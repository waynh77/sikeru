<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GantiPass
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PicDel = New System.Windows.Forms.PictureBox()
        Me.PicSave = New System.Windows.Forms.PictureBox()
        CType(Me.PicDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password Lama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password Baru"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ulangi Password Baru"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordTextBox.Location = New System.Drawing.Point(137, 7)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(139, 20)
        Me.PasswordTextBox.TabIndex = 71
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(137, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(139, 20)
        Me.TextBox1.TabIndex = 72
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(137, 60)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(139, 20)
        Me.TextBox2.TabIndex = 73
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'PicDel
        '
        Me.PicDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicDel.Image = Global.sikeru.My.Resources.Resources.delete
        Me.PicDel.Location = New System.Drawing.Point(282, 50)
        Me.PicDel.Name = "PicDel"
        Me.PicDel.Size = New System.Drawing.Size(32, 32)
        Me.PicDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicDel.TabIndex = 79
        Me.PicDel.TabStop = False
        '
        'PicSave
        '
        Me.PicSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicSave.Image = Global.sikeru.My.Resources.Resources.save
        Me.PicSave.Location = New System.Drawing.Point(282, 9)
        Me.PicSave.Name = "PicSave"
        Me.PicSave.Size = New System.Drawing.Size(32, 32)
        Me.PicSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicSave.TabIndex = 78
        Me.PicSave.TabStop = False
        '
        'GantiPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 87)
        Me.Controls.Add(Me.PicDel)
        Me.Controls.Add(Me.PicSave)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GantiPass"
        Me.Text = "Ganti Password"
        CType(Me.PicDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PicDel As System.Windows.Forms.PictureBox
    Friend WithEvents PicSave As System.Windows.Forms.PictureBox
End Class
