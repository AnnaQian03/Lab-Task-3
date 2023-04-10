Imports System.Windows.Forms

Public Class Magic_Item_Lightning_Rail_Finger

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BTNuseexcalibur_Click(sender As Object, e As EventArgs) Handles BTNuseLightningRailFinger.Click
        MessageBox.Show("Princess : Go Away !!!! Hmmph...!" & vbCrLf & "--Oh No.. Bad End")
        Me.Hide()


    End Sub

    Private Sub BTNcloseexcalibur_Click(sender As Object, e As EventArgs) Handles BTNcloseLightningRailFinger.Click
        Inventory.Show()
        Me.Hide()

    End Sub
End Class
