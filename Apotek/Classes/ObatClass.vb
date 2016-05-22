Public Class ObatClass
    Inherits Koneksi
#Region "declaration"
    Private id As String
    Private name As String
    Private quantity As Integer
    Private price As Long
    Private supplier As String
    Private logo As String
    Private expDate As Date


    Dim tabel As String = "obat"

#End Region

#Region "properties"

    Public Property kode As String
        Get
            Return Me.id
        End Get
        Set(ByVal value As String)
            Me.id = value
        End Set
    End Property

    Public Property nama As String
        Get
            Return Me.name
        End Get
        Set(ByVal value As String)
            Me.name = value
        End Set
    End Property

    Public Property jumlah As Integer
        Get
            Return Me.quantity
        End Get
        Set(ByVal value As Integer)
            Me.quantity = value
        End Set
    End Property

    Public Property harga As Long
        Get
            Return Me.price
        End Get
        Set(ByVal value As Long)
            Me.price = value
        End Set
    End Property

    Public Property penyedia As String
        Get
            Return Me.supplier
        End Get
        Set(ByVal value As String)
            Me.supplier = value
        End Set
    End Property

    Public Property foto As String
        Get
            Return Me.logo
        End Get
        Set(ByVal value As String)
            Me.logo = value
        End Set
    End Property

    Public Property tanggalBasi As String
        Get
            Return Me.expDate
        End Get
        Set(ByVal value As String)
            Me.expDate = value
        End Set
    End Property

#End Region

#Region "display_data"

    Public Sub loadData(ByVal cb As ComboBox)
        Dim atribut As String = "id_obat"
        Try
            tutupKoneksi()
            bukaKoneksi()
            cb.Items.Clear()
            perintah.CommandText = "SELECT " & atribut & " FROM " & tabel & ";"
            perintah.Connection = koneksi
            bacadata = perintah.ExecuteReader
            Do While bacadata.Read
                cb.Items.Add(bacadata.Item(atribut).ToString)
            Loop
            tutupKoneksi()
        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
    End Sub

    Public Sub loadData(ByVal cb As ComboBox, ByVal cb2 As ComboBox)
        Dim atribut As String = "id_obat"
        Try
            tutupKoneksi()
            bukaKoneksi()
            cb.Items.Clear()
            perintah.CommandText = "SELECT " & atribut & " FROM " & tabel & ";"
            perintah.Connection = koneksi
            bacadata = perintah.ExecuteReader
            Do While bacadata.Read
                cb.Items.Add(bacadata.Item(atribut).ToString)
                cb2.Items.Add(bacadata.Item(atribut).ToString)
            Loop
            tutupKoneksi()
        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
    End Sub

    Public Sub displayForTransaksi(ByVal key As String)
        Try
            tutupKoneksi()
            bukaKoneksi()
            Dim query As String = "SELECT *" & _
            " FROM " & tabel & _
            " WHERE id_obat ='" & key & "';"
            perintah.CommandText = query
            perintah.Connection = koneksi
            bacadata = perintah.ExecuteReader

            Do While bacadata.Read
                'namaJasa.Text = bacadata.Item("nama_jasa").ToString()
                kode = bacadata.Item("id_obat").ToString()
                nama = bacadata.Item("nama_obat").ToString()
                harga = CLng(bacadata.Item("harga_obat").ToString)
                jumlah = CInt(bacadata.Item("jumlah_obat").ToString)

                foto = bacadata.Item("foto_obat").ToString()
                penyedia = bacadata.Item("id_supplier").ToString()
                tanggalBasi = bacadata.Item("exp_date").ToString()
            Loop
            tutupKoneksi()
        Catch ex As Exception

        End Try
    End Sub


    Public Sub displayForUpdate(ByVal key As String, ByVal nama As TextBox, ByVal harga As TextBox, ByVal jumlah As TextBox, _
                                ByVal foto As TextBox, ByVal supplier As ComboBox, ByVal tgl As DateTimePicker)
        Try
            tutupKoneksi()
            bukaKoneksi()
            Dim query As String = "SELECT *" & _
            " FROM " & tabel & _
            " WHERE id_obat ='" & key & "';"
            perintah.CommandText = query
            perintah.Connection = koneksi
            bacadata = perintah.ExecuteReader
            Do While bacadata.Read
                'namaJasa.Text = bacadata.Item("nama_jasa").ToString()
                nama.Text = bacadata.Item("nama_obat").ToString()
                harga.Text = bacadata.Item("harga_obat").ToString()
                jumlah.Text = bacadata.Item("jumlah_obat").ToString()

                foto.Text = bacadata.Item("foto_obat").ToString()
                supplier.Text = bacadata.Item("id_supplier").ToString()
                tgl.Value = bacadata.Item("exp_date").ToString()
            Loop
            tutupKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
            'MsgBox(perintah.CommandText)
        End Try
    End Sub

    Public Sub showDataGrid(ByVal DataGridView As DataGridView)
        Try
            DataGridView.Columns.Clear()
            DataGridView.Rows.Clear()
            bukaKoneksi()
            Dim a As String = "SELECT * FROM " & tabel & " ;"
            perintah.CommandText = a '"SELECT * FROM " & tabel & ";"
            perintah.Connection = koneksi
            bacadata = perintah.ExecuteReader
            DataGridView.Columns.Add("kodeObat", "Kode Obat")
            DataGridView.Columns("kodeObat").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridView.Columns.Add("namaObat", "Nama Obat")
            DataGridView.Columns("namaObat").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            DataGridView.Columns.Add("jumlah", "Jumlah")
            DataGridView.Columns("jumlah").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridView.Columns.Add("harga", "Harga")
            DataGridView.Columns("harga").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridView.Columns.Add("expDate", "Expire Date")
            DataGridView.Columns("expDate").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            Dim number As Integer = 0
            Do While bacadata.Read

                DataGridView.Rows.Add()
                With DataGridView.Rows(number)
                    .Cells("kodeObat").Value = bacadata.Item("id_obat").ToString
                    .Cells("namaObat").Value = bacadata.Item("nama_obat").ToString
                    .Cells("jumlah").Value = bacadata.Item("jumlah_obat").ToString
                    .Cells("harga").Value = bacadata.Item("harga_obat").ToString
                    .Cells("expDate").Value = bacadata.Item("exp_date").ToString
                End With
                number += 1
            Loop
            tutupKoneksi()
        Catch ex As Exception
            MessageBox.Show("kesalahan pada query data")
        End Try
    End Sub

