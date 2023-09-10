namespace LabsCs
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(56, 374);
            button1.Name = "button1";
            button1.Size = new Size(154, 37);
            button1.TabIndex = 1;
            button1.Text = "PreviousPic";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(571, 374);
            button2.Name = "button2";
            button2.Size = new Size(116, 37);
            button2.TabIndex = 2;
            button2.Text = "NextPIC";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-3, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(802, 450);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(684, 103);
            button3.Name = "button3";
            button3.Size = new Size(104, 54);
            button3.TabIndex = 4;
            button3.Text = "Next";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form9";
            Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
        private Button button3;
    }
}