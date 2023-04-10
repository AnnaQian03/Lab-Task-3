Imports System.Windows.Forms

Public Class Magic_Item_Shiba_Clan_Pistol

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BTNuseexcalibur_Click(sender As Object, e As EventArgs) Handles BTNuseShibaClanPistol.Click
        MessageBox.Show("The warrior is gone as well as the princess and everything..." & vbCrLf & "Can we consider this as a Bad End ?")
        Me.Hide()

    End Sub

    Private Sub BTNcloseexcalibur_Click(sender As Object, e As EventArgs) Handles BTNcloseShibaClanPistol.Click
        Inventory.Show()
        Me.Hide()

    End Sub
End Class
