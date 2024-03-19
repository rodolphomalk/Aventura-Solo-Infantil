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
    public partial class Frm_Inicial : Form
    {
        public Frm_Inicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Personagem frm_personagem = new Frm_Personagem();
            this.Hide();
            frm_personagem.ShowDialog();
        }

        private void Frm_Inicial_Load(object sender, EventArgs e)
        {
            
        }
    }
}
