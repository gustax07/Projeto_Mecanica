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
    public partial class AdicionarServicos : Form
    {
        public AdicionarServicos()
        {
            InitializeComponent();
        }

        private void lblVeiculo_Click(object sender, EventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Verificar se os campos foram preenchidos:
            if (txbNome.Text == "")
            {
                MessageBox.Show("Informe o nome do serviço!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbData.Text == "")
            {
                MessageBox.Show("Por favor, informe a data de entrega!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbVeiculo.Text == "")
            {
                MessageBox.Show("Por favor, informe o veiculo!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txbOrcamento.Text == "")
            {
                MessageBox.Show("Por favor, informe o orçamento!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbStatus.Text == "")
            {
                MessageBox.Show("Por favor, informe o status!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

       
   }
        
    }
}
