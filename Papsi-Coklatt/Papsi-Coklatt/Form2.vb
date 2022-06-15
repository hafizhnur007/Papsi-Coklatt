Public Class Planning
    Sub KosongkanForm()
        txtidp.Text = ""
        txtsrm.Text = ""
        txtidc.Text = ""
        txtjp.Text = ""
        txtidrm.Text = ""
        txtjrm.Text = ""

        txtidp.Focus()
        'Coding diatas ada untuk mengosongkan Form yang sudah kita buat ,
    End Sub


    Sub HidupkanForm()
        txtidp.Enabled = True
        txtsrm.Enabled = True
        txtidc.Enabled = True
        txtjp.Enabled = True
        txtidrm.Enabled = True
        txtjrm.Enabled = True
        cbjp.Enabled = True
        cblp.Enabled = True
        'Coding diatas untuk mulai menghidupkan form agar form bisa diisi
    End Sub
    Sub MatikanForm()
        txtidp.Enabled = False
        txtsrm.Enabled = False
        txtidc.Enabled = False
        txtjp.Enabled = False
        txtidrm.Enabled = False
        txtjrm.Enabled = False
        cbjp.Enabled = False
        cblp.Enabled = False
        'Coding diatas untuk menutup atau mematikan form agar tidak dapat isi
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from Input ", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV2.DataSource = DS.Tables(0)
        DGV2.ReadOnly = True
        'Coding diatas untuk menampilkan data dari Ms.Access yang sudah kita
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Call HidupkanForm()
        Call KosongkanForm()
        Call HidupkanForm()
        Call KosongkanForm()
        Dim urutankode As String
        urutankode = "IDP" + GetRandom(1, 999)
        txtidp.Text = urutankode
        ' Fungsi coding sama dengan diatas
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call MatikanForm()
        Call KosongkanForm()
        ' Fungsi coding sama dengan diatas
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If txtidp.Text = "" Or txtsrm.Text = "" Or txtidc.Text = "" Or txtjp.Text = "" Or txtidrm.Text = "" Or txtjrm.Text = "" Or cbjp.Text =
"" Or cblp.Text = "" Then
            MsgBox("Data Input Belum Lengkap")
            Exit Sub
            'Coding ini berfungsi untuk mengecek jika salah satu field data
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Input where ID_Planning
='" & txtidp.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            'Coding ini berfungsi untuk mengecek jika di bagian kode buku

            'Jika data inputan tidak sama , maka ke If Not : masukkan inputan

            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Input values ('" & txtidp.Text &
"', '" & txtsrm.Text & "', '" & txtidc.Text & "','" &
txtjp.Text & "','" & txtidrm.Text & "','" & txtjrm.Text & "','" & cbjp.Text & "','" &
cblp.Text & "')"
                CMD = New OleDb.OleDbCommand(simpan, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("Input Data Sukses")
            Else
                MsgBox("Data Sudah Ada")
            End If
            Call MatikanForm()
            Call KosongkanForm()
            Call TampilkanData()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If txtidp.Text = "" Or txtsrm.Text = "" Or txtidc.Text =
"" Or txtjp.Text = "" Or txtidrm.Text = "" Or txtjrm.Text = "" Or cbjp.Text =
"" Or cblp.Text = "" Then
            MsgBox("Data Input Belum Lengkap")
            Exit Sub
            'Coding berfungsi untuk mengecek jika ada field yang belum terisi
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" update Input set ID_Customer = '" &
           txtidc.Text & "', Stock ='" & txtsrm.Text & "',Jumlah_Produksi = '" &
           txtjp.Text & "',ID_RM = '" & txtidrm.Text & "',Jumlah_RM_Terpakai= '" & txtjrm.Text & "',Jenis_Produk = '" &
           cbjp.Text & "',Line_Produksi = '" & cblp.Text & "' where ID_Planning
='" & txtidp.Text & "'", Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")
            'Coding berfungsi untuk mengedit dan mengupdate data yang dipilih
            'untuk kemudian disimpan lagi di tabel Ms.Access yang sdh dibuat
        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub DGV2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV2.CellContentClick

        On Error Resume Next
        txtidp.Text = DGV2.Rows(e.RowIndex).Cells(0).Value
        cbjp.Text = DGV2.Rows(e.RowIndex).Cells(1).Value
        txtjp.Text = DGV2.Rows(e.RowIndex).Cells(2).Value
        txtidrm.Text = DGV2.Rows(e.RowIndex).Cells(3).Value
        txtjrm.Text = DGV2.Rows(e.RowIndex).Cells(4).Value
        DateTimePicker4.Text = DGV2.Rows(e.RowIndex).Cells(5).Value
        DateTimePicker3.Text = DGV2.Rows(e.RowIndex).Cells(6).Value
        'Coding ini berfungsi , ketika kita mau mengedit data ,caranya kita
        'arahkan mouse ke salah satu cell yang di Data Grid View , maka data dari cell
        'tersebut akan masuk ke dalam field yang ada form
        'Cell(0) , Cell(1) dst artinya : dimulai dari Cell ke O , 1 dan
        'seterusnya
        Call HidupkanForm()
        txtidp.Enabled = False 'Ketika mengedit , kita tidak bisa
        'mengedit kode buku nya , kita hanya bisa mengedit di field2 lainnya
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form4.Show()
    End Sub


End Class