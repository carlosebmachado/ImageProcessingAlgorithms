using System;
using System.Windows.Forms;

namespace IPA.Front
{
    public partial class SubtractionConfigs : Form
    {
        public SubtractionConfigs()
        {
            InitializeComponent();
        }

        private void Confirm(object sender, EventArgs e)
        {
            App app = (App)Application.OpenForms[0];
            app.Subtraction(cbSubtraction.Checked);
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
