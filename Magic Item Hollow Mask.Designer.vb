<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Magic_Item_Hollow_Mask
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Magic_Item_Hollow_Mask))
        Me.BTNcloseHollowMask = New System.Windows.Forms.Button()
        Me.BTNuseHollowMask = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTNcloseHollowMask
        '
        Me.BTNcloseHollowMask.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNcloseHollowMask.Location = New System.Drawing.Point(265, 140)
        Me.BTNcloseHollowMask.Name = "BTNcloseHollowMask"
        Me.BTNcloseHollowMask.Size = New System.Drawing.Size(158, 39)
        Me.BTNcloseHollowMask.TabIndex = 7
        Me.BTNcloseHollowMask.Text = "NO , CLOSE"
        Me.BTNcloseHollowMask.UseVisualStyleBackColor = True
        '
        'BTNuseHollowMask
        '
        Me.BTNuseHollowMask.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNuseHollowMask.Location = New System.Drawing.Point(17, 140)
        Me.BTNuseHollowMask.Name = "BTNuseHollowMask"
        Me.BTNuseHollowMask.Size = New System.Drawing.Size(158, 39)
        Me.BTNuseHollowMask.TabIndex = 6
        Me.BTNuseHollowMask.Text = "YES , USE"
        Me.BTNuseHollowMask.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(12, -4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 126)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Hollow Mask will consume the user sanity." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "However, the user is buff with higher " &
    "hybrid attack."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Magic_Item_Hollow_Mask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(435, 191)
        Me.Controls.Add(Me.BTNcloseHollowMask)
        Me.Controls.Add(Me.BTNuseHollowMask)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Magic_Item_Hollow_Mask"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hollow Mask"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNcloseHollowMask As Button
    Friend WithEvents BTNuseHollowMask As Button
    Friend WithEvents Label1 As Label
End Class
