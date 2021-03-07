Public Class main1

    Private Sub main_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.BackgroundImage = My.Resources.Lighthouse
        Me.BackgroundImage = My.Resources.ALTHIAPARK
        PicShow.Visible = False
        tsJam.Text = Format(Now(), "d MMM yyyy")
        jam.Text = Format(Now(), "hh:mm:ss")
        Tt.SetToolTip(PicReg, "Registrasi Penghuni")
        Tt.SetToolTip(PicPay, "Transaksi Pintu")
        Tt.SetToolTip(PicHide, "Sembunyikan Panel")
        Tt.SetToolTip(PicExit, "Keluar")
        Tt.SetToolTip(PicShow, "Tampil Panel")
        PicShow.Left = 25
    End Sub


    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        keluar()
    End Sub

    Sub keluar()
        Dim tny As String
        tny = MsgBox("Apakah anda yakin?", vbYesNo, "Keluar")
        If tny = vbYes Then
            End
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim tny As String
        tny = MsgBox("Apakah anda yakin?", vbYesNo, "Logout")
        If tny = vbYes Then
            Me.Hide()
            With login
                .UsernameTextBox.Text = ""
                .PasswordTextBox.Text = ""
                .Show()
                .UsernameTextBox.Focus()
            End With
        End If
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        With user
            .MdiParent = Me
            .Show()
            .Top = 0
            .Left = 0
        End With
    End Sub

    Private Sub PicExit_Click(sender As Object, e As EventArgs) Handles PicExit.Click
        keluar()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tsJam.Text = Format(Now(), "d MMM yyyy")
        jam.Text = Format(Now(), "hh:mm:ss")
    End Sub

    Private Sub PicHide_Click(sender As Object, e As EventArgs) Handles PicHide.Click
        Panel1.Visible = False
        PicShow.Visible = True
    End Sub

    Private Sub PicShow_Click(sender As Object, e As EventArgs) Handles PicShow.Click
        Panel1.Visible = True
        PicShow.Visible = False
    End Sub

    Private Sub RegPenghuniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegPenghuniToolStripMenuItem.Click
        With registrasi
            .MdiParent = Me
            .Show()
            .Top = 0
            .Left = 0
        End With
    End Sub

    Private Sub TransGateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransGateToolStripMenuItem.Click
        'With TransGate
        '.MdiParent = Me
        '.Show()
        '.Top = 0
        '.Left = 0
        'End With
    End Sub

    Private Sub PicReg_Click(sender As Object, e As EventArgs) Handles PicReg.Click
        RegPenghuniToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub PicPay_Click(sender As Object, e As EventArgs) Handles PicPay.Click
        TransGateToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub PintuMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PintuMasukToolStripMenuItem.Click
        With TransMasuk
            '.MdiParent = Me
            .Show()
            '.Top = 0
            '.Left = 0
        End With
    End Sub

    Private Sub PintuKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PintuKeluarToolStripMenuItem.Click
        With TransKeluar
            '.MdiParent = Me
            .Show()
            '.Top = 0
            '.Left = 0
        End With
    End Sub

    Private Sub GantiPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        With GantiPass
            .MdiParent = Me
            .Show()
            .Top = 0
            .Left = 0
        End With
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        With Laporan
            .MdiParent = Me
            .Show()
            .Top = 0
            .Left = 0
        End With
    End Sub
End Class