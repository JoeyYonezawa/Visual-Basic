 Dim unitCost, marginPercent, sellingPrice, totalValue, totalprofit, totalCost As Double
    Dim itemsOnHand As Integer
    Private Sub CalculateInventoryProfit()
        itemsOnHand = nudStock.Value
        marginPercent = (TrackBar1.Value / 100)
        unitCost = nudUnitCost.Value


        totalCost = nudStock.Value * nudUnitCost.Value
        lblTotalCost.Text = Format(totalCost, "Currency")

        sellingPrice = nudUnitCost.Value / (1 - marginPercent)
        lblSellingPrice.Text = Format(sellingPrice, "Currency")

        totalValue = sellingPrice * nudStock.Value
        lblTotalValue.Text = Format(totalValue, "Currency")

        totalprofit = totalValue - nudStock.Value
        lblTotalProfit.Text = Format(totalprofit, "Currency")

        marginPercent = TrackBar1.Value / 100
        TrackBar1.Text = Format(marginPercent, "Currency")

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub lblTotalCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotalCost.Click
        CalculateInventoryProfit()

    End Sub

    Private Sub lblSellingPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSellingPrice.Click
        CalculateInventoryProfit()


    End Sub

    Private Sub lblTotalValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotalValue.Click
        CalculateInventoryProfit()


    End Sub

    Private Sub lblTotalProfit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotalProfit.Click
        CalculateInventoryProfit()

    End Sub

End Class
