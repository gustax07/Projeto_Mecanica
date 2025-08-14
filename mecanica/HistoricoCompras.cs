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
    public partial class HistoricoCompras : Form
    {
        //Variaveis globais:
        Model.Orcamento orcamento = new Orcamento();

        public HistoricoCompras()
        {
            InitializeComponent();
        }

      

        private void btnVoltarHistCmpr_Click(object sender, EventArgs e)
        {
          
        }
    }
}
