Module Module1

    Sub Main()

        Dim Player1, Player2 As String

        Dim hand1, hand2 As Integer



        For Counter As Integer = 1 To 5

            Randomize()

            hand1 = Int((3 * Rnd()) + 1)

            Randomize()

            hand2 = Int((3 * Rnd()) + 1)

        Next

        If hand1 = 1 Then

            Player1 = "Scissors"

        ElseIf hand1 = 2 Then

            Player1 = "Paper"

        ElseIf hand1 = 3 Then

            Player1 = "Rock"

        End If

        If hand2 = 1 Then

            Player2 = "Scissors"

        ElseIf hand1 = 2 Then

            Player2 = "Paper"

        ElseIf hand1 = 3 Then

            Player2 = "Rock"

        End If

        If Player1 = "Scissors" Then

            If Player2 = "Scissors" Then

                Console.WriteLine("Player 1 " & Player1 & " Player 2 " & Player2 & " No one wins")

            ElseIf Player2 = "Paper" Then

                Console.WriteLine("Player 1 " & Player1 & " Player 2 " & Player2 & " Player 1 wins")

            ElseIf Player2 = "Rock" Then

                Console.WriteLine("Player 1 " & Player1 & " Player 2 " & Player2 & " Player 2 wins")

            End If

        End If

        If Player1 = "Rock" Then

            If Player2 = "Scissors" Then

                Console.WriteLine("Player 1 " & Player1 & " Player 2 " & Player2 & " Player 1 wins")

            ElseIf Player2 = "Paper" Then

                Console.WriteLine("Player 1 " & Player1 & " Player 2 " & Player2 & " Player 2 wins")

            ElseIf Player2 = "Rock" Then

                Console.WriteLine("Player 1 " & Player1 & " Player 2 " & Player2 & " No one wins")

            End If

        End If

        If Player1 = "Paper" Then

            If Player2 = "Scissors" Then

                Console.WriteLine("Player 1 " & Player1 & " Player 2 " & Player2 & " Player 1 wins")

            ElseIf Player2 = "Paper" Then

                Console.WriteLine("Player 1 " & Player1 & " Player 2 " & Player2 & " No one wins")

            ElseIf Player2 = "Stone" Then

                Console.WriteLine("Player 1 " & Player1 & " Player 2 " & Player2 & " Player 1 wins")

            End If

        End If

        Console.Read()

    End Sub

End Module
