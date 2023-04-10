<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MagicItemScroll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MagicItemScroll))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNuseScroll = New System.Windows.Forms.Button()
        Me.BTNclosescroll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 95)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "This item will teleport only the user to back of the battleground." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "User will be " &
    "able to run from the monster."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTNuseScroll
        '
        Me.BTNuseScroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNuseScroll.Location = New System.Drawing.Point(13, 154)
        Me.BTNuseScroll.Name = "BTNuseScroll"
        Me.BTNuseScroll.Size = New System.Drawing.Size(158, 39)
        Me.BTNuseScroll.TabIndex = 1
        Me.BTNuseScroll.Text = "YES , USE"
        Me.BTNuseScroll.UseVisualStyleBackColor = True
        '
        'BTNclosescroll
        '
        Me.BTNclosescroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNclosescroll.Location = New System.Drawing.Point(250, 154)
        Me.BTNclosescroll.Name = "BTNclosescroll"
        Me.BTNclosescroll.Size = New System.Drawing.Size(158, 39)
        Me.BTNclosescroll.TabIndex = 2
        Me.BTNclosescroll.Text = "NO , CLOSE"
        Me.BTNclosescroll.UseVisualStyleBackColor = True
        '
        'MagicItemScroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(435, 205)
        Me.Controls.Add(Me.BTNclosescroll)
        Me.Controls.Add(Me.BTNuseScroll)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MagicItemScroll"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scroll"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BTNuseScroll As Button
    Friend WithEvents BTNclosescroll As Button
End Class
