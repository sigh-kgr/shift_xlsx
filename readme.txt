#はじめに
ユーザ向け説明書です。長いけど1回は必ず読んでください。

##使用範囲
これは教室事務所のPCでのみ使うことを想定しています。Windows10でしか動きませんが、Windows10環境一般での動作を保証しません。開発者は教室外での使用を禁止しませんが、マネージャーの許可のもと、当塾の業務の一環としてのみ使用してください。

##動作要件
・.Net Framework
・Excel
・dll/xmlなどのファイル群
	→インストール時についてくるようになっています。バックアップ(.bkup)以外は全部必須です。触らないこと。以下のうち何かがないと言われたら、namelistとshiftを退避させてパッケージごと再インストールしてください。
	
#使い方

## 0.必要なファイルの確認
	講師のリストをnamelist.txtを直接編集して作成してください。講師名以外の文字列も許容されますが先頭のシングルクォーテーションはExcelの仕様上シートに反映されません。
		→シングルクォーテーションで始まる文字列はシート上で色が変わるようにしました。赤くなります。
	
## 1.アプリの起動
	shift.datが存在しない場合新しく作成されます。シフトを編集・確認する講師をコンボボックスから選択して始めてください。
	
## 2.編集内容の保存
	次回起動時に編集した内容を反映させたい場合は「保存」を押下してください。保存できるデータは1つで完全上書きです。講師を選択しなおした場合、アプリ内で一時的に編集データを保存します。
	
## 3.Excelシートへの出力
	「Excelシート出力」を押下した場合、編集内容の保存の是非を訊きます。ここで「はい」を選択した場合、2.に示したようにデータが保存されます。出力には時間がかかりますので、複数回押さないでください。出力に成功すると、作成したシートを含むExcelブックを表示します。
	
#注意
動作が遅い場合は起動しなおしてください。ただし、「保存」または「Excelシート出力」を押下した直後にアプリを強制終了させることはデータを破損する恐れがありますのでやめてください。

#履歴
v2 チェックボックスをタイルボタンに。カーソルをタイル上に持ってきたとき色が変わるように。
v3 月曜日と日曜日の最小表示機能を撤廃。名前をシートに赤字で出力できるように。
v4 コンボボックスの講師リストとシート上の講師リストの並び順を一致させるように。
		→これまでも結果的に同じだったけど実装の問題で仕様上は保証されてなかった
   シート上のリストで偶数番目の講師の行背景がライトブルーになるように

##今後やりたいこと
使い勝手や見た目に関してご意見があればマネージャーまで。

優先度高
・出勤/休み 以外の状態を反映できるように　→19年冬から事務コマ作る
中
・シート上で使う色をカスタマイズできるように
低
・フォームから直接namelist.txtをいじれるように
・namelistの並び順とシートの並び順が一致することを保証するように
