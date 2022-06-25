Public Class Produksi
    Sub KosongkanForm()
        txtidprod.Text = ""
        txtjenisprod.Text = ""
        txtjumlahprod.Text = ""
        txtkapasitas.Text = ""
        txtketerangan.Text = ""
        txtlineprod.Text = ""
        txtmaterial.Text = ""
        txttargetprod.Text = ""
        txtidprod.Focus()
        'Coding diatas ada untuk mengosongkan Form yang sudah kita buat ,

    End Sub
    Sub MatikanForm()
        txtidprod.Enabled = False
        txtjenisprod.Enabled = False
        txtjumlahprod.Enabled = False
        txtkapasitas.Enabled = False
        txtketerangan.Enabled = False
        txtlineprod.Enabled = False
        txtmaterial.Enabled = False
        txttargetprod.Enabled = False
        'Coding diatas untuk menutup atau mematikan form agar tidak dapat isi
    End Sub
    Sub HidupkanForm()
        txtidprod.Enabled = True
        txtjenisprod.Enabled = True
        txtjumlahprod.Enabled = True
        txtkapasitas.Enabled = True
        txtketerangan.Enabled = True
        txtlineprod.Enabled = True
        txtmaterial.Enabled = True
        txttargetprod.Enabled = True
        'Coding diatas untuk mulai menghidupkan form agar form bisa diisi
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from Produksi ", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV4.DataSource = DS.Tables(0)
        DGV4.ReadOnly = True
    End Sub
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MatikanForm()
        Call TampilkanData()
    End Sub
    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        Call HidupkanForm()
        Call KosongkanForm()
        Dim urutankode As String
        urutankode = "CKLT" + GetRandom(1, 999)
        txtidprod.Text = urutankode
    End Sub
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
    Private Sub Marketing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MatikanForm()
        Call TampilkanData()

    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtidprod.Text = "" Or txtjenisprod.Text = "" Or txtjumlahprod.Text = "" Or txtkapasitas.Text = "" Or txtketerangan.Text = "" Or txtlineprod.Text = "" Or txtmaterial.Text = "" Or txttargetprod.Text = "" Then
            MsgBox("Data Produk Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            Dim simpan As String
            simpan = "insert into Produksi values ('" & txtidprod.Text & "', '" & txtjenisprod.Text & "', '" & txtjumlahprod.Text & "','" & txtkapasitas.Text & "','" & txtketerangan.Text & "', '" & txtlineprod.Text & "','" & txtmaterial.Text & "','" & txttargetprod.Text & "')"
            CMD = New OleDb.OleDbCommand(simpan, Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Input Data Sukses")
            Call MatikanForm()
            Call KosongkanForm()
            Call TampilkanData()
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtidprod.Text = "" Or txtjenisprod.Text = "" Or txtjumlahprod.Text = "" Or txtkapasitas.Text = "" Or txtketerangan.Text = "" Or txtlineprod.Text = "" Or txtmaterial.Text = "" Or txttargetprod.Text = "" Then
            MsgBox("Data Order Belum Lengkap")
            Exit Sub
        Else
            'Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" update Produksi set Jenis_produksi ='" & txtjenisprod.Text & "',Jumlah_produksi = '" & txtjumlahprod.Text &
                                         "',Line_produksi = '" & txtlineprod.Text & "',Material= '" & txtmaterial.Text &
                                         "',Keterangan = '" & txtketerangan.Text & "', Kapasitas = '" & txtkapasitas.Text &
                                         "', Target_produksi '" & txttargetprod.Text & "' where Id_produksi ='" & txtidprod.Text & "'", Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")
        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtidprod.Text = "" Then
            MsgBox("Tidak ada id produksi yang dipilih")
            Exit Sub
        Else
            If MessageBox.Show("Are you sure to delete this data ? ", "Konfirmasi", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then
                CMD = New OleDb.OleDbCommand(" delete from Produksi where Id_Produksi ='" & txtidprod.Text & "'", Conn)
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

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Planning.Show()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Warehouse.Show()
    End Sub
    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV4.CellMouseClick
        On Error Resume Next
        txtidprod.Text = DGV4.Rows(e.RowIndex).Cells(0).Value
        txtjenisprod.Text = DGV4.Rows(e.RowIndex).Cells(1).Value
        txtjumlahprod.Text = DGV4.Rows(e.RowIndex).Cells(2).Value
        txtkapasitas.Text = DGV4.Rows(e.RowIndex).Cells(3).Value
        txtketerangan.Text = DGV4.Rows(e.RowIndex).Cells(4).Value
        txtlineprod.Text = DGV4.Rows(e.RowIndex).Cells(5).Value
        txtmaterial.Text = DGV4.Rows(e.RowIndex).Cells(6).Value
        txttargetprod.Text = DGV4.Rows(e.RowIndex).Cells(7).Value
        Call HidupkanForm()
        txtidprod.Enabled = False
    End Sub
End Class