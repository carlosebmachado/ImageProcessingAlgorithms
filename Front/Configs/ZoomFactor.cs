using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPA.Front.Configs
{
	public partial class ZoomFactor : Form
	{
		public int Zoom = 0;

		public ZoomFactor()
		{
			InitializeComponent();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			try
			{
				Zoom = int.Parse(txtZoomFactor.Text);
			}
			catch
			{
				MessageBox.Show("Formato incorreto.");
				return;
			}
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Cancelado.");
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
