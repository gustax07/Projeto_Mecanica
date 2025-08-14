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
    public partial class CadastroFunionarios : Form
    {

        // Variáveis globais:
        Model.Funcionario funcionario = new Funcionario();
        public CadastroFunionarios(Funcionario funcionario)
        {
            InitializeComponent();
            this.funcionario = funcionario;
        }

        public void AtualizarDgv()
        {
            dgvCadastroFunci.DataSource = funcionario;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbNomeFunci.Text.Length < 4)
            {
                MessageBox.Show("Nome informado vazio ou inválido!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txbDataContratacao.Text.Length < 8)
            {
                MessageBox.Show("Data de contratação vazia ou inválida!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txbEmail.Text == "")
            {
                MessageBox.Show("E-mail informado vazio ou inválido!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txbSenha.Text.Length < 4)
            {
                MessageBox.Show("Senha vazia ou inválida!",
                   "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                // Inicia o cadastro no bd:
                // Instanciar o usuario:

                funcionario.Email = txbEmail.Text;
                funcionario.NomeCompleto = txbNomeFunci.Text;
                funcionario.Senha = txbSenha.Text;
                funcionario.DataContratacao = DateTime.Parse(txbDataContratacao.Text);

                if (funcionario.Cadastrar())
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso!",
                        "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpar os campos do cadastro:
                    txbEmail.Clear();
                    txbNomeFunci.Clear();
                    txbSenha.Clear();
                    txbDataContratacao.Clear();
                    // Atualizar o dgv (reexecutar o SELECT):
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o usuário!", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Validação de erro:
            if (txbEditarEmail.Text.Length < 6)
            {
                MessageBox.Show("O e-mail informado é inválido!", "Erro!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEditarNome.Text.Length < 7)
            {
                MessageBox.Show("Nome informado vazio ou inválido!", "Erro!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEditarSenha.Text.Length >= 1 && txbEditarSenha.Text.Length < 4)
            {
                MessageBox.Show("A senha deve ter no mínimo 4 caracteres!", "Erro!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Inicia a edição no bd:
                // Obter os valores dos txbs de editar:
                funcionario.NomeCompleto = txbEditarNome.Text;
                funcionario.Email = txbEditarEmail.Text;
                funcionario.Senha = txbEditarSenha.Text;
                funcionario.DataContratacao = DateTime.Parse(txbEditarContratacao.Text);

                // Executar o .Modificar():
                if (funcionario.Modificar())
                {
                    MessageBox.Show("Funcionário modificado com sucesso!",
                        "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgv();

                    // Limpar o campos e desabilitar os grbs:
                    grbEditar.Enabled = false;
                    txbEditarEmail.Clear();
                    txbEditarSenha.Clear();
                    txbEditarNome.Clear();
                    txbEditarContratacao.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao modificar o funcionário!", "Erro!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvCadastroFunci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvCadastroFunci.SelectedCells[0].RowIndex;

            funcionario.NomeCompleto = dgvCadastroFunci.Rows[linhaSelecionada].Cells[1].Value.ToString();
            funcionario.Email = dgvCadastroFunci.Rows[linhaSelecionada].Cells[2].Value.ToString();
            funcionario.Id = (int)dgvCadastroFunci.Rows[linhaSelecionada].Cells[0].Value;
            funcionario.DataContratacao = DateTime.Parse(dgvCadastroFunci.Rows[linhaSelecionada].Cells[3].Value.ToString());



            // Atribuir os dados da linha selecionada no grbEditar:
            txbEditarNome.Text = funcionario.NomeCompleto;
            txbEditarEmail.Text = funcionario.Email;
            txbEditarContratacao.Text = funcionario.DataContratacao.ToString();
            // Ativar o grbEdicao:
            grbEditar.Enabled = true;

           
        }
    }
}

