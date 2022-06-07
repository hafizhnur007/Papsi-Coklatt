Public Class Marketing
    Sub KosongkanForm()
        txtcustomer.Text = ""
        txtalamat.Text = ""
        txtnotelp.Text = ""
        txttanggalorder.Text = ""
        txtjenisproduk.Text = ""
        txtjumlahproduk.Text = ""
        txtcustomer.Focus()
        'Coding diatas ada untuk mengosongkan Form yang sudah kita buat ,

    End Sub
    Sub MatikanForm()
        txtcustomer.Enabled = False
        txtalamat.Enabled = False
        txtnotelp.Enabled = False
        txttanggalorder.Enabled = False
        txtjenisproduk.Enabled = False
        txtjumlahproduk.Enabled = False
        'Coding diatas untuk menutup atau mematikan form agar tidak dapat isi
    End Sub
    Sub HidupkanForm()
        txtcustomer.Enabled = True
        txtalamat.Enabled = True
        txtnotelp.Enabled = True
        txttanggalorder.Enabled = True
        txtjenisproduk.Enabled = True
        txtjumlahproduk.Enabled = True
        'Coding diatas untuk mulai menghidupkan form agar form bisa diisi
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from Marketing ", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
        'Coding diatas untuk menampilkan data dari Ms.Access yang sudah kita

    End Sub
    Private Sub Marketing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MatikanForm()
        Call TampilkanData()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call HidupkanForm()
        Call KosongkanForm()
        ' Fungsi coding sama dengan diatas
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Call MatikanForm()
        Call KosongkanForm()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If txtcustomer.Text = "" Or txtalamat.Text = "" Or txtnotelp.Text = "" Or txttanggalorder.Text = "" Or txtjenisproduk.Text = "" Or txtjumlahproduk.Text = "" Then
            MsgBox("Data Order Belum Lengkap")
            Exit Sub
            'Coding ini berfungsi untuk mengecek jika salah satu field data
        Else
            'Call koneksiDB()
            ' CMD = New OleDb.OleDbCommand(" select * from Marketing where Id order='" & txtcustomer.Text & "'", Conn)
            ' DM = CMD.ExecuteReader
            'DM.Read()
            ' If Not DM.HasRows Then
            Call koneksiDB()
                Dim simpan As String
            simpan = "insert into Marketing values ('" & txtcustomer.Text & "', '" & txtalamat.Text & "', '" & txtnotelp.Text & "','" & txttanggalorder.Value.Date.ToString("yyyy/MM/dd") & "','" & txtjenisproduk.Text & "','" & txtjumlahproduk.Text & "')"
            CMD = New OleDb.OleDbCommand(simpan, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("Input Data Sukses")
            'Else
            'MsgBox("Data Sudah Ada")
            'End If
            Call MatikanForm()
            Call KosongkanForm()
            Call TampilkanData()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtcustomer.Text = "" Or txtalamat.Text = "" Or txtnotelp.Text = "" Or txttanggalorder.Text = "" Or txtjenisproduk.Text = "" Or txtjumlahproduk.Text = "" Then
            MsgBox("Data Order Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" update Order set Nama_Customer = '" & txtcustomer.Text & "', Alamat ='" & txtalamat.Text & "',No_Telp = '" & txtnotelp.Text & "',Tanggal_Order = '" & txttanggalorder.Text & "',Jenis_Produk= '" & txtjenisproduk.Text & "',Jumlah_Produk = '" & txtjumlahproduk.Text, Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")
        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If txtcustomer.Text = "" Then
            MsgBox("Tidak ada data order yang dipilih")
            Exit Sub
        Else
            If MessageBox.Show("Are you sure to delete this data ? ", "Konfirmasi", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then
                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Marketing where Id order ='" & txtcustomer.Text & "'", Conn)
                DM = CMD.ExecuteReader
                MsgBox("Hapus Data Berhasil")
                Call MatikanForm()
                Call KosongkanForm()
                Call TampilkanData()
            Else
                Call KosongkanForm()
                Call TampilkanData()
            End If
        End If
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        txtcustomer.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        txtalamat.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        txtnotelp.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        txttanggalorder.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        txtjenisproduk.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        txtjumlahproduk.Text = DGV.Rows(e.RowIndex).Cells(5).Value
        Call HidupkanForm()
        txtcustomer.Enabled = False 'Ketika mengedit , kita tidak bisa

    End Sub
End Class