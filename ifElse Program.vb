Module Module1

    Sub Main()

        Dim userName As String

        'Console.WriteLine("Please type something and press Enter")
        'Dim userValue As String
        'userValue(-Console.ReadLine())
        'Console.WriteLine("You typed: " & userValue)
        'Console.Readline()

        Console.WriteLine("Hello this is your host Bilbo Baggins")
        Console.WriteLine("And Welcome to Go Big or Go Home!")
        Console.WriteLine(vbCrLf)
        Console.Write("What is the name of our lucky guest today?:" + vbCrLf)
        userName = Console.ReadLine()
        Console.WriteLine(vbCrLf)
        Console.WriteLine("Hello " & userName & " and welcome to the show.")
        Console.WriteLine("Now Lets get into the game " + userName)
        Console.WriteLine(vbCrLf)
        Console.WriteLine("What door would you like to open " & userName & " 1,2, or 3?")
        Dim userValue As String = Console.ReadLine()

        If userValue = "1" Then
            Console.WriteLine("You won tickets to a Dodger game!")
            Console.WriteLine("Have fun at the game")

        ElseIf userValue = "2" Then
            Console.WriteLine("You won $1,000,000!")
            Console.WriteLine("Wow")

        ElseIf userValue = "3" Then
            Console.WriteLine("You won a new TV!")
            Console.WriteLine("Have fun watching the game from your movie theater!")

        ElseIf userValue = "Go Bruins" Then
            Console.WriteLine("You won a 4-Year Scholarship to UCLA!")
            Console.WriteLine("Go get your education")

        ElseIf userValue = "Joey Yonezawa" Then
            Console.WriteLine("You won a new TV, $1,000,000, tickets to a Dodger game, and a 4-Year Scholarship to UCLA!!!")
            Console.WriteLine("You must of cheated")

        Else
            Console.WriteLine("That was not a given answer you lose! :(")
            Console.WriteLine("Listen next time " & userName)
            Console.ReadLine()
        End If

        Console.WriteLine(vbCrLf)
        Console.WriteLine("It was fun to have you here " & userName)
        Console.WriteLine("Well that is all the time we have here today, see you next time on Go Big or Go Home!")

    End Sub

End Module
