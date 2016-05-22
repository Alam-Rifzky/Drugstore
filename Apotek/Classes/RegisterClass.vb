Imports System.Security.Cryptography

Public NotInheritable Class RegisterClass

    Private tripleDES As New TripleDESCryptoServiceProvider

    Sub New(ByVal key As String)
        tripleDES.Key = potongHash(key, tripleDES.KeySize \ 8)
        tripleDES.IV = potongHash("", tripleDES.BlockSize \ 8)
    End Sub

    Private Function potongHash(ByVal key As String, ByVal length As Integer) As Byte()

        Dim sha1 As New SHA1CryptoServiceProvider
        'pemecahan byte
        Dim tiapByte As Byte() = System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash As Byte() = sha1.ComputeHash(tiapByte)
        ReDim Preserve hash(length - 1)

        Return hash

    End Function

    Public Function decryptData(ByVal textTerenkripsi As String) As String

        Dim terEnkripsi() As Byte = Convert.FromBase64String(textTerenkripsi)

        'buat stream
        Dim memoryStream As New System.IO.MemoryStream

        Dim dekoderStream As New CryptoStream(memoryStream, tripleDES.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        'use the crypto stream to write the byte array to da stream
        dekoderStream.Write(terEnkripsi, 0, terEnkripsi.Length)
        dekoderStream.FlushFinalBlock()

        Return System.Text.Encoding.Unicode.GetString(memoryStream.ToArray)
    End Function
End Class
