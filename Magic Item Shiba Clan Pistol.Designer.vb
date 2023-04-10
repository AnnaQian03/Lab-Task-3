<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Magic_Item_Shiba_Clan_Pistol
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Magic_Item_Shiba_Clan_Pistol))
        Me.BTNcloseShibaClanPistol = New System.Windows.Forms.Button()
        Me.BTNuseShibaClanPistol = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTNcloseShibaClanPistol
        '
        Me.BTNcloseShibaClanPistol.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNcloseShibaClanPistol.Location = New System.Drawing.Point(265, 195)
        Me.BTNcloseShibaClanPistol.Name = "BTNcloseShibaClanPistol"
        Me.BTNcloseShibaClanPistol.Size = New System.Drawing.Size(158, 39)
        Me.BTNcloseShibaClanPistol.TabIndex = 7
        Me.BTNcloseShibaClanPistol.Text = "NO , CLOSE"
        Me.BTNcloseShibaClanPistol.UseVisualStyleBackColor = True
        '
        'BTNuseShibaClanPistol
        '
        Me.BTNuseShibaClanPistol.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNuseShibaClanPistol.Location = New System.Drawing.Point(17, 194)
        Me.BTNuseShibaClanPistol.Name = "BTNuseShibaClanPistol"
        Me.BTNuseShibaClanPistol.Size = New System.Drawing.Size(158, 39)
        Me.BTNuseShibaClanPistol.TabIndex = 6
        Me.BTNuseShibaClanPistol.Text = "YES , USE"
        Me.BTNuseShibaClanPistol.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 183)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Magic_Item_Shiba_Clan_Pistol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(435, 245)
        Me.Controls.Add(Me.BTNcloseShibaClanPistol)
        Me.Controls.Add(Me.BTNuseShibaClanPistol)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Magic_Item_Shiba_Clan_Pistol"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shiba Clan Pistol"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNcloseShibaClanPistol As Button
    Friend WithEvents BTNuseShibaClanPistol As Button
    Friend WithEvents Label1 As Label
End Class
