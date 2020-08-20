using System;
using System.Windows.Forms;

namespace IPA
{
    public partial class AdditionConfigs : Form
    {
        public AdditionConfigs()
        {
            InitializeComponent();
        }

        private void Confirm(object sender, EventArgs e)
        {
            App app = (App)Application.OpenForms[0];
            app.Addition((float)trackBar.Value / 100);
            Close();
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            lblImg1.Text = (100 - trackBar.Value).ToString();
            lblImg2.Text = trackBar.Value.ToString();
        }
    }
}
