Module Module1

	Sub Main()
		
	    	Dim myValue As Date = Now()
		
	    	'Console.WriteLine(myValue.ToShortDateString())
	    	'Console.WriteLine(myValue.ToShortTimeString())
	    	'Console.WriteLine(myValue.AddDays(3).ToShortDateString())
	    	'Console.WriteLine(myValue.AddHours(-3)ToShortTimeString())
	    	'Console.WriteLine(myValue.DayOfWeek)
	    	'Console.WriteLine(myValue.Month)
		
	    	'Dim myBirthdate As New Date(2001, 9, 28)
		
	    	'Dim myBirthdate As New Date
    		'myBirthdate = Date.Parse("09/28/2001")
		
    		'Dim myBirthdate = #09/28/2001#
		
	    	Dim myAge = Date.Now.Subtract(myBirthdate)
	    	Console.WriteLine(myAge.TotalDays.ToString())
		
	    	'Console.WriteLine(myBirthdate)
    		Console.ReadLine()
		
	End Sub

End Module
