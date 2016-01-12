Dim regularhours, overtimehours, rate As Integer
    Private Sub btncompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncompute.Click
        rate = tbxamount.Text
        If nudhoursworked.Value > 40 Then
            overtimehours = nudhoursworked.Value - 40
            tbxpay.Text = (overtimehours * (rate * 1.5)) + ((nudhoursworked.Value - 10) * rate)
        Else
        regularhours = nudhoursworked.Value
        End If


    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        tbxpay.Text = " "
        tbxamount.Text = " "
        nudhoursworked.Value = "0"
    End Sub
End Class
