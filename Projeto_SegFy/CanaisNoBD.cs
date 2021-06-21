using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_SegFy
{
    public partial class CanaisNoBD : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader leitordedados;
        string strSQL;
        public CanaisNoBD()
        {
            InitializeComponent();
        }

        private void btn_pesquisar_video_bd_Click(object sender, EventArgs e)
        {
            dg_dados_video_bd.Rows.Clear();
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=projetosegfy;Uid=root;Pwd=");
                string palavra = txt_pesquisa_video_bd.Text;
                strSQL = "SELECT * FROM canal WHERE nome_do_canal LIKE '%" + palavra + "%' OR link_do_canal LIKE '%" + palavra + "%'";

                comando = new MySqlCommand(strSQL, conexao);



                conexao.Open();
                comando.ExecuteNonQuery();

                leitordedados = comando.ExecuteReader();

                while (leitordedados.Read())
                {


                    dg_dados_video_bd.Rows.Add(Convert.ToString(leitordedados["nome_do_canal"]), Convert.ToString(leitordedados["link_do_canal"]));



                }





            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

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
