namespace Aventura_Solo
{
    partial class Frm_Personagem
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
            this.Lbl_nome = new System.Windows.Forms.Label();
            this.Txb_nome = new System.Windows.Forms.TextBox();
            this.Lbl_classe = new System.Windows.Forms.Label();
            this.Cbb_classe = new System.Windows.Forms.ComboBox();
            this.Pcr_personagem = new System.Windows.Forms.PictureBox();
            this.Btn_anterior = new System.Windows.Forms.Button();
            this.Btn_proximo = new System.Windows.Forms.Button();
            this.Btn_continuar = new System.Windows.Forms.Button();
            this.Lbl_nomeDigitado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pcr_personagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_nome
            // 
            this.Lbl_nome.AutoSize = true;
            this.Lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Lbl_nome.Location = new System.Drawing.Point(35, 20);
            this.Lbl_nome.Name = "Lbl_nome";
            this.Lbl_nome.Size = new System.Drawing.Size(159, 58);
            this.Lbl_nome.TabIndex = 0;
            this.Lbl_nome.Text = "Nome";
            // 
            // Txb_nome
            // 
            this.Txb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Txb_nome.Location = new System.Drawing.Point(45, 81);
            this.Txb_nome.Name = "Txb_nome";
            this.Txb_nome.Size = new System.Drawing.Size(393, 64);
            this.Txb_nome.TabIndex = 1;
            // 
            // Lbl_classe
            // 
            this.Lbl_classe.AutoSize = true;
            this.Lbl_classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Lbl_classe.Location = new System.Drawing.Point(35, 168);
            this.Lbl_classe.Name = "Lbl_classe";
            this.Lbl_classe.Size = new System.Drawing.Size(349, 58);
            this.Lbl_classe.TabIndex = 2;
            this.Lbl_classe.Text = "O que ela faz?";
            // 
            // Cbb_classe
            // 
            this.Cbb_classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Cbb_classe.FormattingEnabled = true;
            this.Cbb_classe.Items.AddRange(new object[] {
            "",
            "Guerreira",
            "Maga"});
            this.Cbb_classe.Location = new System.Drawing.Point(45, 248);
            this.Cbb_classe.Name = "Cbb_classe";
            this.Cbb_classe.Size = new System.Drawing.Size(391, 66);
            this.Cbb_classe.TabIndex = 3;
            this.Cbb_classe.SelectedIndexChanged += new System.EventHandler(this.Cbb_classe_SelectedIndexChanged);
            // 
            // Pcr_personagem
            // 
            this.Pcr_personagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pcr_personagem.Location = new System.Drawing.Point(552, 21);
            this.Pcr_personagem.Name = "Pcr_personagem";
            this.Pcr_personagem.Size = new System.Drawing.Size(220, 306);
            this.Pcr_personagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pcr_personagem.TabIndex = 4;
            this.Pcr_personagem.TabStop = false;
            // 
            // Btn_anterior
            // 
            this.Btn_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.Btn_anterior.Location = new System.Drawing.Point(603, 416);
            this.Btn_anterior.Name = "Btn_anterior";
            this.Btn_anterior.Size = new System.Drawing.Size(55, 57);
            this.Btn_anterior.TabIndex = 5;
            this.Btn_anterior.Text = "<";
            this.Btn_anterior.UseVisualStyleBackColor = true;
            // 
            // Btn_proximo
            // 
            this.Btn_proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.Btn_proximo.Location = new System.Drawing.Point(681, 416);
            this.Btn_proximo.Name = "Btn_proximo";
            this.Btn_proximo.Size = new System.Drawing.Size(55, 57);
            this.Btn_proximo.TabIndex = 6;
            this.Btn_proximo.Text = ">";
            this.Btn_proximo.UseVisualStyleBackColor = true;
            // 
            // Btn_continuar
            // 
            this.Btn_continuar.Enabled = false;
            this.Btn_continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Btn_continuar.Location = new System.Drawing.Point(531, 493);
            this.Btn_continuar.Name = "Btn_continuar";
            this.Btn_continuar.Size = new System.Drawing.Size(267, 69);
            this.Btn_continuar.TabIndex = 7;
            this.Btn_continuar.Text = "Continuar";
            this.Btn_continuar.UseVisualStyleBackColor = true;
            this.Btn_continuar.Click += new System.EventHandler(this.Btn_continuar_Click);
            // 
            // Lbl_nomeDigitado
            // 
            this.Lbl_nomeDigitado.AutoSize = true;
            this.Lbl_nomeDigitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Lbl_nomeDigitado.Location = new System.Drawing.Point(553, 340);
            this.Lbl_nomeDigitado.Name = "Lbl_nomeDigitado";
            this.Lbl_nomeDigitado.Size = new System.Drawing.Size(132, 48);
            this.Lbl_nomeDigitado.TabIndex = 8;
            this.Lbl_nomeDigitado.Text = "label1";
            // 
            // Frm_Personagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 574);
            this.Controls.Add(this.Lbl_nomeDigitado);
            this.Controls.Add(this.Btn_continuar);
            this.Controls.Add(this.Btn_proximo);
            this.Controls.Add(this.Btn_anterior);
            this.Controls.Add(this.Pcr_personagem);
            this.Controls.Add(this.Cbb_classe);
            this.Controls.Add(this.Lbl_classe);
            this.Controls.Add(this.Txb_nome);
            this.Controls.Add(this.Lbl_nome);
            this.Name = "Frm_Personagem";
            this.Text = "Criação de personagem";
            this.Load += new System.EventHandler(this.Frm_Personagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pcr_personagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_nome;
        private System.Windows.Forms.TextBox Txb_nome;
        private System.Windows.Forms.Label Lbl_classe;
        private System.Windows.Forms.ComboBox Cbb_classe;
        private System.Windows.Forms.PictureBox Pcr_personagem;
        private System.Windows.Forms.Button Btn_anterior;
        private System.Windows.Forms.Button Btn_proximo;
        private System.Windows.Forms.Button Btn_continuar;
        private System.Windows.Forms.Label Lbl_nomeDigitado;
    }
}