using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyEncryption;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace mecanica.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone_temporario { get; set; }
        public string Cpf {  get; set; }
        public string Rg {  get; set; }
        public int Id_veiculo_fk { get; set; }
        public int Id_servicos_fk { get; set; }
        public int Id_orcamento_fk { get; set; }


        public bool Cadastrar()
        {
            string comando = "INSERT INTO clientes (nome, telefone_temporario, cpf, RG, id_veiculo_fk, id_servicos_fk, id_orcamento_fk ) " +
                "VALUES (@nome, @telefone_temporario, @cpf, @RG, @id_veiculo_fk, @id_servicos_fk, @id_orcamento_fk )";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@telefone_temporario", Telefone_temporario);
            cmd.Parameters.AddWithValue("@cpf", Cpf);
            cmd.Parameters.AddWithValue("@RG", Rg);
            cmd.Parameters.AddWithValue("@id_veiculo_fk", Id_veiculo_fk);
            cmd.Parameters.AddWithValue("@id_servicos_fk", Id_servicos_fk);
            cmd.Parameters.AddWithValue("@id_orcamento_fk", Id_orcamento_fk);

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
            string comando = "UPDATE clientes SET nome = @nome, " +
                "telefone_temporario = @telefone_temporario, cpf = @cpf, RG = @RG, id_veiculo_fk = @id_veiculo_fk, id_servicos_fk = @id_servicos_fk," +
                " id_orcamento_fk = @Id_orcamento_fk  WHERE id = @id" 
                ;

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@telefone_temporario", Telefone_temporario);
            cmd.Parameters.AddWithValue("@cpf", Cpf);
            cmd.Parameters.AddWithValue("@RG", Rg);
            cmd.Parameters.AddWithValue("@id_veiculo_fk", Id_veiculo_fk);
            cmd.Parameters.AddWithValue("@id_servicos_fk", Id_servicos_fk);
            cmd.Parameters.AddWithValue("@id_orcamento_fk", Id_orcamento_fk);
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

        public bool Excluir()
        {
            string comando = "DELETE FROM clientes WHERE id = @id";
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

        public bool Listar()
        {
            string comando = "SELECT * FROM view_pedidos";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

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
