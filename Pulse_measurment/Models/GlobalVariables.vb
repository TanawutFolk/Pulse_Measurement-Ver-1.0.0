Imports System.IO
Imports Newtonsoft.Json
Imports Ivi.Visa.Interop

Module GlobalVariables

    '--- product Dropdown & Save Preference
    Public CurrentProduct As String = ""
    Public CurrentRecipe As New ProductionParameters()
    Public CurrentPreferance As New PreferanceConfig()

    Dim resoureceManager As New ResourceManager()

    'GPIB
    Dim instrument1 As MessageBasedSession 'LDT-5910C
    Dim instrument2 As MessageBasedSession 'YOKOGAWA AQ6370D
    Dim instrument3 As MessageBasedSession 'SANTEC OVA-100
    Dim instrument4 As MessageBasedSession 'YOKOGAWA AQ2211
    Dim instrument5 As MessageBasedSession 'FUKKO SYSTEM T-845
    Dim instrument6 As MessageBasedSession 'OFS 1000
    Dim instrument7 As MessageBasedSession 'KEYSIGHT 34416A
    'USB
    Dim usbIntrument1 As MessageBasedSession 'CCS-HPP
    Dim usbIntrument2 As MessageBasedSession 'Oscilloscope















    '--- หา path โฟลเดอร์ PRF ---
    Public Function GetPRFPath() As String
        ' StartupPath
        Dim appPath As String = Application.StartupPath
        'appPath = C : \Users\Tanaw\Desktop\ALL_Pulse\Pulse_measurment\Pulse_measurment\bin\Debug

        ' ย้อน Folder
        ' Debug → bin → Pulse_measurment → Pulse_measurment → ALL_Pulse
        Dim currentDir As DirectoryInfo = Directory.GetParent(appPath)          ' → bin
        currentDir = Directory.GetParent(currentDir.FullName)                   ' → Pulse_measurment Project
        currentDir = Directory.GetParent(currentDir.FullName)                   ' → Pulse_measurment solution
        Dim allPulseRoot As String = Directory.GetParent(currentDir.FullName).FullName ' → นอกสุด

        ' สร้าง Path ไปที่ ALL_Pulse\PRF
        Dim prfPath As String = Path.Combine(allPulseRoot, "PRF")
        If Not Directory.Exists(prfPath) Then Directory.CreateDirectory(prfPath)

        Return prfPath
    End Function
End Module
