Imports System.IO

''' <summary>
''' System Log Class - ???????????? Log ???????
''' </summary>
Public Class clsSysLog

    Private mLogPath As String

    Public Sub New()
        ' ????? Path ?????????? Log
        mLogPath = Path.Combine(Application.StartupPath, "Logs")
        If Not Directory.Exists(mLogPath) Then
            Directory.CreateDirectory(mLogPath)
        End If
    End Sub

    ''' <summary>
    ''' ?????? Log ??????
    ''' </summary>
    ''' <param name="strMessage">???????????????????????</param>
    Public Sub LogOut(ByVal strMessage As String)
        Try
            Dim strFileName As String = "Log_" & DateTime.Now.ToString("yyyyMMdd") & ".txt"
            Dim strFullPath As String = Path.Combine(mLogPath, strFileName)

            Dim strLogLine As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & " - " & strMessage

            ' ????????????????
            Using sw As New StreamWriter(strFullPath, True)
                sw.WriteLine(strLogLine)
            End Using

            ' ?????? Debug Output ????
            Debug.WriteLine(strLogLine)

        Catch ex As Exception
            Debug.WriteLine("LogOut Error: " & ex.Message)
        End Try
    End Sub

End Class
