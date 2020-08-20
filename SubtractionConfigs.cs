using System;
using System.Windows.Forms;

namespace IPA
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
    }
}
