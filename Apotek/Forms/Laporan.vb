Public Class Laporan

    Dim transaction As New TransaksiClass
    Dim laporan As New LaporanExcelClass
   

    'MessageBox.Show(DateTimePicker1.Value.Date)
    'MessageBox.Show(transaksi.laporanTransaksi(DateTimePicker1.Value.Date, DateTimePicker2.Value.Date))

    Private Sub Laporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    
    Private Sub BtnBrowseFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim path, sbString As String
        FolderBrowserDialog1.ShowDialog()
        path = FolderBrowserDialog1.SelectedPath
        sbString = path.Substring(path.Length - 1, 1)
        If Not sbString = "\" Then
            path = path.Insert(path.Length, "\")
        End If

        'MsgBox(sbString)
        TextFolder.Text = path
    End Sub

    Private Sub BtnBuatFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fileName As String

        fileName = TextFolder.Text & TextFile.Text & LblExtension.Text
        'MessageBox.Show(fileName.Substring(0, fileName.LastIndexOf(" ")))

        Try
            laporan.createReport(fileName, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
            Process.Start(fileName)
        Catch ex As Exception
            MessageBox.Show("Periksa kembali tanggal untuk laporan atau file yang akan dicetak", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        'MessageBox.Show(transaksi.coba(DateTimePicker1.Value.Date, DateTimePicker2.Value.Date))
    End Sub

    Private Sub TextFile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not TextFile.Text = "" Then
            BtnBuatFile.Enabled = True
        Else
            BtnBuatFile.Enabled = False
        End If
    End Sub

    Private Sub ObatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObatToolStripMenuItem.Click
        FormObat.Show()
        Me.Close()
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaksiToolStripMenuItem.Click
        Transaksi.Show()
        Me.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub
End Class