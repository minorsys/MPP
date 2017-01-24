Public Class frmMasterStaffNew

    Private Sub frmMasterStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_car' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_carTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_car)
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_PhoneNum' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_PhoneNumTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_PhoneNum)
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_staff' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_staffTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_staff)
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_branch' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_branchTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_branch)


        '### 新しい社員IDを生成する ###

        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(My.Settings.PhoneNumDBConnectionString)

            'コマンドをコネクションから作成する
            Dim command As SqlClient.SqlCommand = connection.CreateCommand

            'コネクションを開く
            connection.Open()

            'データリーダーの定義
            Dim dr As SqlClient.SqlDataReader


            'データコマンドの定義
            command.CommandText = "SELECT id_staff FROM tbl_staff ORDER BY id_staff"
            'データリーダーからのデータの読出し
            dr = command.ExecuteReader()


            Do While dr.Read
                lblStaffID.Text = dr("id_staff")
            Loop

            'データリーダーを閉じる
            dr.Close()

            '最大IDに1を足す
            lblStaffID.Text = (lblStaffID.Text) + 1

            'IDの文字数を取得し、6-(文字数)個の0を先頭に付加する
            Dim nZero As Integer
            nZero = (5 - Len(lblStaffID.Text))

            Dim i As Integer = 1
            Do While i <= nZero
                lblStaffID.Text = "0" & lblStaffID.Text
                i = i + 1
            Loop

        End Using


        '### 所属コンボボックスの設定###
        cmbBranch.SelectedIndex = -1




    End Sub


    '[閉じる]ボタン
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    '[登録]ボタン
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        '登録するデータのチェック　不備があればキャンセルになる
        If Not CheckEditData() Then
            Return
        End If

        '保存確認と保存処理
        If MsgBox("この内容で新規登録してよろしいですか？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            '行の定義
            Dim newrecord As PhoneNumDBDataSet.tbl_staffRow = Me.PhoneNumDBDataSet.tbl_staff.Newtbl_staffRow

            Try
                '行にデータをセットする
                newrecord.id_staff = lblStaffID.Text
                newrecord.staff_name = txtStaffName.Text
                newrecord.staff_kana = txtStaffKana.Text
                newrecord.branch_id = cmbBranch.SelectedValue
                newrecord.staff_phonenum = cmbStaffPhonenum.Text
                newrecord.staff_carnum = cmbStaffCarnum.Text
                newrecord.biko = txtBiko.Text

                '新規行をデータテーブルに追加する
                Me.PhoneNumDBDataSet.tbl_staff.Addtbl_staffRow(newrecord)

                'テーブルアダプタを介して、tbl_carテーブルを更新する
                Me.Tbl_staffTableAdapter.Update(Me.PhoneNumDBDataSet.tbl_staff)

            Catch ex As Exception
                'エラーメッセージを表示する
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, Me.Text)
                Return

            End Try

            'フォームを閉じる
            Me.Close()
        End If
    End Sub

    Private Function CheckEditData() As Boolean

        'データの検査(氏名)
        With txtStaffName
            '空白でない
            If .Text = "" Then
                MsgBox("氏名は必ず入力してください")
                .Select()
                Return False
            End If

            '文字数チェック
            If Not CheckMaxLengthStaff("staff_name", .Text) Then
                MsgBox("氏名は全角10字以内で入力してください")
                .Select()
                Return False

            End If

            '氏名は、既存の登録と重複がないかチェックする。ただし、警告メッセージを表示するだけ
            If Not CheckOverlap(txtStaffName.Text) Then
                MsgBox("注意：氏名が既存のデータと重複しています")

            End If
        End With

        'データの検査(氏名ｶﾅ)
        With txtStaffKana
            If Not CheckMaxLengthStaff("staff_kana", .Text) Then
                MsgBox("氏名ｶﾅは半角20字以内で入力してください")
                .Select()
                Return False
            End If
        End With

        'データの検査(電話番号)
        '同じ電話番号を使っている人がいないかチェック
        '同じ番号を使っている人がいた場合、上書きするかたずねる

        'データの検査(車両番号)
        '同じ車両に乗っている人がいないかチェック
        '同じ車両に乗っている人がいた場合、上書きするかたずねる

        'データの検査(免許証期限)
        'データの検査(備考)

        '全ての検査を通過した
        Return True

    End Function

    '桁数チェック-車両番号(指定された列のサイズと文字列の比較) 
    Private Function CheckMaxLengthStaff(ByVal fieldname As String, ByVal value As String) As Boolean
        'データセットから列の情報を読み取る
        Dim column As DataColumn = PhoneNumDBDataSet.tbl_staff.Columns(fieldname)
        'シフトJISで文字列のバイト数を取得する
        Dim length As Integer = System.Text.Encoding.GetEncoding(932).GetByteCount(value)

        '指定されたサイズを超えたときはエラーになる
        If length > column.MaxLength Then
            Return False
        Else
            Return True
        End If

    End Function

    '重複チェック―氏名
    Private Function CheckOverlap(ByVal staffname As String) As Boolean
        Dim dbName As String
        Dim inputName As String

        For Each drw As DataRow In PhoneNumDBDataSet.tbl_staff.Rows()
            '行の状態が"削除"のデータを除外する
            If drw.RowState <> DataRowState.Deleted Then

                'この行の氏名と、入力された氏名を比較する
                '比較する文字列からスペースを抜く
                dbName = Replace(drw("staff_name"), "　", "")
                dbName = Replace(dbName, " ", "")
                inputName = Replace(staffname, "　", "")
                inputName = Replace(inputName, " ", "")
                If dbName = inputName Then
                    '重複の場合には終了する

                    Return False
                End If
            End If
        Next

        Return True
    End Function

    'キーボードショートカット
    Private Sub frmMasterStaff_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()

        End Select
    End Sub
End Class