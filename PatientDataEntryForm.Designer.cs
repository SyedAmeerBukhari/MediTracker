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
            patientBiographyDataEntryTabPage = new TabPage();
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
            medicalHistoryDataEntryTabPage = new TabPage();
            button1 = new Button();
            textBox2 = new TextBox();
            allergiesListBox = new ListBox();
            AllergiesLable = new Label();
            labHistoryDataEntryTabPage = new TabPage();
            radiologyDataEntryTabPage = new TabPage();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            comboBox1 = new ComboBox();
            proceduresDataEntryTabPage = new TabPage();
            referDataEntryTabPage = new TabPage();
            cunsultentOpinionDataEntryTabPage = new TabPage();
            patientDataEntryTabControl.SuspendLayout();
            patientBiographyDataEntryTabPage.SuspendLayout();
            medicalHistoryDataEntryTabPage.SuspendLayout();
            radiologyDataEntryTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // patientDataEntryTabControl
            // 
            patientDataEntryTabControl.Alignment = TabAlignment.Left;
            patientDataEntryTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            patientDataEntryTabControl.Controls.Add(patientBiographyDataEntryTabPage);
            patientDataEntryTabControl.Controls.Add(medicalHistoryDataEntryTabPage);
            patientDataEntryTabControl.Controls.Add(labHistoryDataEntryTabPage);
            patientDataEntryTabControl.Controls.Add(radiologyDataEntryTabPage);
            patientDataEntryTabControl.Controls.Add(proceduresDataEntryTabPage);
            patientDataEntryTabControl.Controls.Add(referDataEntryTabPage);
            patientDataEntryTabControl.Controls.Add(cunsultentOpinionDataEntryTabPage);
            patientDataEntryTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            patientDataEntryTabControl.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientDataEntryTabControl.ItemSize = new Size(44, 136);
            patientDataEntryTabControl.Location = new Point(-1, 73);
            patientDataEntryTabControl.Margin = new Padding(0);
            patientDataEntryTabControl.Multiline = true;
            patientDataEntryTabControl.Name = "patientDataEntryTabControl";
            patientDataEntryTabControl.Padding = new Point(0, 0);
            patientDataEntryTabControl.RightToLeft = RightToLeft.No;
            patientDataEntryTabControl.SelectedIndex = 0;
            patientDataEntryTabControl.ShowToolTips = true;
            patientDataEntryTabControl.Size = new Size(850, 458);
            patientDataEntryTabControl.SizeMode = TabSizeMode.Fixed;
            patientDataEntryTabControl.TabIndex = 0;
            patientDataEntryTabControl.TabStop = false;
            // 
            // patientBiographyDataEntryTabPage
            // 
            patientBiographyDataEntryTabPage.BackColor = SystemColors.Control;
            patientBiographyDataEntryTabPage.Controls.Add(PatientOccupationTextBox);
            patientBiographyDataEntryTabPage.Controls.Add(patientOccupationLabel);
            patientBiographyDataEntryTabPage.Controls.Add(patientBloodGroupComboBox);
            patientBiographyDataEntryTabPage.Controls.Add(maskedTextBox1);
            patientBiographyDataEntryTabPage.Controls.Add(patientEmergencyContacNumberMaskedTextBox);
            patientBiographyDataEntryTabPage.Controls.Add(contactNumberMaskedTextBox);
            patientBiographyDataEntryTabPage.Controls.Add(patientCNICMaskedTextBox);
            patientBiographyDataEntryTabPage.Controls.Add(CNICLabel);
            patientBiographyDataEntryTabPage.Controls.Add(dataSaveButton);
            patientBiographyDataEntryTabPage.Controls.Add(patientEmergencyContactRelationTextBox);
            patientBiographyDataEntryTabPage.Controls.Add(patientEmergencyContactRelationLabel);
            patientBiographyDataEntryTabPage.Controls.Add(patientEmailAdderssTextBox);
            patientBiographyDataEntryTabPage.Controls.Add(patientEmailLabel);
            patientBiographyDataEntryTabPage.Controls.Add(patientEmergencyContactNumberLabel);
            patientBiographyDataEntryTabPage.Controls.Add(patientEmergencyContactNameTextBox);
            patientBiographyDataEntryTabPage.Controls.Add(patientEmergencyContactNameLabel);
            patientBiographyDataEntryTabPage.Controls.Add(patientEmergencyContactInformationLabel);
            patientBiographyDataEntryTabPage.Controls.Add(patientContactNumberLabel);
            patientBiographyDataEntryTabPage.Controls.Add(patientAdderssTextBox);
            patientBiographyDataEntryTabPage.Controls.Add(patientAdderssLabel);
            patientBiographyDataEntryTabPage.Controls.Add(contactInformationLabel);
            patientBiographyDataEntryTabPage.Controls.Add(patientBloodGroupLabel);
            patientBiographyDataEntryTabPage.Controls.Add(patientAgeLabel);
            patientBiographyDataEntryTabPage.Controls.Add(patientGenderComboBox);
            patientBiographyDataEntryTabPage.Controls.Add(patientLastNameTextBox);
            patientBiographyDataEntryTabPage.Controls.Add(patientLastNameLabel);
            patientBiographyDataEntryTabPage.Controls.Add(patientGenderLabel);
            patientBiographyDataEntryTabPage.Controls.Add(patientFirstNameTextBox);
            patientBiographyDataEntryTabPage.Controls.Add(patientFirstNameLabel);
            patientBiographyDataEntryTabPage.ForeColor = Color.Black;
            patientBiographyDataEntryTabPage.ImeMode = ImeMode.NoControl;
            patientBiographyDataEntryTabPage.Location = new Point(140, 4);
            patientBiographyDataEntryTabPage.Name = "patientBiographyDataEntryTabPage";
            patientBiographyDataEntryTabPage.Padding = new Padding(3);
            patientBiographyDataEntryTabPage.Size = new Size(706, 450);
            patientBiographyDataEntryTabPage.TabIndex = 0;
            patientBiographyDataEntryTabPage.Text = "Patient Biography";
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
            patientEmailLabel.Text = "Email Address";
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
            patientAdderssLabel.Text = "Address";
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
            // medicalHistoryDataEntryTabPage
            // 
            medicalHistoryDataEntryTabPage.BackColor = SystemColors.Control;
            medicalHistoryDataEntryTabPage.Controls.Add(button1);
            medicalHistoryDataEntryTabPage.Controls.Add(textBox2);
            medicalHistoryDataEntryTabPage.Controls.Add(allergiesListBox);
            medicalHistoryDataEntryTabPage.Controls.Add(AllergiesLable);
            medicalHistoryDataEntryTabPage.Location = new Point(140, 4);
            medicalHistoryDataEntryTabPage.Name = "medicalHistoryDataEntryTabPage";
            medicalHistoryDataEntryTabPage.Padding = new Padding(3);
            medicalHistoryDataEntryTabPage.Size = new Size(706, 450);
            medicalHistoryDataEntryTabPage.TabIndex = 1;
            medicalHistoryDataEntryTabPage.Text = "Medical History";
            // 
            // button1
            // 
            button1.Location = new Point(315, 37);
            button1.Name = "button1";
            button1.Size = new Size(115, 36);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 44);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 23);
            textBox2.TabIndex = 2;
            // 
            // allergiesListBox
            // 
            allergiesListBox.BackColor = SystemColors.Control;
            allergiesListBox.FormattingEnabled = true;
            allergiesListBox.ItemHeight = 17;
            allergiesListBox.Location = new Point(56, 73);
            allergiesListBox.Name = "allergiesListBox";
            allergiesListBox.Size = new Size(253, 106);
            allergiesListBox.TabIndex = 1;
            // 
            // AllergiesLable
            // 
            AllergiesLable.AutoSize = true;
            AllergiesLable.Location = new Point(56, 47);
            AllergiesLable.Name = "AllergiesLable";
            AllergiesLable.Size = new Size(58, 17);
            AllergiesLable.TabIndex = 0;
            AllergiesLable.Text = "Allergies";
            // 
            // labHistoryDataEntryTabPage
            // 
            labHistoryDataEntryTabPage.BackColor = SystemColors.Control;
            labHistoryDataEntryTabPage.Location = new Point(140, 4);
            labHistoryDataEntryTabPage.Name = "labHistoryDataEntryTabPage";
            labHistoryDataEntryTabPage.Size = new Size(706, 450);
            labHistoryDataEntryTabPage.TabIndex = 2;
            labHistoryDataEntryTabPage.Text = "Lab History";
            // 
            // radiologyDataEntryTabPage
            // 
            radiologyDataEntryTabPage.BackColor = SystemColors.Control;
            radiologyDataEntryTabPage.Controls.Add(label1);
            radiologyDataEntryTabPage.Controls.Add(richTextBox1);
            radiologyDataEntryTabPage.Controls.Add(label4);
            radiologyDataEntryTabPage.Controls.Add(textBox1);
            radiologyDataEntryTabPage.Controls.Add(label3);
            radiologyDataEntryTabPage.Controls.Add(dateTimePicker1);
            radiologyDataEntryTabPage.Controls.Add(label2);
            radiologyDataEntryTabPage.Controls.Add(comboBox1);
            radiologyDataEntryTabPage.Location = new Point(140, 4);
            radiologyDataEntryTabPage.Name = "radiologyDataEntryTabPage";
            radiologyDataEntryTabPage.Size = new Size(706, 450);
            radiologyDataEntryTabPage.TabIndex = 3;
            radiologyDataEntryTabPage.Text = "Radiology";
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
            // proceduresDataEntryTabPage
            // 
            proceduresDataEntryTabPage.BackColor = SystemColors.Control;
            proceduresDataEntryTabPage.Location = new Point(140, 4);
            proceduresDataEntryTabPage.Name = "proceduresDataEntryTabPage";
            proceduresDataEntryTabPage.Size = new Size(706, 450);
            proceduresDataEntryTabPage.TabIndex = 4;
            proceduresDataEntryTabPage.Text = "Procedures / Surgury";
            // 
            // referDataEntryTabPage
            // 
            referDataEntryTabPage.BackColor = SystemColors.Control;
            referDataEntryTabPage.Location = new Point(140, 4);
            referDataEntryTabPage.Name = "referDataEntryTabPage";
            referDataEntryTabPage.Size = new Size(706, 450);
            referDataEntryTabPage.TabIndex = 5;
            referDataEntryTabPage.Text = "Refer";
            // 
            // cunsultentOpinionDataEntryTabPage
            // 
            cunsultentOpinionDataEntryTabPage.BackColor = SystemColors.Control;
            cunsultentOpinionDataEntryTabPage.Location = new Point(140, 4);
            cunsultentOpinionDataEntryTabPage.Name = "cunsultentOpinionDataEntryTabPage";
            cunsultentOpinionDataEntryTabPage.Size = new Size(706, 450);
            cunsultentOpinionDataEntryTabPage.TabIndex = 6;
            cunsultentOpinionDataEntryTabPage.Text = "Cunsultent Opinion";
            // 
            // PatientDataEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(847, 530);
            Controls.Add(patientDataEntryTabControl);
            Name = "PatientDataEntryForm";
            Text = "Patient Data Entry ";
            patientDataEntryTabControl.ResumeLayout(false);
            patientBiographyDataEntryTabPage.ResumeLayout(false);
            patientBiographyDataEntryTabPage.PerformLayout();
            medicalHistoryDataEntryTabPage.ResumeLayout(false);
            medicalHistoryDataEntryTabPage.PerformLayout();
            radiologyDataEntryTabPage.ResumeLayout(false);
            radiologyDataEntryTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControls.DotNetBarTabControl patientDataEntryTabControl;
        private TabPage patientBiographyDataEntryTabPage;
        private TabPage medicalHistoryDataEntryTabPage;
        private TabPage labHistoryDataEntryTabPage;
        private TabPage radiologyDataEntryTabPage;
        private TabPage proceduresDataEntryTabPage;
        private TabPage referDataEntryTabPage;
        private TabPage cunsultentOpinionDataEntryTabPage;
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
        private ListBox allergiesListBox;
        private Button button1;
        private TextBox textBox2;
    }
}
