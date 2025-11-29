' ==========================================
' 1. Class แม่พิมพ์หลัก (ProductionParameters)
' ==========================================
Public Class ProductionParameters

    ' --- Header Information ---
    Public Property ParameterFile As String
    Public Property OperatorName As String
    Public Property MachineNo As String
    Public Property PartNumber As String    ' แก้เป็น String ตามคำแนะนำ
    Public Property LotNumber As String     ' แก้เป็น String ตามคำแนะนำ
    Public Property SerialNumber As String  ' แก้เป็น String ตามคำแนะนำ

    Public Property FBG1 As String
    Public Property FBG2 As String
    Public Property DataFolder As String
    Public Property PowerCorrection As Double

    ' --- Measurement Checkboxes ---
    Public Property Meas_UseCaloryMeter As Boolean

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

    ' --- Judgment Checkboxes ---
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

    ' ==========================================
    ' ส่วนสำคัญ: เชื่อมโยงกับ Class ย่อยด้านล่าง
    ' ==========================================
    Public Property Meas_IL_Settings As New IL_Group_Settings()

End Class

' ==========================================
' 2. Class กลุ่ม: รวม IL ทั้ง 6 Tabs ไว้ด้วยกัน
' ==========================================
Public Class IL_Group_Settings
    Public Property L1 As New ILParameter()
    Public Property L2 As New ILParameter()
    Public Property L3 As New ILParameter()
    Public Property L4 As New ILParameter()
    Public Property L5 As New ILParameter()
    Public Property L6 As New ILParameter()
End Class

' ==========================================
' 3. Class ย่อย: เก็บค่า Setting ของ IL Sweep (สำหรับ 1 Tab)
' ==========================================
Public Class ILParameter
    ' โซน 1: If Sweep
    Public Property IfStart As Double
    Public Property IfStep As Double
    Public Property IfStop As Double
    Public Property Frequency As Double
    Public Property DutyCycle As Double
    Public Property PulseWidth As Double
    Public Property DelayTime As Double
    Public Property PowerAvg As Integer
    Public Property Tc As Double
    Public Property Tld As Double
    Public Property ICAL As Double
    Public Property ATT As Double

    ' โซน 2: IL Point
    Public Property FCP As Double
    Public Property FPP As Double
    Public Property FRP As Double
    Public Property FCP2 As Double
    Public Property FPP2 As Double
    Public Property FRP2 As Double
    Public Property FPP3 As Double
    Public Property FPP4 As Double

    ' โซน 3: Graph Scale
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