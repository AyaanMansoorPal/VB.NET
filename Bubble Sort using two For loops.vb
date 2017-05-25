Module Module1

    Sub Main()
        Dim MyList(3) As Integer
        Dim i, j, count, temp, n, m As Integer
        n = 2

        For i = 1 To 3
            MyList(i) = Console.ReadLine()
        Next
        For m = 1 To 2
            For j = 1 To n
                If MyList(j + 1) < MyList(j) Then
                    temp = MyList(j)
                    MyList(j) = MyList(j + 1)
                    MyList(j + 1) = temp


                End If
            Next
            n = n - 1
        Next
        For count = 1 To 3
            Console.WriteLine(MyList(count))
        Next

        Console.ReadKey()
    End Sub

End Module
