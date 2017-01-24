Public Class frmMasterStaffEdit

    Private Sub frmMasterEditStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_branch' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_branchTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_branch)
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_staff' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        '  Me.Tbl_staffTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_staff)

        'フォーム開始時、所属コンボボックスの値が自動でセットされないでindex = 0になってしまうので苦肉の策
        cmbBranch.SelectedValue = lblStaffBranch.Text
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

        End With

        'データの検査(氏名ｶﾅ)
        With txtStaffKana
            If Not CheckMaxLengthStaff("staff_kana", .Text) Then
                MsgBox("氏名ｶﾅは半角20字以内で入力してください")
                .Select()
                Return False
            End If
        End With

        '全ての検査を通過した
        Return True


    End Function

    Private Function CheckOverlap(text As String) As Boolean
        Throw New NotImplementedException()
    End Function

    '桁数チェック-社員(指定された列のサイズと文字列の比較)
    Private Function CheckMaxLengthStaff(ByVal fieldname As String, ByVal value As String)
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

    'キーボードショートカット
    Private Sub frmMasterEditStaff_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()

        End Select
    End Sub
End Class