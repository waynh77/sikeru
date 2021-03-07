Public Class userDetail

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PicDel.Click
        With user
            .MdiParent = main1
            .Show()
            .Top = 0
            .Left = 0
            Me.Close()
        End With
    End Sub

    Private Sub userDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tt.SetToolTip(PicSave, "Simpan")
        Tt.SetToolTip(PicDel, "Batal")
    End Sub

    Private Sub PicSave_Click(sender As Object, e As EventArgs) Handles PicSave.Click
        dgv1.EndEdit()
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Data belum lengkap", vbInformation, "Gagal")
        Else
            If lblstatus.Text = "Tambah" Then
                Sql = "select * from msuser where username=" & Aphostrophe(UsernameTextBox.Text)
                Tabel = Proses.executequery(Sql)
                If Tabel.Rows.Count > 0 Then
                    MsgBox("User sudah ada", vbInformation, "Gagal")
                Else
                    Sql = "insert into msuser(username,password)values(" & Aphostrophe(UsernameTextBox.Text) & "," & Aphostrophe(PasswordTextBox.Text) & ")"
                    Proses.executenonquery(Sql)
                    With dgv1
                        Dim akt As Boolean
                        For j = 0 To dgv1.Rows.Count - 1
                            akt = dgv1.Item("aktif", j).Value
                            Sql = "insert into trusermenu(username,idmenu,aktif)values(" & Aphostrophe(UsernameTextBox.Text) & "," & dgv1.Item("idmenu", j).Value & "," & Aphostrophe(akt) & ")"
                            Proses.executenonquery(Sql)
                        Next
                    End With
                    MsgBox("Berhasil simpan user " & UsernameTextBox.Text, vbInformation, "Simpan")
                    PictureBox1_Click(sender, e)
                End If
            Else
                Sql = "select * from msuser where username=" & Aphostrophe(UsernameTextBox.Text) & " and username<>" & Aphostrophe(lblstatus.Text)
                Tabel = Proses.executequery(Sql)
                If Tabel.Rows.Count > 0 Then
                    MsgBox("User sudah ada", vbInformation, "Gagal")
                Else
                    If lblstatus.Text <> "admin" Then
                        Sql = "update msuser set username=" & Aphostrophe(UsernameTextBox.Text) & ",password=" & Aphostrophe(PasswordTextBox.Text) & " where username=" & Aphostrophe(lblstatus.Text)
                        Proses.executenonquery(Sql)
                        With dgv1
                            Dim akt As Boolean
                            For j = 0 To dgv1.Rows.Count - 1
                                akt = dgv1.Item("aktif", j).Value
                                Sql = "update trusermenu set username=" & Aphostrophe(UsernameTextBox.Text) & ",aktif=" & Aphostrophe(akt) & " where username=" & Aphostrophe(lblstatus.Text) & " and idmenu=" & dgv1.Item("idmenu", j).Value
                                Proses.executenonquery(Sql)
                            Next
                        End With
                    Else
                        Sql = "update msuser set password=" & Aphostrophe(PasswordTextBox.Text) & " where username=" & Aphostrophe(lblstatus.Text)
                        Proses.executenonquery(Sql)
                    End If
                    MsgBox("Berhasil update user " & lblstatus.Text, vbInformation, "Simpan")
                    PictureBox1_Click(sender, e)
                End If
            End If
        End If
    End Sub
End Class