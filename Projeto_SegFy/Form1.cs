using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_SegFy
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btn_buscarDoYouTube_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_buscarVideosDoYouTube_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btn_BuscarNoBanco_Click(object sender, EventArgs e)
        {
            VideosNoB videonob = new VideosNoB();
            videonob.Show();
        }

        private void btn_BuscarCanaisNoYoutube_Click(object sender, EventArgs e)
        {
            CanaisYoutube canaisyoutube = new CanaisYoutube();
            canaisyoutube.Show();
        }

        private void btn_BuscarCanaisNoBancoDeDados_Click(object sender, EventArgs e)
        {
            CanaisNoBD canaisbd = new CanaisNoBD();
            canaisbd.Show();
        }
    }
}
