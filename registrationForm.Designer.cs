namespace MediTracker
{
    partial class registrationForm
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
            panel1 = new Panel();
            registerLogoPictureBox = new PictureBox();
            registerLable = new Label();
            registerUserNameLable = new Label();
            registerUserNameTextBox = new TextBox();
            registerPasswordLable = new Label();
            registerpasswordTextBox = new TextBox();
            confirmPasswordLable = new Label();
            confirmPasswordTextBox = new TextBox();
            registerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)registerLogoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 111, 116);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 494);
            panel1.TabIndex = 0;
            // 
            // registerLogoPictureBox
            // 
            registerLogoPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            registerLogoPictureBox.BackgroundImageLayout = ImageLayout.None;
            registerLogoPictureBox.Image = Properties.Resources.MediTracker_Logo__removebg_preview1;
            registerLogoPictureBox.Location = new Point(407, 12);
            registerLogoPictureBox.Name = "registerLogoPictureBox";
            registerLogoPictureBox.Size = new Size(401, 123);
            registerLogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            registerLogoPictureBox.TabIndex = 3;
            registerLogoPictureBox.TabStop = false;
            // 
            // registerLable
            // 
            registerLable.AutoSize = true;
            registerLable.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerLable.Location = new Point(565, 149);
            registerLable.Name = "registerLable";
            registerLable.Size = new Size(79, 25);
            registerLable.TabIndex = 4;
            registerLable.Text = "Register";
            // 
            // registerUserNameLable
            // 
            registerUserNameLable.AutoSize = true;
            registerUserNameLable.Location = new Point(425, 205);
            registerUserNameLable.Name = "registerUserNameLable";
            registerUserNameLable.Size = new Size(60, 15);
            registerUserNameLable.TabIndex = 8;
            registerUserNameLable.Text = "Username";
            // 
            // registerUserNameTextBox
            // 
            registerUserNameTextBox.Location = new Point(425, 223);
            registerUserNameTextBox.Name = "registerUserNameTextBox";
            registerUserNameTextBox.Size = new Size(162, 23);
            registerUserNameTextBox.TabIndex = 7;
            // 
            // registerPasswordLable
            // 
            registerPasswordLable.AutoSize = true;
            registerPasswordLable.Location = new Point(425, 276);
            registerPasswordLable.Name = "registerPasswordLable";
            registerPasswordLable.Size = new Size(57, 15);
            registerPasswordLable.TabIndex = 14;
            registerPasswordLable.Text = "Password";
            // 
            // registerpasswordTextBox
            // 
            registerpasswordTextBox.Location = new Point(425, 294);
            registerpasswordTextBox.Name = "registerpasswordTextBox";
            registerpasswordTextBox.Size = new Size(162, 23);
            registerpasswordTextBox.TabIndex = 13;
            // 
            // confirmPasswordLable
            // 
            confirmPasswordLable.AutoSize = true;
            confirmPasswordLable.Location = new Point(425, 342);
            confirmPasswordLable.Name = "confirmPasswordLable";
            confirmPasswordLable.Size = new Size(104, 15);
            confirmPasswordLable.TabIndex = 16;
            confirmPasswordLable.Text = "Confirm Password";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Location = new Point(425, 360);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(162, 23);
            confirmPasswordTextBox.TabIndex = 15;
            // 
            // registerButton
            // 
            registerButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerButton.Location = new Point(548, 420);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(152, 39);
            registerButton.TabIndex = 17;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // registrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(211, 197, 187);
            ClientSize = new Size(837, 494);
            Controls.Add(registerButton);
            Controls.Add(confirmPasswordLable);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(registerPasswordLable);
            Controls.Add(registerpasswordTextBox);
            Controls.Add(registerUserNameLable);
            Controls.Add(registerUserNameTextBox);
            Controls.Add(registerLable);
            Controls.Add(registerLogoPictureBox);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "registrationForm";
            Text = "registrationForm";
            Load += registrationForm_Load;
            ((System.ComponentModel.ISupportInitialize)registerLogoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox registerLogoPictureBox;
        private Label registerLable;
        private Label registerUserNameLable;
        private TextBox registerUserNameTextBox;
        private Label registerPasswordLable;
        private TextBox registerpasswordTextBox;
        private Label confirmPasswordLable;
        private TextBox confirmPasswordTextBox;
        private Button registerButton;
    }
}