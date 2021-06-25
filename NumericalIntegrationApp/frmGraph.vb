'   Copyright(c) 2017, Luis A. Flores
'   All rights reserved.


' Numerical Integration App (NIA)
' Form: frmTechnique.vb
' by Luis A. Flores
' SICI4038 7/14/2017

'frmGraph.vb
'Class responsible for graphing the selected function.

Public Class frmGraph
    Private pBoxGraph As New PictureBox()
    Private Sub frmGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pBoxGraph.Dock = DockStyle.Fill
        pBoxGraph.BackColor = Color.White
        pBoxGraph.SizeMode = PictureBoxSizeMode.StretchImage

        ' Connect the Paint event of the PictureBox to the event handler method.
        AddHandler pBoxGraph.Paint, AddressOf Me.pBoxGraph_Paint
        ' Add the PictureBox control to the Form.
        Me.Controls.Add(pBoxGraph)
    End Sub


    Private Sub pBoxGraph_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        ' Create a local version of the graphics object for the PictureBox.
        'Parameters needed to paint in the picturebox
        Dim graph As Graphics = e.Graphics
        Dim upperBound As Integer = 20
        Dim lowerBound As Integer = -20
        Dim subintervalLength As Double = 0.5
        Dim count As Integer = 0
        'Points are single data type (possible overflow)
        Dim pnts(80) As PointF

        'Offsets to start graphing in the center
        Dim Xoffset As Single = CSng(pBoxGraph.ClientSize.Width / 2)
        Dim Yoffset As Single = CSng(pBoxGraph.ClientSize.Height / 2)

        'Pens for painting in the picturebox
        Dim blackPen As New Pen(Color.Black, 0.0F)
        Dim bluePen As New Pen(Color.SkyBlue, 0.3F)

        'If-Elseif statements that get the points needed to paint the graph
        If frmTechnique.CboxFunctions.SelectedIndex = 0 Then
            For x As Double = lowerBound To upperBound Step subintervalLength
                pnts(count) = New PointF(CSng(x), CSng(-1 * Math.Pow(x, 2)))
                count += 1
            Next

        ElseIf frmTechnique.CboxFunctions.SelectedIndex = 1 Then
            For x As Double = lowerBound To upperBound Step subintervalLength
                pnts(count) = New PointF(CSng(x), CSng(-1 * (Math.Pow(x, 2) + 1)))
                count += 1
            Next

        ElseIf frmTechnique.CboxFunctions.SelectedIndex = 2 Then
            For x As Double = lowerBound To upperBound Step subintervalLength
                pnts(count) = New PointF(CSng(x), CSng(-1 * Math.Sin(Math.Pow(x, 2))))
                count += 1
            Next

        ElseIf frmTechnique.CboxFunctions.SelectedIndex = 3 Then

            For x As Double = lowerBound To upperBound / 2 Step subintervalLength
                pnts(count) = New PointF(CSng(x), CSng(-1 * Math.Exp(Math.Pow(x, 2))))
                count += 1
            Next



        End If

        Try
            'Showing the graphs' name
            graph.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            If frmTechnique.CboxFunctions.SelectedIndex = 0 Then
                graph.DrawString("Graph:" + vbNewLine + "f(x)=x^2", New Font("Arial", 10), Brushes.Red, New PointF(30.0F, 30.0F))
            ElseIf frmTechnique.CboxFunctions.SelectedIndex = 1 Then
                graph.DrawString("Graph:" + vbNewLine + "f(x)=x^2 + 1", New Font("Arial", 10), Brushes.Red, New PointF(30.0F, 30.0F))
            ElseIf frmTechnique.CboxFunctions.SelectedIndex = 2 Then
                graph.DrawString("Graph:" + vbNewLine + "f(x)=Sin(x^2)", New Font("Arial", 10), Brushes.Red, New PointF(30.0F, 30.0F))
            ElseIf frmTechnique.CboxFunctions.SelectedIndex = 3 Then
                graph.DrawString("Graph:" + vbNewLine + "f(x)=e^(x^2)", New Font("Arial", 10), Brushes.Red, New PointF(30.0F, 30.0F))
            End If

            'Transform the scale (bigger or smaller)
            graph.TranslateTransform(Xoffset, Yoffset)
            graph.ScaleTransform(15, 20)
            'drawing cartesian plane
            graph.DrawLine(blackPen, -300, 0, 300, 0)
            graph.DrawLine(blackPen, 0, -200, 0, 200)
            'Drawing the curve
            graph.DrawCurve(bluePen, pnts)
            graph.ResetTransform()

            'Error message (possible overflow)
        Catch ex As Exception
            Me.Hide()
            MessageBox.Show("Application Error: Values of the function are too big." + vbNewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub 'pictureBox1_Paint

End Class