<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormObat
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LblPegawai = New System.Windows.Forms.Label()
        Me.ObatFilenameText = New System.Windows.Forms.TextBox()
        Me.ObatBrowseButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ObtCbEditID = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ObtHargaText = New System.Windows.Forms.TextBox()
        Me.LblNamaSupplier = New System.Windows.Forms.Label()
        Me.ObtCbSupplierID = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ObtDateExpire = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ObtQuantityText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ObtNameText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ObtIDText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ObatDeleteButton = New System.Windows.Forms.Button()
        Me.ObatSaveButton = New System.Windows.Forms.Button()
        Me.ObatEditButton = New System.Windows.Forms.Button()
        Me.ObatInputButton = New System.Windows.Forms.Button()
        Me.ObtPictureBox = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SplCbEditKode = New System.Windows.Forms.ComboBox()
        Me.LblPegawai2 = New System.Windows.Forms.Label()
        Me.SplDeleteBtn = New System.Windows.Forms.Button()
        Me.SplSaveBtn = New System.Windows.Forms.Button()
        Me.SplEditBtn = New System.Windows.Forms.Button()
        Me.SplInputBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SplAddressText = New System.Windows.Forms.TextBox()
        Me.SplPhoneText = New System.Windows.Forms.TextBox()
        Me.SplNameText = New System.Windows.Forms.TextBox()
        Me.SplKodeText = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ObtPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(731, 527)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage1.Controls.Add(Me.LblPegawai)
        Me.TabPage1.Controls.Add(Me.ObatFilenameText)
        Me.TabPage1.Controls.Add(Me.ObatBrowseButton)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.ObtPictureBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(723, 501)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Obat"
        '
        'LblPegawai
        '
        Me.LblPegawai.AutoSize = True
        Me.LblPegawai.Location = New System.Drawing.Point(489, 20)
        Me.LblPegawai.Name = "LblPegawai"
        Me.LblPegawai.Size = New System.Drawing.Size(10, 13)
        Me.LblPegawai.TabIndex = 9
        Me.LblPegawai.Text = "-"
        '
        'ObatFilenameText
        '
        Me.ObatFilenameText.Enabled = False
        Me.ObatFilenameText.Location = New System.Drawing.Point(492, 293)
        Me.ObatFilenameText.Name = "ObatFilenameText"
        Me.ObatFilenameText.Size = New System.Drawing.Size(138, 20)
        Me.ObatFilenameText.TabIndex = 8
        '
        'ObatBrowseButton
        '
        Me.ObatBrowseButton.Location = New System.Drawing.Point(636, 293)
        Me.ObatBrowseButton.Name = "ObatBrowseButton"
        Me.ObatBrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.ObatBrowseButton.TabIndex = 7
        Me.ObatBrowseButton.Text = "Cari"
        Me.ObatBrowseButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 333)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(697, 140)
        Me.DataGridView1.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ObtCbEditID)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.ObtHargaText)
        Me.GroupBox1.Controls.Add(Me.LblNamaSupplier)
        Me.GroupBox1.Controls.Add(Me.ObtCbSupplierID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ObtDateExpire)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ObtQuantityText)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ObtNameText)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ObtIDText)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ObatDeleteButton)
        Me.GroupBox1.Controls.Add(Me.ObatSaveButton)
        Me.GroupBox1.Controls.Add(Me.ObatEditButton)
        Me.GroupBox1.Controls.Add(Me.ObatInputButton)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 296)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Obat"
        '
        'ObtCbEditID
        '
        Me.ObtCbEditID.FormattingEnabled = True
        Me.ObtCbEditID.Location = New System.Drawing.Point(20, 44)
        Me.ObtCbEditID.Name = "ObtCbEditID"
        Me.ObtCbEditID.Size = New System.Drawing.Size(189, 21)
        Me.ObtCbEditID.TabIndex = 18
        Me.ObtCbEditID.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Harga"
        '
        'ObtHargaText
        '
        Me.ObtHargaText.Location = New System.Drawing.Point(20, 194)
        Me.ObtHargaText.Name = "ObtHargaText"
        Me.ObtHargaText.Size = New System.Drawing.Size(186, 20)
        Me.ObtHargaText.TabIndex = 16
        '
        'LblNamaSupplier
        '
        Me.LblNamaSupplier.AutoSize = True
        Me.LblNamaSupplier.Location = New System.Drawing.Point(260, 68)
        Me.LblNamaSupplier.Name = "LblNamaSupplier"
        Me.LblNamaSupplier.Size = New System.Drawing.Size(10, 13)
        Me.LblNamaSupplier.TabIndex = 15
        Me.LblNamaSupplier.Text = "-"
        '
        'ObtCbSupplierID
        '
        Me.ObtCbSupplierID.FormattingEnabled = True
        Me.ObtCbSupplierID.Location = New System.Drawing.Point(263, 44)
        Me.ObtCbSupplierID.Name = "ObtCbSupplierID"
        Me.ObtCbSupplierID.Size = New System.Drawing.Size(166, 21)
        Me.ObtCbSupplierID.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(260, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Supplier"
        '
        'ObtDateExpire
        '
        Me.ObtDateExpire.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ObtDateExpire.Location = New System.Drawing.Point(263, 107)
        Me.ObtDateExpire.Name = "ObtDateExpire"
        Me.ObtDateExpire.Size = New System.Drawing.Size(166, 20)
        Me.ObtDateExpire.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(260, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Expired Date"
        '
        'ObtQuantityText
        '
        Me.ObtQuantityText.Location = New System.Drawing.Point(20, 144)
        Me.ObtQuantityText.Name = "ObtQuantityText"
        Me.ObtQuantityText.Size = New System.Drawing.Size(186, 20)
        Me.ObtQuantityText.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Jumlah"
        '
        'ObtNameText
        '
        Me.ObtNameText.Location = New System.Drawing.Point(20, 94)
        Me.ObtNameText.Name = "ObtNameText"
        Me.ObtNameText.Size = New System.Drawing.Size(186, 20)
        Me.ObtNameText.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama Obat"
        '
        'ObtIDText
        '
        Me.ObtIDText.Location = New System.Drawing.Point(20, 45)
        Me.ObtIDText.Name = "ObtIDText"
        Me.ObtIDText.Size = New System.Drawing.Size(189, 20)
        Me.ObtIDText.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Id Obat"
        '
        'ObatDeleteButton
        '
        Me.ObatDeleteButton.Location = New System.Drawing.Point(340, 233)
        Me.ObatDeleteButton.Name = "ObatDeleteButton"
        Me.ObatDeleteButton.Size = New System.Drawing.Size(94, 39)
        Me.ObatDeleteButton.TabIndex = 3
        Me.ObatDeleteButton.Text = "Hapus"
        Me.ObatDeleteButton.UseVisualStyleBackColor = True
        '
        'ObatSaveButton
        '
        Me.ObatSaveButton.Enabled = False
        Me.ObatSaveButton.Location = New System.Drawing.Point(235, 233)
        Me.ObatSaveButton.Name = "ObatSaveButton"
        Me.ObatSaveButton.Size = New System.Drawing.Size(94, 39)
        Me.ObatSaveButton.TabIndex = 2
        Me.ObatSaveButton.Text = "Simpan"
        Me.ObatSaveButton.UseVisualStyleBackColor = True
        '
        'ObatEditButton
        '
        Me.ObatEditButton.Location = New System.Drawing.Point(131, 233)
        Me.ObatEditButton.Name = "ObatEditButton"
        Me.ObatEditButton.Size = New System.Drawing.Size(94, 39)
        Me.ObatEditButton.TabIndex = 1
        Me.ObatEditButton.Text = "Ubah"
        Me.ObatEditButton.UseVisualStyleBackColor = True
        '
        'ObatInputButton
        '
        Me.ObatInputButton.Location = New System.Drawing.Point(28, 233)
        Me.ObatInputButton.Name = "ObatInputButton"
        Me.ObatInputButton.Size = New System.Drawing.Size(94, 39)
        Me.ObatInputButton.TabIndex = 0
        Me.ObatInputButton.Text = "Input"
        Me.ObatInputButton.UseVisualStyleBackColor = True
        '
        'ObtPictureBox
        '
        Me.ObtPictureBox.BackColor = System.Drawing.Color.Silver
        Me.ObtPictureBox.Location = New System.Drawing.Point(491, 60)
        Me.ObtPictureBox.Name = "ObtPictureBox"
        Me.ObtPictureBox.Size = New System.Drawing.Size(220, 227)
        Me.ObtPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ObtPictureBox.TabIndex = 3
        Me.ObtPictureBox.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightGray
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(723, 501)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Supplier"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(20, 336)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(684, 152)
        Me.DataGridView2.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SplCbEditKode)
        Me.GroupBox2.Controls.Add(Me.LblPegawai2)
        Me.GroupBox2.Controls.Add(Me.SplDeleteBtn)
        Me.GroupBox2.Controls.Add(Me.SplSaveBtn)
        Me.GroupBox2.Controls.Add(Me.SplEditBtn)
        Me.GroupBox2.Controls.Add(Me.SplInputBtn)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.SplAddressText)
        Me.GroupBox2.Controls.Add(Me.SplPhoneText)
        Me.GroupBox2.Controls.Add(Me.SplNameText)
        Me.GroupBox2.Controls.Add(Me.SplKodeText)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(685, 303)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Supplier"
        '
        'SplCbEditKode
        '
        Me.SplCbEditKode.FormattingEnabled = True
        Me.SplCbEditKode.Location = New System.Drawing.Point(119, 30)
        Me.SplCbEditKode.Name = "SplCbEditKode"
        Me.SplCbEditKode.Size = New System.Drawing.Size(100, 21)
        Me.SplCbEditKode.TabIndex = 14
        Me.SplCbEditKode.Visible = False
        '
        'LblPegawai2
        '
        Me.LblPegawai2.AutoSize = True
        Me.LblPegawai2.Location = New System.Drawing.Point(403, 14)
        Me.LblPegawai2.Name = "LblPegawai2"
        Me.LblPegawai2.Size = New System.Drawing.Size(10, 13)
        Me.LblPegawai2.TabIndex = 13
        Me.LblPegawai2.Text = "-"
        '
        'SplDeleteBtn
        '
        Me.SplDeleteBtn.Location = New System.Drawing.Point(256, 229)
        Me.SplDeleteBtn.Name = "SplDeleteBtn"
        Me.SplDeleteBtn.Size = New System.Drawing.Size(75, 34)
        Me.SplDeleteBtn.TabIndex = 12
        Me.SplDeleteBtn.Text = "Delete"
        Me.SplDeleteBtn.UseVisualStyleBackColor = True
        '
        'SplSaveBtn
        '
        Me.SplSaveBtn.Enabled = False
        Me.SplSaveBtn.Location = New System.Drawing.Point(175, 229)
        Me.SplSaveBtn.Name = "SplSaveBtn"
        Me.SplSaveBtn.Size = New System.Drawing.Size(75, 34)
        Me.SplSaveBtn.TabIndex = 11
        Me.SplSaveBtn.Text = "Save"
        Me.SplSaveBtn.UseVisualStyleBackColor = True
        '
        'SplEditBtn
        '
        Me.SplEditBtn.Location = New System.Drawing.Point(94, 229)
        Me.SplEditBtn.Name = "SplEditBtn"
        Me.SplEditBtn.Size = New System.Drawing.Size(75, 34)
        Me.SplEditBtn.TabIndex = 10
        Me.SplEditBtn.Text = "Edit"
        Me.SplEditBtn.UseVisualStyleBackColor = True
        '
        'SplInputBtn
        '
        Me.SplInputBtn.Location = New System.Drawing.Point(13, 229)
        Me.SplInputBtn.Name = "SplInputBtn"
        Me.SplInputBtn.Size = New System.Drawing.Size(75, 34)
        Me.SplInputBtn.TabIndex = 9
        Me.SplInputBtn.Text = "Input"
        Me.SplInputBtn.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(406, 33)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(263, 258)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'SplAddressText
        '
        Me.SplAddressText.Location = New System.Drawing.Point(119, 134)
        Me.SplAddressText.Multiline = True
        Me.SplAddressText.Name = "SplAddressText"
        Me.SplAddressText.Size = New System.Drawing.Size(206, 78)
        Me.SplAddressText.TabIndex = 7
        '
        'SplPhoneText
        '
        Me.SplPhoneText.Location = New System.Drawing.Point(119, 97)
        Me.SplPhoneText.Name = "SplPhoneText"
        Me.SplPhoneText.Size = New System.Drawing.Size(206, 20)
        Me.SplPhoneText.TabIndex = 6
        '
        'SplNameText
        '
        Me.SplNameText.Location = New System.Drawing.Point(119, 63)
        Me.SplNameText.Name = "SplNameText"
        Me.SplNameText.Size = New System.Drawing.Size(206, 20)
        Me.SplNameText.TabIndex = 5
        '
        'SplKodeText
        '
        Me.SplKodeText.Location = New System.Drawing.Point(119, 30)
        Me.SplKodeText.Name = "SplKodeText"
        Me.SplKodeText.Size = New System.Drawing.Size(100, 20)
        Me.SplKodeText.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Alamat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Telepon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nama Supplier"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Kode Supplier"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(743, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.LogoutToolStripMenuItem1})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem.Text = "Transaksi"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LogoutToolStripMenuItem1
        '
        Me.LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        Me.LogoutToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem1.Text = "Logout"
        '
        'FormObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 556)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormObat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Obat"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ObtPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ObtCbSupplierID As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ObtDateExpire As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ObtQuantityText As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ObtNameText As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ObtIDText As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ObatDeleteButton As System.Windows.Forms.Button
    Friend WithEvents ObatSaveButton As System.Windows.Forms.Button
    Friend WithEvents ObatEditButton As System.Windows.Forms.Button
    Friend WithEvents ObatInputButton As System.Windows.Forms.Button
    Friend WithEvents ObtPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SplDeleteBtn As System.Windows.Forms.Button
    Friend WithEvents SplSaveBtn As System.Windows.Forms.Button
    Friend WithEvents SplEditBtn As System.Windows.Forms.Button
    Friend WithEvents SplInputBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents SplAddressText As System.Windows.Forms.TextBox
    Friend WithEvents SplPhoneText As System.Windows.Forms.TextBox
    Friend WithEvents SplNameText As System.Windows.Forms.TextBox
    Friend WithEvents SplKodeText As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ObatFilenameText As System.Windows.Forms.TextBox
    Friend WithEvents ObatBrowseButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LblPegawai As System.Windows.Forms.Label
    Friend WithEvents LblPegawai2 As System.Windows.Forms.Label
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplCbEditKode As System.Windows.Forms.ComboBox
    Friend WithEvents LblNamaSupplier As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ObtHargaText As System.Windows.Forms.TextBox
    Friend WithEvents ObtCbEditID As System.Windows.Forms.ComboBox
End Class
