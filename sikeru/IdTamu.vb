Public Class IdTamu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clipboard.Clear()
        AxVLCPlugin21.video.takeSnapshot()
        Dim sFile = Dir(Application.StartupPath & "\*.bmp")
        Do Until sFile = ""
            'If tgljam = FileDateTime(sFile) Then
            lblBmp.Text = sFile
            'End If
            sFile = Dir()
        Loop

        Dim Filename As String = Application.StartupPath & "\" & lblBmp.Text
        Dim NewFileName As String = Application.StartupPath & "\tamu\" & Me.Text & ".bmp"

        sFile = Dir(Application.StartupPath & "\tamu\")
        Dim cek As Boolean = False
        Do Until sFile = ""
            If Me.Text & ".bmp" = sFile Then
                cek = True
            End If
            sFile = Dir()
        Loop
        If cek = True Then
            My.Computer.FileSystem.DeleteFile(NewFileName)
        End If
        My.Computer.FileSystem.CopyFile(Filename, NewFileName)
        My.Computer.FileSystem.DeleteFile(Filename)
        If Dir$(NewFileName) <> "" Then
            RegTamu.picid.BackgroundImage = Bitmap.FromFile(NewFileName)
            RegTamu.lblgbr.Text = NewFileName
        End If
        MsgBox("Berhasil ambil gambar identitas", vbInformation, "Gambar Id")
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxVLCPlugin21.playlist.stop()
        Me.Close()
    End Sub

    Private Sub IdTamu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxVLCPlugin21.playlist.add("dshow://")
        AxVLCPlugin21.volume = 0
        AxVLCPlugin21.playlist.play()
    End Sub
End Class