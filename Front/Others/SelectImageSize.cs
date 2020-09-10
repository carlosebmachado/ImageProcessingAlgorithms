using System;
using System.Windows.Forms;

namespace IPA.Front
{
    public partial class SelectImageSize : Form
    {
        public SelectImageSize()
        {
            InitializeComponent();
        }

        private void Confirm(object sender, EventArgs e)
        {
            App app = (App)Application.OpenForms[0];
            app.SetImageSize(float.Parse(txtSize.Text), cbAllow.Checked);
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
