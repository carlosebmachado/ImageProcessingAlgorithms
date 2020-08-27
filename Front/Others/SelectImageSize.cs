using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
