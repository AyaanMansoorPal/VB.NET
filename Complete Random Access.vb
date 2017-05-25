Module Module1
    Structure Student
        <VBFixedString(10)> Dim StudentName As String
        Dim ID As Integer

    End Structure
    Public FileNum As Integer = FreeFile()
    Public RecLength As Long = Len(Record)
    Public Seek, RecordNumber As Integer
    Public Record As Student
    Sub Main()
        Dim nChoice As Integer

        Console.WriteLine("Input Choice")
        nChoice = Console.ReadLine()
        Do
            Select Case nChoice
                Case 1
                    Call InputRecord()
                Case 2
                    Call SeekRecord()
                Case 3
                    Call DisplayAll()
                Case 4
                    Console.Clear()
            End Select
        Loop Until nChoice = 4
        Console.ReadKey()


    End Sub
    Sub InputRecord()
        RecordNumber = 0
        Do
            Console.WriteLine("Input Student Name")
            Record.StudentName = Console.ReadLine()
            Console.WriteLine("Input Student ID")
            Record.ID = Console.ReadLine()


            FileOpen(FileNum, "StudentData.dat", OpenMode.Random, OpenAccess.Write, OpenShare.Default, RecLength)
            RecordNumber += 1
            FilePut(FileNum, Record, RecordNumber)
            FileClose(FileNum)
        Loop Until Record.ID = 999
        Console.ReadKey()
    End Sub
    Sub SeekRecord()
        Console.WriteLine("Input Record number:")
        Seek = Console.ReadLine()
        FileOpen(FileNum, "StudentData.dat", OpenMode.Random, OpenAccess.Read, RecLength)
        FileGet(FileNum, Record, Seek)
        FileClose(FileNum)

        Console.WriteLine()
        Console.WriteLine("Student Name" & Record.StudentName)
        Console.WriteLine("StudentID" & Record.ID)
        Console.ReadKey()

    End Sub
    Sub DisplayAll()
        Dim RecNum As Integer = 0
        FileOpen(FileNum, "StudentRecord.dat", OpenMode.Random, OpenAccess.Read, OpenShare.Default, RecLength)

        While Not EOF(FileNum)
            RecNum = RecNum + 1
            FileGet(FileNum, Record, RecNum)
            Console.WriteLine("Student Name" & Record.StudentName)
            Console.WriteLine("Student ID" & Record.ID)
        End While
        FileClose(FileNum)
        Console.ReadKey()

    End Sub

End Module
