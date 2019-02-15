Option Strict On

'************************************************************************************************
'Assignment:    Lab 2B
'Author:        Brad Oake
'Date:          February 19th, 2015
'Description:   This program accepts input from the user for a worker's name and the number of
'               pieces they assembled. After validation, it creates an instance of a
'               PieceworkPay object and instantiates it with the user's input. After which
'               the worker's pay is calculated and displayed on the form, and values on the
'               SummaryForm are incremented or recalculated.
'************************************************************************************************

Public Class PieceWorkPayInput

    'This event fires when btnCalculate is clicked
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'DECLARATIONS
        Dim workerName As String            'holds the worker name provided by the user
        Dim numberOfPieces As Integer       'holds the number of pieces a worker produced
        Dim validInput As Boolean = True   'holds a flag that is used to control program flow when input isn't valid

        'INPUT
        workerName = txtWorkerName.Text 'store the worker name

        'VALIDATION
        'check if txtWorkerName is empty
        If (txtWorkerName.Text = "") Then
            'Input error, display error message, set validInput flag to false, and focus on error point
            MessageBox.Show("Please enter a worker name.", "Input Error")
            validInput = False
            txtWorkerName.Focus()
        End If

        'Try to grab the number of pieces and place it in an integer variable
        Try
            numberOfPieces = Convert.ToInt32(txtNumberOfPieces.Text)
        Catch 'if conversion failed
            'Input error, display error message, set validInput flag to false, and focus on error point
            MessageBox.Show("Please enter a whole number for the amount of pieces the worker produced.", "Input Error")
            validInput = False
            txtNumberOfPieces.Focus()
        End Try

        'Test if input was valid
        If validInput = True Then
            'Instantiate a pieceworkPay object with user input
            Dim pieceworkPayObject As New PieceworkPay(workerName, numberOfPieces)

            'Update the worker pay label
            lblTotalPay.Text = FormatCurrency(pieceworkPayObject.WorkerPayment.ToString)
        
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears data from the PieceworkPayInput form
        txtWorkerName.Text = ""
        txtNumberOfPieces.Text = ""
        lblTotalPay.Text = ""
        'focus on the worker name text box
        lblWorkerNameHeader.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'exits the program
        Me.Close()
    End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        'Display the SummaryForm and update the labels to correspond with the updated 
        'PieceworkPay object.
        SummaryForm.lblTotalPieces.Text = PieceworkPay.TotalPiecesManufactured.ToString
        SummaryForm.lblTotalPay.Text = FormatCurrency(PieceworkPay.OverallPay.ToString)
        SummaryForm.lblTotalPayPerWorker.Text = FormatCurrency(PieceworkPay.MeanPay.ToString)
        SummaryForm.ShowDialog()
    End Sub
End Class
