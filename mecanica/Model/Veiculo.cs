using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySqlConnector;
using System.Threading.Tasks;
using EasyEncryption;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace mecanica.Model
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor {  get; set; }    

        public bool Cadastrar()
        {
            string comando = "INSERT INTO veiculo (marca, modelo, placa, cor) " +
                "VALUES (@marca, @modelo, @placa, @cor)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@marca", Marca);
            cmd.Parameters.AddWithValue("@modelo", Modelo);
            cmd.Parameters.AddWithValue("@placa", Placa);
            cmd.Parameters.AddWithValue("@cor", Cor);

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

        public bool Excluir()
        {
            string comando = "DELETE FROM veiculo WHERE id = @id";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", Id);

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

        public bool Modificar()
        {
            string comando = "UPDATE veiculo SET marca = @marca, modelo = @modelo, placa = @placa, cor = @cor " +
                " WHERE id = @id"
                ;

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@marca", Marca);
            cmd.Parameters.AddWithValue("@modelo", Modelo);
            cmd.Parameters.AddWithValue("@placa", Placa);
            cmd.Parameters.AddWithValue("@cor", Cor);
            
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
