' 1. Class ProductionParameters
Public Class ProductionParameters

    ' --- Header Production ---
    Public Property ParameterFile As String
    Public Property OperatorName As String
    Public Property MachineNo As String
    Public Property PartNumber As String
    Public Property LotNumber As String
    Public Property SerialNumber As String

    Public Property FBG1 As String
    Public Property FBG2 As String
    Public Property DataFolder As String
    Public Property PowerCorrection As Double

    ' --- Measurement Checkboxes ------------------------------------------
    ' IL Condition Checkboxes
    Public Property Meas_Enable_IL1 As Boolean
    Public Property Meas_Enable_IL2 As Boolean
    Public Property Meas_Enable_IL3 As Boolean
    Public Property Meas_Enable_IL4 As Boolean
    Public Property Meas_Enable_IL5 As Boolean
    Public Property Meas_Enable_IL6 As Boolean

    ' WL Condition Checkboxes
    Public Property Meas_Enable_Spec1 As Boolean
    Public Property Meas_Enable_Spec2 As Boolean
    Public Property Meas_Enable_Spec3 As Boolean
    Public Property Meas_Enable_Spec4 As Boolean
    Public Property Meas_Enable_Spec5 As Boolean
    Public Property Meas_Enable_Spec6 As Boolean

    ' Waveform Condition Checkboxes
    Public Property Meas_Enable_Wave1 As Boolean
    Public Property Meas_Enable_Wave2 As Boolean
    Public Property Meas_Enable_Wave3 As Boolean
    Public Property Meas_Enable_Wave4 As Boolean
    Public Property Meas_Enable_Wave5 As Boolean
    Public Property Meas_Enable_Wave6 As Boolean

    ' Use Calory Meter
    Public Property Meas_UseCaloryMeter As Boolean

    ' --- Judgment Checkboxes ------------------------------------------
    Public Property Judge_Enable_IL1 As Boolean
    Public Property Judge_Enable_IL2 As Boolean
    Public Property Judge_Enable_IL3 As Boolean
    Public Property Judge_Enable_IL4 As Boolean
    Public Property Judge_Enable_IL5 As Boolean
    Public Property Judge_Enable_IL6 As Boolean

    Public Property Judge_Enable_Spec1 As Boolean
    Public Property Judge_Enable_Spec2 As Boolean
    Public Property Judge_Enable_Spec3 As Boolean
    Public Property Judge_Enable_Spec4 As Boolean
    Public Property Judge_Enable_Spec5 As Boolean
    Public Property Judge_Enable_Spec6 As Boolean

    Public Property Judge_Enable_Wave1 As Boolean
    Public Property Judge_Enable_Wave2 As Boolean
    Public Property Judge_Enable_Wave3 As Boolean
    Public Property Judge_Enable_Wave4 As Boolean
    Public Property Judge_Enable_Wave5 As Boolean
    Public Property Judge_Enable_Wave6 As Boolean

    ' ------------------------------------------------------------------------------------
    ' เชื่อมกับ Class ย่อยด้านล่าง
    ' ------------------------------------------------------------------------------------
    Public Property Meas_IL_Settings As New IL_Measure_Settings()
    Public Property Meas_WL_Settings As New WL_Measure_Settings()
    Public Property Meas_W_Settings As New W_Measure_Settings()

    Public Property Judge_IL_Settings As New IL_Judge_Group()
    Public Property Judge_WL_Settings As New WL_Judge_Group()
    Public Property Judge_W_Settings As New Wave_Judge_Group()

End Class

' Class กลุ่ม รวม IL_Measurement ทั้ง 6 Tabs ------------------------------------------------------------
Public Class IL_Measure_Settings
    Public Property L1 As New ILParameter()
    Public Property L2 As New ILParameter()
    Public Property L3 As New ILParameter()
    Public Property L4 As New ILParameter()
    Public Property L5 As New ILParameter()
    Public Property L6 As New ILParameter()
End Class

' Class กลุ่ม รวม WL_Measurement ทั้ง 6 Tabs ------------------------------------------------------------
Public Class WL_Measure_Settings
    Public Property Spec1 As New WLParameter()
    Public Property Spec2 As New WLParameter()
    Public Property Spec3 As New WLParameter()
    Public Property Spec4 As New WLParameter()
    Public Property Spec5 As New WLParameter()
    Public Property Spec6 As New WLParameter()
End Class

