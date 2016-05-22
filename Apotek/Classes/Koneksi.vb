Imports System.Data.OleDb
Public Class Koneksi
    Protected connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\data\coba\Apotek.accdb;Jet OLEDB:Database Password=england"
    'D:\data\Apotek.accdb
    Protected koneksi As New OleDbConnection
    Protected perintah As New OleDb.OleDbCommand
    Protected bacadata As OleDbDataReader

    Public Sub bukaKoneksi()
        Try
            If Koneksi.State = ConnectionState.Closed Then
                Koneksi.ConnectionString = connectionString
                Koneksi.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Tidak terkoneksi ke database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub tutupKoneksi()
        Koneksi.Close()
    End Sub

End Class
