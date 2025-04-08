using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemCallInterface
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            progressBar.Maximum = 100;
            progressBar.Value = 0;
            timer.Interval = 30; // smoother slower transition
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(1);
            if (progressBar.Value >= 100)
            {
                timer.Stop();
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }
    }
}
