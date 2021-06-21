
namespace Projeto_SegFy
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btn_buscarVideosDoYouTube = new System.Windows.Forms.Button();
            this.btn_BuscarNoBanco = new System.Windows.Forms.Button();
            this.btn_BuscarCanaisNoYoutube = new System.Windows.Forms.Button();
            this.btn_BuscarCanaisNoBancoDeDados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_buscarVideosDoYouTube
            // 
            this.btn_buscarVideosDoYouTube.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_buscarVideosDoYouTube.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_buscarVideosDoYouTube.Location = new System.Drawing.Point(104, 161);
            this.btn_buscarVideosDoYouTube.Name = "btn_buscarVideosDoYouTube";
            this.btn_buscarVideosDoYouTube.Size = new System.Drawing.Size(245, 47);
            this.btn_buscarVideosDoYouTube.TabIndex = 0;
            this.btn_buscarVideosDoYouTube.Text = "Buscar Videos do Youtube";
            this.btn_buscarVideosDoYouTube.UseVisualStyleBackColor = false;
            this.btn_buscarVideosDoYouTube.Click += new System.EventHandler(this.btn_buscarVideosDoYouTube_Click);
            // 
            // btn_BuscarNoBanco
            // 
            this.btn_BuscarNoBanco.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_BuscarNoBanco.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_BuscarNoBanco.Location = new System.Drawing.Point(506, 161);
            this.btn_BuscarNoBanco.Name = "btn_BuscarNoBanco";
            this.btn_BuscarNoBanco.Size = new System.Drawing.Size(248, 47);
            this.btn_BuscarNoBanco.TabIndex = 1;
            this.btn_BuscarNoBanco.Text = "Buscar Videos No Banco de Dados";
            this.btn_BuscarNoBanco.UseVisualStyleBackColor = false;
            this.btn_BuscarNoBanco.Click += new System.EventHandler(this.btn_BuscarNoBanco_Click);
            // 
            // btn_BuscarCanaisNoYoutube
            // 
            this.btn_BuscarCanaisNoYoutube.BackColor = System.Drawing.Color.Chocolate;
            this.btn_BuscarCanaisNoYoutube.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_BuscarCanaisNoYoutube.Location = new System.Drawing.Point(104, 241);
            this.btn_BuscarCanaisNoYoutube.Name = "btn_BuscarCanaisNoYoutube";
            this.btn_BuscarCanaisNoYoutube.Size = new System.Drawing.Size(245, 47);
            this.btn_BuscarCanaisNoYoutube.TabIndex = 2;
            this.btn_BuscarCanaisNoYoutube.Text = "Buscar Canais no Youtube";
            this.btn_BuscarCanaisNoYoutube.UseVisualStyleBackColor = false;
            this.btn_BuscarCanaisNoYoutube.Click += new System.EventHandler(this.btn_BuscarCanaisNoYoutube_Click);
            // 
            // btn_BuscarCanaisNoBancoDeDados
            // 
            this.btn_BuscarCanaisNoBancoDeDados.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_BuscarCanaisNoBancoDeDados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_BuscarCanaisNoBancoDeDados.Location = new System.Drawing.Point(506, 241);
            this.btn_BuscarCanaisNoBancoDeDados.Name = "btn_BuscarCanaisNoBancoDeDados";
            this.btn_BuscarCanaisNoBancoDeDados.Size = new System.Drawing.Size(248, 46);
            this.btn_BuscarCanaisNoBancoDeDados.TabIndex = 3;
            this.btn_BuscarCanaisNoBancoDeDados.Text = "Buscar Canais no Banco de Dados";
            this.btn_BuscarCanaisNoBancoDeDados.UseVisualStyleBackColor = false;
            this.btn_BuscarCanaisNoBancoDeDados.Click += new System.EventHandler(this.btn_BuscarCanaisNoBancoDeDados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Tarrget Platinum", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 61);
            this.label1.TabIndex = 5;
            this.label1.Text = "Projeto Segfy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "By: Felipe Barbosa Belarmino dos Santos";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(852, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_BuscarCanaisNoBancoDeDados);
            this.Controls.Add(this.btn_BuscarCanaisNoYoutube);
            this.Controls.Add(this.btn_BuscarNoBanco);
            this.Controls.Add(this.btn_buscarVideosDoYouTube);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Name = "Inicio";
            this.Text = "Projeto SegFy";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscarVideosDoYouTube;
        private System.Windows.Forms.Button btn_BuscarNoBanco;
        private System.Windows.Forms.Button btn_BuscarCanaisNoYoutube;
        private System.Windows.Forms.Button btn_BuscarCanaisNoBancoDeDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

