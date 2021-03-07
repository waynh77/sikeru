<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransMasuk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransMasuk))
        Me.lblrfid = New System.Windows.Forms.Label()
        Me.lblBmp = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtrfid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtip = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblrfid
        '
        Me.lblrfid.AutoSize = True
        Me.lblrfid.BackColor = System.Drawing.Color.Transparent
        Me.lblrfid.Location = New System.Drawing.Point(350, 119)
        Me.lblrfid.Name = "lblrfid"
        Me.lblrfid.Size = New System.Drawing.Size(39, 13)
        Me.lblrfid.TabIndex = 58
        Me.lblrfid.Text = "Label8"
        '
        'lblBmp
        '
        Me.lblBmp.AutoSize = True
        Me.lblBmp.BackColor = System.Drawing.Color.Transparent
        Me.lblBmp.Location = New System.Drawing.Point(18, 236)
        Me.lblBmp.Name = "lblBmp"
        Me.lblBmp.Size = New System.Drawing.Size(39, 13)
        Me.lblBmp.TabIndex = 57
        Me.lblBmp.Text = "Label8"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(449, 236)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 23)
        Me.Button3.TabIndex = 56
        Me.Button3.Text = "Setting"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(342, 236)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 23)
        Me.Button2.TabIndex = 55
        Me.Button2.Text = "Mulai"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtrfid
        '
        Me.txtrfid.Location = New System.Drawing.Point(416, 150)
        Me.txtrfid.Name = "txtrfid"
        Me.txtrfid.Size = New System.Drawing.Size(138, 20)
        Me.txtrfid.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "IP Cam"
        '
        'txtip
        '
        Me.txtip.Location = New System.Drawing.Point(63, 265)
        Me.txtip.Name = "txtip"
        Me.txtip.Size = New System.Drawing.Size(273, 20)
        Me.txtip.TabIndex = 52
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(342, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(212, 23)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Registrasi Tamu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblalamatin
        '
        Me.lblalamatin.AutoSize = True
        Me.lblalamatin.Location = New System.Drawing.Point(413, 194)
        Me.lblalamatin.Name = "lblalamatin"
        Me.lblalamatin.Size = New System.Drawing.Size(35, 13)
        Me.lblalamatin.TabIndex = 50
        Me.lblalamatin.Text = "Nama"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(350, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Alamat"
        '
        'lbljamin
        '
        Me.lbljamin.AutoSize = True
        Me.lbljamin.Location = New System.Drawing.Point(413, 220)
        Me.lbljamin.Name = "lbljamin"
        Me.lbljamin.Size = New System.Drawing.Size(26, 13)
        Me.lbljamin.TabIndex = 48
        Me.lbljamin.Text = "Jam"
        '
        'lbltglin
        '
        Me.lbltglin.AutoSize = True
        Me.lbltglin.Location = New System.Drawing.Point(413, 207)
        Me.lbltglin.Name = "lbltglin"
        Me.lbltglin.Size = New System.Drawing.Size(46, 13)
        Me.lbltglin.TabIndex = 47
        Me.lbltglin.Text = "Tanggal"
        '
        'lblnamain
        '
        Me.lblnamain.AutoSize = True
        Me.lblnamain.Location = New System.Drawing.Point(413, 181)
        Me.lblnamain.Name = "lblnamain"
        Me.lblnamain.Size = New System.Drawing.Size(35, 13)
        Me.lblnamain.TabIndex = 46
        Me.lblnamain.Text = "Nama"
        '
        'lbljenisin
        '
        Me.lbljenisin.AutoSize = True
        Me.lbljenisin.Location = New System.Drawing.Point(415, 135)
        Me.lbljenisin.Name = "lbljenisin"
        Me.lbljenisin.Size = New System.Drawing.Size(59, 13)
        Me.lbljenisin.TabIndex = 45
        Me.lbljenisin.Text = "Jenis Kartu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(350, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Jam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(350, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Tanggal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(350, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "RFID No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(350, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(350, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Jenis Kartu"
        '
        'AxVLCPlugin21
        '
        Me.AxVLCPlugin21.Enabled = True
        Me.AxVLCPlugin21.Location = New System.Drawing.Point(19, 9)
        Me.AxVLCPlugin21.Name = "AxVLCPlugin21"
        Me.AxVLCPlugin21.OcxState = CType(resources.GetObject("AxVLCPlugin21.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVLCPlugin21.Size = New System.Drawing.Size(320, 240)
        Me.AxVLCPlugin21.TabIndex = 59
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(352, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 120)
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'TransMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 296)
        Me.Controls.Add(Me.AxVLCPlugin21)
        Me.Controls.Add(Me.lblrfid)
        Me.Controls.Add(Me.lblBmp)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtrfid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtip)
        Me.Controls.Add(Me.Button1)
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
        Me.Name = "TransMasuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransMasuk"
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblrfid As System.Windows.Forms.Label
    Friend WithEvents lblBmp As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtrfid As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtip As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
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
