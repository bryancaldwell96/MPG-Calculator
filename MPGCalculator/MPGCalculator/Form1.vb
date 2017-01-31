Option Strict On

Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'declare variables
        Dim dblGallons As Double
        Dim dblMiles As Double
        Dim dblMPG As Double

        Try

            'set variable values
            dblGallons = CDbl(txtGallons.Text)
            dblMiles = CDbl(txtMiles.Text)

            'calculate miles divided by gallons
            dblMPG = (dblMiles / dblGallons)

            'display result
            lblMPG.Text = dblMPG.ToString("0.00")

        Catch ex As Exception

            'show error message
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear all text fields for user
        txtGallons.Text = ""
        txtMiles.Text = ""
        lblMPG.Text = ""

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'closes the program
        Application.Exit()

    End Sub

End Class
