Imports Newtonsoft.Json

Public Class GPIBSettings
    Public Property LDT_5910C_TempControlLD As String
    Public Property YOKOGAWA_AQ6370D_OpticSpectAnalyz As String
    Public Property SANTEC_OVA_100_OpticAttenua As String
    Public Property YOKOGAWA_AQ2211_OpticSwitch As String
    Public Property KEYSIGHT_DSO_X_4154GOsciloscope As String
    Public Property FUKKO_SYSTEMAT_845TempControlBase As String
    Public Property KEYSIGHT_34416A_Digitlmultimeter As String
End Class

Public Class PowerMeasurement
    Public Property LaserStar_comport As Double
    Public Property Delaytime As Double
    Public Property Average As Double
End Class

Public Class VariousFolder
    Public Property ParamsFolder As String
    Public Property DataFolder As String
End Class

Public Class Rcable
    Public Property Rprobe As Double
    Public Property Rtec As Double
End Class

Public Class TEC_Condition
    Public Property Case_Waitmultiply As Double
    Public Property Case_WaitPlus As Double
    Public Property Case_Error As Double
    Public Property LD_Waitmultiply As Double
    Public Property LD_WaitPlus As Double
    Public Property LD_Error As Double
    Public Property Det_WaitFactor As Double
    Public Property Det_WaitBase As Double
    Public Property Det_Error As Double
    Public Property Det_SetTemp As Double
    Public Property Timeout As Double
    Public Property GainValue As Integer
End Class

Public Class CCS_HPP
    Public Property MaxAvgCurrent As Double
    Public Property MaximumCWCurrent As Double
    Public Property MaxpeakCurrent As Double
    Public Property Lasermode As String
    Public Property duration As String
    Public Property BFMgain As Double
    Public Property BFMconvers As Double
    Public Property Comport As String
    Public Property Baudrate As Double
End Class

Public Class GeneralSet
    Public Property DelayTimeOffset As Double
End Class

Public Class PreferanceConfig
    Public Property GPIB_address As New GPIBSettings()
    Public Property Power_Measurement As New PowerMeasurement()
    Public Property VariousKinds_Folders As New VariousFolder()
    Public Property Rcable As New Rcable()
    Public Property TEC_Condition As New TEC_Condition()
    Public Property CCS_HPP As New CCS_HPP()
    Public Property General_Setting As New GeneralSet()
End Class
