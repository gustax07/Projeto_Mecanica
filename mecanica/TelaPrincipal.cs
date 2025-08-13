using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mecanica
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnAdicionarservico_Click(object sender, EventArgs e)
        {
            //Abre a tela Adicionar serviços
            AdicionarServicos adicionarServicos = new AdicionarServicos();
            adicionarServicos.Show();

            //Fecha a tela anterior
            this.Hide();
        }

        private void btnSimularPintura_Click(object sender, EventArgs e)
        {

        }
    }
}
