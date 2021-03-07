Imports Microsoft.Reporting.WinForms

Public Class Laporan

    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp1.Value = Now
        dtp2.Value = Now
        dtp3.Value = Now
        dtp4.Value = Now
        Tt.SetToolTip(PicCetak, "Cetak")
        Tt.SetToolTip(PicDel, "Keluar")
        Isicombo()
    End Sub

    Private Sub PicCetak_Click(sender As Object, e As EventArgs) Handles PicCetak.Click
        Cetaklap()
    End Sub

    Sub Isicombo()
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Semua")
        ComboBox1.Items.Add("Kendaraan Masuk")
        ComboBox1.Items.Add("Kendaraan Keluar")
        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("Semua")
        ComboBox2.Items.Add("Penghuni")
        ComboBox2.Items.Add("Tamu")
        ComboBox3.Items.Clear()
        ComboBox3.Items.Add("Semua")
        ComboBox3.Items.Add("On Progress")
        ComboBox3.Items.Add("Selesai")
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
    End Sub

    Sub Cetaklap()
        Dim tgljamawal As Date = dtp1.Value.ToString("yyyy MM dd") & " " & dtp2.Value.ToString("HH:mm")
        Dim tgljamakhir As Date = dtp3.Value.ToString("yyyy MM dd") & " " & dtp4.Value.ToString("HH:mm")

        With Cetak
            .MdiParent = main1
            Sql = "select * from view_trgate1 where (tgljam between " & Aphostrophe(tgljamawal) & " and " & Aphostrophe(tgljamakhir) & ")"
            Select Case ComboBox1.SelectedIndex
                Case 1
                    Sql = Sql & " and inout='IN'"
                Case 2
                    Sql = Sql & " and inout='OUT'"
            End Select
            Select Case ComboBox2.SelectedIndex
                Case 1
                    Sql = Sql & " and JenisTrans='Penghuni'"
                Case 2
                    Sql = Sql & " and JenisTrans='Tamu'"
            End Select
            Select Case ComboBox3.SelectedIndex
                Case 1
                    Sql = Sql & " and sts='false'"
                Case 2
                    Sql = Sql & " and sts='true'"
            End Select
            Sql = Sql & " order by rfidno,tgljam,inout"
            Tabel = Proses.executequery(Sql)
            .BindingSource1.DataSource = Tabel
           
            Dim rds As New ReportDataSource("DataSet1", .BindingSource1)
            .ReportViewer1.LocalReport.ReportPath = "D:\sikeru - Copy\sikeru\report1.rdlc"
            .ReportViewer1.LocalReport.DataSources.Clear()
            .ReportViewer1.LocalReport.DataSources.Add(rds)

            Dim period As New ReportParameter()
            period.Name = "ReportParameter1"
            period.Values.Add("Dari " & tgljamawal & " Sd " & tgljamakhir)

            'Set the report parameters for the report
            Dim parameters() As ReportParameter = {period}
            .ReportViewer1.LocalReport.SetParameters(parameters)

            .ReportViewer1.RefreshReport()

            .Show()
            .Top = 0
            .Left = 0
            '.WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub PicDel_Click(sender As Object, e As EventArgs) Handles PicDel.Click
        Me.Close()
    End Sub
End Class