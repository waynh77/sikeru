<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PicInfo = New System.Windows.Forms.PictureBox()
        Me.PicIn = New System.Windows.Forms.PictureBox()
        Me.PicX = New System.Windows.Forms.PictureBox()
        CType(Me.PicInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(268, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Info"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(306, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Exit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(227, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Login"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordTextBox.Location = New System.Drawing.Point(83, 64)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(139, 20)
        Me.PasswordTextBox.TabIndex = 70
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.Color.White
        Me.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsernameTextBox.Location = New System.Drawing.Point(83, 38)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(139, 20)
        Me.UsernameTextBox.TabIndex = 68
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(18, 61)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(69, 23)
        Me.PasswordLabel.TabIndex = 69
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(18, 35)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(69, 23)
        Me.UsernameLabel.TabIndex = 67
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(33, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "SISTEM INFORMASI KEAMANAN PERUMAHAN"
        '
        'PicInfo
        '
        Me.PicInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicInfo.Image = Global.sikeru.My.Resources.Resources.INFO
        Me.PicInfo.Location = New System.Drawing.Point(265, 38)
        Me.PicInfo.Name = "PicInfo"
        Me.PicInfo.Size = New System.Drawing.Size(32, 32)
        Me.PicInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicInfo.TabIndex = 75
        Me.PicInfo.TabStop = False
        '
        'PicIn
        '
        Me.PicIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicIn.Image = Global.sikeru.My.Resources.Resources.LOGIN
        Me.PicIn.Location = New System.Drawing.Point(227, 38)
        Me.PicIn.Name = "PicIn"
        Me.PicIn.Size = New System.Drawing.Size(32, 32)
        Me.PicIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicIn.TabIndex = 72
        Me.PicIn.TabStop = False
        '
        'PicX
        '
        Me.PicX.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicX.Image = Global.sikeru.My.Resources.Resources.delete
        Me.PicX.Location = New System.Drawing.Point(303, 38)
        Me.PicX.Name = "PicX"
        Me.PicX.Size = New System.Drawing.Size(32, 32)
        Me.PicX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicX.TabIndex = 71
        Me.PicX.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 114)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PicInfo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PicIn)
        Me.Controls.Add(Me.PicX)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        CType(Me.PicInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PicInfo As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PicIn As System.Windows.Forms.PictureBox
    Friend WithEvents PicX As System.Windows.Forms.PictureBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
