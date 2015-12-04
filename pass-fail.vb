Dim usernumber As Integer
    Dim numberCounter As Integer

    Private Sub Enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enter.Click

        numberCounter = numberCounter + 1
        Labelnumbercounter.Text = numberCounter


        usernumber = Val(userInput.Text)
        If usernumber = 42 Then

            LabelYouAreTheWinner.Text = "You're the Lucky Winner"
            LabelYouAreTheWinner.BackColor = Color.LimeGreen
            LabelYouAreTheWinner.Visible = True

        ElseIf usernumber > 42 And usernumber < 101 Then

            LabelYouAreTheWinner.Text = " Your guess is to high, Try again"
            LabelYouAreTheWinner.Visible = True


        ElseIf usernumber > 0 And usernumber < 42 Then
            LabelYouAreTheWinner.Text = "Your guess is to low ,Try again"
            LabelYouAreTheWinner.Visible = True


        Else
            LabelYouAreTheWinner.Text = "Your guess is not even a possible answer"
            LabelYouAreTheWinner.Visible = True

        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click


        If usernumber = 42 Then
            Labelnumbercounter.Text = 0
            numberCounter = 0
        End If

        userInput.Text = ""
        LabelYouAreTheWinner.Visible = False
    End Sub

    Private Sub Form1AreYouLucky_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        userInput.Text = ""
        LabelYouAreTheWinner.Visible = False
    End Sub
End Class
