using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace shift_xlsx
{
    public partial class Form1 : Form
    {
        Dictionary<string, int[,]> shiftDic = new Dictionary<string, int[,]>();
        /* シフト管理ディクショナリ
         * Key1: string 講師名
         * Key2: int 曜日
         * 曜日はDateTimeのDayOfWeek準拠 (Sunday:0, Saturday:6)
         */
        string name = "";

        public Form1()
        {
            InitializeComponent();

            //日時取得
            //デフォルトで当年次月を選択
            DateTime dtNow = DateTime.Now;

            int dtNow_y = int.Parse(dtNow.ToString("yyyy"));

            for (int i = -2; i <= 3; i++){
                cb_year.Items.Add(dtNow_y + i);
            }

            cb_year.SelectedIndex = 2;

            int dtNow_m = int.Parse(dtNow.ToString("MM"));

            if (dtNow_m == 12){
                cb_year.SelectedIndex ++;
                cb_month.SelectedIndex = 0;
            }
            else cb_month.SelectedIndex = dtNow_m;

            //名前リスト読み込み
            try{
                using(StreamReader sr = new StreamReader("namelist.txt")){
                    string line="";
                    for (int i = 0; i < 4; i++) line = sr.ReadLine();
                    
                    while (line!=null){
                        cb_teacher.Items.Add(line);
                        shiftDic.Add(line, new int[7,6]);
                        for(int i=0; i<7; i++){ //曜日                    
                            for(int j=0;j<6; j++){ //コマ
                                shiftDic[line][i, j] = 0;
                            }
                        }
                        line = sr.ReadLine();
                    }
                }
                
            }
            catch{
                MessageBox.Show(
                    "namelist.txtが存在しません\n"
                     + "バックアップから復元します"
                    , "Error", MessageBoxButtons.OK);

                try{
                    File.Copy("namelist.bkup", "namelist.txt", true);
                    this.Close();
                    Application.Restart();
                    return;
                }
                catch{
                    MessageBox.Show("バックアップファイルが正常に読み込めません\n"
                    + "readme.txtに従って, namelist.txtを作成してください"
                    ,"Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
            }

            //保存済みシフトの読み込み
            try{
                using(StreamReader sr = new StreamReader("shift.dat")){
                    name = sr.ReadLine();
                    while (name != null){
                        for(int i=0; i<7; i++){ //曜日
                            for(int j=0; j<5; j++){
                                shiftDic[name][i, j] = sr.Read()-48;
                            }
                            shiftDic[name][i, 5] = int.Parse(sr.ReadLine());
                        }
                        name = sr.ReadLine();
                    }
                }
            }
            catch{
                MessageBox.Show("shift.datが存在しません\n"
                + "新たに生成します"
                , "Error"
                , MessageBoxButtons.OK);
                
                using(StreamWriter sw = new StreamWriter("shift.dat", false)){
                    foreach(string n in shiftDic.Keys){
                        sw.WriteLine(n);
                        for(int i=0; i<7; i++){
                            sw.WriteLine("000000");
                        }
                    }
                }
            }
            name = "";
        }

        private void tile_click(object sender, EventArgs e)
        {
            //mt: 今のところは2つしか使わないのでこれで
            if (((Button)sender).BackColor == Color.Orange){
                ((Button)sender).BackColor = Color.Azure;
            }
            else ((Button)sender).BackColor = Color.Orange;
        }

        private void Cb_teacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ボタンの有効化(cb_teacher.SelectedItemが空のときボタン押すと例外吐くので
            //ロード時点ではdisabledにしておく)
            btn_save.Enabled = true;
            btn_exp.Enabled = true;

            //ハッシュにデータ格納
            //→メソッド化
            WriteDic();
            
            name = cb_teacher.SelectedItem.ToString();
            int dayOfWeek = 6; //曜日
            int lesOfDay = 5; //コマ
            foreach (Control item in gb_btns.Controls){
                ((Button)item).Enabled = true;
                //mt: 3つ以上の状態を持つならなにか考える
                if (shiftDic[name][dayOfWeek, lesOfDay] == 1){
                    ((Button)item).BackColor = Color.Orange;
                }
                else ((Button)item).BackColor = Color.Azure;

                if (lesOfDay == 0){
                    lesOfDay = 5;
                    dayOfWeek--;
                }
                else lesOfDay--;
            }
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            name = cb_teacher.SelectedItem.ToString();
            WriteDic();
            using(StreamWriter sw = new StreamWriter("shift.dat", false)){
                for(int i=0; i<cb_teacher.Items.Count; i++){
                    string name_s = cb_teacher.Items[i].ToString();
                    sw.WriteLine(name_s);
                    for(int j=0; j<7; j++){ //曜日
                        for(int k=0; k<6; k++){ //コマ
                            sw.Write(shiftDic[name_s][j, k]);
                        }
                        sw.WriteLine();
                    }
                }
            }
            File.Copy("namelist.txt","namelist.bkup",true);
        }

        private void Btn_exp_Click(object sender, EventArgs e)
        {
            name = cb_teacher.SelectedItem.ToString();
            WriteDic();

            DialogResult result = MessageBox.Show
                ("編集内容を保存しますか？","確認", MessageBoxButtons.YesNoCancel);

            switch (result){
                case DialogResult.Yes:
                    Btn_save_Click(sender, e);
                    break;

                case DialogResult.No:
                    break;

                case DialogResult.Cancel:
                    return;
            }

            //年月取得
            int year = int.Parse(cb_year.SelectedItem.ToString());
            int month = int.Parse(cb_month.SelectedItem.ToString());
            int days = DateTime.DaysInMonth(year, month);

            //instanciate
            var book = new XLWorkbook();
            string bookName = "Shift_" + year.ToString() + "_" + month.ToString();
            var sheet = book.Worksheets.Add(bookName);

            //名前リスト
            var range_name = sheet.Range(4,2,80,2); //B4:B80
            range_name.Style.Font.FontName = ("游ゴシック");

            string[] nameAry = new string[shiftDic.Keys.Count];

            //FH
            int row = 7;
            int column = 2;
            int aryi = 0;
            foreach(string teacher in shiftDic.Keys){
                sheet.Cell(row,column).Value = teacher;
                if(teacher[0]=='\''){
                    sheet.Cell(row,column).Style.Font.FontColor = XLColor.Red;
                }
                nameAry[aryi] = teacher;
                aryi++;
                row++;
            }

            //LH
            row += 10;
            foreach (string teacher in shiftDic.Keys){
                sheet.Cell(row, column).Value = teacher;
                if(teacher[0]=='\''){
                    sheet.Cell(row,column).Style.Font.FontColor = XLColor.Red;
                }
                row++;
            }

            sheet.Column(column).Width = 20;
            sheet.Column(column+1).Width = 0.2;

            //日付と曜日
            row = 4;
            column = 4;
            int firstSun = 0;
            char[] lesson = {'A','B','C','D','E','F'};
            for(int date=1; date<=days; date++){
                sheet.Range(row, column, row+1, column+(14*6))
                    .Style.Font.FontName = ("游ゴシック");
                sheet.Range(row, column, row+2, column+(14*6))
                    .Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                
                DateTime dt = new DateTime(year, month, date);
                if(date<=7 && dt.DayOfWeek==0) firstSun = date;

                sheet.Cell(row, column).Value = "'" + month + "/" + date;
                sheet.Range(row, column, row, column+5).Merge(false);
                sheet.Cell(row+1, column).Value = dt.ToString("ddd");
                sheet.Range(row+1, column, row+1, column+5).Merge(false);

                for(int i=0; i<6; i++){
                    sheet.Cell(row+2, column+i).Value = lesson[i];
                    sheet.Column(column+i).Width = 2;
                }
                
                column += 6;

                if(date==14){
                    row = 4 + nameAry.Length + 10;
                    column = 4;
                    sheet.Range(row, column, row+1, column+(14*6))
                        .Style.Font.FontName = ("游ゴシック");
                    sheet.Range(row, column, row+1, column+(14*6))
                        .Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                }
            }

            //罫線
            //FH
            row = 4;
            column = 3;
            for(int i=0; i<=14*6; i++){
                sheet.Range(row, column+i, row+nameAry.Length+7, column+i)
                    .Style.Border.RightBorder = XLBorderStyleValues.Hair;
            }

            for(int i = 0; i<=nameAry.Length+7; i++){
                sheet.Range(row+i, column-1, row+i, column+(14*6))
                    .Style.Border.TopBorder = XLBorderStyleValues.Hair;
            }

            sheet.Range(row, column-1, row+nameAry.Length+7, column-1)
                .Style.Border.RightBorder = XLBorderStyleValues.Thin;

            for(int i=0; i<=14*6; i+=6){                
                sheet.Range(row, column+i, row+nameAry.Length+7, column+i)
                .Style.Border.RightBorder = XLBorderStyleValues.Thin;
            }

            sheet.Range(row+3, column-1, row+3, column+(14*6))
                .Style.Border.TopBorder = XLBorderStyleValues.Double;

            sheet.Range(row, column-1, row+nameAry.Length+7, column+(14*6))
                .Style.Border.OutsideBorder = XLBorderStyleValues.Thick;

            int bcc = 0; //backColorCount
            row += 3;
            while (bcc < nameAry.Length + 5){
                if (bcc%2 == 1) sheet.Range(row+bcc, column-1, row+bcc, column+(14*6))
                        .Style.Fill.BackgroundColor = XLColor.Azure; 
                if ((bcc+1)%5 == 0 && (bcc+1) < nameAry.Length+4) sheet.Range
                        (row+bcc, column-1, row+bcc, column+(14*6))
                        .Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                bcc++;
            }

            //罫線LH
            row = 4 + nameAry.Length + 10;
            for(int i=0; i<=(days-14)*6; i++){
                sheet.Range(row, column+i, row+nameAry.Length+7, column+i)
                    .Style.Border.RightBorder = XLBorderStyleValues.Hair;
            }

            for(int i=0; i<=nameAry.Length+7; i++){
                sheet.Range(row+i, column-1, row+i, column+((days-14)*6))
                    .Style.Border.TopBorder = XLBorderStyleValues.Hair;
            }

            sheet.Range(row, column-1, row+nameAry.Length+7, column-1)
                .Style.Border.RightBorder = XLBorderStyleValues.Thin;

            for(int i=0; i<=(days-14)*6; i+=6){                
                sheet.Range(row, column+i, row+nameAry.Length+7, column+i)
                .Style.Border.RightBorder = XLBorderStyleValues.Thin;
            }

            sheet.Range(row+3, column-1, row+3, column+((days-14)*6))
                .Style.Border.TopBorder = XLBorderStyleValues.Double;

            sheet.Range(row, column-1, row+nameAry.Length+7, column+((days-14)*6))
                .Style.Border.OutsideBorder = XLBorderStyleValues.Thick;

            bcc = 0;
            row += 3;
            while (bcc < nameAry.Length + 5){
                if (bcc%2 == 1) sheet.Range(row+bcc, column-1, row+bcc, column+((days-14)*6))
                        .Style.Fill.BackgroundColor = XLColor.Azure; 
                if ((bcc+1)%5 == 0 && (bcc+1) < nameAry.Length+4) sheet.Range
                        (row+bcc, column-1, row+bcc, column+((days-14)*6))
                        .Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                bcc++;
            }

            //シフト出力
            //FH
            row = 7;
            column = 4;
            for(int i=0; i<nameAry.Length; i++){
                for (int date=1; date<=14; date++){

                        DateTime dt = new DateTime(year, month, date);
                        int dow = (int)dt.DayOfWeek;
                    
                    for (int k=0; k<6; k++){
                        sheet.Cell(row+i, column+6*(date-1)+k)
                            .Value = shiftDic[nameAry[i]][dow,k];
                    }
                }
            }

            //LH
            row = 7 + nameAry.Length + 10;
            for(int i=0; i<nameAry.Length; i++){
                for (int date=15; date<=days; date++){

                        DateTime dt = new DateTime(year, month, date);
                        int dow = (int)dt.DayOfWeek;
                    
                    for (int k=0; k<6; k++){
                        sheet.Cell(row+i, column+6*(date-15)+k)
                            .Value = shiftDic[nameAry[i]][dow,k];
                    }
                }
            }

            //色塗り
            //FH
            row = 7;
            column = 4;
            //奇数行　背景White
            for(int i=0; i<nameAry.Length+5; i+=2){
                sheet.Range(row+i, column, row+i, column+6*14-1)
                    .AddConditionalFormat().WhenEquals(0)
                    .Fill.SetBackgroundColor(XLColor.White)
                    .Font.SetFontColor(XLColor.White);

                sheet.Range(row+i, column, row+i, column+6*14-1)
                    .AddConditionalFormat().WhenEquals(1)
                    .Fill.SetBackgroundColor(XLColor.Orange)
                    .Font.SetFontColor(XLColor.Orange);
            }
            //偶数行　背景Azure
            for(int i=1; i<nameAry.Length+5; i+=2){
                sheet.Range(row+i, column, row+i, column+6*14-1)
                    .AddConditionalFormat().WhenEquals(0)
                    .Fill.SetBackgroundColor(XLColor.Azure)
                    .Font.SetFontColor(XLColor.Azure);

                sheet.Range(row+i, column, row+i, column+6*14-1)
                    .AddConditionalFormat().WhenEquals(1)
                    .Fill.SetBackgroundColor(XLColor.Orange)
                    .Font.SetFontColor(XLColor.Orange);
            }

            //LH
            row = 7 + nameAry.Length + 10;
            for(int i=0; i<nameAry.Length+5; i+=2){
                sheet.Range(row+i, column, row+i, column+6*(days-14)-1)
                    .AddConditionalFormat().WhenEquals(0)
                    .Fill.SetBackgroundColor(XLColor.White)
                    .Font.SetFontColor(XLColor.White);

                sheet.Range(row+i, column, row+i, column+6*(days-14)-1)
                    .AddConditionalFormat().WhenEquals(1)
                    .Fill.SetBackgroundColor(XLColor.Orange)
                    .Font.SetFontColor(XLColor.Orange);
            }
            //偶数行　背景Azure
            for(int i=1; i<nameAry.Length+5; i+=2){
                sheet.Range(row+i, column, row+i, column+6*(days-14)-1)
                    .AddConditionalFormat().WhenEquals(0)
                    .Fill.SetBackgroundColor(XLColor.Azure)
                    .Font.SetFontColor(XLColor.Azure);

                sheet.Range(row+i, column, row+i, column+6*(days-14)-1)
                    .AddConditionalFormat().WhenEquals(1)
                    .Fill.SetBackgroundColor(XLColor.Orange)
                    .Font.SetFontColor(XLColor.Orange);
            }

            try{
                book.SaveAs(@"Output\" + year + "_" + month + ".xlsx");

                using (Process p = new Process()){
                    p.StartInfo.FileName
                        = @"Output\"+ year + "_" + month + ".xlsx";
                    p.Start();
                }
            }

            catch{
                string sheetName = year + "_" + month + ".xlsx";
                MessageBox.Show(
                    "使用中のファイルにはアクセスできません\n"
                     + sheetName 
                     + "を閉じてから再度実行してください"
                    ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WriteDic()
        {
            int dayOfWeek = 6; //曜日
            int lesOfDay = 5; //コマ

            if (name == "") return;

            foreach (Control item in gb_btns.Controls){
                //mt: 3つ以上の状態を持つならなにか考える
                if (item.BackColor == Color.Orange){
                    shiftDic[name][dayOfWeek, lesOfDay] = 1;
                }
                else shiftDic[name][dayOfWeek, lesOfDay] = 0;

                if (lesOfDay == 0){
                    lesOfDay = 5;
                    dayOfWeek--;
                }
                else lesOfDay--;
            }
        }
    }
}
