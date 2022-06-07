Imports System.Data.OleDb
Module Koneksi
    Public Conn As OleDbConnection
    Public DA As OleDbDataAdapter
    Public DS As DataSet
    Public CMD As OleDbCommand
    Public DM As OleDbDataReader
    Sub koneksiDB()
        Try
            Conn = New OleDbConnection("provider=microsoft.ace.oledb.12.0; data source =Papsi-Coklat.accdb")
            Conn.Open()
            'MsgBox("Connected")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub tampilkanData(sequel As String, DGV As DataGridView)
        DA = New OleDb.OleDbDataAdapter(sequel, Conn)
        DS = New DataSet
        DA.Fill(DS)

        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
    End Sub
End Module
