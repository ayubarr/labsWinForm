<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        components = New ComponentModel.Container()
        Timer1 = New Timer(components)
        Label1 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(743, 328)
        Label1.Name = "Label1"
        Label1.Size = New Size(181, 212)
        Label1.TabIndex = 0
        Label1.Text = "0"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(1404, 819)
        Button1.Name = "Button1"
        Button1.Size = New Size(187, 62)
        Button1.TabIndex = 1
        Button1.Text = "NEXT"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1680, 929)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Form9"
        Text = "Form9"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
