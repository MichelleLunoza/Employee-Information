Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim pay As Decimal
        Dim sss As Decimal
        Dim tax As Decimal
        Dim np As Decimal
        Dim day As Integer
        Dim rpd As Decimal
        Dim rate As Decimal
        Dim contri As Decimal




        Integer.TryParse(dayNumericUpDown.Value, day)


        If psComboBox.Text = "A" Then
            rpd = 500
        ElseIf psComboBox.Text = "B" Then
            rpd = 400
        ElseIf psComboBox.Text = "C" Then
            rpd = 300
        End If

        If singleRadioButton.Checked = True Then
            rate = 0.1
        ElseIf marriedRadioButton.Checked = True Then
            rate = 0.05
        Else
            rate = 0.05

        End If

        If pay > 10000 Then
            sss = 0.07
        ElseIf pay > 5000 AndAlso pay < 9999 Then
            sss = 0.05
        ElseIf pay > 1000 AndAlso pay < 4999 Then
            sss = 0.03
        ElseIf pay < 1000 Then
            sss = 0.01


        End If

        pay = day * rpd
        contri = pay * sss
        tax = pay * rate
        np = pay - (contri + tax)

        payTextBox.Text = pay.ToString("c2")
        sssTextBox.Text = contri.ToString("c2")
        taxTextBox.Text = tax.ToString("c2")
        npTextBox.Text = np.ToString("c2")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        payTextBox.Text = ""
        sssTextBox.Text = ""
        npTextBox.Text = ""
        taxTextBox.Text = ""
        enComboBox.Text = ""
        nameTextBox.Text = ""
        psComboBox.Text = ""
        singleRadioButton.Checked = False
        marriedRadioButton.Checked = False
        widRadioButton.Checked = False
        dayNumericUpDown.Value = False



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()


    End Sub

    Private Sub enComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enComboBox.SelectedIndexChanged
        Dim nme As String

        Integer.TryParse(enComboBox.Text, nme)

        If enComboBox.Text = 1 Then
            nameTextBox.Text = "Light"
        ElseIf enComboBox.Text = 2 Then
            nameTextBox.Text = "jess"
        ElseIf enComboBox.Text = 3 Then
            nameTextBox.Text = "renz"

        End If

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New Form1
        frm.Show()
        Me.Close()
    End Sub
End Class