' Class กลุ่ม รวม W_Measurement ทั้ง 6 Tabs ------------------------------------------------------------
Public Class W_Measure_Settings
    Public Property Wave1 As New WaveformParameter()
    Public Property Wave2 As New WaveformParameter()
    Public Property Wave3 As New WaveformParameter()
    Public Property Wave4 As New WaveformParameter()
    Public Property Wave5 As New WaveformParameter()
    Public Property Wave6 As New WaveformParameter()
End Class

' Class กลุ่ม รวม IL_Judgment ทั้ง 6 Tabs ------------------------------------------------------------
Public Class IL_Judge_Group
    Public Property L1 As New IL_Judge_Parameter()
    Public Property L2 As New IL_Judge_Parameter()
    Public Property L3 As New IL_Judge_Parameter()
    Public Property L4 As New IL_Judge_Parameter()
    Public Property L5 As New IL_Judge_Parameter()
    Public Property L6 As New IL_Judge_Parameter()
End Class

' Class กลุ่ม รวม WL_Judgment ทั้ง 6 Tabs ------------------------------------------------------------
Public Class WL_Judge_Group
    Public Property Spec1 As New WL_Judge_Parameter()
    Public Property Spec2 As New WL_Judge_Parameter()
    Public Property Spec3 As New WL_Judge_Parameter()
    Public Property Spec4 As New WL_Judge_Parameter()
    Public Property Spec5 As New WL_Judge_Parameter()
    Public Property Spec6 As New WL_Judge_Parameter()
End Class

' Class กลุ่ม รวม W_Judgment ทั้ง 6 Tabs ------------------------------------------------------------
Public Class Wave_Judge_Group
    Public Property Wave1 As New W_Judge_Parameter()
    Public Property Wave2 As New W_Judge_Parameter()
    Public Property Wave3 As New W_Judge_Parameter()
    Public Property Wave4 As New W_Judge_Parameter()
    Public Property Wave5 As New W_Judge_Parameter()
    Public Property Wave6 As New W_Judge_Parameter()
End Class

'-------------- Class IL_Measurement Parameter 1 Tab ------------------------------------------------------------
Public Class ILParameter
    ' โซน 1: If Sweep
    Public Property IfStart As Double
    Public Property IfStep As Double
    Public Property IfStop As Double
    Public Property Frequency As Double
    Public Property DutyCycle As Double
    Public Property PulseWidth As Double
    Public Property DelayTime As Double
    Public Property PowerAvg As Double
    Public Property Tc As Double
    Public Property Tld As Double
    Public Property ICAL As Double
    Public Property ATT As Double
    Public Property SampleNumber As Double

    ' โซน 2: IL Point
    Public Property FCP As Double
    Public Property FPP As Double
    Public Property FRP As Double
    Public Property FCP2 As Double
    Public Property FPP2 As Double
    Public Property FRP2 As Double
    Public Property FPP3 As Double
    Public Property FPP4 As Double

    ' โซน 3: If Sweep Graph Scale/Div
    Public Property Scale_If As Double
    Public Property Div_If As Double
    Public Property Scale_Vf As Double
    Public Property Div_Vf As Double
    Public Property Scale_Po As Double
    Public Property Div_Po As Double
    Public Property Scale_SE As Double
    Public Property Div_SE As Double
    Public Property Scale_Rd As Double
    Public Property Div_Rd As Double
    Public Property Scale_Im As Double
    Public Property Div_Im As Double
End Class

'-------------- Class WL_Measurement Parameter 1 Tab ------------------------------------------------------------
Public Class WLParameter
    ' --- Pulse Condition (ซ้าย) ---
    Public Property IfPulse As Double    ' If [mA]
    Public Property Frequency As Double     ' Frequency [KHz]
    Public Property DutyCycle As Double     ' Duty cycle [%]
    Public Property PulseWidth As Double    ' Pulse Width [us]
    Public Property DelayTime As Double     ' Delay time [us]
    Public Property Tc As Double            ' Tc [°C]
    Public Property Tld As Double           ' Tld [°C]
    Public Property ATT As Double           ' ATT [dB]

    ' --- OSA Setting (กลาง) ---
    Public Property WLCenter As Double      ' WL Center [nm]
    Public Property Span As Double          ' Span [nm]
    Public Property RefLevel As Double      ' Ref Level [dBm]
    Public Property Resolution As Double    ' Resolution [nm]
    Public Property Sensitivity As String   ' Sensitivity (Dropdown: MID, HIGH)
    Public Property Points As Integer       ' Points
    Public Property Average As Integer      ' Average [Tims]
    Public Property SweepSpeed As Integer   ' Sweep Speed
    Public Property WavelengthA As Integer  ' Wavelength A
    Public Property WavelengthB As Integer  ' Wavelength B

    ' --- Measurement Point (ขวา) ---
    Public Property Point1 As String        ' IL1
    Public Property Point2 As String        ' FFP
