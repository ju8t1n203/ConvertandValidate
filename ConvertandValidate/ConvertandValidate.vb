Option Compare Text
Option Explicit On
Option Strict On
'Justin Bell
'RCET0265
'Fall 2024
'Convert and Validate
' link
Imports System.Threading

Module ConvertandValidate

    Sub Main()

        'just the given code
        Dim aValidNumber As Integer
        Dim usernResponse As String
        'defined the usernResponse varible

        Do
            Console.WriteLine("press ""Q"" to quit.")
            Console.WriteLine($"Enter a number:")
            usernResponse = Console.ReadLine()

            If usernResponse = "q" Then
                Exit Do
            End If

            If ConversionValid(usernResponse, aValidNumber) = True Then
                Console.WriteLine($"{usernResponse} converted successfully to {aValidNumber}!")
            Else
                Console.WriteLine($"Oops, {usernResponse} does not seem to be a number")
            End If

            'clears the console after one second, for fun
            Thread.Sleep(1000)
            Console.Clear()

        Loop

    End Sub

    'it works

    Function ConversionValid(convertThisString As String, ByRef toThisInteger As Integer) As Boolean
        'this produces a status to be returned
        Dim status As Boolean = False

        Try
            toThisInteger = CInt(convertThisString)
            status = True
        Catch ex As Exception
            status = False
        End Try

        Return status
    End Function

End Module
