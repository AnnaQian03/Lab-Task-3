<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Magic_Item_System_Alert_871
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Magic_Item_System_Alert_871))
        Me.BTNcloseSystemAlert871 = New System.Windows.Forms.Button()
        Me.BTNuseSystemAlert871 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTNcloseSystemAlert871
        '
        Me.BTNcloseSystemAlert871.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNcloseSystemAlert871.Location = New System.Drawing.Point(257, 138)
        Me.BTNcloseSystemAlert871.Name = "BTNcloseSystemAlert871"
        Me.BTNcloseSystemAlert871.Size = New System.Drawing.Size(158, 39)
        Me.BTNcloseSystemAlert871.TabIndex = 7
        Me.BTNcloseSystemAlert871.Text = "NO , CLOSE"
        Me.BTNcloseSystemAlert871.UseVisualStyleBackColor = True
        '
        'BTNuseSystemAlert871
        '
        Me.BTNuseSystemAlert871.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNuseSystemAlert871.Location = New System.Drawing.Point(20, 138)
        Me.BTNuseSystemAlert871.Name = "BTNuseSystemAlert871"
        Me.BTNuseSystemAlert871.Size = New System.Drawing.Size(158, 39)
        Me.BTNuseSystemAlert871.TabIndex = 6
        Me.BTNuseSystemAlert871.Text = "YES , USE"
        Me.BTNuseSystemAlert871.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 126)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "System Alert - Code : 871 is a cursed item." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "When the item is used. It will cause" &
    " chaos." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Do not use it , or you will regret." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Magic_Item_System_Alert_871
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(435, 200)
        Me.Controls.Add(Me.BTNcloseSystemAlert871)
        Me.Controls.Add(Me.BTNuseSystemAlert871)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Magic_Item_System_Alert_871"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Alert 871"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNcloseSystemAlert871 As Button
    Friend WithEvents BTNuseSystemAlert871 As Button
    Friend WithEvents Label1 As Label
End Class
