<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.dtp4 = New System.Windows.Forms.DateTimePicker()
        Me.dtp3 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PicDel = New System.Windows.Forms.PictureBox()
        Me.PicCetak = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PicDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCetak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Waktu Awal"
        '
        'dtp1
        '
        Me.dtp1.Location = New System.Drawing.Point(15, 25)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(200, 20)
        Me.dtp1.TabIndex = 1
        '
        'dtp2
        '
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp2.Location = New System.Drawing.Point(221, 25)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(93, 20)
        Me.dtp2.TabIndex = 2
        '
        'dtp4
        '
        Me.dtp4.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp4.Location = New System.Drawing.Point(221, 68)
        Me.dtp4.Name = "dtp4"
        Me.dtp4.Size = New System.Drawing.Size(93, 20)
        Me.dtp4.TabIndex = 5
        '
        'dtp3
        '
        Me.dtp3.Location = New System.Drawing.Point(15, 68)
        Me.dtp3.Name = "dtp3"
        Me.dtp3.Size = New System.Drawing.Size(200, 20)
        Me.dtp3.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Waktu Akhir"
        '
        'PicDel
        '
        Me.PicDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicDel.Image = Global.sikeru.My.Resources.Resources.delete
        Me.PicDel.Location = New System.Drawing.Point(331, 58)
        Me.PicDel.Name = "PicDel"
        Me.PicDel.Size = New System.Drawing.Size(32, 32)
        Me.PicDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicDel.TabIndex = 79
        Me.PicDel.TabStop = False
        '
        'PicCetak
        '
        Me.PicCetak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicCetak.Image = Global.sikeru.My.Resources.Resources.Print2
        Me.PicCetak.Location = New System.Drawing.Point(331, 13)
        Me.PicCetak.Name = "PicCetak"
        Me.PicCetak.Size = New System.Drawing.Size(32, 32)
        Me.PicCetak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicCetak.TabIndex = 78
        Me.PicCetak.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Jenis Transaksi"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(103, 102)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(260, 21)
        Me.ComboBox1.TabIndex = 81
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(103, 129)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(260, 21)
        Me.ComboBox2.TabIndex = 83
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Penghuni/Tamu"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(103, 156)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(260, 21)
        Me.ComboBox3.TabIndex = 85
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Status Transaksi"
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 188)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PicDel)
        Me.Controls.Add(Me.PicCetak)
        Me.Controls.Add(Me.dtp4)
        Me.Controls.Add(Me.dtp3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtp2)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Laporan"
        Me.Text = "Laporan"
        CType(Me.PicDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCetak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PicDel As System.Windows.Forms.PictureBox
    Friend WithEvents PicCetak As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
