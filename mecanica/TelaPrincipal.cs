using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mecanica.Model;

namespace mecanica
{
    public partial class TelaPrincipal : Form
    {
        Funcionario funcionario = new Funcionario();
        public TelaPrincipal(Funcionario funcionario)
        {
            InitializeComponent();
            this.funcionario = funcionario;
        }

        private void btnAdicionarservico_Click(object sender, EventArgs e)
        {
            //Abre a tela Adicionar serviços
            AdicionarServicos adicionarServicos = new AdicionarServicos();
            

            //Fecha a tela anterior
            this.Hide();
            adicionarServicos.ShowDialog();
        }

        private void btnSimularPintura_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarfuncionarios_Click(object sender, EventArgs e)
        {
            //Abrir a tela Cadastrar Funcionarios
            CadastroFunionarios cadastroFunionarios = new CadastroFunionarios(funcionario);
            

            //Fechar a tela anterior 
            this.Hide();
            cadastroFunionarios.ShowDialog();
            this.Show();

        }

        private void btnHistoricoCompras_Click(object sender, EventArgs e)
        {
            HistoricoCompras historico = new HistoricoCompras(); // passa referência
           
            this.Hide(); // esconde TelaPrincipal
            historico.ShowDialog();
        }
    }
}
