<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrasi
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
        Me.PicDel = New System.Windows.Forms.PictureBox()
        Me.PicEdit = New System.Windows.Forms.PictureBox()
        Me.PicAdd = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.PicFind = New System.Windows.Forms.PictureBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        CType(Me.PicDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicDel
        '
        Me.PicDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicDel.Image = Global.sikeru.My.Resources.Resources.delete
        Me.PicDel.Location = New System.Drawing.Point(431, 12)
        Me.PicDel.Name = "PicDel"
        Me.PicDel.Size = New System.Drawing.Size(32, 32)
        Me.PicDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicDel.TabIndex = 78
        Me.PicDel.TabStop = False
        '
        'PicEdit
        '
        Me.PicEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicEdit.Image = Global.sikeru.My.Resources.Resources.edit
        Me.PicEdit.Location = New System.Drawing.Point(382, 12)
        Me.PicEdit.Name = "PicEdit"
        Me.PicEdit.Size = New System.Drawing.Size(32, 32)
        Me.PicEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicEdit.TabIndex = 77
        Me.PicEdit.TabStop = False
        '
        'PicAdd
        '
        Me.PicAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicAdd.Image = Global.sikeru.My.Resources.Resources.Add
        Me.PicAdd.Location = New System.Drawing.Point(333, 12)
        Me.PicAdd.Name = "PicAdd"
        Me.PicAdd.Size = New System.Drawing.Size(32, 32)
        Me.PicAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicAdd.TabIndex = 76
        Me.PicAdd.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.sikeru.My.Resources.Resources.Door
        Me.PictureBox2.Location = New System.Drawing.Point(507, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 80
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "RFID No"
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(70, 24)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(190, 20)
        Me.txtcari.TabIndex = 82
        '
        'PicFind
        '
        Me.PicFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicFind.Image = Global.sikeru.My.Resources.Resources.find
        Me.PicFind.Location = New System.Drawing.Point(266, 12)
        Me.PicFind.Name = "PicFind"
        Me.PicFind.Size = New System.Drawing.Size(32, 32)
        Me.PicFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicFind.TabIndex = 83
        Me.PicFind.TabStop = False
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(12, 50)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.RowHeadersVisible = False
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(527, 292)
        Me.dgv1.TabIndex = 84
        '
        'registrasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 354)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.PicFind)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PicDel)
        Me.Controls.Add(Me.PicEdit)
        Me.Controls.Add(Me.PicAdd)
        Me.Name = "registrasi"
        Me.Text = "Registrasi Kartu"
        CType(Me.PicDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicDel As System.Windows.Forms.PictureBox
    Friend WithEvents PicEdit As System.Windows.Forms.PictureBox
    Friend WithEvents PicAdd As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents PicFind As System.Windows.Forms.PictureBox
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
End Class
