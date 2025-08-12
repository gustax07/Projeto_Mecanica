using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mecanica.Model
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone_temporario { get; set; }
        public string Cpf {  get; set; }
        public string Rg {  get; set; }
        public int id_veiculo_fk { get; set; }
        public int id_servicos_fk { get; set; }
        public int id_orcamento_fk { get; set; }
    }
}
