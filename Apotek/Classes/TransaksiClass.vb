Public Class TransaksiClass
    Inherits Koneksi
    Dim tabel As String = "transaksi"

#Region "display data"

    Public Function sumData() As Integer
        Dim hasil As Integer

        Try
            tutupKoneksi()
            bukaKoneksi()

            perintah.CommandText = "SELECT COUNT(no_transaksi) AS jumlah FROM " & tabel & ";"
            perintah.Connection = koneksi
            bacadata = perintah.ExecuteReader
            Do While bacadata.Read
                hasil = CInt(bacadata.Item("jumlah").ToString)
            Loop
            Return hasil
            tutupKoneksi()
        Catch ex As Exception
            Return 0
            MsgBox(ex.ToString)
        End Try

    End Function

    Public Function sumDataRetur() As Integer
        Dim hasil As Integer

        Try
            tutupKoneksi()
            bukaKoneksi()

            perintah.CommandText = "SELECT COUNT(no_transaksi) AS jumlah FROM " & tabel & " WHERE no_transaksi LIKE '%R%';"
            perintah.Connection = koneksi
            bacadata = perintah.ExecuteReader
            Do While bacadata.Read
                hasil = CInt(bacadata.Item("jumlah").ToString)
            Loop
            Return hasil
            tutupKoneksi()
        Catch ex As Exception
            Return 0
            MsgBox(ex.ToString)
        End Try

    End Function

    Public Function laporanTransaksi(ByVal tanggalAwal As String, ByVal tanggalAkhir As String) As DataTable
        Dim tabel_laporan As New DataTable
        Dim baris_data As DataRow

        tabel_laporan.Columns.Add("no_transaksi")
        tabel_laporan.Columns.Add("tanggal_transaksi")
        tabel_laporan.Columns.Add("pendapatan")


        Try
            tutupKoneksi()
            bukaKoneksi()
            Dim query As String = "SELECT *" & _
            " FROM " & tabel & _
            " WHERE tanggal_transaksi BETWEEN #" & tanggalAwal & "# AND #" & tanggalAkhir & "#;"
            perintah.CommandText = query
            perintah.Connection = koneksi
            bacadata = perintah.ExecuteReader

            Do While bacadata.Read
                baris_data = tabel_laporan.NewRow
                baris_data("no_transaksi") = bacadata.Item("no_transaksi").ToString()
                baris_data("tanggal_transaksi") = bacadata.Item("tanggal_transaksi").ToString()
                baris_data("pendapatan") = bacadata.Item("total_harga").ToString()
                tabel_laporan.Rows.Add(baris_data)
            Loop

            tutupKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
            'Return tabel_laporan
        End Try

        Return tabel_laporan
    End Function


    

#End Region

#Region "insert data"

    Public Function masukkanData(ByVal id As String, ByVal totalHarga As String, ByVal TanggalTransaksi As String) As Boolean
        Try
            tutupKoneksi()
            bukaKoneksi()
            perintah.CommandText = "INSERT INTO " & tabel & " (no_transaksi,total_harga,tanggal_transaksi) " & _
            "VALUES('" & id & "'," & totalHarga & ",'" & TanggalTransaksi & "');"
            perintah.Connection = koneksi
            perintah.ExecuteNonQuery()
            Return True
            tutupKoneksi()
        Catch ex As Exception
            Return False
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function masukkanDataDetilTransaksi(ByVal id As String, ByVal idObat As String, ByVal jumlah As String) As Boolean
        Try
            tutupKoneksi()
            bukaKoneksi()
            perintah.CommandText = "INSERT INTO detail_transaksi (no_transaksi,id_obat,jumlah) " & _
            "VALUES('" & id & "','" & idObat & "'," & jumlah & ");"
            perintah.Connection = koneksi
            perintah.ExecuteNonQuery()
            Return True
            tutupKoneksi()
        Catch ex As Exception
            Return False
            MsgBox(ex.ToString)
        End Try
    End Function

#End Region

#Region "update data"
    Public Function updateJumlah(ByVal key As String, ByVal jumlahObat As String) As Boolean
        Try
            tutupKoneksi()
            bukaKoneksi()
            perintah.CommandText = "UPDATE obat SET jumlah_obat=" & jumlahObat & _
            " WHERE id_obat ='" & key & "';"
            perintah.Connection = koneksi
            perintah.ExecuteNonQuery()
            Return True
            tutupKoneksi()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function
#End Region

#Region "delete data"

#End Region

End Class
