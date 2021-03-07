<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegPenghuniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransGateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PintuMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PintuKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GantiPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsLblUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.jam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PicShow = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PicPay = New System.Windows.Forms.PictureBox()
        Me.PicReg = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PicExit = New System.Windows.Forms.PictureBox()
        Me.PicHide = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PicShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PicPay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicReg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicHide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.RegPenghuniToolStripMenuItem, Me.TransGateToolStripMenuItem, Me.ReportToolStripMenuItem, Me.GantiPasswordToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(751, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Image = Global.sikeru.My.Resources.Resources.user
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.AdminToolStripMenuItem.Text = "User Management"
        '
        'RegPenghuniToolStripMenuItem
        '
        Me.RegPenghuniToolStripMenuItem.Image = Global.sikeru.My.Resources.Resources.Contact
        Me.RegPenghuniToolStripMenuItem.Name = "RegPenghuniToolStripMenuItem"
        Me.RegPenghuniToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.RegPenghuniToolStripMenuItem.Text = "Registrasi Kartu"
        '
        'TransGateToolStripMenuItem
        '
        Me.TransGateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PintuMasukToolStripMenuItem, Me.PintuKeluarToolStripMenuItem})
        Me.TransGateToolStripMenuItem.Image = Global.sikeru.My.Resources.Resources.car
        Me.TransGateToolStripMenuItem.Name = "TransGateToolStripMenuItem"
        Me.TransGateToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.TransGateToolStripMenuItem.Text = "Trans Gate"
        '
        'PintuMasukToolStripMenuItem
        '
        Me.PintuMasukToolStripMenuItem.Name = "PintuMasukToolStripMenuItem"
        Me.PintuMasukToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.PintuMasukToolStripMenuItem.Text = "Pintu Masuk"
        '
        'PintuKeluarToolStripMenuItem
        '
        Me.PintuKeluarToolStripMenuItem.Name = "PintuKeluarToolStripMenuItem"
        Me.PintuKeluarToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.PintuKeluarToolStripMenuItem.Text = "Pintu Keluar"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Image = Global.sikeru.My.Resources.Resources.kalender
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'GantiPasswordToolStripMenuItem
        '
        Me.GantiPasswordToolStripMenuItem.Image = Global.sikeru.My.Resources.Resources.userb
        Me.GantiPasswordToolStripMenuItem.Name = "GantiPasswordToolStripMenuItem"
        Me.GantiPasswordToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.GantiPasswordToolStripMenuItem.Text = "Ganti Password"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = Global.sikeru.My.Resources.Resources.LOGOUT
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Image = Global.sikeru.My.Resources.Resources.Door
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.TsLblUser, Me.tsJam, Me.jam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 370)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(751, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(62, 17)
        Me.ToolStripStatusLabel1.Text = "SIKERU v1"
        '
        'TsLblUser
        '
        Me.TsLblUser.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.TsLblUser.Name = "TsLblUser"
        Me.TsLblUser.Size = New System.Drawing.Size(68, 17)
        Me.TsLblUser.Text = "USER NAME"
        '
        'tsJam
        '
        Me.tsJam.Image = Global.sikeru.My.Resources.Resources.kalender
        Me.tsJam.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tsJam.Name = "tsJam"
        Me.tsJam.Size = New System.Drawing.Size(479, 17)
        Me.tsJam.Spring = True
        Me.tsJam.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'jam
        '
        Me.jam.Image = Global.sikeru.My.Resources.Resources.clock2
        Me.jam.Name = "jam"
        Me.jam.Size = New System.Drawing.Size(127, 17)
        Me.jam.Text = "ToolStripStatusLabel3"
        '
        'PicShow
        '
        Me.PicShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PicShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicShow.Image = CType(resources.GetObject("PicShow.Image"), System.Drawing.Image)
        Me.PicShow.Location = New System.Drawing.Point(149, 328)
        Me.PicShow.Name = "PicShow"
        Me.PicShow.Size = New System.Drawing.Size(32, 32)
        Me.PicShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicShow.TabIndex = 22
        Me.PicShow.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PicPay)
        Me.Panel1.Controls.Add(Me.PicReg)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PicExit)
        Me.Panel1.Controls.Add(Me.PicHide)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(143, 346)
        Me.Panel1.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(-11, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 19)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Transaction"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(-11, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 19)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Registration"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicPay
        '
        Me.PicPay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicPay.Image = Global.sikeru.My.Resources.Resources.car
        Me.PicPay.Location = New System.Drawing.Point(55, 94)
        Me.PicPay.Name = "PicPay"
        Me.PicPay.Size = New System.Drawing.Size(32, 32)
        Me.PicPay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicPay.TabIndex = 24
        Me.PicPay.TabStop = False
        '
        'PicReg
        '
        Me.PicReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicReg.Image = CType(resources.GetObject("PicReg.Image"), System.Drawing.Image)
        Me.PicReg.Location = New System.Drawing.Point(55, 15)
        Me.PicReg.Name = "PicReg"
        Me.PicReg.Size = New System.Drawing.Size(32, 32)
        Me.PicReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicReg.TabIndex = 23
        Me.PicReg.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 324)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 324)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Hide"
        '
        'PicExit
        '
        Me.PicExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PicExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicExit.Image = CType(resources.GetObject("PicExit.Image"), System.Drawing.Image)
        Me.PicExit.Location = New System.Drawing.Point(95, 285)
        Me.PicExit.Name = "PicExit"
        Me.PicExit.Size = New System.Drawing.Size(32, 32)
        Me.PicExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicExit.TabIndex = 19
        Me.PicExit.TabStop = False
        '
        'PicHide
        '
        Me.PicHide.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PicHide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicHide.Image = CType(resources.GetObject("PicHide.Image"), System.Drawing.Image)
        Me.PicHide.Location = New System.Drawing.Point(24, 285)
        Me.PicHide.Name = "PicHide"
        Me.PicHide.Size = New System.Drawing.Size(32, 32)
        Me.PicHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicHide.TabIndex = 18
        Me.PicHide.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'main1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(751, 392)
        Me.Controls.Add(Me.PicShow)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "main1"
        Me.Text = "Sistem Informasi Keamanan Perumahan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PicShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PicPay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicReg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicHide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegPenghuniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransGateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TsLblUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsJam As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents jam As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GantiPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PicShow As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PicPay As System.Windows.Forms.PictureBox
    Friend WithEvents PicReg As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PicExit As System.Windows.Forms.PictureBox
    Friend WithEvents PicHide As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PintuMasukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PintuKeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
