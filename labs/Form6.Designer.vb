<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form6))
        Button2 = New Button()
        Button1 = New Button()
        RichTextBox1 = New RichTextBox()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(1194, 1048)
        Button2.Name = "Button2"
        Button2.Size = New Size(199, 68)
        Button2.TabIndex = 5
        Button2.Text = "NEXT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(439, 1048)
        Button1.Name = "Button1"
        Button1.Size = New Size(268, 68)
        Button1.TabIndex = 4
        Button1.Text = "PREVIOUS"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Font = New Font("Segoe UI", 13.1F, FontStyle.Bold, GraphicsUnit.Point)
        RichTextBox1.Location = New Point(439, 70)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(954, 899)
        RichTextBox1.TabIndex = 3
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1904, 1220)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(RichTextBox1)
        Name = "Form6"
        Text = "Form6"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
