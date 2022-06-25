Public Class Purchasing
    Sub KosongkanForm()
        txtno.Text = ""
        txtnama.Text = ""
        txtnotelp.Text = ""
        rtxalamat.Text = ""
        cbj.Text = ""
        txtj.Text = ""
        txtno.Focus()
        'Coding diatas ada untuk mengosongkan Form yang sudah kita buat ,
    End Sub
    Sub HidupkanForm()
        txtno.Enabled = True
        txtnama.Enabled = True
        txtnotelp.Enabled = True
        rtxalamat.Enabled = True
        cbj.Enabled = True
        txtj.Enabled = True
        'Coding diatas untuk mulai menghidupkan form agar form bisa diisi
    End Sub
    Sub MatikanForm()
        txtno.Enabled = False
        txtnama.Enabled = False
        txtnotelp.Enabled = False
        rtxalamat.Enabled = False
        cbj.Enabled = False
        txtj.Enabled = False
        'Coding diatas untuk menutup atau mematikan form agar tidak dapat isi
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call HidupkanForm()
        Call KosongkanForm()
        ' Fungsi coding sama dengan diatas
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call MatikanForm()
        Call KosongkanForm()
        ' Fungsi coding sama dengan diatas
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Show(Warehouse)
    End Sub
End Class