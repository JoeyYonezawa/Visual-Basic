  Dim score As Integer = 0
    Private Sub initializeVaribles()
        score = 0
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        If TextBox1.Text < 20 Then

            score = score + 1

        ElseIf TextBox1.Text > 19 And TextBox1.Text < 30 Then

            score = score + 2
        Else

            score = score + 3

        End If

        If btnYes1.Checked Then
            score = score + 4
        End If

        If btnYes1.Checked Then
            score = score + 2
        End If

        If btnYes1.Checked Then
            score = score + 1
        End If

        lblScore.Text = CStr(score)

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        lblScore.Text = " "
        score = 0

        btnYes1.Checked = False
        btnYes2.Checked = False
        btnYes3.Checked = False
        btnNo1.Checked = False
        btnNo2.Checked = False
        btnNo3.Checked = False

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initializeVaribles()
    End Sub
End Class
