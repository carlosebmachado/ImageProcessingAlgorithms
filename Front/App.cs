using IPA.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Security;
using System.Windows.Forms;

namespace IPA.Front
{
    public partial class App : Form
    {
        private List<ImageData> _images = new List<ImageData>();
        private List<ImageData> _applyed = new List<ImageData>();

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
                string[] fileNames = openFileDialog.FileNames;
                // le os arquivos selecionados
                foreach (string file in fileNames)
                {
                    //txtFile.Text += file;
                    try
                    {
                        Image img = Image.FromFile(file);
                        _images.Add(new ImageData((Bitmap)img, file));
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
            // verifica se tem imagens para salvar
            if (_applyed.Count == 0)
            {
                MessageBox.Show("Não há nada para salvar.",
                                "Imagem",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            // percorre as imagens com efeitos e salva 
            foreach (var id in _applyed)
            {
                id.Image.Save(id.GetFullName() + ".jpg");
            }
            _applyed.Clear();
        }

        private void CleanAll(object sender, EventArgs e)
        {
            // reseta todos os dados
            flpOriginal.Controls.Clear();
            flpEffect.Controls.Clear();
            _images.Clear();
            _applyed.Clear();
        }

        private void CleanOriginal(object sender, EventArgs e)
        {
            // reseta os dados de imagens carregadas
            flpOriginal.Controls.Clear();
            _images.Clear();
        }

        private void CleanEffect(object sender, EventArgs e)
        {
            // reseta os dados de imagens com efeitos
            flpEffect.Controls.Clear();
            _applyed.Clear();
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
            // monitora o tempo decorrido
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            // percorre as imagens carregadas e aplica os efeitos em cada uma e cria uma nova com o efeito aplicado
            foreach (var id in _images)
            {
                _applyed.Add(new ImageData(ImageEffects.SimpleGrayScale(id.Image), id.GetFullName() + "(simple_gray_scale)" + ".jpg"));
            }
            stopwatch.Stop();

            DisplayImagesEffect();

            ShowElapsedTime(stopwatch.Elapsed.ToString());
        }

        private void GrayScaleW(object sender, EventArgs e)
        {
            if (NoImages()) return;

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            foreach (var id in _images)
            {
                _applyed.Add(new ImageData(ImageEffects.WeightedGrayScale(id.Image), id.GetFullName() + "(weighted_gray_scale)" + ".jpg"));
            }
            stopwatch.Stop();

            DisplayImagesEffect();

            ShowElapsedTime(stopwatch.Elapsed.ToString());
        }

        private void Negative(object sender, EventArgs e)
        {
            if (NoImages()) return;

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            foreach (var id in _images)
            {
                _applyed.Add(new ImageData(ImageEffects.Negative(id.Image), id.GetFullName() + "(negative)" + ".jpg"));
            }
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
            // verifica se é necessário aplicar pb antes de alicar o limiar
            if (bw)
            {
                foreach (var id in _images)
                {
                    _applyed.Add(new ImageData(ImageEffects.Threshold(ImageEffects.SimpleGrayScale(id.Image), L), id.GetFullName() + "(threshold)" + ".jpg"));
                }
            }
            else
            {
                foreach (var id in _images)
                {
                    _applyed.Add(new ImageData(ImageEffects.Threshold(id.Image, L), id.GetFullName() + "(threshold)" + ".jpg"));
                }
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
            if (CorrectImageAmount()) return;
            if (CompatibleImages()) return;

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            // pega as duas imagens e aplica o efeito para gerar apenas uma imagens
            _applyed.Add(new ImageData(ImageEffects.Adiction(_images[0].Image, _images[1].Image, p), _images[0].GetFullName() + _images[1].Name + "(addiction)" + ".jpg"));
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
            if (CorrectImageAmount()) return;
            if (CompatibleImages()) return;

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            // é possível inverter a ordem das imagens para um efeito diferente na subtração
            if (invert)
            {
                _applyed.Add(new ImageData(ImageEffects.Subtraction(_images[0].Image, _images[1].Image, invert), _images[1].GetFullName() + _images[0].Name + "(subtraction)" + ".jpg"));
            }
            else
            {
                _applyed.Add(new ImageData(ImageEffects.Subtraction(_images[0].Image, _images[1].Image, invert), _images[0].GetFullName() + _images[1].Name + "(subtraction)" + ".jpg"));
            }
            stopwatch.Stop();

            DisplayImagesEffect();

            ShowElapsedTime(stopwatch.Elapsed.ToString());
        }

        #endregion Effects

        #region Aux

        private PictureBox GenericPB(int h, int w, Image image)
        {
            // caixa generica de imagem para ser aplicada no container
            // calculo de proporção para não haver distorção
            float fw = 100F / h * w;
            return new PictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Height = 100,
                Width = (int)fw,
                Image = image
            };
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
            // limpa as existentes e dispoe as imagens novamente com as novas
            flpEffect.Controls.Clear();
            foreach (var a in _applyed)
            {
                var img = a.Image;
                flpEffect.Controls.Add(GenericPB(img.Height, img.Width, img));
            }
        }

        private bool CompatibleImages()
        {
            if (!(_images[0].Image.Width < _images[1].Image.Width && _images[0].Image.Height < _images[1].Image.Height ||
                  _images[1].Image.Width < _images[0].Image.Width && _images[1].Image.Height < _images[0].Image.Height ||
                  _images[1].Image.Width == _images[0].Image.Width && _images[1].Image.Height == _images[0].Image.Height))
            {
                MessageBox.Show("Imagens incompatíveis. Se as imagens forem de tamanhos diferentes, " +
                                "uma delas deve ser menor tanto na altura quanto na largura." +
                                "Procure também não usar imagens de tamanhos muito diferentes.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private bool CorrectImageAmount()
        {
            if (_images.Count != 2)
            {
                MessageBox.Show("Você deve selecionar duas imagens.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private bool NoImages()
        {
            if (_images.Count == 0)
            {
                MessageBox.Show("Nenhuma imagem foi selecionada.",
                                "Imagem",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        #endregion Aux
    }
}
