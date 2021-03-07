Public Class RegDetail

    Private Sub RegDetail_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Keluar()
    End Sub

    Private Sub RegDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        Tt.SetToolTip(PicSave, "Simpan")
        Tt.SetToolTip(PicDel, "Batal")
        If lblstatus.Text <> "Tambah" Then
            isiData()
        End If
    End Sub

    Sub isiData()
        Sql = "select * from mskartu where rfidno=" & Aphostrophe(lblstatus.Text)
        Tabel = Proses.executequery(Sql)
        If Tabel.Rows.Count > 0 Then
            Dim jenis As String = Trim(Tabel.Rows(0).Item("jeniskartu"))
            If jenis = "Penghuni" Then
                ComboBox1.SelectedIndex = 0
            Else
                ComboBox1.SelectedIndex = 1
            End If
            txtrfid.Text = Tabel.Rows(0).Item("rfidno")
            txtnama.Text = Tabel.Rows(0).Item("nama")
            txtalamat.Text = Tabel.Rows(0).Item("alamat")
            cekaktif.Checked = Tabel.Rows(0).Item("aktif")
        End If

    End Sub

    Private Sub PicSave_Click(sender As Object, e As EventArgs) Handles PicSave.Click
        If txtrfid.Text = "" Or txtnama.Text = "" Then
            MsgBox("Data belum lengkap", vbInformation, "Cek")
        Else
            If lblstatus.Text = "Tambah" Then
                Sql = "select * from mskartu where rfidno=" & Aphostrophe(txtrfid.Text)
                Tabel = Proses.executequery(Sql)
                If Tabel.Rows.Count > 0 Then
                    MsgBox("Rfid sudah digunakan", vbInformation, "Gagal")
                Else
                    Sql = "insert into mskartu(rfidno,jeniskartu,nama,alamat,aktif)values(" & Aphostrophe(txtrfid.Text) & "," & Aphostrophe(ComboBox1.Text) & "," & Aphostrophe(txtnama.Text) & "," & Aphostrophe(txtalamat.Text) & "," & Aphostrophe(cekaktif.Checked) & ")"
                    Proses.executenonquery(Sql)
                    MsgBox("Berhasil tambah kartu " & txtrfid.Text, vbInformation, "Simpan")
                    Keluar()
                End If
            Else
                Sql = "select * from mskartu where rfidno=" & Aphostrophe(txtrfid.Text) & " and rfidno<>" & Aphostrophe(lblstatus.Text)
                Tabel = Proses.executequery(Sql)
                If Tabel.Rows.Count > 0 Then
                    MsgBox("Rfid sudah digunakan", vbInformation, "Gagal")
                Else
                    Sql = "update mskartu set rfidno=" & Aphostrophe(txtrfid.Text) & ",nama=" & Aphostrophe(txtnama.Text) & ",jeniskartu=" & Aphostrophe(ComboBox1.Text) & ",alamat=" & Aphostrophe(txtalamat.Text) & ",aktif=" & Aphostrophe(cekaktif.Checked) & " where rfidno=" & Aphostrophe(lblstatus.Text)
                    Proses.executenonquery(Sql)
                    MsgBox("Berhasil update kartu " & lblstatus.Text, vbInformation, "Simpan")
                    Keluar()
                End If
            End If
        End If
    End Sub

    Sub Keluar()
        With registrasi
            .MdiParent = main1
            .Show()
            .Top = 0
            .Left = 0
            Me.Close()
        End With
    End Sub

    Private Sub PicDel_Click(sender As Object, e As EventArgs) Handles PicDel.Click
        Keluar()
    End Sub
End Class