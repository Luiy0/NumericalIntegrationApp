'   Copyright(c) 2017, Luis A. Flores
'   All rights reserved.

' Numerical Integration App (NIA)
' Form: frmTechnique.vb
' by Luis A. Flores
' SICI4038 7/14/2017


'frmTechnique Class is responsible For calling the numerical integration method selected by the user, 
'passing the validated parameters To the respective numerical technique And displaying the results.

Public Class frmTechnique
    'Variable for displaying the fucntion's graph
    Dim graph As System.Drawing.Graphics
    'Variables related to the runtime of each technique
    Dim stopWatch As New Stopwatch()
    Dim ts As TimeSpan
    Dim elapsedTime As String


    'Button subrutine for the calculate action which starts the process of finding the approximation of the integral's value using the selected technique by the user.
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declaration of several important variables needed for holding the parameters requiered by the Numerical Integration Techniques (NITs)
        Dim upperBound, lowerBound, subintervalLength, midPointInterval, approximation, approxError, exactVal, derivatives(5), errorMax As Double
        Dim numberSubinterval, terms, subdivisions As Integer
        'Clearing the results textBox.
        txtResults.Clear()

        'Try-Catch statement for validating the user's entered parameters.
        Try
            'Converting the user's input data to numerical data
            upperBound = CDbl(txtUpperBound.Text)
            lowerBound = CDbl(txtLowerBound.Text)
            'Technique specific parameters
            If txtSubinterval.Visible = True Then
                numberSubinterval = CInt(txtSubinterval.Text)
                terms = 2
                subdivisions = 2
            ElseIf txtTerms.Visible = True Then
                terms = CInt(txtTerms.Text)
                numberSubinterval = 2
                subdivisions = 2
            End If
        Catch ex As Exception
            'If an error occurs, this message will pop up and alert the user that the default values will be used.
            MessageBox.Show(ex.Message + vbNewLine + "Default values will be used.", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUpperBound.Text = "1"
            upperBound = 1
            txtLowerBound.Text = "-1"
            lowerBound = -1
            txtSubinterval.Text = "2"
            numberSubinterval = 2
            txtTerms.Text = "2"
            terms = 2
        End Try

        'Validating the integral bounds
        If upperBound <= lowerBound Or lowerBound >= upperBound Then
            MessageBox.Show("Wrong interval." + vbNewLine + "Default values will be used.", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUpperBound.Text = "1"
            upperBound = 1
            txtLowerBound.Text = "-1"
            lowerBound = -1
        End If

        'Validating the entered number of subintervals
        If numberSubinterval < 1 Then
            MessageBox.Show("The number of subintervals is too low." + vbNewLine + "Default value of 2 will be used.", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            numberSubinterval = 2
            txtSubinterval.Text = "2"
        End If

        'Validating the entered number of terms for the series approximation
        If terms < 0 Then
            MessageBox.Show("The number of terms is too low." + vbNewLine + "Default value of 2 will be used.", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            terms = 2
            txtTerms.Text = "2"
        End If


        'Calculating the length of each subinterval
        subintervalLength = ((upperBound - lowerBound) / numberSubinterval)
        'Calculating the midpoint of the interval.
        midPointInterval = (upperBound + lowerBound) / 2





        'LEFT RIEMANN SUM DISPLAY OF RESULSTS
        If (String.Compare(lblTechName.Text, "Left Riemann Sum")) = 0 Then
            'Variable for holding the result of the technique. Calling the RiemannLeft function and passing the requiered arguments.
            approximation = RiemannLeft(upperBound, lowerBound, subintervalLength, midPointInterval, derivatives)
            'Variables to find the runtime of the technique.
            ts = stopWatch.Elapsed
            elapsedTime = String.Format("{0:0hr}:{1:0m}:{2:0s}.{3:0ms}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)

            'Displaying the technique data.
            txtResults.Text = "Fuction:" + vbTab + vbTab + vbTab + CboxFunctions.SelectedItem.ToString + vbNewLine +
                              "Interval:" + vbTab + vbTab + vbTab + "[" + lowerBound.ToString + "," + upperBound.ToString + "]" + vbNewLine +
                              "Subintervals:" + vbTab + vbTab + Strings.Format(numberSubinterval, "E") + vbNewLine +
                              "Length (∆x):" + vbTab + vbTab + Strings.Format(subintervalLength, "E") + vbNewLine +
                              "Approximation:" + vbTab + vbTab + Strings.Format(approximation, "E") + vbNewLine +
                              "Runtime:" + vbTab + vbTab + vbTab + elapsedTime + vbNewLine + vbNewLine +
                              "First Derivative:" + vbNewLine +
                              "f '(" + lowerBound.ToString("N3") + ") : " + Strings.Format(derivatives(0), "E") + vbNewLine +
                              "f '(" + midPointInterval.ToString("N3") + ") : " + Strings.Format(derivatives(1), "E") + vbNewLine +
                              "f '(" + upperBound.ToString("N3") + ") : " + Strings.Format(derivatives(2), "E") + vbNewLine + vbNewLine +
                              "Conclusions:" + vbNewLine + "This technique uses the left end point of each subinterval to create a rectanglea under the curve. " + "If the function is increasing on the interval, " +
                              "then the left Riemann sum is an underestimate of the exact value and the right Riemann sum is an overestimate." +
                              "If the function is decreasing on the interval, then the left sum overestimates and the right sum underestimates the exact value." + vbNewLine + vbNewLine +
                              "Note: A higher quantity of subintervals gives a better approximation but requieres more time."



            'RIGHT RIEMANN SUM DISPLAY OF RESULTS
        ElseIf (String.Compare(lblTechName.Text, "Right Riemann Sum")) = 0 Then
            'Variable for holding the result of the technique.
            approximation = RiemannRight(upperBound, lowerBound, subintervalLength, midPointInterval, derivatives)
            'Variables needed to find the runtime of each technique.
            ts = stopWatch.Elapsed
            elapsedTime = String.Format("{0:0hr}:{1:0m}:{2:0s}.{3:0ms}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)

            'Displaying the technique data.
            txtResults.Text = "Fuction:" + vbTab + vbTab + vbTab + CboxFunctions.SelectedItem.ToString + vbNewLine +
                              "Interval:" + vbTab + vbTab + vbTab + "[" + lowerBound.ToString + "," + upperBound.ToString + "]" + vbNewLine +
                              "Subintervals:" + vbTab + vbTab + Strings.Format(numberSubinterval, "E") + vbNewLine +
                              "Length (∆x):" + vbTab + vbTab + Strings.Format(subintervalLength, "E") + vbNewLine +
                              "Approximation:" + vbTab + vbTab + Strings.Format(approximation, "E") + vbNewLine +
                              "Runtime:" + vbTab + vbTab + vbTab + elapsedTime + vbNewLine + vbNewLine +
                              "First Derivative:" + vbNewLine +
                              "f '(" + lowerBound.ToString("N3") + ") : " + Strings.Format(derivatives(0), "E") + vbNewLine +
                              "f '(" + midPointInterval.ToString("N3") + ") : " + Strings.Format(derivatives(1), "E") + vbNewLine +
                              "f '(" + upperBound.ToString("N3") + ") : " + Strings.Format(derivatives(2), "E") + vbNewLine + vbNewLine +
                              "Conclusions:" + vbNewLine + "This technique uses the right end point of each subinterval to create a rectangle under the curve. " + "If the function is increasing on the interval, " +
                              "then the left Riemann sum is an underestimate of the exact value and the right Riemann sum is an overestimate." +
                              "If the function is decreasing on the interval, then the left sum overestimates and the right sum underestimates the exact value." + vbNewLine + vbNewLine +
                              "Note: A higher quantity of subintervals gives a better approximation but requieres more time."

            'MIDPOINT RULE DISPLAY OF RESULTS
        ElseIf (String.Compare(lblTechName.Text, "Midpoint Rule")) = 0 Then
            approximation = Midpoint(upperBound, lowerBound, subintervalLength, numberSubinterval, approxError, midPointInterval, exactVal)
            ts = stopWatch.Elapsed
            elapsedTime = String.Format("{0:0hr}:{1:0m}:{2:0s}.{3:0ms}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)

            'Displaying the technique data.
            txtResults.Text = "Fuction:" + vbTab + vbTab + vbTab + CboxFunctions.SelectedItem.ToString + vbNewLine +
                              "Interval:" + vbTab + vbTab + vbTab + "[" + lowerBound.ToString + "," + upperBound.ToString + "]" + vbNewLine +
                              "Subintervals:" + vbTab + vbTab + Strings.Format(numberSubinterval, "E") + vbNewLine +
                              "Length (∆x):" + vbTab + vbTab + Strings.Format(subintervalLength, "E") + vbNewLine +
                              "Approximation:" + vbTab + vbTab + Strings.Format(approximation, "E") + vbNewLine +
                              "Error Max Bound:" + vbTab + vbTab + Strings.Format(approxError, "E") + vbNewLine +
                              "Possible Exact Value:" + vbTab + Strings.Format(exactVal, "E") + vbNewLine +
                              "Runtime:" + vbTab + vbTab + vbTab + elapsedTime + vbNewLine + vbNewLine +
                              "Conclusions:" + vbNewLine + "This technique uses the midpoint of each subinterval to create a rectangle under the curve. " +
                              "The approximation will be closer to the exact value in comparison to the other Riemann sums given that the midpoints are used. " +
                              "Therefore, the approximation of this technique will be in-between the left and right Riemann sums aproximations." + vbNewLine + vbNewLine +
                              "Note: A higher quantity of subintervals gives a better approximation but requieres more time."

            'TRAPEZOIDAL RULE DISPLAY OF RESULTS
        ElseIf (String.Compare(lblTechName.Text, "Trapezoidal Rule")) = 0 Then
            approximation = Trapezoidal(upperBound, lowerBound, subintervalLength, midPointInterval, derivatives, approxError, exactVal, errorMax, numberSubinterval)
            ts = stopWatch.Elapsed
            elapsedTime = String.Format("{0:0hr}:{1:0m}:{2:0s}.{3:0ms}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)

            Dim absError As Double = Math.Abs(exactVal - approximation)
            Dim relError As Double = Math.Abs(absError / exactVal)
            Dim percError As Double = relError * 100

            'Displaying the technique data.
            txtResults.Text = "Fuction:" + vbTab + vbTab + vbTab + CboxFunctions.SelectedItem.ToString + vbNewLine +
                              "Interval:" + vbTab + vbTab + vbTab + "[" + lowerBound.ToString + "," + upperBound.ToString + "]" + vbNewLine +
                              "Subintervals:" + vbTab + vbTab + Strings.Format(numberSubinterval, "E") + vbNewLine +
                              "Length (∆x):" + vbTab + vbTab + Strings.Format(subintervalLength, "E") + vbNewLine +
                              "Approximation:" + vbTab + vbTab + Strings.Format(approximation, "E") + vbNewLine +
                              "Error:" + vbTab + vbTab + vbTab + Strings.Format(approxError, "E") + vbNewLine +
                              "Error Max Bound:" + vbTab + vbTab + Strings.Format(errorMax, "E") + vbNewLine +
                              "Possible Exact Value:" + vbTab + Strings.Format(exactVal, "E") + vbNewLine +
                              "Relative Error:" + vbTab + vbTab + Strings.Format(relError, "E") + vbNewLine +
                              "Error Percentage:" + vbTab + vbTab + percError.ToString("N3") + "%" + vbNewLine +
                              "Runtime:" + vbTab + vbTab + vbTab + elapsedTime + vbNewLine + vbNewLine +
                              "Second Derivatives:" + vbNewLine +
                              "f ''(" + lowerBound.ToString("N3") + ") : " + Strings.Format(derivatives(0), "E") + vbNewLine +
                              "f ''(" + midPointInterval.ToString("N3") + ") : " + Strings.Format(derivatives(1), "E") + vbNewLine +
                              "f ''(" + upperBound.ToString("N3") + ") : " + Strings.Format(derivatives(2), "E") + vbNewLine + vbNewLine +
                              "Conclusions:" + vbNewLine + "This technique uses trapezoids instead of rectangles to approximate the area under a curve. " +
                              "It follows that if the integrand is concave up (and thus has a positive second derivative), then the error is negative and the trapezoidal rule overestimates the true value. " +
                              "This can also be seen from the geometric picture: the trapezoids include all of the area under the curve and extend over it. Similarly, a concave-down function yields an underestimate " +
                              "because area is unaccounted For under the curve, but none Is counted above. If the interval of the integral being approximated includes an inflection point, the Error Is harder To identify." +
                               vbNewLine + vbNewLine + "Note: A higher quantity of subintervals gives a better approximation but requieres more time. " +
                               "When the function is periodic and one integrates over one full period, there are about as many sections of the graph that are concave up as concave down, so the errors cancel."

            'SIMPSON'S RULE DISPLAY OF RESULTS
        ElseIf (String.Compare(lblTechName.Text, "Simpson's Rule")) = 0 Then
            approximation = CompositeSimpson(upperBound, lowerBound, subintervalLength, numberSubinterval, midPointInterval, approxError, exactVal, errorMax)
            ts = stopWatch.Elapsed
            elapsedTime = String.Format("{0:0hr}:{1:0m}:{2:0s}.{3:0ms}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)

            Dim absError As Double = Math.Abs(exactVal - approximation)
            Dim relError = Math.Abs(absError / exactVal)
            Dim percError = relError * 100

            'Displaying the technique data.
            txtResults.Text = "Fuction:" + vbTab + vbTab + vbTab + CboxFunctions.SelectedItem.ToString + vbNewLine +
                              "Interval:" + vbTab + vbTab + vbTab + "[" + lowerBound.ToString + "," + upperBound.ToString + "]" + vbNewLine +
                              "Subintervals:" + vbTab + vbTab + Strings.Format(numberSubinterval, "E") + vbNewLine +
                              "Length (∆x):" + vbTab + vbTab + Strings.Format(subintervalLength, "E") + vbNewLine +
                              "Approximation:" + vbTab + vbTab + Strings.Format(approximation, "E") + vbNewLine +
                              "Error:" + vbTab + vbTab + vbTab + Strings.Format(approxError, "E") + vbNewLine +
                              "Error Max Bound:" + vbTab + vbTab + Strings.Format(errorMax, "E") + vbNewLine +
                              "Possible Exact Value:" + vbTab + Strings.Format(exactVal, "E") + vbNewLine +
                              "Relative Error:" + vbTab + vbTab + Strings.Format(relError, "E") + vbNewLine +
                              "Error Percentage:" + vbTab + vbTab + percError.ToString("N3") + "%" + vbNewLine +
                              "Runtime:" + vbTab + vbTab + vbTab + elapsedTime + vbNewLine + vbNewLine +
                              "Conclusions:" + vbNewLine + "This technique uses parabolas instead of straight-line segments but the number of subintervals must be even. " +
                              "Simpson's rule provides exact results for any polynomial of degree three or less, since the fourth derivative of such a polynomial is zero at all points." +
                              vbNewLine + vbNewLine + "Note: A higher quantity of subintervals gives a better approximation but requieres more time."


            'SERIES APPROXIMATION TECHNIQUE DISPLAY OF RESULTS
        ElseIf (String.Compare(lblTechName.Text, "Series Approximation")) = 0 Then
            approximation = Series(upperBound, lowerBound, midPointInterval, terms, approxError, exactVal)
            ts = stopWatch.Elapsed
            elapsedTime = String.Format("{0:00hr}:{1:00m}:{2:00s}.{3:00ms}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)

            'Display the technique data.
            txtResults.Text = "Fuction:" + vbTab + vbTab + vbTab + CboxFunctions.SelectedItem.ToString + vbNewLine +
                              "Interval:" + vbTab + vbTab + vbTab + "[" + lowerBound.ToString + "," + upperBound.ToString + "]" + vbNewLine +
                              "Approximation:" + vbTab + vbTab + Strings.Format(approximation, "E") + vbNewLine +
                              "Max Error Bound:" + vbTab + vbTab + Strings.Format(approxError, "E") + vbNewLine +
                              "Possible Exact Value:" + vbTab + Strings.Format(exactVal, "E") + vbNewLine +
                              "Runtime:" + vbTab + vbTab + vbTab + elapsedTime + vbNewLine + vbNewLine +
                              "Conclusions:" + "The series approximation uses Taylor polynomials and term by term integration to obtain the result. The higher the number of terms the better the approximation will be." +
                              vbNewLine + vbNewLine + "Note: The taylor seires approximation with " + terms.ToString + " terms."


            'BOOLE'S RULE DISPLAY OF RESULTS
        ElseIf (String.Compare(lblTechName.Text, "Boole's Rule")) = 0 Then
            approximation = Boole(lowerBound, upperBound, approxError, exactVal, midPointInterval, numberSubinterval)
            ts = stopWatch.Elapsed
            elapsedTime = String.Format("{0:00hr}:{1:00m}:{2:00s}.{3:00ms}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)

            Dim absError As Double = Math.Abs(exactVal - approximation)
            Dim relError = Math.Abs(absError / exactVal)
            Dim percError = relError * 100

            'Display the technique data.
            txtResults.Text = "Fuction:" + vbTab + vbTab + vbTab + CboxFunctions.SelectedItem.ToString + vbNewLine +
                              "Interval:" + vbTab + vbTab + vbTab + "[" + lowerBound.ToString + "," + upperBound.ToString + "]" + vbNewLine +
                              "Approximation:" + vbTab + vbTab + Strings.Format(approximation, "E") + vbNewLine +
                              "Approximation Error:" + vbTab + vbTab + Strings.Format(approxError, "E") + vbNewLine +
                              "Possible Exact Value:" + vbTab + Strings.Format(exactVal, "E") + vbNewLine +
                              "Relative Error:" + vbTab + vbTab + Strings.Format(relError, "E") + vbNewLine +
                              "Error Percentage:" + vbTab + vbTab + percError.ToString("N3") + "%" + vbNewLine +
                              "Runtime:" + vbTab + vbTab + vbTab + elapsedTime + vbNewLine + vbNewLine +
                              "Conclusions:" + "Boole's rule approximates an integral by using the values of f at five equally spaced points." +
                              "Having n = 4 means that f(x) can be approximated by a polynomial of 4th degree so that fifth and higher order differences vanish in the general quadrature formula."

            'SIMPSON'S COMPOSITE 3/8 RULE
        ElseIf (String.Compare(lblTechName.Text, "Simpson's 3/8 Rule")) = 0 Then
            approximation = CompositeThreeEight(lowerBound, upperBound, approxError, exactVal, midPointInterval, numberSubinterval)
            ts = stopWatch.Elapsed
            elapsedTime = String.Format("{0:00hr}:{1:00m}:{2:00s}.{3:00ms}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)

            Dim absError As Double = Math.Abs(exactVal - approximation)
            Dim relError = Math.Abs(absError / exactVal)
            Dim percError = relError * 100

            'Display the technique data.
            txtResults.Text = "Fuction:" + vbTab + vbTab + vbTab + CboxFunctions.SelectedItem.ToString + vbNewLine +
                              "Interval:" + vbTab + vbTab + vbTab + "[" + lowerBound.ToString + "," + upperBound.ToString + "]" + vbNewLine +
                              "Approximation:" + vbTab + vbTab + Strings.Format(approximation, "E") + vbNewLine +
                              "Approximation Error:" + vbTab + vbTab + Strings.Format(approxError, "E") + vbNewLine +
                              "Possible Exact Value:" + vbTab + Strings.Format(exactVal, "E") + vbNewLine +
                              "Relative Error:" + vbTab + vbTab + Strings.Format(relError, "E") + vbNewLine +
                              "Error Percentage:" + vbTab + vbTab + percError.ToString("N3") + "%" + vbNewLine +
                              "Runtime:" + vbTab + vbTab + vbTab + elapsedTime + vbNewLine + vbNewLine +
                              "Conclusions:" + "This rule uses four points instead of three like the normal Simpson's rule to calculate the approximation. Similar to to other rules, it's approximation gets better while incrementing the number of subintervals."


            'RESULTS OF ALL THE AVAILABLE TECHNIQUES
        ElseIf (String.Compare(lblTechName.Text, "All Techniques")) = 0 Then

            'Display the technique data.
            txtResults.Text = "Fuction:" + vbTab + vbTab + vbTab + CboxFunctions.SelectedItem.ToString + vbNewLine +
                              "Interval:" + vbTab + vbTab + vbTab + "[" + lowerBound.ToString + "," + upperBound.ToString + "]" + vbNewLine + vbNewLine +
                              "Technique:" + vbTab + vbTab + "Approximation:" + vbNewLine + vbNewLine +
                              "Right Riemann Sum:" + vbTab + vbTab + Strings.Format(RiemannRight(upperBound, lowerBound, subintervalLength, midPointInterval, derivatives), "E") + vbNewLine +
                              "Runtime:" + vbTab + vbTab + vbTab + String.Format("{0:00hr}:{1:00m}:{2:00s}.{3:00ms}", stopWatch.Elapsed.Hours, stopWatch.Elapsed.Minutes, stopWatch.Elapsed.Seconds, stopWatch.Elapsed.Milliseconds / 10) + vbNewLine + vbNewLine +
                              "Left Riemann Sum:" + vbTab + vbTab + Strings.Format(RiemannLeft(upperBound, lowerBound, subintervalLength, midPointInterval, derivatives), "E") + vbNewLine +
                              "Runtime:" + vbTab + vbTab + vbTab + String.Format("{0:00hr}:{1:00m}:{2:00s}.{3:00ms}", stopWatch.Elapsed.Hours, stopWatch.Elapsed.Minutes, stopWatch.Elapsed.Seconds, stopWatch.Elapsed.Milliseconds / 10) + vbNewLine + vbNewLine +
                              "Midpoint Rule:" + vbTab + vbTab + Strings.Format(Midpoint(upperBound, lowerBound, subintervalLength, numberSubinterval, approxError, midPointInterval, exactVal), "E") + vbNewLine +
                              "Runtime:" + vbTab + vbTab + vbTab + String.Format("{0:00hr}:{1:00m}:{2:00s}.{3:00ms}", stopWatch.Elapsed.Hours, stopWatch.Elapsed.Minutes, stopWatch.Elapsed.Seconds, stopWatch.Elapsed.Milliseconds / 10) + vbNewLine + vbNewLine +
                              "Trapeziodal Rule:" + vbTab + vbTab + Strings.Format(Trapezoidal(upperBound, lowerBound, subintervalLength, midPointInterval, derivatives, approxError, exactVal, errorMax, numberSubinterval), "E") + vbNewLine +
                              "Runtime:" + vbTab + vbTab + vbTab + String.Format("{0:00hr}:{1:00m}:{2:00s}.{3:00ms}", stopWatch.Elapsed.Hours, stopWatch.Elapsed.Minutes, stopWatch.Elapsed.Seconds, stopWatch.Elapsed.Milliseconds / 10) + vbNewLine + vbNewLine +
                              "Simpson's Rule:" + vbTab + vbTab + Strings.Format(CompositeSimpson(upperBound, lowerBound, subintervalLength, numberSubinterval, midPointInterval, approxError, exactVal, errorMax), "E") + vbNewLine +
                              "Runtime:" + vbTab + vbTab + vbTab + String.Format("{0:00hr}:{1:00m}:{2:00s}.{3:00ms}", stopWatch.Elapsed.Hours, stopWatch.Elapsed.Minutes, stopWatch.Elapsed.Seconds, stopWatch.Elapsed.Milliseconds / 10) + vbNewLine + vbNewLine +
                              "Simpson's 3/8 Rule:" + vbTab + vbTab + Strings.Format(CompositeThreeEight(lowerBound, upperBound, approxError, exactVal, midPointInterval, numberSubinterval), "E") + vbNewLine +
                              "Runtime:" + vbTab + vbTab + vbTab + String.Format("{0:00hr}:{1:00m}:{2:00s}.{3:00ms}", stopWatch.Elapsed.Hours, stopWatch.Elapsed.Minutes, stopWatch.Elapsed.Seconds, stopWatch.Elapsed.Milliseconds / 10) + vbNewLine + vbNewLine +
                              "Series Approximation:" + vbTab + Strings.Format(Series(upperBound, lowerBound, midPointInterval, terms, approxError, exactVal), "E") + vbNewLine +
                              "Runtime:" + vbTab + vbTab + vbTab + String.Format("{0:00hr}:{1:00m}:{2:00s}.{3:00ms}", stopWatch.Elapsed.Hours, stopWatch.Elapsed.Minutes, stopWatch.Elapsed.Seconds, stopWatch.Elapsed.Milliseconds / 10) + vbNewLine + vbNewLine +
                              "Boole's Rule:" + vbTab + vbTab + Strings.Format(Boole(lowerBound, upperBound, approxError, exactVal, midPointInterval, numberSubinterval), "E") + vbNewLine +
                              "Runtime:" + vbTab + vbTab + vbTab + String.Format("{0:00hr}:{1:00m}:{2:00s}.{3:00ms}", stopWatch.Elapsed.Hours, stopWatch.Elapsed.Minutes, stopWatch.Elapsed.Seconds, stopWatch.Elapsed.Milliseconds / 10) + vbNewLine + vbNewLine

        End If
    End Sub


    'Right Riemann Sum technique
    'This function calculates the approximation of the integral's value using the right Riemann sum technique.
    Public Function RiemannRight(UpperBound As Double, LowerBound As Double, SubintervalLength As Double, midPointInterval As Double, derivatives() As Double) As Double
        'Variable for holding the approximation.
        Dim Sum As Double = 0
        'Variable for holding the function
        Dim func As Func(Of Double, Double)
        'Resseting the stopwatch everytime the technique is used.
        stopWatch.Reset()

        'If - ElseIf statements that determine the appropriate formula to use depending on the function selected by the user.
        If CboxFunctions.SelectedIndex = 0 Then
            'Start the stopwatch to determine runtime.
            stopWatch.Start()
            'For cycle from the integral's lower bound limit to the upper bound limit with a step of the subinterval length value.
            For x As Double = LowerBound + Math.Abs(SubintervalLength) To UpperBound Step Math.Abs(SubintervalLength)
                'Accumulate the right Riemann sum term values to the variable sum in order to determine the approximation.
                Sum += Math.Pow(x, 2) * SubintervalLength
            Next
            'Stop the stopwatch and save the elapsed time.
            stopWatch.Stop()
            'Store the user's selected fuction to calculate the derivatives
            func = Function(x) Math.Pow(x, 2)
            'Calculating the first derivatives and storing them in the corresponding variables. 
            ' Using Math.Net Numerics Library
            derivatives(0) = MathNet.Numerics.Differentiate.Derivative(func, UpperBound, 1)
            derivatives(1) = MathNet.Numerics.Differentiate.Derivative(func, LowerBound, 1)
            derivatives(2) = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 1)

            'User's selected function
        ElseIf CboxFunctions.SelectedIndex = 1 Then
            stopWatch.Start()
            For x As Double = LowerBound + Math.Abs(SubintervalLength) To UpperBound Step Math.Abs(SubintervalLength)
                Sum += (Math.Pow(x, 2) + 1) * SubintervalLength
            Next
            stopWatch.Stop()

            func = Function(x) Math.Pow(x, 2) + 1
            derivatives(0) = MathNet.Numerics.Differentiate.Derivative(func, UpperBound, 1)
            derivatives(1) = MathNet.Numerics.Differentiate.Derivative(func, LowerBound, 1)
            derivatives(2) = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 1)

        ElseIf CboxFunctions.SelectedIndex = 2 Then
            stopWatch.Start()
            For x As Double = LowerBound + Math.Abs(SubintervalLength) To UpperBound Step Math.Abs(SubintervalLength)
                Sum += Math.Sin(Math.Pow(x, 2)) * SubintervalLength
            Next
            stopWatch.Stop()

            func = Function(x) Math.Sin(Math.Pow(x, 2))
            derivatives(0) = MathNet.Numerics.Differentiate.Derivative(func, UpperBound, 1)
            derivatives(1) = MathNet.Numerics.Differentiate.Derivative(func, LowerBound, 1)
            derivatives(2) = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 1)

        ElseIf CboxFunctions.SelectedIndex = 3 Then
            stopWatch.Start()
            For x As Double = LowerBound + Math.Abs(SubintervalLength) To UpperBound Step Math.Abs(SubintervalLength)
                Sum += Math.Exp(Math.Pow(x, 2)) * SubintervalLength
            Next
            stopWatch.Stop()

            func = Function(x) Math.Exp(Math.Pow(x, 2))
            derivatives(0) = MathNet.Numerics.Differentiate.Derivative(func, UpperBound, 1)
            derivatives(1) = MathNet.Numerics.Differentiate.Derivative(func, LowerBound, 1)
            derivatives(2) = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 1)

        End If

        Return Sum
    End Function

    'Left Riemann Sum technique
    'This function calculates the approximation of the integral's value using the left Riemann sum technique.
    Public Function RiemannLeft(UpperBound As Double, LowerBound As Double, SubintervalLength As Double, midPointInterval As Double, derivatives() As Double) As Double
        Dim Sum As Double = 0
        Dim func As Func(Of Double, Double)
        stopWatch.Reset()

        'The only diffeerence between this technique and the right Riemann sum is that this one takes the left subinterval value
        If CboxFunctions.SelectedIndex = 0 Then
            stopWatch.Start()
            'For cycle from the lowerBound to the last subinterval left side point. 
            'Increments are the subinterval length magnitude.
            For x As Double = LowerBound To UpperBound - Math.Abs(SubintervalLength) Step Math.Abs(SubintervalLength)
                Sum += Math.Pow(x, 2) * SubintervalLength
            Next
            stopWatch.Stop()
            'Calculating derivatives
            func = Function(x) Math.Pow(x, 2)
            derivatives(0) = MathNet.Numerics.Differentiate.Derivative(func, UpperBound, 1)
            derivatives(1) = MathNet.Numerics.Differentiate.Derivative(func, LowerBound, 1)
            derivatives(2) = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 1)

        ElseIf CboxFunctions.SelectedIndex = 1 Then
            stopWatch.Start()
            For x As Double = LowerBound To UpperBound - Math.Abs(SubintervalLength) Step Math.Abs(SubintervalLength)
                Sum += (Math.Pow(x, 2) + 1) * SubintervalLength
            Next
            stopWatch.Stop()

            func = Function(x) Math.Pow(x, 2) + 1
            derivatives(0) = MathNet.Numerics.Differentiate.Derivative(func, UpperBound, 1)
            derivatives(1) = MathNet.Numerics.Differentiate.Derivative(func, LowerBound, 1)
            derivatives(2) = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 1)

        ElseIf CboxFunctions.SelectedIndex = 2 Then
            stopWatch.Start()
            For x As Double = LowerBound To UpperBound - Math.Abs(SubintervalLength) Step Math.Abs(SubintervalLength)
                Sum += Math.Sin(Math.Pow(x, 2)) * SubintervalLength
            Next
            stopWatch.Stop()

            func = Function(x) Math.Sin(Math.Pow(x, 2))
            derivatives(0) = MathNet.Numerics.Differentiate.Derivative(func, UpperBound, 1)
            derivatives(1) = MathNet.Numerics.Differentiate.Derivative(func, LowerBound, 1)
            derivatives(2) = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 1)

        ElseIf CboxFunctions.SelectedIndex = 3 Then
            stopWatch.Start()
            For x As Double = LowerBound To UpperBound - Math.Abs(SubintervalLength) Step Math.Abs(SubintervalLength)
                Sum += Math.Exp(Math.Pow(x, 2)) * SubintervalLength
            Next
            stopWatch.Stop()

            func = Function(x) Math.Exp(Math.Pow(x, 2))
            derivatives(0) = MathNet.Numerics.Differentiate.Derivative(func, UpperBound, 1)
            derivatives(1) = MathNet.Numerics.Differentiate.Derivative(func, LowerBound, 1)
            derivatives(2) = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 1)

        End If

        Return Sum
    End Function

    'Midpoint rule technique
    'This function calculates the approximation of the integral's value using the midpoint ruel technique.
    Public Function Midpoint(UpperBound As Double, LowerBound As Double, SubintervalLength As Double, numberSubinterval As Double, ByRef approxError As Double, midPointInterval As Double, ByRef exactVal As Double) As Double
        Dim Sum As Double = 0
        Dim func As Func(Of Double, Double)
        'Variables for holding the midpoint of each subinterval and the second derivative evaluated at the midPoint of the interval
        Dim subIntervalMid, secondDerivative As Double
        stopWatch.Reset()

        stopWatch.Start()
        If CboxFunctions.SelectedIndex = 0 Then
            'This technique requieres to find the subinterval midpoint of each subinterval and evaluate the function at that point.
            For x As Double = LowerBound To UpperBound - Math.Abs(SubintervalLength) Step Math.Abs(SubintervalLength)
                subIntervalMid = (x + (x + SubintervalLength)) / 2
                Sum += Math.Pow(subIntervalMid, 2) * SubintervalLength
            Next

            'Calculating derivatives and error utilizing mathematical formula.
            func = Function(x) Math.Pow(x, 2)
            secondDerivative = Math.Abs(MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 2))
            approxError = Math.Abs(secondDerivative * (Math.Pow(UpperBound - LowerBound, 3)) / (24 * Math.Pow(numberSubinterval, 2)))
            exactVal = Sum - approxError

        ElseIf CboxFunctions.SelectedIndex = 1 Then
            For x As Double = LowerBound To UpperBound - Math.Abs(SubintervalLength) Step Math.Abs(SubintervalLength)
                subIntervalMid = (x + (x + SubintervalLength)) / 2
                Sum += (Math.Pow(subIntervalMid, 2) + 1) * SubintervalLength
            Next


            func = Function(x) Math.Pow(x, 2) + 1
            secondDerivative = Math.Abs(MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 2))
            approxError = Math.Abs(secondDerivative * (Math.Pow(UpperBound - LowerBound, 3)) / (24 * Math.Pow(numberSubinterval, 2)))
            exactVal = Sum - approxError

        ElseIf CboxFunctions.SelectedIndex = 2 Then
            For x As Double = LowerBound To UpperBound - Math.Abs(SubintervalLength) Step Math.Abs(SubintervalLength)
                subIntervalMid = (x + (x + SubintervalLength)) / 2
                Sum += Math.Sin(Math.Pow(subIntervalMid, 2)) * SubintervalLength
            Next

            func = Function(x) Math.Sin(Math.Pow(x, 2))
            secondDerivative = Math.Abs(MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 2))
            approxError = Math.Abs(secondDerivative * (Math.Pow(UpperBound - LowerBound, 3)) / (24 * Math.Pow(numberSubinterval, 2)))
            exactVal = Sum - approxError

        ElseIf CboxFunctions.SelectedIndex = 3 Then
            For x As Double = LowerBound To UpperBound - Math.Abs(SubintervalLength) Step Math.Abs(SubintervalLength)
                subIntervalMid = (x + (x + SubintervalLength)) / 2
                Sum += Math.Exp(Math.Pow(x, 2)) * SubintervalLength
            Next

            func = Function(x) Math.Exp(Math.Pow(x, 2))
            secondDerivative = Math.Abs(MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 2))
            approxError = Math.Abs(secondDerivative * (Math.Pow(UpperBound - LowerBound, 3)) / (24 * Math.Pow(numberSubinterval, 2)))
            exactVal = Sum - approxError

        End If

        stopWatch.Stop()
        Return Sum
    End Function

    'Multiple Segment / Composite Trapezoidal rule technique (n=1 for elementary formula having one subinterval)
    'This function calculates the approximation of the integral's value using the trapezium rule technique.
    Public Function Trapezoidal(UpperBound As Double, LowerBound As Double, SubintervalLength As Double, midPointInterval As Double, ByRef derivatives() As Double, ByRef approxError As Double, ByRef exactVal As Double,
                                ByRef errorMax As Double, numberSubinterval As Integer) As Double

        Dim TApprox As Double = 0
        Dim func As Func(Of Double, Double)
        stopWatch.Reset()

        stopWatch.Start()
        'If selected function has index 0 then do this.
        If CboxFunctions.SelectedIndex = 0 Then
            'From lower bound to upperbound with step given by the length of each subinterval
            For x As Double = LowerBound To UpperBound Step Math.Abs(SubintervalLength)
                'The mathematical formula states that the first and last evaluations are not multiplied by two
                If x = LowerBound Or x = UpperBound Then
                    TApprox += Math.Pow(x, 2) * SubintervalLength / 2
                Else
                    TApprox += (2 * Math.Pow(x, 2) * (SubintervalLength / 2))
                End If
            Next

            'Calculating derivatives and error, estimating an exact value using mathematical formula.
            func = Function(x) Math.Pow(x, 2)
            derivatives(0) = MathNet.Numerics.Differentiate.Derivative(func, UpperBound, 2)
            derivatives(1) = MathNet.Numerics.Differentiate.Derivative(func, LowerBound, 2)
            derivatives(2) = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 2)
            'Error computation given by mathematical formula.
            'The exact value is not exact, it is the possible exact value and it is used to calculate the relative error.
            'Errormax holds the max bound of the error.
            approxError = Math.Abs(((UpperBound - LowerBound) / 12) * derivatives(2) * Math.Pow(SubintervalLength, 2))
            errorMax = derivatives(2) * (Math.Pow(UpperBound - LowerBound, 3) / 12 * Math.Pow(numberSubinterval, 2))
            exactVal = TApprox - approxError


        ElseIf CboxFunctions.SelectedIndex = 1 Then
            For x As Double = LowerBound To UpperBound Step Math.Abs(SubintervalLength)
                If x = LowerBound Or x = UpperBound Then
                    TApprox += (Math.Pow(x, 2) + 1) * SubintervalLength / 2
                Else
                    TApprox += (2 * (Math.Pow(x, 2) + 1) * (SubintervalLength / 2))
                End If
            Next

            func = Function(x) Math.Pow(x, 2) + 1
            derivatives(0) = MathNet.Numerics.Differentiate.Derivative(func, UpperBound, 2)
            derivatives(1) = MathNet.Numerics.Differentiate.Derivative(func, LowerBound, 2)
            derivatives(2) = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 2)
            approxError = Math.Abs(((UpperBound - LowerBound) / 12) * derivatives(2) * Math.Pow(SubintervalLength, 2))
            errorMax = derivatives(2) * (Math.Pow(UpperBound - LowerBound, 3) / 12 * Math.Pow(numberSubinterval, 2))
            exactVal = TApprox - approxError

        ElseIf CboxFunctions.SelectedIndex = 2 Then

            For x As Double = LowerBound To UpperBound Step Math.Abs(SubintervalLength)
                If x = LowerBound Or x = UpperBound Then
                    TApprox += Math.Sin(Math.Pow(x, 2)) * SubintervalLength / 2
                Else
                    TApprox += ((2 * Math.Sin(Math.Pow(x, 2))) * (SubintervalLength / 2))
                End If
            Next

            func = Function(x) Math.Sin(Math.Pow(x, 2))
            derivatives(0) = MathNet.Numerics.Differentiate.Derivative(func, UpperBound, 2)
            derivatives(1) = MathNet.Numerics.Differentiate.Derivative(func, LowerBound, 2)
            derivatives(2) = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 2)
            approxError = Math.Abs(((UpperBound - LowerBound) / 12) * derivatives(2) * Math.Pow(SubintervalLength, 2))
            errorMax = derivatives(2) * (Math.Pow(UpperBound - LowerBound, 3) / 12 * Math.Pow(numberSubinterval, 2))
            exactVal = TApprox - approxError

        ElseIf CboxFunctions.SelectedIndex = 3 Then

            For x As Double = LowerBound To UpperBound Step Math.Abs(SubintervalLength)
                If x = LowerBound Or x = UpperBound Then
                    TApprox += Math.Exp(Math.Pow(x, 2)) * SubintervalLength / 2
                Else
                    TApprox += ((2 * Math.Exp(Math.Pow(x, 2))) * (SubintervalLength / 2))
                End If
            Next

            func = Function(x) Math.Exp(Math.Pow(x, 2))
            derivatives(0) = MathNet.Numerics.Differentiate.Derivative(func, UpperBound, 2)
            derivatives(1) = MathNet.Numerics.Differentiate.Derivative(func, LowerBound, 2)
            derivatives(2) = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 2)
            approxError = Math.Abs(((UpperBound - LowerBound) / 12) * derivatives(2) * Math.Pow(SubintervalLength, 2))
            errorMax = derivatives(2) * (Math.Pow(UpperBound - LowerBound, 3) / 12 * Math.Pow(numberSubinterval, 2))
            exactVal = TApprox - approxError

        End If

        stopWatch.Stop()
        Return TApprox
    End Function

    'Multiple Segment / Composite Simpson's rule technnique (n=2 for 1/3 rule)
    'This function calculates the approximation of the integral's value using the Simpson's rule technique.
    Public Function CompositeSimpson(UpperBound As Double, LowerBound As Double, SubintervalLength As Double, numberSubinterval As Integer, midPointInterval As Double, ByRef approxError As Double,
                            ByRef exactVal As Double, ByRef errorMax As Double) As Double

        'The counter variable is used for knowing when we are at the lowerbound and upperbound
        Dim counter As Integer = 0
        Dim func As Func(Of Double, Double)
        Dim fourthDerivative As Double
        Dim SApprox As Double = 0
        stopWatch.Reset()

        stopWatch.Start()
        'Selection of function
        If CboxFunctions.SelectedIndex = 0 Then
            'Calculating the approximation using the mathematical formula
            For x As Double = LowerBound To UpperBound Step Math.Abs(SubintervalLength)
                If counter = 0 Or counter = numberSubinterval Then
                    SApprox += Math.Pow(x, 2) * (SubintervalLength / 3)
                ElseIf counter Mod 2 = 0 Then
                    SApprox += 2 * Math.Pow(x, 2) * (SubintervalLength / 3)
                Else
                    SApprox += 4 * Math.Pow(x, 2) * (SubintervalLength / 3)
                End If
                counter += 1
            Next

            'Calculating derivatives needed for error analysis
            func = Function(x) Math.Pow(x, 2)
            fourthDerivative = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 4)
            'Error computation
            approxError = Math.Abs(((UpperBound - LowerBound) / 180) * fourthDerivative * Math.Pow(SubintervalLength, 4))
            errorMax = fourthDerivative * (Math.Pow(UpperBound - LowerBound, 5) / 180 * Math.Pow(numberSubinterval, 4))
            exactVal = SApprox - approxError

        ElseIf CboxFunctions.SelectedIndex = 1 Then
            For x As Double = LowerBound To UpperBound Step Math.Abs(SubintervalLength)
                If counter = 0 Or counter = numberSubinterval Then
                    SApprox += (Math.Pow(x, 2) + 1) * (SubintervalLength / 3)
                ElseIf counter Mod 2 = 0 Then
                    SApprox += 2 * (Math.Pow(x, 2) + 1) * (SubintervalLength / 3)
                Else
                    SApprox += 4 * (Math.Pow(x, 2) + 1) * (SubintervalLength / 3)
                End If
                counter += 1
            Next

            func = Function(x) Math.Pow(x, 2) + 1
            fourthDerivative = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 4)
            approxError = Math.Abs(((UpperBound - LowerBound) / 180) * fourthDerivative * Math.Pow(SubintervalLength, 4))
            errorMax = fourthDerivative * (Math.Pow(UpperBound - LowerBound, 5) / 180 * Math.Pow(numberSubinterval, 4))
            exactVal = SApprox - approxError

        ElseIf CboxFunctions.SelectedIndex = 2 Then
            For x As Double = LowerBound To UpperBound Step Math.Abs(SubintervalLength)
                If counter = 0 Or counter = numberSubinterval Then
                    SApprox += Math.Sin(Math.Pow(x, 2)) * (SubintervalLength / 3)
                ElseIf counter Mod 2 = 0 Then
                    SApprox += 2 * Math.Sin(Math.Pow(x, 2)) * (SubintervalLength / 3)
                Else
                    SApprox += 4 * Math.Sin(Math.Pow(x, 2)) * (SubintervalLength / 3)
                End If
                counter += 1
            Next

            func = Function(x) Math.Sin(Math.Pow(x, 2))
            fourthDerivative = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 4)
            approxError = Math.Abs(((UpperBound - LowerBound) / 180) * fourthDerivative * Math.Pow(SubintervalLength, 4))
            errorMax = fourthDerivative * (Math.Pow(UpperBound - LowerBound, 5) / 180 * Math.Pow(numberSubinterval, 4))
            exactVal = SApprox - approxError

        ElseIf CboxFunctions.SelectedIndex = 3 Then
            For x As Double = LowerBound To UpperBound Step Math.Abs(SubintervalLength)
                If counter = 0 Or counter = numberSubinterval Then
                    SApprox += Math.Exp(Math.Pow(x, 2)) * (SubintervalLength / 3)
                ElseIf counter Mod 2 = 0 Then
                    SApprox += 2 * Math.Exp(Math.Pow(x, 2)) * (SubintervalLength / 3)
                Else
                    SApprox += 4 * Math.Exp(Math.Pow(x, 2)) * (SubintervalLength / 3)
                End If
                counter += 1
            Next

            func = Function(x) Math.Exp(Math.Pow(x, 2))
            fourthDerivative = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 4)
            approxError = Math.Abs(((UpperBound - LowerBound) / 180) * fourthDerivative * Math.Pow(SubintervalLength, 4))
            errorMax = fourthDerivative * (Math.Pow(UpperBound - LowerBound, 5) / 180 * Math.Pow(numberSubinterval, 4))
            exactVal = SApprox - approxError

        End If

        stopWatch.Stop()
        Return SApprox
    End Function

    'Taylor series approximation using term by term integration
    'The terms are specified by the user and the approximation is found using term by term integration.
    Public Function Series(UpperBound As Double, LowerBound As Double, midPointInterval As Double, terms As Integer, ByRef approxError As Double, ByRef exactVal As Double) As Double
        'Array for holding the values of the terms once they have been integrated
        Dim sum(terms) As Double
        Dim approximation As Double = 0
        Dim func As Func(Of Double, Double)
        stopWatch.Reset()

        stopWatch.Start()
        If CboxFunctions.SelectedIndex = 0 Then
            'func holds the function
            func = Function(x) Math.Pow(x, 2)
            'This line cannot be inside the for cycle becuase the Math.Net Numerics Derivative method starts calculating derivatives of order 1
            approximation = MathNet.Numerics.Integrate.OnClosedInterval(Function(x) (Math.Pow(midPointInterval, 2) * Math.Pow(x - midPointInterval, 0)) / factorial(0), LowerBound, UpperBound)

            For n As Integer = 1 To terms - 1 Step 1
                'Calculate the derivative, evaluate the polynomial term in the midpoint of the interval, and then integrate the term.
                sum(n) = MathNet.Numerics.Integrate.OnClosedInterval(Function(x) (MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, n) * Math.Pow(x - midPointInterval, n)) / factorial(n), LowerBound, UpperBound)
                'Holds the sum of integrated terms. Yields the approximation of the antiderivative value
                approximation += sum(n)
            Next

            'Reminder theorem error
            approxError = Math.Abs((Math.Pow(UpperBound, 2) * Math.Pow(midPointInterval - LowerBound, terms + 1)) / factorial(terms + 1))
            exactVal = approximation - approxError


        ElseIf CboxFunctions.SelectedIndex = 1 Then
            func = Function(x) Math.Pow(x, 2) + 1
            approximation = MathNet.Numerics.Integrate.OnClosedInterval(Function(x) ((Math.Pow(midPointInterval, 2) + 1) * Math.Pow(x - midPointInterval, 0)) / factorial(0), LowerBound, UpperBound)

            For n As Integer = 1 To terms - 1 Step 1
                sum(n) = MathNet.Numerics.Integrate.OnClosedInterval(Function(x) (MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, n) * Math.Pow(x - midPointInterval, n)) / factorial(n), LowerBound, UpperBound)
                approximation += sum(n)
            Next

            approxError = Math.Abs((Math.Pow(UpperBound, 2) + 1 * Math.Pow(midPointInterval - LowerBound, terms + 1)) / factorial(terms + 1))
            exactVal = approximation - approxError

        ElseIf CboxFunctions.SelectedIndex = 2 Then
            For n As Integer = 0 To terms Step 1
                'Using the series expansion for sin(x) and term by term integration
                sum(n) = MathNet.Numerics.Integrate.OnClosedInterval(Function(x) (Math.Pow(-1, n) * Math.Pow(x, 4 * n + 2)) / factorial(2 * n + 1), LowerBound, UpperBound)
                approximation += sum(n)
            Next

            approxError = Math.Abs((Math.Sin(Math.Pow(UpperBound, 2)) * Math.Pow(midPointInterval - LowerBound, terms + 1)) / factorial(terms + 1))
            exactVal = approximation - approxError

        ElseIf CboxFunctions.SelectedIndex = 3 Then
            For n As Integer = 0 To terms Step 1
                'Using the series expansion for e^x and term by term integration
                sum(n) = MathNet.Numerics.Integrate.OnClosedInterval(Function(x) (Math.Pow(x, 2 * n)) / factorial(n), LowerBound, UpperBound)
                approximation += sum(n)
            Next

            approxError = Math.Abs((Math.Exp(Math.Pow(UpperBound, 2)) * Math.Pow(midPointInterval - LowerBound, terms + 1)) / factorial(terms + 1))
            exactVal = approximation - approxError

        End If

        Return approximation
    End Function

    'Composite Boole's Rule
    Public Function Boole(lowerBound As Double, upperBound As Double, ByRef approxError As Double, ByRef exactVal As Double, midPointInterval As Double, numberSubintervals As Integer) As Double
        'Calculating the length of the subintervals
        Dim h As Double = (upperBound - lowerBound) / (4 * numberSubintervals)
        'array for holding the values of x sub k. The array is of size 4*number of subintervals because the mathematical formula
        Dim x(4 * numberSubintervals) As Double
        Dim func As Func(Of Double, Double)
        Dim sixthDerivative As Double
        Dim bApprox As Double = 0
        stopWatch.Reset()

        stopWatch.Start()
        'Calculating the subinterval points where the function will be evaluated
        For j As Integer = 0 To 4 * numberSubintervals Step 1
            x(j) = lowerBound + j * h
        Next

        If CboxFunctions.SelectedIndex = 0 Then
            For j As Integer = 1 To numberSubintervals Step 1
                'Formula is created from the mathematical theory, selecting 5 points and evaluating them.
                bApprox += (2 * h / 45) * (7 * Math.Pow(x(4 * j - 4), 2) + 32 * Math.Pow(x(4 * j - 3), 2) + 12 * Math.Pow(x(4 * j - 2), 2) + 32 * Math.Pow(x(4 * j - 1), 2) + 7 * Math.Pow(x(4 * j), 2))
            Next
            'storing the function to calculate its derivative
            func = Function(y) Math.Pow(y, 2)
            sixthDerivative = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 6)
            'Error computation 
            approxError = Math.Abs(((2 * (upperBound - lowerBound) * sixthDerivative) / 945) * Math.Pow(h, 6))
            exactVal = bApprox - approxError

        ElseIf CboxFunctions.SelectedIndex = 1 Then
            For j As Integer = 1 To numberSubintervals Step 1
                bApprox += (2 * h / 45) * (7 * (Math.Pow(x(4 * j - 4), 2) + 1) + 32 * (Math.Pow(x(4 * j - 3), 2) + 1) + 12 * (Math.Pow(x(4 * j - 2), 2) + 1) + 32 * (Math.Pow(x(4 * j - 1), 2) + 1) + 7 * (Math.Pow(x(4 * j), 2)) + 1)
            Next
            func = Function(y) Math.Pow(y, 2) + 1
            sixthDerivative = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 6)
            approxError = Math.Abs(((2 * (upperBound - lowerBound) * sixthDerivative) / 945) * Math.Pow(h, 6))
            exactVal = bApprox - approxError

        ElseIf CboxFunctions.SelectedIndex = 2 Then
            For j As Integer = 1 To numberSubintervals Step 1
                bApprox += (2 * h / 45) * (7 * Math.Sin(Math.Pow(x(4 * j - 4), 2)) + 32 * Math.Sin(Math.Pow(x(4 * j - 3), 2)) + 12 * Math.Sin(Math.Pow(x(4 * j - 2), 2)) + 32 * Math.Sin(Math.Pow(x(4 * j - 1), 2)) + 7 * Math.Sin(Math.Pow(x(4 * j), 2)))
            Next
            func = Function(y) Math.Sin(Math.Pow(y, 2))
            sixthDerivative = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 6)
            approxError = Math.Abs(((2 * (upperBound - lowerBound) * sixthDerivative) / 945) * Math.Pow(h, 6))
            exactVal = bApprox - approxError

        ElseIf CboxFunctions.SelectedIndex = 3 Then
            For j As Integer = 1 To numberSubintervals Step 1
                bApprox += (2 * h / 45) * (7 * Math.Exp(Math.Pow(x(4 * j - 4), 2)) + 32 * Math.Exp(Math.Pow(x(4 * j - 3), 2)) + 12 * Math.Exp(Math.Pow(x(4 * j - 2), 2)) + 32 * Math.Exp(Math.Pow(x(4 * j - 1), 2)) + 7 * Math.Exp(Math.Pow(x(4 * j), 2)))
            Next
            func = Function(y) Math.Exp(Math.Pow(y, 2))
            sixthDerivative = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 6)
            approxError = Math.Abs(((2 * (upperBound - lowerBound) * sixthDerivative) / 945) * Math.Pow(h, 6))
            exactVal = bApprox - approxError

        End If

        stopWatch.Stop()
        Return bApprox
    End Function

    'Composite Simpson's 3/8 Rule
    Public Function CompositeThreeEight(lowerBound As Double, upperBound As Double, ByRef approxError As Double, ByRef exactVal As Double, midPointInterval As Double, numberSubintervals As Integer) As Double
        'Similar to Boole's rule using four points instead of five.
        'h holds the subinterval length
        Dim h As Double = (upperBound - lowerBound) / (3 * numberSubintervals)
        'Array for holding the values of x
        Dim x(3 * numberSubintervals) As Double
        Dim func As Func(Of Double, Double)
        Dim fourthDerivative As Double
        Dim Approx As Double = 0
        stopWatch.Reset()

        stopWatch.Start()
        'Calculating the x values on the subintervals that the function will be evaluated on
        For j As Integer = 0 To 3 * numberSubintervals Step 1
            x(j) = lowerBound + j * h
        Next

        If CboxFunctions.SelectedIndex = 0 Then
            For j As Integer = 1 To numberSubintervals Step 1
                'Translated from the mathematical sumation formula
                Approx += (3 * h / 8) * (Math.Pow(x(3 * j - 3), 2) + 3 * Math.Pow(x(3 * j - 2), 2) + 3 * Math.Pow(x(3 * j - 1), 2) + Math.Pow(x(3 * j), 2))
            Next
            func = Function(y) Math.Pow(y, 2)
            fourthDerivative = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 4)
            'Calculating error
            approxError = Math.Abs((((upperBound - lowerBound) * fourthDerivative) / 80) * Math.Pow(h, 4))
            exactVal = Approx - approxError

        ElseIf CboxFunctions.SelectedIndex = 1 Then
            For j As Integer = 1 To numberSubintervals Step 1
                Approx += (3 * h / 8) * ((Math.Pow(x(3 * j - 3), 2) + 1) + 3 * (Math.Pow(x(3 * j - 2), 2) + 1) + 3 * (Math.Pow(x(3 * j - 1), 2) + 1) + (Math.Pow(x(3 * j), 2) + 1))
            Next
            func = Function(y) Math.Pow(y, 2) + 1
            fourthDerivative = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 4)
            approxError = Math.Abs((((upperBound - lowerBound) * fourthDerivative) / 80) * Math.Pow(h, 4))
            exactVal = Approx - approxError

        ElseIf CboxFunctions.SelectedIndex = 2 Then
            For j As Integer = 1 To numberSubintervals Step 1
                Approx += (3 * h / 8) * (Math.Sin(Math.Pow(x(3 * j - 3), 2)) + 3 * Math.Sin(Math.Pow(x(3 * j - 2), 2)) + 3 * Math.Sin(Math.Pow(x(3 * j - 1), 2)) + Math.Sin(Math.Pow(x(3 * j), 2)))
            Next
            func = Function(y) Math.Sin(Math.Pow(y, 2))
            fourthDerivative = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 4)
            approxError = Math.Abs((((upperBound - lowerBound) * fourthDerivative) / 80) * Math.Pow(h, 4))
            exactVal = Approx - approxError

        ElseIf CboxFunctions.SelectedIndex = 3 Then
            For j As Integer = 1 To numberSubintervals Step 1
                Approx += (3 * h / 8) * (Math.Exp(Math.Pow(x(3 * j - 3), 2)) + 3 * Math.Exp(Math.Pow(x(3 * j - 2), 2)) + 3 * Math.Exp(Math.Pow(x(3 * j - 1), 2)) + Math.Exp(Math.Pow(x(3 * j), 2)))
            Next
            func = Function(y) Math.Exp(Math.Pow(y, 2))
            fourthDerivative = MathNet.Numerics.Differentiate.Derivative(func, midPointInterval, 4)
            approxError = Math.Abs((((upperBound - lowerBound) * fourthDerivative) / 80) * Math.Pow(h, 4))
            exactVal = Approx - approxError

        End If

        stopWatch.Stop()
        Return Approx
    End Function

    'Function for calculating the factorial of a given number
    Public Function factorial(n As Integer) As Double
        If n = 0 Then
            Return 1
        Else
            Return n * factorial(n - 1)
        End If
    End Function

    'Button subrutine for the back action
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        txtUpperBound.Clear()
        txtLowerBound.Clear()
        txtSubinterval.Clear()
        txtResults.Clear()
        CboxFunctions.SelectedIndex = -1
        Me.Close()
        frmMenu.Show()
    End Sub

    'Clear button subrutine for clearing the form's contents
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUpperBound.Clear()
        txtLowerBound.Clear()
        txtSubinterval.Clear()
        txtTerms.Clear()
        txtResults.Clear()
        CboxFunctions.SelectedIndex = -1
        frmGraph.Hide()

    End Sub

    'Graph button subrutinte for graphing the function
    Public Sub btnGraph_Click(sender As Object, e As EventArgs) Handles btnGraph.Click
        frmGraph.Show()
    End Sub

    Private Sub frmTechnique_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class