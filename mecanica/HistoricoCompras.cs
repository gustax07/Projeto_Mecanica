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
    public partial class HistoricoCompras : Form
    {
        public HistoricoCompras()
        {
            InitializeComponent();
        }

        private void btnVoltarHistCmpr_Click(object sender, EventArgs e)
        {
            // Abre a TelaPrincipal
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();

            // Fecha a tela atual (Histórico de Compras)
            this.Close();
        }
    }
}
