Module Themes
    Public Function QuestionTheme() As Boolean
question:
        System.Console.Write("Enter Your Theme (Light Or Dark) : ")
        Dim theme As String = System.Console.ReadLine().ToLower()
        If theme = "light" Then
            System.Console.BackgroundColor = ConsoleColor.White
            System.Console.Clear()
            System.Console.ForegroundColor = ConsoleColor.Black
            Return True
        ElseIf theme = "dark" Then
            System.Console.BackgroundColor = ConsoleColor.Black
            System.Console.Clear()
            System.Console.ForegroundColor = ConsoleColor.White
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

    Public Function QuestionColor() As Boolean

questioncolor:
        System.Console.Write("Enter Your Theme Color (Black - White - Red - Blue - Green - Magenta - Yellow) : ")
        Dim color As String = System.Console.ReadLine().ToLower()
        System.Console.Clear()
        Dim successful As Boolean = True
        Select Case color
            Case "black"
                System.Console.ForegroundColor = ConsoleColor.Black
            Case "white"
                System.Console.ForegroundColor = ConsoleColor.White
            Case "red"
                System.Console.ForegroundColor = ConsoleColor.Red
            Case "blue"
                System.Console.ForegroundColor = ConsoleColor.Blue
            Case "green"
                System.Console.ForegroundColor = ConsoleColor.Green
            Case "magenta"
                System.Console.ForegroundColor = ConsoleColor.Magenta
            Case "yellow"
                System.Console.ForegroundColor = ConsoleColor.Yellow
            Case Else
                System.Console.BackgroundColor = ConsoleColor.Red
                System.Console.ForegroundColor = ConsoleColor.White
                System.Console.WriteLine("Theme Color It is invalid")
                System.Console.ResetColor()
                Console.ReadKey()
                GoTo questioncolor
                successful = False

        End Select
        Return successful
    End Function
End Module
