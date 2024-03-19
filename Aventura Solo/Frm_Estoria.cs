using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aventura_Solo
{
    public partial class Frm_Estoria : Form
    {
        public Frm_Estoria()
        {
            InitializeComponent();
        }

        public void EstoriaSelecionada(int estoria)
        {
            Lbl_texto.Text = "A estória chegou!";
        }

        public void PersonagemSelecionada(string imagemSelecionada)
        {
            Pcr_personagem.ImageLocation = imagemSelecionada;
            Lbl_texto.Text = "Deu certo!";
        }

        private void Frm_Estoria_Load(object sender, EventArgs e)
        {

        }
    }
}
