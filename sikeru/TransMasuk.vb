Public Class TransMasuk

    Private Sub TransMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        lblBmp.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With Setting
            .MdiParent = main1
            .Show()
            .Top = 0
            .Left = 0

            Me.Close()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With RegTamu
            .MdiParent = main1
            .Show()
            .Top = 0
            .Left = 0

            Me.Close()
        End With
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
                Sql = "select * from trgate where rfidno=" & Aphostrophe(lblrfid.Text) & " and sts=0 and inout='IN'"
                Tabel = Proses.executequery(Sql)
                If Tabel.Rows.Count > 0 Then
                    'MsgBox("Kendaraan masih di dalam area", vbInformation, "Cek kendaraan")
                    My.Computer.Audio.Play(Application.StartupPath & "\area.wav")
                Else
                    lbltglin.Text = Format(Now, "dd MMM yyyy")
                    lbljamin.Text = Format(Now, "hh:mm:ss")
                    Clipboard.Clear()
                    AxVLCPlugin21.video.takeSnapshot()
                    Dim tgljam As String = Now
                    Dim sFile = Dir(Application.StartupPath & "\*.bmp")
                    Do Until sFile = ""
                        'If tgljam = FileDateTime(sFile) Then
                        lblBmp.Text = sFile
                        'End If
                        sFile = Dir()
                    Loop

                    Dim Filename As String = Application.StartupPath & "\" & lblBmp.Text
                    Dim NewFileName As String = Application.StartupPath & "\Gbr\In-" & Format(Now, "yyyyMMddHHmmss") & ".bmp"

                    My.Computer.FileSystem.CopyFile(Filename, NewFileName)
                    My.Computer.FileSystem.DeleteFile(Filename)
                    If Dir$(NewFileName) <> "" Then
                        PictureBox1.BackgroundImage = Bitmap.FromFile(NewFileName)
                    End If

                    Sql = "insert into trgate(rfidno,inout,tgljam,jenistrans,gbr)values(" & Aphostrophe(lblrfid.Text) & ",'IN'," & Aphostrophe(tgljam) & "," & Aphostrophe(lbljenisin.Text) & "," & Aphostrophe(NewFileName) & ")"
                    Proses.executenonquery(Sql)

                    If Trim(lbljenisin.Text) = "Tamu" Then
                        Dim idtr As Integer
                        Sql = "select top 1 idtrans from trgate order by idtrans desc"
                        Tabel = Proses.executequery(Sql)
                        idtr = Tabel.Rows(0).Item("idtrans")
                        Sql = "insert into trtamu(idtrans)values(" & idtr & ")"
                        Proses.executenonquery(Sql)
                    End If
                    My.Computer.Audio.Play(Application.StartupPath & "\datang.wav")
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