Module Module1

    Sub Main()

        'Dim myNewCar As Car = New Car
        Dim myNewCar As New Car
        'Dim myOtherCar As Car = myNewCar

        'Dim myOtherCar As New Car("BMW", 2005, 30000)


        Carlot.AddToInventory(myNewCar)


        myNewCar.Make = "Oldsmobile"
        myNewCar.Model = "Cutlas Supreme"
        myNewCar.Year = 1986
        myNewCar.Color = "Silver"

        'With myNewCar 
        '    .Make = "Olds"
        '    .Model = "Cutlas"
        '    .Year = 1986
        '    .Color = "Silver"
        'End With

        'Console.WriteLine("{0} - {1} - {2}", myNewCar.Make, myNewCar.Model, myNewCar.Year.ToString())
        'Console.WriteLine(determineMarketValue(myNewCar))
        'Console.WriteLine(myNewCar.determineMarketValue)

        Console.WriteLine("Before: " & myNewCar.Make)
        doByValue(myNewCar)
        Console.WriteLine("After By Value: " & myNewCar.Make)

        doByReference(myNewCar)
        Console.WriteLine("After By Reference: " & myNewCar.Make)

        Console.ReadLine()


    End Sub

    'Function determineMarketValue(ByVal myCar As Car) As Double
    '    ' Super Secret Formula

    '    Return 100.0

    'End Function

    Sub doByValue(ByVal myCar As Car)
        myCar = New Car
        myCar.Make = "BMW"
    End Sub

    Sub doByReference(ByRef myCar As Car)
        myCar = New Car
        myCar.Make = "BMW"
    End Sub

End Module


Public Class Car

    Public Make As String
    Public Model As String
    Public Year As Integer
    Public Color As String
    Public Amount As Double
    Public Surcharge As Double

    Public Sub New()

    End Sub

    Public Sub New(ByVal _Make As String, ByVal _Year As Integer, ByVal _amount As Double 
        Me.Make = _Make
        Me.Year = _Year
        Me.Amount = _amount
        Me.Surcharge = _amount * 1.025
    End Sub


    Public Function determineMarketValue() As Double
        ' Super Secret Formula

        Return 100.0

    End Function

    Public Sub myMethod(ByVal myParameter As String)

    End Sub
    Public Sub myMethod(ByVal aotherversion As String, ByVal myParameter As String)

    End Sub

    Public Sub myMethod(ByVal myParameter As Integer)

    End Sub


End Class

Public Class Carlot

    Public Shared Sub AddToInventory(ByVal newCar As Car)
        'Body of the method goes here.
    End Sub

End Class
