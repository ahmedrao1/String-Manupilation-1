Module Module1

    Sub Main()
        Dim InputWord As String = ""
        Dim OutputWord As String = ""
        Dim FirstAlpha As Char = ""
        Dim l As Integer = 0

        Console.Write("Enter String : ")
        InputWord = Console.ReadLine

        FirstAlpha = Left(InputWord, 1)
        OutputWord = FirstAlpha

        For l = 1 To Len(InputWord) - 1
            If Mid(InputWord, l + 1, 1) = FirstAlpha Then
                OutputWord = OutputWord & "*"
            Else
                OutputWord = OutputWord & Mid(InputWord, l + 1, 1)
            End If
        Next

        Console.Write("Output is : " & OutputWord)
        Console.ReadKey()





    End Sub

End Module
