Module Module1

    Sub Main()
        Dim MyList(6) As Integer
        Dim j, i, count, temp, n As Integer
        Dim NoMoreSwap As Boolean

        For i = 1 To 6
            Console.WriteLine("Input 6 list items to sort")
            MyList(i) = Console.ReadLine()
        Next
        n = 5

        Do
            NoMoreSwap = True
            For j = 1 To n
                If MyList(j + 1) < MyList(j) Then
                    temp = MyList(j)
                    MyList(j) = MyList(j + 1)
                    MyList(j + 1) = temp
                    NoMoreSwap = False


                End If
            Next
            n = n - 1



        Loop Until NoMoreSwap = True

        Console.WriteLine("New List")
        For count = 1 To 6
            Console.WriteLine(MyList(count))
        Next

        Console.ReadKey()
    End Sub

End Module
