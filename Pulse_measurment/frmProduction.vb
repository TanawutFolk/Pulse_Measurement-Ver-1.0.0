Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json

Public Class frmProduction
    Private Sub btnMeasureIL_condition_Click(sender As Object, e As EventArgs) Handles btnMeasureIL_condition.Click
        Dim ilMeasureWindow As New frmILMeasurement
        ilMeasureWindow.ShowDialog()
    End Sub

    Private Sub btnMeasureWL_condition_Click(sender As Object, e As EventArgs) Handles btnMeasureWL_condition.Click
        Dim wlMeasureWindow As New frmWLMeasurement
        wlMeasureWindow.ShowDialog()
    End Sub

    Private Sub btnMeasureWaveform_Click(sender As Object, e As EventArgs) Handles btnMeasureWaveform.Click
        Dim wMeasureWindow As New frmWMeasurement
        wMeasureWindow.ShowDialog()
    End Sub

    Private Sub btnJudgIL_condition_Click(sender As Object, e As EventArgs) Handles btnJudgIL_condition.Click
        Dim ilJudgWindow As New frmiLJudgment 'form1 is ILjudgment condition
        ilJudgWindow.ShowDialog()
    End Sub

    Private Sub btnJudgWL_condition_Click(sender As Object, e As EventArgs) Handles btnJudgWL_condition.Click
        Dim wlJudgWindow As New frmWLJudgment
        wlJudgWindow.ShowDialog()
    End Sub

    Private Sub btnJudgW_condition_Click(sender As Object, e As EventArgs) Handles btnJudgW_condition.Click
        Dim wJudgWindow As New frmWJudgment
        wJudgWindow.ShowDialog()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "JSON Files|*.json"

        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                ' 1. อ่านไฟล์
                Dim jsonContent As String = File.ReadAllText(ofd.FileName)
                ' --- เพิ่มบรรทัดนี้ เพื่อขอดูไส้ในไฟล์ก่อนครับ ---
                MessageBox.Show(jsonContent)

                ' 2. แปลง JSON เข้าแม่พิมพ์
                Dim data As Production = JsonConvert.DeserializeObject(Of Production)(jsonContent)

                ' 3. จับคู่ตัวแปร JSON -> (Mapping)
                txtMachineNO.Text = data.ProcNo
                txtPathNumber.Text = data.ProcName
                txtVoltWat.Text = data.sCalFactor.ToString()

                MessageBox.Show("Load Success")

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub frmProduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'combobox
        Dim fileName As String = "SampleData/Operator.txt"
        If File.Exists(fileName) Then
            Dim lines() As String = File.ReadAllLines(fileName)
            cboOperator.Items.Clear()
            cboOperator.Items.AddRange(lines)
        Else
            MessageBox.Show("Not Found " & fileName & " file")

        End If

    End Sub
End Class

Public Class Production
    Public Property ProcNo As String      ' คือ Machine No.
    Public Property ProcName As String    ' คือ Part number
    Public Property sCalFactor As Double  ' คือ Power Correction (ใช้ Double เพราะอาจมีทศนิยม)
End Class