using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aventura_Solo
{
    public partial class Frm_Selecao : Form
    {
        string imagemArmazenada; 

        public Frm_Selecao()
        {
            InitializeComponent();
        }

        public void ArmazenarImagemSelecionada(string imagemSelecionada)
        {
            imagemArmazenada = imagemSelecionada;
        }

        private void Pcr_aventura1_Click(object sender, EventArgs e)
        {
            //EstoriaSelecionada(1);
            Frm_Estoria frm_Estoria = new Frm_Estoria();
            frm_Estoria.EstoriaSelecionada(1);
            frm_Estoria.PersonagemSelecionada(imagemArmazenada);
            this.Hide();
            frm_Estoria.ShowDialog();
        }
    }
}
