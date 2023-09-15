Module Module1
    Sub Main()
        'Assignment - create a program called simple calculator, that will receive 
        '   two numbers from the user, add them together and display the output on the screen
        Console.WriteLine("Enter the first number: ")
        Dim x As Long = Console.ReadLine()
        Console.WriteLine("Enter the second number: ")
        Dim y As Long = Console.ReadLine()
        Dim sum As Long = x + y

        Console.WriteLine($"{x} + {y} = {sum}")
        Console.ReadKey(True)
    End Sub
End Module