using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace mecanica.Model
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }

        public DataTable DataContratacao { get; set; }
        public string Email { get; set; }

        public string Senha { get; set; }


        public bool Cadastrar()
        {
            string comando = "INSERT INTO funcionario (Nome_completo, Email, senha, data_contratacao) " +
                "VALUES (@nome_completo, @email, @data_contratacao, @senha)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome_completo", NomeCompleto);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@data_contratacao", DataContratacao);
            // Obter o hash:
            string hashsenha = EasyEncryption.SHA.ComputeSHA256Hash(Senha);
            cmd.Parameters.AddWithValue("@senha", hashsenha);
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
            string comando = "UPDATE funcionario SET nome_completo = @nome_completo, " +
                "email = @email, senha = @senha, data_contratacao = @data_contratacao WHERE id = @id";

            if (Senha == "" || Senha == null)
            {
                comando = "UPDATE funcionario SET nome_completo = @nome_completo, " +
                "email = @email WHERE id = @id";
            }

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome_completo", NomeCompleto);
            cmd.Parameters.AddWithValue("@data_contratacao", DataContratacao);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@id", Id);

            // Obter o hash:
            if (Senha != "" || Senha != null)
            {
                string hashsenha = EasyEncryption.SHA.ComputeSHA256Hash(Senha);
                cmd.Parameters.AddWithValue("@senha", hashsenha);
            }

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

            public DataTable Listar()
        {

            string comando = "SELECT id, nome_completo, email FROM funcionario";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
       
      }
  }

