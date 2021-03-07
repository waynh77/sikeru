<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegDetail
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
        Me.cekaktif = New System.Windows.Forms.CheckBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtrfid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PicDel = New System.Windows.Forms.PictureBox()
        Me.PicSave = New System.Windows.Forms.PictureBox()
        Me.lblstatus = New System.Windows.Forms.Label()
        CType(Me.PicDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cekaktif
        '
        Me.cekaktif.AutoSize = True
        Me.cekaktif.Location = New System.Drawing.Point(14, 97)
        Me.cekaktif.Name = "cekaktif"
        Me.cekaktif.Size = New System.Drawing.Size(47, 17)
        Me.cekaktif.TabIndex = 17
        Me.cekaktif.Text = "Aktif"
        Me.cekaktif.UseVisualStyleBackColor = True
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(374, 55)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(225, 59)
        Me.txtalamat.TabIndex = 16
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(374, 9)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(225, 20)
        Me.txtnama.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(333, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(333, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Nama"
        '
        'txtrfid
        '
        Me.txtrfid.Location = New System.Drawing.Point(88, 55)
        Me.txtrfid.Name = "txtrfid"
        Me.txtrfid.Size = New System.Drawing.Size(225, 20)
        Me.txtrfid.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "RFID No"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Penghuni", "Tamu"})
        Me.ComboBox1.Location = New System.Drawing.Point(88, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(162, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Jenis Kartu"
        '
        'PicDel
        '
        Me.PicDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicDel.Image = Global.sikeru.My.Resources.Resources.delete
        Me.PicDel.Location = New System.Drawing.Point(626, 68)
        Me.PicDel.Name = "PicDel"
        Me.PicDel.Size = New System.Drawing.Size(32, 32)
        Me.PicDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicDel.TabIndex = 77
        Me.PicDel.TabStop = False
        '
        'PicSave
        '
        Me.PicSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicSave.Image = Global.sikeru.My.Resources.Resources.save
        Me.PicSave.Location = New System.Drawing.Point(626, 12)
        Me.PicSave.Name = "PicSave"
        Me.PicSave.Size = New System.Drawing.Size(32, 32)
        Me.PicSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicSave.TabIndex = 76
        Me.PicSave.TabStop = False
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Location = New System.Drawing.Point(85, 98)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(39, 13)
        Me.lblstatus.TabIndex = 78
        Me.lblstatus.Text = "Alamat"
        '
        'RegDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 131)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.PicDel)
        Me.Controls.Add(Me.PicSave)
        Me.Controls.Add(Me.cekaktif)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtrfid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegDetail"
        Me.Text = "RegDetail"
        CType(Me.PicDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cekaktif As System.Windows.Forms.CheckBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtrfid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PicDel As System.Windows.Forms.PictureBox
    Friend WithEvents PicSave As System.Windows.Forms.PictureBox
    Friend WithEvents lblstatus As System.Windows.Forms.Label
End Class
