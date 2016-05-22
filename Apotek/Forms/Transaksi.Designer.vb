<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LblKembalian = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnInputTransaksi = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextUangDibayar = New System.Windows.Forms.TextBox()
        Me.TextTotalHarga = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabelBelanja = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblIDObtTransaksi = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextExpire = New System.Windows.Forms.TextBox()
        Me.TextSupplier = New System.Windows.Forms.TextBox()
        Me.TextJumlahObat = New System.Windows.Forms.TextBox()
        Me.TextHargaObat = New System.Windows.Forms.TextBox()
        Me.TextNamaObat = New System.Windows.Forms.TextBox()
        Me.gambarObat = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnMasukKeranjang = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextJumlah = New System.Windows.Forms.TextBox()
        Me.CbIDObat = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnInputRetur = New System.Windows.Forms.Button()
        Me.BtnHapusRetur = New System.Windows.Forms.Button()
        Me.TextTotalRetur = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.KeranjangRetur = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LblIDObtRetur = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextExpireRetur = New System.Windows.Forms.TextBox()
        Me.TextSupplierObrRtr = New System.Windows.Forms.TextBox()
        Me.TextJmlObtRetur = New System.Windows.Forms.TextBox()
        Me.TextHargaObtRetur = New System.Windows.Forms.TextBox()
        Me.TextNamaObatRetur = New System.Windows.Forms.TextBox()
        Me.gambarObatRetur = New System.Windows.Forms.PictureBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BtnInputKranjangRetur = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextJumlahObtRetur = New System.Windows.Forms.TextBox()
        Me.CbIDObatRetur = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TabelBelanja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gambarObat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.KeranjangRetur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.gambarObatRetur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(588, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(737, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ObatToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ObatToolStripMenuItem
        '
        Me.ObatToolStripMenuItem.Name = "ObatToolStripMenuItem"
        Me.ObatToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ObatToolStripMenuItem.Text = "Obat"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(707, 529)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightGray
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(699, 503)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Transaksi Beli"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LblKembalian)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.BtnInputTransaksi)
        Me.GroupBox3.Controls.Add(Me.BtnHapus)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextUangDibayar)
        Me.GroupBox3.Controls.Add(Me.TextTotalHarga)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TabelBelanja)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 220)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(660, 260)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Keranjang Belanja"
        '
        'LblKembalian
        '
        Me.LblKembalian.AutoSize = True
        Me.LblKembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKembalian.Location = New System.Drawing.Point(390, 198)
        Me.LblKembalian.Name = "LblKembalian"
        Me.LblKembalian.Size = New System.Drawing.Size(28, 37)
        Me.LblKembalian.TabIndex = 9
        Me.LblKembalian.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(290, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Kembalian Rp"
        '
        'BtnInputTransaksi
        '
        Me.BtnInputTransaksi.Location = New System.Drawing.Point(566, 76)
        Me.BtnInputTransaksi.Name = "BtnInputTransaksi"
        Me.BtnInputTransaksi.Size = New System.Drawing.Size(75, 51)
        Me.BtnInputTransaksi.TabIndex = 7
        Me.BtnInputTransaksi.Text = "Input"
        Me.BtnInputTransaksi.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(566, 19)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 51)
        Me.BtnHapus.TabIndex = 5
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Uang Di Bayar"
        '
        'TextUangDibayar
        '
        Me.TextUangDibayar.Location = New System.Drawing.Point(101, 215)
        Me.TextUangDibayar.Name = "TextUangDibayar"
        Me.TextUangDibayar.Size = New System.Drawing.Size(171, 20)
        Me.TextUangDibayar.TabIndex = 3
        '
        'TextTotalHarga
        '
        Me.TextTotalHarga.Location = New System.Drawing.Point(101, 179)
        Me.TextTotalHarga.Name = "TextTotalHarga"
        Me.TextTotalHarga.Size = New System.Drawing.Size(171, 20)
        Me.TextTotalHarga.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total"
        '
        'TabelBelanja
        '
        Me.TabelBelanja.AllowUserToAddRows = False
        Me.TabelBelanja.AllowUserToDeleteRows = False
        Me.TabelBelanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelBelanja.Location = New System.Drawing.Point(6, 19)
        Me.TabelBelanja.Name = "TabelBelanja"
        Me.TabelBelanja.ReadOnly = True
        Me.TabelBelanja.Size = New System.Drawing.Size(554, 150)
        Me.TabelBelanja.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblIDObtTransaksi)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextExpire)
        Me.GroupBox2.Controls.Add(Me.TextSupplier)
        Me.GroupBox2.Controls.Add(Me.TextJumlahObat)
        Me.GroupBox2.Controls.Add(Me.TextHargaObat)
        Me.GroupBox2.Controls.Add(Me.TextNamaObat)
        Me.GroupBox2.Controls.Add(Me.gambarObat)
        Me.GroupBox2.Location = New System.Drawing.Point(341, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 182)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Barang"
        '
        'LblIDObtTransaksi
        '
        Me.LblIDObtTransaksi.AutoSize = True
        Me.LblIDObtTransaksi.Location = New System.Drawing.Point(28, 163)
        Me.LblIDObtTransaksi.Name = "LblIDObtTransaksi"
        Me.LblIDObtTransaksi.Size = New System.Drawing.Size(10, 13)
        Me.LblIDObtTransaksi.TabIndex = 7
        Me.LblIDObtTransaksi.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "ID:"
        '
        'TextExpire
        '
        Me.TextExpire.Enabled = False
        Me.TextExpire.Location = New System.Drawing.Point(132, 140)
        Me.TextExpire.Name = "TextExpire"
        Me.TextExpire.Size = New System.Drawing.Size(193, 20)
        Me.TextExpire.TabIndex = 5
        Me.TextExpire.Text = "Expire Status"
        '
        'TextSupplier
        '
        Me.TextSupplier.Enabled = False
        Me.TextSupplier.Location = New System.Drawing.Point(132, 114)
        Me.TextSupplier.Name = "TextSupplier"
        Me.TextSupplier.Size = New System.Drawing.Size(193, 20)
        Me.TextSupplier.TabIndex = 4
        Me.TextSupplier.Text = "Supplier"
        '
        'TextJumlahObat
        '
        Me.TextJumlahObat.Enabled = False
        Me.TextJumlahObat.Location = New System.Drawing.Point(132, 88)
        Me.TextJumlahObat.Name = "TextJumlahObat"
        Me.TextJumlahObat.Size = New System.Drawing.Size(193, 20)
        Me.TextJumlahObat.TabIndex = 3
        Me.TextJumlahObat.Text = "Jumlah Obat"
        '
        'TextHargaObat
        '
        Me.TextHargaObat.Enabled = False
        Me.TextHargaObat.Location = New System.Drawing.Point(132, 62)
        Me.TextHargaObat.Name = "TextHargaObat"
        Me.TextHargaObat.Size = New System.Drawing.Size(193, 20)
        Me.TextHargaObat.TabIndex = 2
        Me.TextHargaObat.Text = "Harga Obat"
        '
        'TextNamaObat
        '
        Me.TextNamaObat.Enabled = False
        Me.TextNamaObat.Location = New System.Drawing.Point(132, 19)
        Me.TextNamaObat.Multiline = True
        Me.TextNamaObat.Name = "TextNamaObat"
        Me.TextNamaObat.Size = New System.Drawing.Size(193, 37)
        Me.TextNamaObat.TabIndex = 1
        Me.TextNamaObat.Text = "Nama Obat"
        '
        'gambarObat
        '
        Me.gambarObat.Location = New System.Drawing.Point(6, 19)
        Me.gambarObat.Name = "gambarObat"
        Me.gambarObat.Size = New System.Drawing.Size(117, 141)
        Me.gambarObat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gambarObat.TabIndex = 0
        Me.gambarObat.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnMasukKeranjang)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextJumlah)
        Me.GroupBox1.Controls.Add(Me.CbIDObat)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 182)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaksi"
        '
        'BtnMasukKeranjang
        '
        Me.BtnMasukKeranjang.Enabled = False
        Me.BtnMasukKeranjang.Location = New System.Drawing.Point(27, 124)
        Me.BtnMasukKeranjang.Name = "BtnMasukKeranjang"
        Me.BtnMasukKeranjang.Size = New System.Drawing.Size(271, 36)
        Me.BtnMasukKeranjang.TabIndex = 4
        Me.BtnMasukKeranjang.Text = "Masukkan ke keranjang"
        Me.BtnMasukKeranjang.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah"
        '
        'TextJumlah
        '
        Me.TextJumlah.Location = New System.Drawing.Point(25, 98)
        Me.TextJumlah.Name = "TextJumlah"
        Me.TextJumlah.Size = New System.Drawing.Size(273, 20)
        Me.TextJumlah.TabIndex = 2
        '
        'CbIDObat
        '
        Me.CbIDObat.FormattingEnabled = True
        Me.CbIDObat.Location = New System.Drawing.Point(25, 47)
        Me.CbIDObat.Name = "CbIDObat"
        Me.CbIDObat.Size = New System.Drawing.Size(273, 21)
        Me.CbIDObat.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Id Obat"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightGray
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(699, 503)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Transaksi Retur"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnInputRetur)
        Me.GroupBox4.Controls.Add(Me.BtnHapusRetur)
        Me.GroupBox4.Controls.Add(Me.TextTotalRetur)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.KeranjangRetur)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 217)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(660, 260)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tabel Barang Yang Akan di Kembalikan"
        '
        'BtnInputRetur
        '
        Me.BtnInputRetur.Location = New System.Drawing.Point(566, 73)
        Me.BtnInputRetur.Name = "BtnInputRetur"
        Me.BtnInputRetur.Size = New System.Drawing.Size(75, 48)
        Me.BtnInputRetur.TabIndex = 7
        Me.BtnInputRetur.Text = "Input"
        Me.BtnInputRetur.UseVisualStyleBackColor = True
        '
        'BtnHapusRetur
        '
        Me.BtnHapusRetur.Location = New System.Drawing.Point(566, 19)
        Me.BtnHapusRetur.Name = "BtnHapusRetur"
        Me.BtnHapusRetur.Size = New System.Drawing.Size(75, 48)
        Me.BtnHapusRetur.TabIndex = 5
        Me.BtnHapusRetur.Text = "Hapus"
        Me.BtnHapusRetur.UseVisualStyleBackColor = True
        '
        'TextTotalRetur
        '
        Me.TextTotalRetur.Location = New System.Drawing.Point(101, 179)
        Me.TextTotalRetur.Name = "TextTotalRetur"
        Me.TextTotalRetur.Size = New System.Drawing.Size(459, 20)
        Me.TextTotalRetur.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Total"
        '
        'KeranjangRetur
        '
        Me.KeranjangRetur.AllowUserToAddRows = False
        Me.KeranjangRetur.AllowUserToDeleteRows = False
        Me.KeranjangRetur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KeranjangRetur.Location = New System.Drawing.Point(6, 19)
        Me.KeranjangRetur.Name = "KeranjangRetur"
        Me.KeranjangRetur.ReadOnly = True
        Me.KeranjangRetur.Size = New System.Drawing.Size(554, 150)
        Me.KeranjangRetur.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LblIDObtRetur)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.TextExpireRetur)
        Me.GroupBox5.Controls.Add(Me.TextSupplierObrRtr)
        Me.GroupBox5.Controls.Add(Me.TextJmlObtRetur)
        Me.GroupBox5.Controls.Add(Me.TextHargaObtRetur)
        Me.GroupBox5.Controls.Add(Me.TextNamaObatRetur)
        Me.GroupBox5.Controls.Add(Me.gambarObatRetur)
        Me.GroupBox5.Location = New System.Drawing.Point(342, 26)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(338, 182)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Data Barang"
        '
        'LblIDObtRetur
        '
        Me.LblIDObtRetur.AutoSize = True
        Me.LblIDObtRetur.Location = New System.Drawing.Point(35, 163)
        Me.LblIDObtRetur.Name = "LblIDObtRetur"
        Me.LblIDObtRetur.Size = New System.Drawing.Size(10, 13)
        Me.LblIDObtRetur.TabIndex = 7
        Me.LblIDObtRetur.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "ID:"
        '
        'TextExpireRetur
        '
        Me.TextExpireRetur.Enabled = False
        Me.TextExpireRetur.Location = New System.Drawing.Point(132, 140)
        Me.TextExpireRetur.Name = "TextExpireRetur"
        Me.TextExpireRetur.Size = New System.Drawing.Size(193, 20)
        Me.TextExpireRetur.TabIndex = 5
        Me.TextExpireRetur.Text = "Expire Status"
        '
        'TextSupplierObrRtr
        '
        Me.TextSupplierObrRtr.Enabled = False
        Me.TextSupplierObrRtr.Location = New System.Drawing.Point(132, 114)
        Me.TextSupplierObrRtr.Name = "TextSupplierObrRtr"
        Me.TextSupplierObrRtr.Size = New System.Drawing.Size(193, 20)
        Me.TextSupplierObrRtr.TabIndex = 4
        Me.TextSupplierObrRtr.Text = "Supplier"
        '
        'TextJmlObtRetur
        '
        Me.TextJmlObtRetur.Enabled = False
        Me.TextJmlObtRetur.Location = New System.Drawing.Point(132, 88)
        Me.TextJmlObtRetur.Name = "TextJmlObtRetur"
        Me.TextJmlObtRetur.Size = New System.Drawing.Size(193, 20)
        Me.TextJmlObtRetur.TabIndex = 3
        Me.TextJmlObtRetur.Text = "Jumlah Obat"
        '
        'TextHargaObtRetur
        '
        Me.TextHargaObtRetur.Enabled = False
        Me.TextHargaObtRetur.Location = New System.Drawing.Point(132, 62)
        Me.TextHargaObtRetur.Name = "TextHargaObtRetur"
        Me.TextHargaObtRetur.Size = New System.Drawing.Size(193, 20)
        Me.TextHargaObtRetur.TabIndex = 2
        Me.TextHargaObtRetur.Text = "Harga Obat"
        '
        'TextNamaObatRetur
        '
        Me.TextNamaObatRetur.Enabled = False
        Me.TextNamaObatRetur.Location = New System.Drawing.Point(132, 19)
        Me.TextNamaObatRetur.Multiline = True
        Me.TextNamaObatRetur.Name = "TextNamaObatRetur"
        Me.TextNamaObatRetur.Size = New System.Drawing.Size(193, 37)
        Me.TextNamaObatRetur.TabIndex = 1
        Me.TextNamaObatRetur.Text = "Nama Obat"
        '
        'gambarObatRetur
        '
        Me.gambarObatRetur.Location = New System.Drawing.Point(6, 19)
        Me.gambarObatRetur.Name = "gambarObatRetur"
        Me.gambarObatRetur.Size = New System.Drawing.Size(117, 141)
        Me.gambarObatRetur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gambarObatRetur.TabIndex = 0
        Me.gambarObatRetur.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BtnInputKranjangRetur)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.TextJumlahObtRetur)
        Me.GroupBox6.Controls.Add(Me.CbIDObatRetur)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Location = New System.Drawing.Point(18, 26)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(318, 182)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Transaksi"
        '
        'BtnInputKranjangRetur
        '
        Me.BtnInputKranjangRetur.Enabled = False
        Me.BtnInputKranjangRetur.Location = New System.Drawing.Point(27, 124)
        Me.BtnInputKranjangRetur.Name = "BtnInputKranjangRetur"
        Me.BtnInputKranjangRetur.Size = New System.Drawing.Size(271, 36)
        Me.BtnInputKranjangRetur.TabIndex = 4
        Me.BtnInputKranjangRetur.Text = "Masukkan ke keranjang"
        Me.BtnInputKranjangRetur.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Jumlah"
        '
        'TextJumlahObtRetur
        '
        Me.TextJumlahObtRetur.Location = New System.Drawing.Point(25, 98)
        Me.TextJumlahObtRetur.Name = "TextJumlahObtRetur"
        Me.TextJumlahObtRetur.Size = New System.Drawing.Size(273, 20)
        Me.TextJumlahObtRetur.TabIndex = 2
        '
        'CbIDObatRetur
        '
        Me.CbIDObatRetur.FormattingEnabled = True
        Me.CbIDObatRetur.Location = New System.Drawing.Point(25, 47)
        Me.CbIDObatRetur.Name = "CbIDObatRetur"
        Me.CbIDObatRetur.Size = New System.Drawing.Size(273, 21)
        Me.CbIDObatRetur.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Id Obat"
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 568)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Transaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TabelBelanja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.gambarObat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.KeranjangRetur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.gambarObatRetur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ObatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LblKembalian As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnInputTransaksi As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextUangDibayar As System.Windows.Forms.TextBox
    Friend WithEvents TextTotalHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabelBelanja As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextExpire As System.Windows.Forms.TextBox
    Friend WithEvents TextSupplier As System.Windows.Forms.TextBox
    Friend WithEvents TextJumlahObat As System.Windows.Forms.TextBox
    Friend WithEvents TextHargaObat As System.Windows.Forms.TextBox
    Friend WithEvents TextNamaObat As System.Windows.Forms.TextBox
    Friend WithEvents gambarObat As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnMasukKeranjang As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextJumlah As System.Windows.Forms.TextBox
    Friend WithEvents CbIDObat As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnInputRetur As System.Windows.Forms.Button
    Friend WithEvents BtnHapusRetur As System.Windows.Forms.Button
    Friend WithEvents TextTotalRetur As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents KeranjangRetur As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextExpireRetur As System.Windows.Forms.TextBox
    Friend WithEvents TextSupplierObrRtr As System.Windows.Forms.TextBox
    Friend WithEvents TextJmlObtRetur As System.Windows.Forms.TextBox
    Friend WithEvents TextHargaObtRetur As System.Windows.Forms.TextBox
    Friend WithEvents TextNamaObatRetur As System.Windows.Forms.TextBox
    Friend WithEvents gambarObatRetur As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnInputKranjangRetur As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextJumlahObtRetur As System.Windows.Forms.TextBox
    Friend WithEvents CbIDObatRetur As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblIDObtTransaksi As System.Windows.Forms.Label
    Friend WithEvents LblIDObtRetur As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
