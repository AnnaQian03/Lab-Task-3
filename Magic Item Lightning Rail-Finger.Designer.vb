<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Magic_Item_Lightning_Rail_Finger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Magic_Item_Lightning_Rail_Finger))
        Me.BTNcloseLightningRailFinger = New System.Windows.Forms.Button()
        Me.BTNuseLightningRailFinger = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTNcloseLightningRailFinger
        '
        Me.BTNcloseLightningRailFinger.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNcloseLightningRailFinger.Location = New System.Drawing.Point(265, 146)
        Me.BTNcloseLightningRailFinger.Name = "BTNcloseLightningRailFinger"
        Me.BTNcloseLightningRailFinger.Size = New System.Drawing.Size(158, 39)
        Me.BTNcloseLightningRailFinger.TabIndex = 7
        Me.BTNcloseLightningRailFinger.Text = "NO , CLOSE"
        Me.BTNcloseLightningRailFinger.UseVisualStyleBackColor = True
        '
        'BTNuseLightningRailFinger
        '
        Me.BTNuseLightningRailFinger.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNuseLightningRailFinger.Location = New System.Drawing.Point(17, 146)
        Me.BTNuseLightningRailFinger.Name = "BTNuseLightningRailFinger"
        Me.BTNuseLightningRailFinger.Size = New System.Drawing.Size(158, 39)
        Me.BTNuseLightningRailFinger.TabIndex = 6
        Me.BTNuseLightningRailFinger.Text = "YES , USE"
        Me.BTNuseLightningRailFinger.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 126)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Summoning Misaka from [A Certain Scientific Railgun]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Misaka can eliminate the mo" &
    "nster , however the princess is getting jealous." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hmmph" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Magic_Item_Lightning_Rail_Finger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(435, 197)
        Me.Controls.Add(Me.BTNcloseLightningRailFinger)
        Me.Controls.Add(Me.BTNuseLightningRailFinger)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Magic_Item_Lightning_Rail_Finger"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lightning Rail Finger"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNcloseLightningRailFinger As Button
    Friend WithEvents BTNuseLightningRailFinger As Button
    Friend WithEvents Label1 As Label
End Class
