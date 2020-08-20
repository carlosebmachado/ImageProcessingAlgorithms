using IPA.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Security;
using System.Windows.Forms;

namespace IPA
{
    public partial class App : Form
    {
        private List<Bitmap> _images = new List<Bitmap>();
        private List<Bitmap> _applyed;
        private string[] _fileNames;

        public App()
        {
            InitializeComponent();
        }

        #region Interface

        private void LoadFiles(object sender, EventArgs e)
        {
            // filtros e propriedades de seleção
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Selecionar imagem";
            openFileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ReadOnlyChecked = true;
            openFileDialog.ShowReadOnly = true;
            
            DialogResult dr = openFileDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                _fileNames = openFileDialog.FileNames;
                // le os arquivos selecionados
                foreach (string file in _fileNames)
                {
                    //txtFile.Text += file;
                    try
                    {
                        Image img = Image.FromFile(file);
                        _images.Add((Bitmap)img);
                        flpOriginal.Controls.Add(GenericPB(img.Height, img.Width, img));
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
                        MessageBox.Show("Não é possível exibir a imagem: " +
                                        file.Substring(file.LastIndexOf('\\'))+
                                        ". Falta de permição ou arquivo corrompido." +
                                        "\n\nErro reportado: " + ex.Message + "\n\n" +
                                        "Detalhes:\n\n" + ex.StackTrace,
                                        "Erro",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SaveFiles(object sender, EventArgs e)
        {
            if (NoImages()) return;
            if (_applyed == null)
            {
                MessageBox.Show("Não há nada para salvar.",
                                "Imagem",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < _applyed.Count; i++)
            {
                string fn = _fileNames[i].Substring(0, _fileNames[i].Length - 4);
                _applyed[i].Save(fn + "_effect_.jpg");
            }
        }

        private void CleanAll(object sender, EventArgs e)
        {
            flpOriginal.Controls.Clear();
            flpEffect.Controls.Clear();
            _images = new List<Bitmap>();
            _applyed = null;
            _fileNames = null;
        }

        private void CleanOriginal(object sender, EventArgs e)
        {
            flpOriginal.Controls.Clear();
            _images = new List<Bitmap>();
        }

        private void CleanEffect(object sender, EventArgs e)
        {
            flpEffect.Controls.Clear();
            _applyed = null;
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void About(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        #endregion Interface

        #region Effects

        private void GrayScaleS(object sender, EventArgs e)
        {
            if (NoImages()) return;

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            _applyed = ImageEffects.SimpleGrayScale(_images);
            stopwatch.Stop();

            DisplayImagesEffect();

            ShowElapsedTime(stopwatch.Elapsed.ToString());
        }

        private void GrayScaleW(object sender, EventArgs e)
        {
            if (NoImages()) return;

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            _applyed = ImageEffects.SimpleGrayScale(_images);
            stopwatch.Stop();

            DisplayImagesEffect();

            ShowElapsedTime(stopwatch.Elapsed.ToString());
        }

        private void Negative(object sender, EventArgs e)
        {
            if (NoImages()) return;

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            _applyed = ImageEffects.Negative(_images);
            stopwatch.Stop();

            DisplayImagesEffect();

            ShowElapsedTime(stopwatch.Elapsed.ToString());
        }

        private void ThresholdForm(object sender, EventArgs e)
        {
            new ThresholdConfigs().ShowDialog();
        }

        public void Threshold(bool bw, int L)
        {
            if (NoImages()) return;

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            if (bw)
            {
                _applyed = ImageEffects.Threshold(ImageEffects.SimpleGrayScale(_images), L);
            }
            else
            {
                _applyed = ImageEffects.Threshold(_images, L);
            }
            stopwatch.Stop();

            DisplayImagesEffect();

            ShowElapsedTime(stopwatch.Elapsed.ToString());
        }

        private void AdditionForm(object sender, EventArgs e)
        {
            new AdditionConfigs().ShowDialog();
        }

        public void Addition(float p)
        {
            if (NoImages()) return;
            if(_images.Count != 2)
            {
                MessageBox.Show("Selecione apenas duas imagens.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            if (!(_images[0].Width < _images[1].Width && _images[0].Height < _images[1].Height ||
                  _images[1].Width < _images[0].Width && _images[1].Height < _images[0].Height ||
                  _images[1].Width == _images[0].Width && _images[1].Height == _images[0].Height))
            {
                MessageBox.Show("Imagens incompatíveis. Se as imagens forem de tamanhos diferentes, " +
                                "uma delas deve ser menor tanto na altura quanto na largura.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            _applyed = ImageEffects.Adiction(_images[0], _images[1], p);
            stopwatch.Stop();

            DisplayImagesEffect();

            ShowElapsedTime(stopwatch.Elapsed.ToString());
        }



        private void SubtractionForm(object sender, EventArgs e)
        {
            new SubtractionConfigs().ShowDialog();
        }

        public void Subtraction(bool invert)
        {
            if (NoImages()) return;
            if (_images.Count != 2)
            {
                MessageBox.Show("Selecione apenas duas imagens.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            if (!(_images[0].Width < _images[1].Width && _images[0].Height < _images[1].Height ||
                  _images[1].Width < _images[0].Width && _images[1].Height < _images[0].Height ||
                  _images[1].Width == _images[0].Width && _images[1].Height == _images[0].Height))
            {
                MessageBox.Show("Imagens incompatíveis. Se as imagens forem de tamanhos diferentes, " +
                                "uma delas deve ser menor tanto na altura quanto na largura." +
                                "Procure também não usar imagens de tamanhos muito diferentes.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            _applyed = ImageEffects.Subtraction(_images[0], _images[1], invert);
            stopwatch.Stop();

            DisplayImagesEffect();

            ShowElapsedTime(stopwatch.Elapsed.ToString());
        }

        #endregion Effects

        #region Aux

        private PictureBox GenericPB(int h, int w, Image image)
        {
            float fw = 100F / h * w;
            return new PictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Height = 100,
                Width = (int)fw,
                Image = image
            };
        }

        private bool NoImages()
        {
            if (_fileNames == null)
            {
                MessageBox.Show("Nenhuma imagem foi selecionada.",
                                "Imagem",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void ShowElapsedTime(string t)
        {
            MessageBox.Show("Tempo decorrido: " + t + ".",
                            "Tempo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void DisplayImagesEffect()
        {
            foreach (var a in _applyed)
            {
                flpEffect.Controls.Add(GenericPB(a.Height, a.Width, a));
            }
        }

        #endregion Aux
    }
}
