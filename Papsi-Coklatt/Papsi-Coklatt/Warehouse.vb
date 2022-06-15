Public Class Warehouse
    Dim OpenFileDialog1 As New OpenFileDialog
    Dim statusCari As Boolean
    Sub KosongkanForm()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        DateTimePicker1.Value = Now
        DateTimePicker2.Value = Now
        TextBox1.Focus()
        'Coding diatas ada untuk mengosongkan Form yang sudah kita buat ,
    End Sub
    Sub HidupkanForm()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True
        'Coding diatas untuk mulai menghidupkan form agar form bisa diisi
    End Sub
    Sub MatikanForm()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        'Coding diatas untuk menutup atau mematikan form agar tidak dapat isi
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from Warehouse_Material ", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        'Coding diatas untuk menampilkan data dari Ms.Access yang sudah kita
    End Sub
    Sub TampilkanData2()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from Warehouse_FG ", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView2.DataSource = DS.Tables(0)
        DataGridView2.ReadOnly = True
        'Coding diatas untuk menampilkan data dari Ms.Access yang sudah kita
    End Sub
    Private Sub DGV_MouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = e.RowIndex
        TextBox1.Text = DataGridView1.Rows(i).Cells(0).Value
        TextBox2.Text = DataGridView1.Rows(i).Cells(1).Value
        TextBox3.Text = DataGridView1.Rows(i).Cells(2).Value
        TextBox4.Text = DataGridView1.Rows(i).Cells(3).Value
        DateTimePicker1.Value = DataGridView1.Rows(i).Cells(4).Value
        TextBox6.Text = DataGridView1.Rows(i).Cells(5).Value
        DateTimePicker2.Value = DataGridView1.Rows(i).Cells(6).Value
        Call MatikanForm()
    End Sub
    Private Sub DGV_MouseClick2(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim i As Integer
        i = e.RowIndex
        TextBox7.Text = DataGridView2.Rows(i).Cells(0).Value
        DateTimePicker3.Value = DataGridView2.Rows(i).Cells(1).Value
        DateTimePicker4.Value = DataGridView2.Rows(i).Cells(2).Value
        Call MatikanForm()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        statusCari = True
        koneksiDB()
        Call MatikanForm()
        Call TampilkanData()
        Call TampilkanData2()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call HidupkanForm()
        Call KosongkanForm()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Data Input Belum Lengkap")
            Exit Sub
            'Coding ini berfungsi untuk mengecek jika salah satu field data
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Warehouse_Material where Kode_Material ='" & TextBox1.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            'Coding ini berfungsi untuk mengecek jika di bagian kode buku

            'Jika data inputan tidak sama , maka ke If Not : masukkan inputan

            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Warehouse_Material values ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "','" & TextBox4.Text & "','" & DateTimePicker1.Value.Date.ToString("yyyy/MM/dd") & "','" & TextBox6.Text & "','" & DateTimePicker2.Value.Date.ToString("yyyy/MM/dd") & "')"
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Tidak ada Kode yang dipilih")
            Exit Sub
        Else
            If MessageBox.Show("Are you sure to delete this data ? ", "Konfirmasi", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then
                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Warehouse_Material where Kode_MAterial ='" & TextBox1.Text & "'", Conn)
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call KosongkanForm()
        Call MatikanForm()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call HidupkanForm()
        Call KosongkanForm()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call KosongkanForm()
        Call MatikanForm()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox7.Text = "" Then
            MsgBox("Tidak ada ID yang dipilih")
            Exit Sub
        Else
            If MessageBox.Show("Are you sure to delete this data ? ", "Konfirmasi", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then
                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Warehouse_FG where ID_FG ='" & TextBox7.Text & "'", Conn)
                DM = CMD.ExecuteReader
                MsgBox("Hapus Data Berhasil")
                Call MatikanForm()
                Call KosongkanForm()
                Call TampilkanData2()
            Else
                Call KosongkanForm()
                Call TampilkanData2()
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox7.Text = "" Then
            MsgBox("Data Input Belum Lengkap")
            Exit Sub
            'Coding ini berfungsi untuk mengecek jika salah satu field data
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Warehouse_FG where ID_FG ='" & TextBox7.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            'Coding ini berfungsi untuk mengecek jika di bagian kode buku

            'Jika data inputan tidak sama , maka ke If Not : masukkan inputan

            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Warehouse_FG values ('" & TextBox7.Text & "', '" & DateTimePicker3.Value.Date.ToString("yyyy/MM/dd") & "','" & DateTimePicker4.Value.Date.ToString("yyyy/MM/dd") & "')"
                CMD = New OleDb.OleDbCommand(simpan, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("Input Data Sukses")
            Else
                MsgBox("Data Sudah Ada")
            End If
            Call MatikanForm()
            Call KosongkanForm()
            Call TampilkanData2()
        End If
    End Sub
End Class