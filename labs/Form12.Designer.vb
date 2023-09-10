<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Timer1 = New Timer(components)
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(694, 280)
        Button1.Name = "Button1"
        Button1.Size = New Size(251, 85)
        Button1.TabIndex = 0
        Button1.Text = "YELLOW"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(703, 403)
        Button2.Name = "Button2"
        Button2.Size = New Size(224, 85)
        Button2.TabIndex = 1
        Button2.Text = "RED"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(703, 516)
        Button3.Name = "Button3"
        Button3.Size = New Size(224, 85)
        Button3.TabIndex = 2
        Button3.Text = "GREEN"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 40.125F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(367, 164)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 142)
        Label1.TabIndex = 3
        Label1.Text = "0"
        ' 
        ' Timer1
        ' 
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(703, 653)
        Button4.Name = "Button4"
        Button4.Size = New Size(224, 83)
        Button4.TabIndex = 4
        Button4.Text = "NEXT"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form12
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1812, 979)
        Controls.Add(Button4)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form12"
        Text = "Form12"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button4 As Button
End Class
