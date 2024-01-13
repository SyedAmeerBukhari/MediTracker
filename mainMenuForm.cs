// Ignore Spelling: Medi

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediTracker
{
    public partial class mainMenuForm : Form
    {
        public mainMenuForm()
        {
            InitializeComponent();
        }

        private void exisitingPatientdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatientDataViewForm patientDataViewForm = new PatientDataViewForm();
            patientDataViewForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientDataEntryForm patientDataEntryForm = new PatientDataEntryForm();
            patientDataEntryForm.Show();
        }

        private void newPatentEntryButton_Click(object sender, EventArgs e)
        {
            PatientDataEntryForm patientDataEntryForm = new PatientDataEntryForm();
            patientDataEntryForm.Show();
        }

        private void exisitingPatientdataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            PatientDataViewForm patientDataViewForm1 = new PatientDataViewForm();
            patientDataViewForm1.Show();
        }
    }
}
