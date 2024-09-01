Module Themes
    Public Function QuestionTheme() As Boolean
question:
        System.Console.Write("Enter Your Theme (Light Or Dark) : ")
        Dim theme As String = System.Console.ReadLine().ToLower()
        If theme = "light" Then
            System.Console.BackgroundColor = ConsoleColor.White
            System.Console.Clear()
            Return True
        ElseIf theme = "dark" Then
            System.Console.BackgroundColor = ConsoleColor.Black
            System.Console.Clear()
            Return True
        Else
            System.Console.BackgroundColor = ConsoleColor.Red
            System.Console.ForegroundColor = ConsoleColor.White
            System.Console.WriteLine("Theme It is invalid")
            System.Console.ResetColor()
            Console.ReadKey()
            GoTo question
            Return False
        End If
    End Function

    Public Sub QuestionColor()
questioncolor:
        System.Console.Write("Enter Your Theme Color (Black - White - Red - Blue - Green - Magenta - Yellow) : ")
        Dim color As String = System.Console.ReadLine().ToLower()
        Select Case color
            Case "black"
                System.Console.ForegroundColor = ConsoleColor.Black
            Case "black"
                System.Console.ForegroundColor = ConsoleColor.Black
            Case "red"
                System.Console.ForegroundColor = ConsoleColor.Black
            Case "blue"
                System.Console.ForegroundColor = ConsoleColor.Black
            Case "green"
                System.Console.ForegroundColor = ConsoleColor.Black
            Case "magenta"
                System.Console.ForegroundColor = ConsoleColor.Black
            Case "yellow"
                System.Console.ForegroundColor = ConsoleColor.Black
            Case Else
                System.Console.BackgroundColor = ConsoleColor.Red
                System.Console.ForegroundColor = ConsoleColor.White
                System.Console.WriteLine("Theme Color It is invalid")
                System.Console.ResetColor()
                Console.ReadKey()
                GoTo questioncolor

        End Select
    End Sub
End Module
