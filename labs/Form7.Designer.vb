<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        NEXTFORMToolStripMenuItem = New ToolStripMenuItem()
        CLOSEToolStripMenuItem = New ToolStripMenuItem()
        NEXTAPPSToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(32, 32)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1777, 150)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {NEXTFORMToolStripMenuItem, CLOSEToolStripMenuItem, NEXTAPPSToolStripMenuItem})
        ToolStripMenuItem1.Font = New Font("Segoe UI", 40.125F, FontStyle.Bold, GraphicsUnit.Point)
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(369, 146)
        ToolStripMenuItem1.Text = "OPEN"
        ' 
        ' NEXTFORMToolStripMenuItem
        ' 
        NEXTFORMToolStripMenuItem.Name = "NEXTFORMToolStripMenuItem"
        NEXTFORMToolStripMenuItem.Size = New Size(857, 150)
        NEXTFORMToolStripMenuItem.Text = "NEXT FORM"
        ' 
        ' CLOSEToolStripMenuItem
        ' 
        CLOSEToolStripMenuItem.Name = "CLOSEToolStripMenuItem"
        CLOSEToolStripMenuItem.Size = New Size(857, 150)
        CLOSEToolStripMenuItem.Text = "CLOSE"
        ' 
        ' NEXTAPPSToolStripMenuItem
        ' 
        NEXTAPPSToolStripMenuItem.Name = "NEXTAPPSToolStripMenuItem"
        NEXTAPPSToolStripMenuItem.Size = New Size(857, 150)
        NEXTAPPSToolStripMenuItem.Text = "NEXT APP"
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1777, 953)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form7"
        Text = "Form7"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NEXTFORMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLOSEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NEXTAPPSToolStripMenuItem As ToolStripMenuItem
End Class
