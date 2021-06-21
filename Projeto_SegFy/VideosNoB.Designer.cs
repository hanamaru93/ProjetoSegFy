
namespace Projeto_SegFy
{
    partial class VideosNoB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_pesquisar_video_bd = new System.Windows.Forms.Button();
            this.dg_dados_video_bd = new System.Windows.Forms.DataGridView();
            this.TituloDoVideo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Canal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDePub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assistir = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pesquisa_video_bd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados_video_bd)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pesquisar_video_bd
            // 
            this.btn_pesquisar_video_bd.Location = new System.Drawing.Point(793, 14);
            this.btn_pesquisar_video_bd.Name = "btn_pesquisar_video_bd";
            this.btn_pesquisar_video_bd.Size = new System.Drawing.Size(114, 23);
            this.btn_pesquisar_video_bd.TabIndex = 8;
            this.btn_pesquisar_video_bd.Text = "Pesquisar";
            this.btn_pesquisar_video_bd.UseVisualStyleBackColor = true;
            this.btn_pesquisar_video_bd.Click += new System.EventHandler(this.btn_pesquisar_video_bd_Click);
            // 
            // dg_dados_video_bd
            // 
            this.dg_dados_video_bd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_dados_video_bd.BackgroundColor = System.Drawing.Color.Ivory;
            this.dg_dados_video_bd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_dados_video_bd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TituloDoVideo,
            this.Canal,
            this.DataDePub,
            this.Assistir});
            this.dg_dados_video_bd.Location = new System.Drawing.Point(72, 44);
            this.dg_dados_video_bd.Name = "dg_dados_video_bd";
            this.dg_dados_video_bd.RowTemplate.Height = 25;
            this.dg_dados_video_bd.Size = new System.Drawing.Size(835, 396);
            this.dg_dados_video_bd.TabIndex = 7;
            this.dg_dados_video_bd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_dados_video_bd_CellContentClick);
            // 
            // TituloDoVideo
            // 
            this.TituloDoVideo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TituloDoVideo.HeaderText = "Titulo Do Video";
            this.TituloDoVideo.Name = "TituloDoVideo";
            // 
            // Canal
            // 
            this.Canal.HeaderText = "Canal";
            this.Canal.Name = "Canal";
            // 
            // DataDePub
            // 
            this.DataDePub.HeaderText = "Data de Publicação";
            this.DataDePub.Name = "DataDePub";
            // 
            // Assistir
            // 
            this.Assistir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Assistir.HeaderText = "Link do Video";
            this.Assistir.Name = "Assistir";
            this.Assistir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Assistir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Assistir.Width = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pesquisa:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_pesquisa_video_bd
            // 
            this.txt_pesquisa_video_bd.Location = new System.Drawing.Point(72, 15);
            this.txt_pesquisa_video_bd.Name = "txt_pesquisa_video_bd";
            this.txt_pesquisa_video_bd.Size = new System.Drawing.Size(715, 23);
            this.txt_pesquisa_video_bd.TabIndex = 5;
            this.txt_pesquisa_video_bd.TextChanged += new System.EventHandler(this.txt_pesquisa_video_bd_TextChanged);
            // 
            // VideosNoB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.btn_pesquisar_video_bd);
            this.Controls.Add(this.dg_dados_video_bd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pesquisa_video_bd);
            this.Name = "VideosNoB";
            this.Text = "VideosNoB";
            this.Load += new System.EventHandler(this.VideosNoB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados_video_bd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pesquisar_video_bd;
        private System.Windows.Forms.DataGridView dg_dados_video_bd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloDoVideo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Canal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDePub;
        private System.Windows.Forms.DataGridViewLinkColumn Assistir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pesquisa_video_bd;
    }
}