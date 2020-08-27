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
    public partial class ConvoluctionConfigs : Form
    {
        public ConvoluctionConfigs()
        {
            InitializeComponent();
        }

        private void Confirm(object sender, EventArgs e)
        {
            App app = (App)Application.OpenForms[0];
            var matrix = new int[][]
            {
                new int[] { int.Parse(tb00.Text), int.Parse(tb01.Text), int.Parse(tb02.Text), int.Parse(tb03.Text), int.Parse(tb04.Text) },
                new int[] { int.Parse(tb10.Text), int.Parse(tb11.Text), int.Parse(tb12.Text), int.Parse(tb13.Text), int.Parse(tb14.Text) },
                new int[] { int.Parse(tb20.Text), int.Parse(tb21.Text), int.Parse(tb22.Text), int.Parse(tb23.Text), int.Parse(tb24.Text) },
                new int[] { int.Parse(tb30.Text), int.Parse(tb31.Text), int.Parse(tb32.Text), int.Parse(tb33.Text), int.Parse(tb34.Text) },
                new int[] { int.Parse(tb40.Text), int.Parse(tb41.Text), int.Parse(tb42.Text), int.Parse(tb43.Text), int.Parse(tb44.Text) }
            };
            app.Convoluction(matrix, int.Parse(txtDiv.Text), cbRed.Checked, cbGreen.Checked, cbBlue.Checked);
            Close();
        }
    }
}
