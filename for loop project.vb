 Dim x As Integer



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For x = 1 To 100 Step 1
            ListBox1.Items.Add(CStr(x))
            Console.WriteLine()
        Next
        For x = 40 To 0 Step -2
            ListBox2.Items.Add(CStr(x))
            Console.WriteLine()
        Next
        For x = -15 To 15 Step 1
            ListBox3.Items.Add(CStr(x))
            Console.WriteLine()
        Next
        For x = 50 To -50 Step -5
            ListBox4.Items.Add(CStr(x))
            Console.WriteLine()
        Next
        For x = 75 To 0 Step -5
            ListBox5.Items.Add(CStr(x))
            Console.WriteLine()
        Next
        For x = 0 To 30 Step 3
            ListBox6.Items.Add(CStr(x))
            Console.WriteLine()
        Next
    End Sub
End Class
