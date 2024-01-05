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

        private void loginButton_Click(object sender, EventArgs e)
        {
            mainMenuForm mainMenuForm = new mainMenuForm();
            mainMenuForm.Show();
        }
    }
}
