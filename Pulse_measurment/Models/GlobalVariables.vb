Imports System.IO
Imports Newtonsoft.Json
Imports NationalInstruments.Visa

Module GlobalVariables

    Public CurrentProduct As String = ""
    Public CurrentRecipe As New ProductionParameters()
    Public CurrentPreferance As New PreferanceConfig()

















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
