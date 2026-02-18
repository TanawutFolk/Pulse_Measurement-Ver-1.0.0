'Option Strict Off
'Option Explicit On
'Public Class clsCalMeter
'    Private mLocalMode As Boolean
'    Private mSerialObj As New clsSerialPort
'    Private mInitOk As Boolean = False
'    Public objName(1) As String
'    Private MoveMode(1) As String
'    Private MovePara(1) As Integer
'    Private pulseTolerance As Integer
'    Public COMPORT As Integer


'    Friend Function CalMeter_Init1(ByVal intPort As Integer, ByVal intBaud As Integer, ByVal blnDebug As Boolean) As Boolean

'        Dim strRet As String = ""
'        '------------------------------------------------------------------
'        '初期処理
'        CalMeter_Init1 = True
'        mLocalMode = blnDebug

'        Try
'            If mLocalMode Then Exit Try
'            Dim i As Integer
'            For i = 1 To 2
'                '------------------------------------------------------------------
'                '通信設定
'                Debug.Print(intBaud)
'                If mSerialObj.PORT_SetUp(mLocalMode, intBaud, 8, System.IO.Ports.Parity.None, 1) = False Then
'                    gSysLog.LogOut("CalMeter_Init," & "PORT_INIT_PORTSETUP,Port " & intPort & ",FAIL,Try:" & i)
'                    GoTo RESET
'                End If
'                Call System.Threading.Thread.Sleep(50)
'                If mSerialObj.PORT_Open(intPort, vbCrLf) = False Then
'                    mSerialObj.PORT_Close()
'                    gSysLog.LogOut("CalMeter_Init," & "PORT_INIT_PORTOPEN,Port " & intPort & ",FAIL,Try:" & i)
'                    GoTo RESET
'                End If
'                Call System.Threading.Thread.Sleep(50)
'                GoTo DONE
'                '------------------------------------------------------------------
'                'ﾊﾞｰｼﾞｮﾝ確認  
'                'If mSerialObj.SendData("?:") = False Then
'                '    mSerialObj.PORT_Close()
'                '    gSysLog.LogOut("CalMeter_Init," & "PORT_INIT_SendData?:,Port " & intPort & ",FAIL,Try:" & i)
'                '    GoTo RESET
'                'End If

'                'Call System.Threading.Thread.Sleep(50)
'                'If mSerialObj.ReceiveData(strRet, 1000) = False Then
'                '    mSerialObj.PORT_Close()
'                '    gSysLog.LogOut("CalMeter_Init," & "PORT_INIT_ReceiveData,Port " & intPort & ",FAIL,Try:" & i)
'                '    GoTo RESET
'                'End If
'                'Call System.Threading.Thread.Sleep(150)
'                'GoTo DONE
'RESET:
'                'Call System.Threading.Thread.Sleep(50)
'            Next i
'            Throw New Exception("INITIALIZE FAIL,PORT " & intPort)
'DONE:
'            mInitOk = True
'            Return True
'        Catch ex As System.Exception
'            CalMeter_Init1 = False
'            Call mSerialObj.PORT_Close()
'            Call gSysLog.LogOut("CalMeter_Init," & ex.Message)
'        Finally
'            'objName(intDev) = strName
'            'MoveMode(intDev) = ""
'            'MovePara(intDev) = 0
'            'pulseTolerance = tolerance
'        End Try
'    End Function
'    Friend Function ReadAverageCal(ByVal intIndex As Integer, ByRef dblPf As Double, ByRef CalMeterNo As Integer) As Double

'        Dim strRet As String = ""

'        Dim vCF As Integer
'        Dim i As String
'        Dim n As Integer
'        Dim sum As Integer
'        Dim calP As Single
'        Dim CalV As Single
'        Dim r As String

'        Dim PmAverage As Integer

'        'ReadCalMeter = True

'        vCF = 1
'        PmAverage = 10
'        n = 0
'        sum = 0
'        Try
'            Do
'                'Call System.Threading.Thread.Sleep(1000)
'                'mSerialObj.SendData("$SP" & vbCr, 1000)
'                Select Case CalMeterNo
'                    Case 1
'                        frmMeas.comRS1.DiscardInBuffer()
'                        frmMeas.comRS1.WriteLine("$SP" & vbCr)
'                    Case 2
'                        frmMeas.comRS2.DiscardInBuffer()
'                        frmMeas.comRS2.WriteLine("$SP" & vbCr)
'                End Select

'                r = ""
'                i = 10
'                Do
'                    Dim recieve As String = ""
'                    Call System.Threading.Thread.Sleep(100)
'                    Select Case CalMeterNo
'                        Case 1
'                            recieve = frmMeas.comRS1.ReadExisting
'                        Case 2
'                            recieve = frmMeas.comRS2.ReadExisting
'                    End Select
'                    r = r + recieve
'                    If InStr(strRet, "*") Then Exit Do
'                    i = i - 1
'                Loop Until i < 0
'                If InStr(r, "*") > 0 Then
'                    r = Mid(r, InStr(r, "*") + 1)
'                    If IsNumeric(r) Then
'                        CalV = CSng(r)
'                        calP = 1000 * CalV / vCF
'                        n = n + 1
'                        sum = sum + calP
'                    End If
'                End If
'            Loop Until n >= PmAverage

