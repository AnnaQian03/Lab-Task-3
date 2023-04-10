<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Magic_Item_Excalibur
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Magic_Item_Excalibur))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNcloseexcalibur = New System.Windows.Forms.Button()
        Me.BTNuseexcalibur = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 126)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Excalibur also known as the HOLY SWORD." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Excalibur can kill any monster in one hi" &
    "t." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The item will vanish after 3 uses."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTNcloseexcalibur
        '
        Me.BTNcloseexcalibur.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNcloseexcalibur.Location = New System.Drawing.Point(257, 138)
        Me.BTNcloseexcalibur.Name = "BTNcloseexcalibur"
        Me.BTNcloseexcalibur.Size = New System.Drawing.Size(158, 39)
        Me.BTNcloseexcalibur.TabIndex = 4
        Me.BTNcloseexcalibur.Text = "NO , CLOSE"
        Me.BTNcloseexcalibur.UseVisualStyleBackColor = True
        '
        'BTNuseexcalibur
        '
        Me.BTNuseexcalibur.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNuseexcalibur.Location = New System.Drawing.Point(20, 138)
        Me.BTNuseexcalibur.Name = "BTNuseexcalibur"
        Me.BTNuseexcalibur.Size = New System.Drawing.Size(158, 39)
        Me.BTNuseexcalibur.TabIndex = 3
        Me.BTNuseexcalibur.Text = "YES , USE"
        Me.BTNuseexcalibur.UseVisualStyleBackColor = True
        '
        'Magic_Item_Excalibur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(435, 187)
        Me.Controls.Add(Me.BTNcloseexcalibur)
        Me.Controls.Add(Me.BTNuseexcalibur)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Magic_Item_Excalibur"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Excalibur"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BTNcloseexcalibur As Button
    Friend WithEvents BTNuseexcalibur As Button
End Class
