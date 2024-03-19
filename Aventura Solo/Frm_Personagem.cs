using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Aventura_Solo
{
    public partial class Frm_Personagem : Form
    {

        public Frm_Personagem()
        {
            InitializeComponent();

            Txb_nome.Leave += Txb_nome_Leave;
        }

        private void Txb_nome_Leave(object sender, EventArgs e)
        {
            Lbl_nomeDigitado.Text = Txb_nome.Text;
            HabilitarBotaoContinuar();
        }

        private void Btn_continuar_Click(object sender, EventArgs e)
        {
            //PersonagemSelecionada(Pcr_personagem.ImageLocation);
            //Frm_Estoria frm_estoria = new Frm_Estoria();
            //frm_estoria.PersonagemSelecionada(Pcr_personagem.ImageLocation);
            Frm_Selecao frm_selecao = new Frm_Selecao();
            this.Hide();
            frm_selecao.ArmazenarImagemSelecionada(Pcr_personagem.ImageLocation);
            frm_selecao.ShowDialog();

        }

        private void Frm_Personagem_Load(object sender, EventArgs e)
        {
            Lbl_nomeDigitado.Text = Txb_nome.Text;

        }

        private void HabilitarBotaoContinuar()
        {
            if(Txb_nome.Text != null && Cbb_classe.Text != "")
            {
                Btn_continuar.Enabled = true;

            }
        }

        private void TrocarImagemClasse(int index)
        {
            Pcr_personagem.ImageLocation = $"D:\\Programação\\Aventura Solo\\Imagens\\{index}.jpg";
            //Frm_Estoria frm_Estoria = new Frm_Estoria();
            //frm_Estoria.PersonagemSelecionada($"D:\\Programação\\Aventura Solo\\Imagens\\{index}.jpg");
        }

        private void Cbb_classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarBotaoContinuar();
            TrocarImagemClasse(Cbb_classe.SelectedIndex);
        }
    }
}
