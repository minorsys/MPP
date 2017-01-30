Public Class frmGrd


    Private Sub frmGrd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.dtInteg' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        'Me.DtIntegTableAdapter.FillIntegTable(Me.PhoneNumDBDataSet.dtInteg)

        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(My.Settings.PhoneNumDBConnectionString)

            'コマンドをコネクションから作成する
            Dim command As SqlClient.SqlCommand = connection.CreateCommand

            'コネクションを開く
            connection.Open()

            'データリーダーの定義
            Dim dr As SqlClient.SqlDataReader

            '### 所属コンボボックス、車庫コンボボックスの設定###
            '先頭に(全て)を追加する
            cmbBranchStaff.Items.Add("(すべて)")
            cmbBranchCar.Items.Add("(すべて)")

            'データコマンドの定義
            command.CommandText = "SELECT * FROM tbl_branch ORDER BY id_branch"

            'データリーダーからのデータの読出し
            dr = command.ExecuteReader()
            Do While dr.Read
                '読みだしたデータをコンボボックスに追加する
                cmbBranchStaff.Items.Add(dr("id_branch") & ":" & dr("branch_name"))
                cmbBranchCar.Items.Add(dr("id_branch") & ":" & dr("branch_name"))
            Loop

            'データリーダーを閉じる
            dr.Close()

            'コネクションを閉じる
            connection.Close()

            '2つのコンボボックスで既定の状態として、先頭の(すべて)を選択する
            cmbBranchStaff.SelectedIndex = 0
            cmbBranchCar.SelectedIndex = 0

        End Using

        '指定された条件でデータベースを読み込む
        LoadDatabase()

    End Sub

    Public Sub LoadDatabase()
        Dim fs As String = ""
        Dim sql As String

        '電話番号フィルタの条件指定(部分一致)と条件式の作成
        If txtFilterPhonenum.Text <> "" Then
            fs = "tbl_phonenum.phonenum like '%" & txtFilterPhonenum.Text & "%'"
        End If

        '氏名フィルタの条件指定(部分一致)と条件式の作成
        If txtFilterKana.Text <> "" Then
            fs = "tbl_staff.staff_kana like '%" & txtFilterKana.Text & "%'"
        End If

        '所属コンボボックスの条件指定と条件式の作成
        If cmbBranchStaff.SelectedIndex > 0 Then
            If fs <> "" Then
                fs &= "AND "
            End If

            fs &= "tbl_staff.branch_id = '" & Strings.Left(cmbBranchStaff.Text, cmbBranchStaff.Text.IndexOf(":")) & "'"

        End If

        '車庫コンボボックスの条件指定と条件式の作成
        If cmbBranchCar.SelectedIndex > 0 Then
            If fs <> "" Then
                fs &= "AND "
            End If

            fs &= "tbl_car.branch_id = '" & Strings.Left(cmbBranchCar.Text, cmbBranchCar.Text.IndexOf(":")) & "'"

        End If

        'SQLステートメントの定義
        sql = "Select tbl_PhoneNum.*, tbl_branch_1.*, tbl_staff.*, tbl_car.*, tbl_branch.* " &
              "From tbl_car INNER Join tbl_branch On tbl_car.branch_id = tbl_branch.id_branch FULL OUTER Join " &
              "tbl_staff INNER Join tbl_branch As tbl_branch_1 On tbl_staff.branch_id = tbl_branch_1.id_branch LEFT OUTER Join " &
              "tbl_PhoneNum On tbl_staff.staff_phonenum = tbl_PhoneNum.phonenum " &
              "ON tbl_car.carnum1 = tbl_staff.staff_carnum "
        'ON tbl_car.staff_id = tbl_staff.id_staff "

        '条件が指定されているときには、WHERE句を追加する
        If fs <> "" Then
            sql &= " WHERE " & fs

        Else
            '条件がなければ、無線番号順にソート（SQL文の末尾にORDER BYを追加）
            sql &= " ORDER BY tbl_car.musen "
        End If

        'データアダプタにSQLステートメントを設定する
        Dim da As New SqlClient.SqlDataAdapter(sql, My.Settings.PhoneNumDBConnectionString)

        'データテーブルをクリアする
        Me.PhoneNumDBDataSet.dtMain.Clear()

        'データテーブルにデータアダプタを介してデータをセットする
        da.Fill(Me.PhoneNumDBDataSet.dtMain)

        '現在の行数をラベルに表示する
        lblHowManyRecords.Text = Me.grdMain.RowCount & "件のデータが選択されました"

    End Sub

    '電話番号フィルター変更時、データベースを再読み込み
    Private Sub txtFilterPhonenum_TextChanged(sender As Object, e As EventArgs) Handles txtFilterPhonenum.TextChanged
        LoadDatabase()
    End Sub

    '氏名ｶﾅフィルター変更時、データベースを再読み込み
    Private Sub txtFilterKana_TextChanged(sender As Object, e As EventArgs) Handles txtFilterKana.TextChanged
        LoadDatabase()
    End Sub

    '所属コンボボックス変更時、データベースを再読み込み
    Private Sub cmbBranchStaff_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBranchStaff.SelectedIndexChanged


        LoadDatabase()

    End Sub

    '車庫コンボボックス変更時、データベースを再読み込み
    Private Sub cmbBranchCar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBranchCar.SelectedIndexChanged


        LoadDatabase()

    End Sub


    Private Sub shiboriDatabase(ByVal fs As String)
        'データグリッドビューのソート（列名をクリックすると△ボタン表示されるやつ）が効いていると、そっちが優先されてしまうので、解除する。
        DtMainBindingSource.Sort = ""


        Dim sql As String



        'SQLステートメントの定義
        sql = "Select tbl_PhoneNum.*, tbl_branch_1.*, tbl_staff.*, tbl_car.*, tbl_branch.* " &
              "From tbl_car INNER Join tbl_branch On tbl_car.branch_id = tbl_branch.id_branch FULL OUTER Join " &
              "tbl_staff INNER Join tbl_branch As tbl_branch_1 On tbl_staff.branch_id = tbl_branch_1.id_branch LEFT OUTER Join " &
              "tbl_PhoneNum On tbl_staff.staff_phonenum = tbl_PhoneNum.phonenum " &
              "ON tbl_car.carnum1 = tbl_staff.staff_carnum "
        'sql = "Select tbl_PhoneNum.*, tbl_branch_1.*, tbl_staff.*, tbl_car.*, tbl_branch.* " &
        '      "From tbl_car INNER Join tbl_branch On tbl_car.branch_id = tbl_branch.id_branch FULL OUTER Join " &
        '      "tbl_staff INNER Join tbl_branch As tbl_branch_1 On tbl_staff.branch_id = tbl_branch_1.id_branch LEFT OUTER Join " &
        '      "tbl_PhoneNum On tbl_staff.staff_phonenum = tbl_PhoneNum.phonenum ON tbl_car.staff_id = tbl_staff.id_staff "

        sql &= " WHERE "

        '所属コンボボックスの条件指定と条件式の作成
        If cmbBranchStaff.SelectedIndex > 0 Then

            ' sql &= "And "

            sql &= "tbl_staff.branch_id = '" & Strings.Left(cmbBranchStaff.Text, cmbBranchStaff.Text.IndexOf(":")) & "'"

        End If

        '車庫コンボボックスの条件指定と条件式の作成
        If cmbBranchCar.SelectedIndex > 0 Then
            If cmbBranchStaff.SelectedIndex > 0 Then
                sql &= "AND "
            End If
            sql &= "tbl_car.branch_id = '" & Strings.Left(cmbBranchCar.Text, cmbBranchCar.Text.IndexOf(":")) & "'"

        End If

        If cmbBranchCar.SelectedIndex > 0 OrElse cmbBranchStaff.SelectedIndex > 0 Then
            sql &= "AND "

        End If

        sql &= fs

        'データアダプタにSQLステートメントを設定する
        Dim da As New SqlClient.SqlDataAdapter(sql, My.Settings.PhoneNumDBConnectionString)

        'データテーブルをクリアする
        Me.PhoneNumDBDataSet.dtMain.Clear()
        'Me.PhoneNumDBDataSet.dtMain.OrderBy(PhoneNumDBDataSet.dtMain.musenColumn)
        'データテーブルにデータアダプタを介してデータをセットする
        da.Fill(Me.PhoneNumDBDataSet.dtMain)

        '現在の行数をラベルに表示する
        lblHowManyRecords.Text = Me.grdMain.RowCount & "件のデータが選択されました"
    End Sub

    '絞り込みア行
    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ｱ-ｵ]%' ORDER BY tbl_staff.staff_kana"

        shiboriDatabase(fs)
    End Sub

    '絞り込みカ行
    Private Sub btnKa_Click(sender As Object, e As EventArgs) Handles btnKa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ｶ-ｺ]%' ORDER BY tbl_staff.staff_kana"

        shiboriDatabase(fs)
    End Sub

    '絞り込みサ行
    Private Sub btnSa_Click(sender As Object, e As EventArgs) Handles btnSa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ｻ-ｿ]%' ORDER BY tbl_staff.staff_kana"

        shiboriDatabase(fs)
    End Sub

    '絞り込みタ行
    Private Sub btnTa_Click(sender As Object, e As EventArgs) Handles btnTa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ﾀ-ﾄ]%' ORDER BY tbl_staff.staff_kana"

        shiboriDatabase(fs)
    End Sub

    '絞り込みナ行
    Private Sub btnNa_Click(sender As Object, e As EventArgs) Handles btnNa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ﾅ-ﾉ]%' ORDER BY tbl_staff.staff_kana"

        shiboriDatabase(fs)
    End Sub

    '絞り込みハ行
    Private Sub btnHa_Click(sender As Object, e As EventArgs) Handles btnHa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ﾊ-ﾎ]%' ORDER BY tbl_staff.staff_kana"

        shiboriDatabase(fs)
    End Sub

    '絞り込みマ行
    Private Sub btnMa_Click(sender As Object, e As EventArgs) Handles btnMa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ﾏ-ﾓ]%' ORDER BY tbl_staff.staff_kana"

        shiboriDatabase(fs)
    End Sub

    '絞り込みヤ行
    Private Sub btnYa_Click(sender As Object, e As EventArgs) Handles btnYa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ﾔ-ﾖ]%' ORDER BY tbl_staff.staff_kana"

        shiboriDatabase(fs)
    End Sub

    '絞り込みラ行
    Private Sub btnRa_Click(sender As Object, e As EventArgs) Handles btnRa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ﾗ-ﾛ]%' ORDER BY tbl_staff.staff_kana"

        shiboriDatabase(fs)
    End Sub

    '絞り込みワ行
    Private Sub btnWa_Click(sender As Object, e As EventArgs) Handles btnWa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ﾜ-ｦ]%' ORDER BY tbl_staff.staff_kana"

        shiboriDatabase(fs)
    End Sub

    '絞り込み1000未満
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim fs As String
        fs = "tbl_car.carnum1 like '___' ORDER BY tbl_car.carnum1"

        shiboriDatabase(fs)
    End Sub

    '絞り込み1000番台
    Private Sub btn1000_Click(sender As Object, e As EventArgs) Handles btn1000.Click
        Dim fs As String
        fs = "tbl_car.carnum1 like '1___' ORDER BY tbl_car.carnum1"

        shiboriDatabase(fs)
    End Sub

    '絞り込み2000番台
    Private Sub btn2000_Click(sender As Object, e As EventArgs) Handles btn2000.Click
        Dim fs As String
        fs = "tbl_car.carnum1 like '2___' ORDER BY tbl_car.carnum1"

        shiboriDatabase(fs)
    End Sub

    '絞り込み3000番台
    Private Sub btn3000_Click(sender As Object, e As EventArgs) Handles btn3000.Click
        Dim fs As String
        fs = "tbl_car.carnum1 like '3___' ORDER BY tbl_car.carnum1"

        shiboriDatabase(fs)
    End Sub

    '絞り込み4000番台
    Private Sub btn4000_Click(sender As Object, e As EventArgs) Handles btn4000.Click
        Dim fs As String
        fs = "tbl_car.carnum1 like '4___' ORDER BY tbl_car.carnum1"

        shiboriDatabase(fs)
    End Sub

    '絞り込み5000番台
    Private Sub btn5000_Click(sender As Object, e As EventArgs) Handles btn5000.Click
        Dim fs As String
        fs = "tbl_car.carnum1 like '5___' ORDER BY tbl_car.carnum1"

        shiboriDatabase(fs)
    End Sub

    '絞り込み6000番台
    Private Sub btn6000_Click(sender As Object, e As EventArgs) Handles btn6000.Click
        Dim fs As String
        fs = "tbl_car.carnum1 like '6___' ORDER BY tbl_car.carnum1"

        shiboriDatabase(fs)
    End Sub

    '絞り込み7000番台
    Private Sub btn7000_Click(sender As Object, e As EventArgs) Handles btn7000.Click
        Dim fs As String
        fs = "tbl_car.carnum1 like '7___' ORDER BY tbl_car.carnum1"

        shiboriDatabase(fs)
    End Sub

    '絞り込み8000番台
    Private Sub btn8000_Click(sender As Object, e As EventArgs) Handles btn8000.Click
        Dim fs As String
        fs = "tbl_car.carnum1 like '8___' ORDER BY tbl_car.carnum1"

        shiboriDatabase(fs)
    End Sub

    '絞り込み9000番台
    Private Sub btn9000_Click(sender As Object, e As EventArgs) Handles btn9000.Click
        Dim fs As String
        fs = "tbl_car.carnum1 like '9___' ORDER BY tbl_car.carnum1"

        shiboriDatabase(fs)
    End Sub

    '[解除]ボタンを押すとフィルタを解除して全レコードを表示する
    Private Sub btnFilterClear_Click(sender As Object, e As EventArgs) Handles btnFilterClear.Click
        txtFilterKana.Text = ""
        txtFilterPhonenum.Text = ""
        cmbBranchStaff.SelectedIndex = 0
        cmbBranchCar.SelectedIndex = 0

        LoadDatabase()
    End Sub

    '[選択行の編集]ボタン
    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        'データグリッドビューが空のときは終了する
        If grdMain.Rows.Count = 0 Then Return

        Dim row As Integer
        Dim pcode As String
        Dim scode As String
        Dim ccode As String

        'データグリッドビューの行番号を取得する
        row = grdMain.CurrentRow.Index
        '行番号から電話番号を取得する
        pcode = grdMain.Item(0, row).Value.ToString
        scode = grdMain.Item(7, row).Value.ToString
        ccode = grdMain.Item(13, row).Value.ToString

        Dim frm As New frmModifier
        '[選択行の編集]フォームのSetSelectedRecordプロシージャを呼び出し、
        '指定した電話番号のデータを表示する
        frm.SetSelectedRecord(pcode, scode, ccode, Me)
        '[選択行の編集]フォームを表示する
        frm.ShowDialog(Me)

        '[選択行の編集］フォームから戻ったら、このフォームを更新する
        LoadDatabase()

    End Sub

    '管理メニューボタン
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim frm As New frmAdmin
        frm.Show(Me)

    End Sub

    '[新しい行を追加]ボタン
    'Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddNewRow.Click
    '    Dim f As New frmAddRecord() '[新しい行を追加]フォーム

    '    '[新しい行を追加]フォームを表示する
    '    f.ShowDialog(Me)

    '    '新規登録の処理から戻ってきたら、表を更新する
    '    LoadDatabase()

    'End Sub

    '[選択した行を削除]ボタン
    'Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
    '    'データグリッドビューが空のときは終了する
    '    If grdMain.Rows.Count = 0 Then Return

    '    Dim row As Integer
    '    Dim phonenum As String
    '    Dim staffname As String
    '    Dim carnum As String
    '    Dim id As String

    '    'データグリッドビューの行番号を取得する
    '    row = grdMain.CurrentRow.Index
    '    '行番号から電話番号、氏名、車番、integ_idを取得する
    '    phonenum = grdMain.Item(1, row).Value.ToString
    '    staffname = grdMain.Item(9, row).Value.ToString
    '    carnum = grdMain.Item(15, row).Value.ToString
    '    id = grdMain.Item(0, row).Value.ToString


    '    'メッセージボックスに行情報を表示し、削除してよいか確認
    '    If MsgBox("電話番号：" & phonenum & ",　氏名：" & staffname & ",　車番：" & carnum & vbCrLf & "この行を削除してもよろしいですか？(マスタは削除されません。)", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2) <> MsgBoxResult.Yes Then
    '        Return

    '    End If

    '    '処理の成功をチェックするフラグ
    '    Dim bSuccess As Boolean = False

    '    'コネクションを指定する
    '    Using connection As New SqlClient.SqlConnection(My.Settings.PhoneNumDBConnectionString)

    '        'コマンドを定義する
    '        Dim command As SqlClient.SqlCommand = connection.CreateCommand()

    '        'コネクションを開く
    '        connection.Open()

    '        'トランザクションの開始
    '        command.Transaction = connection.BeginTransaction()

    '        Try
    '            'コマンドの定義と実行
    '            '
    '            command.CommandText = "DELETE FROM tbl_integrate WHERE integ_id = '" & id & "'"
    '            command.ExecuteNonQuery()

    '            'トランザクションのコミット
    '            command.Transaction.Commit()

    '            MsgBox("選択された行を削除しました。")

    '            '処理が成功したため、フラグにセットする
    '            bSuccess = True

    '            '処理が失敗したとき
    '        Catch ex As Exception
    '            'トランザクションのロールバック
    '            command.Transaction.Rollback()

    '            MsgBox("エラーが発生したため、処理を中止します。" & vbCrLf & ex.Message)

    '        End Try

    '    End Using

    '    '成功した時の後処理
    '    If bSuccess Then

    '        'frmGrdを更新する
    '        LoadDatabase()


    '    End If


    'End Sub

    '[2t平]ボタン
    Private Sub btn2tHira_Click(sender As Object, e As EventArgs) Handles btn2tHira.Click
        Dim fs As String
        fs = "tbl_car.ton like '2t平%' ORDER BY tbl_car.musen"

        shiboriDatabase(fs)
    End Sub


    '[2tU]ボタン
    Private Sub btn2tU_Click(sender As Object, e As EventArgs) Handles btn2tU.Click
        Dim fs As String
        fs = "tbl_car.ton = '2tU' ORDER BY tbl_car.musen"

        shiboriDatabase(fs)
    End Sub

    '[3tu]ボタン
    Private Sub btn3tU_Click(sender As Object, e As EventArgs) Handles btn3tU.Click
        Dim fs As String
        fs = "tbl_car.ton = '3tU' ORDER BY tbl_car.musen"

        shiboriDatabase(fs)
    End Sub

    '[4tu]ボタン
    Private Sub btn4tU_Click(sender As Object, e As EventArgs) Handles btn4tU.Click
        Dim fs As String
        fs = "tbl_car.ton = '4tU' ORDER BY tbl_car.musen"

        shiboriDatabase(fs)
    End Sub

    '[7tu]ボタン
    Private Sub btn7tU_Click(sender As Object, e As EventArgs) Handles btn7tU.Click
        Dim fs As String
        fs = "tbl_car.ton = '7tU' ORDER BY tbl_car.musen"

        shiboriDatabase(fs)
    End Sub

    '[10tU]
    Private Sub btn10tU_Click(sender As Object, e As EventArgs) Handles btn10tU.Click
        Dim fs As String
        fs = "tbl_car.ton = '10tU' ORDER BY tbl_car.musen"

        shiboriDatabase(fs)
    End Sub

    '[15tU]ボタン
    Private Sub btn15tU_Click(sender As Object, e As EventArgs) Handles btn15tU.Click
        Dim fs As String
        fs = "tbl_car.ton = '15tU' ORDER BY tbl_car.musen"

        shiboriDatabase(fs)
    End Sub

    '[全車両]ボタン 
    Private Sub btnAllCar_Click(sender As Object, e As EventArgs) Handles btnAllCar.Click
        Dim fs As String
        fs = "tbl_car.carnum1 like '%[0-9]%' ORDER BY tbl_car.musen"

        shiboriDatabase(fs)
    End Sub

    '選択行の車検証・免許証エクスポートボタン
    Private Sub btnExportSyakenMenkyo_Click(sender As Object, e As EventArgs) Handles btnExportSyakenMenkyo.Click
        'データグリッドビューが空のときは終了する
        If grdMain.Rows.Count = 0 Then Return

        'セルが選択されていなければ戻る
        If grdMain.SelectedCells.Count = 0 Then
            MsgBox("行が選択されていません")
            Return
        End If

        'ファイルを出力するためのフォルダを作成する
        Dim folderpath As String
        folderpath = DateTime.Now.ToString("yyyy-MM-dd HHmmss")
        System.IO.Directory.CreateDirectory("C:\MPP\Exports\" & folderpath & "\車検証")
        System.IO.Directory.CreateDirectory("C:\MPP\Exports\" & folderpath & "\免許証")

        '見つからなかったファイル名をためる用
        Dim errmsg As String = ""

        '選択されている各行について、
        For Each c As DataGridViewCell In grdMain.SelectedCells

            '選択されている行の車番を取得する
            Dim selectedCarnum As String
            selectedCarnum = grdMain.Item(13, c.RowIndex).Value.ToString()

            '選択されている行の氏名を取得する
            Dim selectedStaff As String
            selectedStaff = grdMain.Item(8, c.RowIndex).Value.ToString

            If Not selectedCarnum = "" Then
                '取得した車番からはじまるファイル名をもつファイルを検索する
                Dim files As System.Collections.ObjectModel.ReadOnlyCollection(Of String) =
                 My.Computer.FileSystem.GetFiles(
                 "\\192.168.8.190\share\system\syaken",
                  FileIO.SearchOption.SearchTopLevelOnly,
                 "" & selectedCarnum & "*")

                '見つからなかったら、エラーメッセージに車番を追加する
                If files.Count = 0 Then
                    errmsg += vbCrLf & selectedCarnum
                Else


                    '該当ファイルをコピーする
                    For Each f As String In files
                        System.IO.File.Copy(f, "C:\MPP\Exports\" & folderpath & "\車検証\" & selectedCarnum & ".pdf")

                    Next

                End If

            End If

            If Not selectedStaff = "" Then
                '取得した氏名からはじまるファイル名をもつファイルを検索する
                Dim files As System.Collections.ObjectModel.ReadOnlyCollection(Of String) =
                 My.Computer.FileSystem.GetFiles(
                 "\\192.168.8.190\share\system\menkyo",
                  FileIO.SearchOption.SearchTopLevelOnly,
                 "" & selectedStaff & "*")

                If files.Count = 0 Then
                    errmsg += vbCrLf & selectedStaff
                Else

                    '該当ファイルをコピーする
                    For Each f As String In files
                        System.IO.File.Copy(f, "C:\MPP\Exports\" & folderpath & "\免許証\" & selectedStaff & ".pdf")
                    Next

                End If

            End If

        Next c

        '見つからなかった免許・車検証があれば、エラーメッセージを表示
        If Not errmsg = "" Then
            errmsg = "以下のファイルは見つかりませんでした:" & errmsg
            MsgBox(errmsg)
        End If

        'エクスポートしたフォルダを表示する
        System.Diagnostics.Process.Start("C:\MPP\Exports\" & folderpath & "")
    End Sub
End Class