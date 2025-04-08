using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace SystemCallInterface
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "password123")
            {
                // ✅ Store login info in Session
                Session.LoggedInUser = username;

                // ✅ Show Main Form
                Form1 mainForm = new Form1();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                //lblError.Text = "❌ Invalid username or password.";
            }
        }
    }
}
