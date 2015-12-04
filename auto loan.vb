 Dim globalMonths As Double = 60.0
    Const maxLoanAmountAllowed As Integer = 25000
    Const maxLowCreditAllowed As Double = 5000


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        nudLoanAmount.Maximum = maxLoanAmountAllowed

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        
        nudLoanAmount.Value = 0.0
        nudRate.Value = 5.0
        btn3years.Checked = False
        btn5years.Checked = False
        btn7years.Checked = False
        TextBox1.Text = "$0.00"
        cmbCreditRating.SelectedIndex = -1
    End Sub

    Private Sub btn3years_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3years.CheckedChanged
        globalMonths = 36
    End Sub

    Private Sub btn5years_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5years.CheckedChanged
        globalMonths = 60
    End Sub

    Private Sub btn7years_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7years.CheckedChanged
        globalMonths = 84
    End Sub

    Private Sub btnComputePayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim dblRate, dblMonths, dblPayment As Double
        Dim dblLoanAmount As Double, strPayment As String
        Dim dblAdjustedRate As Double, strErrorMessage As String

        dblLoanAmount = Convert.ToDouble(nudloanamount.Value)

        If cmbCreditRating.Text = "" Then
            MessageBox.Show("Please enter the customer's credit rating in the credit rating box.", "No Credit Rating")
            cmbCreditRating.Focus()
            Exit Sub
        End If


        dblRate = (Convert.ToDouble(nudRate.Value) / 100) / 12

        Select Case cmbCreditRating.SelectedIndex
            Case 0
                dblAdjustedRate = dblRate
            Case 1
                dblAdjustedRate = dblRate * 1.1
            Case 2
                dblAdjustedRate = dblRate * 1.15
            Case 3
                dblAdjustedRate = dblRate * 1.17
            Case 4
                dblAdjustedRate = dblRate * 1.25

        End Select



        dblPayment = Pmt(dblAdjustedRate, globalMonths, -dblLoanAmount)
        strPayment = Format$(dblPayment, "Currency")
        TextBox1.Text = strPayment

    End Sub
End Class
