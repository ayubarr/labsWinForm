Public Class Form12
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Text = Val(Label1.Text) + 1
        If Label1.Text = "5" Then
            Button1.BackColor = Color.Yellow
            Button3.BackColor = Color.White
        End If
        If Label1.Text = "10" Then
            Button2.BackColor = Color.Red
            Button1.BackColor = Color.White
        End If
        If Label1.Text = "15" Then
            Button3.BackColor = Color.Green
            Button2.BackColor = Color.White
        End If
        If Label1.Text = "15" Then
            Label1.Text = "PEREHODITE DOROGY"
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form13.Show()
    End Sub
End Class