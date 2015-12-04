 Dim dollarvalue, eurovalue, poundsvalue As Double
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
    End Sub

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        dollarvalue = TextBox1.Text
        eurovalue = NumericUpDown1.Value
        poundsvalue = NumericUpDown2.Value

        TextBox2.Text = dollarvalue * eurovalue
        TextBox3.Text = dollarvalue * poundsvalue

    End Sub
