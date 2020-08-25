namespace IPA.Front
{
    partial class ThresholdConfigs
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
            this.cbThreshold = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThreshold = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbThreshold
            // 
            this.cbThreshold.AutoSize = true;
            this.cbThreshold.Checked = true;
            this.cbThreshold.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbThreshold.Location = new System.Drawing.Point(15, 32);
            this.cbThreshold.Name = "cbThreshold";
            this.cbThreshold.Size = new System.Drawing.Size(168, 17);
            this.cbThreshold.TabIndex = 5;
            this.cbThreshold.Text = "Converter para preto e branco";
            this.cbThreshold.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor de L:";
            // 
            // txtThreshold
            // 
            this.txtThreshold.Location = new System.Drawing.Point(76, 6);
            this.txtThreshold.Name = "txtThreshold";
            this.txtThreshold.Size = new System.Drawing.Size(101, 20);
            this.txtThreshold.TabIndex = 3;
            this.txtThreshold.Text = "150";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(102, 64);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.Confirm);
            // 
            // ThresholdConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 99);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cbThreshold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtThreshold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ThresholdConfigs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbThreshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThreshold;
        private System.Windows.Forms.Button btnConfirm;
    }
}