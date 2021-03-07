Public Class RegTamu

    Private Sub RegTamu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kosong()
        IsiGrid()
        Tt.SetToolTip(PicSave, "Simpan")
        Tt.SetToolTip(PicDel, "Keluar")
    End Sub

    Sub IsiGrid()
        Sql = "select top 1000 * from view_regtamu order by idtamu desc"
        Tabel = Proses.executequery(Sql)
        dgv1.DataSource = Tabel
    End Sub

    Sub IsiData()
        If dgv1.RowCount > 0 Then
            Kosong()
            Dim baris As Byte = dgv1.CurrentRow.Index
            With dgv1
                lblidtamu.Text = .Item(0, baris).Value
                lblidtrans.Text = .Item(1, baris).Value
                lblrfid.Text = .Item(2, baris).Value
                lbltgljam.Text = .Item(3, baris).Value
                txtnama.Text = .Item("Nama", baris).Value
                cmbjenis.Text = .Item("Jenisid", baris).Value
                txtno.Text = .Item("Noidentitas", baris).Value
                txttujuan.Text = .Item("Tujuan", baris).Value
                picmasuk.BackgroundImage = Bitmap.FromFile(.Item("gbr", baris).Value)
                lblgbr.Text = .Item("gbrid", baris).Value
                If .Item("gbrid", baris).Value <> "-" Then
                    picid.BackgroundImage = Bitmap.FromFile(.Item("gbrid", baris).Value)
                End If
            End With
        End If
    End Sub

    Sub Kosong()
        lblidtamu.Text = ""
        lblidtrans.Text = ""
        lblrfid.Text = ""
        lbltgljam.Text = ""
        txtnama.Text = ""
        txtno.Text = ""
        txttujuan.Text = ""
        cmbjenis.Text = ""
        picmasuk.BackgroundImage = Nothing
        picid.BackgroundImage = Nothing
        lblgbr.Text = ""
    End Sub

    Private Sub PicDel_Click(sender As Object, e As EventArgs) Handles PicDel.Click
        keluar()
    End Sub
    Sub keluar()
        With TransMasuk
            '.MdiParent = main1
            .Show()
            '.Top = 0
            '.Left = 0

            Me.Close()
        End With

    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub

    Private Sub dgv1_SelectionChanged(sender As Object, e As EventArgs) Handles dgv1.SelectionChanged
        IsiData()
    End Sub

    Private Sub picid_Click(sender As Object, e As EventArgs) Handles picid.Click
    End Sub

    Private Sub picid_DoubleClick(sender As Object, e As EventArgs) Handles picid.DoubleClick
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IdTamu.Text = lblidtamu.Text
        IdTamu.Show()
    End Sub

    Private Sub PicSave_Click(sender As Object, e As EventArgs) Handles PicSave.Click
        Sql = "update trtamu set nama=" & Aphostrophe(txtnama.Text) & ",jenisId=" & Aphostrophe(cmbjenis.Text) & ",noidentitas=" & Aphostrophe(txtno.Text) & ",tujuan=" & Aphostrophe(txttujuan.Text) & ",gbrid=" & Aphostrophe(lblgbr.Text) & " where idtamu=" & lblidtamu.Text
        Proses.executenonquery(Sql)
        MsgBox("Berhasil update tamu", vbInformation, "Update")
        IsiGrid()
    End Sub
End Class