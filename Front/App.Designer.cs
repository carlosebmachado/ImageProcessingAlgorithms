namespace IPA.Front
{
    partial class App
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClean = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCleanAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCleanOriginal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCleanEffect = new System.Windows.Forms.ToolStripMenuItem();
            this.tonsDeCinzaSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGrayScaleS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGrayScaleW = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNegative = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThreshold = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddition = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSubtraction = new System.Windows.Forms.ToolStripMenuItem();
            this.domínioDeEspaçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConvoluction = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSharpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdgeEnhance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdgeDetect1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdgeDetect2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiObjectDetect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHighlightingRelief = new System.Windows.Forms.ToolStripMenuItem();
            this.erosãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPersonalMorphology = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDilation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiErosion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMorphOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmoMorphClose = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbEffect = new System.Windows.Forms.GroupBox();
            this.flpEffect = new System.Windows.Forms.FlowLayoutPanel();
            this.gbOriginal = new System.Windows.Forms.GroupBox();
            this.flpOriginal = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.gbEffect.SuspendLayout();
            this.gbOriginal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.tonsDeCinzaSToolStripMenuItem,
            this.domínioDeEspaçoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(720, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.tsmiClean});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.LoadFiles);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.SaveFiles);
            // 
            // tsmiClean
            // 
            this.tsmiClean.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCleanAll,
            this.tsmiCleanOriginal,
            this.tsmiCleanEffect});
            this.tsmiClean.Name = "tsmiClean";
            this.tsmiClean.Size = new System.Drawing.Size(111, 22);
            this.tsmiClean.Text = "Limpar";
            // 
            // tsmiCleanAll
            // 
            this.tsmiCleanAll.Name = "tsmiCleanAll";
            this.tsmiCleanAll.Size = new System.Drawing.Size(116, 22);
            this.tsmiCleanAll.Text = "Tudo";
            this.tsmiCleanAll.Click += new System.EventHandler(this.CleanAll);
            // 
            // tsmiCleanOriginal
            // 
            this.tsmiCleanOriginal.Name = "tsmiCleanOriginal";
            this.tsmiCleanOriginal.Size = new System.Drawing.Size(116, 22);
            this.tsmiCleanOriginal.Text = "Original";
            this.tsmiCleanOriginal.Click += new System.EventHandler(this.CleanOriginal);
            // 
            // tsmiCleanEffect
            // 
            this.tsmiCleanEffect.Name = "tsmiCleanEffect";
            this.tsmiCleanEffect.Size = new System.Drawing.Size(116, 22);
            this.tsmiCleanEffect.Text = "Efeito";
            this.tsmiCleanEffect.Click += new System.EventHandler(this.CleanEffect);
            // 
            // tonsDeCinzaSToolStripMenuItem
            // 
            this.tonsDeCinzaSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGrayScaleS,
            this.tsmiGrayScaleW,
            this.tsmiNegative,
            this.tsmiThreshold,
            this.tsmiAddition,
            this.tsmiSubtraction});
            this.tonsDeCinzaSToolStripMenuItem.Name = "tonsDeCinzaSToolStripMenuItem";
            this.tonsDeCinzaSToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.tonsDeCinzaSToolStripMenuItem.Text = "Domínio de Valor";
            // 
            // tsmiGrayScaleS
            // 
            this.tsmiGrayScaleS.Name = "tsmiGrayScaleS";
            this.tsmiGrayScaleS.Size = new System.Drawing.Size(162, 22);
            this.tsmiGrayScaleS.Text = "Tons de cinza (S)";
            this.tsmiGrayScaleS.Click += new System.EventHandler(this.GrayScaleS);
            // 
            // tsmiGrayScaleW
            // 
            this.tsmiGrayScaleW.Name = "tsmiGrayScaleW";
            this.tsmiGrayScaleW.Size = new System.Drawing.Size(162, 22);
            this.tsmiGrayScaleW.Text = "Tons de cinza (P)";
            this.tsmiGrayScaleW.Click += new System.EventHandler(this.GrayScaleW);
            // 
            // tsmiNegative
            // 
            this.tsmiNegative.Name = "tsmiNegative";
            this.tsmiNegative.Size = new System.Drawing.Size(162, 22);
            this.tsmiNegative.Text = "Negativa";
            this.tsmiNegative.Click += new System.EventHandler(this.Negative);
            // 
            // tsmiThreshold
            // 
            this.tsmiThreshold.Name = "tsmiThreshold";
            this.tsmiThreshold.Size = new System.Drawing.Size(162, 22);
            this.tsmiThreshold.Text = "Limiarização";
            this.tsmiThreshold.Click += new System.EventHandler(this.ThresholdForm);
            // 
            // tsmiAddition
            // 
            this.tsmiAddition.Name = "tsmiAddition";
            this.tsmiAddition.Size = new System.Drawing.Size(162, 22);
            this.tsmiAddition.Text = "Adição";
            this.tsmiAddition.Click += new System.EventHandler(this.AdditionForm);
            // 
            // tsmiSubtraction
            // 
            this.tsmiSubtraction.Name = "tsmiSubtraction";
            this.tsmiSubtraction.Size = new System.Drawing.Size(162, 22);
            this.tsmiSubtraction.Text = "Subtração";
            this.tsmiSubtraction.Click += new System.EventHandler(this.SubtractionForm);
            // 
            // domínioDeEspaçoToolStripMenuItem
            // 
            this.domínioDeEspaçoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConvoluction,
            this.erosãoToolStripMenuItem});
            this.domínioDeEspaçoToolStripMenuItem.Name = "domínioDeEspaçoToolStripMenuItem";
            this.domínioDeEspaçoToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.domínioDeEspaçoToolStripMenuItem.Text = "Domínio de Espaço";
            // 
            // tsmiConvoluction
            // 
            this.tsmiConvoluction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizadoToolStripMenuItem,
            this.borrarToolStripMenuItem1,
            this.tsmiSharpen,
            this.tsmiEdgeEnhance,
            this.tsmiEdgeDetect1,
            this.tsmiEdgeDetect2,
            this.tsmiObjectDetect,
            this.tsmiHighlightingRelief});
            this.tsmiConvoluction.Name = "tsmiConvoluction";
            this.tsmiConvoluction.Size = new System.Drawing.Size(180, 22);
            this.tsmiConvoluction.Text = "Convolução";
            this.tsmiConvoluction.Click += new System.EventHandler(this.ConvoluctionForm);
            // 
            // personalizadoToolStripMenuItem
            // 
            this.personalizadoToolStripMenuItem.Name = "personalizadoToolStripMenuItem";
            this.personalizadoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.personalizadoToolStripMenuItem.Text = "Personalizado";
            this.personalizadoToolStripMenuItem.Click += new System.EventHandler(this.ConvoluctionForm);
            // 
            // borrarToolStripMenuItem1
            // 
            this.borrarToolStripMenuItem1.Name = "borrarToolStripMenuItem1";
            this.borrarToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.borrarToolStripMenuItem1.Text = "Borrar";
            this.borrarToolStripMenuItem1.Click += new System.EventHandler(this.Blur);
            // 
            // tsmiSharpen
            // 
            this.tsmiSharpen.Name = "tsmiSharpen";
            this.tsmiSharpen.Size = new System.Drawing.Size(166, 22);
            this.tsmiSharpen.Text = "Aguçar";
            this.tsmiSharpen.Click += new System.EventHandler(this.Sharpen);
            // 
            // tsmiEdgeEnhance
            // 
            this.tsmiEdgeEnhance.Name = "tsmiEdgeEnhance";
            this.tsmiEdgeEnhance.Size = new System.Drawing.Size(166, 22);
            this.tsmiEdgeEnhance.Text = "Realçar Bordas";
            this.tsmiEdgeEnhance.Click += new System.EventHandler(this.EdgeEnhance);
            // 
            // tsmiEdgeDetect1
            // 
            this.tsmiEdgeDetect1.Name = "tsmiEdgeDetect1";
            this.tsmiEdgeDetect1.Size = new System.Drawing.Size(166, 22);
            this.tsmiEdgeDetect1.Text = "Detectar Bordas 1";
            this.tsmiEdgeDetect1.Click += new System.EventHandler(this.EdgeDetect1);
            // 
            // tsmiEdgeDetect2
            // 
            this.tsmiEdgeDetect2.Name = "tsmiEdgeDetect2";
            this.tsmiEdgeDetect2.Size = new System.Drawing.Size(166, 22);
            this.tsmiEdgeDetect2.Text = "Detectar Bordas 2";
            this.tsmiEdgeDetect2.Click += new System.EventHandler(this.EdgeDetect2);
            // 
            // tsmiObjectDetect
            // 
            this.tsmiObjectDetect.Name = "tsmiObjectDetect";
            this.tsmiObjectDetect.Size = new System.Drawing.Size(166, 22);
            this.tsmiObjectDetect.Text = "Detectar Objetos";
            this.tsmiObjectDetect.Click += new System.EventHandler(this.ObjectsDetect);
            // 
            // tsmiHighlightingRelief
            // 
            this.tsmiHighlightingRelief.Name = "tsmiHighlightingRelief";
            this.tsmiHighlightingRelief.Size = new System.Drawing.Size(166, 22);
            this.tsmiHighlightingRelief.Text = "Destacar Relevo";
            this.tsmiHighlightingRelief.Click += new System.EventHandler(this.HighlightingRelief);
            // 
            // erosãoToolStripMenuItem
            // 
            this.erosãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPersonalMorphology,
            this.tsmiDilation,
            this.tsmiErosion,
            this.tsmiMorphOpen,
            this.tsmoMorphClose});
            this.erosãoToolStripMenuItem.Name = "erosãoToolStripMenuItem";
            this.erosãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.erosãoToolStripMenuItem.Text = "Morfologia";
            // 
            // tsmiPersonalMorphology
            // 
            this.tsmiPersonalMorphology.Name = "tsmiPersonalMorphology";
            this.tsmiPersonalMorphology.Size = new System.Drawing.Size(180, 22);
            this.tsmiPersonalMorphology.Text = "Personalizado";
            this.tsmiPersonalMorphology.Click += new System.EventHandler(this.CustonMorphologyForm);
            // 
            // tsmiDilation
            // 
            this.tsmiDilation.Name = "tsmiDilation";
            this.tsmiDilation.Size = new System.Drawing.Size(180, 22);
            this.tsmiDilation.Text = "Dilatação";
            this.tsmiDilation.Click += new System.EventHandler(this.Dilation);
            // 
            // tsmiErosion
            // 
            this.tsmiErosion.Name = "tsmiErosion";
            this.tsmiErosion.Size = new System.Drawing.Size(180, 22);
            this.tsmiErosion.Text = "Erosão";
            this.tsmiErosion.Click += new System.EventHandler(this.Erosion);
            // 
            // tsmiMorphOpen
            // 
            this.tsmiMorphOpen.Name = "tsmiMorphOpen";
            this.tsmiMorphOpen.Size = new System.Drawing.Size(180, 22);
            this.tsmiMorphOpen.Text = "Abertura";
            this.tsmiMorphOpen.Click += new System.EventHandler(this.MorphOpen);
            // 
            // tsmoMorphClose
            // 
            this.tsmoMorphClose.Name = "tsmoMorphClose";
            this.tsmoMorphClose.Size = new System.Drawing.Size(180, 22);
            this.tsmoMorphClose.Text = "Fechamento";
            this.tsmoMorphClose.Click += new System.EventHandler(this.MorphClose);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créditosToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.sairToolStripMenuItem.Text = "Ajuda";
            // 
            // créditosToolStripMenuItem
            // 
            this.créditosToolStripMenuItem.Name = "créditosToolStripMenuItem";
            this.créditosToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.créditosToolStripMenuItem.Text = "Sobre";
            this.créditosToolStripMenuItem.Click += new System.EventHandler(this.About);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.Exit);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.gbEffect, 0, 0);
            this.tlpMain.Controls.Add(this.gbOriginal, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 24);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(720, 426);
            this.tlpMain.TabIndex = 7;
            // 
            // gbEffect
            // 
            this.gbEffect.Controls.Add(this.flpEffect);
            this.gbEffect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEffect.Location = new System.Drawing.Point(363, 3);
            this.gbEffect.Name = "gbEffect";
            this.gbEffect.Size = new System.Drawing.Size(354, 420);
            this.gbEffect.TabIndex = 8;
            this.gbEffect.TabStop = false;
            this.gbEffect.Text = "Efeito";
            // 
            // flpEffect
            // 
            this.flpEffect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpEffect.Location = new System.Drawing.Point(6, 16);
            this.flpEffect.Margin = new System.Windows.Forms.Padding(0);
            this.flpEffect.Name = "flpEffect";
            this.flpEffect.Size = new System.Drawing.Size(345, 401);
            this.flpEffect.TabIndex = 5;
            // 
            // gbOriginal
            // 
            this.gbOriginal.Controls.Add(this.flpOriginal);
            this.gbOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOriginal.Location = new System.Drawing.Point(3, 3);
            this.gbOriginal.Name = "gbOriginal";
            this.gbOriginal.Size = new System.Drawing.Size(354, 420);
            this.gbOriginal.TabIndex = 5;
            this.gbOriginal.TabStop = false;
            this.gbOriginal.Text = "Original";
            // 
            // flpOriginal
            // 
            this.flpOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpOriginal.Location = new System.Drawing.Point(6, 16);
            this.flpOriginal.Margin = new System.Windows.Forms.Padding(0);
            this.flpOriginal.Name = "flpOriginal";
            this.flpOriginal.Size = new System.Drawing.Size(345, 401);
            this.flpOriginal.TabIndex = 5;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmos de processamento de imagens";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.gbEffect.ResumeLayout(false);
            this.gbOriginal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tonsDeCinzaSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiGrayScaleS;
        private System.Windows.Forms.ToolStripMenuItem tsmiGrayScaleW;
        private System.Windows.Forms.ToolStripMenuItem tsmiNegative;
        private System.Windows.Forms.ToolStripMenuItem tsmiThreshold;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddition;
        private System.Windows.Forms.ToolStripMenuItem tsmiSubtraction;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiClean;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox gbEffect;
        private System.Windows.Forms.FlowLayoutPanel flpEffect;
        private System.Windows.Forms.GroupBox gbOriginal;
        private System.Windows.Forms.FlowLayoutPanel flpOriginal;
        private System.Windows.Forms.ToolStripMenuItem tsmiCleanAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiCleanOriginal;
        private System.Windows.Forms.ToolStripMenuItem tsmiCleanEffect;
        private System.Windows.Forms.ToolStripMenuItem créditosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem domínioDeEspaçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiConvoluction;
        private System.Windows.Forms.ToolStripMenuItem personalizadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdgeDetect1;
        private System.Windows.Forms.ToolStripMenuItem tsmiObjectDetect;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSharpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdgeEnhance;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdgeDetect2;
        private System.Windows.Forms.ToolStripMenuItem tsmiHighlightingRelief;
        private System.Windows.Forms.ToolStripMenuItem erosãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDilation;
        private System.Windows.Forms.ToolStripMenuItem tsmiErosion;
        private System.Windows.Forms.ToolStripMenuItem tsmiMorphOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmoMorphClose;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonalMorphology;
    }
}

