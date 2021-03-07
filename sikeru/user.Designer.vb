<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PicAdd = New System.Windows.Forms.PictureBox()
        Me.PicEdit = New System.Windows.Forms.PictureBox()
        Me.PicDel = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data User"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(27, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(240, 317)
        Me.DataGridView1.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(274, 43)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(494, 317)
        Me.DataGridView2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(270, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hak Akses"
        '
        'PicAdd
        '
        Me.PicAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicAdd.Image = Global.sikeru.My.Resources.Resources.Add
        Me.PicAdd.Location = New System.Drawing.Point(638, 8)
        Me.PicAdd.Name = "PicAdd"
        Me.PicAdd.Size = New System.Drawing.Size(32, 32)
        Me.PicAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicAdd.TabIndex = 73
        Me.PicAdd.TabStop = False
        '
        'PicEdit
        '
        Me.PicEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicEdit.Image = Global.sikeru.My.Resources.Resources.edit
        Me.PicEdit.Location = New System.Drawing.Point(687, 8)
        Me.PicEdit.Name = "PicEdit"
        Me.PicEdit.Size = New System.Drawing.Size(32, 32)
        Me.PicEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicEdit.TabIndex = 74
        Me.PicEdit.TabStop = False
        '
        'PicDel
        '
        Me.PicDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicDel.Image = Global.sikeru.My.Resources.Resources.delete
        Me.PicDel.Location = New System.Drawing.Point(736, 8)
        Me.PicDel.Name = "PicDel"
        Me.PicDel.Size = New System.Drawing.Size(32, 32)
        Me.PicDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicDel.TabIndex = 75
        Me.PicDel.TabStop = False
        '
        'user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 373)
        Me.Controls.Add(Me.PicDel)
        Me.Controls.Add(Me.PicEdit)
        Me.Controls.Add(Me.PicAdd)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "user"
        Me.Text = "User Management"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PicAdd As System.Windows.Forms.PictureBox
    Friend WithEvents PicEdit As System.Windows.Forms.PictureBox
    Friend WithEvents PicDel As System.Windows.Forms.PictureBox
End Class
