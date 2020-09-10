namespace IPA.Front
{
    partial class SelectImageSize
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cbAllow = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(182, 99);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.Confirm);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(182, 29);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(75, 20);
            this.txtSize.TabIndex = 0;
            this.txtSize.Text = "200";
            this.txtSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterKeyPress);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(163, 109);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "Digite a altura e a largura será calculada proporcionamente para cada imagem. Ao " +
    "clicar em permitir, significa que imagens podem ser redimensionada para um taman" +
    "ho além de seu tamanho original.";
            // 
            // cbAllow
            // 
            this.cbAllow.AutoSize = true;
            this.cbAllow.Checked = true;
            this.cbAllow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAllow.Location = new System.Drawing.Point(182, 55);
            this.cbAllow.Name = "cbAllow";
            this.cbAllow.Size = new System.Drawing.Size(60, 17);
            this.cbAllow.TabIndex = 1;
            this.cbAllow.Text = "Permitir";
            this.cbAllow.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tamanho px";
            // 
            // SelectImageSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 134);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAllow);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.btnConfirm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectImageSize";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tamanho das imagens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox cbAllow;
        private System.Windows.Forms.Label label1;
    }
}