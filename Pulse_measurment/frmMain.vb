Public Class frmMain
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        ' 
        Dim aboutWindow As New frmAbout()

        ' สั่งโชว์แบบ Dialog 
        ' (User ต้องกดปิดหน้า About ก่อน ถึงจะกลับไปกดหน้า Main ได้)
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
End Class