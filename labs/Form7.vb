Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NEXTFORMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEXTFORMToolStripMenuItem.Click
        Form8.Show()
    End Sub

    Private Sub CLOSEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLOSEToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NEXTAPPSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEXTAPPSToolStripMenuItem.Click
        Form9.Show()
    End Sub
End Class