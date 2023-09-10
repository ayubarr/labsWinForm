<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        PictureBox2 = New PictureBox()
        Button3 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._35eb55fe1cf4674332852fdf9232a0d8
        PictureBox1.Location = New Point(674, 87)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(566, 737)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(674, 866)
        Button1.Name = "Button1"
        Button1.Size = New Size(219, 71)
        Button1.TabIndex = 1
        Button1.Text = "PREVIOUS"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(1090, 866)
        Button2.Name = "Button2"
        Button2.Size = New Size(150, 71)
        Button2.TabIndex = 2
        Button2.Text = "NEXT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._51b3fc17c06471c3b24dad05cb22954d
        PictureBox2.Location = New Point(674, 87)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(566, 737)
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(1639, 982)
        Button3.Name = "Button3"
        Button3.Size = New Size(162, 58)
        Button3.TabIndex = 4
        Button3.Text = "NEXT"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form10
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1920, 1100)
        Controls.Add(Button3)
        Controls.Add(PictureBox2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Name = "Form10"
        Text = "Form10"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button3 As Button
End Class
