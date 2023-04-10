Public Class Form1

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub BTNexit_Click(sender As Object, e As EventArgs) Handles BTNload.Click
        Controls.Clear()
        InitializeComponent()
        LoadDialog.Show()

    End Sub

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        Setting.Show()
        Me.Hide()

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        Dim folderBrowserDialog As New FolderBrowserDialog()
        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then

            Dim selectedPath As String = folderBrowserDialog.SelectedPath
            ' Open the selected folder
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Help.Show()

    End Sub

    Private Sub BTNattack_Click(sender As Object, e As EventArgs) Handles BTNattack.Click

        Dim monsterhp As Double = Val(txtmonsterhp.Text)
        Dim monsteratk As Double = Val(txtmonsteratk.Text)
        Dim monsterdef As Double = Val(txtmonsterdef.Text)
        Dim monstermp As Double = Val(txtmonstermp.Text)
        Dim monstersp As Double = Val(txtmonstersp.Text)
        Dim playerhp As Double = Val(txtplayerhp.Text)
        Dim playeratk As Double = Val(txtplayeratk.Text)
        Dim playerdef As Double = Val(txtplayerdef.Text)
        Dim playermp As Double = Val(txtplayermp.Text)
        Dim playersp As Double = Val(txtplayersp.Text)

        monsterhp = monsterhp - (playeratk - monsterdef)
        txtmonsterdef.Text = monsterdef + 500
        txtplayerhp.Text = playerhp - 1000
        txtplayersp.Text = playersp - 5
        txtplayermp.Text = playermp - 50
        txtmonstersp.Text = monstersp + 5
        txtmonstermp.Text = monstermp + 200

        If monsterhp < 50000 Then
            txtmonsterdef.Text = monsterdef + 800
            txtplayeratk.Text = playeratk + 500
        Else
            txtplayeratk.Text = playeratk + 900
        End If

        txtmonsterhp.Text = monsterhp.ToString
        If monsterhp < 0 Then
            MessageBox.Show("The monster has been defeated!")
            txtmonsterhp.Text = "0"
            txtmonsterdef.Text = "0"
            txtmonsteratk.Text = "0"
            txtmonstermp.Text = "0"
            txtmonstersp.Text = "0"
        Else
            txtmonsterhp.Text = monsterhp.ToString
        End If

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub BTNsave_Click(sender As Object, e As EventArgs) Handles BTNsave.Click
        Gamesaved.Show()
    End Sub

    Private Sub BTNrun_Click(sender As Object, e As EventArgs) Handles BTNrun.Click
        Run.Show()
        Me.Hide()

    End Sub

    Private Sub BTNnext_Click(sender As Object, e As EventArgs) Handles BTNnext.Click
        Dim monsterhp As Double = Val(txtmonsterhp.Text)
        If monsterhp = 0 Then
            Win.Show()
            Me.Hide()

        Else
            MessageBox.Show("Defeat the golem before proceed !")
        End If
    End Sub

    Private Sub BTNinventory_Click(sender As Object, e As EventArgs) Handles BTNinventory.Click
        Inventory.Show()
        Me.Hide()

    End Sub
End Class
