namespace MediTracker
{
    partial class loginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 194, 213);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 337);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.MediTracker_Logo__removebg_preview;
            pictureBox1.Location = new Point(227, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(359, 302);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(278, 174);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(278, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(223, 23);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 156);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 6;
            label1.Text = "Username / Emil";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 215);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 7;
            label2.Text = "Pasword";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 114);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 8;
            label3.Text = "Login";
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(137, 222, 226);
            ClientSize = new Size(579, 337);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "loginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
