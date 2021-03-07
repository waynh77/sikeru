<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransKeluar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransKeluar))
        Me.lblbmp = New System.Windows.Forms.Label()
        Me.lblrfid = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbljamout = New System.Windows.Forms.Label()
        Me.lbltglout = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtrfid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtip = New System.Windows.Forms.TextBox()
        Me.lblalamatin = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbljamin = New System.Windows.Forms.Label()
        Me.lbltglin = New System.Windows.Forms.Label()
        Me.lblnamain = New System.Windows.Forms.Label()
        Me.lbljenisin = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AxVLCPlugin21 = New AxAXVLC.AxVLCPlugin2()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblbmp
        '
        Me.lblbmp.AutoSize = True
        Me.lblbmp.Location = New System.Drawing.Point(20, 242)
        Me.lblbmp.Name = "lblbmp"
        Me.lblbmp.Size = New System.Drawing.Size(37, 13)
        Me.lblbmp.TabIndex = 111
        Me.lblbmp.Text = "lblbmp"
        '
        'lblrfid
        '
        Me.lblrfid.AutoSize = True
        Me.lblrfid.Location = New System.Drawing.Point(19, 256)
        Me.lblrfid.Name = "lblrfid"
        Me.lblrfid.Size = New System.Drawing.Size(31, 13)
        Me.lblrfid.TabIndex = 110
        Me.lblrfid.Text = "lblrfid"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(235, 296)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 23)
        Me.Button2.TabIndex = 109
        Me.Button2.Text = "Mulai"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lbljamout
        '
        Me.lbljamout.AutoSize = True
        Me.lbljamout.Location = New System.Drawing.Point(417, 357)
        Me.lbljamout.Name = "lbljamout"
        Me.lbljamout.Size = New System.Drawing.Size(26, 13)
        Me.lbljamout.TabIndex = 108
        Me.lbljamout.Text = "Jam"
        '
        'lbltglout
        '
        Me.lbltglout.AutoSize = True
        Me.lbltglout.Location = New System.Drawing.Point(417, 344)
        Me.lbltglout.Name = "lbltglout"
        Me.lbltglout.Size = New System.Drawing.Size(46, 13)
        Me.lbltglout.TabIndex = 107
        Me.lbltglout.Text = "Tanggal"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(354, 357)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 106
        Me.Label12.Text = "Jam"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(354, 344)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 105
        Me.Label13.Text = "Tanggal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(353, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "Keluar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(354, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Masuk"
        '
        'txtrfid
        '
        Me.txtrfid.Location = New System.Drawing.Point(85, 321)
        Me.txtrfid.Name = "txtrfid"
        Me.txtrfid.Size = New System.Drawing.Size(138, 20)
        Me.txtrfid.TabIndex = 101
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "IP Cam"
        '
        'txtip
        '
        Me.txtip.Location = New System.Drawing.Point(67, 272)
        Me.txtip.Name = "txtip"
        Me.txtip.Size = New System.Drawing.Size(273, 20)
        Me.txtip.TabIndex = 99
        '
        'lblalamatin
        '
        Me.lblalamatin.AutoSize = True
        Me.lblalamatin.Location = New System.Drawing.Point(82, 365)
        Me.lblalamatin.Name = "lblalamatin"
        Me.lblalamatin.Size = New System.Drawing.Size(35, 13)
        Me.lblalamatin.TabIndex = 98
        Me.lblalamatin.Text = "Nama"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 365)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Alamat"
        '
        'lbljamin
        '
        Me.lbljamin.AutoSize = True
        Me.lbljamin.Location = New System.Drawing.Point(417, 170)
        Me.lbljamin.Name = "lbljamin"
        Me.lbljamin.Size = New System.Drawing.Size(26, 13)
        Me.lbljamin.TabIndex = 96
        Me.lbljamin.Text = "Jam"
        '
        'lbltglin
        '
        Me.lbltglin.AutoSize = True
        Me.lbltglin.Location = New System.Drawing.Point(417, 157)
        Me.lbltglin.Name = "lbltglin"
        Me.lbltglin.Size = New System.Drawing.Size(46, 13)
        Me.lbltglin.TabIndex = 95
        Me.lbltglin.Text = "Tanggal"
        '
        'lblnamain
        '
        Me.lblnamain.AutoSize = True
        Me.lblnamain.Location = New System.Drawing.Point(82, 352)
        Me.lblnamain.Name = "lblnamain"
        Me.lblnamain.Size = New System.Drawing.Size(35, 13)
        Me.lblnamain.TabIndex = 94
        Me.lblnamain.Text = "Nama"
        '
        'lbljenisin
        '
        Me.lbljenisin.AutoSize = True
        Me.lbljenisin.Location = New System.Drawing.Point(84, 306)
        Me.lbljenisin.Name = "lbljenisin"
        Me.lbljenisin.Size = New System.Drawing.Size(59, 13)
        Me.lbljenisin.TabIndex = 93
        Me.lbljenisin.Text = "Jenis Kartu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(354, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Jam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(354, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Tanggal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "RFID No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Jenis Kartu"
        '
        'AxVLCPlugin21
        '
        Me.AxVLCPlugin21.Enabled = True
        Me.AxVLCPlugin21.Location = New System.Drawing.Point(20, 15)
        Me.AxVLCPlugin21.Name = "AxVLCPlugin21"
        Me.AxVLCPlugin21.OcxState = CType(resources.GetObject("AxVLCPlugin21.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVLCPlugin21.Size = New System.Drawing.Size(320, 240)
        Me.AxVLCPlugin21.TabIndex = 112
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(356, 221)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(202, 120)
        Me.PictureBox2.TabIndex = 102
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(356, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 120)
        Me.PictureBox1.TabIndex = 87
        Me.PictureBox1.TabStop = False
        '
        'TransKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 388)
        Me.Controls.Add(Me.AxVLCPlugin21)
        Me.Controls.Add(Me.lblbmp)
        Me.Controls.Add(Me.lblrfid)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lbljamout)
        Me.Controls.Add(Me.lbltglout)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtrfid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtip)
        Me.Controls.Add(Me.lblalamatin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbljamin)
        Me.Controls.Add(Me.lbltglin)
        Me.Controls.Add(Me.lblnamain)
        Me.Controls.Add(Me.lbljenisin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "TransKeluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pintu Keluar"
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblbmp As System.Windows.Forms.Label
    Friend WithEvents lblrfid As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lbljamout As System.Windows.Forms.Label
    Friend WithEvents lbltglout As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtrfid As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtip As System.Windows.Forms.TextBox
    Friend WithEvents lblalamatin As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbljamin As System.Windows.Forms.Label
    Friend WithEvents lbltglin As System.Windows.Forms.Label
    Friend WithEvents lblnamain As System.Windows.Forms.Label
    Friend WithEvents lbljenisin As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents AxVLCPlugin21 As AxAXVLC.AxVLCPlugin2
End Class