End Class

' ------------- Class W_Measurement Parameter 1 Tab -------------------------------------------------------------
Public Class WaveformParameter
    ' --- Pulse Condition ซ้าย ---
    Public Property IfPulse As Double
    Public Property Frequency As Double
    Public Property DutyCycle As Double
    Public Property PulseWidth As Double
    Public Property DelayTime As Double
    Public Property Average As Double       ' Average [time]
    Public Property Tc As Double
    Public Property Tld As Double
    Public Property ATT As Double

    ' --- OSC Setting กลาง ---
    Public Property TimePerDiv As Double    ' Time/div [us/div]
    Public Property DataPoint As Integer    ' Data Point [pts]

    Public Property CH1_Coupling As String  ' AC/DC
    Public Property CH1_VoltPerDiv As Double

    Public Property CH2_Coupling As String  ' AC/DC
    Public Property CH2_VoltPerDiv As Double

    Public Property TriggerSource As String
    Public Property TriggerType As String
    Public Property TriggerLevel As Double
    Public Property TriggerMode As String

    ' --- Measurement Point ขวา ---
    Public Property Point1 As String
    Public Property Point2 As String
End Class

' ------------- Class IL_judge_Parameter 1 Tab -------------------------------------------------------------
Public Class IL_Judge_Parameter
    ' --- ส่วนบน ---
    Public Property SelectPoint As String

    ' --- dL / dI ---
    Public Property Step_mA As Double
    Public Property Smoothing_pt As Double
    Public Property PermissionRate As Double

    ' --- Kink Method (0=Each Point, 1=Parallel Line) ---
    Public Property KinkMethod As Integer

    ' --- Judgment Mode (แยก Start และ End) ---
    Public Property StartMode As Integer ' 1=Row1, 2=Row2, 3=Row3
    Public Property EndMode As Integer   ' 1=Row1, 2=Row2, 3=Row3

    ' --- Row 1 (แบบซับซ้อน) ---
    ' ฝั่ง Start
    Public Property Row1_Start_Cbo1 As String
    Public Property Row1_Start_Cbo2 As String
    Public Property Row1_Start_Val As Double
    ' ฝั่ง End
    Public Property Row1_End_Cbo1 As String
    Public Property Row1_End_Cbo2 As String
    Public Property Row1_End_Val As Double

    ' --- Row 2 (mA) ---
    Public Property Row2_Start_mA As Double
    Public Property Row2_End_mA As Double

    ' --- Row 3 (mW) ---
    Public Property Row3_Start_mW As Double
    Public Property Row3_End_mW As Double

    ' --- Least-squares method ---
    Public Property LeastSquaresMode As Integer ' 0=Primary, 1=Secondary
    Public Property NumOfPoint As Integer
End Class

' ------------ Class WL_judge_Parameter 1 Tab -------------------------------------------------------------
Public Class WL_Judge_Parameter
    Public Property Select1 As String       ' Select (ซ้าย)
    Public Property Select2 As String       ' Select (ขวา)

    ' --- PinBand ---
    Public Property PinBand_Min As Double
    Public Property PinBand_Max As Double
End Class

' ------------ Class W_judge_Parameter 1 Tab -------------------------------------------------------------
Public Class W_Judge_Parameter
    Public Property Select1 As String
    Public Property Select2 As String

    ' --- Rise time ---
    Public Property RiseTime_Min As Double
    Public Property RiseTime_Max As Double
    Public Property RiseTime_Start As Double ' Start [%]
    Public Property RiseTime_Stop As Double  ' Stop [%]

    ' --- Fall time ---
    Public Property FallTime_Min As Double
    Public Property FallTime_Max As Double
    Public Property FallTime_Start As Double ' Start [%]
    Public Property FallTime_Stop As Double  ' Stop [%]

    ' --- FBG Locking time ---
    Public Property LockingTime_Min As Double
    Public Property LockingTime_Max As Double

    ' --- Slew rate ---
    Public Property SlewRate_Min As Double
    Public Property SlewRate_Max As Double
End Class