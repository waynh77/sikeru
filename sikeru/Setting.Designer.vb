<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setting
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
        Me.txtcam1 = New System.Windows.Forms.TextBox()
        Me.txtcam2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PicDel = New System.Windows.Forms.PictureBox()
        Me.PicSave = New System.Windows.Forms.PictureBox()
        CType(Me.PicDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cam Pintu Masuk"
        '
        'txtcam1
        '
        Me.txtcam1.Location = New System.Drawing.Point(108, 18)
        Me.txtcam1.Name = "txtcam1"
        Me.txtcam1.Size = New System.Drawing.Size(455, 20)
        Me.txtcam1.TabIndex = 1
        '
        'txtcam2
        '
        Me.txtcam2.Location = New System.Drawing.Point(108, 44)
        Me.txtcam2.Name = "txtcam2"
        Me.txtcam2.Size = New System.Drawing.Size(455, 20)
        Me.txtcam2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cam Pintu Keluar"
        '
        'PicDel
        '
        Me.PicDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicDel.Image = Global.sikeru.My.Resources.Resources.delete
        Me.PicDel.Location = New System.Drawing.Point(607, 18)
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
        Me.PicSave.Location = New System.Drawing.Point(569, 18)
        Me.PicSave.Name = "PicSave"
        Me.PicSave.Size = New System.Drawing.Size(32, 32)
        Me.PicSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicSave.TabIndex = 76
        Me.PicSave.TabStop = False
        '
        'Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 83)
        Me.Controls.Add(Me.PicDel)
        Me.Controls.Add(Me.PicSave)
        Me.Controls.Add(Me.txtcam2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcam1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Setting"
        Me.Text = "Setting"
        CType(Me.PicDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcam1 As System.Windows.Forms.TextBox
    Friend WithEvents txtcam2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PicDel As System.Windows.Forms.PictureBox
    Friend WithEvents PicSave As System.Windows.Forms.PictureBox
End Class
