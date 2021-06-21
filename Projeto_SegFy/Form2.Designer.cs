
namespace Projeto_SegFy
{
    partial class Form2
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
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_dados = new System.Windows.Forms.DataGridView();
            this.TituloDoVideo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Canal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDePub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assistir = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(74, 12);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(714, 23);
            this.txt_pesquisa.TabIndex = 0;
            this.txt_pesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisa:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dg_dados
            // 
            this.dg_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_dados.BackgroundColor = System.Drawing.Color.Ivory;
            this.dg_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_dados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TituloDoVideo,
            this.Canal,
            this.DataDePub,
            this.Assistir});
            this.dg_dados.Location = new System.Drawing.Point(74, 41);
            this.dg_dados.Name = "dg_dados";
            this.dg_dados.RowTemplate.Height = 25;
            this.dg_dados.Size = new System.Drawing.Size(835, 323);
            this.dg_dados.TabIndex = 2;
            this.dg_dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_dados_CellContentClick);
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
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(794, 11);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(115, 23);
            this.btn_pesquisar.TabIndex = 3;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(74, 384);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(835, 54);
            this.btn_cadastrar.TabIndex = 4;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.dg_dados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pesquisa);
            this.Name = "Form2";
            this.Text = "Pesquisa de Videos no Youtube";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_dados;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloDoVideo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Canal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDePub;
        private System.Windows.Forms.DataGridViewLinkColumn Assistir;
    }
}