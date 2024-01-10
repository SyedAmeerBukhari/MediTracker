using TabControls;

namespace MediTracker
{
    partial class PatientDataViewForm
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
            patientDataViewTabControl = new TabControls.DotNetBarTabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            patientDataViewTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // patientDataViewTabControl
            // 
            patientDataViewTabControl.Alignment = TabAlignment.Left;
            patientDataViewTabControl.Controls.Add(tabPage1);
            patientDataViewTabControl.Controls.Add(tabPage2);
            patientDataViewTabControl.Dock = DockStyle.Bottom;
            patientDataViewTabControl.ItemSize = new Size(44, 136);
            patientDataViewTabControl.Location = new Point(0, 120);
            patientDataViewTabControl.Multiline = true;
            patientDataViewTabControl.Name = "patientDataViewTabControl";
            patientDataViewTabControl.SelectedIndex = 0;
            patientDataViewTabControl.Size = new Size(800, 330);
            patientDataViewTabControl.SizeMode = TabSizeMode.Fixed;
            patientDataViewTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(140, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(656, 322);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(140, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(656, 442);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // PatentDataViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(patientDataViewTabControl);
            Name = "PatentDataViewForm";
            Text = "PatentDataViewForm";
            Load += PatientDataViewForm_Load;
            patientDataViewTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DotNetBarTabControl patientDataViewTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}