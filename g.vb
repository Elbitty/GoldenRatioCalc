Module GoldenRule
    Function Calculate(to_val As Integer) As Double
        Const NUMBER_ONE As Integer = 1
        Dim i As Integer = NUMBER_ONE
        Dim j As Integer = NUMBER_ONE
        Dim tmp As Integer = 0
        For val As Integer = 1 To to_val
            tmp = i + j
            i = j
            j = tmp
        Next
        Return j / i
    End Function

    Sub Main()
        Console.WriteLine(Calculate(24).ToString)
    End Sub
End Module
