Option Strict On

'************************************************************************************************
'Assignment:    Lab 2B
'Author:        Brad Oake
'Date:          February 19th, 2015
'Description:   This program is modified by the usage of PieceworkPayInput.vb. The totals
'               incremented by the PieceworkPay class on that form will be displayed here.
'************************************************************************************************
Public Class SummaryForm

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close() 'close the form and return to PieceworkPayInput
    End Sub

End Class