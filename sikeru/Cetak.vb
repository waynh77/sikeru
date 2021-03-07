Imports Microsoft.Reporting.WinForms

Public Class Cetak

    Private Sub Cetak_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
        TampilLayout()
    End Sub

    Sub TampilLayout()
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100
    End Sub
End Class