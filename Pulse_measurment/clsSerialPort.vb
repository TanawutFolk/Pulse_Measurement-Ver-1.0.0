Option Strict Off
Option Explicit On

Public Class clsSerialPort
    '******************************************************************
    'ﾓｼﾞｭｰﾙ名     :clsSerialPort 
    '             :ｼﾘｱﾙ通信ｸﾗｽ 
    '開発日       :2011/09
    '             :SANYU INDUSTRY CO.,LTD.   T.Nakamura
    '******************************************************************
    Private WithEvents mSerialPort As New System.IO.Ports.SerialPort
    Private mLocalMode As Boolean                     'ﾛｰｶﾙﾓｰﾄﾞ(False:装置稼動/True:ｱﾌﾟﾘ単体)
    Private mSerialPort_InitOK As Boolean = False     '
    Private mstrDelimiter As String                   '
    Public Event ReceiveEvent()

    ''' <summary>
    ''' ｼﾘｱﾙﾎﾟｰﾄ OPEN
    ''' </summary>
    ''' <param name="intPortNum">ﾎﾟｰﾄ番号</param>
    ''' <param name="strDelimiter">ﾃﾞﾘﾐﾀ</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Friend Function PORT_Open(ByVal intPortNum As Integer, ByVal strDelimiter As String) As Boolean

        PORT_Open = True

        '------------------------------------------------------------------
        'ﾎﾟｰﾄOPEN
        Try
            If mLocalMode Then Exit Try

            mSerialPort.PortName = "COM" & intPortNum
            If mSerialPort.IsOpen = False Then
                mSerialPort.Open()
                If strDelimiter <> "" Then mSerialPort.NewLine = strDelimiter
                mstrDelimiter = strDelimiter
                mSerialPort_InitOK = True
                mSerialPort.DiscardInBuffer()                   '受信ﾊﾞｯﾌｧｸﾘｱ
                mSerialPort.DiscardOutBuffer()                  '送信ﾊﾞｯﾌｧｸﾘｱ
            End If

        Catch ex As Exception
            PORT_Open = False
            Call gSysLog.LogOut("PORT_Open," & ex.Message)
        Finally

        End Try

    End Function

    ''' <summary>
    ''' ｼﾘｱﾙﾎﾟｰﾄ CLOSE
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Friend Function PORT_Close() As Boolean

        PORT_Close = True

        '------------------------------------------------------------------
        'ﾎﾟｰﾄCLOSE
        Try
            If mLocalMode Then Exit Try

            mSerialPort_InitOK = False
            mSerialPort.Close()

        Catch ex As Exception
            PORT_Close = False
            Call gSysLog.LogOut("PORT_Close," & ex.Message)
        Finally

        End Try

    End Function

    ''' <summary>
    ''' ｼﾘｱﾙﾎﾟｰﾄ 設定
    ''' </summary>
    ''' <param name="blnDebug">ｱﾌﾟﾘ単体動作ﾓｰﾄﾞ True:ﾛｰｶﾙ(装置起動しない) False:通常</param>
    ''' <param name="intBaudRate">ﾎﾞｰﾚｰﾄ</param>
    ''' <param name="intDataBits">ﾃﾞｰﾀﾋﾞｯﾄ 5～8 </param>
    ''' <param name="intParity">ﾊﾟﾘﾃｨ0～4</param>
    ''' <param name="intStopBits">ｽﾄｯﾌﾟﾋﾞｯﾄ 0～3</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Friend Function PORT_SetUp(ByVal blnDebug As Boolean,
                               ByVal intBaudRate As Integer, ByVal intDataBits As Integer,
                               ByVal intParity As System.IO.Ports.Parity, ByVal intStopBits As System.IO.Ports.StopBits) As Boolean

        '------------------------------------------------------------------
        '初期処理
        PORT_SetUp = True
        mLocalMode = blnDebug

        '------------------------------------------------------------------
        '通信設定
        Try

            With (mSerialPort)
                .BaudRate = intBaudRate
                .DataBits = intDataBits
                .Parity = intParity
                .StopBits = intStopBits
            End With

        Catch ex As Exception
            PORT_SetUp = False
            Call gSysLog.LogOut("PORT_SetUp," & ex.Message)
        Finally

        End Try

    End Function

    ''' <summary>
    ''' ｼﾘｱﾙﾎﾟｰﾄ ﾃﾞｰﾀ送信
    ''' </summary>
    ''' <param name="strDATA">送信ﾃﾞｰﾀ</param>
    ''' <param name="intTimeOutMS">ﾀｲﾑｱｳﾄMS</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Friend Function SendData(ByVal strDATA As String, Optional ByVal intTimeOutMS As Integer = -1) As Boolean

        SendData = True

        '------------------------------------------------------------------
        'ﾃﾞｰﾀ送信
        Try
            If mSerialPort_InitOK = False Then Exit Try
            If mLocalMode Then Exit Try

            mSerialPort.WriteTimeout = intTimeOutMS        '送信ﾀｲﾑｱｳﾄ設定
            If mstrDelimiter <> "" Then
                mSerialPort.WriteLine(strDATA)             'ﾃﾞｰﾀ送信
            Else
                mSerialPort.Write(strDATA)
            End If

        Catch ex As Exception
            SendData = False
            Call gSysLog.LogOut("SendData," & ex.Message)
        Finally

        End Try

    End Function

    ''' <summary>
    ''' ﾃﾞｰﾀ受信ｲﾍﾞﾝﾄ(親ｸﾗｽで"ReceiveEvent"を起こす)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PORT_ReceiveEvent(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles mSerialPort.DataReceived
        RaiseEvent ReceiveEvent()
    End Sub

    ''' <summary>
    ''' ｼﾘｱﾙﾎﾟｰﾄ ﾃﾞｰﾀ受信
    ''' </summary>
    ''' <param name="strDATA">受信ﾃﾞｰﾀ</param>
    ''' <param name="intTimeOutMS">ﾀｲﾑｱｳﾄMS</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Friend Function ReceiveData(ByRef strDATA As String, ByVal intTimeOutMS As Integer) As Boolean

        Dim strTmp As String = ""
        Dim intReadByt As Integer
        Dim bytData() As Byte

        ReceiveData = False

        '------------------------------------------------------------------
        'ﾃﾞｰﾀ受信
        Try
            If mSerialPort_InitOK = False Then Exit Try
            If mLocalMode Then Exit Try

            mSerialPort.ReadTimeout = intTimeOutMS              '受信ﾀｲﾑｱｳﾄ設定
            If mstrDelimiter <> "" Then
                strTmp = mSerialPort.ReadLine()                 'ﾃﾞｰﾀ受信
                ReceiveData = True
            Else
                intReadByt = mSerialPort.BytesToRead
                ReDim bytData(0 To intReadByt)
                mSerialPort.Read(bytData, 0, intReadByt)
                strTmp = System.Text.Encoding.GetEncoding("Shift_JIS").GetString(bytData)
            End If
            strDATA = strTmp
            ReceiveData = True
        Catch ex As Exception
            ReceiveData = False
            Call gSysLog.LogOut("ReceiveData," & ex.Message)
        Finally

        End Try

    End Function

End Class
