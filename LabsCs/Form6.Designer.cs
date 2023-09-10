namespace LabsCs
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            pToolStripMenuItem = new ToolStripMenuItem();
            nextFormToolStripMenuItem = new ToolStripMenuItem();
            closeProgramToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { pToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // pToolStripMenuItem
            // 
            pToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nextFormToolStripMenuItem, closeProgramToolStripMenuItem });
            pToolStripMenuItem.Name = "pToolStripMenuItem";
            pToolStripMenuItem.Size = new Size(48, 20);
            pToolStripMenuItem.Text = "Open";
            // 
            // nextFormToolStripMenuItem
            // 
            nextFormToolStripMenuItem.Name = "nextFormToolStripMenuItem";
            nextFormToolStripMenuItem.Size = new Size(180, 22);
            nextFormToolStripMenuItem.Text = "Next Form";
            nextFormToolStripMenuItem.Click += nextFormToolStripMenuItem_Click;
            // 
            // closeProgramToolStripMenuItem
            // 
            closeProgramToolStripMenuItem.Name = "closeProgramToolStripMenuItem";
            closeProgramToolStripMenuItem.Size = new Size(180, 22);
            closeProgramToolStripMenuItem.Text = "Close Program";
            closeProgramToolStripMenuItem.Click += closeProgramToolStripMenuItem_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form6";
            Text = "Form6";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pToolStripMenuItem;
        private ToolStripMenuItem nextFormToolStripMenuItem;
        private ToolStripMenuItem closeProgramToolStripMenuItem;
    }
}