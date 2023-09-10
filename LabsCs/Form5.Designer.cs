namespace LabsCs
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            richTextBox2 = new RichTextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(121, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(525, 384);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(121, 402);
            button1.Name = "button1";
            button1.Size = new Size(75, 36);
            button1.TabIndex = 1;
            button1.Text = "PriviousList";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(571, 402);
            button2.Name = "button2";
            button2.Size = new Size(75, 36);
            button2.TabIndex = 2;
            button2.Text = "NextList";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(121, 12);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(525, 384);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            richTextBox2.Visible = false;
            // 
            // button3
            // 
            button3.Location = new Point(693, 289);
            button3.Name = "button3";
            button3.Size = new Size(95, 50);
            button3.TabIndex = 4;
            button3.Text = "Next";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(richTextBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private RichTextBox richTextBox2;
        private Button button3;
    }
}