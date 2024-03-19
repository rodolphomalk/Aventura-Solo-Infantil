namespace Aventura_Solo
{
    partial class Frm_Inicial
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
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_texto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.BackColor = System.Drawing.SystemColors.Desktop;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold);
            this.Lbl_Titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_Titulo.Location = new System.Drawing.Point(126, 25);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(582, 95);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Aventura Solo";
            // 
            // Lbl_texto
            // 
            this.Lbl_texto.AutoSize = true;
            this.Lbl_texto.BackColor = System.Drawing.SystemColors.Desktop;
            this.Lbl_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Lbl_texto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_texto.Location = new System.Drawing.Point(61, 145);
            this.Lbl_texto.MaximumSize = new System.Drawing.Size(2000, 0);
            this.Lbl_texto.Name = "Lbl_texto";
            this.Lbl_texto.Size = new System.Drawing.Size(1913, 116);
            this.Lbl_texto.TabIndex = 1;
            this.Lbl_texto.Text = "Bem-vinda a um mundo de aventuras onde você vai se divertir muito! Basta clicar n" +
    "o botão para iniciarmos nossa jornada!";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(507, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 101);
            this.button1.TabIndex = 2;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lbl_texto);
            this.Controls.Add(this.Lbl_Titulo);
            this.Name = "Frm_Inicial";
            this.Text = "Bem-vinda!";
            this.Load += new System.EventHandler(this.Frm_Inicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_texto;
        private System.Windows.Forms.Button button1;
    }
}

