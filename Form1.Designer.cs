namespace shift_xlsx
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_year = new System.Windows.Forms.ComboBox();
            this.cb_month = new System.Windows.Forms.ComboBox();
            this.cb_teacher = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_btns = new System.Windows.Forms.GroupBox();
            this.btn_satF = new System.Windows.Forms.Button();
            this.btn_satE = new System.Windows.Forms.Button();
            this.btn_satD = new System.Windows.Forms.Button();
            this.btn_satC = new System.Windows.Forms.Button();
            this.btn_satB = new System.Windows.Forms.Button();
            this.btn_satA = new System.Windows.Forms.Button();
            this.btn_friF = new System.Windows.Forms.Button();
            this.btn_friE = new System.Windows.Forms.Button();
            this.btn_friD = new System.Windows.Forms.Button();
            this.btn_friC = new System.Windows.Forms.Button();
            this.btn_friB = new System.Windows.Forms.Button();
            this.btn_friA = new System.Windows.Forms.Button();
            this.btn_thuF = new System.Windows.Forms.Button();
            this.btn_thuE = new System.Windows.Forms.Button();
            this.btn_thuD = new System.Windows.Forms.Button();
            this.btn_thuC = new System.Windows.Forms.Button();
            this.btn_thuB = new System.Windows.Forms.Button();
            this.btn_thuA = new System.Windows.Forms.Button();
            this.btn_wedF = new System.Windows.Forms.Button();
            this.btn_wedE = new System.Windows.Forms.Button();
            this.btn_wedD = new System.Windows.Forms.Button();
            this.btn_wedC = new System.Windows.Forms.Button();
            this.btn_wedB = new System.Windows.Forms.Button();
            this.btn_wedA = new System.Windows.Forms.Button();
            this.btn_tueF = new System.Windows.Forms.Button();
            this.btn_tueE = new System.Windows.Forms.Button();
            this.btn_tueD = new System.Windows.Forms.Button();
            this.btn_tueC = new System.Windows.Forms.Button();
            this.btn_tueB = new System.Windows.Forms.Button();
            this.btn_tueA = new System.Windows.Forms.Button();
            this.btn_monF = new System.Windows.Forms.Button();
            this.btn_monE = new System.Windows.Forms.Button();
            this.btn_monD = new System.Windows.Forms.Button();
            this.btn_monC = new System.Windows.Forms.Button();
            this.btn_monB = new System.Windows.Forms.Button();
            this.btn_monA = new System.Windows.Forms.Button();
            this.btn_sunF = new System.Windows.Forms.Button();
            this.btn_sunE = new System.Windows.Forms.Button();
            this.btn_sunD = new System.Windows.Forms.Button();
            this.btn_sunC = new System.Windows.Forms.Button();
            this.btn_sunB = new System.Windows.Forms.Button();
            this.btn_sunA = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_exp = new System.Windows.Forms.Button();
            this.gb_btns.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_year
            // 
            this.cb_year.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cb_year.FormattingEnabled = true;
            this.cb_year.Location = new System.Drawing.Point(33, 23);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(97, 33);
            this.cb_year.TabIndex = 0;
            // 
            // cb_month
            // 
            this.cb_month.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cb_month.FormattingEnabled = true;
            this.cb_month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb_month.Location = new System.Drawing.Point(187, 23);
            this.cb_month.Name = "cb_month";
            this.cb_month.Size = new System.Drawing.Size(57, 33);
            this.cb_month.TabIndex = 1;
            // 
            // cb_teacher
            // 
            this.cb_teacher.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cb_teacher.FormattingEnabled = true;
            this.cb_teacher.Location = new System.Drawing.Point(108, 85);
            this.cb_teacher.Name = "cb_teacher";
            this.cb_teacher.Size = new System.Drawing.Size(168, 33);
            this.cb_teacher.TabIndex = 4;
            this.cb_teacher.SelectedIndexChanged += new System.EventHandler(this.Cb_teacher_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(136, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(250, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "月分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(37, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "講師";
            // 
            // gb_btns
            // 
            this.gb_btns.Controls.Add(this.btn_satF);
            this.gb_btns.Controls.Add(this.btn_satE);
            this.gb_btns.Controls.Add(this.btn_satD);
            this.gb_btns.Controls.Add(this.btn_satC);
            this.gb_btns.Controls.Add(this.btn_satB);
            this.gb_btns.Controls.Add(this.btn_satA);
            this.gb_btns.Controls.Add(this.btn_friF);
            this.gb_btns.Controls.Add(this.btn_friE);
            this.gb_btns.Controls.Add(this.btn_friD);
            this.gb_btns.Controls.Add(this.btn_friC);
            this.gb_btns.Controls.Add(this.btn_friB);
            this.gb_btns.Controls.Add(this.btn_friA);
            this.gb_btns.Controls.Add(this.btn_thuF);
            this.gb_btns.Controls.Add(this.btn_thuE);
            this.gb_btns.Controls.Add(this.btn_thuD);
            this.gb_btns.Controls.Add(this.btn_thuC);
            this.gb_btns.Controls.Add(this.btn_thuB);
            this.gb_btns.Controls.Add(this.btn_thuA);
            this.gb_btns.Controls.Add(this.btn_wedF);
            this.gb_btns.Controls.Add(this.btn_wedE);
            this.gb_btns.Controls.Add(this.btn_wedD);
            this.gb_btns.Controls.Add(this.btn_wedC);
            this.gb_btns.Controls.Add(this.btn_wedB);
            this.gb_btns.Controls.Add(this.btn_wedA);
            this.gb_btns.Controls.Add(this.btn_tueF);
            this.gb_btns.Controls.Add(this.btn_tueE);
            this.gb_btns.Controls.Add(this.btn_tueD);
            this.gb_btns.Controls.Add(this.btn_tueC);
            this.gb_btns.Controls.Add(this.btn_tueB);
            this.gb_btns.Controls.Add(this.btn_tueA);
            this.gb_btns.Controls.Add(this.btn_monF);
            this.gb_btns.Controls.Add(this.btn_monE);
            this.gb_btns.Controls.Add(this.btn_monD);
            this.gb_btns.Controls.Add(this.btn_monC);
            this.gb_btns.Controls.Add(this.btn_monB);
            this.gb_btns.Controls.Add(this.btn_monA);
            this.gb_btns.Controls.Add(this.btn_sunF);
            this.gb_btns.Controls.Add(this.btn_sunE);
            this.gb_btns.Controls.Add(this.btn_sunD);
            this.gb_btns.Controls.Add(this.btn_sunC);
            this.gb_btns.Controls.Add(this.btn_sunB);
            this.gb_btns.Controls.Add(this.btn_sunA);
            this.gb_btns.Location = new System.Drawing.Point(33, 184);
            this.gb_btns.Name = "gb_btns";
            this.gb_btns.Size = new System.Drawing.Size(681, 285);
            this.gb_btns.TabIndex = 55;
            this.gb_btns.TabStop = false;
            // 
            // btn_satF
            // 
            this.btn_satF.BackColor = System.Drawing.Color.Azure;
            this.btn_satF.Enabled = false;
            this.btn_satF.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_satF.FlatAppearance.BorderSize = 0;
            this.btn_satF.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_satF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_satF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_satF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_satF.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_satF.Location = new System.Drawing.Point(577, 233);
            this.btn_satF.Name = "btn_satF";
            this.btn_satF.Size = new System.Drawing.Size(97, 46);
            this.btn_satF.TabIndex = 90;
            this.btn_satF.Text = "F";
            this.btn_satF.UseVisualStyleBackColor = false;
            this.btn_satF.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_satE
            // 
            this.btn_satE.BackColor = System.Drawing.Color.Azure;
            this.btn_satE.Enabled = false;
            this.btn_satE.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_satE.FlatAppearance.BorderSize = 0;
            this.btn_satE.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_satE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_satE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_satE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_satE.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_satE.Location = new System.Drawing.Point(577, 189);
            this.btn_satE.Name = "btn_satE";
            this.btn_satE.Size = new System.Drawing.Size(97, 46);
            this.btn_satE.TabIndex = 89;
            this.btn_satE.Text = "E";
            this.btn_satE.UseVisualStyleBackColor = false;
            this.btn_satE.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_satD
            // 
            this.btn_satD.BackColor = System.Drawing.Color.Azure;
            this.btn_satD.Enabled = false;
            this.btn_satD.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_satD.FlatAppearance.BorderSize = 0;
            this.btn_satD.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_satD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_satD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_satD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_satD.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_satD.Location = new System.Drawing.Point(577, 145);
            this.btn_satD.Name = "btn_satD";
            this.btn_satD.Size = new System.Drawing.Size(97, 46);
            this.btn_satD.TabIndex = 88;
            this.btn_satD.Text = "D";
            this.btn_satD.UseVisualStyleBackColor = false;
            this.btn_satD.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_satC
            // 
            this.btn_satC.BackColor = System.Drawing.Color.Azure;
            this.btn_satC.Enabled = false;
            this.btn_satC.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_satC.FlatAppearance.BorderSize = 0;
            this.btn_satC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_satC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_satC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_satC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_satC.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_satC.Location = new System.Drawing.Point(577, 101);
            this.btn_satC.Name = "btn_satC";
            this.btn_satC.Size = new System.Drawing.Size(97, 46);
            this.btn_satC.TabIndex = 87;
            this.btn_satC.Text = "C";
            this.btn_satC.UseVisualStyleBackColor = false;
            this.btn_satC.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_satB
            // 
            this.btn_satB.BackColor = System.Drawing.Color.Azure;
            this.btn_satB.Enabled = false;
            this.btn_satB.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_satB.FlatAppearance.BorderSize = 0;
            this.btn_satB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_satB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_satB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_satB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_satB.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_satB.Location = new System.Drawing.Point(577, 57);
            this.btn_satB.Name = "btn_satB";
            this.btn_satB.Size = new System.Drawing.Size(97, 46);
            this.btn_satB.TabIndex = 86;
            this.btn_satB.Text = "B";
            this.btn_satB.UseVisualStyleBackColor = false;
            this.btn_satB.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_satA
            // 
            this.btn_satA.BackColor = System.Drawing.Color.Azure;
            this.btn_satA.Enabled = false;
            this.btn_satA.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_satA.FlatAppearance.BorderSize = 0;
            this.btn_satA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_satA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_satA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_satA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_satA.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_satA.Location = new System.Drawing.Point(577, 13);
            this.btn_satA.Name = "btn_satA";
            this.btn_satA.Size = new System.Drawing.Size(97, 46);
            this.btn_satA.TabIndex = 85;
            this.btn_satA.Text = "A";
            this.btn_satA.UseVisualStyleBackColor = false;
            this.btn_satA.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_friF
            // 
            this.btn_friF.BackColor = System.Drawing.Color.Azure;
            this.btn_friF.Enabled = false;
            this.btn_friF.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_friF.FlatAppearance.BorderSize = 0;
            this.btn_friF.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_friF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_friF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_friF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_friF.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_friF.Location = new System.Drawing.Point(482, 233);
            this.btn_friF.Name = "btn_friF";
            this.btn_friF.Size = new System.Drawing.Size(97, 46);
            this.btn_friF.TabIndex = 84;
            this.btn_friF.Text = "F";
            this.btn_friF.UseVisualStyleBackColor = false;
            this.btn_friF.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_friE
            // 
            this.btn_friE.BackColor = System.Drawing.Color.Azure;
            this.btn_friE.Enabled = false;
            this.btn_friE.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_friE.FlatAppearance.BorderSize = 0;
            this.btn_friE.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_friE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_friE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_friE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_friE.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_friE.Location = new System.Drawing.Point(482, 189);
            this.btn_friE.Name = "btn_friE";
            this.btn_friE.Size = new System.Drawing.Size(97, 46);
            this.btn_friE.TabIndex = 83;
            this.btn_friE.Text = "E";
            this.btn_friE.UseVisualStyleBackColor = false;
            this.btn_friE.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_friD
            // 
            this.btn_friD.BackColor = System.Drawing.Color.Azure;
            this.btn_friD.Enabled = false;
            this.btn_friD.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_friD.FlatAppearance.BorderSize = 0;
            this.btn_friD.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_friD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_friD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_friD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_friD.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_friD.Location = new System.Drawing.Point(482, 145);
            this.btn_friD.Name = "btn_friD";
            this.btn_friD.Size = new System.Drawing.Size(97, 46);
            this.btn_friD.TabIndex = 82;
            this.btn_friD.Text = "D";
            this.btn_friD.UseVisualStyleBackColor = false;
            this.btn_friD.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_friC
            // 
            this.btn_friC.BackColor = System.Drawing.Color.Azure;
            this.btn_friC.Enabled = false;
            this.btn_friC.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_friC.FlatAppearance.BorderSize = 0;
            this.btn_friC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_friC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_friC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_friC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_friC.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_friC.Location = new System.Drawing.Point(482, 101);
            this.btn_friC.Name = "btn_friC";
            this.btn_friC.Size = new System.Drawing.Size(97, 46);
            this.btn_friC.TabIndex = 81;
            this.btn_friC.Text = "C";
            this.btn_friC.UseVisualStyleBackColor = false;
            this.btn_friC.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_friB
            // 
            this.btn_friB.BackColor = System.Drawing.Color.Azure;
            this.btn_friB.Enabled = false;
            this.btn_friB.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_friB.FlatAppearance.BorderSize = 0;
            this.btn_friB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_friB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_friB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_friB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_friB.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_friB.Location = new System.Drawing.Point(482, 57);
            this.btn_friB.Name = "btn_friB";
            this.btn_friB.Size = new System.Drawing.Size(97, 46);
            this.btn_friB.TabIndex = 80;
            this.btn_friB.Text = "B";
            this.btn_friB.UseVisualStyleBackColor = false;
            this.btn_friB.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_friA
            // 
            this.btn_friA.BackColor = System.Drawing.Color.Azure;
            this.btn_friA.Enabled = false;
            this.btn_friA.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_friA.FlatAppearance.BorderSize = 0;
            this.btn_friA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_friA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_friA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_friA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_friA.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_friA.Location = new System.Drawing.Point(482, 13);
            this.btn_friA.Name = "btn_friA";
            this.btn_friA.Size = new System.Drawing.Size(97, 46);
            this.btn_friA.TabIndex = 79;
            this.btn_friA.Text = "A";
            this.btn_friA.UseVisualStyleBackColor = false;
            this.btn_friA.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_thuF
            // 
            this.btn_thuF.BackColor = System.Drawing.Color.Azure;
            this.btn_thuF.Enabled = false;
            this.btn_thuF.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_thuF.FlatAppearance.BorderSize = 0;
            this.btn_thuF.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_thuF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_thuF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_thuF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thuF.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_thuF.Location = new System.Drawing.Point(387, 233);
            this.btn_thuF.Name = "btn_thuF";
            this.btn_thuF.Size = new System.Drawing.Size(97, 46);
            this.btn_thuF.TabIndex = 78;
            this.btn_thuF.Text = "F";
            this.btn_thuF.UseVisualStyleBackColor = false;
            this.btn_thuF.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_thuE
            // 
            this.btn_thuE.BackColor = System.Drawing.Color.Azure;
            this.btn_thuE.Enabled = false;
            this.btn_thuE.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_thuE.FlatAppearance.BorderSize = 0;
            this.btn_thuE.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_thuE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_thuE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_thuE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thuE.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_thuE.Location = new System.Drawing.Point(387, 189);
            this.btn_thuE.Name = "btn_thuE";
            this.btn_thuE.Size = new System.Drawing.Size(97, 46);
            this.btn_thuE.TabIndex = 77;
            this.btn_thuE.Text = "E";
            this.btn_thuE.UseVisualStyleBackColor = false;
            this.btn_thuE.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_thuD
            // 
            this.btn_thuD.BackColor = System.Drawing.Color.Azure;
            this.btn_thuD.Enabled = false;
            this.btn_thuD.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_thuD.FlatAppearance.BorderSize = 0;
            this.btn_thuD.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_thuD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_thuD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_thuD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thuD.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_thuD.Location = new System.Drawing.Point(387, 145);
            this.btn_thuD.Name = "btn_thuD";
            this.btn_thuD.Size = new System.Drawing.Size(97, 46);
            this.btn_thuD.TabIndex = 76;
            this.btn_thuD.Text = "D";
            this.btn_thuD.UseVisualStyleBackColor = false;
            this.btn_thuD.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_thuC
            // 
            this.btn_thuC.BackColor = System.Drawing.Color.Azure;
            this.btn_thuC.Enabled = false;
            this.btn_thuC.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_thuC.FlatAppearance.BorderSize = 0;
            this.btn_thuC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_thuC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_thuC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_thuC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thuC.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_thuC.Location = new System.Drawing.Point(387, 101);
            this.btn_thuC.Name = "btn_thuC";
            this.btn_thuC.Size = new System.Drawing.Size(97, 46);
            this.btn_thuC.TabIndex = 75;
            this.btn_thuC.Text = "C";
            this.btn_thuC.UseVisualStyleBackColor = false;
            this.btn_thuC.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_thuB
            // 
            this.btn_thuB.BackColor = System.Drawing.Color.Azure;
            this.btn_thuB.Enabled = false;
            this.btn_thuB.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_thuB.FlatAppearance.BorderSize = 0;
            this.btn_thuB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_thuB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_thuB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_thuB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thuB.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_thuB.Location = new System.Drawing.Point(387, 57);
            this.btn_thuB.Name = "btn_thuB";
            this.btn_thuB.Size = new System.Drawing.Size(97, 46);
            this.btn_thuB.TabIndex = 74;
            this.btn_thuB.Text = "B";
            this.btn_thuB.UseVisualStyleBackColor = false;
            this.btn_thuB.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_thuA
            // 
            this.btn_thuA.BackColor = System.Drawing.Color.Azure;
            this.btn_thuA.Enabled = false;
            this.btn_thuA.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_thuA.FlatAppearance.BorderSize = 0;
            this.btn_thuA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_thuA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_thuA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_thuA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thuA.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_thuA.Location = new System.Drawing.Point(387, 13);
            this.btn_thuA.Name = "btn_thuA";
            this.btn_thuA.Size = new System.Drawing.Size(97, 46);
            this.btn_thuA.TabIndex = 73;
            this.btn_thuA.Text = "A";
            this.btn_thuA.UseVisualStyleBackColor = false;
            this.btn_thuA.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_wedF
            // 
            this.btn_wedF.BackColor = System.Drawing.Color.Azure;
            this.btn_wedF.Enabled = false;
            this.btn_wedF.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_wedF.FlatAppearance.BorderSize = 0;
            this.btn_wedF.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_wedF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_wedF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_wedF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wedF.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_wedF.Location = new System.Drawing.Point(292, 233);
            this.btn_wedF.Name = "btn_wedF";
            this.btn_wedF.Size = new System.Drawing.Size(97, 46);
            this.btn_wedF.TabIndex = 72;
            this.btn_wedF.Text = "F";
            this.btn_wedF.UseVisualStyleBackColor = false;
            this.btn_wedF.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_wedE
            // 
            this.btn_wedE.BackColor = System.Drawing.Color.Azure;
            this.btn_wedE.Enabled = false;
            this.btn_wedE.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_wedE.FlatAppearance.BorderSize = 0;
            this.btn_wedE.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_wedE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_wedE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_wedE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wedE.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_wedE.Location = new System.Drawing.Point(292, 189);
            this.btn_wedE.Name = "btn_wedE";
            this.btn_wedE.Size = new System.Drawing.Size(97, 46);
            this.btn_wedE.TabIndex = 71;
            this.btn_wedE.Text = "E";
            this.btn_wedE.UseVisualStyleBackColor = false;
            this.btn_wedE.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_wedD
            // 
            this.btn_wedD.BackColor = System.Drawing.Color.Azure;
            this.btn_wedD.Enabled = false;
            this.btn_wedD.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_wedD.FlatAppearance.BorderSize = 0;
            this.btn_wedD.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_wedD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_wedD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_wedD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wedD.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_wedD.Location = new System.Drawing.Point(292, 145);
            this.btn_wedD.Name = "btn_wedD";
            this.btn_wedD.Size = new System.Drawing.Size(97, 46);
            this.btn_wedD.TabIndex = 70;
            this.btn_wedD.Text = "D";
            this.btn_wedD.UseVisualStyleBackColor = false;
            this.btn_wedD.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_wedC
            // 
            this.btn_wedC.BackColor = System.Drawing.Color.Azure;
            this.btn_wedC.Enabled = false;
            this.btn_wedC.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_wedC.FlatAppearance.BorderSize = 0;
            this.btn_wedC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_wedC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_wedC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_wedC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wedC.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_wedC.Location = new System.Drawing.Point(292, 101);
            this.btn_wedC.Name = "btn_wedC";
            this.btn_wedC.Size = new System.Drawing.Size(97, 46);
            this.btn_wedC.TabIndex = 69;
            this.btn_wedC.Text = "C";
            this.btn_wedC.UseVisualStyleBackColor = false;
            this.btn_wedC.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_wedB
            // 
            this.btn_wedB.BackColor = System.Drawing.Color.Azure;
            this.btn_wedB.Enabled = false;
            this.btn_wedB.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_wedB.FlatAppearance.BorderSize = 0;
            this.btn_wedB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_wedB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_wedB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_wedB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wedB.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_wedB.Location = new System.Drawing.Point(292, 57);
            this.btn_wedB.Name = "btn_wedB";
            this.btn_wedB.Size = new System.Drawing.Size(97, 46);
            this.btn_wedB.TabIndex = 68;
            this.btn_wedB.Text = "B";
            this.btn_wedB.UseVisualStyleBackColor = false;
            this.btn_wedB.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_wedA
            // 
            this.btn_wedA.BackColor = System.Drawing.Color.Azure;
            this.btn_wedA.Enabled = false;
            this.btn_wedA.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_wedA.FlatAppearance.BorderSize = 0;
            this.btn_wedA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_wedA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_wedA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_wedA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wedA.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_wedA.Location = new System.Drawing.Point(292, 13);
            this.btn_wedA.Name = "btn_wedA";
            this.btn_wedA.Size = new System.Drawing.Size(97, 46);
            this.btn_wedA.TabIndex = 67;
            this.btn_wedA.Text = "A";
            this.btn_wedA.UseVisualStyleBackColor = false;
            this.btn_wedA.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_tueF
            // 
            this.btn_tueF.BackColor = System.Drawing.Color.Azure;
            this.btn_tueF.Enabled = false;
            this.btn_tueF.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_tueF.FlatAppearance.BorderSize = 0;
            this.btn_tueF.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_tueF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_tueF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_tueF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tueF.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_tueF.Location = new System.Drawing.Point(197, 233);
            this.btn_tueF.Name = "btn_tueF";
            this.btn_tueF.Size = new System.Drawing.Size(97, 46);
            this.btn_tueF.TabIndex = 66;
            this.btn_tueF.Text = "F";
            this.btn_tueF.UseVisualStyleBackColor = false;
            this.btn_tueF.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_tueE
            // 
            this.btn_tueE.BackColor = System.Drawing.Color.Azure;
            this.btn_tueE.Enabled = false;
            this.btn_tueE.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_tueE.FlatAppearance.BorderSize = 0;
            this.btn_tueE.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_tueE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_tueE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_tueE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tueE.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_tueE.Location = new System.Drawing.Point(197, 189);
            this.btn_tueE.Name = "btn_tueE";
            this.btn_tueE.Size = new System.Drawing.Size(97, 46);
            this.btn_tueE.TabIndex = 65;
            this.btn_tueE.Text = "E";
            this.btn_tueE.UseVisualStyleBackColor = false;
            this.btn_tueE.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_tueD
            // 
            this.btn_tueD.BackColor = System.Drawing.Color.Azure;
            this.btn_tueD.Enabled = false;
            this.btn_tueD.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_tueD.FlatAppearance.BorderSize = 0;
            this.btn_tueD.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_tueD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_tueD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_tueD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tueD.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_tueD.Location = new System.Drawing.Point(197, 145);
            this.btn_tueD.Name = "btn_tueD";
            this.btn_tueD.Size = new System.Drawing.Size(97, 46);
            this.btn_tueD.TabIndex = 64;
            this.btn_tueD.Text = "D";
            this.btn_tueD.UseVisualStyleBackColor = false;
            this.btn_tueD.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_tueC
            // 
            this.btn_tueC.BackColor = System.Drawing.Color.Azure;
            this.btn_tueC.Enabled = false;
            this.btn_tueC.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_tueC.FlatAppearance.BorderSize = 0;
            this.btn_tueC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_tueC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_tueC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_tueC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tueC.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_tueC.Location = new System.Drawing.Point(197, 101);
            this.btn_tueC.Name = "btn_tueC";
            this.btn_tueC.Size = new System.Drawing.Size(97, 46);
            this.btn_tueC.TabIndex = 63;
            this.btn_tueC.Text = "C";
            this.btn_tueC.UseVisualStyleBackColor = false;
            this.btn_tueC.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_tueB
            // 
            this.btn_tueB.BackColor = System.Drawing.Color.Azure;
            this.btn_tueB.Enabled = false;
            this.btn_tueB.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_tueB.FlatAppearance.BorderSize = 0;
            this.btn_tueB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_tueB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_tueB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_tueB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tueB.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_tueB.Location = new System.Drawing.Point(197, 57);
            this.btn_tueB.Name = "btn_tueB";
            this.btn_tueB.Size = new System.Drawing.Size(97, 46);
            this.btn_tueB.TabIndex = 62;
            this.btn_tueB.Text = "B";
            this.btn_tueB.UseVisualStyleBackColor = false;
            this.btn_tueB.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_tueA
            // 
            this.btn_tueA.BackColor = System.Drawing.Color.Azure;
            this.btn_tueA.Enabled = false;
            this.btn_tueA.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_tueA.FlatAppearance.BorderSize = 0;
            this.btn_tueA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_tueA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_tueA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_tueA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tueA.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_tueA.Location = new System.Drawing.Point(197, 13);
            this.btn_tueA.Name = "btn_tueA";
            this.btn_tueA.Size = new System.Drawing.Size(97, 46);
            this.btn_tueA.TabIndex = 61;
            this.btn_tueA.Text = "A";
            this.btn_tueA.UseVisualStyleBackColor = false;
            this.btn_tueA.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_monF
            // 
            this.btn_monF.BackColor = System.Drawing.Color.Azure;
            this.btn_monF.Enabled = false;
            this.btn_monF.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_monF.FlatAppearance.BorderSize = 0;
            this.btn_monF.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_monF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_monF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_monF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_monF.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_monF.Location = new System.Drawing.Point(102, 233);
            this.btn_monF.Name = "btn_monF";
            this.btn_monF.Size = new System.Drawing.Size(97, 46);
            this.btn_monF.TabIndex = 60;
            this.btn_monF.Text = "F";
            this.btn_monF.UseVisualStyleBackColor = false;
            this.btn_monF.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_monE
            // 
            this.btn_monE.BackColor = System.Drawing.Color.Azure;
            this.btn_monE.Enabled = false;
            this.btn_monE.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_monE.FlatAppearance.BorderSize = 0;
            this.btn_monE.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_monE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_monE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_monE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_monE.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_monE.Location = new System.Drawing.Point(102, 189);
            this.btn_monE.Name = "btn_monE";
            this.btn_monE.Size = new System.Drawing.Size(97, 46);
            this.btn_monE.TabIndex = 59;
            this.btn_monE.Text = "E";
            this.btn_monE.UseVisualStyleBackColor = false;
            this.btn_monE.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_monD
            // 
            this.btn_monD.BackColor = System.Drawing.Color.Azure;
            this.btn_monD.Enabled = false;
            this.btn_monD.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_monD.FlatAppearance.BorderSize = 0;
            this.btn_monD.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_monD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_monD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_monD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_monD.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_monD.Location = new System.Drawing.Point(102, 145);
            this.btn_monD.Name = "btn_monD";
            this.btn_monD.Size = new System.Drawing.Size(97, 46);
            this.btn_monD.TabIndex = 58;
            this.btn_monD.Text = "D";
            this.btn_monD.UseVisualStyleBackColor = false;
            this.btn_monD.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_monC
            // 
            this.btn_monC.BackColor = System.Drawing.Color.Azure;
            this.btn_monC.Enabled = false;
            this.btn_monC.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_monC.FlatAppearance.BorderSize = 0;
            this.btn_monC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_monC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_monC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_monC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_monC.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_monC.Location = new System.Drawing.Point(102, 101);
            this.btn_monC.Name = "btn_monC";
            this.btn_monC.Size = new System.Drawing.Size(97, 46);
            this.btn_monC.TabIndex = 57;
            this.btn_monC.Text = "C";
            this.btn_monC.UseVisualStyleBackColor = false;
            this.btn_monC.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_monB
            // 
            this.btn_monB.BackColor = System.Drawing.Color.Azure;
            this.btn_monB.Enabled = false;
            this.btn_monB.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_monB.FlatAppearance.BorderSize = 0;
            this.btn_monB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_monB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_monB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_monB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_monB.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_monB.Location = new System.Drawing.Point(102, 57);
            this.btn_monB.Name = "btn_monB";
            this.btn_monB.Size = new System.Drawing.Size(97, 46);
            this.btn_monB.TabIndex = 56;
            this.btn_monB.Text = "B";
            this.btn_monB.UseVisualStyleBackColor = false;
            this.btn_monB.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_monA
            // 
            this.btn_monA.BackColor = System.Drawing.Color.Azure;
            this.btn_monA.Enabled = false;
            this.btn_monA.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_monA.FlatAppearance.BorderSize = 0;
            this.btn_monA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_monA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_monA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_monA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_monA.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_monA.Location = new System.Drawing.Point(102, 13);
            this.btn_monA.Name = "btn_monA";
            this.btn_monA.Size = new System.Drawing.Size(97, 46);
            this.btn_monA.TabIndex = 55;
            this.btn_monA.Text = "A";
            this.btn_monA.UseVisualStyleBackColor = false;
            this.btn_monA.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_sunF
            // 
            this.btn_sunF.BackColor = System.Drawing.Color.Azure;
            this.btn_sunF.Enabled = false;
            this.btn_sunF.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_sunF.FlatAppearance.BorderSize = 0;
            this.btn_sunF.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_sunF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_sunF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_sunF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sunF.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_sunF.Location = new System.Drawing.Point(7, 233);
            this.btn_sunF.Name = "btn_sunF";
            this.btn_sunF.Size = new System.Drawing.Size(97, 46);
            this.btn_sunF.TabIndex = 11;
            this.btn_sunF.Text = "F";
            this.btn_sunF.UseVisualStyleBackColor = false;
            this.btn_sunF.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_sunE
            // 
            this.btn_sunE.BackColor = System.Drawing.Color.Azure;
            this.btn_sunE.Enabled = false;
            this.btn_sunE.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_sunE.FlatAppearance.BorderSize = 0;
            this.btn_sunE.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_sunE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_sunE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_sunE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sunE.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_sunE.Location = new System.Drawing.Point(7, 189);
            this.btn_sunE.Name = "btn_sunE";
            this.btn_sunE.Size = new System.Drawing.Size(97, 46);
            this.btn_sunE.TabIndex = 10;
            this.btn_sunE.Text = "E";
            this.btn_sunE.UseVisualStyleBackColor = false;
            this.btn_sunE.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_sunD
            // 
            this.btn_sunD.BackColor = System.Drawing.Color.Azure;
            this.btn_sunD.Enabled = false;
            this.btn_sunD.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_sunD.FlatAppearance.BorderSize = 0;
            this.btn_sunD.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_sunD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_sunD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_sunD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sunD.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_sunD.Location = new System.Drawing.Point(7, 145);
            this.btn_sunD.Name = "btn_sunD";
            this.btn_sunD.Size = new System.Drawing.Size(97, 46);
            this.btn_sunD.TabIndex = 9;
            this.btn_sunD.Text = "D";
            this.btn_sunD.UseVisualStyleBackColor = false;
            this.btn_sunD.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_sunC
            // 
            this.btn_sunC.BackColor = System.Drawing.Color.Azure;
            this.btn_sunC.Enabled = false;
            this.btn_sunC.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_sunC.FlatAppearance.BorderSize = 0;
            this.btn_sunC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_sunC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_sunC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_sunC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sunC.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_sunC.Location = new System.Drawing.Point(7, 101);
            this.btn_sunC.Name = "btn_sunC";
            this.btn_sunC.Size = new System.Drawing.Size(97, 46);
            this.btn_sunC.TabIndex = 8;
            this.btn_sunC.Text = "C";
            this.btn_sunC.UseVisualStyleBackColor = false;
            this.btn_sunC.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_sunB
            // 
            this.btn_sunB.BackColor = System.Drawing.Color.Azure;
            this.btn_sunB.Enabled = false;
            this.btn_sunB.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_sunB.FlatAppearance.BorderSize = 0;
            this.btn_sunB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_sunB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_sunB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_sunB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sunB.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_sunB.Location = new System.Drawing.Point(7, 57);
            this.btn_sunB.Name = "btn_sunB";
            this.btn_sunB.Size = new System.Drawing.Size(97, 46);
            this.btn_sunB.TabIndex = 7;
            this.btn_sunB.Text = "B";
            this.btn_sunB.UseVisualStyleBackColor = false;
            this.btn_sunB.Click += new System.EventHandler(this.tile_click);
            // 
            // btn_sunA
            // 
            this.btn_sunA.BackColor = System.Drawing.Color.Azure;
            this.btn_sunA.Enabled = false;
            this.btn_sunA.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btn_sunA.FlatAppearance.BorderSize = 0;
            this.btn_sunA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btn_sunA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_sunA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_sunA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sunA.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_sunA.Location = new System.Drawing.Point(7, 13);
            this.btn_sunA.Name = "btn_sunA";
            this.btn_sunA.Size = new System.Drawing.Size(97, 46);
            this.btn_sunA.TabIndex = 6;
            this.btn_sunA.Text = "A";
            this.btn_sunA.UseVisualStyleBackColor = false;
            this.btn_sunA.Click += new System.EventHandler(this.tile_click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Meiryo UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(643, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 24);
            this.label10.TabIndex = 62;
            this.label10.Text = "土";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Meiryo UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(549, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 24);
            this.label9.TabIndex = 61;
            this.label9.Text = "金";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(454, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 24);
            this.label8.TabIndex = 60;
            this.label8.Text = "木";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(359, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 24);
            this.label7.TabIndex = 59;
            this.label7.Text = "水";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(265, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 24);
            this.label6.TabIndex = 58;
            this.label6.Text = "火";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(170, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 24);
            this.label5.TabIndex = 57;
            this.label5.Text = "月";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(74, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 24);
            this.label4.TabIndex = 56;
            this.label4.Text = "日";
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_save.Location = new System.Drawing.Point(390, 493);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(106, 37);
            this.btn_save.TabIndex = 63;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // btn_exp
            // 
            this.btn_exp.Enabled = false;
            this.btn_exp.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_exp.Location = new System.Drawing.Point(526, 493);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.Size = new System.Drawing.Size(181, 37);
            this.btn_exp.TabIndex = 64;
            this.btn_exp.Text = "Excelシート出力";
            this.btn_exp.UseVisualStyleBackColor = true;
            this.btn_exp.Click += new System.EventHandler(this.Btn_exp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(759, 559);
            this.Controls.Add(this.btn_exp);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gb_btns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_teacher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_month);
            this.Controls.Add(this.cb_year);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "shift_xlsx";
            this.gb_btns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_year;
        private System.Windows.Forms.ComboBox cb_month;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_teacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sunA;
        private System.Windows.Forms.Button btn_sunB;
        private System.Windows.Forms.Button btn_sunC;
        private System.Windows.Forms.Button btn_sunD;
        private System.Windows.Forms.Button btn_sunE;
        private System.Windows.Forms.Button btn_sunF;
        private System.Windows.Forms.GroupBox gb_btns;
        private System.Windows.Forms.Button btn_monF;
        private System.Windows.Forms.Button btn_monE;
        private System.Windows.Forms.Button btn_monD;
        private System.Windows.Forms.Button btn_monC;
        private System.Windows.Forms.Button btn_monB;
        private System.Windows.Forms.Button btn_monA;
        private System.Windows.Forms.Button btn_satF;
        private System.Windows.Forms.Button btn_satE;
        private System.Windows.Forms.Button btn_satD;
        private System.Windows.Forms.Button btn_satC;
        private System.Windows.Forms.Button btn_satB;
        private System.Windows.Forms.Button btn_satA;
        private System.Windows.Forms.Button btn_friF;
        private System.Windows.Forms.Button btn_friE;
        private System.Windows.Forms.Button btn_friD;
        private System.Windows.Forms.Button btn_friC;
        private System.Windows.Forms.Button btn_friB;
        private System.Windows.Forms.Button btn_friA;
        private System.Windows.Forms.Button btn_thuF;
        private System.Windows.Forms.Button btn_thuE;
        private System.Windows.Forms.Button btn_thuD;
        private System.Windows.Forms.Button btn_thuC;
        private System.Windows.Forms.Button btn_thuB;
        private System.Windows.Forms.Button btn_thuA;
        private System.Windows.Forms.Button btn_wedF;
        private System.Windows.Forms.Button btn_wedE;
        private System.Windows.Forms.Button btn_wedD;
        private System.Windows.Forms.Button btn_wedC;
        private System.Windows.Forms.Button btn_wedB;
        private System.Windows.Forms.Button btn_wedA;
        private System.Windows.Forms.Button btn_tueF;
        private System.Windows.Forms.Button btn_tueE;
        private System.Windows.Forms.Button btn_tueD;
        private System.Windows.Forms.Button btn_tueC;
        private System.Windows.Forms.Button btn_tueB;
        private System.Windows.Forms.Button btn_tueA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_exp;
    }
}

