Imports System.IO
Imports Newtonsoft.Json


Module GlobalVariables

    ' เก็บค่าตัวแปรจาก Dropdown Product ที่หน้าหลัก
    Public CurrentProduct As String = ""

    ' 2. ตัวแปรเก็บสูตรการผลิตปัจจุบัน (ที่โหลดมาจากไฟล์ Json)
    ' เวลาแก้ค่าในหน้าจอ เราจะแก้ใส่ตัวนี้
    Public CurrentRecipe As New ProductionParameters()
    Public CurrentPreferance As New PreferanceConfig()

    '--- หา path โฟลเดอร์ PRF ---
    Public Function GetPRFPath() As String
        ' หาตำแหน่งที่ไฟล์ .exe รันอยู่ (bin\Debug)
        Dim appPath As String = Application.StartupPath
        ' appPath = C:\Users\Tanaw\Desktop\ALL_Pulse\Pulse_measurment\Pulse_measurment\bin\Debug

        ' ถอยออกมา 4 ขั้น เพื่อไปหา ALL_Pulse
        ' Debug → bin → Pulse_measurment → Pulse_measurment → ALL_Pulse
        Dim currentDir As DirectoryInfo = Directory.GetParent(appPath)          ' → bin
        currentDir = Directory.GetParent(currentDir.FullName)                   ' → Pulse_measurment (โปรเจกต์)
        currentDir = Directory.GetParent(currentDir.FullName)                   ' → Pulse_measurment (solution)
        Dim allPulseRoot As String = Directory.GetParent(currentDir.FullName).FullName ' → ALL_Pulse

        ' สร้าง Path ไปที่ ALL_Pulse\PRF
        Dim prfPath As String = Path.Combine(allPulseRoot, "PRF")

        ' ถ้ายังไม่มี ให้สร้างรอไว้เลย
        If Not Directory.Exists(prfPath) Then Directory.CreateDirectory(prfPath)

        Return prfPath
    End Function
End Module
