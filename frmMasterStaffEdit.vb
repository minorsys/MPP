Public Class frmMasterStaffEdit

    Private Sub frmMasterEditStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_car' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_carTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_car)
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_PhoneNum' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_PhoneNumTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_PhoneNum)
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_branch' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_branchTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_branch)
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_staff' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        '  Me.Tbl_staffTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_staff)

        'フォーム開始時、コンボボックスの値が自動でセットされないでindex = 0になってしまうので苦肉の策
        cmbBranch.SelectedValue = lblStaffBranch.Text
        cmbStaffCarnum.SelectedValue = lblStaff_Carnum.Text
        cmbStaffPhonenum.SelectedValue = lblStaff_phonenum.Text

        'フォーム開始時、免許証期限のDatetimePickerの初期値をセット
        If lblLimitMenkyo.Text = "" Then
            dtpMenkyoLimit.Format = DateTimePickerFormat.Custom
            dtpMenkyoLimit.CustomFormat = " "
        Else
            dtpMenkyoLimit.Format = DateTimePickerFormat.Long
        End If
    End Sub

    Private frm_MasterStaff

    Public Sub SetSelectedStaff(ByVal staffid As String, ByVal f As frmMasterStaff)
        '呼び出し元フォームを格納する
        frm_MasterStaff = f

        '電話番号マスタのデータをデータソースにセット
        'Me.Tbl_PhoneNumTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_PhoneNum)

        '受け取ったコードを利用して、該当する社員テーブルのデータをデータソースにセット
        Me.Tbl_staffTableAdapter.FillByScode(Me.PhoneNumDBDataSet.tbl_staff, staffid)

    End Sub
    '[キャンセル]ボタン
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    '[決定]ボタン
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        '登録する内容がデータ型と一致しているかチェック
        If Not CheckEditData() Then
            Return
        End If

        '保存確認と保存処理
        If MsgBox("これまでの修正内容をデータベースに保存しますか？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            '編集状態を確定する
            Me.TblstaffBindingSource.EndEdit()

            'テーブルアダプタを介して、レコードを更新する
            Me.Tbl_staffTableAdapter.Update(Me.PhoneNumDBDataSet.tbl_staff)

            'フォームを閉じる
            Me.Close()
        End If
    End Sub

    Private Function CheckEditData() As Boolean


        'データの検査(電話番号)
        '同じ電話番号を使っている人がいないかチェック
        '同じ番号を使っている人がいた場合、上書きするかたずねる
        If Not cmbStaffPhonenum.Text = "" Then
            CheckPhoneOverlap(cmbStaffPhonenum.Text)

        End If

        'データの検査(車両番号)
        '同じ車両に乗っている人がいないかチェック
        '同じ車両に乗っている人がいた場合、上書きするかたずねる
        If Not cmbStaffCarnum.Text = "" Then
            CheckCarOverlap(cmbStaffCarnum.Text)

        End If

        'データの検査(免許証期限)

        'データの検査(備考)
        With txtBiko
            If Not CheckMaxLengthStaff("biko", .Text) Then
                MsgBox("備考は全角50字以内で入力してください")
                .Select()
                Return False

            End If
        End With



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
    Private Function CheckNameOverlap(ByVal staffname As String) As Boolean
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

    '重複チェック－－電話番号
    Private Sub CheckPhoneOverlap(ByVal staffphonenum As String)
        Dim dbNum As String
        Dim inputNum As String

        inputNum = staffphonenum
        For Each drw As DataRow In PhoneNumDBDataSet.tbl_staff.Rows()
            If drw.RowState <> DataRowState.Deleted Then
                dbNum = drw("staff_phonenum").ToString


                If dbNum = inputNum Then
                    MsgBox(drw("staff_phonenum").ToString & vbCrLf & "この番号は次の人に使用されています：" & drw("staff_name") & vbCrLf & "登録すると使用者は上書きされます。")

                End If
            End If
        Next


    End Sub

    '重複チェック－－車両番号
    Private Sub CheckCarOverlap(ByVal staffcarnum As String)
        Dim dbCarnum As String
        Dim inputCarnum As String

        inputCarnum = staffcarnum
        For Each drw As DataRow In PhoneNumDBDataSet.tbl_staff.Rows()
            If drw.RowState <> DataRowState.Deleted Then
                dbCarnum = drw("staff_carnum").ToString

                If dbCarnum = inputCarnum Then
                    MsgBox(drw("staff_carnum").ToString & vbCrLf & "この車両は次の人に使用されています：" & drw("staff_name") & vbCrLf & "登録すると使用者は上書きされます。")

                End If
            End If
        Next

    End Sub

    'キーボードショートカット
    Private Sub frmMasterEditStaff_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()

        End Select
    End Sub
End Class