Public Class frmMasterCarEdit
    Private Sub frmMasterEditCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_car' テーブルに読み込みます。必要に応じて移動、または削除をしてください。

        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_branch' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_branchTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_branch)
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_car' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        'Me.Tbl_carTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_car)

        '### 車格コンボボックスに値をセット ###
        cmbTon.Items.Add("2t平")
        cmbTon.Items.Add("2t平PG")
        cmbTon.Items.Add("2tU")
        cmbTon.Items.Add("3tU")
        cmbTon.Items.Add("4tU")
        cmbTon.Items.Add("7tU")
        cmbTon.Items.Add("10tU")
        cmbTon.Items.Add("15tU")
        cmbTon.Items.Add("その他")

        '所属コンボボックスの規定値をレコードに合わせる
        cmbBranch.SelectedValue = lblCarBranch.Text
    End Sub

    '車格コンボボックスの値が変更されたら、車格テキストボックスに代入
    Private Sub cmbTon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTon.SelectedIndexChanged

    End Sub

    Private frm_MasterCar

    Public Sub SetSelectedCar(ByVal carnum As String, ByVal f As frmMasterCar)
        '呼び出し元フォームを格納する
        frm_MasterCar = f

        '電話番号マスタのデータをデータソースにセット
        'Me.Tbl_PhoneNumTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_PhoneNum)

        '受け取ったコードを利用して、該当する車両番号テーブルのデータをデータソースにセット
        Me.Tbl_carTableAdapter.FillByCcode(Me.PhoneNumDBDataSet.tbl_car, carnum)

    End Sub
    '[キャンセル]ボタン
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    '[決定]ボタン
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

    End Sub

    Private Function CheckEditData() As Boolean
        'データの検査(地名)
        With txtCarnum2
            If Not CheckMaxLengthCar("carnum2", .Text) Then
                MsgBox("地名は全角4字以内で入力してください")
                .Select()
                Return False
            End If
        End With

        'データの検査(分類番号)
        With txtCarnum3
            If Not CheckMaxLengthCar("carnum3", .Text) Then
                MsgBox("分類番号は半角3字以内で入力してください")
                .Select()
                Return False
            End If
        End With

        'データの検査(ひらがな)
        With txtCarnum4
            If Not CheckMaxLengthCar("carnum4", .Text) Then
                MsgBox("ひらがなは全角1文字で入力してください")
                .Select()
                Return False
            End If
        End With

        'データの検査(無線)
        With txtMusen
            If Not CheckMaxLengthCar("musen", .Text) Then

                MsgBox("無線番号は半角4字以内で入力してください")
                .Select()
                Return False
            End If
        End With

        'データの検査(車格)
        With cmbTon
            If Not CheckMaxLengthCar("ton", .SelectedText) Then
                MsgBox("車格は半角4字以内で入力してください")
                .Select()
                Return False
            End If
        End With

        'データの検査(備考)
        With txtBiko
            If Not CheckMaxLengthCar("biko", .Text) Then
                MsgBox("備考は全角50字以内で入力してください")
                .Select()
                Return False
            End If
        End With

        'データの検査(車庫)
        With cmbBranch
            If .SelectedIndex = -1 Then
                MsgBox("車両の所属が選択されていません")
                .Select()
                Return False

            End If
        End With

        '全ての検査を通過した
        Return True

    End Function

    '桁数チェック-車両(指定された列のサイズと文字列の比較)
    Private Function CheckMaxLengthCar(ByVal fieldname As String, ByVal value As String)
        'データセットから列の情報を読み取る
        Dim column As DataColumn = PhoneNumDBDataSet.tbl_car.Columns(fieldname)
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
    Private Sub frmMasterEditCar_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()

        End Select
    End Sub
End Class