Module Module1

    Sub Main()
        Dim Word1Front As String = ""
        Dim Word2front As String = ""
        Dim Word1back As String = ""
        Dim Word2Back As String = ""
        Dim InputWord1 As String = ""
        Dim InputWord2 As String = ""
        Dim OutputWord As String = ""
        Dim Length_1 As Integer = 0
        Dim Length_2 As Integer = 0

        Console.Write("Enter your first word : ")
        InputWord1 = Console.ReadLine

        Console.Write("Enter your second word : ")
        InputWord2 = Console.ReadLine

        If Len(InputWord1) Mod 2 = 0 Then
            Word1Front = Left(InputWord1, (Len(InputWord1) / 2))
            Word1back = Right(InputWord1, (Len(InputWord1) / 2))
        Else
            Length_1 = Len(InputWord1) - 1
            Word1Front = Left(InputWord1, (Length_1 / 2) + 1)
            Word1back = Right(InputWord1, (Length_1 / 2))
        End If

        If Len(InputWord2) Mod 2 = 0 Then
            Word2front = Left(InputWord2, (Len(InputWord2) / 2))
            Word2Back = Right(InputWord2, (Len(InputWord2) / 2))
        Else
            Length_2 = Len(InputWord2) - 1
            Word2front = Left(InputWord2, (Length_2 / 2) + 1)
            Word2Back = Right(InputWord2, (Length_2 / 2))
        End If

        OutputWord = Word1Front & Word2front & Word1back & Word2Back

        Console.WriteLine("The new word is : " & OutputWord)

        Console.ReadKey()





    End Sub

End Module
