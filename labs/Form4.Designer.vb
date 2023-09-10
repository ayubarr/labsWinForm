<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label1 = New Label()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(239, 145)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(600, 206)
        TextBox1.TabIndex = 0
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonFace
        Button1.Font = New Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(950, 701)
        Button1.Name = "Button1"
        Button1.Size = New Size(467, 192)
        Button1.TabIndex = 1
        Button1.Text = "CHECK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(936, 179)
        Label1.Name = "Label1"
        Label1.Size = New Size(1105, 106)
        Label1.TabIndex = 2
        Label1.Text = "DO TOADS LIVE ON MARS?"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox1.Location = New Point(239, 485)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(155, 75)
        CheckBox1.TabIndex = 3
        CheckBox1.Text = "YEP"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox2.Location = New Point(556, 485)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(602, 75)
        CheckBox2.TabIndex = 4
        CheckBox2.Text = "DO WE HAVE TOADS?"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox3.Location = New Point(1291, 485)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.RightToLeft = RightToLeft.No
        CheckBox3.Size = New Size(205, 75)
        CheckBox3.TabIndex = 5
        CheckBox3.Text = "NOPE"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Font = New Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox4.Location = New Point(1612, 485)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(429, 75)
        CheckBox4.TabIndex = 6
        CheckBox4.Text = "I LOVE TOADS!"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(1901, 997)
        Button2.Name = "Button2"
        Button2.Size = New Size(276, 58)
        Button2.TabIndex = 7
        Button2.Text = "NEXT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(2315, 1095)
        Controls.Add(Button2)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents Button2 As Button
End Class
