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
            patientDataViewTabControl = new DotNetBarTabControl();
            patientBiographyDataVeiwTabControl = new TabPage();
            medicalHistoryDataVeiwTabControl = new TabPage();
            labHistoryDataVeiwTabControl = new TabPage();
            radiologyDataVeiwTabControl = new TabPage();
            proceduresDataVeiwTabControl = new TabPage();
            referDataVeiwTabControl = new TabPage();
            consultantOpinionDataVeiwTabControl = new TabPage();
            caseSumaryDataVeiwTabControl = new TabPage();
            patientDataViewTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // patientDataViewTabControl
            // 
            patientDataViewTabControl.Alignment = TabAlignment.Left;
            patientDataViewTabControl.Controls.Add(patientBiographyDataVeiwTabControl);
            patientDataViewTabControl.Controls.Add(medicalHistoryDataVeiwTabControl);
            patientDataViewTabControl.Controls.Add(labHistoryDataVeiwTabControl);
            patientDataViewTabControl.Controls.Add(radiologyDataVeiwTabControl);
            patientDataViewTabControl.Controls.Add(proceduresDataVeiwTabControl);
            patientDataViewTabControl.Controls.Add(referDataVeiwTabControl);
            patientDataViewTabControl.Controls.Add(consultantOpinionDataVeiwTabControl);
            patientDataViewTabControl.Controls.Add(caseSumaryDataVeiwTabControl);
            patientDataViewTabControl.Dock = DockStyle.Bottom;
            patientDataViewTabControl.ItemSize = new Size(44, 136);
            patientDataViewTabControl.Location = new Point(0, 84);
            patientDataViewTabControl.Multiline = true;
            patientDataViewTabControl.Name = "patientDataViewTabControl";
            patientDataViewTabControl.SelectedIndex = 0;
            patientDataViewTabControl.Size = new Size(800, 366);
            patientDataViewTabControl.SizeMode = TabSizeMode.Fixed;
            patientDataViewTabControl.TabIndex = 0;
            // 
            // patientBiographyDataVeiwTabControl
            // 
            patientBiographyDataVeiwTabControl.BackColor = SystemColors.Control;
            patientBiographyDataVeiwTabControl.Location = new Point(140, 4);
            patientBiographyDataVeiwTabControl.Name = "patientBiographyDataVeiwTabControl";
            patientBiographyDataVeiwTabControl.Padding = new Padding(3);
            patientBiographyDataVeiwTabControl.Size = new Size(656, 358);
            patientBiographyDataVeiwTabControl.TabIndex = 0;
            patientBiographyDataVeiwTabControl.Text = "Patient Biography";
            // 
            // medicalHistoryDataVeiwTabControl
            // 
            medicalHistoryDataVeiwTabControl.BackColor = SystemColors.Control;
            medicalHistoryDataVeiwTabControl.Location = new Point(140, 4);
            medicalHistoryDataVeiwTabControl.Name = "medicalHistoryDataVeiwTabControl";
            medicalHistoryDataVeiwTabControl.Padding = new Padding(3);
            medicalHistoryDataVeiwTabControl.Size = new Size(656, 358);
            medicalHistoryDataVeiwTabControl.TabIndex = 1;
            medicalHistoryDataVeiwTabControl.Text = "Medical History";
            // 
            // labHistoryDataVeiwTabControl
            // 
            labHistoryDataVeiwTabControl.BackColor = SystemColors.Control;
            labHistoryDataVeiwTabControl.Location = new Point(140, 4);
            labHistoryDataVeiwTabControl.Name = "labHistoryDataVeiwTabControl";
            labHistoryDataVeiwTabControl.Size = new Size(656, 358);
            labHistoryDataVeiwTabControl.TabIndex = 2;
            labHistoryDataVeiwTabControl.Text = "Lab History";
            // 
            // radiologyDataVeiwTabControl
            // 
            radiologyDataVeiwTabControl.BackColor = SystemColors.Control;
            radiologyDataVeiwTabControl.Location = new Point(140, 4);
            radiologyDataVeiwTabControl.Name = "radiologyDataVeiwTabControl";
            radiologyDataVeiwTabControl.Size = new Size(656, 358);
            radiologyDataVeiwTabControl.TabIndex = 3;
            radiologyDataVeiwTabControl.Text = "Radiology";
            // 
            // proceduresDataVeiwTabControl
            // 
            proceduresDataVeiwTabControl.BackColor = SystemColors.Control;
            proceduresDataVeiwTabControl.Location = new Point(140, 4);
            proceduresDataVeiwTabControl.Name = "proceduresDataVeiwTabControl";
            proceduresDataVeiwTabControl.Size = new Size(656, 358);
            proceduresDataVeiwTabControl.TabIndex = 4;
            proceduresDataVeiwTabControl.Text = "Procedures / Surguries";
            // 
            // referDataVeiwTabControl
            // 
            referDataVeiwTabControl.BackColor = SystemColors.Control;
            referDataVeiwTabControl.Location = new Point(140, 4);
            referDataVeiwTabControl.Name = "referDataVeiwTabControl";
            referDataVeiwTabControl.Size = new Size(656, 358);
            referDataVeiwTabControl.TabIndex = 5;
            referDataVeiwTabControl.Text = "refer";
            // 
            // consultantOpinionDataVeiwTabControl
            // 
            consultantOpinionDataVeiwTabControl.BackColor = SystemColors.Control;
            consultantOpinionDataVeiwTabControl.Location = new Point(140, 4);
            consultantOpinionDataVeiwTabControl.Name = "consultantOpinionDataVeiwTabControl";
            consultantOpinionDataVeiwTabControl.Size = new Size(656, 358);
            consultantOpinionDataVeiwTabControl.TabIndex = 6;
            consultantOpinionDataVeiwTabControl.Text = "Consultant Opinion";
            // 
            // caseSumaryDataVeiwTabControl
            // 
            caseSumaryDataVeiwTabControl.BackColor = SystemColors.Control;
            caseSumaryDataVeiwTabControl.Location = new Point(140, 4);
            caseSumaryDataVeiwTabControl.Name = "caseSumaryDataVeiwTabControl";
            caseSumaryDataVeiwTabControl.Size = new Size(656, 358);
            caseSumaryDataVeiwTabControl.TabIndex = 7;
            caseSumaryDataVeiwTabControl.Text = "Case Sumary";
            // 
            // PatientDataViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(patientDataViewTabControl);
            Name = "PatientDataViewForm";
            Text = "PatentDataViewForm";
            Load += PatientDataViewForm_Load;
            patientDataViewTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DotNetBarTabControl patientDataViewTabControl;
        private TabPage patientBiographyDataVeiwTabControl;
        private TabPage medicalHistoryDataVeiwTabControl;
        private TabPage labHistoryDataVeiwTabControl;
        private TabPage radiologyDataVeiwTabControl;
        private TabPage proceduresDataVeiwTabControl;
        private TabPage referDataVeiwTabControl;
        private TabPage consultantOpinionDataVeiwTabControl;
        private TabPage caseSumaryDataVeiwTabControl;
    }
}