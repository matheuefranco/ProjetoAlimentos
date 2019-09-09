using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProjetoAlimentos
{
    public class ConectaBanco
    {
        public string mensagem;
        MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=compServer;database=sisalimentos");

        public bool verifica(string user, string pass)
        {
            string senhaHash = Biblioteca.makeHash(pass);
            MySqlCommand cmd = new MySqlCommand("consultaSenha", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("usuario", user);
            cmd.Parameters.AddWithValue("senha", senhaHash);
            try
            {
                conexao.Open();//abrindo a conexão;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();// tabela virtual
                da.Fill(ds); //passando os valores consultados para o DataSet 
                if (ds.Tables[0].Rows.Count > 0) // verifica se houve retorno
                    return true;
                else
                    return false;

            }
            catch (MySqlException er)
            {
                mensagem = "Erro" + er.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }
        //------------------ fim verifica ---------------------
        public bool insereProduto(string descricao, int tipo, double densidade)
        {
            MySqlCommand cmd = new MySqlCommand("insere_produto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("descricao", descricao);
            cmd.Parameters.AddWithValue("tipo", tipo);
            cmd.Parameters.AddWithValue("densidade", densidade);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                //mensagem = "Dados inseridos com sucesso";
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = "Erro Mysql " + erro.Message;
                return false;

            }
            finally
            {
                conexao.Close();
            }
        }
        //--------- fim insere_produto ---------------
        public DataSet listaProdutos()
        {
            MySqlCommand cmd = new MySqlCommand("lista_produtos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();//abrindo a conexão;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();// tabela virtual
                da.Fill(ds); //passando os valores consultados para o DataSet 
                return ds;

            }
            catch (MySqlException er)
            {
                mensagem = "Erro" + er.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }
        //----------- fim listaProdutos -----------------
        public bool insereItens(string descricao, double massa,int idproduto)
        {
            MySqlCommand cmd = new MySqlCommand("insere_itens", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("descricao_itens", descricao);
            cmd.Parameters.AddWithValue("massa", massa);
            cmd.Parameters.AddWithValue("idproduto", idproduto);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                //mensagem = "Dados inseridos com sucesso";
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = "Erro Mysql " + erro.Message;
                return false;

            }
            finally
            {
                conexao.Close();
            }
        }
        //--------- fim insere_itens ---------------
    }
}