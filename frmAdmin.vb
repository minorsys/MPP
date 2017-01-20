Public Class frmAdmin
    Private Sub btnMasterCar_Click(sender As Object, e As EventArgs) Handles btnMasterCar.Click
        Dim frm As New frmMasterCar
        frm.ShowDialog(Me)
    End Sub
End Class