namespace MediTracker
{
    partial class mainMenuForm
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
            exisitingPatientdataGridView = new DataGridView();
            patentIdColumnReadTextBox = new DataGridViewTextBoxColumn();
            patientFullNameColumnReadTextBox = new DataGridViewTextBoxColumn();
            lastVisitColumnReadTextBox = new DataGridViewTextBoxColumn();
            viewDetailsColumnButton = new DataGridViewButtonColumn();
            newPatentEntryButton = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)exisitingPatientdataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(812, 100);
            panel1.TabIndex = 0;
            // 
            // exisitingPatientdataGridView
            // 
            exisitingPatientdataGridView.BackgroundColor = Color.WhiteSmoke;
            exisitingPatientdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            exisitingPatientdataGridView.Columns.AddRange(new DataGridViewColumn[] { patentIdColumnReadTextBox, patientFullNameColumnReadTextBox, lastVisitColumnReadTextBox, viewDetailsColumnButton });
            exisitingPatientdataGridView.Dock = DockStyle.Bottom;
            exisitingPatientdataGridView.Location = new Point(0, 243);
            exisitingPatientdataGridView.Name = "exisitingPatientdataGridView";
            exisitingPatientdataGridView.Size = new Size(812, 223);
            exisitingPatientdataGridView.TabIndex = 1;
            exisitingPatientdataGridView.CellContentClick += exisitingPatientdataGridView_CellContentClick;
            // 
            // patentIdColumnReadTextBox
            // 
            patentIdColumnReadTextBox.HeaderText = "ID";
            patentIdColumnReadTextBox.Name = "patentIdColumnReadTextBox";
            patentIdColumnReadTextBox.ReadOnly = true;
            // 
            // patientFullNameColumnReadTextBox
            // 
            patientFullNameColumnReadTextBox.HeaderText = "Name";
            patientFullNameColumnReadTextBox.Name = "patientFullNameColumnReadTextBox";
            patientFullNameColumnReadTextBox.ReadOnly = true;
            // 
            // lastVisitColumnReadTextBox
            // 
            lastVisitColumnReadTextBox.HeaderText = "Last Vist";
            lastVisitColumnReadTextBox.Name = "lastVisitColumnReadTextBox";
            lastVisitColumnReadTextBox.ReadOnly = true;
            // 
            // viewDetailsColumnButton
            // 
            viewDetailsColumnButton.HeaderText = "View Details";
            viewDetailsColumnButton.Name = "viewDetailsColumnButton";
            viewDetailsColumnButton.ReadOnly = true;
            viewDetailsColumnButton.Resizable = DataGridViewTriState.True;
            viewDetailsColumnButton.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // newPatentEntryButton
            // 
            newPatentEntryButton.Location = new Point(670, 171);
            newPatentEntryButton.Name = "newPatentEntryButton";
            newPatentEntryButton.Size = new Size(118, 36);
            newPatentEntryButton.TabIndex = 2;
            newPatentEntryButton.Text = "New Patient Entry";
            newPatentEntryButton.UseVisualStyleBackColor = true;
            newPatentEntryButton.Click += newPatentEntryButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 135);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 3;
            label1.Text = "Search Patient Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 23);
            textBox1.TabIndex = 4;
            // 
            // mainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 466);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(newPatentEntryButton);
            Controls.Add(exisitingPatientdataGridView);
            Controls.Add(panel1);
            Name = "mainMenuForm";
            Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)exisitingPatientdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView exisitingPatientdataGridView;
        private Button newPatentEntryButton;
        private DataGridViewTextBoxColumn patentIdColumnReadTextBox;
        private DataGridViewTextBoxColumn patientFullNameColumnReadTextBox;
        private DataGridViewTextBoxColumn lastVisitColumnReadTextBox;
        private DataGridViewButtonColumn viewDetailsColumnButton;
        private Label label1;
        private TextBox textBox1;
    }
}