'            calP = sum / PmAverage

'            dblPf = calP
'        Catch ex As System.Exception
'            'ReadCalMeter = False
'            Call gSysLog.LogOut("ReadCalMeter," & ex.Message)
'        Finally

'        End Try

'        Return dblPf

'    End Function
'    Friend Function CalMeter_Init(ByVal CalMeterNo As Integer, ByVal PortName As String) As Boolean
'        CalMeter_Init = False
'        Try
'            'frmMeas.comRS1.Close()
'            'frmMeas.comRS2.Close()


'            Select Case CalMeterNo
'                Case 1
'                    With frmMeas.comRS1
'                        '.PortName = "COM" & g_Machine.comPortCal1
'                        .PortName = "COM" & PortName
'                        .BaudRate = 9600
'                        .DataBits = 8
'                        .StopBits = IO.Ports.StopBits.One
'                        .Parity = IO.Ports.Parity.None
'                        .WriteTimeout = 1000
'                    End With

'                    frmMeas.comRS1.Open()
'                    frmMeas.comRS1.DiscardInBuffer()
'                    frmMeas.comRS1.DiscardOutBuffer()

'                    frmMeas.comRS1.DtrEnable = True
'                    frmMeas.comRS1.RtsEnable = True
'                Case 2
'                    With frmMeas.comRS2
'                        '.PortName = "COM" & g_Machine.comPortCal2
'                        .PortName = "COM" & PortName
'                        .BaudRate = 9600
'                        .DataBits = 8
'                        .StopBits = IO.Ports.StopBits.One
'                        .Parity = IO.Ports.Parity.None
'                        .WriteTimeout = 1000
'                    End With

'                    frmMeas.comRS2.Open()
'                    frmMeas.comRS2.DiscardInBuffer()
'                    frmMeas.comRS2.DiscardOutBuffer()

'                    frmMeas.comRS2.DtrEnable = True
'                    frmMeas.comRS2.RtsEnable = True
'            End Select
'            CalMeter_Init = True
'        Catch ex As System.Exception

'        Finally

'        End Try
'    End Function
'    Friend Function PORTCLOSE(ByVal CalMeterNo As Integer) As Boolean
'        PORTCLOSE = False
'        Try
'            If CalMeterNo = 1 Then
'                frmMeas.comRS1.Close()
'            Else
'                frmMeas.comRS2.Close()
'            End If

'            PORTCLOSE = True

'        Catch ex As Exception

'        End Try
'    End Function

'    Friend Function ReadSingleCal(ByVal intIndex As Integer, ByRef dblPf As Double, ByRef CalMeterNo As Integer) As Double

'        Dim strRet As String = ""

'        Dim vCF As Integer
'        Dim i As String
'        Dim n As Integer
'        Dim sum As Integer
'        Dim calP As Single
'        Dim CalV As Single
'        Dim r As String

'        Dim PmAverage As Integer

'        'ReadCalMeter = True

'        vCF = 1
'        PmAverage = 1
'        n = 0
'        sum = 0
'        Try
'            Do
'                'Call System.Threading.Thread.Sleep(1000)
'                'mSerialObj.SendData("$SP" & vbCr, 1000)
'                Select Case CalMeterNo
'                    Case 1
'                        frmMeas.comRS1.DiscardInBuffer()
'                        frmMeas.comRS1.WriteLine("$SP" & vbCr)
'                    Case 2
'                        frmMeas.comRS2.DiscardInBuffer()
'                        frmMeas.comRS2.WriteLine("$SP" & vbCr)
'                End Select

'                r = ""
'                i = 10
'                Do
'                    Dim recieve As String = ""
'                    Call System.Threading.Thread.Sleep(100)
'                    Select Case CalMeterNo
'                        Case 1
'                            recieve = frmMeas.comRS1.ReadExisting
'                        Case 2
'                            recieve = frmMeas.comRS2.ReadExisting
'                    End Select
'                    r = r + recieve
'                    If InStr(strRet, "*") Then Exit Do
'                    i = i - 1
'                Loop Until i < 0
'                If InStr(r, "*") > 0 Then
'                    r = Mid(r, InStr(r, "*") + 1)
'                    If IsNumeric(r) Then
'                        CalV = CSng(r)
'                        calP = 1000 * CalV / vCF
'                        n = n + 1
'                        sum = sum + calP
'                    End If
'                End If
'            Loop Until n >= PmAverage

'            calP = sum / PmAverage

'            dblPf = calP
'        Catch ex As System.Exception
'            'ReadCalMeter = False
'            Call gSysLog.LogOut("ReadCalMeter," & ex.Message)
'        Finally

'        End Try

'        Return dblPf

'    End Function
'End Class

