'Name: Ashok Sasitharan 100745484
'Date: January 21 2020
'FileName : ASasitharan_Lab1
'Changes: N/A



Option Strict On
Public Class averageUnitsShipped

    '************************************************************************GLOBAL VARIABLES************************************************************************
    Dim dayCounter As Integer = 1
    Dim unitSum As Double = 0.0
    Dim unitAverage As Double = 0.0
    '************************************************************************GLOBAL VARIABLES************************************************************************
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUnits.TextChanged

    End Sub



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the application
        Me.Close()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'reset day counter back to 1
        dayCounter = 1

        'resets input display to blank
        txtInputDisplay.Clear()

        'resets output label text t0 blank
        lblOutput.Text = ""

        'resets input textbox to blank
        txtUnits.Clear()

        'resets day back to day 1
        lblDays.Text = "Day " & dayCounter

        'reset average back to 0
        unitAverage = 0.0

        'set enter button back to enabled
        btnEnter.Enabled = True

        'set read only to false on input text box
        txtUnits.ReadOnly = False

        'set textbox color back to white
        txtUnits.BackColor = Color.White
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'decalare temp input variable
        Dim unitInput As Integer

        'resets output label to blank
        lblOutput.Text = ""

        'run is user input is numeric and parse the input
        If Integer.TryParse(txtUnits.Text, result:=unitInput) Then

            'run if user input is within 0 and 5000
            If unitInput >= 0 And unitInput <= 5000 Then

                'display user input 
                txtInputDisplay.Text &= unitInput.ToString("") & Environment.NewLine

                'change day
                lblDays.Text = "Day " & dayCounter.ToString("")

                'add input to total units sum
                unitSum += unitInput

                'increment counter up by 1
                dayCounter += 1

                'set focus back on to input textbox
                txtUnits.Select()

                'clear the input textbox
                txtUnits.Clear()


                'run if user input is less than 0 or greater than 5000
            Else

                'display error message
                lblOutput.Text = "Values must be between 0 and 5000 inclusive. Please try again."

                'set focus back on textbox
                txtUnits.Select()

                'clear the input textbox
                txtUnits.Clear()

            End If

            'run if user input is not numeric
        Else

            'display error message
            lblOutput.Text = "Input must be numeric. Please try again."

            'set focus back on to textbox
            txtUnits.Select()

            'clear the input textbox
            txtUnits.Clear()

        End If

        'run is day counter exceeds 7 days
        If dayCounter > 7 Then

            'calculate average of units and round to 2 decimal places
            unitAverage = Math.Round(unitSum / 7, 2)

            'output the average
            lblOutput.Text = "Average per day: " & unitAverage

            'set input textbox to read only
            txtUnits.ReadOnly = True

            'set enter button to disabled
            btnEnter.Enabled = False

            'set textbox color to grey
            txtUnits.BackColor = Color.LightGray


        End If


    End Sub
End Class
