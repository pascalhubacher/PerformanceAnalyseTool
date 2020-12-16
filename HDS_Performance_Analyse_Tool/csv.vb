Public Class csv
    Public Shared Function csv_get_position_contains_value(ByVal inputstring As String, ByVal value As String, ByVal separator As Char, Optional ByVal int_starting_at_1 As Integer = 1) As Integer
        '******************************************************
        'description:
        'in a separated string this function gets the first occuring position of the value 

        'input:
        'inputstring -> string to search
        'value -> string value you want to search for
        'separator -> char that is used to separate the inputstring

        'output:
        'integer value of the position in inputstring where ths value was first found (starting with element 1)
        'or you set the optional variable int_starting_at_1 to 0 then it starts with 0
        'output is -1 when it can't find the string

        'example:
        'bsp: inputstring -> "1,www,2,eee,rrrr" -> "eee" => 4
        '******************************************************

        csv_get_position_contains_value = -1

        Dim array_str As String() = Nothing
        Dim int_temp_position As Integer = Nothing
        Dim int_position As Integer = Nothing

        'fills all values of a line in an array
        array_str = inputstring.Split(separator)

        int_temp_position = 1
        int_position = 0

        'get the position of the value
        For Each str_line As String In array_str
            If InStr(str_line, value) <> 0 Then
                int_position = int_temp_position
            End If
            int_temp_position = int_temp_position + 1
        Next

        'return value
        If int_starting_at_1 = 0 Then
            csv_get_position_contains_value = int_position - 1
        Else
            csv_get_position_contains_value = int_position
        End If

    End Function

    Public Shared Function csv_remove_position(ByVal inputstring As String, ByVal position As Integer, ByVal separator As Char) As String
        '******************************************************
        'description:
        'in a separated string this function removes the position in the inputstring

        'input:
        'inputstring -> string to search
        'position -> integer position (starting counting with 1) you want to remove from the inputstring
        'separator -> char that is used to separate the inputstring

        'output:
        'inputstring with the position removed

        'example:
        'bsp: inputstring -> "1,www,2,eee,rrrr" -> 4 => "1,www,2,rrrr"
        '******************************************************

        csv_remove_position = "-1"
        Dim int_counter As Integer = 0
        Dim tempstring As String = ""

        If Split(inputstring, separator).Length >= position Then
            For Each element As String In Split(inputstring, separator)

                If position <> int_counter Then
                    tempstring = tempstring & separator & element
                End If

                int_counter = int_counter + 1
            Next

            csv_remove_position = tempstring

            tempstring = Nothing
            int_counter = Nothing
        End If

    End Function

    Public Shared Function csv_add_at_the_end(ByVal inputstring As String, ByVal new_value As String, ByVal separator As Char) As String
        '******************************************************
        'description:
        'in a separated string this function add a new value at the end of the inputstring

        'input:
        'inputstring -> string to search
        'new_value -> string value you want to add at the end of the inputstring
        'separator -> char that is used to separate the inputstring

        'output:
        'inputstring with the new_value added

        'example:
        'bsp: inputstring -> "1,www,2,eee,rrrr" -> "abc" => "1,www,2,eee,rrrr,abc"
        '******************************************************

        Dim tempstring As String = Nothing

        tempstring = inputstring & separator & new_value

        csv_add_at_the_end = tempstring
    End Function

    Public Shared Function csv_get_position(ByVal inputstring As String, ByVal value As String, ByVal separator As Char, Optional ByVal int_starting_at_1 As Integer = 1) As Integer
        '******************************************************
        'description:
        'in a separated string this function gets the first occuring position of the value 

        'input:
        'inputstring -> string to search
        'value -> string value you want to search for
        'separator -> char that is used to separate the inputstring

        'output:
        'integer value of the position in inputstring where ths value was first found (starting with element 1)
        'or you set the optional variable int_starting_at_1 to 0 then it starts with 0
        'output is -1 when it can't find the string

        'example:
        'bsp: inputstring -> "1,www,2,eee,rrrr" -> "eee" => 4
        '******************************************************

        csv_get_position = -1

        Dim array_str As String() = Nothing
        Dim int_temp_position As Integer = Nothing
        Dim int_position As Integer = Nothing

        'fills all values of a line in an array
        array_str = inputstring.Split(separator)

        int_temp_position = 1
        int_position = 0

        'get the position of the value
        For Each str_line As String In array_str
            If str_line = value Then
                int_position = int_temp_position
            End If
            int_temp_position = int_temp_position + 1
        Next

        'return value
        If int_starting_at_1 = 0 Then
            csv_get_position = int_position - 1
        Else
            csv_get_position = int_position
        End If

    End Function

    Public Shared Function csv_average_start_end_position(ByVal inputstring As String, ByVal separator As Char, Optional ByVal start_position As Integer = 1, Optional ByVal end_position As Integer = -1) As String
        '******************************************************
        'description:
        'in a separated string this function calculates the average from the start_position to the end_position

        'input:
        'inputstring -> string to search
        'separator -> char that is used to separate the inputstring
        'optional start_position -> integer position (starting counting with 1) you want to begin -> if not specified 1 is taken
        'optional end_position -> integer position (starting counting with 1) you want to end -> if not specified -1 is taken

        'output:
        'inputstring with the average calculated from start_position to the end_position. all values that calculate the average 
        'are replaced by the average value

        'example:
        'bsp: inputstring -> "test,1,2,4,5" -> 3,5 => "test,1,2,3.6666"
        '******************************************************

        Dim str_temp1 As String = ""
        Dim int_temp_average_sum As Integer = 0
        Dim int_temp_average_counter As Integer = 0
        Dim int_counter As Integer = 0
        Dim int_array As Array = Split(inputstring, separator)

        'initial setting
        csv_average_start_end_position = "-1"

        If end_position = -1 Then
            'set the end position to the number of elements
            end_position = int_array.Length
        End If

        'end_position must not be bigger than the elements number in the string
        If Not end_position > int_array.Length Then

            If Not start_position >= end_position Then

                int_counter = 1
                For Each str_element As String In int_array

                    If int_counter >= start_position And int_counter < end_position Then

                        'ignore 0 values
                        If Not str_element = "0" Then
                            int_temp_average_sum = int_temp_average_sum + CInt(str_element)
                            int_temp_average_counter = int_temp_average_counter + 1
                        End If

                    Else
                        If int_counter = end_position Then
                            'ignore 0 values
                            If Not str_element = "0" Then
                                int_temp_average_sum = int_temp_average_sum + CInt(str_element)
                                int_temp_average_counter = int_temp_average_counter + 1
                            End If

                            '
                            If int_temp_average_sum > 0 Then
                                ' int_temp_average_sum > 0
                                str_temp1 = str_temp1 & separator & CStr(int_temp_average_sum / int_temp_average_counter)
                            Else
                                'if int_temp_average_sum smaller than 1 then the average is zero
                                str_temp1 = str_temp1 & separator & "0"
                            End If

                        Else
                            If str_temp1 = "" Then
                                str_temp1 = str_element
                            Else
                                str_temp1 = str_temp1 & separator & str_element
                            End If

                        End If
                    End If

                    int_counter = int_counter + 1

                Next

                csv_average_start_end_position = str_temp1

                int_counter = Nothing
                str_temp1 = Nothing
                int_temp_average_sum = Nothing
                int_temp_average_counter = Nothing
                int_array = Nothing

            Else
                ' the start_position is same or bigger than the end_position. this is not allowed
                csv_average_start_end_position = "-1"
            End If

        Else
            'end_position is bigger than the number of elements
            csv_average_start_end_position = "-1"

        End If

        int_array = Nothing
        int_counter = Nothing

    End Function
    Public Shared Function csv_extract(ByVal inputstring As String, ByVal position As Integer, ByVal separator As Char) As String
        '******************************************************
        'description:
        'gives you specifies the comma value of a csv string

        'input:
        'inputstring -> string to search
        'position -> integer position of the value you want to extract
        'separator -> char that is used to separate the inputstring

        'output:
        'string value of the position requested in 'position'(starting with element 1)
        ' or "-1" if there is an error in the call

        'example:
        'bsp: inputstring -> "1,www,2,eee,rrrr" -> 2 => "www"
        '******************************************************

        'Dim tempstring As String = Nothing

        'Dim i As Integer = 1
        'While i <= position
        '    If inputstring.IndexOf(separator) <> -1 Then
        '        tempstring = inputstring.Substring(0, inputstring.IndexOf(separator))
        '        inputstring = inputstring.Substring(inputstring.IndexOf(separator) + 1, inputstring.Length - (inputstring.IndexOf(separator) + 1))
        '    Else
        '        tempstring = inputstring
        '    End If
        '    i = i + 1
        'End While

        If inputstring.Contains(separator) Then

            'do to performance saving i do not check if the position is bigger than the amount of elements

            'If Split(inputstring, separator).Length >= position Then
            csv_extract = Split(inputstring, separator)(position - 1)
            'Else
            '   csv_extract = Split(inputstring, separator)(0)
            'End If

        Else
            If position = 1 Then
                csv_extract = inputstring
            Else
                csv_extract = "-1"
            End If
        End If

    End Function

    Public Shared Function csv_length(ByVal inputstring As String, ByVal separator As Char) As Integer
        '******************************************************
        'description:
        'gives you the amount of elements back in the inputstring

        'input:
        'inputstring -> string to search
        'separator -> char that is used to separate the inputstring

        'output:
        'integer value of the amaunt of elements in 'inputstring'(starting with element 1)

        'example:
        'bsp: inputstring -> "1,www,2,eee,rrrr" => 5
        '******************************************************


        Dim array_str As String() = Nothing
        Dim counter As Integer = 0

        If Not inputstring = "" Then
            'not empty string

            'fills all values of a line in an array
            array_str = inputstring.Split(separator)

            For Each str_line As String In array_str
                counter = counter + 1
            Next
        Else
            'empty string
            counter = 0
        End If

        csv_length = counter

    End Function

    Public Shared Function csv_replace(ByVal inputstring As String, ByVal new_value As String, ByVal position As Integer, ByVal separator As Char) As String
        '******************************************************
        'description:
        'in a separated string this function replaces one value

        'input:
        'inputstring -> string to search
        'new_value -> string value you want to replace the existing value
        'separator -> char that is used to separate the inputstring

        'output:
        'inputstring with the new_value

        'example:
        'bsp: inputstring -> "1,www,2,eee,rrrr" -> "abc",3 => "1,www,abc,eee,rrrr"
        '******************************************************

        Dim array_str As String() = Nothing
        Dim tempstring As String = Nothing

        'fills all values of a line in an array
        array_str = inputstring.Split(separator)
        'replace the value
        array_str(position - 1) = new_value

        'rebuild the string back
        For Each str_line As String In array_str
            'first line
            If tempstring = Nothing Then
                tempstring = str_line
            Else
                tempstring = tempstring & "," & str_line
            End If

        Next

        csv_replace = tempstring
    End Function

End Class
