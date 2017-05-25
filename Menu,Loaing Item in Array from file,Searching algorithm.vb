Imports System.IO
Module Module1
    Sub Main()
        Dim Choice As Integer

        Console.WriteLine("Menu")
        Console.WriteLine("1. Display File Contents")
        Console.WriteLine("2.Search Array for book")
        Console.WriteLine("3.End Program")
        Console.WriteLine("Input Choice")
        Choice = Console.ReadLine()


        Select Case Choice
            Case 1
                Call Display()
            Case 2
                Call SearchBook()
            Case 3
                Console.Clear()
        End Select
    End Sub

    Sub Display()
        Dim oRead As New System.IO.StreamReader("C:/Bookfile.txt")
        Dim Book(10) As String
        Dim count As Integer
        count = 1
        While oRead.EndOfStream = False
            Dim s As String
            s = oRead.ReadLine()

            Book(count) = s
            count = count + 1

        End While

        Console.ReadKey()

        For i = 1 To 10
            Console.WriteLine(Book(i))

        Next
        Console.ReadKey()
    End Sub
    Sub SearchBook()
        Dim oRead As New System.IO.StreamReader("C:/Bookfile.txt")
        Dim Book(10) As String
        Dim count As Integer
        count = 1
        While oRead.EndOfStream = False
            Dim s As String
            s = oRead.ReadLine()

            Book(count) = s
            count = count + 1

        End While
        Dim SearchItem, Found As String
        Console.WriteLine("Input Search")
        SearchItem = Console.ReadLine()
        For i = 1 To 10
            If Book(i) = SearchItem Then
                Found = i

            End If
        Next
        If Book(Found) = SearchItem Then
            Console.WriteLine("Book Found")
        Else
            Console.WriteLine("not found")

        End If
        Console.ReadKey()
    End Sub

End Module
