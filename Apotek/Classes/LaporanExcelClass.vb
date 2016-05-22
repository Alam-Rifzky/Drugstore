Imports excel = Microsoft.Office.Interop.Excel

Public Class LaporanExcelClass

    Dim transaksi As New TransaksiClass

    Dim xlapp As excel.Application
    Dim xlworkbook As excel.Workbook
    Dim xlworksheet As excel.Worksheet
    Dim misvalue As Object = System.Reflection.Missing.Value    'unknown object (look for the use of this code)
    Dim xlRange As excel.Range

#Region "fill_cells"

    Sub fillTwoRangeCenter(ByVal range As String, ByVal range2 As String, ByVal value As String)
        xlRange = xlworksheet.Range(range, range2)
        xlRange.Merge()
        xlRange.FormulaR1C1 = value
        xlRange.HorizontalAlignment = 3
        xlRange.VerticalAlignment = 3
    End Sub

    Sub fillTwoRangeLeft(ByVal range As String, ByVal range2 As String, ByVal value As String)
        xlRange = xlworksheet.Range(range, range2)
        xlRange.Merge()
        xlRange.FormulaR1C1 = value
        xlRange.HorizontalAlignment = 2
        xlRange.VerticalAlignment = 2
    End Sub

    Sub fillCellLeft(ByVal range As String, ByVal value As String)
        xlRange = xlworksheet.Range(range)
        xlRange.Merge()
        xlRange.FormulaR1C1 = value
        xlRange.HorizontalAlignment = 2
        xlRange.VerticalAlignment = 2
    End Sub

    Sub fillCellCenter(ByVal range As String, ByVal value As String)
        xlRange = xlworksheet.Range(range)
        xlRange.Merge()
        xlRange.FormulaR1C1 = value
        xlRange.HorizontalAlignment = 3
        xlRange.VerticalAlignment = 3
    End Sub

    Sub fillOneRangeTheVeryCenter(ByVal range As String, ByVal value As String)
        xlRange = xlworksheet.Range(range)
        xlRange.Merge()
        xlRange.FormulaR1C1 = value
        xlRange.HorizontalAlignment = 3
        xlRange.VerticalAlignment = 2
    End Sub

    Sub fillTwoRangeTheVeryCenter(ByVal range As String, ByVal range2 As String, ByVal value As String)
        xlRange = xlworksheet.Range(range, range2)
        xlRange.Merge()
        xlRange.FormulaR1C1 = value
        xlRange.HorizontalAlignment = 3
        xlRange.VerticalAlignment = 2
    End Sub

#End Region

#Region "execution"

    Public Sub createReport(ByVal namaFile As String, ByVal firstDate As String, ByVal lastDate As String)
        xlapp = New excel.Application
        xlworkbook = xlapp.Workbooks.Add(misvalue)
        xlworksheet = xlapp.Sheets("sheet1")
        laporanTransaksi(firstDate, lastDate)
        Try
            xlworksheet.SaveAs(namaFile)
            'MsgBox("file sudah dibuat")
        Catch ex As Exception
            MessageBox.Show("Periksa Kembali Nama File atau Lokasi Direktori Anda")
            xlworkbook.Close()
            xlapp.Quit()
            tutupFile(xlapp)
            tutupFile(xlworkbook)
            tutupFile(xlworksheet)
        End Try
        xlworkbook.Close()
        xlapp.Quit()
        tutupFile(xlapp)
        tutupFile(xlworkbook)
        tutupFile(xlworksheet)
    End Sub

    Public Sub openFile(ByVal namaFile As String, ByVal sheet As String)
        xlapp = New excel.Application
        xlworkbook = xlapp.Workbooks.Open(namaFile)
        xlworksheet = xlworkbook.Worksheets(sheet)
    End Sub

    Public Sub tutupFile(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

#End Region

#Region "laporan"

    Sub laporanTransaksi(ByVal tanggalAwal As String, ByVal tanggalAkhir As String)
        Dim tabel_laporan As New DataTable
        Dim number As Integer = 5

        tabel_laporan = transaksi.laporanTransaksi(tanggalAwal, tanggalAkhir)

        fillTwoRangeCenter("A1", "H1", "LAPORAN DATA TRANSAKSI APOTEK SEHAT")

        '------------------------------------------------
        fillTwoRangeCenter("A2", "B2", "TANGGAL LAPORAN")
        '------------------------------------------------
        fillCellLeft("C2", ": " & Now.Date)

        fillCellCenter("A4", "NO TRANSAKSI")
        fillCellCenter("B4", "TANGGAL TRANSAKSI")
        fillCellCenter("C4", "PENDAPATAN")

        For Each row As DataRow In tabel_laporan.Rows
            fillCellLeft("A" & number.ToString, row.Item("no_transaksi"))
            fillCellLeft("B" & number.ToString, hilangkanJam(row.Item("tanggal_transaksi")))
            fillCellLeft("C" & number.ToString, row.Item("pendapatan"))
            number += 1
        Next

    End Sub


#End Region

#Region "fungsi"

    Function hilangkanJam(ByVal str As String) As String
        Dim result As String = str

        result = result.Substring(0, result.LastIndexOf("12") - 1)

        Return result
    End Function

#End Region

End Class
