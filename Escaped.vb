Public Class Escaped
    Private Sub BTNattack_Click(sender As Object, e As EventArgs) Handles BTNattackEscaped.Click

    End Sub

    Private Sub BTNsaveEscaped_Click(sender As Object, e As EventArgs) Handles BTNsaveEscaped.Click
        Gamesaved.Show()

    End Sub

    Private Sub BTNloadEscaped_Click(sender As Object, e As EventArgs) Handles BTNloadEscaped.Click
        Controls.Clear()
        InitializeComponent()
        LoadDialog.Show()
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        Dim folderBrowserDialog As New FolderBrowserDialog()
        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then

            Dim selectedPath As String = folderBrowserDialog.SelectedPath
            ' Open the selected folder
        End If
    End Sub

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        Setting.Show()
        Me.Hide()

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Help.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Oh Nooooo ! You let the princess down. -- BAD END --")

    End Sub

    Private Sub BTNinventoryEscaped_Click(sender As Object, e As EventArgs) Handles BTNinventoryEscaped.Click
        MessageBox.Show("Cannot access inventory right now.")

    End Sub
End Class