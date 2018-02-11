Module Module1

    Sub Main()
        Dim InputWord1 As String = ""
        Dim InputWord2 As String = ""
        Dim OutputWord As String = ""
        Dim Alpha As String = ""
        Dim AlphaB As String = ""

        Console.Write("Enter First Word : ")
        InputWord1 = Console.ReadLine
        Console.Write("Enter Second Word : ")
        InputWord2 = Console.ReadLine

        Alpha = Left(InputWord1, 2)
        AlphaB = Left(InputWord2, 2)

        OutputWord = AlphaB & Mid(InputWord1, 3, Len(InputWord1)) & " " & Alpha & Mid(InputWord2, 3, Len(InputWord2))

        Console.Write("New Word is: " & OutputWord)
        Console.ReadKey()






    End Sub

End Module
