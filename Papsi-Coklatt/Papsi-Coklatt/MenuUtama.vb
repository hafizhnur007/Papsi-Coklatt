Public Class MenuUtama
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Marketing.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Produksi.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Planning.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Warehouse.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Purchasing.Show()
    End Sub

    Private Sub DataPlanningToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPlanningToolStripMenuItem.Click
        lprnplanning.Show()
    End Sub

    Private Sub DataMarketingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMarketingToolStripMenuItem.Click
        lprnmarketing.Show()
    End Sub

    Private Sub DataPurchasingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPurchasingToolStripMenuItem.Click
        lprnpurchasing.Show()
    End Sub

    Private Sub DataProduksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataProduksiToolStripMenuItem.Click
        lprnproduksi.Show()
    End Sub

    Private Sub DataWarehouseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataWarehouseToolStripMenuItem.Click
        lprnwarehousematerial.Show()
    End Sub

    Private Sub DataWarehouseFGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataWarehouseFGToolStripMenuItem.Click
        lprnwarehousefg.Show()
    End Sub
End Class
