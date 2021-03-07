Public Class login

    Private Sub PicIn_Click(sender As Object, e As EventArgs) Handles PicIn.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("user name/password harus diisi", vbInformation, "Gagal")
            If UsernameTextBox.Text = "" Then
                UsernameTextBox.Focus()
            Else
                PasswordTextBox.Focus()
            End If
        Else
            Sql = "select * from msuser where username=" & Aphostrophe(UsernameTextBox.Text) & " and password=" & Aphostrophe(PasswordTextBox.Text)
            Tabel = Proses.executequery(Sql)
            If Tabel.Rows.Count > 0 Then
                namauser = UsernameTextBox.Text
                main1.TsLblUser.Text = UCase(namauser)
                main1.Show()
                Me.Hide()
                cekUser()
            Else
                MsgBox("user name/password salah", vbInformation, "Gagal")
            End If
        End If
    End Sub

    Sub cekUser()
        Dim akt As Boolean
        Dim id As Byte
        Sql = "select * from trusermenu where username=" & Aphostrophe(namauser) & " order by idmenu asc"
        Tabel = Proses.executequery(Sql)
        With main1
            For i = 0 To Tabel.Rows.Count - 1
                id = Tabel.Rows(i).Item("idmenu")
                akt = Tabel.Rows(i).Item("aktif")
                If id = 1 Then
                    If akt = False Then
                        .AdminToolStripMenuItem.Visible = False
                    Else
                        .AdminToolStripMenuItem.Visible = True
                    End If
                End If
                If id = 2 Then
                    If akt = False Then
                        .RegPenghuniToolStripMenuItem.Visible = False
                        .PicReg.Enabled = False
                    Else
                        .RegPenghuniToolStripMenuItem.Visible = True
                        .PicReg.Enabled = True
                    End If
                End If
                If id = 3 Then
                    If akt = False Then
                        .TransGateToolStripMenuItem.Visible = False
                        .PicPay.Enabled = False
                    Else
                        .TransGateToolStripMenuItem.Visible = True
                        .PicPay.Enabled = True
                    End If
                End If
            Next
        End With
    End Sub

    Private Sub PicX_Click(sender As Object, e As EventArgs) Handles PicX.Click
        Dim tny As String
        tny = MsgBox("Apakah anda yakin?", vbYesNo, "Keluar")
        If tny = vbYes Then
            End
        End If

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tt.SetToolTip(PicIn, "Login")
        Tt.SetToolTip(PicInfo, "Information")
        Tt.SetToolTip(PicX, "Exit")

    End Sub

    Private Sub PicInfo_Click(sender As Object, e As EventArgs) Handles PicInfo.Click

    End Sub

    Private Sub UsernameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameTextBox.KeyPress
        If e.KeyChar = Chr(13) Then
            PasswordTextBox.Focus()
        End If
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub PasswordTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        If e.KeyChar = Chr(13) Then
            PicIn_Click(sender, e)
        End If
    End Sub

    Private Sub PasswordTextBox_MouseMove(sender As Object, e As MouseEventArgs) Handles PasswordTextBox.MouseMove

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
       
    End Sub
End Class
