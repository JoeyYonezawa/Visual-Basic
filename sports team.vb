  Dim baseball, football, soccer As String
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        lblFootball.Visible = False
        lblBaseball.Visible = False
        lblSentence.Text = " "
        rbBaseball.Checked = False
        rbFootball.Checked = False
        rbSoccer.Checked = False
    End Sub

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        baseball = rbBaseball.Text
        football = rbFootball.Text
        soccer = rbSoccer.Text

        If rbBaseball.Checked Then
            lblBaseball.Visible = True
            lblSentence.Text = " Baseball has 10 players on the field. "
        ElseIf rbFootball.Checked Then
            lblFootball.Visible = True
            lblSentence.Text = " Football has 22 players on the field. "
        ElseIf rbSoccer.Checked Then
            lblSoccer.Visible = True
            lblSentence.Text = " Soccer has 22 players on the field. "
        End If


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblSentence.Text = ""
        lblBaseball.Visible = False
        lblFootball.Visible = False
        lblSoccer.Visible = False
    End Sub
End Class
