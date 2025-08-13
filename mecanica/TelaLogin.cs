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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txbEmail.Text.Trim();
            string senha = txbSenha.Text.Trim();

            if (email == "admin@admin.com" && senha == "admin")
            {
                TelaPrincipal tela = new TelaPrincipal();
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

   


