Module Module1

    Sub Main()
        Dim Word As String = ""
        Dim LeftSide As String = ""
        Dim RightSide As String = ""

        Console.Write("Enter your word : ")
        Word = Console.ReadLine

        LeftSide = Left(Word, 2)
        RightSide = Right(Word, 2)

        If Len(Word) < 2 Then
            Console.Write("Your word is less than 2 alphabets")
        Else
            Console.Write("The new word is : " & LeftSide & RightSide)
        End If
        Console.ReadKey()





    End Sub

End Module
