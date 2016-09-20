Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & 1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & 2
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & 3
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & 4
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & 5
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & 6
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & 7
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & 8
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & 9
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox3.Text = "+"
        If TextBox1.Text = "" Then
            MsgBox("Please Enter the value to work on!", vbInformation, "Enter the field")
            Exit Sub
        End If
        If (TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "") Then
            MsgBox("Please click on evaluate sign '=' !", vbInformation, "Click on =")
            Exit Sub
        End If
        TextBox2.Text = TextBox1.Text
        TextBox1.Text = ""
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox3.Text = "-"
        If TextBox1.Text = "" Then
            MsgBox("Please Enter the value to work on!", vbInformation, "Enter the field")
            Exit Sub
        End If
        If (TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "") Then
            MsgBox("Please click on evaluate sign '=' !", vbInformation, "Click on =")
            Exit Sub
        End If
        TextBox2.Text = TextBox1.Text
        TextBox1.Text = ""
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox3.Text = "*"
        If TextBox1.Text = "" Then
            MsgBox("Please Enter the value to work on!", vbInformation, "Enter the field")
            Exit Sub
        End If
        If (TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "") Then
            MsgBox("Please click on evaluate sign '=' !", vbInformation, "Click on =")
            Exit Sub
        End If
        TextBox2.Text = TextBox1.Text
        TextBox1.Text = ""
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox3.Text = "/"
        If TextBox1.Text = "" Then
            MsgBox("Please Enter the value to work on!", vbInformation, "Enter the field")
            Exit Sub
        End If
        If (TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "") Then
            MsgBox("Please click on evaluate sign '=' !", vbInformation, "Click on =")
            Exit Sub
        End If
        TextBox2.Text = TextBox1.Text
        TextBox1.Text = ""
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "") Then
            MsgBox("Please enter all the fields and then continue!", MsgBoxStyle.Information, "Incomplete information")
        Else
            Dim operatorText As String, value1 As Integer, value2 As Integer, value3 As Integer
            operatorText = TextBox3.Text
            value1 = Integer.Parse(TextBox2.Text)
            value2 = Integer.Parse(TextBox1.Text)

            If (operatorText = "+") Then
                value3 = value1 + value2
                TextBox2.Text = value3
            ElseIf (operatorText = "-") Then
                value3 = value1 - value2
                TextBox2.Text = value3
            ElseIf (operatorText = "*") Then
                value3 = value1 * value2
                TextBox2.Text = value3
            ElseIf (operatorText = "/") Then
                value3 = value1 / value2
                TextBox2.Text = value3
            End If
            TextBox1.Text = ""
            TextBox3.Text = ""
            MsgBox(TextBox2.Text, vbInformation, "The Result is...")
        End If
    End Sub
End Class
