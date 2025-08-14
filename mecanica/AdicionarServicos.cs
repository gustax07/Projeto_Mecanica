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
        Model.Servicos servico = new Model.Servicos();
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
            else if (txbOrcamento.Text == "")
            {
                MessageBox.Show("Por favor, informe o orçamento!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbStatus.Text == "")
            {
                MessageBox.Show("Por favor, informe o status!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Inicia o cadastro no bd:
                // Instanciar o usuario:
                Model.Servicos usuario = new Model.Servicos();
                servico.nomeServico = txbNome.Text;
                servico.DataEntrega = DateTime.Parse(txbData.Text);
                servico.Veiculo = txbVeiculo.Text;
                servico.Orcamento = double.Parse(txbOrcamento.Text);
                servico.Status = txbStatus.Text;

                if (servico.Adicionar())
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!",
                        "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpar os campos do cadastro:
                    txbNome.Clear();
                    txbOrcamento.Clear();
                    txbStatus.Clear();
                    txbVeiculo.Clear();
                    txbData.Clear();
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




        private void dgvServicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
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
                else if (txbOrcamento.Text == "")
                {
                    MessageBox.Show("Por favor, informe o orçamento!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txbStatus.Text == "")
                {
                    MessageBox.Show("Por favor, informe o status!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    // Inicia a edição no bd:
                    // Obter os valores dos txbs de editar:
                    this.servico.nomeServico = txbEdtNome.Text;
                    this.servico.DataEntrega = DateTime.Parse(txbEdtEntrega.Text);
                    this.servico.Veiculo = txbEdtVeiculo.Text;
                    this.servico.Orcamento = int.Parse(txbEdtOrcamento.Text);
                    this.servico.Status = txbEdtStatus.Text;

                    // Executar o .Modificar():
                    if (this.servico.Modificar())
                    {
                        MessageBox.Show("Usuário modificado com sucesso!",
                            "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarDgv();

                        // Limpar o campos e desabilitar os grbs:

                        grbEdicao.Enabled = false;
                        grbAdicionar.Enabled = false;
                        txbEdtEntrega.Clear();
                        txbEdtNome.Clear();
                        txbEdtOrcamento.Clear();
                        txbEdtStatus.Clear();
                        txbEdtVeiculo.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao modificar serviço!", "Erro!",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

        }
        public void AtualizarDgv()
        {
            dgvServicos.DataSource = dgvServicos;
        }

        private void dgvServicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvServicos.SelectedCells[0].RowIndex;

            this.servico.nomeServico = dgvServicos.Rows[linhaSelecionada].Cells[1].Value.ToString();
            this.servico.DataEntrega = DateTime.Parse(dgvServicos.Rows[linhaSelecionada].Cells[2].Value.ToString());
            this.servico.Id = (int)dgvServicos.Rows[linhaSelecionada].Cells[0].Value;
            this.servico.Veiculo = dgvServicos.Rows[linhaSelecionada].Cells[2].Value.ToString();
            this.servico.Orcamento = (double)dgvServicos.Rows[linhaSelecionada].Cells[3].Value;
            this.servico.Status = dgvServicos.Rows[linhaSelecionada].Cells[2].Value.ToString();

            // Atribuir os dados da linha selecionada no grbEditar:
            txbEdtNome.Text = this.servico.nomeServico;
            txbEdtEntrega.Text = this.servico.DataEntrega.ToString();
            txbEdtVeiculo.Text = this.servico.Veiculo;
            txbEdtOrcamento.Text = this.servico.Orcamento.ToString();
            txbEdtStatus.Text = this.servico.Status;
            //Ativar grbEdicao:
            grbEdicao.Enabled = true;
        }
    }

}
