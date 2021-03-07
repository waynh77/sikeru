Public Class TransKeluar

    Private Sub TransKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kosong()
        Sql = "select * from msset"
        Tabel = Proses.executequery(Sql)
        txtip.Text = Tabel.Rows(0).Item("masukcam")
    End Sub
    Sub Kosong()
        lblnamain.Text = ""
        lblalamatin.Text = ""
        lbljenisin.Text = ""
        lbltglin.Text = ""
        lbljamin.Text = ""
        txtrfid.Text = ""
        lblrfid.Text = ""
        lblbmp.Text = ""
        lbltglout.Text = ""
        lbljamout.Text = ""
        lblbmp.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Mulai" Then
            Button2.Text = "Stop"

            AxVLCPlugin21.playlist.add(txtip.Text)
            AxVLCPlugin21.playlist.play()
        Else
            Button2.Text = "Mulai"
            AxVLCPlugin21.playlist.stop()

        End If
        txtrfid.Focus()
    End Sub

    Private Sub txtrfid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrfid.KeyPress
        If e.KeyChar = Chr(13) Then

            Sql = "select * from mskartu where rfidno=" & Aphostrophe(txtrfid.Text)
            Tabel = Proses.executequery(Sql)
            lblrfid.Text = txtrfid.Text
            txtrfid.Text = ""
            If Tabel.Rows.Count > 0 Then
                lblnamain.Text = Tabel.Rows(0).Item("Nama")
                lblalamatin.Text = Tabel.Rows(0).Item("alamat")
                lbljenisin.Text = Tabel.Rows(0).Item("jeniskartu")
                Sql = "select top 1 * from trgate where rfidno=" & Aphostrophe(lblrfid.Text) & " and sts=0 and inout='IN'"
                Tabel = Proses.executequery(Sql)
                If Tabel.Rows.Count = 0 Then
                    'MsgBox("Kendaraan masih di dalam area", vbInformation, "Cek kendaraan")
                    'My.Computer.Audio.Play(Application.StartupPath & "\area.wav")
                Else
                    Dim idTrans As Integer = Tabel.Rows(0).Item("idtrans")
                    lbltglin.Text = Format(Tabel.Rows(0).Item("tgljam"), "dd MMM yyyy")
                    lbljamin.Text = Format(Tabel.Rows(0).Item("tgljam"), "hh:mm:ss")
                    lbltglout.Text = Format(Now, "dd MMM yyyy")
                    lbljamout.Text = Format(Now, "hh:mm:ss")
                    PictureBox1.BackgroundImage = Bitmap.FromFile(Tabel.Rows(0).Item("gbr").ToString)
                    Clipboard.Clear()
                    AxVLCPlugin21.video.takeSnapshot()
                    Dim tgljam As String = Now
                    Dim sFile = Dir(Application.StartupPath & "\*.bmp")
                    Do Until sFile = ""
                        'If tgljam = FileDateTime(sFile) Then
                        lblbmp.Text = sFile
                        'End If
                        sFile = Dir()
                    Loop

                    Dim Filename As String = Application.StartupPath & "\" & lblbmp.Text
                    Dim NewFileName As String = Application.StartupPath & "\Gbr\out-" & Format(Now, "yyyyMMddHHmmss") & ".bmp"

                    My.Computer.FileSystem.CopyFile(Filename, NewFileName)
                    My.Computer.FileSystem.DeleteFile(Filename)
                    If Dir$(NewFileName) <> "" Then
                        PictureBox2.BackgroundImage = Bitmap.FromFile(NewFileName)
                    End If

                    Sql = "insert into trgate(rfidno,inout,tgljam,jenistrans,gbr,sts)values(" & Aphostrophe(lblrfid.Text) & ",'OUT'," & Aphostrophe(tgljam) & "," & Aphostrophe(lbljenisin.Text) & "," & Aphostrophe(NewFileName) & ",'True')"
                    Proses.executenonquery(Sql)
                    Sql = "update trgate set sts='True' where idtrans=" & idTrans
                    Proses.executenonquery(Sql)
                    My.Computer.Audio.Play(Application.StartupPath & "\trmksh.wav")
                End If


            Else
                'MsgBox("Rfid tidak diketemukan", vbInformation, "Kartu tidak terdaftar")
                My.Computer.Audio.Play(Application.StartupPath & "\tdkterdaftar.wav")
                Kosong()
            End If
        End If
    End Sub

    Private Sub txtrfid_TextChanged(sender As Object, e As EventArgs) Handles txtrfid.TextChanged

    End Sub
End Class