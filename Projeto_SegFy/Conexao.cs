using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Projeto_SegFy;

namespace Projeto_SegFy
{
    class Conexao
    {

        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;

        public void Inserir_Video(string titulo, string canal, string data_de_publicacao, string link_do_video)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=projetosegfy;Uid=root;Pwd=");

                strSQL = "INSERT INTO video (titulo_do_video, canal, data_de_publicacao, link_do_video) VALUES (@TITULO, @CANAL, @DATA, @LINK)";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@TITULO", titulo);
                comando.Parameters.AddWithValue("@CANAL", canal);
                comando.Parameters.AddWithValue("@DATA", DateTime.Parse(data_de_publicacao));
                comando.Parameters.AddWithValue("@LINK", link_do_video);

                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados Cadastrados com Sucesso!");


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);

            }
            finally 
            {

                conexao.Close();
                conexao = null;
                comando = null;
            
            
            }

        }

        public void Inserir_Canal(string canal, string link_do_canal) {

            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=projetosegfy;Uid=root;Pwd=");

                strSQL = "INSERT INTO canal (nome_do_canal, link_do_canal) VALUES (@CANAL, @LINK)";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@CANAL", canal);
                comando.Parameters.AddWithValue("@LINK", link_do_canal);
                

                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados Cadastrados com Sucesso!");


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);

            }
            finally
            {

                conexao.Close();
                conexao = null;
                comando = null;


            }






        }



    }
}
