Imports System.IO
Imports System.Data.SqlClient
Module Module1

    Public Tt As New ToolTip
    Public Sql As String
    Public LokRpt As String
    Public Tabel As New DataTable
    Public Proses As New koneksi
    Public lokGbr As String
    Public ServerName As String = ".\sqlexpress"
    Public UserServer As String = "SA"
    Public PasServer As String = "123"
    Public conString As String
    Public namauser As String


    Function Aphostrophe(ByVal sval As String) As String
        Dim sRet As String
        sRet = sval.Replace("'", "''")
        sRet = "'" + sRet + "'"
        Return sRet
    End Function
End Module
