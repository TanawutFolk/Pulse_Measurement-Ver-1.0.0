Public Class clsILX_LDC37xx
    '******************************************************************
    'ﾓｼﾞｭｰﾙ名     :clsILX_LDC3744 
    '             :ILX LDC-3744 LDｺﾝﾄﾛｰﾗ制御ｸﾗｽ
    '開発日       :2012/03
    '             :SANYU INDUSTRY CO.,LTD.   T.Nakamura
    '******************************************************************
    Private mLocalMode As Boolean                     'ﾛｰｶﾙﾓｰﾄﾞ(False:装置稼動/True:ｱﾌﾟﾘ単体)
    Private mGPIB As New clsNI_488
    Public mGPIBNo As Integer
    Public mGPIBUnit As Integer

    ''' <summary>
    ''' ILX LDC-3744 LDｺﾝﾄﾛｰﾗ初期処理
    ''' </summary>
    ''' <param name="intUnit">GPIBﾎﾞｰﾄﾞ番号0～</param>
    ''' <param name="intPort">GPIBﾎﾟｰﾄ番号</param>
    ''' <param name="blnDebug">ｱﾌﾟﾘ単体動作ﾓｰﾄﾞ True:ﾛｰｶﾙ(装置起動しない) False:通常</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Friend Function LD_Init(ByVal intUnit As Integer, ByVal intPort As Integer, ByVal blnDebug As Boolean) As Boolean
        '------------------------------------------------------------------
        '初期処理
        LD_Init = True
        mLocalMode = blnDebug

        Try
            If mLocalMode Then Exit Try

            '------------------------------------------------------------------
            '通信設定
            If mGPIB.GPIB_Init(intUnit, intPort, vbLf, blnDebug) = False Then Throw New Exception("")

        Catch ex As System.Exception
            LD_Init = False
            Call mGPIB.GPIB_Quit()
            Call gSysLog.LogOut("ILXLD_Init," & ex.Message)
        Finally

        End Try

    End Function

    ''' <summary>
    ''' ILX LDC-3744 LDｺﾝﾄﾛｰﾗ終了処理
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Friend Function LD_Quit() As Boolean

        '------------------------------------------------------------------
        '終了処理
        LD_Quit = True

        Try
            If mLocalMode Then Exit Try
            Call LD_ONOFF(0)
            Call LD_TEC_ONOFF(0)
            Call mGPIB.GPIB_Quit()
        Catch ex As System.Exception
            LD_Quit = False
            Call gSysLog.LogOut("ILXLD_Quit," & ex.Message)
        Finally

        End Try

    End Function

    ''' <summary>
    ''' LD発光/消光処理
    ''' </summary>
    ''' <param name="intOnOff">0:Off 1:On</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Friend Function LD_ONOFF(ByVal intOnOff As Integer) As Boolean

        LD_ONOFF = True

        Try
            If mLocalMode Then Exit Try

            '------------------------------------------------------------------
            'LD発光/消光処理


            If intOnOff = 1 Then
                If mGPIB.GPIB_Send("LAS:OUT 1") = False Then Throw New Exception("")
            Else
                If mGPIB.GPIB_Send("LAS:OUT 0") = False Then Throw New Exception("")
            End If

        Catch ex As System.Exception
            LD_ONOFF = False
            Call gSysLog.LogOut("ILXLD_ONOFF," & ex.Message)
        Finally

        End Try

    End Function

    ''' <summary>
    ''' LD温調ON/OFF処理
    ''' </summary>
    ''' <param name="intOnOff">0:Off 1:On</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Friend Function LD_TEC_ONOFF(ByVal intOnOff As Integer) As Boolean

        LD_TEC_ONOFF = True

        Try
            If mLocalMode Then Exit Try

            '------------------------------------------------------------------
            'LD温調ON/OFF処理
            If intOnOff = 1 Then
                If mGPIB.GPIB_Send("TEC:OUT 1") = False Then Throw New Exception("")
            Else
                If mGPIB.GPIB_Send("TEC:OUT 0") = False Then Throw New Exception("")
            End If

        Catch ex As System.Exception
            LD_TEC_ONOFF = False
            Call gSysLog.LogOut("ILXLD_TEC_ONOFF," & ex.Message)
        Finally

        End Try

    End Function

    ''' <summary>
    ''' LD発光電流 設定/取得
    ''' </summary>
    ''' <param name="intIndex">0:Set 1:Get</param>
    ''' <param name="dblPow">設定or取得電流値</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Friend Function LD_Power(ByVal intIndex As Integer, ByRef dblPow As Double) As Boolean

        Dim strRet As String = ""

        LD_Power = True

        Try
            If mLocalMode Then
                If intIndex = 1 Then dblPow = Rnd() * 1000
                Exit Try
            End If

            '------------------------------------------------------------------
            'LD発光電流 設定/取得
            If intIndex = 1 Then
                If mGPIB.GPIB_Send("LAS:DIS:LDI") = False Then Throw New Exception("")
                Call System.Threading.Thread.Sleep(10)
                If mGPIB.GPIB_Send("LAS:DIS?") = False Then Throw New Exception("")
                Call System.Threading.Thread.Sleep(50)
                If mGPIB.GPIB_Receive(strRet) = False Then Throw New Exception("")
                dblPow = Val(Mid(strRet, 2, 6)) '戻り値
            Else
                If mGPIB.GPIB_Send("LAS:LDI " & dblPow) = False Then Throw New Exception("")
            End If

        Catch ex As System.Exception
            LD_Power = False
            Call gSysLog.LogOut("ILXLD_Power," & ex.Message)
        Finally

        End Try

    End Function

    ''' <summary>
    ''' LD PD 設定/取得
    ''' </summary>
    ''' <param name="intIndex">0:Set 1:Get</param>
    ''' <param name="dblPow">設定or取得PD値</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function PD_Power(ByVal intIndex As Integer, ByRef dblPow As Double) As Boolean

        Dim strRet As String = ""

        PD_Power = True

        Try
            If mLocalMode Then
                If intIndex = 1 Then dblPow = Rnd() * 1000
                Exit Try
            End If

            '------------------------------------------------------------------
            'PD 設定/取得
            'ILXはﾌﾛﾝﾄﾊﾟﾈﾙに表示中の値をLAS:DIS?で取得してくる…
            'なのでﾌﾛﾝﾄを変更してから取得命令…
            '通常の製造中はLD電流を見ていたいから最後に元に戻している(ｸﾗｽ設計的によろしくないです)
            If intIndex = 1 Then
                If mGPIB.GPIB_Send("LAS:DIS:MDI") = False Then Throw New Exception("")
                Call System.Threading.Thread.Sleep(50)
                If mGPIB.GPIB_Send("LAS:DIS?") = False Then Throw New Exception("")
                Call System.Threading.Thread.Sleep(50)
                If mGPIB.GPIB_Receive(strRet) = False Then Throw New Exception("")
                dblPow = Val(Mid(strRet, 2, 6)) '戻り値
                Call System.Threading.Thread.Sleep(50)
            Else

            End If

        Catch ex As System.Exception
            PD_Power = False
            Call gSysLog.LogOut("ILXPD_Power," & ex.Message)
        Finally
            If mLocalMode = False Then Call mGPIB.GPIB_Send("LAS:DIS:LDI")
        End Try

    End Function

    ''' <summary>
    ''' LD温調 設定/取得
    ''' </summary>
    ''' <param name="intIndex">0:Set 1:Get</param>
    ''' <param name="dblTemp">設定or取得温度</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Friend Function LD_Temp(ByVal intIndex As Integer, ByRef dblTemp As Double) As Boolean

        Dim strRet As String = ""

        LD_Temp = True

        Try
            If mLocalMode Then Exit Try

            '------------------------------------------------------------------
            'LD発光電流 設定/取得
            If intIndex = 1 Then
                If mGPIB.GPIB_Send("TEC:DIS?") = False Then Throw New Exception("")
                Call System.Threading.Thread.Sleep(50)
                If mGPIB.GPIB_Receive(strRet) = False Then Throw New Exception("")
                dblTemp = Val(Mid(strRet, 2, 6)) '戻り値
            Else
                If mGPIB.GPIB_Send("TEC:T " & dblTemp) = False Then Throw New Exception("")
            End If

        Catch ex As System.Exception
            LD_Temp = False
            Call gSysLog.LogOut("ILXLD_Temp," & ex.Message)
        Finally

        End Try

    End Function

    ''' <summary>
    ''' LD OnOff 待ち
    ''' </summary>
    ''' <param name="OnOffIndex">0:Off待ち 1:On待ち</param>
    ''' <param name="dblCurrThreshold">状態判定電流値</param>
    ''' <param name="TimeOutS">ﾀｲﾑｱｳﾄ(秒)</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Friend Function LDOnOffWait(ByVal OnOffIndex As Integer,
                                ByVal dblCurrThreshold As Double,
                                ByVal TimeOutS As Integer) As Boolean

        Dim dblPow As Double
        Dim intRet As Integer
        Dim strTimeOut As String = ""
        Dim intTimeOut = TimeOutS * 1000
        Dim sw As New System.Diagnostics.Stopwatch()

        LDOnOffWait = True

        Try
            If mLocalMode Then Exit Try

            '------------------------------------------------------------------
            'OnOff待ち
            sw.Start()
            Call System.Threading.Thread.Sleep(20)
            Do
                intRet = LD_Status()
                If OnOffIndex = 0 And intRet = 0 Then
                    If LD_Power(1, dblPow) Then
                        If dblPow < dblCurrThreshold Then Exit Do
                    End If
                ElseIf OnOffIndex = 1 And intRet = 1 Then
                    If LD_Power(1, dblPow) Then
                        If dblPow > dblCurrThreshold Then Exit Do
                    End If
                End If

                Call System.Threading.Thread.Sleep(500)

                '------------------------------------------------------------------
                'ﾀｲﾑｱｳﾄ
                If sw.ElapsedMilliseconds > intTimeOut Then
                    strTimeOut = "Time Out " & TimeOutS & "sec"
                    Throw New Exception("")
                End If

                Call System.Windows.Forms.Application.DoEvents()
                '------------------------------------------------------------------
                '中断確認
                If gblnEmergency = True Then Throw New Exception("")
            Loop
        Catch ex As System.Exception
            LDOnOffWait = False
            Call gSysLog.LogOut("ILXLDOnOffWait," & ex.Message & "," & strTimeOut)
        Finally
            sw.Stop()
        End Try

    End Function

    ''' <summary>
    ''' LD ﾍﾟﾙﾁｪｺﾝﾄﾛｰﾗ 安定待ち
    ''' </summary>
    ''' <param name="dblMainTmp">基準温度</param>
    ''' <param name="dblTolerance">温度公差</param>
    ''' <param name="StabilitySec">安定時間(秒)</param>
    ''' <param name="TimeOutS">ﾀｲﾑｱｳﾄ(秒)</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Friend Function LDTEC_Steady(ByVal dblMainTmp As Double,
                                 ByVal dblTolerance As Double,
                                 ByVal StabilitySec As Integer,
                                 ByVal TimeOutS As Integer) As Boolean

        Dim intCnt As Integer
        Dim dblTemp As Double
        Dim intLoopMax As Integer
        Dim strTimeOut As String = ""
        Dim sw As New System.Diagnostics.Stopwatch()
        Dim intTimeOut = TimeOutS * 1000

        Const SingleSleep As Long = 200

        LDTEC_Steady = True

        Try
            If mLocalMode Then Exit Try
            intLoopMax = (StabilitySec * 1000) / SingleSleep                  '安定回数計算

            '------------------------------------------------------------------
            '安定待ち
            sw.Start()
            Do
                If LD_Temp(1, dblTemp) = True Then
                    If ((dblMainTmp + dblTolerance) >= dblTemp) And ((dblMainTmp - dblTolerance) <= dblTemp) Then
                        intCnt = intCnt + 1
                    Else
                        intCnt = 0
                    End If
                Else
                    intCnt = 0
                End If
                If intCnt > intLoopMax Then Exit Do
                Call System.Threading.Thread.Sleep(SingleSleep)

                '------------------------------------------------------------------
                'ﾀｲﾑｱｳﾄ
                If sw.ElapsedMilliseconds > intTimeOut Then
                    strTimeOut = "Time Out " & TimeOutS & "sec"
                    Throw New Exception("")
                End If

                Call System.Windows.Forms.Application.DoEvents()
                '------------------------------------------------------------------
                '中断確認
                If gblnEmergency = True Then Throw New Exception("")
            Loop
        Catch ex As System.Exception
            LDTEC_Steady = False
            Call gSysLog.LogOut("ILXLDTEC_Steady," & ex.Message & "," & strTimeOut)
        Finally
            sw.Stop()
        End Try

    End Function

    ''' <summary>
    ''' LD ON/OFF確認
    ''' </summary>
    ''' <returns>0:OFF 1:ON -1:ｴﾗｰ</returns>
    ''' <remarks></remarks>
    Public Function LD_Status() As Integer

        Dim strRet As String = ""
        LD_Status = -1

        Try
            If mLocalMode Then Exit Try

            '------------------------------------------------------------------
            'LD ON/OFF確認
            If mGPIB.GPIB_Send("LAS:OUT?") = False Then Throw New Exception("")
            Call System.Threading.Thread.Sleep(50)
            If mGPIB.GPIB_Receive(strRet) = False Then Throw New Exception("")
            LD_Status = Val(strRet)

        Catch ex As System.Exception
            Call gSysLog.LogOut("ILXLD_Status," & ex.Message)
        Finally
            If LD_Status = -1 Then gSysLog.LogOut("ILXLD_Status," & strRet)
        End Try

    End Function
    ''Add checking Vf, Itec, Vtec functions to protect measurment error from machine machine and setting, refer solfware request sheet MC-21-0033
    'Add checking Ambient temperature function to protect solder remelt (action from quality talk)
    'Revised by Thanakit W. 16 Jul 2021

    Public Function TEC_Status() As Integer

        Dim strRet As String = ""
        TEC_Status = -1

        Try
            If mLocalMode Then Exit Try

            If mGPIB.GPIB_Send("TEC:OUT?") = False Then Throw New Exception("")
            Call System.Threading.Thread.Sleep(50)
            If mGPIB.GPIB_Receive(strRet) = False Then Throw New Exception("")
            TEC_Status = Val(strRet)

        Catch ex As System.Exception
            Call gSysLog.LogOut("ILXTEC_Status," & ex.Message)
        Finally
            If TEC_Status = -1 Then gSysLog.LogOut("ILXTEC_Status," & strRet)
        End Try

    End Function

    Friend Function LD_Itec_Limit(ByVal intIndex As Integer, ByRef dblItecLimit As Double) As Boolean

        Dim strRet As String = ""

        LD_Itec_Limit = True

        Try
            If mLocalMode Then Exit Try

            If mGPIB.GPIB_Send("TEC:LIM:ITE " & dblItecLimit) = False Then Throw New Exception("")


        Catch ex As System.Exception
            LD_Itec_Limit = False
            Call gSysLog.LogOut("ILXLD_Temp," & ex.Message)
        Finally

        End Try

    End Function
    Friend Function WriteGPIB(ByVal intIndex As Integer, ByVal RemoteCom As String, ByRef settingValue As Object) As Boolean

        Dim strRet As String = ""

        WriteGPIB = True

        Try
            If mLocalMode Then Exit Try

            If mGPIB.GPIB_Send(RemoteCom & settingValue) = False Then Throw New Exception("")


        Catch ex As System.Exception
            WriteGPIB = False
            Call gSysLog.LogOut("WriteGPIB," & ex.Message)
        Finally

        End Try

    End Function
    Friend Function ReadGPIB(ByVal intIndex As Integer, ByVal RemoteCom As String, ByRef readingValue As Object) As Boolean
        ReadGPIB = False

        Dim strRet As String = ""

        Try
            If mLocalMode Then Exit Try

            If mGPIB.GPIB_Send(RemoteCom) = False Then Throw New Exception("")
            If mGPIB.GPIB_Receive(strRet) = False Then Throw New Exception("")

            readingValue = strRet

            ReadGPIB = True
        Catch ex As System.Exception
            Call gSysLog.LogOut("ReadGPIB," & ex.Message)
        Finally
        End Try

    End Function
    Friend Function LD_Itec(ByVal intIndex As Integer, ByRef dblItec As Double) As Double
        Dim strRet As String = ""

        Try
            If mLocalMode Then Exit Try

            '------------------------------------------------------------------
            ''LD発光電流 設定/取得
            If intIndex = 1 Then
                If mGPIB.GPIB_Send("TEC:DIS?") = False Then Throw New Exception("")
                Call System.Threading.Thread.Sleep(50)
                If mGPIB.GPIB_Receive(strRet) = False Then Throw New Exception("")
                dblItec = Val(Mid(strRet, 2, 6)) '戻り値
            Else
                If mGPIB.GPIB_Send("TEC:ITE?") = False Then Throw New Exception("")
                If mGPIB.GPIB_Receive(strRet) = False Then Throw New Exception("")
            End If

            dblItec = strRet

        Catch ex As System.Exception
            Call gSysLog.LogOut("ILXLD_Temp," & ex.Message)
        Finally

        End Try

        Return dblItec

    End Function

    Friend Function LD_Vf(ByVal intIndex As Integer, ByRef dblVf As Double) As Double

        Dim strRet As String = ""

        Try
            If mLocalMode Then Exit Try

            '------------------------------------------------------------------
            ''LD発光電流 設定/取得
            If intIndex = 1 Then
                If mGPIB.GPIB_Send("TEC:DIS?") = False Then Throw New Exception("")
                Call System.Threading.Thread.Sleep(50)
                If mGPIB.GPIB_Receive(strRet) = False Then Throw New Exception("")
                dblVf = Val(Mid(strRet, 2, 6)) '戻り値
            Else
                If mGPIB.GPIB_Send("LAS:LDV?") = False Then Throw New Exception("")
                If mGPIB.GPIB_Receive(strRet) = False Then Throw New Exception("")
            End If

            dblVf = strRet

        Catch ex As System.Exception
            Call gSysLog.LogOut("ILXLD_Temp," & ex.Message)
        Finally

        End Try

        Return dblVf

    End Function

    Friend Function LD_Vtec(ByVal intIndex As Integer, ByRef dblVtec As Double) As Double

        Dim strRet As String = ""

        Try
            If mLocalMode Then Exit Try

            If mGPIB.GPIB_Send("TEC:V?") = False Then Throw New Exception("")
            If mGPIB.GPIB_Receive(strRet) = False Then Throw New Exception("")

        Catch ex As System.Exception
            Call gSysLog.LogOut("ILXLD_Temp," & ex.Message)
        Finally

            dblVtec = strRet

        End Try

        Return dblVtec

    End Function
    Friend Function LD_ReadTemp(ByVal intIndex As Integer, ByRef dblTemp As Double) As Double

        Dim strRet As String = ""

        Try
            If mLocalMode Then Exit Try

            If mGPIB.GPIB_Send("TEC:T?") = False Then Throw New Exception("")
            If mGPIB.GPIB_Receive(strRet) = False Then Throw New Exception("")

        Catch ex As System.Exception
            Call gSysLog.LogOut("ILXLD_Temp," & ex.Message)
        Finally

            dblTemp = strRet

        End Try

        Return dblTemp

    End Function
    Friend Function LD_ReadIop(ByVal intIndex As Integer, ByRef dblIop As Double) As Double

        Dim strRet As String = ""

        Try
            If mLocalMode Then Exit Try

            If mGPIB.GPIB_Send("LAS:LDI?") = False Then Throw New Exception("")
            If mGPIB.GPIB_Receive(strRet) = False Then Throw New Exception("")
            'End If

        Catch ex As System.Exception
            Call gSysLog.LogOut("ILXLD_Temp," & ex.Message)
        Finally

            dblIop = strRet

        End Try

        Return dblIop

    End Function

    Friend Function LD_ReadTempLimit(ByVal intIndex As Integer, ByRef Data As Double) As Double

        Dim strRet As String = ""

        Try
            If mLocalMode Then Exit Try

            If mGPIB.GPIB_Send("TEC:LIM:THI?") = False Then Throw New Exception("")
            If mGPIB.GPIB_Receive(strRet) = False Then Throw New Exception("")
            'End If

        Catch ex As System.Exception
            Call gSysLog.LogOut("LD_ReadTempLimit," & ex.Message)
        Finally

            Data = strRet

        End Try

        Return Data

    End Function

    Friend Function LD_ReadGain(ByVal intIndex As Integer, ByRef Data As Double) As Double

        Dim strRet As String = ""

        Try
            If mLocalMode Then Exit Try

            If mGPIB.GPIB_Send("TEC:GAIN?") = False Then Throw New Exception("")
            If mGPIB.GPIB_Receive(strRet) = False Then Throw New Exception("")
            'End If

        Catch ex As System.Exception
            Call gSysLog.LogOut("LD_ReadGain," & ex.Message)
        Finally

            Data = strRet

        End Try

        Return Data

    End Function

    Friend Function LD_ReadConstant(ByVal intIndex As Integer) As String

        Dim strRet As String = ""

        Try
            If mLocalMode Then Exit Try

            If mGPIB.GPIB_Send("TEC:CONST?") = False Then Throw New Exception("")
            If mGPIB.GPIB_Receive(strRet) = False Then Throw New Exception("")

        Catch ex As System.Exception
            Call gSysLog.LogOut("LD_ReadGain," & ex.Message)
        Finally

        End Try

        Return strRet

    End Function
    ''' <summary>
    ''' LD ﾍﾟﾙﾁｪｺﾝﾄﾛｰﾗ 安定待ち
    ''' </summary>
    ''' <param name="dblMainTmp">基準温度</param>
    ''' <param name="dblTolerance">温度公差</param>
    ''' <param name="StabilitySec">安定時間(秒)</param>
    ''' <param name="TimeOutS">ﾀｲﾑｱｳﾄ(秒)</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Friend Function LDTEC_SteadyCheck(ByVal dblMainTmp As Double,
                                 ByVal dblTolerance As Double,
                                 ByVal dblOffset As Double) As Boolean

        Dim dblTemp As Double

        Const SingleSleep As Long = 200

        LDTEC_SteadyCheck = False

        Try
            If mLocalMode Then Exit Try
            If LD_Temp(1, dblTemp) = True Then
                If (((dblMainTmp - dblOffset) + dblTolerance) >= dblTemp) And (((dblMainTmp - dblOffset) - dblTolerance) <= dblTemp) Then
                    LDTEC_SteadyCheck = True
                End If
            End If
        Catch ex As System.Exception
            'LDTEC_SteadyCheck = False
            'Call gSysLog.LogOut("ILXLDTEC_Steady," & ex.Message & "," & strTimeOut)
        Finally
            'sw.Stop()
            Call System.Threading.Thread.Sleep(SingleSleep)
        End Try

    End Function
End Class
