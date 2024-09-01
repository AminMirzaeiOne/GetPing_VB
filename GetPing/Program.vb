Imports System.Net.NetworkInformation

Module Program

    Sub Main()
        Banner()
        Console.ReadKey()
    End Sub

    Sub Banner()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("    ____  _                ______          __           ")
        Console.WriteLine("   / __ \(_)___  ____ _   /_  __/__  _____/ /____  __  _")
        Console.WriteLine("  / /_/ / / __ \/ __ `/    / / / _ \/ ___/ __/ _ \/  /_/")
        Console.WriteLine(" / ____/ / / / / /_/ /    / / /  __(__  ) /_/  __/  /   ")
        Console.WriteLine("/_/   /_/_/ /_/\__, /    /_/  \___/____/\__/\___/\_/    ")
        Console.WriteLine("              /____/                                    ")
    End Sub

    Sub CheckPing(url As String)
        Dim hostname_or_ip As String = ""
        Dim data As String = ""
        Dim timeout As Integer = ""

    End Sub

End Module
