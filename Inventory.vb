Public Class Inventory
    Private Sub BTNclose_Click(sender As Object, e As EventArgs) Handles BTNclose.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub BTNitem1_Click(sender As Object, e As EventArgs) Handles BTNitem1.Click
        MagicItemScroll.Show()
        Me.Hide()

    End Sub

    Private Sub BTNitem2_Click(sender As Object, e As EventArgs) Handles BTNitem2.Click
        Magic_Item_Excalibur.Show()
        Me.Hide()
    End Sub

    Private Sub BTNitem3_Click(sender As Object, e As EventArgs) Handles BTNitem3.Click
        Magic_Item_Hollow_Mask.Show()
        Me.Hide()
    End Sub

    Private Sub BTNitem4_Click(sender As Object, e As EventArgs) Handles BTNitem4.Click
        Magic_Item_Shiba_Clan_Pistol.Show()
        Me.Hide()
    End Sub

    Private Sub BTNitem5_Click(sender As Object, e As EventArgs) Handles BTNitem5.Click
        Magic_Item_Lightning_Rail_Finger.Show()
        Me.Hide()

    End Sub

    Private Sub BTNitem6_Click(sender As Object, e As EventArgs) Handles BTNitem6.Click
        Magic_Item_System_Alert_871.Show()
        Me.Hide()

    End Sub
End Class