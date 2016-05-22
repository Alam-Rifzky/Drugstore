Public Class SupplierClass
    Inherits Koneksi

    Dim tabel As String = "supplier"

#Region "declaration"
    Private id As String
    Private name As String
    Private phone As String
    Private address As String
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

    Public Property telepon As String
        Get
            Return Me.phone
        End Get
        Set(ByVal value As String)
            Me.phone = value
        End Set
    End Property

    

    Public Property alamat As String
        Get
            Return Me.address
        End Get
        Set(ByVal value As String)
            Me.address = value
        End Set
    End Property

#End Region

#Region "display_data"

    Public Sub loadData(ByVal cb As ComboBox, ByVal cb2 As ComboBox)
        Dim atribut As String = "id_supplier"
        Try
            tutupKoneksi()
            bukaKoneksi()
            cb.Items.Clear()
            perintah.CommandText = "SELECT " & atribut & " FROM " & tabel & ";"
            perintah.Connection = koneksi
            bacadata = perintah.ExecuteReader
            Do While bacadata.Read
                cb2.Items.Add(bacadata.Item(atribut).ToString)
                cb.Items.Add(bacadata.Item(atribut).ToString)
            Loop
            tutupKoneksi()
        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
    End Sub


    Public Sub displayForUpdate(ByVal key As String, ByVal namaSupplier As TextBox, ByVal telpSupplier As TextBox, _
                                ByVal alamatSupplier As TextBox)
        Try
            tutupKoneksi()
            bukaKoneksi()
            Dim query As String = "SELECT nama_supplier,telepon_supplier,alamat_supplier" & _
            " FROM " & tabel & _
            " WHERE id_supplier='" & key & "';"
            perintah.CommandText = query
            perintah.Connection = koneksi
            bacadata = perintah.ExecuteReader
            Do While bacadata.Read
                'namaJasa.Text = bacadata.Item("nama_jasa").ToString()
                namaSupplier.Text = bacadata.Item("nama_supplier").ToString()
                telpSupplier.Text = bacadata.Item("telepon_supplier").ToString()
                alamatSupplier.Text = bacadata.Item("alamat_supplier").ToString()

            Loop
            tutupKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
            'MsgBox(perintah.CommandText)
        End Try
    End Sub

    Public Function displaySupplierName(ByVal key As String) As String
        Try
            tutupKoneksi()
            bukaKoneksi()
            Dim query As String = "SELECT nama_supplier" & _
            " FROM " & tabel & _
            " WHERE id_supplier='" & key & "';"
            perintah.CommandText = query
            perintah.Connection = koneksi
            bacadata = perintah.ExecuteReader
            Do While bacadata.Read
                'namaJasa.Text = bacadata.Item("nama_jasa").ToString()
                nama = bacadata.Item("nama_supplier").ToString()
            Loop
            Return nama
            tutupKoneksi()
        Catch ex As Exception
            Return nama
            MsgBox(ex.ToString)
            'MsgBox(perintah.CommandText)
        End Try
    End Function

    Public Sub showDataGrid(ByVal DataGridView As DataGridView)
        Try
            DataGridView.Columns.Clear()
            DataGridView.Rows.Clear()
            bukaKoneksi()
            Dim a As String = "SELECT * FROM " & tabel & " ;"
            perintah.CommandText = a '"SELECT * FROM " & tabel & ";"
            perintah.Connection = koneksi
            bacadata = perintah.ExecuteReader
            DataGridView.Columns.Add("kodeSupplier", "Kode Supplier")
            DataGridView.Columns("kodeSupplier").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridView.Columns.Add("namaSupplier", "Nama Supplier")
            DataGridView.Columns("namaSupplier").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridView.Columns.Add("teleponSupplier", "Telepon")
            DataGridView.Columns("teleponSupplier").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridView.Columns.Add("alamatSupplier", "Alamat")
            DataGridView.Columns("alamatSupplier").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            Dim number As Integer = 0
            Do While bacadata.Read

                DataGridView.Rows.Add()
                With DataGridView.Rows(number)
                    .Cells("kodeSupplier").Value = bacadata.Item("id_supplier").ToString
                    .Cells("namaSupplier").Value = bacadata.Item("nama_supplier").ToString
                    .Cells("teleponSupplier").Value = bacadata.Item("telepon_supplier").ToString
                    .Cells("alamatSupplier").Value = bacadata.Item("alamat_supplier").ToString
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

    Public Function masukkanData(ByVal id As String, ByVal namaSupplier As String, ByVal teleponSupplier As String, _
                                 ByVal alamatSupplier As String) As Boolean
        Try
            tutupKoneksi()
            bukaKoneksi()
            perintah.CommandText = "INSERT INTO " & tabel & " (id_supplier,nama_supplier,telepon_supplier,alamat_supplier) " & _
            "VALUES('" & id & "','" & namaSupplier & "','" & teleponSupplier & "','" & alamatSupplier & "');"
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


#Region "update_data"

    Public Function updateData(ByVal key As String, ByVal namaSupplier As String, ByVal telpSupplier As String, ByVal alamatSupplier As String) As Boolean
        Try
            tutupKoneksi()
            bukaKoneksi()
            perintah.CommandText = "UPDATE " & tabel & " SET nama_supplier='" & namaSupplier & "', telepon_supplier='" & telpSupplier & "', alamat_supplier='" & alamatSupplier & "'" & _
            " WHERE id_supplier ='" & key & "';"
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


#Region "delete_data"

    Public Function deleteData(ByVal key As String) As Boolean
        Try
            tutupKoneksi()
            bukaKoneksi()
            perintah.CommandText = "DELETE FROM " & tabel & " WHERE id_supplier ='" & key & "';"
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
