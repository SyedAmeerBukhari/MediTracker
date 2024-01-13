// Ignore Spelling: Medi

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MediTracker
{
    public partial class registrationForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-57U88QT\\MSSQLSERVER01;Initial Catalog=PatientDB;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");

        public registrationForm()
        {
            InitializeComponent();
        }

        private void registrationForm_Load(object sender, EventArgs e)
        {

        }

        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdatePasswordLabels();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (registerpasswordTextBox.Text == confirmPasswordTextBox.Text)
            {
                successLabel.Visible = true;
                unMatchPaswordLable.Visible = false;
                con.Open();
                string q = "INSERT INTO Doctor (Username, Password) VALUES (@Username, @Password)";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@Username", registerUserNameTextBox.Text);
                cmd.Parameters.AddWithValue("@Password", registerpasswordTextBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Successfully Saved");
            }
            else
            {
                successLabel.Visible = false;
                unMatchPaswordLable.Visible = true;
            }
        }

        private void UpdatePasswordLabels()
        {
            // Check if the passwords match and update label visibility accordingly
            if (registerpasswordTextBox.Text == confirmPasswordTextBox.Text)
            {
                successLabel.Visible = true;
                unMatchPaswordLable.Visible = false;
            }
            else
            {
                successLabel.Visible = false;
                unMatchPaswordLable.Visible = true;
            }
        }

        private void registerpasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (registerpasswordTextBox.Text == string.Empty)
            {
                successLabel.Visible = false;
                unMatchPaswordLable.Visible = false;
            }
        }
    }
}