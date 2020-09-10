using System;
using System.Windows.Forms;

namespace IPA.Front
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
            app.AdditionW((float)trackBar.Value / 100);
            Close();
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            lblImg1.Text = (100 - trackBar.Value).ToString();
            lblImg2.Text = trackBar.Value.ToString();
        }

        private void EnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                Confirm(new object(), new EventArgs());
            }
        }
    }
}
