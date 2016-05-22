Public Class PegawaiClass
    Inherits Koneksi
#Region "display_data"

    Public Function login(ByVal username As String, ByVal password As String, ByRef sesi As String) As Boolean
        Dim query As String
        Dim number As Integer = 0

        query = "SELECT username FROM petugas WHERE username='" & username & "' AND password='" & password & "';"
        Try
            tutupKoneksi()
            bukaKoneksi()
            perintah.CommandText = query
            perintah.Connection = koneksi
            bacadata = perintah.ExecuteReader
            Do While bacadata.Read
                sesi = bacadata.Item("username").ToString()
                number += 1
            Loop

            If number = 1 Then
                Return True
            Else
                MessageBox.Show("SQL Injection detected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If


        Catch ex As Exception
            Return False
        End Try



    End Function


#End Region


#Region "insert_data"

#End Region


#Region "update_data"

#End Region


#Region "delete_data"

#End Region

End Class
