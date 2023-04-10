<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNnext = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtplayersp = New System.Windows.Forms.TextBox()
        Me.txtplayermp = New System.Windows.Forms.TextBox()
        Me.txtplayerdef = New System.Windows.Forms.TextBox()
        Me.txtplayeratk = New System.Windows.Forms.TextBox()
        Me.txtplayerhp = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTNinventory = New System.Windows.Forms.Button()
        Me.BTNattack = New System.Windows.Forms.Button()
        Me.BTNrun = New System.Windows.Forms.Button()
        Me.BTNsave = New System.Windows.Forms.Button()
        Me.BTNload = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtmonstersp = New System.Windows.Forms.TextBox()
        Me.txtmonstermp = New System.Windows.Forms.TextBox()
        Me.txtmonsterdef = New System.Windows.Forms.TextBox()
        Me.txtmonsteratk = New System.Windows.Forms.TextBox()
        Me.txtmonsterhp = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1438, 377)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(-1, 382)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(687, 289)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'BTNnext
        '
        Me.BTNnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNnext.Location = New System.Drawing.Point(552, 636)
        Me.BTNnext.Name = "BTNnext"
        Me.BTNnext.Size = New System.Drawing.Size(134, 32)
        Me.BTNnext.TabIndex = 2
        Me.BTNnext.Text = "Next--->"
        Me.BTNnext.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.txtplayersp)
        Me.Panel1.Controls.Add(Me.txtplayermp)
        Me.Panel1.Controls.Add(Me.txtplayerdef)
        Me.Panel1.Controls.Add(Me.txtplayeratk)
        Me.Panel1.Controls.Add(Me.txtplayerhp)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Location = New System.Drawing.Point(1039, 379)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(398, 289)
        Me.Panel1.TabIndex = 3
        '
        'txtplayersp
        '
        Me.txtplayersp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtplayersp.Location = New System.Drawing.Point(95, 194)
        Me.txtplayersp.Name = "txtplayersp"
        Me.txtplayersp.ReadOnly = True
        Me.txtplayersp.Size = New System.Drawing.Size(165, 30)
        Me.txtplayersp.TabIndex = 16
        Me.txtplayersp.Text = "250"
        '
        'txtplayermp
        '
        Me.txtplayermp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtplayermp.Location = New System.Drawing.Point(95, 158)
        Me.txtplayermp.Name = "txtplayermp"
        Me.txtplayermp.ReadOnly = True
        Me.txtplayermp.Size = New System.Drawing.Size(165, 30)
        Me.txtplayermp.TabIndex = 15
        Me.txtplayermp.Text = "1500"
        '
        'txtplayerdef
        '
        Me.txtplayerdef.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtplayerdef.Location = New System.Drawing.Point(95, 121)
        Me.txtplayerdef.Name = "txtplayerdef"
        Me.txtplayerdef.ReadOnly = True
        Me.txtplayerdef.Size = New System.Drawing.Size(165, 30)
        Me.txtplayerdef.TabIndex = 14
        Me.txtplayerdef.Text = "1000-Hybrid"
        '
        'txtplayeratk
        '
        Me.txtplayeratk.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtplayeratk.Location = New System.Drawing.Point(95, 80)
        Me.txtplayeratk.Name = "txtplayeratk"
        Me.txtplayeratk.ReadOnly = True
        Me.txtplayeratk.Size = New System.Drawing.Size(165, 30)
        Me.txtplayeratk.TabIndex = 13
        Me.txtplayeratk.Text = "4500-Hybrid"
        '
        'txtplayerhp
        '
        Me.txtplayerhp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtplayerhp.Location = New System.Drawing.Point(95, 38)
        Me.txtplayerhp.Name = "txtplayerhp"
        Me.txtplayerhp.ReadOnly = True
        Me.txtplayerhp.Size = New System.Drawing.Size(165, 30)
        Me.txtplayerhp.TabIndex = 12
        Me.txtplayerhp.Text = "30000"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label11.Location = New System.Drawing.Point(3, 239)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(257, 23)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "JOB : WARRIOR"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.BTNinventory)
        Me.Panel3.Controls.Add(Me.BTNattack)
        Me.Panel3.Controls.Add(Me.BTNrun)
        Me.Panel3.Controls.Add(Me.BTNsave)
        Me.Panel3.Controls.Add(Me.BTNload)
        Me.Panel3.Location = New System.Drawing.Point(269, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(129, 289)
        Me.Panel3.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(26, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Menu"
        '
        'BTNinventory
        '
        Me.BTNinventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNinventory.Location = New System.Drawing.Point(9, 27)
        Me.BTNinventory.Name = "BTNinventory"
        Me.BTNinventory.Size = New System.Drawing.Size(117, 47)
        Me.BTNinventory.TabIndex = 7
        Me.BTNinventory.Text = "Inventory"
        Me.BTNinventory.UseVisualStyleBackColor = True
        '
        'BTNattack
        '
        Me.BTNattack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNattack.Location = New System.Drawing.Point(9, 80)
        Me.BTNattack.Name = "BTNattack"
        Me.BTNattack.Size = New System.Drawing.Size(117, 47)
        Me.BTNattack.TabIndex = 6
        Me.BTNattack.Text = "Attack"
        Me.BTNattack.UseVisualStyleBackColor = True
        '
        'BTNrun
        '
        Me.BTNrun.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNrun.Location = New System.Drawing.Point(9, 133)
        Me.BTNrun.Name = "BTNrun"
        Me.BTNrun.Size = New System.Drawing.Size(117, 47)
        Me.BTNrun.TabIndex = 5
        Me.BTNrun.Text = "Run"
        Me.BTNrun.UseVisualStyleBackColor = True
        '
        'BTNsave
        '
        Me.BTNsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNsave.Location = New System.Drawing.Point(9, 186)
        Me.BTNsave.Name = "BTNsave"
        Me.BTNsave.Size = New System.Drawing.Size(117, 47)
        Me.BTNsave.TabIndex = 4
        Me.BTNsave.Text = "Save"
        Me.BTNsave.UseVisualStyleBackColor = True
        '
        'BTNload
        '
        Me.BTNload.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNload.Location = New System.Drawing.Point(9, 239)
        Me.BTNload.Name = "BTNload"
        Me.BTNload.Size = New System.Drawing.Size(117, 47)
        Me.BTNload.TabIndex = 3
        Me.BTNload.Text = "Load"
        Me.BTNload.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label12.Location = New System.Drawing.Point(3, 197)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 23)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "SP:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Player"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label13.Location = New System.Drawing.Point(3, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 23)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "MP:"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label14.Location = New System.Drawing.Point(3, 121)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 23)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "DEF:"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label16.Location = New System.Drawing.Point(3, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 23)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "HP:"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label15.Location = New System.Drawing.Point(3, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 23)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "ATK:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.txtmonstersp)
        Me.Panel2.Controls.Add(Me.txtmonstermp)
        Me.Panel2.Controls.Add(Me.txtmonsterdef)
        Me.Panel2.Controls.Add(Me.txtmonsteratk)
        Me.Panel2.Controls.Add(Me.txtmonsterhp)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(692, 379)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(341, 292)
        Me.Panel2.TabIndex = 4
        '
        'txtmonstersp
        '
        Me.txtmonstersp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtmonstersp.Location = New System.Drawing.Point(95, 197)
        Me.txtmonstersp.Name = "txtmonstersp"
        Me.txtmonstersp.ReadOnly = True
        Me.txtmonstersp.Size = New System.Drawing.Size(235, 30)
        Me.txtmonstersp.TabIndex = 11
        Me.txtmonstersp.Text = "100"
        '
        'txtmonstermp
        '
        Me.txtmonstermp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtmonstermp.Location = New System.Drawing.Point(95, 157)
        Me.txtmonstermp.Name = "txtmonstermp"
        Me.txtmonstermp.ReadOnly = True
        Me.txtmonstermp.Size = New System.Drawing.Size(235, 30)
        Me.txtmonstermp.TabIndex = 10
        Me.txtmonstermp.Text = "9999"
        '
        'txtmonsterdef
        '
        Me.txtmonsterdef.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtmonsterdef.Location = New System.Drawing.Point(95, 116)
        Me.txtmonsterdef.Name = "txtmonsterdef"
        Me.txtmonsterdef.ReadOnly = True
        Me.txtmonsterdef.Size = New System.Drawing.Size(235, 30)
        Me.txtmonsterdef.TabIndex = 9
        Me.txtmonsterdef.Text = "3000-Hybrid"
        '
        'txtmonsteratk
        '
        Me.txtmonsteratk.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtmonsteratk.Location = New System.Drawing.Point(95, 80)
        Me.txtmonsteratk.Name = "txtmonsteratk"
        Me.txtmonsteratk.ReadOnly = True
        Me.txtmonsteratk.Size = New System.Drawing.Size(235, 30)
        Me.txtmonsteratk.TabIndex = 8
        Me.txtmonsteratk.Text = "1500-Physical"
        '
        'txtmonsterhp
        '
        Me.txtmonsterhp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtmonsterhp.Location = New System.Drawing.Point(95, 38)
        Me.txtmonsterhp.Name = "txtmonsterhp"
        Me.txtmonsterhp.ReadOnly = True
        Me.txtmonsterhp.Size = New System.Drawing.Size(235, 30)
        Me.txtmonsterhp.TabIndex = 7
        Me.txtmonsterhp.Text = "99999"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label10.Location = New System.Drawing.Point(6, 239)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(335, 23)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "ELEMENT: EARTH"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label9.Location = New System.Drawing.Point(3, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 23)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "SP:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label8.Location = New System.Drawing.Point(3, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 23)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "MP:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label7.Location = New System.Drawing.Point(3, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 23)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "DEF:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label6.Location = New System.Drawing.Point(3, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "ATK:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(3, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "HP:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Monster Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1437, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SettingToolStripMenuItem.Text = "&Setting"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Black
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadioButton1.Location = New System.Drawing.Point(12, 636)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(122, 29)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Auto Read"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1437, 668)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTNnext)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNnext As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents BTNinventory As Button
    Friend WithEvents BTNattack As Button
    Friend WithEvents BTNrun As Button
    Friend WithEvents BTNsave As Button
    Friend WithEvents BTNload As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtplayersp As TextBox
    Friend WithEvents txtplayermp As TextBox
    Friend WithEvents txtplayerdef As TextBox
    Friend WithEvents txtplayeratk As TextBox
    Friend WithEvents txtplayerhp As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtmonstersp As TextBox
    Friend WithEvents txtmonstermp As TextBox
    Friend WithEvents txtmonsterdef As TextBox
    Friend WithEvents txtmonsteratk As TextBox
    Friend WithEvents txtmonsterhp As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadioButton1 As RadioButton
End Class
