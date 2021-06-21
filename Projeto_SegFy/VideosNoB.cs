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
    public partial class VideosNoB : Form
    {

        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader leitordedados;
        string strSQL;
        public VideosNoB()
        {
            InitializeComponent();
        }

        private void VideosNoB_Load(object sender, EventArgs e)
        {

        }

        private void dg_dados_video_bd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_pesquisar_video_bd_Click(object sender, EventArgs e)
        {


            dg_dados_video_bd.Rows.Clear();
            try
                {
                    conexao = new MySqlConnection("Server=localhost;Database=projetosegfy;Uid=root;Pwd=");
                    string palavra = txt_pesquisa_video_bd.Text;
                    strSQL = "SELECT * FROM video WHERE titulo_do_video LIKE '%" + palavra + "%' OR canal LIKE '%" + palavra + "%' OR data_de_publicacao LIKE '%" + palavra + "%' OR link_do_video LIKE '%" + palavra + "%'";

                    comando = new MySqlCommand(strSQL, conexao);
                    


                    conexao.Open();
                    comando.ExecuteNonQuery();

                    leitordedados = comando.ExecuteReader();

                while (leitordedados.Read()) {


                    dg_dados_video_bd.Rows.Add(Convert.ToString(leitordedados["titulo_do_video"]), Convert.ToString(leitordedados["canal"]), 
                        Convert.ToString(leitordedados["data_de_publicacao"]), Convert.ToString(leitordedados["link_do_video"]));



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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_pesquisa_video_bd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
