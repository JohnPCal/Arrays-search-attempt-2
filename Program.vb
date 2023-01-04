Imports System
Module Program
    Dim countryabbrev, input As String 'Declaring input and abbreviation text
    Dim countryname() As String 'Declaring the array as dynamic
    Dim found As Boolean 'Dim found to return result positive or negative
    Sub Main()
        ReDim countryname(30) 'Populating array statically

        countryname(0) = "England"
        countryname(1) = "Wales"
        countryname(2) = "Scotland"
        countryname(3) = "Northern Ireland"
        countryname(4) = "Ireland"
        countryname(5) = "France"
        countryname(6) = "Germany"
        countryname(7) = "Luxembourg"
        countryname(8) = "Italy"
        countryname(9) = "Denmark"
        countryname(10) = "Finland"
        countryname(11) = "Poland"
        countryname(12) = "Sweden"
        countryname(13) = "Spain"
        countryname(14) = "Netherlands"
        countryname(15) = "Romania"
        countryname(16) = "Portugal"
        countryname(17) = "Belgium"
        countryname(18) = "Bulgaria"
        countryname(19) = "Austria"
        countryname(20) = "Greece"
        countryname(21) = "Hungary"
        countryname(22) = "Czechia" '
        countryname(23) = "Croatia"
        countryname(24) = "Lithuania"
        countryname(25) = "Cyprus"
        countryname(26) = "Malta"
        countryname(27) = "Slovenia"
        countryname(28) = "Estonia"
        countryname(29) = "Slovakia"
        countryname(30) = "Latvia"

        Do
            Console.WriteLine("Please enter the name of the European country you are from")
            input = Console.ReadLine() 'User entry for country name

            For count As Integer = 0 To 30 'check entry against arrays
                If UCase(countryname(count)) = UCase(input) Then 'Compare both as uppercase
                    found = True
                    Console.WriteLine("Valid country")
                    Exit For
                End If
            Next
            If found = True Then
                Select Case input 'Case select to display abbreviation
                    Case "England"
                        countryabbrev = "GB, EN"
                    Case "Scotland"
                        countryabbrev = "GB, SC"
                    Case "Wales"
                        countryabbrev = "GB, WS"
                    Case "Northern Ireland"
                        countryabbrev = "GB, NI"
                    Case "Ireland"
                        countryabbrev = "IE"
                    Case "France"
                        countryabbrev = "FR"
                    Case "Germany"
                        countryabbrev = "DE"
                    Case "Luxembourg"
                        countryabbrev = "LU"
                    Case "Italy"
                        countryabbrev = "IT"
                    Case "Denmark"
                        countryabbrev = "DK"
                    Case "Finland"
                        countryabbrev = "FI"
                    Case "Poland"
                        countryabbrev = "PL"
                    Case "Sweden"
                        countryabbrev = "SE"
                    Case "Spain"
                        countryabbrev = "ES"
                    Case "Netherlands"
                        countryabbrev = "NL"
                    Case "Romania"
                        countryabbrev = "RO"
                    Case "Portugal"
                        countryabbrev = "PT"
                    Case "Belgium"
                        countryabbrev = "BE"
                    Case "Bulgaria"
                        countryabbrev = "BG"
                    Case "Austria"
                        countryabbrev = "AT"
                    Case "Greece"
                        countryabbrev = "GR"
                    Case "Hungary"
                        countryabbrev = "HU"
                    Case "Czechia"
                        countryabbrev = "CZ"
                    Case "Crotatia"
                        countryabbrev = "HR"
                    Case "Lithuania"
                        countryabbrev = "LT"
                    Case "Cyprus"
                        countryabbrev = "CY"
                    Case "Malta"
                        countryabbrev = "MT"
                    Case "Slovenia"
                        countryabbrev = "SL"
                    Case "Estonia"
                        countryabbrev = "EE"
                    Case "Slovakia"
                        countryabbrev = "SK"
                    Case "Latvia"
                        countryabbrev = "LV"
                    Case Else
                        Console.WriteLine("Invalid entry")
                End Select
            End If
            Console.WriteLine("The abbreviation for " & input & " is " & countryabbrev) 'Using variables to create a cleaner case and display
        Loop
    End Sub
    'John Calverley
End Module
