namespace IPA.Front
{
	partial class BgSubtractionForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BgSubtractionForm));
			this.gbOriginal = new System.Windows.Forms.GroupBox();
			this.wmpOriginal = new AxWMPLib.AxWindowsMediaPlayer();
			this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
			this.gbEffect = new System.Windows.Forms.GroupBox();
			this.wmpEffect = new AxWMPLib.AxWindowsMediaPlayer();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiVideoSelect = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSaveVideo = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiClean = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiApply = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDoublePlay = new System.Windows.Forms.ToolStripMenuItem();
			this.gbOriginal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.wmpOriginal)).BeginInit();
			this.tlpMain.SuspendLayout();
			this.gbEffect.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.wmpEffect)).BeginInit();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbOriginal
			// 
			this.gbOriginal.Controls.Add(this.wmpOriginal);
			this.gbOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbOriginal.Location = new System.Drawing.Point(3, 3);
			this.gbOriginal.Name = "gbOriginal";
			this.gbOriginal.Size = new System.Drawing.Size(394, 420);
			this.gbOriginal.TabIndex = 5;
			this.gbOriginal.TabStop = false;
			this.gbOriginal.Text = "Original";
			// 
			// wmpOriginal
			// 
			this.wmpOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wmpOriginal.Enabled = true;
			this.wmpOriginal.Location = new System.Drawing.Point(3, 16);
			this.wmpOriginal.Name = "wmpOriginal";
			this.wmpOriginal.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpOriginal.OcxState")));
			this.wmpOriginal.Size = new System.Drawing.Size(388, 401);
			this.wmpOriginal.TabIndex = 0;
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
			this.tlpMain.Size = new System.Drawing.Size(800, 426);
			this.tlpMain.TabIndex = 8;
			// 
			// gbEffect
			// 
			this.gbEffect.Controls.Add(this.wmpEffect);
			this.gbEffect.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbEffect.Location = new System.Drawing.Point(403, 3);
			this.gbEffect.Name = "gbEffect";
			this.gbEffect.Size = new System.Drawing.Size(394, 420);
			this.gbEffect.TabIndex = 8;
			this.gbEffect.TabStop = false;
			this.gbEffect.Text = "Efeito";
			// 
			// wmpEffect
			// 
			this.wmpEffect.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wmpEffect.Enabled = true;
			this.wmpEffect.Location = new System.Drawing.Point(3, 16);
			this.wmpEffect.Name = "wmpEffect";
			this.wmpEffect.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpEffect.OcxState")));
			this.wmpEffect.Size = new System.Drawing.Size(388, 401);
			this.wmpEffect.TabIndex = 1;
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ferramentasToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(800, 24);
			this.menuStrip.TabIndex = 9;
			this.menuStrip.Text = "menuStrip";
			// 
			// arquivoToolStripMenuItem
			// 
			this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVideoSelect,
            this.tsmiSaveVideo,
            this.tsmiClean});
			this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
			this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.arquivoToolStripMenuItem.Text = "Arquivo";
			// 
			// tsmiVideoSelect
			// 
			this.tsmiVideoSelect.Name = "tsmiVideoSelect";
			this.tsmiVideoSelect.Size = new System.Drawing.Size(180, 22);
			this.tsmiVideoSelect.Text = "Abrir vídeo...";
			this.tsmiVideoSelect.Click += new System.EventHandler(this.VideoSelect_Click);
			// 
			// tsmiSaveVideo
			// 
			this.tsmiSaveVideo.Name = "tsmiSaveVideo";
			this.tsmiSaveVideo.Size = new System.Drawing.Size(180, 22);
			this.tsmiSaveVideo.Text = "Salvar vídeo";
			this.tsmiSaveVideo.Click += new System.EventHandler(this.SaveVideo_Click);
			// 
			// tsmiClean
			// 
			this.tsmiClean.Name = "tsmiClean";
			this.tsmiClean.Size = new System.Drawing.Size(180, 22);
			this.tsmiClean.Text = "Limpar";
			this.tsmiClean.Click += new System.EventHandler(this.Clean_Click);
			// 
			// ferramentasToolStripMenuItem
			// 
			this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiApply,
            this.tsmiDoublePlay});
			this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
			this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
			this.ferramentasToolStripMenuItem.Text = "Ferramentas";
			// 
			// tsmiApply
			// 
			this.tsmiApply.Name = "tsmiApply";
			this.tsmiApply.Size = new System.Drawing.Size(217, 22);
			this.tsmiApply.Text = "Aplicar subtração de fundo";
			this.tsmiApply.Click += new System.EventHandler(this.Apply_Click);
			// 
			// tsmiDoublePlay
			// 
			this.tsmiDoublePlay.Name = "tsmiDoublePlay";
			this.tsmiDoublePlay.Size = new System.Drawing.Size(217, 22);
			this.tsmiDoublePlay.Text = "Duplo play";
			this.tsmiDoublePlay.Click += new System.EventHandler(this.DoublePlay_Click);
			// 
			// BgSubtractionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tlpMain);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.Name = "BgSubtractionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Remoção de fundo";
			this.gbOriginal.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.wmpOriginal)).EndInit();
			this.tlpMain.ResumeLayout(false);
			this.gbEffect.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.wmpEffect)).EndInit();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox gbOriginal;
		private System.Windows.Forms.TableLayoutPanel tlpMain;
		private System.Windows.Forms.GroupBox gbEffect;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiVideoSelect;
		private System.Windows.Forms.ToolStripMenuItem tsmiSaveVideo;
		private System.Windows.Forms.ToolStripMenuItem tsmiClean;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private AxWMPLib.AxWindowsMediaPlayer wmpOriginal;
		private AxWMPLib.AxWindowsMediaPlayer wmpEffect;
		private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiApply;
		private System.Windows.Forms.ToolStripMenuItem tsmiDoublePlay;
	}
}