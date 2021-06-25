'   Copyright(c) 2017, Luis A. Flores
'   All rights reserved.


' Numerical Integration App (NIA)
' Form: frmTechnique.vb
' by Luis A. Flores
' SICI4038 7/14/2017

'frmWelcome Class is responsible For displaying the welcome screen to the user
Public Class frmWelcome
    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    'Start button method shows the menu form
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        frmMenu.Show()
        Me.Hide()
    End Sub

    'Exit button method for quitting the application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Application.Exit()
    End Sub
End Class
