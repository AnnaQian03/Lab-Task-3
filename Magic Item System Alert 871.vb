Imports System.Windows.Forms

Public Class Magic_Item_System_Alert_871

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BTNuseexcalibur_Click(sender As Object, e As EventArgs) Handles BTNuseSystemAlert871.Click
        MessageBox.Show("ERROR - CRASHED" & vbCrLf & "The Game is closed by Anna Chan")
        Application.Exit()

    End Sub

    Private Sub BTNcloseexcalibur_Click(sender As Object, e As EventArgs) Handles BTNcloseSystemAlert871.Click
        Inventory.Show()
        Me.Hide()

    End Sub
End Class
