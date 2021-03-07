<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegTamu
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
        Me.lblidtamu = New System.Windows.Forms.Label()
        Me.lblidtrans = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbjenis = New System.Windows.Forms.ComboBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.txttujuan = New System.Windows.Forms.TextBox()
        Me.lblrfid = New System.Windows.Forms.Label()
        Me.lbltgljam = New System.Windows.Forms.Label()
        Me.picmasuk = New System.Windows.Forms.PictureBox()
        Me.picid = New System.Windows.Forms.PictureBox()
        Me.PicDel = New System.Windows.Forms.PictureBox()
        Me.PicSave = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblgbr = New System.Windows.Forms.Label()
        CType(Me.picmasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblidtamu
        '
        Me.lblidtamu.AutoSize = True
        Me.lblidtamu.Location = New System.Drawing.Point(13, 13)
        Me.lblidtamu.Name = "lblidtamu"
        Me.lblidtamu.Size = New System.Drawing.Size(43, 13)
        Me.lblidtamu.TabIndex = 0
        Me.lblidtamu.Text = "idTAmu"
        '
        'lblidtrans
        '
        Me.lblidtrans.AutoSize = True
        Me.lblidtrans.Location = New System.Drawing.Point(98, 13)
        Me.lblidtrans.Name = "lblidtrans"
        Me.lblidtrans.Size = New System.Drawing.Size(43, 13)
        Me.lblidtrans.TabIndex = 1
        Me.lblidtrans.Text = "IdTrans"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No Identitas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(274, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tujuan"
        '
        'cmbjenis
        '
        Me.cmbjenis.FormattingEnabled = True
        Me.cmbjenis.Items.AddRange(New Object() {"KTP", "SIM", "Kartu Pelajar"})
        Me.cmbjenis.Location = New System.Drawing.Point(67, 29)
        Me.cmbjenis.Name = "cmbjenis"
        Me.cmbjenis.Size = New System.Drawing.Size(121, 21)
        Me.cmbjenis.TabIndex = 6
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(67, 57)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(192, 20)
        Me.txtnama.TabIndex = 7
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(344, 28)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(192, 20)
        Me.txtno.TabIndex = 8
        '
        'txttujuan
        '
        Me.txttujuan.Location = New System.Drawing.Point(344, 54)
        Me.txttujuan.Name = "txttujuan"
        Me.txttujuan.Size = New System.Drawing.Size(192, 20)
        Me.txttujuan.TabIndex = 9
        '
        'lblrfid
        '
        Me.lblrfid.AutoSize = True
        Me.lblrfid.Location = New System.Drawing.Point(543, 9)
        Me.lblrfid.Name = "lblrfid"
        Me.lblrfid.Size = New System.Drawing.Size(40, 13)
        Me.lblrfid.TabIndex = 11
        Me.lblrfid.Text = "RfidNo"
        '
        'lbltgljam
        '
        Me.lbltgljam.AutoSize = True
        Me.lbltgljam.Location = New System.Drawing.Point(542, 32)
        Me.lbltgljam.Name = "lbltgljam"
        Me.lbltgljam.Size = New System.Drawing.Size(41, 13)
        Me.lbltgljam.TabIndex = 12
        Me.lbltgljam.Text = "TglJam"
        '
        'picmasuk
        '
        Me.picmasuk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picmasuk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picmasuk.Location = New System.Drawing.Point(542, 83)
        Me.picmasuk.Name = "picmasuk"
        Me.picmasuk.Size = New System.Drawing.Size(126, 83)
        Me.picmasuk.TabIndex = 13
        Me.picmasuk.TabStop = False
        '
        'picid
        '
        Me.picid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picid.Location = New System.Drawing.Point(542, 183)
        Me.picid.Name = "picid"
        Me.picid.Size = New System.Drawing.Size(126, 83)
        Me.picid.TabIndex = 14
        Me.picid.TabStop = False
        '
        'PicDel
        '
        Me.PicDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicDel.Image = Global.sikeru.My.Resources.Resources.Door
        Me.PicDel.Location = New System.Drawing.Point(636, 282)
        Me.PicDel.Name = "PicDel"
        Me.PicDel.Size = New System.Drawing.Size(32, 32)
        Me.PicDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicDel.TabIndex = 81
        Me.PicDel.TabStop = False
        '
        'PicSave
        '
        Me.PicSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicSave.Image = Global.sikeru.My.Resources.Resources.save
        Me.PicSave.Location = New System.Drawing.Point(598, 282)
        Me.PicSave.Name = "PicSave"
        Me.PicSave.Size = New System.Drawing.Size(32, 32)
        Me.PicSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicSave.TabIndex = 80
        Me.PicSave.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(539, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Gbr Masuk"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(539, 167)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Gbr Identitas"
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(19, 83)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.RowHeadersVisible = False
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(514, 231)
        Me.dgv1.TabIndex = 84
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(540, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 41)
        Me.Button1.TabIndex = 85
        Me.Button1.Text = "Ambil Gambar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblgbr
        '
        Me.lblgbr.AutoSize = True
        Me.lblgbr.Location = New System.Drawing.Point(542, 253)
        Me.lblgbr.Name = "lblgbr"
        Me.lblgbr.Size = New System.Drawing.Size(39, 13)
        Me.lblgbr.TabIndex = 86
        Me.lblgbr.Text = "Label1"
        '
        'RegTamu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 326)
        Me.Controls.Add(Me.lblgbr)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PicDel)
        Me.Controls.Add(Me.PicSave)
        Me.Controls.Add(Me.picid)
        Me.Controls.Add(Me.picmasuk)
        Me.Controls.Add(Me.lbltgljam)
        Me.Controls.Add(Me.lblrfid)
        Me.Controls.Add(Me.txttujuan)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.cmbjenis)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblidtrans)
        Me.Controls.Add(Me.lblidtamu)
        Me.Name = "RegTamu"
        Me.Text = "Registrasi Tamu"
        CType(Me.picmasuk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblidtamu As System.Windows.Forms.Label
    Friend WithEvents lblidtrans As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbjenis As System.Windows.Forms.ComboBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents txttujuan As System.Windows.Forms.TextBox
    Friend WithEvents lblrfid As System.Windows.Forms.Label
    Friend WithEvents lbltgljam As System.Windows.Forms.Label
    Friend WithEvents picmasuk As System.Windows.Forms.PictureBox
    Friend WithEvents picid As System.Windows.Forms.PictureBox
    Friend WithEvents PicDel As System.Windows.Forms.PictureBox
    Friend WithEvents PicSave As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblgbr As System.Windows.Forms.Label
End Class
