Public Class user

    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tt.SetToolTip(PicAdd, "Tambah")
        Tt.SetToolTip(PicEdit, "Edit")
        Tt.SetToolTip(PicDel, "Hapus")
        IsiUser()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_RowHeightChanged(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView1.RowHeightChanged

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        IsiUser2()
    End Sub

    Sub IsiUser()
        Sql = "select * from msuser"
        Tabel = Proses.executequery(Sql)
        DataGridView1.DataSource = Tabel
    End Sub

    Sub IsiUser2()
        Sql = "select * from view_user1 where username=" & Aphostrophe(DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value)
        Tabel = Proses.executequery(Sql)
        DataGridView2.DataSource = Tabel

    End Sub
    Private Sub PicAdd_Click(sender As Object, e As EventArgs) Handles PicAdd.Click
        With userDetail
            .MdiParent = main1
            .lblstatus.Text = "Tambah"
            .Show()
            .Top = 0
            .Left = 0
            .UsernameTextBox.Text = ""
            .PasswordTextBox.Text = ""
            Sql = "select * from msmenu"
            Tabel = Proses.executequery(Sql)
            .dgv1.DataSource = Tabel
            Me.Close()
        End With
    End Sub

    Private Sub PicDel_Click(sender As Object, e As EventArgs) Handles PicDel.Click
        Dim tny As String = MsgBox("Apakah anda yakin hapus", vbYesNo, "Hapus")
        Dim nama As String = DataGridView1.Item("username", DataGridView1.CurrentRow.Index).Value
        If nama = "admin" Then
            MsgBox("Admin tidak dapat dihapus", vbInformation, "Hapus")
        Else
            If tny = vbYes Then
                Sql = "delete from msuser where username=" & Aphostrophe(nama)
                Proses.executenonquery(Sql)
                Sql = "delete from trusermenu where username=" & Aphostrophe(nama)
                Proses.executenonquery(Sql)
                MsgBox("Berhasil hapus user " & nama, vbInformation, "Hapus")
                IsiUser()
            End If
        End If
    End Sub

    Private Sub PicEdit_Click(sender As Object, e As EventArgs) Handles PicEdit.Click
        With userDetail
            Dim namauser As String = DataGridView1.Item("username", DataGridView1.CurrentRow.Index).Value
            .MdiParent = main1
            .lblstatus.Text = namauser
            .Show()
            .Top = 0
            .Left = 0
            .UsernameTextBox.Text = namauser
            .PasswordTextBox.Text = DataGridView1.Item("password", DataGridView1.CurrentRow.Index).Value
            Sql = "select idmenu,menu,ket,aktif from view_user1 where username=" & Aphostrophe(namauser)
            Tabel = Proses.executequery(Sql)
            .dgv1.DataSource = Tabel
            Me.Close()
        End With
    End Sub
End Class