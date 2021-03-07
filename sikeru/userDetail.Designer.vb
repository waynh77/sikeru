<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userDetail
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
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PicSave = New System.Windows.Forms.PictureBox()
        Me.PicDel = New System.Windows.Forms.PictureBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.IDmenu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namamenu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aktif = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.PicSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Location = New System.Drawing.Point(21, 20)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(39, 13)
        Me.lblstatus.TabIndex = 0
        Me.lblstatus.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordTextBox.Location = New System.Drawing.Point(91, 82)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(180, 20)
        Me.PasswordTextBox.TabIndex = 72
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.Color.White
        Me.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsernameTextBox.Location = New System.Drawing.Point(91, 49)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(180, 20)
        Me.UsernameTextBox.TabIndex = 71
        '
        'PicSave
        '
        Me.PicSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicSave.Image = Global.sikeru.My.Resources.Resources.save
        Me.PicSave.Location = New System.Drawing.Point(378, 50)
        Me.PicSave.Name = "PicSave"
        Me.PicSave.Size = New System.Drawing.Size(32, 32)
        Me.PicSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicSave.TabIndex = 74
        Me.PicSave.TabStop = False
        '
        'PicDel
        '
        Me.PicDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicDel.Image = Global.sikeru.My.Resources.Resources.delete
        Me.PicDel.Location = New System.Drawing.Point(431, 49)
        Me.PicDel.Name = "PicDel"
        Me.PicDel.Size = New System.Drawing.Size(32, 32)
        Me.PicDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicDel.TabIndex = 75
        Me.PicDel.TabStop = False
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDmenu, Me.namamenu, Me.ket, Me.Aktif})
        Me.dgv1.Location = New System.Drawing.Point(12, 119)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowHeadersVisible = False
        Me.dgv1.Size = New System.Drawing.Size(451, 219)
        Me.dgv1.TabIndex = 76
        '
        'IDmenu
        '
        Me.IDmenu.DataPropertyName = "idmenu"
        Me.IDmenu.HeaderText = "Id"
        Me.IDmenu.Name = "IDmenu"
        Me.IDmenu.ReadOnly = True
        Me.IDmenu.Width = 41
        '
        'namamenu
        '
        Me.namamenu.DataPropertyName = "menu"
        Me.namamenu.HeaderText = "Nama Menu"
        Me.namamenu.Name = "namamenu"
        Me.namamenu.ReadOnly = True
        Me.namamenu.Width = 90
        '
        'ket
        '
        Me.ket.DataPropertyName = "ket"
        Me.ket.HeaderText = "Keterangan"
        Me.ket.Name = "ket"
        Me.ket.ReadOnly = True
        Me.ket.Width = 87
        '
        'Aktif
        '
        Me.Aktif.DataPropertyName = "aktif"
        Me.Aktif.HeaderText = "Aktif"
        Me.Aktif.Name = "Aktif"
        Me.Aktif.Width = 34
        '
        'userDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 350)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.PicDel)
        Me.Controls.Add(Me.PicSave)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblstatus)
        Me.Name = "userDetail"
        Me.Text = "Data Pengguna"
        CType(Me.PicSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PicSave As System.Windows.Forms.PictureBox
    Friend WithEvents PicDel As System.Windows.Forms.PictureBox
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDmenu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namamenu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ket As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Aktif As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
