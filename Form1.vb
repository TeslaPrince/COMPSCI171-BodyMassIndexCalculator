Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim weight As Double
        Dim height As Double
        Dim eqPt1 As Double
        Dim eqPt2 As Double
        Dim eqpt3
        Const BMI As Integer = 703
        weight = CDbl(txtWeight.Text)
        height = CDbl(txtHeight.Text)
        eqPt1 = weight * BMI
        eqPt2 = height * height
        eqpt3 = eqPt1 / eqPt2
        txtIndex.Text = String.Format("{0:N}", eqpt3)
        Select Case (eqpt3)
            Case 0 To 18.4
                txtStatus.Text = "Underweight"
            Case 18.5 To 24.9
                txtStatus.Text = "Normal"
            Case 25.9 To 29.9
                txtStatus.Text = "Overweight (Obesity Grade I)"
            Case 30.0 To 34.9
                txtStatus.Text = "Obesity Grade II"
            Case 35.0 To 39.9
                txtStatus.Text = "Obesity Grade III"
            Case >= 40.0
                txtStatus.Text = "Obesity Grade IV"
            Case < 0
                txtStatus.Text = "Invalid"
        End Select
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fmtStr As String = "{0, -20}{1, 20}"
        lbxChart.Items.Add(String.Format(fmtStr, "BMI", "Weight Status"))
        lbxChart.Items.Add(String.Format(fmtStr, "", ""))
        lbxChart.Items.Add(String.Format(fmtStr, "Below 18.4", "Underweight"))
        lbxChart.Items.Add(String.Format(fmtStr, "18.5 - 24.9", "Normal"))
        lbxChart.Items.Add(String.Format(fmtStr, "25.0 - 29.9", "Obesity Grade I"))
        lbxChart.Items.Add(String.Format(fmtStr, "30.0 - 34.9", "Obesity Grade II"))
        lbxChart.Items.Add(String.Format(fmtStr, "35.0 - 39.9", "Obesity Grade III"))
        lbxChart.Items.Add(String.Format(fmtStr, "40.0 and Above", "Obesity Grade IV"))
    End Sub
End Class
