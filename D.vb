Module Module1

    Sub Main()
        Dim Inputsentence As String = ""
        Dim Notfound As Boolean = False
        Dim Badfound As Boolean = False
        Dim OutputSentence As String = ""
        Dim Leftstring As String = ""
        Dim Rightstring As String = ""
        Dim Notpos As Integer = 0
        Dim Badpos As Integer = 0

        Console.Write("Enter the string: ")
        Inputsentence = Console.ReadLine

        If InStr(Inputsentence, "not") <> 0 Then
            Notpos = InStr(Inputsentence, "not")
            Notfound = True
        End If
        If InStr(Inputsentence, "bad") <> 0 Then
            Badpos = InStr(Inputsentence, "bad")
            Badfound = True
        End If
        If Notfound = False And Badfound = False Then
            Console.WriteLine("Not And Bad are not found...!")
        Else
            Leftstring = Mid(Inputsentence, 1, Notpos - 1)
            Rightstring = Mid(Inputsentence, Badpos + 3, Len(Inputsentence))
            OutputSentence = Leftstring & "good" & Rightstring

            Console.WriteLine("Output : " & OutputSentence)
        End If
        Console.ReadKey()





    End Sub

End Module
