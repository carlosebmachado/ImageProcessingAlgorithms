using IPA.Core;
using System;
using System.Diagnostics;
using System.Security;
using System.Windows.Forms;

namespace IPA.Front
{
	public partial class BgSubtractionForm : Form
	{
		private bool _selected = false;

		private string _path;

		public BgSubtractionForm()
		{
			InitializeComponent();
		}

		private void Clean()
		{
			_selected = false;
			_path = "";
		}

		private void VideoSelect_Click(object sender, EventArgs e)
		{
			if (_selected)
			{
				if (MessageBox.Show("Se você selecionar outro conteúdo, o atual será sobrescrito. Quer continuar?",
					"Aviso",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Clean();
				}
				else
				{
					return;
				}
			}
			_selected = true;

			// filtros e propriedades de seleção
			openFileDialog.Multiselect = false;
			openFileDialog.Title = "Selecionar vídeo";
			openFileDialog.Filter = "Vídeos (*.MP4;*.AVI;*.FLV,*.MKV,*.MOV)|*.MP4;*.AVI;*.FLV,*.MKV,*.MOV|" + "All files (*.*)|*.*";
			openFileDialog.CheckFileExists = true;
			openFileDialog.CheckPathExists = true;
			openFileDialog.FilterIndex = 1;
			openFileDialog.RestoreDirectory = true;
			openFileDialog.ReadOnlyChecked = true;
			openFileDialog.ShowReadOnly = true;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				_path = openFileDialog.FileName;
				try
				{
					wmpOriginal.URL = _path;
				}
				catch (SecurityException ex)
				{
					MessageBox.Show("Erro de segurança.\n\n" +
									"Mensagem : " + ex.Message + "\n\n" +
									"Detalhes:\n\n" + ex.StackTrace,
									"Erro de segurança",
									MessageBoxButtons.OK,
									MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Não é possível carregar o arquivo: " +
									_path.Substring(_path.LastIndexOf('\\')) +
									". Falta de permição ou arquivo corrompido." +
									"\n\nErro reportado: " + ex.Message + "\n\n" +
									"Detalhes:\n\n" + ex.StackTrace,
									"Erro",
									MessageBoxButtons.OK,
									MessageBoxIcon.Error);
				}
			}
		}

		private void SaveVideo_Click(object sender, EventArgs e)
		{

		}

		private void Clean_Click(object sender, EventArgs e)
		{
			Clean();
		}

		private void Apply_Click(object sender, EventArgs e)
		{
			if (!_selected)
			{
				MessageBox.Show(
					"Nenhum vídeo selecionado.",
					"Aviso",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var stopwatch = new Stopwatch();
			stopwatch.Start();
			wmpEffect.URL = M3Algorithms.BackgroundSubtraction(_path);
			stopwatch.Stop();

			ShowElapsedTime(stopwatch.Elapsed.ToString());
		}

		private void ShowElapsedTime(string t)
		{
			MessageBox.Show("Tempo decorrido: " + t + ".",
							"Tempo",
							MessageBoxButtons.OK,
							MessageBoxIcon.Information);
		}

		private void DoublePlay_Click(object sender, EventArgs e)
		{
			wmpOriginal.Ctlcontrols.currentPosition = 0;
			wmpOriginal.Ctlcontrols.play();
			wmpEffect.Ctlcontrols.currentPosition = 0;
			wmpEffect.Ctlcontrols.play();
		}
	}
}
