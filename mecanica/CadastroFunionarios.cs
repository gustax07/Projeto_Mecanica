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
        }
    }

