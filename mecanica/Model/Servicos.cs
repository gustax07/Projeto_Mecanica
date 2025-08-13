using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MySqlConnector;

namespace mecanica.Model
{
    internal class Servicos
    {
        public int Id { get; set; }
        public string nomeServico { get; set; }
        public DataTable DataEntrega { get; set; }
        public string Veiculo {  get; set; }
        public int Orcamento { get; set; }
        public string Status {  get; set; }



        public bool Adicionar()
        {
            string comando = "INSERT INTO servicos (id_servico, id_veiculo, id_status, data_entrega, id_orcamento) " +
                "VALUES (@id_servico, @id_veiculo, @id_status, @data_entrega, @id_orcamento)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id_servico", nomeServico);
            cmd.Parameters.AddWithValue("@id_veiculo", Veiculo);
            cmd.Parameters.AddWithValue("@id_status", Status);
            cmd.Parameters.AddWithValue("@data_entrega", DataEntrega);
            cmd.Parameters.AddWithValue("@id_orcamento", Orcamento);


            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }

            public bool Modificar()
        {
            string comando = "UPDATE servicos SET id_servico = @id_servico, id_veiculo = @id_veiculo " +
                "id_status = @id_status, data_entrega = @data_entrega, id_orcamento = @id_orcamento WHERE id = @id";

           

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@id_servico", nomeServico);
            cmd.Parameters.AddWithValue("@id_veiculo", Veiculo);
            cmd.Parameters.AddWithValue("@id_status", Status);
            cmd.Parameters.AddWithValue("@data_entrega", DataEntrega);
            cmd.Parameters.AddWithValue("@id_orcamento", Orcamento);




            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}
