using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;


namespace Projeto_SegFy
{
    public partial class CanaisYoutube : Form
    {
        public CanaisYoutube()
        {
            InitializeComponent();
        }

        private void txt_pesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btn_pesquisar_Click(object sender, EventArgs e)
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
                    case "youtube#channel":

                        dg_dados.Rows.Add(searchResult.Snippet.ChannelTitle, "https://www.youtube.com/channel/" + searchResult.Id.ChannelId);
                        break;

                }

            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string canal = dg_dados.CurrentRow.Cells[0].Value.ToString();
            string link = dg_dados.CurrentRow.Cells[1].Value.ToString();


            Conexao conexao = new Conexao();
            conexao.Inserir_Canal(canal, link);
        }
    }
}
