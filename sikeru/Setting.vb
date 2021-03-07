Public Class Setting

    Private Sub PicSave_Click(sender As Object, e As EventArgs) Handles PicSave.Click
        Sql = "update msset set masukcam=" & Aphostrophe(txtcam1.Text) & ", keluarcam=" & Aphostrophe(txtcam2.Text) & " where idset=1"
        Proses.executenonquery(Sql)
        MsgBox("Berhasil simpan", vbInformation, "Simpan")
        'TransMasuk.txtip.Text = txtcam1.Text
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

    Private Sub PicDel_Click(sender As Object, e As EventArgs) Handles PicDel.Click
        keluar()
    End Sub

    Private Sub Setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sql = "select * from msset"
        Tabel = Proses.executequery(Sql)
        txtcam1.Text = Tabel.Rows(0).Item("masukcam")
        txtcam2.Text = Tabel.Rows(0).Item("keluarcam")
    End Sub
End Class