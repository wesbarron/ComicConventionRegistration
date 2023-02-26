Public Class frmComic
    Private Sub frmComic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdBtn1.Checked = True
        grpType.ForeColor = Color.Crimson
        lblRegsTotal.Text = ""
        txtBoxGroup.Focus()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declarations
        Dim intGroup As Integer = 0
        Dim decRegistration As Decimal
        Dim decTotalCost As Decimal
        Dim decSuperHero As Decimal = 380D
        Dim decAutographs As Decimal = 275D
        Dim decConvention As Decimal = 209D

        'Check to see if user entered a numeric value
        If IsNumeric(txtBoxGroup.Text) Then
            intGroup = Convert.ToInt32(txtBoxGroup.Text)
            'number greater than 0?
            If intGroup > 0 And intGroup < 20 Then
                'Calculate and display cost
                If rdBtn1.Checked Then
                    decRegistration = decSuperHero
                ElseIf rdBtn2.Checked Then
                    decRegistration = decAutographs
                ElseIf rdBtn3.Checked Then
                    decRegistration = decConvention
                End If

                decTotalCost = (intGroup * decRegistration)
                lblRegsTotal.Text = decTotalCost.ToString("C")
            Else
                'Error if negative number
                MsgBox("Enter a positive number between 1 and 20", , "Invalid Number Error")
            End If
        Else
            'Error if non-numeric
            MsgBox("Enter a reasonable number between 1 and 20", , "Invalid Entry Error")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBoxGroup.Clear()
        lblRegsTotal.Text = ""
        rdBtn1.Checked = True
        rdBtn2.Checked = False
        rdBtn3.Checked = False
        txtBoxGroup.Focus()
    End Sub
End Class
