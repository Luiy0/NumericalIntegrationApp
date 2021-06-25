'   Copyright(c) 2017, Luis A. Flores
'   All rights reserved.

' Numerical Integration App (NIA)
' Form: frmTechnique.vb
' by Luis A. Flores
' SICI4038 7/14/2017

'frmMenu.vb 
'The class serves as a menu where the user can select the desired technique. Once a technique is selected the frmTechnique form will show.

Public Class frmMenu

    'Button method for the Left side Riemann Sum selection.
    Private Sub btnRiemannUpper_Click(sender As Object, e As EventArgs) Handles btnRiemannUpper.Click
        'Label displaying the chosen technique in the form.
        frmTechnique.lblTechName.Text = "Left Riemann Sum"
        frmTechnique.txtTerms.Hide()
        frmTechnique.lblTerms.Hide()
        frmTechnique.lblSubinterval.Show()
        frmTechnique.txtSubinterval.Show()
        'Hiding this form
        Me.Hide()
        'Showing the next form
        frmTechnique.Show()
    End Sub

    'Button subrutine for the right side Riemann Sum selection.
    Private Sub btnRiemannLower_Click(sender As Object, e As EventArgs) Handles btnRiemannLower.Click
        'Label displaying the chosen technique in the form.
        frmTechnique.lblTechName.Text = "Right Riemann Sum"
        frmTechnique.txtTerms.Hide()
        frmTechnique.lblTerms.Hide()
        frmTechnique.lblSubinterval.Show()
        frmTechnique.txtSubinterval.Show()
        Me.Hide()
        frmTechnique.Show()
    End Sub

    'Button subrutine for the Midpoint Rule selection.
    Private Sub btnMidpoint_Click(sender As Object, e As EventArgs) Handles btnMidpoint.Click
        'Label displaying the chosen technique in the form.
        frmTechnique.lblTechName.Text = "Midpoint Rule"
        frmTechnique.txtTerms.Hide()
        frmTechnique.lblTerms.Hide()
        frmTechnique.lblSubinterval.Show()
        frmTechnique.txtSubinterval.Show()
        Me.Hide()
        frmTechnique.Show()

    End Sub

    'Button subrutine for the Trapezoidal Rule selection.
    Private Sub btnTrapezoidal_Click(sender As Object, e As EventArgs) Handles btnTrapezoidal.Click
        'Label displaying the chosen technique in the form.
        frmTechnique.lblTechName.Text = "Trapezoidal Rule"
        frmTechnique.txtTerms.Hide()
        frmTechnique.lblTerms.Hide()
        frmTechnique.lblSubinterval.Show()
        frmTechnique.txtSubinterval.Show()
        Me.Hide()
        frmTechnique.Show()
    End Sub

    'Button subrutine for the Simpson Rule selection.
    Private Sub btnSimpson_Click(sender As Object, e As EventArgs) Handles btnSimpson.Click
        'Label displaying the chosen technique in the form.
        frmTechnique.lblTechName.Text = "Simpson's Rule"
        frmTechnique.txtTerms.Hide()
        frmTechnique.lblTerms.Hide()
        frmTechnique.lblSubinterval.Show()
        frmTechnique.txtSubinterval.Show()
        Me.Hide()
        frmTechnique.Show()
    End Sub

    'Button subrutine for the Taylor polynomial selection.
    Private Sub btnSeries_Click(sender As Object, e As EventArgs) Handles btnTaylor.Click
        'Label displaying the chosen technique in the form.
        frmTechnique.lblTechName.Text = "Series Approximation"
        frmTechnique.lblSubinterval.Hide()
        frmTechnique.txtSubinterval.Hide()
        frmTechnique.txtTerms.Show()
        frmTechnique.lblTerms.Show()

        Me.Hide()
        frmTechnique.Show()
    End Sub

    'Button subrutine for multiple technique selection.
    Private Sub btnMultiple_Click(sender As Object, e As EventArgs) Handles btnMultiple.Click
        frmTechnique.lblTechName.Text = "All Techniques"
        frmTechnique.txtTerms.Show()
        frmTechnique.lblTerms.Show()
        frmTechnique.txtSubinterval.Show()
        frmTechnique.lblSubinterval.Show()

        Me.Hide()
        frmTechnique.Show()
    End Sub

    'Button subrutine for Boole's rule
    Private Sub btnBoole_Click(sender As Object, e As EventArgs) Handles btnBoole.Click
        frmTechnique.lblTechName.Text = "Boole's Rule"
        frmTechnique.txtTerms.Hide()
        frmTechnique.lblTerms.Hide()
        frmTechnique.txtSubinterval.Show()
        frmTechnique.lblSubinterval.Show()
        Me.Hide()
        frmTechnique.Show()
    End Sub

    'Button subrutine for the Simpson's 3/8 rule
    Private Sub btnThreeEight_Click(sender As Object, e As EventArgs) Handles btnThreeEight.Click
        frmTechnique.lblTechName.Text = "Simpson's 3/8 Rule"
        frmTechnique.txtTerms.Hide()
        frmTechnique.lblTerms.Hide()
        frmTechnique.txtSubinterval.Show()
        frmTechnique.lblSubinterval.Show()
        Me.Hide()
        frmTechnique.Show()
    End Sub

    'Button subrutine for the back form action
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmWelcome.Show()
    End Sub

    'Button method for the exit form action
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class