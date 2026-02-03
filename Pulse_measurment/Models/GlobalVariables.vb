Imports System.IO
Imports Newtonsoft.Json


Module GlobalVariables
    ' 1. ตัวแปรเก็บชื่อรุ่นสินค้าปัจจุบัน (ที่เลือกจาก Dropdown หน้าแรก)
    ' ค่าเริ่มต้นเป็นค่าว่าง ""
    Public CurrentProduct As String = ""

    ' 2. ตัวแปรเก็บสูตรการผลิตปัจจุบัน (ที่โหลดมาจากไฟล์ Json)
    ' เวลาแก้ค่าในหน้าจอ เราจะแก้ใส่ตัวนี้
    Public CurrentRecipe As New ProductionParameters()
    Public CurrentPreferance As New PreferanceConfig()

    ' ---------------------------------------------------------
    ' ฟังก์ชันเสริม: หา Path ของโฟลเดอร์ PRF (เอามาไว้ตรงนี้จะได้เรียกใช้ได้ทุกที่)
    ' ---------------------------------------------------------
    Public Function GetPRFPath() As String
        ' หาตำแหน่งที่ไฟล์ .exe รันอยู่
        Dim appPath As String = Application.StartupPath

        ' ถอยออกมา 1 ขั้น เพื่อไปหาโฟลเดอร์ PRF
        Dim prfPath As String = Path.Combine(Directory.GetParent(appPath).FullName, "PRF")

        ' ถ้ายังไม่มี ให้สร้างรอไว้เลย
        If Not Directory.Exists(prfPath) Then Directory.CreateDirectory(prfPath)

        Return prfPath
    End Function
End Module
