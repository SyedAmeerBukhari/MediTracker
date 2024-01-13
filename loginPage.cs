// Ignore Spelling: Medi

using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MediTracker
{
    public partial class loginPage : Form
    {
        
        public loginPage()
        {
            InitializeComponent();
        }

        private void RegisterNowLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrationForm registrationForm = new registrationForm();
            registrationForm.Show();
        }

        private async void DisplayMessageBoxForSeconds(string message, int seconds)
        {
            // Show the MessageBox
            MessageBox.Show(message);

            // Wait for the specified duration asynchronously
            await Task.Delay(seconds * 1000);

            // Close the MessageBox programmatically (if needed)
            foreach (Form form in Application.OpenForms)
            {
                if (form is MessageBox)
                {
                    form.Close();
                    break;
                }
            }
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-57U88QT\\MSSQLSERVER01;Initial Catalog=PatientDB;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");

            // Assuming you have textboxes for username and password
            string username = loginUserNameTextBox.Text;
            string password = loginPasswordTextBox.Text;

            con.Open();

            // Perform a SELECT query to check if the username and password exist
            string query = "SELECT COUNT(*) FROM Doctor WHERE Username = @Username AND Password = @Password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            int result = (int)cmd.ExecuteScalar();
            con.Close();

            if (result > 0)
            {
                // Successful login
                DisplayMessageBoxForSeconds("Login successful", 2);
                mainMenuForm mainMenuForm = new mainMenuForm();
                mainMenuForm.Show();
            }
            else
            {
                // Failed login
                invalidCredentialsLabel.Visible = true;
            }

          
        }
    }
}
