namespace MediTracker
{
    partial class PatientDataEntryForm
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
            patientDataEntryTabControl = new TabControls.DotNetBarTabControl();
            patientBiographyTabPage = new TabPage();
            PatientOccupationTextBox = new TextBox();
            patientOccupationLabel = new Label();
            patientBloodGroupComboBox = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            patientEmergencyContacNumberMaskedTextBox = new MaskedTextBox();
            contactNumberMaskedTextBox = new MaskedTextBox();
            patientCNICMaskedTextBox = new MaskedTextBox();
            CNICLabel = new Label();
            dataSaveButton = new Button();
            patientEmergencyContactRelationTextBox = new TextBox();
            patientEmergencyContactRelationLabel = new Label();
            patientEmailAdderssTextBox = new TextBox();
            patientEmailLabel = new Label();
            patientEmergencyContactNumberLabel = new Label();
            patientEmergencyContactNameTextBox = new TextBox();
            patientEmergencyContactNameLabel = new Label();
            patientEmergencyContactInformationLabel = new Label();
            patientContactNumberLabel = new Label();
            patientAdderssTextBox = new TextBox();
            patientAdderssLabel = new Label();
            contactInformationLabel = new Label();
            patientBloodGroupLabel = new Label();
            patientAgeLabel = new Label();
            patientGenderComboBox = new ComboBox();
            patientLastNameTextBox = new TextBox();
            patientLastNameLabel = new Label();
            patientGenderLabel = new Label();
            patientFirstNameTextBox = new TextBox();
            patientFirstNameLabel = new Label();
            medicalHistoryTabPage = new TabPage();
            AllergiesLable = new Label();
            labHistoryTabPage = new TabPage();
            radiologyTabPage = new TabPage();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            proceduresTabPage = new TabPage();
            referTabPage = new TabPage();
            cunsultentOpinionTabPage = new TabPage();
            caseSummaryTabPage = new TabPage();
            patientDataEntryTabControl.SuspendLayout();
            patientBiographyTabPage.SuspendLayout();
            medicalHistoryTabPage.SuspendLayout();
            radiologyTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // patientDataEntryTabControl
            // 
            patientDataEntryTabControl.Alignment = TabAlignment.Left;
            patientDataEntryTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            patientDataEntryTabControl.Controls.Add(patientBiographyTabPage);
            patientDataEntryTabControl.Controls.Add(medicalHistoryTabPage);
            patientDataEntryTabControl.Controls.Add(labHistoryTabPage);
            patientDataEntryTabControl.Controls.Add(radiologyTabPage);
            patientDataEntryTabControl.Controls.Add(proceduresTabPage);
            patientDataEntryTabControl.Controls.Add(referTabPage);
            patientDataEntryTabControl.Controls.Add(cunsultentOpinionTabPage);
            patientDataEntryTabControl.Controls.Add(caseSummaryTabPage);
            patientDataEntryTabControl.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientDataEntryTabControl.ItemSize = new Size(44, 136);
            patientDataEntryTabControl.Location = new Point(-1, 65);
            patientDataEntryTabControl.Margin = new Padding(0);
            patientDataEntryTabControl.Multiline = true;
            patientDataEntryTabControl.Name = "patientDataEntryTabControl";
            patientDataEntryTabControl.Padding = new Point(0, 0);
            patientDataEntryTabControl.RightToLeft = RightToLeft.No;
            patientDataEntryTabControl.SelectedIndex = 0;
            patientDataEntryTabControl.ShowToolTips = true;
            patientDataEntryTabControl.Size = new Size(850, 466);
            patientDataEntryTabControl.SizeMode = TabSizeMode.Fixed;
            patientDataEntryTabControl.TabIndex = 0;
            patientDataEntryTabControl.TabStop = false;
            // 
            // patientBiographyTabPage
            // 
            patientBiographyTabPage.BackColor = Color.LightSteelBlue;
            patientBiographyTabPage.Controls.Add(PatientOccupationTextBox);
            patientBiographyTabPage.Controls.Add(patientOccupationLabel);
            patientBiographyTabPage.Controls.Add(patientBloodGroupComboBox);
            patientBiographyTabPage.Controls.Add(maskedTextBox1);
            patientBiographyTabPage.Controls.Add(patientEmergencyContacNumberMaskedTextBox);
            patientBiographyTabPage.Controls.Add(contactNumberMaskedTextBox);
            patientBiographyTabPage.Controls.Add(patientCNICMaskedTextBox);
            patientBiographyTabPage.Controls.Add(CNICLabel);
            patientBiographyTabPage.Controls.Add(dataSaveButton);
            patientBiographyTabPage.Controls.Add(patientEmergencyContactRelationTextBox);
            patientBiographyTabPage.Controls.Add(patientEmergencyContactRelationLabel);
            patientBiographyTabPage.Controls.Add(patientEmailAdderssTextBox);
            patientBiographyTabPage.Controls.Add(patientEmailLabel);
            patientBiographyTabPage.Controls.Add(patientEmergencyContactNumberLabel);
            patientBiographyTabPage.Controls.Add(patientEmergencyContactNameTextBox);
            patientBiographyTabPage.Controls.Add(patientEmergencyContactNameLabel);
            patientBiographyTabPage.Controls.Add(patientEmergencyContactInformationLabel);
            patientBiographyTabPage.Controls.Add(patientContactNumberLabel);
            patientBiographyTabPage.Controls.Add(patientAdderssTextBox);
            patientBiographyTabPage.Controls.Add(patientAdderssLabel);
            patientBiographyTabPage.Controls.Add(contactInformationLabel);
            patientBiographyTabPage.Controls.Add(patientBloodGroupLabel);
            patientBiographyTabPage.Controls.Add(patientAgeLabel);
            patientBiographyTabPage.Controls.Add(patientGenderComboBox);
            patientBiographyTabPage.Controls.Add(patientLastNameTextBox);
            patientBiographyTabPage.Controls.Add(patientLastNameLabel);
            patientBiographyTabPage.Controls.Add(patientGenderLabel);
            patientBiographyTabPage.Controls.Add(patientFirstNameTextBox);
            patientBiographyTabPage.Controls.Add(patientFirstNameLabel);
            patientBiographyTabPage.ForeColor = Color.Black;
            patientBiographyTabPage.ImeMode = ImeMode.NoControl;
            patientBiographyTabPage.Location = new Point(140, 4);
            patientBiographyTabPage.Name = "patientBiographyTabPage";
            patientBiographyTabPage.Padding = new Padding(3);
            patientBiographyTabPage.Size = new Size(706, 458);
            patientBiographyTabPage.TabIndex = 0;
            patientBiographyTabPage.Text = "Patient Biography";
            // 
            // PatientOccupationTextBox
            // 
            PatientOccupationTextBox.Location = new Point(433, 106);
            PatientOccupationTextBox.Name = "PatientOccupationTextBox";
            PatientOccupationTextBox.Size = new Size(100, 23);
            PatientOccupationTextBox.TabIndex = 41;
            // 
            // patientOccupationLabel
            // 
            patientOccupationLabel.AutoSize = true;
            patientOccupationLabel.Location = new Point(433, 86);
            patientOccupationLabel.Name = "patientOccupationLabel";
            patientOccupationLabel.Size = new Size(74, 17);
            patientOccupationLabel.TabIndex = 40;
            patientOccupationLabel.Text = "Occupation";
            // 
            // patientBloodGroupComboBox
            // 
            patientBloodGroupComboBox.FormattingEnabled = true;
            patientBloodGroupComboBox.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            patientBloodGroupComboBox.Location = new Point(148, 106);
            patientBloodGroupComboBox.Name = "patientBloodGroupComboBox";
            patientBloodGroupComboBox.Size = new Size(121, 25);
            patientBloodGroupComboBox.TabIndex = 39;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(38, 106);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 38;
            // 
            // patientEmergencyContacNumberMaskedTextBox
            // 
            patientEmergencyContacNumberMaskedTextBox.Location = new Point(162, 320);
            patientEmergencyContacNumberMaskedTextBox.Mask = "0000-0000";
            patientEmergencyContacNumberMaskedTextBox.Name = "patientEmergencyContacNumberMaskedTextBox";
            patientEmergencyContacNumberMaskedTextBox.Size = new Size(100, 23);
            patientEmergencyContacNumberMaskedTextBox.TabIndex = 37;
            // 
            // contactNumberMaskedTextBox
            // 
            contactNumberMaskedTextBox.Location = new Point(158, 221);
            contactNumberMaskedTextBox.Mask = "0000-0000";
            contactNumberMaskedTextBox.Name = "contactNumberMaskedTextBox";
            contactNumberMaskedTextBox.Size = new Size(100, 23);
            contactNumberMaskedTextBox.TabIndex = 36;
            // 
            // patientCNICMaskedTextBox
            // 
            patientCNICMaskedTextBox.Location = new Point(288, 104);
            patientCNICMaskedTextBox.Mask = "00000-0000000-0";
            patientCNICMaskedTextBox.Name = "patientCNICMaskedTextBox";
            patientCNICMaskedTextBox.Size = new Size(100, 23);
            patientCNICMaskedTextBox.TabIndex = 34;
            // 
            // CNICLabel
            // 
            CNICLabel.AutoSize = true;
            CNICLabel.Location = new Point(288, 86);
            CNICLabel.Name = "CNICLabel";
            CNICLabel.Size = new Size(38, 17);
            CNICLabel.TabIndex = 30;
            CNICLabel.Text = "CNIC";
            // 
            // dataSaveButton
            // 
            dataSaveButton.BackColor = SystemColors.ButtonFace;
            dataSaveButton.FlatStyle = FlatStyle.Flat;
            dataSaveButton.Location = new Point(491, 309);
            dataSaveButton.Name = "dataSaveButton";
            dataSaveButton.Size = new Size(111, 44);
            dataSaveButton.TabIndex = 28;
            dataSaveButton.Text = "Save ";
            dataSaveButton.UseVisualStyleBackColor = false;
            // 
            // patientEmergencyContactRelationTextBox
            // 
            patientEmergencyContactRelationTextBox.Location = new Point(275, 320);
            patientEmergencyContactRelationTextBox.Name = "patientEmergencyContactRelationTextBox";
            patientEmergencyContactRelationTextBox.Size = new Size(100, 23);
            patientEmergencyContactRelationTextBox.TabIndex = 27;
            // 
            // patientEmergencyContactRelationLabel
            // 
            patientEmergencyContactRelationLabel.AutoSize = true;
            patientEmergencyContactRelationLabel.Location = new Point(275, 302);
            patientEmergencyContactRelationLabel.Name = "patientEmergencyContactRelationLabel";
            patientEmergencyContactRelationLabel.Size = new Size(79, 17);
            patientEmergencyContactRelationLabel.TabIndex = 26;
            patientEmergencyContactRelationLabel.Text = "Relationship";
            // 
            // patientEmailAdderssTextBox
            // 
            patientEmailAdderssTextBox.Location = new Point(275, 219);
            patientEmailAdderssTextBox.Name = "patientEmailAdderssTextBox";
            patientEmailAdderssTextBox.Size = new Size(100, 23);
            patientEmailAdderssTextBox.TabIndex = 25;
            // 
            // patientEmailLabel
            // 
            patientEmailLabel.AutoSize = true;
            patientEmailLabel.Location = new Point(275, 201);
            patientEmailLabel.Name = "patientEmailLabel";
            patientEmailLabel.Size = new Size(91, 17);
            patientEmailLabel.TabIndex = 24;
            patientEmailLabel.Text = "Email Adderss";
            // 
            // patientEmergencyContactNumberLabel
            // 
            patientEmergencyContactNumberLabel.AutoSize = true;
            patientEmergencyContactNumberLabel.Location = new Point(158, 302);
            patientEmergencyContactNumberLabel.Name = "patientEmergencyContactNumberLabel";
            patientEmergencyContactNumberLabel.Size = new Size(104, 17);
            patientEmergencyContactNumberLabel.TabIndex = 22;
            patientEmergencyContactNumberLabel.Text = "Contact Number";
            // 
            // patientEmergencyContactNameTextBox
            // 
            patientEmergencyContactNameTextBox.Location = new Point(38, 320);
            patientEmergencyContactNameTextBox.Name = "patientEmergencyContactNameTextBox";
            patientEmergencyContactNameTextBox.Size = new Size(100, 23);
            patientEmergencyContactNameTextBox.TabIndex = 21;
            // 
            // patientEmergencyContactNameLabel
            // 
            patientEmergencyContactNameLabel.AutoSize = true;
            patientEmergencyContactNameLabel.Location = new Point(38, 302);
            patientEmergencyContactNameLabel.Name = "patientEmergencyContactNameLabel";
            patientEmergencyContactNameLabel.Size = new Size(43, 17);
            patientEmergencyContactNameLabel.TabIndex = 20;
            patientEmergencyContactNameLabel.Text = "Name";
            // 
            // patientEmergencyContactInformationLabel
            // 
            patientEmergencyContactInformationLabel.AutoSize = true;
            patientEmergencyContactInformationLabel.Location = new Point(38, 264);
            patientEmergencyContactInformationLabel.Name = "patientEmergencyContactInformationLabel";
            patientEmergencyContactInformationLabel.Size = new Size(192, 17);
            patientEmergencyContactInformationLabel.TabIndex = 19;
            patientEmergencyContactInformationLabel.Text = "Emergency Contact Information";
            // 
            // patientContactNumberLabel
            // 
            patientContactNumberLabel.AutoSize = true;
            patientContactNumberLabel.Location = new Point(158, 201);
            patientContactNumberLabel.Name = "patientContactNumberLabel";
            patientContactNumberLabel.Size = new Size(104, 17);
            patientContactNumberLabel.TabIndex = 17;
            patientContactNumberLabel.Text = "Contact Number";
            // 
            // patientAdderssTextBox
            // 
            patientAdderssTextBox.Location = new Point(38, 219);
            patientAdderssTextBox.Name = "patientAdderssTextBox";
            patientAdderssTextBox.Size = new Size(100, 23);
            patientAdderssTextBox.TabIndex = 16;
            // 
            // patientAdderssLabel
            // 
            patientAdderssLabel.AutoSize = true;
            patientAdderssLabel.Location = new Point(38, 201);
            patientAdderssLabel.Name = "patientAdderssLabel";
            patientAdderssLabel.Size = new Size(56, 17);
            patientAdderssLabel.TabIndex = 15;
            patientAdderssLabel.Text = "Adderss";
            // 
            // contactInformationLabel
            // 
            contactInformationLabel.AutoSize = true;
            contactInformationLabel.Location = new Point(38, 163);
            contactInformationLabel.Name = "contactInformationLabel";
            contactInformationLabel.Size = new Size(124, 17);
            contactInformationLabel.TabIndex = 14;
            contactInformationLabel.Text = "Contact Information";
            // 
            // patientBloodGroupLabel
            // 
            patientBloodGroupLabel.AutoSize = true;
            patientBloodGroupLabel.Location = new Point(148, 86);
            patientBloodGroupLabel.Name = "patientBloodGroupLabel";
            patientBloodGroupLabel.Size = new Size(84, 17);
            patientBloodGroupLabel.TabIndex = 13;
            patientBloodGroupLabel.Text = "Blood Group";
            // 
            // patientAgeLabel
            // 
            patientAgeLabel.AutoSize = true;
            patientAgeLabel.Location = new Point(38, 86);
            patientAgeLabel.Name = "patientAgeLabel";
            patientAgeLabel.Size = new Size(31, 17);
            patientAgeLabel.TabIndex = 11;
            patientAgeLabel.Text = "Age";
            // 
            // patientGenderComboBox
            // 
            patientGenderComboBox.FormattingEnabled = true;
            patientGenderComboBox.Items.AddRange(new object[] { "Male", "Female", "Other" });
            patientGenderComboBox.Location = new Point(343, 35);
            patientGenderComboBox.Name = "patientGenderComboBox";
            patientGenderComboBox.Size = new Size(121, 25);
            patientGenderComboBox.TabIndex = 10;
            // 
            // patientLastNameTextBox
            // 
            patientLastNameTextBox.Location = new Point(144, 35);
            patientLastNameTextBox.Name = "patientLastNameTextBox";
            patientLastNameTextBox.Size = new Size(100, 23);
            patientLastNameTextBox.TabIndex = 7;
            // 
            // patientLastNameLabel
            // 
            patientLastNameLabel.AutoSize = true;
            patientLastNameLabel.Location = new Point(144, 17);
            patientLastNameLabel.Name = "patientLastNameLabel";
            patientLastNameLabel.Size = new Size(70, 17);
            patientLastNameLabel.TabIndex = 6;
            patientLastNameLabel.Text = "Last Name";
            // 
            // patientGenderLabel
            // 
            patientGenderLabel.AutoSize = true;
            patientGenderLabel.Location = new Point(343, 17);
            patientGenderLabel.Name = "patientGenderLabel";
            patientGenderLabel.Size = new Size(51, 17);
            patientGenderLabel.TabIndex = 4;
            patientGenderLabel.Text = "Gender";
            // 
            // patientFirstNameTextBox
            // 
            patientFirstNameTextBox.Location = new Point(38, 35);
            patientFirstNameTextBox.Name = "patientFirstNameTextBox";
            patientFirstNameTextBox.Size = new Size(100, 23);
            patientFirstNameTextBox.TabIndex = 3;
            // 
            // patientFirstNameLabel
            // 
            patientFirstNameLabel.AutoSize = true;
            patientFirstNameLabel.Location = new Point(38, 17);
            patientFirstNameLabel.Name = "patientFirstNameLabel";
            patientFirstNameLabel.Size = new Size(71, 17);
            patientFirstNameLabel.TabIndex = 2;
            patientFirstNameLabel.Text = "First Name";
            // 
            // medicalHistoryTabPage
            // 
            medicalHistoryTabPage.BackColor = Color.LightSteelBlue;
            medicalHistoryTabPage.Controls.Add(AllergiesLable);
            medicalHistoryTabPage.Location = new Point(140, 4);
            medicalHistoryTabPage.Name = "medicalHistoryTabPage";
            medicalHistoryTabPage.Padding = new Padding(3);
            medicalHistoryTabPage.Size = new Size(706, 427);
            medicalHistoryTabPage.TabIndex = 1;
            medicalHistoryTabPage.Text = "Medical History";
            // 
            // AllergiesLable
            // 
            AllergiesLable.AutoSize = true;
            AllergiesLable.Location = new Point(87, 53);
            AllergiesLable.Name = "AllergiesLable";
            AllergiesLable.Size = new Size(58, 17);
            AllergiesLable.TabIndex = 0;
            AllergiesLable.Text = "Allergies";
            // 
            // labHistoryTabPage
            // 
            labHistoryTabPage.Location = new Point(140, 4);
            labHistoryTabPage.Name = "labHistoryTabPage";
            labHistoryTabPage.Size = new Size(706, 427);
            labHistoryTabPage.TabIndex = 2;
            labHistoryTabPage.Text = "Lab History";
            labHistoryTabPage.UseVisualStyleBackColor = true;
            // 
            // radiologyTabPage
            // 
            radiologyTabPage.BackColor = SystemColors.ActiveCaption;
            radiologyTabPage.Controls.Add(richTextBox1);
            radiologyTabPage.Controls.Add(label4);
            radiologyTabPage.Controls.Add(textBox1);
            radiologyTabPage.Controls.Add(label3);
            radiologyTabPage.Controls.Add(dateTimePicker1);
            radiologyTabPage.Controls.Add(label2);
            radiologyTabPage.Controls.Add(comboBox1);
            radiologyTabPage.Controls.Add(label1);
            radiologyTabPage.Location = new Point(140, 4);
            radiologyTabPage.Name = "radiologyTabPage";
            radiologyTabPage.Size = new Size(706, 427);
            radiologyTabPage.TabIndex = 3;
            radiologyTabPage.Text = "Radiology";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(444, 78);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(254, 82);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(444, 58);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 6;
            label4.Text = "Findings";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 238);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 218);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 4;
            label3.Text = "Radiologist";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(50, 163);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(238, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 143);
            label2.Name = "label2";
            label2.Size = new Size(103, 17);
            label2.TabIndex = 2;
            label2.Text = "Date of Imaging";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Standard X-rays", "Fluoroscopy", "CT Angiography (CTA)", "CT Colonography (Virtual Colonoscopy)", "Magnetic Resonance Angiography (MRA)", "Functional MRI (fMRI)", "Diffusion-weighted Imaging (DWI)", "Obstetric Ultrasound", "Doppler Ultrasound", "Positron Emission Tomography (PET)", "Single Photon Emission Computed Tomography (SPECT)", "Barium Swallow", "Barium Enema", "Digital Mammography", "3D Mammography (Tomosynthesis)", "Dual-energy X-ray Absorptiometry", "Angiography", "Embolization", "Transthoracic Echocardiography (TTE)", "Transesophageal Echocardiography (TEE)", "Voiding Cystourethrogram (VCUG)", "Joint Imaging" });
            comboBox1.Location = new Point(50, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 58);
            label1.Name = "label1";
            label1.Size = new Size(88, 17);
            label1.TabIndex = 0;
            label1.Text = "Imaging Type";
            // 
            // proceduresTabPage
            // 
            proceduresTabPage.Location = new Point(140, 4);
            proceduresTabPage.Name = "proceduresTabPage";
            proceduresTabPage.Size = new Size(706, 427);
            proceduresTabPage.TabIndex = 4;
            proceduresTabPage.Text = "Procedures / Surgury";
            proceduresTabPage.UseVisualStyleBackColor = true;
            // 
            // referTabPage
            // 
            referTabPage.Location = new Point(140, 4);
            referTabPage.Name = "referTabPage";
            referTabPage.Size = new Size(706, 427);
            referTabPage.TabIndex = 5;
            referTabPage.Text = "Refer";
            referTabPage.UseVisualStyleBackColor = true;
            // 
            // cunsultentOpinionTabPage
            // 
            cunsultentOpinionTabPage.Location = new Point(140, 4);
            cunsultentOpinionTabPage.Name = "cunsultentOpinionTabPage";
            cunsultentOpinionTabPage.Size = new Size(706, 427);
            cunsultentOpinionTabPage.TabIndex = 6;
            cunsultentOpinionTabPage.Text = "Cunsultent Opinion";
            cunsultentOpinionTabPage.UseVisualStyleBackColor = true;
            // 
            // caseSummaryTabPage
            // 
            caseSummaryTabPage.Location = new Point(140, 4);
            caseSummaryTabPage.Name = "caseSummaryTabPage";
            caseSummaryTabPage.Size = new Size(706, 427);
            caseSummaryTabPage.TabIndex = 7;
            caseSummaryTabPage.Text = "Case Summary";
            caseSummaryTabPage.UseVisualStyleBackColor = true;
            // 
            // PatientDataEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 530);
            Controls.Add(patientDataEntryTabControl);
            Name = "PatientDataEntryForm";
            Text = "Patient Data Entry ";
            patientDataEntryTabControl.ResumeLayout(false);
            patientBiographyTabPage.ResumeLayout(false);
            patientBiographyTabPage.PerformLayout();
            medicalHistoryTabPage.ResumeLayout(false);
            medicalHistoryTabPage.PerformLayout();
            radiologyTabPage.ResumeLayout(false);
            radiologyTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControls.DotNetBarTabControl patientDataEntryTabControl;
        private TabPage patientBiographyTabPage;
        private TabPage medicalHistoryTabPage;
        private TabPage labHistoryTabPage;
        private TabPage radiologyTabPage;
        private TabPage proceduresTabPage;
        private TabPage referTabPage;
        private TabPage cunsultentOpinionTabPage;
        private TabPage caseSummaryTabPage;
        private TextBox patientLastNameTextBox;
        private Label patientLastNameLabel;
        private TextBox textBox3;
        private Label patientGenderLabel;
        private TextBox patientFirstNameTextBox;
        private Label patientFirstNameLabel;
        private ComboBox patientGenderComboBox;
        private Label patientBloodGroupLabel;
        private Label patientAgeLabel;
        private Label patientContactNumberLabel;
        private TextBox patientAdderssTextBox;
        private Label patientAdderssLabel;
        private Label contactInformationLabel;
        private TextBox patientEmergencyContactRelationTextBox;
        private Label patientEmergencyContactRelationLabel;
        private TextBox patientEmailAdderssTextBox;
        private Label patientEmailLabel;
        private Label patientEmergencyContactNumberLabel;
        private TextBox patientEmergencyContactNameTextBox;
        private Label patientEmergencyContactNameLabel;
        private Label patientEmergencyContactInformationLabel;
        private Button dataSaveButton;
        private Label CNICLabel;
        private Label label15;
        private TextBox textBox12;
        private ComboBox comboBox1;
        private MaskedTextBox contactNumberMaskedTextBox;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox patientCNICMaskedTextBox;
        private MaskedTextBox patientEmergencyContacNumberMaskedTextBox;
        private TextBox PatientOccupationTextBox;
        private Label patientOccupationLabel;
        private ComboBox patientBloodGroupComboBox;
        private MaskedTextBox maskedTextBox1;
        private Label AllergiesLable;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
    }
}
