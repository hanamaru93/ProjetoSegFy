using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_SegFy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            dg_dados.Rows.Clear();
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyA9jNEt5lpZACDDIDMjhcDJLaqiGh90Fdw",
                ApplicationName = this.GetType().ToString()
            });

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = txt_pesquisa.Text; // Replace with your search term.
            searchListRequest.MaxResults = 50;

            // Call the search.list method to retrieve results matching the specified query term.
            var searchListResponse = await searchListRequest.ExecuteAsync();

            List<string> videos = new List<string>();
            List<string> channels = new List<string>();
            List<string> playlists = new List<string>();

            // Add each result to the appropriate list, and then display the lists of
            // matching videos, channels, and playlists.
            foreach (var searchResult in searchListResponse.Items)
            {

                //searchResult.Snippet.Title;
                //searchResult.Id.VideoId;
                switch (searchResult.Id.Kind)
                {
                    case "youtube#video":

                        dg_dados.Rows.Add( searchResult.Snippet.Title, searchResult.Snippet.ChannelTitle, searchResult.Snippet.PublishedAt, "https://www.youtube.com/watch?v=" + searchResult.Id.VideoId);
                    break;
                        
                }

            }

        }

        private void dg_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            string titulo = dg_dados.CurrentRow.Cells[0].Value.ToString();
            string canal = dg_dados.CurrentRow.Cells[1].Value.ToString();
            string data = dg_dados.CurrentRow.Cells[2].Value.ToString();
            string link_do_video = dg_dados.CurrentRow.Cells[3].Value.ToString();
           

            Conexao conexao = new Conexao();
            conexao.Inserir_Video(titulo, canal, data, link_do_video);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
