Public Class Form4
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
        txtidprod.Text = False
        txtjenisprod.Text = False
        txtjumlahprod.Text = False
        txtkapasitas.Text = False
        txtketerangan.Text = False
        txtlineprod.Text = False
        txtmaterial.Text = False
        txttargetprod.Text = False
        'Coding diatas untuk menutup atau mematikan form agar tidak dapat isi
    End Sub
    Sub HidupkanForm()
        txtidprod.Text = True
        txtjenisprod.Text = True
        txtjumlahprod.Text = True
        txtkapasitas.Text = True
        txtketerangan.Text = True
        txtlineprod.Text = True
        txtmaterial.Text = True
        txttargetprod.Text = True
        'Coding diatas untuk mulai menghidupkan form agar form bisa diisi
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from Produksi ", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
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
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" update Produksi set Id_Produksi = '" & txtidprod.Text & "', Jenis_produksi ='" & txtjenisprod.Text & "',Jumlah_produksi = '" & txtjumlahprod.Text & "',Line_produksi = '" & txtlineprod.Text & "',Material= '" & txtmaterial.Text & "',Keterangan = '" & txtketerangan.Text & "', Kapasitas = '" & txtkapasitas.Text & "', Target_produksi '" & txttargetprod.Text, Conn)
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
End Class