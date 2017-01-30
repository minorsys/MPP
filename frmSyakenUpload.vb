Public Class frmSyakenUpload
    Private Sub btnFileSelect_Click(sender As Object, e As EventArgs) Handles btnFileSelect.Click
        'OpenFileDialogクラスのインスタンスを作成
        Dim ofd As New OpenFileDialog()

        'はじめのファイル名を指定する
        'はじめに「ファイル名」で表示される文字列を指定する
        ofd.FileName = "XXXX.pdf"
        'はじめに表示されるフォルダを指定する
        '指定しない（空の文字列）の時は、現在のディレクトリが表示される
        ofd.InitialDirectory = "\\192.168.8.190\share\★★個人用フォルダ★★\菅原\scan"
        '[ファイルの種類]に表示される選択肢を指定する
        '指定しないとすべてのファイルが表示される
        ofd.Filter = "pdfファイル(*.pdf)|*.pdf|すべてのファイル(*.*)|*.*"
        '[ファイルの種類]ではじめに選択されるものを指定する
        '2番目の「すべてのファイル」が選択されているようにする
        ofd.FilterIndex = 1
        'タイトルを設定する
        ofd.Title = "車検証ファイルを選択してください"
        'ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
        ofd.RestoreDirectory = True
        '存在しないファイルの名前が指定されたとき警告を表示する
        'デフォルトでTrueなので指定する必要はない
        ofd.CheckFileExists = True
        '存在しないパスが指定されたとき警告を表示する
        'デフォルトでTrueなので指定する必要はない
        ofd.CheckPathExists = True

        'ダイアログを表示する
        If ofd.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき、選択されたファイル名を表示する
            Console.WriteLine(ofd.FileName)
            txtFilePath.Text = ofd.FileName.ToString
        End If
    End Sub

    Private Sub frmSyakenUpload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_car' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_carTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_car)


    End Sub

    'アップロードボタン
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        'ファイルが選択されていなければキャンセル
        If txtFilePath.Text = "" Then
            MsgBox("ファイルを選択してください")
            Return
        End If

        '選択された車番の車検証をoldフォルダに移動
        Dim files As System.Collections.ObjectModel.ReadOnlyCollection(Of String) =
                 My.Computer.FileSystem.GetFiles(
                 "\\192.168.8.190\share\system\syaken",
                  FileIO.SearchOption.SearchTopLevelOnly,
                 "" & cmbCarnum.Text & "_*")

        '\\system\syakenに該当車番ファイルが見つからなかったら、メッセージを出して次へ
        If files.Count = 0 Then

            If MsgBox("車両番号：" & cmbCarnum.Text & "の以前の車検証ファイルが見つかりません。ファイルは新規に保存されます。続行しますか？", vbYesNo) = vbYes Then

            Else
                Return

            End If

            '\\system\syakenに該当車番ファイルが見つかったら、以前の車検証ファイルはoldフォルダに移動する

        Else

            If MsgBox("車両番号：" & cmbCarnum.Text & "の以前の車検証ファイルが見つかりました。ファイルは上書きされます。続行しますか？", vbYesNo) = vbYes Then
                For Each f As String In files
                    System.IO.File.Move(f, "\\192.168.8.190\share\system\syaken\old\" & Split(f, "\").Last)
                Next
            Else
                Return
            End If
        End If


        '選択された車番の新しい車検証をsyakenフォルダにコピー＆リネーム　例：1467_車検証_20170101.pdf
        Dim newSyakenFilePath As String
        newSyakenFilePath = "\\192.168.8.190\share\system\syaken\" & cmbCarnum.Text & "_車検証_" & dtpSyakenLimit.Text.ToString & ".pdf"

        System.IO.File.Copy(txtFilePath.Text, newSyakenFilePath)

        Me.Close()
    End Sub
End Class