Imports System.Windows.Forms

Public Class Magic_Item_Excalibur

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BTNusescroll_Click(sender As Object, e As EventArgs) Handles BTNuseexcalibur.Click
        Win.Show()
        Me.Hide()

    End Sub

    Private Sub BTNcloseexcalibur_Click(sender As Object, e As EventArgs) Handles BTNcloseexcalibur.Click
        Inventory.Show()
        Me.Hide()

    End Sub
End Class
