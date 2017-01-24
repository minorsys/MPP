Public Class frmAdmin
    Private Sub btnMasterCar_Click(sender As Object, e As EventArgs) Handles btnMasterCar.Click
        Dim frm As New frmMasterCar
        frm.ShowDialog(Me)
    End Sub

    Private Sub btnMasterStaff_Click(sender As Object, e As EventArgs) Handles btnMasterStaff.Click
        Dim frm As New frmMasterStaff
        frm.ShowDialog(Me)
    End Sub


End Class