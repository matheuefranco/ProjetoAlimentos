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
        MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=;database=sisalimentos");

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
        public DataSet listaItensIdProd(int idprod)
        {
            MySqlCommand cmd = new MySqlCommand("lista_itens_idprod", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id_prod", idprod);
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
        //----------- fim listaItensProdutos -----------------
        public bool insereConsumo(int iditem, string descricao, 
                                  DateTime data, double qtd)
        {
            MySqlCommand cmd = new MySqlCommand("insere_consumo", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("desc_consumo", descricao);
            cmd.Parameters.AddWithValue("qtd", qtd);
            cmd.Parameters.AddWithValue("iditem", iditem);
            cmd.Parameters.AddWithValue("data", data.ToString("yyyy-MM-dd"));
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
        //--------- fim insere_consumo ---------------
        public bool updateProduto(int idprod, string descricao,
                                  double densidade, int tipo)
        {
            MySqlCommand cmd = new MySqlCommand("update_prod", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("desc_prod", descricao);
            cmd.Parameters.AddWithValue("tipo", tipo);
            cmd.Parameters.AddWithValue("idprod", idprod);
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
        //--------- fim insere_consumo ---------------
        public DataSet listaItensConsumo()
        {
            MySqlCommand cmd = new MySqlCommand("lista_itens_consumo_por_data", conexao);
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
        //----------- fim listaItensConsumo -----------------
        public DataSet listaItensConsumoPorPeriodo(string dateSt, string dateEnd, int idProd)
        {
            MySqlCommand cmd = new MySqlCommand("lista_itens_consumo_por_periodo", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("date_st", dateSt);
            cmd.Parameters.AddWithValue("date_end", dateEnd);
            cmd.Parameters.AddWithValue("idprod", idProd);
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
        //----------- fim listaItensConsumo
    }
}