Public Class FormObat
    Dim obat As New ObatClass
    Dim supplier As New SupplierClass

#Region "Supplier"

    Private Sub SplInputBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SplInputBtn.Click
        If supplier.masukkanData(SplKodeText.Text, SplNameText.Text, SplPhoneText.Text, SplAddressText.Text) = True Then
            MessageBox.Show("data berhasil dimasukkan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            bersihSupplier()
            supplier.loadData(ObtCbSupplierID, ObtCbSupplierID)
        Else
            MessageBox.Show("Data Gagal ditambah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Sub bersihSupplier()
        SplKodeText.Text = ""
        SplNameText.Text = ""
        SplPhoneText.Text = ""
        SplAddressText.Text = ""
    End Sub

    Private Sub SplEditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SplEditBtn.Click
        SplCbEditKode.Visible = True
        SplInputBtn.Enabled = False
        SplDeleteBtn.Enabled = False
        SplSaveBtn.Enabled = True
        supplier.loadData(SplCbEditKode, ObtCbSupplierID)
    End Sub

    Private Sub SplSaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SplSaveBtn.Click
        If supplier.updateData(SplCbEditKode.Text, SplNameText.Text, SplPhoneText.Text, SplAddressText.Text) = True Then
            MessageBox.Show("data berhasil diubah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            bersihSupplier()
            SplCbEditKode.Items.Clear()
        End If
        SplCbEditKode.Visible = False
        SplInputBtn.Enabled = True
        SplDeleteBtn.Enabled = True
        SplSaveBtn.Enabled = False
    End Sub

    Private Sub SplCbEditKode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SplCbEditKode.SelectedIndexChanged
        supplier.displayForUpdate(SplCbEditKode.Text, SplNameText, SplPhoneText, SplAddressText)
    End Sub

    Private Sub SplDeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SplDeleteBtn.Click
        If SplCbEditKode.Visible = False Then
            MessageBox.Show("Harap pilih ID yang akan di hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SplCbEditKode.Visible = True
            supplier.loadData(SplCbEditKode, ObtCbSupplierID)
        Else

            If supplier.deleteData(SplCbEditKode.Text) = True Then
                MessageBox.Show("Data Telah di Hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                bersihSupplier()
                SplCbEditKode.Items.Clear()
            End If
        End If
    End Sub



#End Region


#Region "Obat"

    Private Sub ObatBrowseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObatBrowseButton.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            ObatFilenameText.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Sub bersihObat()
        ObtIDText.Text = ""
        ObtNameText.Text = ""
        ObtHargaText.Text = ""
        ObtQuantityText.Text = ""
        ObtCbSupplierID.Text = ""
        ObatFilenameText.Text = ""
    End Sub



    Private Sub ObatInputButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObatInputButton.Click
        If obat.masukkanData(ObtIDText.Text, ObtNameText.Text, ObtHargaText.Text, ObtQuantityText.Text, ObatFilenameText.Text, ObtCbSupplierID.Text, ObtDateExpire.Value.Date) = True Then
            MessageBox.Show("data berhasil dimasukkan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            bersihObat()
            obat.showDataGrid(DataGridView1)
        End If
    End Sub

    Private Sub ObtCbSupplierID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObtCbSupplierID.SelectedIndexChanged
        supplier.displaySupplierName(ObtCbSupplierID.Text)
        LblNamaSupplier.Text = supplier.nama
    End Sub

    Private Sub ObatFilenameText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObatFilenameText.TextChanged
        ObtPictureBox.ImageLocation = ObatFilenameText.Text
    End Sub

    Private Sub ObatEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObatEditButton.Click
        ObatInputButton.Enabled = False
        ObatEditButton.Enabled = False
        ObatDeleteButton.Enabled = False
        ObatSaveButton.Enabled = True
        obat.loadData(ObtCbEditID)
        ObtCbEditID.Visible = True
    End Sub

    Private Sub ObatSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObatSaveButton.Click

        If obat.updateData(ObtCbEditID.Text, ObtNameText.Text, ObtQuantityText.Text, ObtHargaText.Text, ObatFilenameText.Text, ObtCbSupplierID.Text, ObtDateExpire.Value.Date) = True Then
            MessageBox.Show("data berhasil diubah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            bersihObat()
            ObtCbEditID.Items.Clear()
            obat.showDataGrid(DataGridView1)
        End If

        ObatInputButton.Enabled = True
        ObatEditButton.Enabled = True
        ObatDeleteButton.Enabled = True
        ObatSaveButton.Enabled = False
        ObtCbEditID.Items.Clear()
        ObtCbEditID.Visible = False
    End Sub

    Private Sub ObtCbEditID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObtCbEditID.SelectedIndexChanged
        obat.displayForUpdate(ObtCbEditID.Text, ObtNameText, ObtHargaText, ObtQuantityText, ObatFilenameText, ObtCbSupplierID, ObtDateExpire)

    End Sub

    Private Sub ObatDeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObatDeleteButton.Click
        If ObtCbEditID.Visible = False Then
            MessageBox.Show("Harap pilih ID yang akan di hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ObtCbEditID.Visible = True
            obat.loadData(ObtCbEditID)
        Else

            If obat.deleteData(ObtCbEditID.Text) = True Then
                MessageBox.Show("Data Telah di Hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                bersihObat()
                ObtCbEditID.Text = ""
                ObtCbEditID.Items.Clear()
                obat.showDataGrid(DataGridView1)
            End If
        End If
    End Sub
#End Region

    Private Sub Obat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LblPegawai.Text = sesi
        LblPegawai2.Text = sesi
        supplier.loadData(SplCbEditKode, ObtCbSupplierID)
        supplier.showDataGrid(DataGridView2)
        obat.showDataGrid(DataGridView1)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Transaksi.Show()
        Me.Close()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanToolStripMenuItem.Click
        Laporan.Show()
        Me.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem1.Click
        Login.Show()
        Me.Close()
    End Sub
End Class