''' <summary>
''' Machine Info Class - ??????? GPIB Address ??? Unit ?????????????
''' </summary>
Public Class MachineInfo

    ' --- LD Controller 1 ---
    Public Property GPIBLD1 As Integer = 1
    Public Property UnitLD1 As Integer = 0

    ' --- LD Controller 2 ---
    Public Property GPIBLD2 As Integer = 2
    Public Property UnitLD2 As Integer = 0

    ' --- TEC Controller Tc (Case Temperature) ---
    Public Property GPIBTc As Integer = 3
    Public Property UnitTc As Integer = 0

    ' --- TEC Controller Ts (LD Temperature) ---
    Public Property GPIBTs As Integer = 4
    Public Property UnitTs As Integer = 0

    ' --- Other Instruments ---
    Public Property GPIBOsa As Integer = 5          ' Optical Spectrum Analyzer
    Public Property UnitOsa As Integer = 0

    Public Property GPIBAttenuator As Integer = 6   ' Optical Attenuator
    Public Property UnitAttenuator As Integer = 0

    Public Property GPIBSwitch As Integer = 7       ' Optical Switch
    Public Property UnitSwitch As Integer = 0

    Public Property GPIBMultimeter As Integer = 8   ' Digital Multimeter
    Public Property UnitMultimeter As Integer = 0

End Class
