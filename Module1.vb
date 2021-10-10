Module Module1

    Dim code_c() As String = {"C1", "C2", "C3", "C4", "C5"}
    Dim price_c() As Decimal = {1.5, 3.0, 4.5, 6.0, 8.0}

    Dim code_m() As String = {"M1", "M2", "M3", "M4", "M5"}
    Dim price_m() As Decimal = {5.75, 12.5, 22.5, 34.5, 45.0}

    Dim code_f() As String = {"F1", "F2", "F3", "F4", "F5"}
    Dim price_f() As Decimal = {1.5, 3.0, 4.5, 6.0, 8.0}

    Dim passenger_account_number(0) As String
    Dim passenger_account_name(0) As String
    Dim booking_info(0) As String
    Dim index As Integer = 0
    Dim index1 As Integer = 0


    Sub Main()

        'task 1 : 

        Dim passenger_account_reg_number As String
        Dim passenger_account_reg_name As String
        Dim authentication_reg As Boolean = False
        Dim loop_reg As String

        Do

            Do

                Console.WriteLine("Enter account number to open a new account")
                passenger_account_reg_number = Console.ReadLine()

                authentication_reg = authentication_function(passenger_account_reg_number, passenger_account_number)
                If authentication_reg = False Then
                    Console.WriteLine("Account number already exists...")
                End If

            Loop Until authentication_reg = True

            passenger_account_number(index) = passenger_account_reg_number

            Console.WriteLine("Input the passenger account name")
            passenger_account_reg_name = Console.ReadLine()
            passenger_account_name(index) = passenger_account_reg_name





            Console.WriteLine("To input other passenger information press any key, to start booking type 'continue'")
            loop_reg = Console.ReadLine()




            If loop_reg <> "continue" Then
                index += 1
                ReDim Preserve passenger_account_number(index)

                ReDim Preserve passenger_account_name(index)

            End If





        Loop While loop_reg <> "continue"
        'end of task 1

        'task 2

        Dim start_time As Integer
        Dim home_start_station As String
        Dim start_end_station As String
        Dim end_destionation_station As String
        Dim passenger_book_account_number As String
        Dim cost_c, cost_m, cost_f, total As Decimal
        Dim authentication_book As Boolean = False
        Dim booking_number As String
        Dim confirmation As Char
        Dim booking_info_holder As String

        For count = 0 To index

            Do
                Do

                    Console.WriteLine("Input the account number to start booking ")
                    passenger_book_account_number = Console.ReadLine()

                    authentication_book = authentication_function(passenger_book_account_number, passenger_account_number)
                    If (authentication_book = True) Then
                        Console.WriteLine("The account number does not exist")
                    End If

                Loop While authentication_book = True 'this

                Do

                    Console.WriteLine("Input the start time for the journey {0~23}")
                    start_time = Console.ReadLine()

                    If start_time < 0 Or start_time > 23 Then
                        Console.WriteLine("Start time should be between {0~23}")
                    End If

                Loop Until start_time >= 0 And start_time <= 23

                Do

                    Console.WriteLine("Input the code for the home to start station")
                    Console.WriteLine("     C1     |     1.50")
                    Console.WriteLine("     C2     |     3.0")
                    Console.WriteLine("     C3     |     4.5")
                    Console.WriteLine("     C4     |     6.0")
                    Console.WriteLine("     C5     |     8.0")

                    home_start_station = Console.ReadLine()

                    If home_start_station <> "C1" And home_start_station = "C2" And home_start_station = "C3" And home_start_station = "C4" And home_start_station = "C5" Then
                        Console.WriteLine("Code invalid")
                    End If

                Loop Until home_start_station = "C1" Or home_start_station = "C2" Or home_start_station = "C3" Or home_start_station = "C4" Or home_start_station = "C5"

                Do

                    Console.WriteLine("Input the code for the start station to end station")
                    Console.WriteLine("     M1     |     5.75")
                    Console.WriteLine("     M2     |     12.5")
                    Console.WriteLine("     M3     |     22.25")
                    Console.WriteLine("     M4     |     34.5")
                    Console.WriteLine("     M5     |     45.0")

                    start_end_station = Console.ReadLine()

                    If start_end_station <> "M1" And start_end_station = "M2" And start_end_station = "M3" And start_end_station = "M4" And start_end_station = "M5" Then
                        Console.WriteLine("Code invalid")
                    End If

                Loop Until start_end_station = "M1" Or start_end_station = "M2" Or start_end_station = "M3" Or start_end_station = "M4" Or start_end_station = "M5"

                Do

                    Console.WriteLine("Input the code for the end station to final destination")
                    Console.WriteLine("     F1     |     1.50")
                    Console.WriteLine("     F2     |     3.0")
                    Console.WriteLine("     F3     |     4.5")
                    Console.WriteLine("     F4     |     6.0")
                    Console.WriteLine("     F5     |     8.0")

                    end_destionation_station = Console.ReadLine()

                    If end_destionation_station <> "F1" And end_destionation_station = "F2" And end_destionation_station = "F3" And end_destionation_station = "F4" And end_destionation_station = "F5" Then
                        Console.WriteLine("Code invalid")
                    End If

                Loop Until end_destionation_station = "F1" Or end_destionation_station = "F2" Or end_destionation_station = "F3" Or end_destionation_station = "F4" Or end_destionation_station = "F5"

                cost_c = price_c(Array.IndexOf(code_c, home_start_station))
                cost_m = price_m(Array.IndexOf(code_m, start_end_station))
                cost_f = price_f(Array.IndexOf(code_f, end_destionation_station))
                total = cost_c + cost_m + cost_f

                booking_number = Now()

                'booking info (index1) was here, should be outside loop so it doesn't store unless confirmation = y 
                booking_info_holder = "The passenger account number is: " & passenger_book_account_number & vbNewLine & "The passenger name is : " & passenger_account_name(Array.IndexOf(passenger_account_number, passenger_book_account_number)) & vbNewLine & "The codes for the stations are : " & home_start_station & " " & start_end_station & " " & end_destionation_station


                'end of task 2 

                'task 3

                Dim discount As Decimal
                Dim final_total As Decimal
                Dim x As Integer = 0

                If start_time > 10 Then
                    discount = total * 0.4

                Else
                    discount = 0

                End If

                final_total = total - discount


                Console.WriteLine(booking_info_holder & vbNewLine & "Your discount is : " & discount & ", The final total is : " & final_total & " || " & booking_number)
                Console.WriteLine(vbNewLine & "If all the information is correct input y otherwise press any key to reinput information")
                confirmation = Console.ReadLine()


                booking_info(index1) = booking_info_holder & vbNewLine & "Your discount is : " & discount & ", The final total is : " & final_total & " || " & booking_number

            Loop Until confirmation = "y"


            index1 += 1
            ReDim Preserve booking_info(index1)


        Next count

        Console.WriteLine(vbNewLine & "Here is the information for all of the accounts:" & vbNewLine)

        For x = 0 To index1
            Console.WriteLine(vbNewLine & booking_info(x))
        Next x
        Console.ReadLine()

    End Sub

    'authentication function for duplicate account number while registering

    Function authentication_function(ByVal passenger_account_reg_number As String, ByVal passenger_account_number() As String)

        For k = 0 To index
            If (passenger_account_number(k) = passenger_account_reg_number) Then
                Return False
            End If
        Next k
        Return True



    End Function

End Module
