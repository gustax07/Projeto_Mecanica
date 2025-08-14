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
            adicionarServicos.Show();

            //Fecha a tela anterior
            this.Hide();
        }

        private void btnSimularPintura_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarfuncionarios_Click(object sender, EventArgs e)
        {
            //Abrir a tela Cadastrar Funcionarios
            CadastroFunionarios cadastroFunionarios = new CadastroFunionarios(funcionario);
            cadastroFunionarios.Show();

            //Fechar a tela anterior 
            this.Hide();
        }

        private void btnHistoricoCompras_Click(object sender, EventArgs e)
        {
            HistoricoCompras historico = new HistoricoCompras(); // passa referência
            historico.Show();
            this.Hide(); // esconde TelaPrincipal
        }
    }
}
