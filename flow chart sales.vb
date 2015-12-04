 Dim Total As Integer
    Dim UserSales As Integer
    Dim UserComm As Integer
    Dim UserNumber As Integer
    

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        UserNumber = Val(TextBox1.Text)
        If TextBox1.Text > 40000 Then
            UserComm = UserNumber * 0.14
            lblResult.Text = " Based on sales of $" & UserNumber & ", your comm. of 14% is $" & UserComm
        End If

        UserNumber = Val(TextBox1.Text)
        If TextBox1.Text > 25000 And TextBox1.Text <= 40000 Then
            UserComm = UserNumber * 0.09
            lblResult.Text = " Based on sales of $" & UserNumber & ", your comm. of 9% is $" & UserComm
        End If

        UserNumber = Val(TextBox1.Text)
        If TextBox1.Text > 10000 And TextBox1.Text <= 25000 Then
            UserComm = UserNumber * 0.07
            lblResult.Text = " Based on sales of $" & UserNumber & ", your comm. of 7% is $" & UserComm
        End If

        UserNumber = Val(TextBox1.Text)
        If TextBox1.Text <= 10000 Then
            lblResult.Text = "YOUR FIRED!"
        End If

    End Sub



    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        TextBox1.Text = " "
        lblResult.Text = " "

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
