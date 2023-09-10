<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        MonthCalendar1 = New MonthCalendar()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.CalendarDimensions = New Size(2, 2)
        MonthCalendar1.Location = New Point(660, 204)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1758, 934)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 46)
        Button1.TabIndex = 1
        Button1.Text = "NEXT"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2116, 1008)
        Controls.Add(Button1)
        Controls.Add(MonthCalendar1)
        Name = "Form3"
        Text = "Test2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Button1 As Button
End Class
