Public Class registrasi

    Private Sub registrasi_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        isigrid()
    End Sub

    Private Sub registrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tt.SetToolTip(PicAdd, "Tambah")
        Tt.SetToolTip(PicEdit, "Edit")
        Tt.SetToolTip(PicDel, "Hapus")
        Tt.SetToolTip(PicFind, "Cari")
        Tt.SetToolTip(PictureBox2, "Keluar")
    End Sub

    Sub isigrid()
        Sql = "select * from mskartu"
        Tabel = Proses.executequery(Sql)
        dgv1.DataSource = Tabel
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PicAdd_Click(sender As Object, e As EventArgs) Handles PicAdd.Click
        With RegDetail
            .MdiParent = main1
            .lblstatus.Text = "Tambah"
            .Show()
            .Top = 0
            .Left = 0
            Me.Close()
        End With
    End Sub

    Private Sub PicEdit_Click(sender As Object, e As EventArgs) Handles PicEdit.Click
        With RegDetail
            .MdiParent = main1
            .lblstatus.Text = dgv1.Item("rfidno", dgv1.CurrentRow.Index).Value
            .Show()
            .Top = 0
            .Left = 0
            Me.Close()
        End With
    End Sub

    Private Sub PicFind_Click(sender As Object, e As EventArgs) Handles PicFind.Click
        cari()
    End Sub

    Sub cari()
        If txtcari.Text = "" Then
            Sql = "select * from mskartu"
        Else
            Sql = "select * from mskartu where rfidno=" & Aphostrophe(txtcari.Text)
        End If
        Tabel = Proses.executequery(Sql)
        dgv1.DataSource = Tabel
        txtcari.Text = ""
    End Sub

    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        If e.KeyChar = Chr(13) Then
            cari()
        End If
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged

    End Sub

    Private Sub PicDel_Click(sender As Object, e As EventArgs) Handles PicDel.Click
        Dim tny As String = MsgBox("Apakah anda yakin hapus", vbYesNo, "Hapus")
        Dim rfid As String = dgv1.Item("rfidno", dgv1.CurrentRow.Index).Value
        If tny = vbYes Then
            Sql = "delete from mskartu where rfidno=" & Aphostrophe(rfid)
            Proses.executenonquery(Sql)
            MsgBox("Berhasil hapus rfid " & rfid, vbInformation, "Hapus")
            isigrid()
        End If

    End Sub
End Class