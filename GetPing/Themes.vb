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
            GoTo question
            Return False
        End If
    End Function
End Module
