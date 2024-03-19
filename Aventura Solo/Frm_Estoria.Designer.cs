namespace Aventura_Solo
{
    partial class Frm_Estoria
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
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Lbl_texto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pcr_personagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pcr_personagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Lbl_titulo.Location = new System.Drawing.Point(307, 9);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(208, 76);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "label1";
            // 
            // Lbl_texto
            // 
            this.Lbl_texto.AutoSize = true;
            this.Lbl_texto.Location = new System.Drawing.Point(261, 94);
            this.Lbl_texto.Name = "Lbl_texto";
            this.Lbl_texto.Size = new System.Drawing.Size(44, 16);
            this.Lbl_texto.TabIndex = 1;
            this.Lbl_texto.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 444);
            this.panel1.TabIndex = 2;
            // 
            // Pcr_personagem
            // 
            this.Pcr_personagem.Location = new System.Drawing.Point(193, 212);
            this.Pcr_personagem.Name = "Pcr_personagem";
            this.Pcr_personagem.Size = new System.Drawing.Size(165, 226);
            this.Pcr_personagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pcr_personagem.TabIndex = 0;
            this.Pcr_personagem.TabStop = false;
            // 
            // Frm_Estoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pcr_personagem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_texto);
            this.Controls.Add(this.Lbl_titulo);
            this.Name = "Frm_Estoria";
            this.Text = "Estoria";
            this.Load += new System.EventHandler(this.Frm_Estoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pcr_personagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Label Lbl_texto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Pcr_personagem;
    }
}