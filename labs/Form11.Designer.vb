<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        ProgressBar1 = New ProgressBar()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(406, 305)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(933, 76)
        ProgressBar1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(406, 430)
        Button1.Name = "Button1"
        Button1.Size = New Size(217, 60)
        Button1.TabIndex = 1
        Button1.Text = "LOAD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(1122, 430)
        Button2.Name = "Button2"
        Button2.Size = New Size(217, 60)
        Button2.TabIndex = 2
        Button2.Text = "CANCEL"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(1364, 319)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 50)
        Label1.TabIndex = 3
        Label1.Text = "100%"
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(1485, 738)
        Button3.Name = "Button3"
        Button3.Size = New Size(159, 87)
        Button3.TabIndex = 4
        Button3.Text = "NEXT"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form11
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1755, 914)
        Controls.Add(Button3)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ProgressBar1)
        Name = "Form11"
        Text = "Form11"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
End Class
