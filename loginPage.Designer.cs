﻿namespace MediTracker
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
            loginLogoPictureBox = new PictureBox();
            loginButton = new Button();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginUserNameLabel = new Label();
            loginPaswordLabel = new Label();
            loginHeaderLabel = new Label();
            RegisterNowLinkLabel = new LinkLabel();
            questionLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)loginLogoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 151, 219);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 418);
            panel1.TabIndex = 0;
            // 
            // loginLogoPictureBox
            // 
            loginLogoPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginLogoPictureBox.BackgroundImageLayout = ImageLayout.None;
            loginLogoPictureBox.Image = Properties.Resources.MediTracker_Logo__removebg_preview1;
            loginLogoPictureBox.Location = new Point(405, 12);
            loginLogoPictureBox.Name = "loginLogoPictureBox";
            loginLogoPictureBox.Size = new Size(399, 98);
            loginLogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            loginLogoPictureBox.TabIndex = 2;
            loginLogoPictureBox.TabStop = false;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginButton.Location = new Point(549, 272);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(79, 25);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userNameTextBox.Location = new Point(458, 174);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(228, 23);
            userNameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.Location = new Point(458, 233);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(228, 23);
            passwordTextBox.TabIndex = 5;
            // 
            // loginUserNameLabel
            // 
            loginUserNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginUserNameLabel.AutoSize = true;
            loginUserNameLabel.Location = new Point(458, 156);
            loginUserNameLabel.Name = "loginUserNameLabel";
            loginUserNameLabel.Size = new Size(60, 15);
            loginUserNameLabel.TabIndex = 6;
            loginUserNameLabel.Text = "Username";
            // 
            // loginPaswordLabel
            // 
            loginPaswordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginPaswordLabel.AutoSize = true;
            loginPaswordLabel.Location = new Point(458, 215);
            loginPaswordLabel.Name = "loginPaswordLabel";
            loginPaswordLabel.Size = new Size(52, 15);
            loginPaswordLabel.TabIndex = 7;
            loginPaswordLabel.Text = "Pasword";
            // 
            // loginHeaderLabel
            // 
            loginHeaderLabel.Anchor = AnchorStyles.None;
            loginHeaderLabel.AutoSize = true;
            loginHeaderLabel.Location = new Point(559, 113);
            loginHeaderLabel.Name = "loginHeaderLabel";
            loginHeaderLabel.Size = new Size(37, 15);
            loginHeaderLabel.TabIndex = 8;
            loginHeaderLabel.Text = "Login";
            // 
            // RegisterNowLinkLabel
            // 
            RegisterNowLinkLabel.ActiveLinkColor = Color.Red;
            RegisterNowLinkLabel.Anchor = AnchorStyles.None;
            RegisterNowLinkLabel.AutoSize = true;
            RegisterNowLinkLabel.Location = new Point(584, 310);
            RegisterNowLinkLabel.Name = "RegisterNowLinkLabel";
            RegisterNowLinkLabel.Size = new Size(77, 15);
            RegisterNowLinkLabel.TabIndex = 9;
            RegisterNowLinkLabel.TabStop = true;
            RegisterNowLinkLabel.Text = "Register Now";
            RegisterNowLinkLabel.LinkClicked += RegisterNowLinkLabel_LinkClicked;
            // 
            // questionLabel
            // 
            questionLabel.Anchor = AnchorStyles.None;
            questionLabel.AutoSize = true;
            questionLabel.Location = new Point(454, 311);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(126, 15);
            questionLabel.TabIndex = 10;
            questionLabel.Text = "Don't have a Account?";
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(816, 418);
            Controls.Add(loginButton);
            Controls.Add(questionLabel);
            Controls.Add(RegisterNowLinkLabel);
            Controls.Add(loginHeaderLabel);
            Controls.Add(loginPaswordLabel);
            Controls.Add(loginUserNameLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(loginLogoPictureBox);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "loginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)loginLogoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox loginLogoPictureBox;
        private Button loginButton;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Label loginUserNameLabel;
        private Label loginPaswordLabel;
        private Label loginHeaderLabel;
        private LinkLabel RegisterNowLinkLabel;
        private Label questionLabel;
    }
}
