Module Module1
    Sub Main()

        Dim a, b As Integer
        Dim LargerValue, SmallerValue
        Dim GCD As Integer


        While a = 0 Or b = 0
            Console.WriteLine("Input first positive integer")
            a = Console.ReadLine()
            Console.WriteLine("Input second positive integer")
            b = Console.ReadLine()
        End While

        If a > b And a <> 0 And b <> 0 Then
            LargerValue = a
            SmallerValue = b
            GCD = CalculateGCD(LargerValue, SmallerValue)
        ElseIf a < b And a <> 0 And b <> 0 Then
            LargerValue = b
            SmallerValue = a
            GCD = CalculateGCD(LargerValue, SmallerValue)

        End If
        Console.WriteLine("The GCD is:" & Space(1.5) & GCD)


        If a > b Then
            LargerValue = a
            SmallerValue = b
            Console.WriteLine("Value of x, y and the GCD respectively")
            Console.Write(BezoutsLemma(SmallerValue, LargerValue))

        Else
            LargerValue = b
            SmallerValue = a
            Console.WriteLine("Value of x, y and the GCD respectively: Applying Bezouts Lemma")
            Console.Write(BezoutsLemma(SmallerValue, LargerValue))
        End If






        Console.ReadKey()
    End Sub

    Function CalculateGCD(ByVal Big As Integer, ByVal Small As Integer) As Integer
        Dim Remainder As Integer
        Dim Quotient As Integer
        Dim Answer As Integer

        Remainder = Big Mod Small
        Quotient = Int(Big / Small)


        If Remainder = 0 Then
            Return Small
        Else
            Answer = CalculateGCD(Small, Remainder)
            Return Answer
        End If


    End Function
    Function BezoutsLemma(ByVal Small As Integer, ByVal Big As Integer) As Tuple(Of Integer, Integer, Integer)
        Dim x, y As Integer
        Dim r As Integer
        Dim r2 As Integer
        Dim Qi As Integer
        Dim Matrix(10, 3) As Integer
        Dim i As Integer


        r = Big


        Matrix(0, 0) = 1
        Matrix(0, 1) = 0
        Matrix(0, 2) = r
        Matrix(0, 3) = 0


        r2 = Small


        Matrix(1, 0) = 0
        Matrix(1, 1) = 1
        Matrix(1, 2) = r2
        Matrix(1, 3) = 0



        For i = 2 To 10
            If r2 <> 0 Then
                Qi = Int(r / r2)
                Matrix(i, 3) = Qi
                r2 = Matrix(i - 2, 2) - Qi * r2
                r = Matrix(i - 1, 2)
                Matrix(i, 2) = r2
                x = Matrix(i - 2, 0) - Qi * Matrix(i - 1, 0)
                Matrix(i, 0) = x
                y = Matrix(i - 2, 1) - Qi * Matrix(i - 1, 1)
                Matrix(i, 1) = y




            End If


        Next

        Return Tuple.Create(x, y, r)



    End Function

End Module
