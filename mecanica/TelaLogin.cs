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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Email = txbEmail.Text.Trim();
            funcionario.Senha = txbSenha.Text.Trim();

            if (funcionario.Email == "admin@admin.com" && funcionario.Senha == "admin")
            {
                TelaPrincipal tela = new TelaPrincipal(funcionario);
                tela.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("E-mail ou senha incorretos!");
            }
        }
    }
}

   


