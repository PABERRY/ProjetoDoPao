namespace ProjetoDoPao
{
    partial class FormComandas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComandas));
            this.dgvComandas = new System.Windows.Forms.DataGridView();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.grbLancamentos = new System.Windows.Forms.GroupBox();
            this.lblComanda = new System.Windows.Forms.Label();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.lblProduto_lancamento = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txbProduto_Lancamento = new System.Windows.Forms.TextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.btnLancar_Produto = new System.Windows.Forms.Button();
            this.lblTituloComandas = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).BeginInit();
            this.grbInformacoes.SuspendLayout();
            this.grbLancamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComandas
            // 
            this.dgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComandas.Location = new System.Drawing.Point(395, 62);
            this.dgvComandas.Name = "dgvComandas";
            this.dgvComandas.Size = new System.Drawing.Size(393, 384);
            this.dgvComandas.TabIndex = 0;
            this.dgvComandas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComandas_CellClick);
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.grbInformacoes.Controls.Add(this.btnContinuar);
            this.grbInformacoes.Controls.Add(this.txbProduto);
            this.grbInformacoes.Controls.Add(this.txbComanda);
            this.grbInformacoes.Controls.Add(this.lblCodProduto);
            this.grbInformacoes.Controls.Add(this.lblComanda);
            this.grbInformacoes.Location = new System.Drawing.Point(28, 24);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(281, 202);
            this.grbInformacoes.TabIndex = 1;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "informações";
            // 
            // grbLancamentos
            // 
            this.grbLancamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.grbLancamentos.Controls.Add(this.btnCancelar);
            this.grbLancamentos.Controls.Add(this.btnLancar_Produto);
            this.grbLancamentos.Controls.Add(this.lblQuantidade);
            this.grbLancamentos.Controls.Add(this.lblProduto_lancamento);
            this.grbLancamentos.Controls.Add(this.txbQuantidade);
            this.grbLancamentos.Controls.Add(this.txbProduto_Lancamento);
            this.grbLancamentos.Location = new System.Drawing.Point(28, 249);
            this.grbLancamentos.Name = "grbLancamentos";
            this.grbLancamentos.Size = new System.Drawing.Size(281, 197);
            this.grbLancamentos.TabIndex = 2;
            this.grbLancamentos.TabStop = false;
            this.grbLancamentos.Text = "Lançamento";
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(55, 45);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(98, 21);
            this.lblComanda.TabIndex = 0;
            this.lblComanda.Text = "COMANDA:";
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProduto.Location = new System.Drawing.Point(20, 96);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(133, 21);
            this.lblCodProduto.TabIndex = 0;
            this.lblCodProduto.Text = "COD. PRODUTO:";
            // 
            // txbComanda
            // 
            this.txbComanda.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(159, 38);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(83, 28);
            this.txbComanda.TabIndex = 1;
            // 
            // txbProduto
            // 
            this.txbProduto.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProduto.Location = new System.Drawing.Point(159, 89);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.Size = new System.Drawing.Size(83, 28);
            this.txbProduto.TabIndex = 1;
            // 
            // btnContinuar
            // 
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(39, 142);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(193, 40);
            this.btnContinuar.TabIndex = 2;
            this.btnContinuar.Text = "CONTINUAR";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // lblProduto_lancamento
            // 
            this.lblProduto_lancamento.AutoSize = true;
            this.lblProduto_lancamento.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto_lancamento.Location = new System.Drawing.Point(68, 33);
            this.lblProduto_lancamento.Name = "lblProduto_lancamento";
            this.lblProduto_lancamento.Size = new System.Drawing.Size(70, 19);
            this.lblProduto_lancamento.TabIndex = 0;
            this.lblProduto_lancamento.Text = "Produto:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(35, 83);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(103, 19);
            this.lblQuantidade.TabIndex = 0;
            this.lblQuantidade.Text = "Quandtidade:";
            // 
            // txbProduto_Lancamento
            // 
            this.txbProduto_Lancamento.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProduto_Lancamento.Location = new System.Drawing.Point(159, 29);
            this.txbProduto_Lancamento.Name = "txbProduto_Lancamento";
            this.txbProduto_Lancamento.Size = new System.Drawing.Size(83, 28);
            this.txbProduto_Lancamento.TabIndex = 1;
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidade.Location = new System.Drawing.Point(159, 74);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(83, 28);
            this.txbQuantidade.TabIndex = 1;
            // 
            // btnLancar_Produto
            // 
            this.btnLancar_Produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancar_Produto.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar_Produto.Location = new System.Drawing.Point(39, 108);
            this.btnLancar_Produto.Name = "btnLancar_Produto";
            this.btnLancar_Produto.Size = new System.Drawing.Size(193, 40);
            this.btnLancar_Produto.TabIndex = 2;
            this.btnLancar_Produto.Text = "LANÇAR";
            this.btnLancar_Produto.UseVisualStyleBackColor = true;
            this.btnLancar_Produto.Click += new System.EventHandler(this.btnLancar_Produto_Click);
            // 
            // lblTituloComandas
            // 
            this.lblTituloComandas.AutoSize = true;
            this.lblTituloComandas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.lblTituloComandas.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloComandas.Location = new System.Drawing.Point(405, 24);
            this.lblTituloComandas.Name = "lblTituloComandas";
            this.lblTituloComandas.Size = new System.Drawing.Size(303, 30);
            this.lblTituloComandas.TabIndex = 3;
            this.lblTituloComandas.Text = "Lançamento de Comandas ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(39, 154);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(193, 37);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDoPao.Properties.Resources.paes_fundo;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.lblTituloComandas);
            this.Controls.Add(this.grbLancamentos);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.dgvComandas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormComandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormComandas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).EndInit();
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.grbLancamentos.ResumeLayout(false);
            this.grbLancamentos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComandas;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.GroupBox grbLancamentos;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.Label lblProduto_lancamento;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TextBox txbProduto_Lancamento;
        private System.Windows.Forms.Button btnLancar_Produto;
        private System.Windows.Forms.Label lblTituloComandas;
        private System.Windows.Forms.Button btnCancelar;
    }
}