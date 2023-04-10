Imports System.Windows.Forms

Public Class Magic_Item_Hollow_Mask

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BTNuseexcalibur_Click(sender As Object, e As EventArgs) Handles BTNuseHollowMask.Click
        MessageBox.Show("The warriro gone rage." & vbCrLf & " The warrior killed everyone in the battlefield." & vbCrLf & " This is very very bad end.")
        Me.Hide()

    End Sub

    Private Sub BTNcloseexcalibur_Click(sender As Object, e As EventArgs) Handles BTNcloseHollowMask.Click
        Inventory.Show()
        Me.Hide()
    End Sub
End Class