#End Region

#Region "insert_data"

    Public Function masukkanData(ByVal id As String, ByVal namaObat As String, ByVal hargaObat As String, ByVal jumlahObat As String, _
                                ByVal fotoObat As String, ByVal idSupplier As String, ByVal expDate As String) As Boolean
        Try
            tutupKoneksi()
            bukaKoneksi()
            perintah.CommandText = "INSERT INTO " & tabel & " (id_obat,nama_obat,harga_obat,jumlah_obat,foto_obat,id_supplier,exp_date) " & _
            "VALUES('" & id & "','" & namaObat & "'," & hargaObat & "," & jumlahObat & ",'" & fotoObat & "','" & idSupplier & "','" & expDate & "');"
            perintah.Connection = koneksi
            perintah.ExecuteNonQuery()
            Return True
            tutupKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False

        End Try
    End Function

#End Region


#Region "update_data"

    Public Function updateData(ByVal key As String, ByVal namaObat As String, ByVal jumlahObat As String, ByVal hargaObat As String, ByVal fotoObat As String, ByVal idSupplier As String, ByVal expDate As String) As Boolean
        Try
            tutupKoneksi()
            bukaKoneksi()
            perintah.CommandText = "UPDATE " & tabel & " SET nama_obat ='" & namaObat & "', jumlah_obat=" & jumlahObat & ", harga_obat=" & hargaObat & ",foto_obat='" & fotoObat & "',id_supplier='" & idSupplier & "',exp_date='" & expDate & "'" & _
            " WHERE id_obat ='" & key & "';"
            perintah.Connection = koneksi
            perintah.ExecuteNonQuery()
            Return True
            tutupKoneksi()
        Catch ex As Exception
            MsgBox(perintah.CommandText)
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function

#End Region


#Region "delete_data"
    Public Function deleteData(ByVal key As String) As Boolean
        Try
            tutupKoneksi()
            bukaKoneksi()
            perintah.CommandText = "DELETE FROM " & tabel & " WHERE id_obat ='" & key & "';"
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



End Class
