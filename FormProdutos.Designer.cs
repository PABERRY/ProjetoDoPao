namespace ProjetoDoPao
{
    partial class FormProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbCadastrar_CadastrarProdutos = new System.Windows.Forms.GroupBox();
            this.btnCadastrar_Produtos = new System.Windows.Forms.Button();
            this.cmbCategoria_CadastrarProdutos = new System.Windows.Forms.ComboBox();
            this.txbPreco_CadastrarProdutos = new System.Windows.Forms.TextBox();
            this.txbNome_CadastrarProdutos = new System.Windows.Forms.TextBox();
            this.lblCategoria_CadastrarProdutos = new System.Windows.Forms.Label();
            this.lblPreco_CadastrarProdutos = new System.Windows.Forms.Label();
            this.lblNome_CadastrarProdutos = new System.Windows.Forms.Label();
            this.grbEditar_Produtos = new System.Windows.Forms.GroupBox();
            this.btnEditar_Produtos = new System.Windows.Forms.Button();
            this.cmbCategoria_EditarProdutos = new System.Windows.Forms.ComboBox();
            this.txbPreco_EditarProdutos = new System.Windows.Forms.TextBox();
            this.txbNome_EditarProdutos = new System.Windows.Forms.TextBox();
            this.lblCategoria_EditarProdutos = new System.Windows.Forms.Label();
            this.lblPreco_EditarProdutos = new System.Windows.Forms.Label();
            this.lblNome_EditarProdutos = new System.Windows.Forms.Label();
            this.grbApagar_Produtos = new System.Windows.Forms.GroupBox();
            this.btnApagar_Produtos = new System.Windows.Forms.Button();
            this.lblApagar_Produtos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbCadastrar_CadastrarProdutos.SuspendLayout();
            this.grbEditar_Produtos.SuspendLayout();
            this.grbApagar_Produtos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(31, 26);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(374, 350);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // grbCadastrar_CadastrarProdutos
            // 
            this.grbCadastrar_CadastrarProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.grbCadastrar_CadastrarProdutos.Controls.Add(this.btnCadastrar_Produtos);
            this.grbCadastrar_CadastrarProdutos.Controls.Add(this.cmbCategoria_CadastrarProdutos);
            this.grbCadastrar_CadastrarProdutos.Controls.Add(this.txbPreco_CadastrarProdutos);
            this.grbCadastrar_CadastrarProdutos.Controls.Add(this.txbNome_CadastrarProdutos);
            this.grbCadastrar_CadastrarProdutos.Controls.Add(this.lblCategoria_CadastrarProdutos);
            this.grbCadastrar_CadastrarProdutos.Controls.Add(this.lblPreco_CadastrarProdutos);
            this.grbCadastrar_CadastrarProdutos.Controls.Add(this.lblNome_CadastrarProdutos);
            this.grbCadastrar_CadastrarProdutos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastrar_CadastrarProdutos.Location = new System.Drawing.Point(458, 12);
            this.grbCadastrar_CadastrarProdutos.Name = "grbCadastrar_CadastrarProdutos";
            this.grbCadastrar_CadastrarProdutos.Size = new System.Drawing.Size(286, 156);
            this.grbCadastrar_CadastrarProdutos.TabIndex = 1;
            this.grbCadastrar_CadastrarProdutos.TabStop = false;
            this.grbCadastrar_CadastrarProdutos.Text = "Cadastrar";
            // 
            // btnCadastrar_Produtos
            // 
            this.btnCadastrar_Produtos.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar_Produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar_Produtos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar_Produtos.Location = new System.Drawing.Point(9, 104);
            this.btnCadastrar_Produtos.Name = "btnCadastrar_Produtos";
            this.btnCadastrar_Produtos.Size = new System.Drawing.Size(271, 36);
            this.btnCadastrar_Produtos.TabIndex = 3;
            this.btnCadastrar_Produtos.Text = "Cadastrar";
            this.btnCadastrar_Produtos.UseVisualStyleBackColor = false;
            this.btnCadastrar_Produtos.Click += new System.EventHandler(this.btnCadastrar_Produtos_Click);
            // 
            // cmbCategoria_CadastrarProdutos
            // 
            this.cmbCategoria_CadastrarProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria_CadastrarProdutos.FormattingEnabled = true;
            this.cmbCategoria_CadastrarProdutos.Location = new System.Drawing.Point(101, 77);
            this.cmbCategoria_CadastrarProdutos.Name = "cmbCategoria_CadastrarProdutos";
            this.cmbCategoria_CadastrarProdutos.Size = new System.Drawing.Size(172, 22);
            this.cmbCategoria_CadastrarProdutos.TabIndex = 2;
            // 
            // txbPreco_CadastrarProdutos
            // 
            this.txbPreco_CadastrarProdutos.Location = new System.Drawing.Point(101, 51);
            this.txbPreco_CadastrarProdutos.Name = "txbPreco_CadastrarProdutos";
            this.txbPreco_CadastrarProdutos.Size = new System.Drawing.Size(172, 21);
            this.txbPreco_CadastrarProdutos.TabIndex = 1;
            // 
            // txbNome_CadastrarProdutos
            // 
            this.txbNome_CadastrarProdutos.Location = new System.Drawing.Point(101, 25);
            this.txbNome_CadastrarProdutos.Name = "txbNome_CadastrarProdutos";
            this.txbNome_CadastrarProdutos.Size = new System.Drawing.Size(172, 21);
            this.txbNome_CadastrarProdutos.TabIndex = 1;
            // 
            // lblCategoria_CadastrarProdutos
            // 
            this.lblCategoria_CadastrarProdutos.AutoSize = true;
            this.lblCategoria_CadastrarProdutos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria_CadastrarProdutos.Location = new System.Drawing.Point(40, 80);
            this.lblCategoria_CadastrarProdutos.Name = "lblCategoria_CadastrarProdutos";
            this.lblCategoria_CadastrarProdutos.Size = new System.Drawing.Size(60, 14);
            this.lblCategoria_CadastrarProdutos.TabIndex = 0;
            this.lblCategoria_CadastrarProdutos.Text = "Categoria:";
            // 
            // lblPreco_CadastrarProdutos
            // 
            this.lblPreco_CadastrarProdutos.AutoSize = true;
            this.lblPreco_CadastrarProdutos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco_CadastrarProdutos.Location = new System.Drawing.Point(57, 54);
            this.lblPreco_CadastrarProdutos.Name = "lblPreco_CadastrarProdutos";
            this.lblPreco_CadastrarProdutos.Size = new System.Drawing.Size(39, 14);
            this.lblPreco_CadastrarProdutos.TabIndex = 0;
            this.lblPreco_CadastrarProdutos.Text = "Preço:";
            // 
            // lblNome_CadastrarProdutos
            // 
            this.lblNome_CadastrarProdutos.AutoSize = true;
            this.lblNome_CadastrarProdutos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome_CadastrarProdutos.Location = new System.Drawing.Point(57, 28);
            this.lblNome_CadastrarProdutos.Name = "lblNome_CadastrarProdutos";
            this.lblNome_CadastrarProdutos.Size = new System.Drawing.Size(42, 14);
            this.lblNome_CadastrarProdutos.TabIndex = 0;
            this.lblNome_CadastrarProdutos.Text = "Nome:";
            // 
            // grbEditar_Produtos
            // 
            this.grbEditar_Produtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.grbEditar_Produtos.Controls.Add(this.btnEditar_Produtos);
            this.grbEditar_Produtos.Controls.Add(this.cmbCategoria_EditarProdutos);
            this.grbEditar_Produtos.Controls.Add(this.txbPreco_EditarProdutos);
            this.grbEditar_Produtos.Controls.Add(this.txbNome_EditarProdutos);
            this.grbEditar_Produtos.Controls.Add(this.lblCategoria_EditarProdutos);
            this.grbEditar_Produtos.Controls.Add(this.lblPreco_EditarProdutos);
            this.grbEditar_Produtos.Controls.Add(this.lblNome_EditarProdutos);
            this.grbEditar_Produtos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar_Produtos.Location = new System.Drawing.Point(458, 202);
            this.grbEditar_Produtos.Name = "grbEditar_Produtos";
            this.grbEditar_Produtos.Size = new System.Drawing.Size(286, 156);
            this.grbEditar_Produtos.TabIndex = 1;
            this.grbEditar_Produtos.TabStop = false;
            this.grbEditar_Produtos.Text = "Editar";
            // 
            // btnEditar_Produtos
            // 
            this.btnEditar_Produtos.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar_Produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar_Produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar_Produtos.Location = new System.Drawing.Point(6, 98);
            this.btnEditar_Produtos.Name = "btnEditar_Produtos";
            this.btnEditar_Produtos.Size = new System.Drawing.Size(277, 41);
            this.btnEditar_Produtos.TabIndex = 4;
            this.btnEditar_Produtos.Text = "Editar";
            this.btnEditar_Produtos.UseVisualStyleBackColor = false;
            this.btnEditar_Produtos.Click += new System.EventHandler(this.btnEditar_Produtos_Click);
            // 
            // cmbCategoria_EditarProdutos
            // 
            this.cmbCategoria_EditarProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria_EditarProdutos.FormattingEnabled = true;
            this.cmbCategoria_EditarProdutos.Location = new System.Drawing.Point(101, 70);
            this.cmbCategoria_EditarProdutos.Name = "cmbCategoria_EditarProdutos";
            this.cmbCategoria_EditarProdutos.Size = new System.Drawing.Size(172, 22);
            this.cmbCategoria_EditarProdutos.TabIndex = 2;
            // 
            // txbPreco_EditarProdutos
            // 
            this.txbPreco_EditarProdutos.Location = new System.Drawing.Point(101, 44);
            this.txbPreco_EditarProdutos.Name = "txbPreco_EditarProdutos";
            this.txbPreco_EditarProdutos.Size = new System.Drawing.Size(172, 21);
            this.txbPreco_EditarProdutos.TabIndex = 1;
            // 
            // txbNome_EditarProdutos
            // 
            this.txbNome_EditarProdutos.Location = new System.Drawing.Point(101, 18);
            this.txbNome_EditarProdutos.Name = "txbNome_EditarProdutos";
            this.txbNome_EditarProdutos.Size = new System.Drawing.Size(172, 21);
            this.txbNome_EditarProdutos.TabIndex = 1;
            // 
            // lblCategoria_EditarProdutos
            // 
            this.lblCategoria_EditarProdutos.AutoSize = true;
            this.lblCategoria_EditarProdutos.Location = new System.Drawing.Point(40, 73);
            this.lblCategoria_EditarProdutos.Name = "lblCategoria_EditarProdutos";
            this.lblCategoria_EditarProdutos.Size = new System.Drawing.Size(60, 14);
            this.lblCategoria_EditarProdutos.TabIndex = 0;
            this.lblCategoria_EditarProdutos.Text = "Categoria:";
            // 
            // lblPreco_EditarProdutos
            // 
            this.lblPreco_EditarProdutos.AutoSize = true;
            this.lblPreco_EditarProdutos.Location = new System.Drawing.Point(57, 47);
            this.lblPreco_EditarProdutos.Name = "lblPreco_EditarProdutos";
            this.lblPreco_EditarProdutos.Size = new System.Drawing.Size(39, 14);
            this.lblPreco_EditarProdutos.TabIndex = 0;
            this.lblPreco_EditarProdutos.Text = "Preço:";
            // 
            // lblNome_EditarProdutos
            // 
            this.lblNome_EditarProdutos.AutoSize = true;
            this.lblNome_EditarProdutos.Location = new System.Drawing.Point(57, 21);
            this.lblNome_EditarProdutos.Name = "lblNome_EditarProdutos";
            this.lblNome_EditarProdutos.Size = new System.Drawing.Size(42, 14);
            this.lblNome_EditarProdutos.TabIndex = 0;
            this.lblNome_EditarProdutos.Text = "Nome:";
            // 
            // grbApagar_Produtos
            // 
            this.grbApagar_Produtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.grbApagar_Produtos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbApagar_Produtos.Controls.Add(this.btnApagar_Produtos);
            this.grbApagar_Produtos.Controls.Add(this.lblApagar_Produtos);
            this.grbApagar_Produtos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbApagar_Produtos.Location = new System.Drawing.Point(20, 382);
            this.grbApagar_Produtos.Name = "grbApagar_Produtos";
            this.grbApagar_Produtos.Size = new System.Drawing.Size(724, 85);
            this.grbApagar_Produtos.TabIndex = 4;
            this.grbApagar_Produtos.TabStop = false;
            this.grbApagar_Produtos.Text = "Apagar";
            // 
            // btnApagar_Produtos
            // 
            this.btnApagar_Produtos.BackColor = System.Drawing.Color.Transparent;
            this.btnApagar_Produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar_Produtos.ForeColor = System.Drawing.Color.IndianRed;
            this.btnApagar_Produtos.Location = new System.Drawing.Point(524, 24);
            this.btnApagar_Produtos.Name = "btnApagar_Produtos";
            this.btnApagar_Produtos.Size = new System.Drawing.Size(148, 43);
            this.btnApagar_Produtos.TabIndex = 1;
            this.btnApagar_Produtos.Text = "Apagar";
            this.btnApagar_Produtos.UseVisualStyleBackColor = false;
            this.btnApagar_Produtos.Click += new System.EventHandler(this.btnApagar_Produtos_Click);
            // 
            // lblApagar_Produtos
            // 
            this.lblApagar_Produtos.AutoSize = true;
            this.lblApagar_Produtos.BackColor = System.Drawing.Color.Transparent;
            this.lblApagar_Produtos.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagar_Produtos.Location = new System.Drawing.Point(23, 32);
            this.lblApagar_Produtos.Name = "lblApagar_Produtos";
            this.lblApagar_Produtos.Size = new System.Drawing.Size(330, 23);
            this.lblApagar_Produtos.TabIndex = 0;
            this.lblApagar_Produtos.Text = " Selecione um produto para apagar:";
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDoPao.Properties.Resources.paes_fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.grbApagar_Produtos);
            this.Controls.Add(this.grbEditar_Produtos);
            this.Controls.Add(this.grbCadastrar_CadastrarProdutos);
            this.Controls.Add(this.dgvProdutos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProdutos";
            this.Text = "FormProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbCadastrar_CadastrarProdutos.ResumeLayout(false);
            this.grbCadastrar_CadastrarProdutos.PerformLayout();
            this.grbEditar_Produtos.ResumeLayout(false);
            this.grbEditar_Produtos.PerformLayout();
            this.grbApagar_Produtos.ResumeLayout(false);
            this.grbApagar_Produtos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbCadastrar_CadastrarProdutos;
        private System.Windows.Forms.TextBox txbPreco_CadastrarProdutos;
        private System.Windows.Forms.TextBox txbNome_CadastrarProdutos;
        private System.Windows.Forms.Label lblPreco_CadastrarProdutos;
        private System.Windows.Forms.Label lblNome_CadastrarProdutos;
        private System.Windows.Forms.ComboBox cmbCategoria_CadastrarProdutos;
        private System.Windows.Forms.Label lblCategoria_CadastrarProdutos;
        private System.Windows.Forms.GroupBox grbEditar_Produtos;
        private System.Windows.Forms.ComboBox cmbCategoria_EditarProdutos;
        private System.Windows.Forms.TextBox txbPreco_EditarProdutos;
        private System.Windows.Forms.TextBox txbNome_EditarProdutos;
        private System.Windows.Forms.Label lblCategoria_EditarProdutos;
        private System.Windows.Forms.Label lblPreco_EditarProdutos;
        private System.Windows.Forms.Label lblNome_EditarProdutos;
        private System.Windows.Forms.GroupBox grbApagar_Produtos;
        private System.Windows.Forms.Button btnApagar_Produtos;
        private System.Windows.Forms.Label lblApagar_Produtos;
        private System.Windows.Forms.Button btnCadastrar_Produtos;
        private System.Windows.Forms.Button btnEditar_Produtos;
    }
}