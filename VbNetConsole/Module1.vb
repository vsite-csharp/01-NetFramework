Module Module1

    Sub Main()

        Dim sum As Integer = 0
        For i = 1 To 100 Step 1
            sum = sum + i
        Next
        Console.WriteLine(sum)

        Console.WriteLine("GOTOVO!!!")
        Console.ReadKey(True)
    End Sub

End Module
