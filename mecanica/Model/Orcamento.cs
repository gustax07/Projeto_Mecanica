using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mecanica.Model
{
    internal class Orcamento
    {
        public uint Id { get; set; }
        public DateTime Data_prevista { get; set; }
        public string Forma_pagamento { get; set; }
        public double Valor_estimado { get; set; }
        public string Descricao_problema { get; set; }
    }
}
