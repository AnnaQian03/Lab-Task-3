Public Class Win
    Private Sub BTNsaveWin_Click(sender As Object, e As EventArgs) Handles BTNsaveWin.Click
        Gamesaved.Show()

    End Sub

    Private Sub BTNloadWin_Click(sender As Object, e As EventArgs) Handles BTNloadWin.Click
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
        Dim reward As String = InputBox("What is your wish. Princess can grant you your wishes", "Tsundere Princess Asking : ", "Gold or Marriage")
        MessageBox.Show("Congratulation . Good Ending" & vbCrLf & " You get " & reward)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BTNinventoryWin_Click(sender As Object, e As EventArgs) Handles BTNinventoryWin.Click
        MessageBox.Show("Cannot access inventory right now.")

    End Sub
End Class