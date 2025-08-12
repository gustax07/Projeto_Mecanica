using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mecanica.Model
{
    internal class Telefone
    {
        public int Id { get; set; }
        public int Id_funcionario_fk { get; set; }
        public string Numero_telefone {  get; set; }
    }
}
