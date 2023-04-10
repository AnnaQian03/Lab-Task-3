Imports System.Windows.Forms

Public Class MagicItemScroll

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BTNusescroll_Click(sender As Object, e As EventArgs) Handles BTNuseScroll.Click
        Escaped.Show()
        Me.Hide()

    End Sub

    Private Sub BTNclosescroll_Click(sender As Object, e As EventArgs) Handles BTNclosescroll.Click
        Inventory.Show()
        Me.Hide()

    End Sub
End Class
