 Private Sub btnComputeTax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComputeTax.Click
        txtTaxDue.Text = 0.03 * (txtIncome.Text - 600 * NumericUpDown1.Value)
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtIncome.Text = 0
        NumericUpDown1.Value = 0
        txtTaxDue.Text = "0"
    End Sub
