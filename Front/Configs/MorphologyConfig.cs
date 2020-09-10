using System;
using System.Windows.Forms;

namespace IPA.Front
{
    public partial class MorphologyConfig : Form
    {
        public MorphologyConfig()
        {
            InitializeComponent();
        }

        private void Confirm(object sender, EventArgs e)
        {
            App app = (App)Application.OpenForms[0];
            var size = 2;
            int[][] matrix;
            if (rbSize.Checked)
            {
                size = int.Parse(txtSize.Text);
                var mSize = size * 2 + 1;
                matrix = new int[mSize][];
                for (int i = 0; i < mSize; i++)
                {
                    matrix[i] = new int[mSize];
                    for (int j = 0; j < mSize; j++)
                    {
                        matrix[i][j] = 1;
                    }
                }
            }
            else
            {
                matrix = new int[][]
                {
                new int[] { int.Parse(tb00.Text), int.Parse(tb01.Text), int.Parse(tb02.Text), int.Parse(tb03.Text), int.Parse(tb04.Text) },
                new int[] { int.Parse(tb10.Text), int.Parse(tb11.Text), int.Parse(tb12.Text), int.Parse(tb13.Text), int.Parse(tb14.Text) },
                new int[] { int.Parse(tb20.Text), int.Parse(tb21.Text), int.Parse(tb22.Text), int.Parse(tb23.Text), int.Parse(tb24.Text) },
                new int[] { int.Parse(tb30.Text), int.Parse(tb31.Text), int.Parse(tb32.Text), int.Parse(tb33.Text), int.Parse(tb34.Text) },
                new int[] { int.Parse(tb40.Text), int.Parse(tb41.Text), int.Parse(tb42.Text), int.Parse(tb43.Text), int.Parse(tb44.Text) }
                };
            }
            app.CustomMorphology(rbDilation.Checked, matrix, size);
            Close();
        }

        private void CustomSelect(object sender, EventArgs e)
        {
            gbCustom.Enabled = true;
            gbSize.Enabled = false;
        }

        private void SizeSelect(object sender, EventArgs e)
        {
            gbCustom.Enabled = false;
            gbSize.Enabled = true;
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
