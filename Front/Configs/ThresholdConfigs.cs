using System;
using System.Windows.Forms;

namespace IPA.Front
{
    public partial class ThresholdConfigs : Form
    {
        public ThresholdConfigs()
        {
            InitializeComponent();
        }

        private void Confirm(object sender, EventArgs e)
        {
            App app = (App)Application.OpenForms[0];
            app.Threshold(cbThreshold.Checked, int.Parse(txtThreshold.Text));
            Close();
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
