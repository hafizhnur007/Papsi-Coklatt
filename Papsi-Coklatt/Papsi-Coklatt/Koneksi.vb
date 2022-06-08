﻿Imports System.Data.OleDb
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
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As String
        ' by making Generator static, we preserve the same instance '
        ' (i.e., do not create new instances with the same seed over and over) '
        ' between calls '
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max).ToString
    End Function
End Module
