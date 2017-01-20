Public Class frmMasterCar
    Private Sub frmMasterCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_car' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_carTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_car)

    End Sub
End Class