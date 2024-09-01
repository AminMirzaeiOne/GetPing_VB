Imports System.Net.NetworkInformation
Imports System.Text
Imports Microsoft

Module Program

    Sub Main()
        System.Console.Write("Ping Or Themes Or Info : ")
        Dim menu As String = System.Console.ReadLine().ToLower()
        Dim hostName As String = ""
        If menu = "ping" Then
pingstart:
            Banner()
            System.Console.Write("Enter Your Host example(www.google.com) : ")
            hostName = System.Console.ReadLine().ToLower().Trim()
            CheckPing(hostName)
        ElseIf menu = "themes" Then
            If Themes.QuestionTheme().Equals(True) Then
                GoTo pingstart
            End If
        ElseIf menu = "info" Then


        End If

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
        Dim hostname_or_ip As String = url
        Dim data As String = ""
        Dim timeout As Integer = 0
        Dim ping As Ping = New Ping()
        Dim pingOptions As PingOptions = New PingOptions(64, True)
        timeout = 120
        data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        Dim buffer As Byte() = Encoding.ASCII.GetBytes(data)
        Dim reply As PingReply = ping.Send(hostname_or_ip, timeout, buffer, pingOptions)
        Console.WriteLine("-------------------------------------------------")
        ' Check if the connection was successful
        If reply.Status = IPStatus.Success Then
            ' Connection status
            Console.WriteLine("Connection: {0}", reply.Status.ToString())

            ' Destination IP address
            Console.WriteLine("Address: {0}", reply.Address.ToString())

            ' RoundTrip time
            Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime)

            ' TTL
            Console.WriteLine("Time to live (TTL): {0}", reply.Options.Ttl)

            ' Packet size
            Console.WriteLine("Buffer size: {0}", reply.Buffer.Length)

            ' Fragment
            Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment)
        Else
            Console.WriteLine("Ping failed!")
        End If
    End Sub

End Module
