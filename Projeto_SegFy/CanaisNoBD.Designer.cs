
namespace Projeto_SegFy
{
    partial class CanaisNoBD
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pesquisa_video_bd = new System.Windows.Forms.TextBox();
            this.TituloDoVideo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Canal = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados_video_bd)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pesquisar_video_bd
            // 
            this.btn_pesquisar_video_bd.Location = new System.Drawing.Point(794, 6);
            this.btn_pesquisar_video_bd.Name = "btn_pesquisar_video_bd";
            this.btn_pesquisar_video_bd.Size = new System.Drawing.Size(114, 23);
            this.btn_pesquisar_video_bd.TabIndex = 12;
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
            this.Canal});
            this.dg_dados_video_bd.Location = new System.Drawing.Point(73, 36);
            this.dg_dados_video_bd.Name = "dg_dados_video_bd";
            this.dg_dados_video_bd.RowTemplate.Height = 25;
            this.dg_dados_video_bd.Size = new System.Drawing.Size(835, 396);
            this.dg_dados_video_bd.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pesquisa:";
            // 
            // txt_pesquisa_video_bd
            // 
            this.txt_pesquisa_video_bd.Location = new System.Drawing.Point(73, 7);
            this.txt_pesquisa_video_bd.Name = "txt_pesquisa_video_bd";
            this.txt_pesquisa_video_bd.Size = new System.Drawing.Size(715, 23);
            this.txt_pesquisa_video_bd.TabIndex = 9;
            // 
            // TituloDoVideo
            // 
            this.TituloDoVideo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TituloDoVideo.HeaderText = "Nome Do Canal";
            this.TituloDoVideo.Name = "TituloDoVideo";
            // 
            // Canal
            // 
            this.Canal.HeaderText = "Link do Canal";
            this.Canal.Name = "Canal";
            this.Canal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Canal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CanaisNoBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.btn_pesquisar_video_bd);
            this.Controls.Add(this.dg_dados_video_bd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pesquisa_video_bd);
            this.Name = "CanaisNoBD";
            this.Text = "CanaisNoBD";
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados_video_bd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pesquisar_video_bd;
        private System.Windows.Forms.DataGridView dg_dados_video_bd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pesquisa_video_bd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloDoVideo;
        private System.Windows.Forms.DataGridViewLinkColumn Canal;
    }
}