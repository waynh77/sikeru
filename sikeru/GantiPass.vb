Public Class GantiPass

    Private Sub GantiPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tt.SetToolTip(PicSave, "Simpan")
        Tt.SetToolTip(PicDel, "Keluar")

    End Sub

    Private Sub PicSave_Click(sender As Object, e As EventArgs) Handles PicSave.Click
        If PasswordTextBox.Text = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data belum lengkap", vbInformation, "Cek")
        Else
            Sql = "select * from msuser where username=" & Aphostrophe(namauser)
            Tabel = Proses.executequery(Sql)
            Dim pas As String = Tabel.Rows(0).Item("Password")
            If Trim(pas) = Trim(PasswordTextBox.Text) Then
                If TextBox1.Text = TextBox2.Text Then
                    Sql = "update msuser set password=" & Aphostrophe(TextBox1.Text)
                    Proses.executenonquery(Sql)
                    MsgBox("Berhasil ganti password", vbInformation, "Berhasil")
                    Me.Close()
                Else
                    MsgBox("Password baru tidak sama", vbInformation, "Cek")
                End If
            Else
                MsgBox("Password lama salah", vbInformation, "Cek")
            End If
        End If
    End Sub

    Private Sub PicDel_Click(sender As Object, e As EventArgs) Handles PicDel.Click
        Me.Close()
    End Sub
End Class