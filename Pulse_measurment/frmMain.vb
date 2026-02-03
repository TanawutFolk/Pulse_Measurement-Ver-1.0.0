Imports System.IO

Public Class frmMain
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        ' 
        Dim aboutWindow As New frmAbout()

        aboutWindow.ShowDialog()
    End Sub

    Private Sub btnProduction_Click(sender As Object, e As EventArgs) Handles btnProduction.Click
        Dim productWindow As New frmProduction
        productWindow.ShowDialog()
    End Sub

    Private Sub btnManual_Click(sender As Object, e As EventArgs) Handles btnManual.Click

    End Sub

    Private Sub btnPreference_Click(sender As Object, e As EventArgs) Handles btnPreference.Click
        Dim preferWindow As New frmPreferance
        preferWindow.ShowDialog()
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Me.Close()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim opFile As String = Path.Combine(Application.StartupPath, "SampleData\Product.txt")
        If File.Exists(opFile) Then
            Dim lines As String() = File.ReadAllLines(opFile)
            cboProduct.Items.AddRange(lines)
        End If
    End Sub

    Private Sub cboProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduct.SelectedIndexChanged
        ' เมื่อผู้ใช้เลือก Product จาก dropdown ให้บันทึกลง GlobalVariables
        If cboProduct.SelectedItem IsNot Nothing Then
            GlobalVariables.CurrentProduct = cboProduct.SelectedItem.ToString()
        End If
    End Sub
End Class