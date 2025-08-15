using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySqlConnector;
using System.Threading.Tasks;

namespace mecanica.Model
{
    public class Telefone
    {
        public int Id { get; set; }
        public int Id_funcionario_fk { get; set; }
        public string Numero_telefone {  get; set; }
        public int Id_cliente_fk { get; set; }

        public bool Cadastrar()
        {
            string comando = "INSERT INTO clientes (id_funcionario_fk, numero_telefone, id_cliente_fk ) " +
                "VALUES (@id_funcionario_fk, @numero_telefone, @id_cliente_fk )";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@Id_funcionario_fk", Id_funcionario_fk);
            cmd.Parameters.AddWithValue("@Numero_telefone", Numero_telefone);
            cmd.Parameters.AddWithValue("@Id_cliente_fk", Id_cliente_fk);

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

            string comando = "UPDATE clientes SET id_funcionario_fk = @id_funcionario_fk " +
                 "numero_telefone = @numero_telefone, id_cliente_fk = @id_cliente_fk" +
                 "WHERE id = @id"
                 ;

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id_funcionario_fk", Id_funcionario_fk);
            cmd.Parameters.AddWithValue("@numero_telefone", Numero_telefone);
            cmd.Parameters.AddWithValue("@id_cliente_fk", Id_cliente_fk);
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
    }
}
