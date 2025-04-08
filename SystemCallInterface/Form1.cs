using System;
using System.IO;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace SystemCallInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LogSystemCall(string systemCall)
        {
            string logPath = "C:\\Users\\Public\\systemcall_log.txt";
            string user = Session.LoggedInUser;
            string logEntry = $"{DateTime.Now} | User: {user} | Call: {systemCall}";

            try
            {
                File.AppendAllText(logPath, logEntry + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Log Error: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\Public\\testfile.txt";
            try
            {
                if (!File.Exists(path))
                {
                    File.Create(path).Close();
                    MessageBox.Show($"✅ File created: {path}");
                    LogSystemCall("CreateFile: testfile.txt");
                }
                else
                {
                    MessageBox.Show($"ℹ️ File already exists: {path}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}");
            }
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\Public\\testfile.txt";
            string contentToWrite = txtInput.Text;

            try
            {
                File.WriteAllText(path, contentToWrite);
                txtOutput.Text = $"✅ File written successfully!\n\n🧠 WriteFile: This function writes content into a file (overwrites if it already exists).";
                LogSystemCall("WriteFile: testfile.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\Public\\testfile.txt";
            try
            {
                if (File.Exists(path))
                {
                    string content = File.ReadAllText(path);
                    txtOutput.Text = $"📄 File Content:\n{content}\n\n🧠 ReadFile: Reads the content of a file.";
                    LogSystemCall("ReadFile: testfile.txt");
                }
                else
                {
                    MessageBox.Show($"⚠️ File not found: {path}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Clear session
            Session.LoggedInUser = "";

            // Show Login Form again
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            // Close current form
            this.Hide();
        }

        private void lblInput_Click(object sender, EventArgs e)
        {

        }
    }
}
