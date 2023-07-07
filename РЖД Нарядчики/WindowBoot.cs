using System;
using System.Windows.Forms;

namespace РЖД_Нарядчики
{
    public partial class WindowBoot : Form
    {
        public WindowBoot()
        {
            InitializeComponent();
        }

        private void logo_Click(object sender, EventArgs e)
        { }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar.Increment(2);
            if (progressBar.Value == 100)
            {
                timer1.Enabled = false;
                Login form = new Login();
                form.Show();
                this.Hide();
            }
        }
    }
}
