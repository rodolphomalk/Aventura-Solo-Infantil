namespace Aventura_Solo
{
    partial class Frm_Selecao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Selecao));
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Pcr_aventura1 = new System.Windows.Forms.PictureBox();
            this.Lbl_aventura1 = new System.Windows.Forms.Label();
            this.Lbl_aventura2 = new System.Windows.Forms.Label();
            this.Pcr_aventura2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pcr_aventura1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcr_aventura2)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.Lbl_titulo.Location = new System.Drawing.Point(40, 10);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(736, 76);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "Escolha uma aventura!";
            // 
            // Pcr_aventura1
            // 
            this.Pcr_aventura1.Image = ((System.Drawing.Image)(resources.GetObject("Pcr_aventura1.Image")));
            this.Pcr_aventura1.Location = new System.Drawing.Point(142, 101);
            this.Pcr_aventura1.Name = "Pcr_aventura1";
            this.Pcr_aventura1.Size = new System.Drawing.Size(178, 161);
            this.Pcr_aventura1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pcr_aventura1.TabIndex = 1;
            this.Pcr_aventura1.TabStop = false;
            this.Pcr_aventura1.Click += new System.EventHandler(this.Pcr_aventura1_Click);
            // 
            // Lbl_aventura1
            // 
            this.Lbl_aventura1.AutoSize = true;
            this.Lbl_aventura1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Lbl_aventura1.Location = new System.Drawing.Point(59, 285);
            this.Lbl_aventura1.MaximumSize = new System.Drawing.Size(350, 0);
            this.Lbl_aventura1.Name = "Lbl_aventura1";
            this.Lbl_aventura1.Size = new System.Drawing.Size(338, 96);
            this.Lbl_aventura1.TabIndex = 2;
            this.Lbl_aventura1.Text = "A aventura na terra do morango";
            this.Lbl_aventura1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_aventura2
            // 
            this.Lbl_aventura2.AutoSize = true;
            this.Lbl_aventura2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Lbl_aventura2.Location = new System.Drawing.Point(447, 285);
            this.Lbl_aventura2.MaximumSize = new System.Drawing.Size(350, 0);
            this.Lbl_aventura2.Name = "Lbl_aventura2";
            this.Lbl_aventura2.Size = new System.Drawing.Size(343, 48);
            this.Lbl_aventura2.TabIndex = 4;
            this.Lbl_aventura2.Text = "O roubo do totem";
            this.Lbl_aventura2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pcr_aventura2
            // 
            this.Pcr_aventura2.Location = new System.Drawing.Point(530, 101);
            this.Pcr_aventura2.Name = "Pcr_aventura2";
            this.Pcr_aventura2.Size = new System.Drawing.Size(178, 161);
            this.Pcr_aventura2.TabIndex = 3;
            this.Pcr_aventura2.TabStop = false;
            // 
            // Frm_Selecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.Lbl_aventura2);
            this.Controls.Add(this.Pcr_aventura2);
            this.Controls.Add(this.Lbl_aventura1);
            this.Controls.Add(this.Pcr_aventura1);
            this.Controls.Add(this.Lbl_titulo);
            this.Name = "Frm_Selecao";
            this.Text = "Aventuras";
            ((System.ComponentModel.ISupportInitialize)(this.Pcr_aventura1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcr_aventura2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.PictureBox Pcr_aventura1;
        private System.Windows.Forms.Label Lbl_aventura1;
        private System.Windows.Forms.Label Lbl_aventura2;
        private System.Windows.Forms.PictureBox Pcr_aventura2;
    }
}