Option Explicit On
Option Strict On

Imports HDS_Performance_Analyse_Tool.Form_Performance_Analyse_Tool_Main

Public Class logs

    Public Shared Sub logwriter(ByVal str_severity As String, ByVal str_text As String, Optional ByVal bool_show_information_message_enforce As Boolean = False)
        Const str_logwriter_severity_information As String = "### Information ### "
        Const str_logwriter_severity_warning As String = "### Warning     ### "
        Const str_logwriter_severity_error As String = "### Error       ### "
        Const str_logwriter_severity_debug As String = "!!! Debug       !!! "

        Const str_type_of_information_messagebox As String = "msgbox"
        Const str_type_of_information_console As String = "console"

        'set type of output
        Const str_type_of_output As String = str_type_of_information_console

        Select Case str_type_of_output
            Case str_type_of_information_messagebox
                Select Case str_severity
                    Case str_severity_information
                        If bool_show_information_message_enforce Then
                            MsgBox(str_text, MsgBoxStyle.Information, str_logwriter_severity_information)
                        End If

                    Case str_severity_warning
                        MsgBox(str_text, MsgBoxStyle.Exclamation, str_logwriter_severity_warning)

                    Case str_severity_error
                        MsgBox(str_text, MsgBoxStyle.Exclamation, str_logwriter_severity_error)

                    Case str_severity_debug
                        MsgBox(str_text, MsgBoxStyle.MsgBoxHelp, str_logwriter_severity_debug)

                End Select
            Case str_type_of_information_console
                Select Case str_severity
                    Case str_severity_information
                        If bool_show_information_message_enforce Then
                            Console.WriteLine(Date.Now & " " & str_logwriter_severity_information & str_text)
                        End If

                    Case str_severity_warning
                        Console.WriteLine(Date.Now & " " & str_logwriter_severity_warning & str_text)

                    Case str_severity_error
                        Console.WriteLine(Date.Now & " " & str_logwriter_severity_error & str_text)

                    Case str_severity_debug
                        Console.WriteLine(Date.Now & " " & str_logwriter_severity_debug & str_text)

                End Select

        End Select






    End Sub

End Class
