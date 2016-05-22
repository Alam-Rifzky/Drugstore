Public Class Transaksi
    Dim obat As New ObatClass
    Dim transaksi As New TransaksiClass
    Private Sub Transaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = sesi
        isiTabelBelanja(TabelBelanja)
        isiTabelBelanja(KeranjangRetur)
        obat.loadData(CbIDObat, CbIDObatRetur)
    End Sub


#Region "transaksi Belanja"

    Sub isiTabelBelanja(ByVal DataGridView As DataGridView)
        DataGridView.Columns.Add("kodeObat", "Kode Obat")
        DataGridView.Columns("kodeObat").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridView.Columns.Add("namaObat", "Nama Obat")
        DataGridView.Columns("namaObat").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView.Columns.Add("hargaObat", "Harga Obat")
        DataGridView.Columns("hargaObat").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridView.Columns.Add("jumlahObat", "Jumlah Obat")
        DataGridView.Columns("jumlahObat").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        For i As Integer = 0 To 10

        Next
    End Sub

    Sub bersih()
        CbIDObat.Text = ""
        TextJumlah.Text = ""
    End Sub

    Sub bersihTransaksi()
        TextUangDibayar.Text = ""
        TextTotalHarga.Text = ""
    End Sub

    Function hitungTotalHarga() As Long
        Dim hasil As Long = 0
        For Each barisData As DataGridViewRow In TabelBelanja.Rows
            hasil += CLng(barisData.Cells("hargaObat").Value) * CInt(barisData.Cells("jumlahObat").Value)
        Next
        Return hasil
    End Function

    Sub inputDetailTransaksi(ByVal id As String, ByVal gridview As DataGridView)
        For Each barisData As DataGridViewRow In gridview.Rows
            transaksi.masukkanDataDetilTransaksi(id, barisData.Cells("kodeObat").Value, barisData.Cells("jumlahObat").Value)
        Next
    End Sub

    Private Sub ObatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObatToolStripMenuItem.Click
        FormObat.Show()
        Me.Close()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanToolStripMenuItem.Click
        Laporan.Show()
        Me.Close()
    End Sub

    Private Sub BtnMasukKeranjang_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMasukKeranjang.Click

        If obat.jumlah >= CInt(TextJumlah.Text) Then
            obat.jumlah -= CInt(TextJumlah.Text)
            TextJumlahObat.Text = obat.jumlah
            TabelBelanja.Rows.Add()
            'MsgBox(TabelBelanja.Rows.Count)
            With TabelBelanja.Rows(TabelBelanja.Rows.Count - 1)
                .Cells("kodeObat").Value = CbIDObat.Text
                .Cells("namaObat").Value = obat.nama
                .Cells("hargaObat").Value = obat.harga
                .Cells("jumlahObat").Value = TextJumlah.Text
            End With
            TextTotalHarga.Text = hitungTotalHarga()
            bersih()
        Else
            MessageBox.Show("Jumlah Barang Melebihi Stok", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        End If


    End Sub

    Private Sub BtnHapus_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        Dim row As DataGridViewRow
        row = TabelBelanja.Rows(TabelBelanja.CurrentRow.Index)

        obat.displayForTransaksi(row.Cells("kodeObat").Value)
        setDataBarang()
        TextJumlahObat.Text = CInt(TextJumlahObat.Text) + CInt(row.Cells("jumlahObat").Value)
        TabelBelanja.Rows.RemoveAt(TabelBelanja.CurrentRow.Index)
        TextTotalHarga.Text = hitungTotalHarga()
    End Sub

    Private Sub CbIDObat_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbIDObat.SelectedIndexChanged
        obat.displayForTransaksi(CbIDObat.Text)
        setDataBarang()
    End Sub

    Sub setDataBarang()
        LblIDObtTransaksi.Text = obat.kode
        TextNamaObat.Text = obat.nama
        TextHargaObat.Text = obat.harga
        TextJumlahObat.Text = obat.jumlah
        TextSupplier.Text = obat.penyedia
        TextExpire.Text = obat.tanggalBasi
        gambarObat.ImageLocation = obat.foto
    End Sub


    Private Sub TextUangDibayar_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextUangDibayar.TextChanged
        Try
            LblKembalian.Text = CInt(TextUangDibayar.Text) - CLng(TextTotalHarga.Text)
        Catch ex As Exception
            LblKembalian.Text = 0
        End Try
    End Sub

   

    Private Sub BtnInputTransaksi_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInputTransaksi.Click
        Dim id As Integer = transaksi.sumData + 1
        If transaksi.masukkanData(id.ToString, TextUangDibayar.Text, Now.Date) = True Then
            inputDetailTransaksi(id.ToString, TabelBelanja)
            MessageBox.Show("transaksi berhasil", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            bersihTransaksi()
            TabelBelanja.Rows.Clear()
        End If
    End Sub

    Private Sub TextJumlahObat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextJumlahObat.TextChanged
        Try
            transaksi.updateJumlah(LblIDObtTransaksi.Text, CInt(TextJumlahObat.Text))
        Catch ex As Exception
            TextJumlahObat.Text = 0
        End Try

    End Sub

#End Region


#Region "Transaksi Retur"

    Private Sub CbIDObatRetur_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbIDObatRetur.SelectedIndexChanged
        obat.displayForTransaksi(CbIDObatRetur.Text)
        setDataRetur()
    End Sub

    Sub setDataRetur()
        LblIDObtRetur.Text = obat.kode
        TextNamaObatRetur.Text = obat.nama
        TextHargaObtRetur.Text = obat.harga
        TextJmlObtRetur.Text = obat.jumlah
        TextSupplierObrRtr.Text = obat.penyedia
        TextExpireRetur.Text = obat.tanggalBasi
        gambarObatRetur.ImageLocation = obat.foto
    End Sub

    Function Retur_hitungTotalHarga() As Long
        Dim hasil As Long = 0
        For Each barisData As DataGridViewRow In KeranjangRetur.Rows
            hasil += CLng(barisData.Cells("hargaObat").Value) * CInt(barisData.Cells("jumlahObat").Value)
        Next
        Return hasil
    End Function

    Sub retur_bersih()
        CbIDObatRetur.Text = ""
        TextJumlahObtRetur.Text = ""
    End Sub

    Sub retur_bersihTransaksi()
        TextTotalRetur.Text = ""
    End Sub

    Private Sub BtnInputKranjangRetur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInputKranjangRetur.Click
        obat.jumlah += CInt(TextJumlahObtRetur.Text)
        TextJmlObtRetur.Text = obat.jumlah
        KeranjangRetur.Rows.Add()
        'MsgBox(TabelBelanja.Rows.Count)
        With KeranjangRetur.Rows(KeranjangRetur.Rows.Count - 1)
            .Cells("kodeObat").Value = CbIDObatRetur.Text
            .Cells("namaObat").Value = obat.nama
            .Cells("hargaObat").Value = obat.harga
            .Cells("jumlahObat").Value = TextJumlahObtRetur.Text
        End With
        TextTotalRetur.Text = Retur_hitungTotalHarga()
        'MsgBox()
        retur_bersih()
    End Sub

    Private Sub BtnHapusRetur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapusRetur.Click
        Dim row As DataGridViewRow
        row = KeranjangRetur.Rows(KeranjangRetur.CurrentRow.Index)

        obat.displayForTransaksi(row.Cells("kodeObat").Value)
        setDataRetur()
        TextJmlObtRetur.Text = CInt(TextJmlObtRetur.Text) - CInt(row.Cells("jumlahObat").Value)

        KeranjangRetur.Rows.RemoveAt(KeranjangRetur.CurrentRow.Index)
        TextTotalRetur.Text = Retur_hitungTotalHarga()
    End Sub

    Private Sub BtnInputRetur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInputRetur.Click
        Dim id As String = "R" & transaksi.sumDataRetur + 1
        If transaksi.masukkanData(id.ToString, TextTotalRetur.Text, Now.Date) = True Then
            inputDetailTransaksi(id, KeranjangRetur)
            MessageBox.Show("transaksi berhasil", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            retur_bersihTransaksi()
            KeranjangRetur.Rows.Clear()
        End If
    End Sub



#End Region

    
   
    Private Sub TextJumlahObtRetur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextJumlahObtRetur.TextChanged
        If Not TextJumlahObtRetur.Text = "" Then
            BtnInputKranjangRetur.Enabled = True
        Else
            BtnInputKranjangRetur.Enabled = False
        End If
    End Sub

    Private Sub TextJumlah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextJumlah.TextChanged
        If Not TextJumlah.Text = "" Then
            BtnMasukKeranjang.Enabled = True
        Else
            BtnMasukKeranjang.Enabled = False
        End If
    End Sub

    Private Sub TextJmlObtRetur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextJmlObtRetur.TextChanged
        Try
            transaksi.updateJumlah(LblIDObtRetur.Text, CInt(TextJmlObtRetur.Text))
        Catch ex As Exception
            TextJmlObtRetur.Text = 0
        End Try
    End Sub

End Class