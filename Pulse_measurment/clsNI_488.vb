'Option Strict Off
'Option Explicit On

'Imports NationalInstruments.NI4882

'Public Class clsNI_488
'    '******************************************************************
'    'ﾓｼﾞｭｰﾙ名     :clsNI_488
'    '             :National Instruments NI-488.2 GPIB制御ｸﾗｽ
'    '開発日       :2012/03
'    '             :SANYU INDUSTRY CO.,LTD.   T.Nakamura
'    '******************************************************************
'    Private mLocalMode As Boolean                     'ﾛｰｶﾙﾓｰﾄﾞ(False:装置稼動/True:ｱﾌﾟﾘ単体)
'    Private mGpibDevice As Device
'    Private mstrDelimiter As String                   '

'    ''' <summary>
'    ''' NI-488.2 GPIB初期処理
'    ''' </summary>
'    ''' <param name="intBoardNo">ﾎﾞｰﾄﾞ番号</param>
'    ''' <param name="intAddress">GPIBｱﾄﾞﾚｽ</param>
'    ''' <param name="strDelimiter">ﾃﾞﾘﾐﾀ</param>
'    ''' <param name="blnDebug">ｱﾌﾟﾘ単体動作ﾓｰﾄﾞ True:ﾛｰｶﾙ(装置起動しない) False:通常</param>
'    ''' <returns>Boolean</returns>
'    ''' <remarks></remarks>
'    Friend Function GPIB_Init(ByVal intBoardNo As Integer, ByVal intAddress As Integer,
'                              ByVal strDelimiter As String, ByVal blnDebug As Boolean) As Boolean

'        '------------------------------------------------------------------
'        '初期処理
'        GPIB_Init = True
'        mLocalMode = blnDebug
'        mstrDelimiter = strDelimiter

'        Try
'            If mLocalMode Then Exit Try

'            '------------------------------------------------------------------
'            'ﾎﾞｰﾄﾞ初期化
'            mGpibDevice = New Device(intBoardNo, intAddress, 0)
'        Catch ex As System.Exception
'            GPIB_Init = False
'            Call gSysLog.LogOut("GPIB_Init," & ex.Message)
'        Finally

'        End Try

'    End Function

'    ''' <summary>
'    ''' NI-488.2 GPIB終了処理
'    ''' </summary>
'    ''' <returns>Boolean</returns>
'    ''' <remarks></remarks>
'    Friend Function GPIB_Quit() As Boolean

'        '------------------------------------------------------------------
'        '終了処理
'        GPIB_Quit = True

'        Try
'            If mLocalMode Then Exit Try

'            If IsNothing(mGpibDevice) = False Then mGpibDevice.Dispose()
'        Catch ex As System.Exception
'            GPIB_Quit = False
'            Call gSysLog.LogOut("GPIB_Quit," & ex.Message)
'        Finally

'        End Try

'    End Function

'    ''' <summary>
'    ''' NI-488.2 送信
'    ''' </summary>
'    ''' <param name="strData">送信文字列</param>
'    ''' <returns>Boolean</returns>
'    ''' <remarks></remarks>
'    Friend Function GPIB_Send(ByVal strData As String) As Boolean

'        GPIB_Send = True

'        Try
'            If mLocalMode Then Exit Try

'            '------------------------------------------------------------------
'            'ﾃﾞｰﾀ送信
'            mGpibDevice.Write(strData & mstrDelimiter)

'        Catch ex As System.Exception
'            GPIB_Send = False
'            Call gSysLog.LogOut("GPIB_Send," & ex.Message)
'        Finally

'        End Try

'    End Function

'    ''' <summary>
'    ''' NI-488.2 受信
'    ''' </summary>
'    ''' <param name="strData">受信文字列</param>
'    ''' <returns>Boolean</returns>
'    ''' <remarks></remarks>
'    Friend Function GPIB_Receive(ByRef strData As String) As Boolean

'        Dim strBuffer As String = ""

'        GPIB_Receive = True
'        Try
'            If mLocalMode Then Exit Try

'            '------------------------------------------------------------------
'            'ﾃﾞｰﾀ受信
'            strData = mGpibDevice.ReadString()

'        Catch ex As System.Exception
'            GPIB_Receive = False
'            Call gSysLog.LogOut("GPIB_Receive," & ex.Message)
'        Finally

'        End Try
'    End Function
'End Class
