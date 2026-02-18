Imports Newtonsoft.Json

Public Class GPIBSettings
    Public Property LDT_5910C_TempControlLD As Integer = "1"
    Public Property YOKOGAWA_AQ6370D_OpticSpectAnalyz As Integer = "2"
    Public Property SANTEC_OVA_100_OpticAttenua As Integer = "3"
    Public Property YOKOGAWA_AQ2211_OpticSwitch As Integer = "4"
    'Public Property KEYSIGHT_DSO_X_4154GOsciloscope As String = ""
    Public Property FUKKO_SYSTEMAT_845TempControlBase As Integer = "5"
    Public Property OFS_1000_TempControlBase As Integer = "6"
    Public Property KEYSIGHT_34416A_Digitlmultimeter As Integer = "7"
End Class

Public Class PowerMeasurement
    Public Property LaserStar_comport As Double = 0
    Public Property Delaytime As Double = 0
    Public Property Average As Double = 0
    Public Property MaxPeakCurrent As Double = 0  'เพิ่งเพิ่มมา
    Public Property LaserOperationMode As String = ""
End Class

Public Class VariousFolder
    Public Property ParamsFolder As String = ""
    Public Property DataFolder As String = ""
End Class

Public Class Rcable
    Public Property Rprobe As Double = 0
    Public Property Rtec As Double = 0
End Class

Public Class TEC_Condition
    Public Property Case_Waitmultiply As Double = 0
    Public Property Case_WaitPlus As Double = 0
    Public Property Case_Error As Double = 0
    Public Property LD_Waitmultiply As Double = 0
    Public Property LD_WaitPlus As Double = 0
    Public Property LD_Error As Double = 0
    Public Property Det_WaitFactor As Double = 0
    Public Property Det_WaitBase As Double = 0
    Public Property Det_Error As Double = 0
    Public Property Det_SetTemp As Double = 0
    Public Property Timeout As Double = 0
    Public Property GainValue As Integer = 1
End Class

Public Class CCS_HPP
    Public Property MaxAvgCurrent As Double = 0
    Public Property MaximumCWCurrent As Double = 0
    Public Property MaxpeakCurrent As Double = 0
    Public Property Lasermode As String = "ACC"
    Public Property duration As String = "int"
    Public Property BFMgain As Double = 0
    Public Property BFMconvers As Double = 0
    Public Property Comport As String = ""
    Public Property Baudrate As Double = 9600
End Class

Public Class OscilloscopeSettings
    Public Property Comport As String = ""
    Public Property Baudrate As Double = 9600
End Class

Public Class GeneralSet
    Public Property DelayTimeOffset As Double = 0
End Class

Public Class ChannelSwitch
    Public Property WL_Start As String = ""
    Public Property WL_Stop As String = ""
    Public Property Slot As Integer = 1
    Public Property Input As Integer = 0
    Public Property Output As Integer = 1
End Class


Public Class PreferanceParameter
    Public Property GPIB_address As New GPIBSettings()
    Public Property Power_Measurement As New PowerMeasurement()
    Public Property VariousKinds_Folders As New VariousFolder()
    Public Property Rcable As New Rcable()
    Public Property TEC_Condition As New TEC_Condition()
    Public Property CCS_HPP As New CCS_HPP()
    Public Property General_Setting As New GeneralSet()
    Public Property Oscilloscope_Setting As New OscilloscopeSettings()
    Public Property ChanelSwitch As New ChannelSwitch()
End Class
