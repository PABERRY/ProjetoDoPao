namespace ProjetoDoPao
{
    partial class FormUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.btnCadastrar_Cadastro = new System.Windows.Forms.Button();
            this.txbSenha_Cadastro = new System.Windows.Forms.TextBox();
            this.txbEmail_cadastro = new System.Windows.Forms.TextBox();
            this.txbNome_Cadastro = new System.Windows.Forms.TextBox();
            this.lblSenha_Cadastro = new System.Windows.Forms.Label();
            this.lblEmail_Cadastro = new System.Windows.Forms.Label();
            this.lblNome_Cadastro = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbSenha_Editar = new System.Windows.Forms.TextBox();
            this.txbEmail_Editar = new System.Windows.Forms.TextBox();
            this.txbNome_Editar = new System.Windows.Forms.TextBox();
            this.lblSenha_Editar = new System.Windows.Forms.Label();
            this.lblEmail_Editar = new System.Windows.Forms.Label();
            this.lblNome_Editar = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblApagar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(21, 22);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(370, 355);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // grbCadastro
            // 
            this.grbCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.grbCadastro.Controls.Add(this.btnCadastrar_Cadastro);
            this.grbCadastro.Controls.Add(this.txbSenha_Cadastro);
            this.grbCadastro.Controls.Add(this.txbEmail_cadastro);
            this.grbCadastro.Controls.Add(this.txbNome_Cadastro);
            this.grbCadastro.Controls.Add(this.lblSenha_Cadastro);
            this.grbCadastro.Controls.Add(this.lblEmail_Cadastro);
            this.grbCadastro.Controls.Add(this.lblNome_Cadastro);
            this.grbCadastro.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastro.Location = new System.Drawing.Point(440, 22);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(293, 159);
            this.grbCadastro.TabIndex = 1;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // btnCadastrar_Cadastro
            // 
            this.btnCadastrar_Cadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrar_Cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar_Cadastro.Location = new System.Drawing.Point(9, 109);
            this.btnCadastrar_Cadastro.Name = "btnCadastrar_Cadastro";
            this.btnCadastrar_Cadastro.Size = new System.Drawing.Size(278, 36);
            this.btnCadastrar_Cadastro.TabIndex = 2;
            this.btnCadastrar_Cadastro.Text = "Cadastrar";
            this.btnCadastrar_Cadastro.UseVisualStyleBackColor = true;
            this.btnCadastrar_Cadastro.Click += new System.EventHandler(this.btnCadastrar_Cadastro_Click);
            // 
            // txbSenha_Cadastro
            // 
            this.txbSenha_Cadastro.Location = new System.Drawing.Point(105, 82);
            this.txbSenha_Cadastro.Name = "txbSenha_Cadastro";
            this.txbSenha_Cadastro.Size = new System.Drawing.Size(168, 21);
            this.txbSenha_Cadastro.TabIndex = 1;
            // 
            // txbEmail_cadastro
            // 
            this.txbEmail_cadastro.Location = new System.Drawing.Point(105, 55);
            this.txbEmail_cadastro.Name = "txbEmail_cadastro";
            this.txbEmail_cadastro.Size = new System.Drawing.Size(168, 21);
            this.txbEmail_cadastro.TabIndex = 1;
            // 
            // txbNome_Cadastro
            // 
            this.txbNome_Cadastro.Location = new System.Drawing.Point(105, 26);
            this.txbNome_Cadastro.Name = "txbNome_Cadastro";
            this.txbNome_Cadastro.Size = new System.Drawing.Size(168, 21);
            this.txbNome_Cadastro.TabIndex = 1;
            // 
            // lblSenha_Cadastro
            // 
            this.lblSenha_Cadastro.AutoSize = true;
            this.lblSenha_Cadastro.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha_Cadastro.Location = new System.Drawing.Point(57, 87);
            this.lblSenha_Cadastro.Name = "lblSenha_Cadastro";
            this.lblSenha_Cadastro.Size = new System.Drawing.Size(42, 14);
            this.lblSenha_Cadastro.TabIndex = 0;
            this.lblSenha_Cadastro.Text = "Senha:";
            // 
            // lblEmail_Cadastro
            // 
            this.lblEmail_Cadastro.AutoSize = true;
            this.lblEmail_Cadastro.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail_Cadastro.Location = new System.Drawing.Point(61, 55);
            this.lblEmail_Cadastro.Name = "lblEmail_Cadastro";
            this.lblEmail_Cadastro.Size = new System.Drawing.Size(38, 14);
            this.lblEmail_Cadastro.TabIndex = 0;
            this.lblEmail_Cadastro.Text = "Email:";
            // 
            // lblNome_Cadastro
            // 
            this.lblNome_Cadastro.AutoSize = true;
            this.lblNome_Cadastro.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome_Cadastro.Location = new System.Drawing.Point(6, 29);
            this.lblNome_Cadastro.Name = "lblNome_Cadastro";
            this.lblNome_Cadastro.Size = new System.Drawing.Size(96, 14);
            this.lblNome_Cadastro.TabIndex = 0;
            this.lblNome_Cadastro.Text = "Nome Completo:";
            // 
            // grbEditar
            // 
            this.grbEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbSenha_Editar);
            this.grbEditar.Controls.Add(this.txbEmail_Editar);
            this.grbEditar.Controls.Add(this.txbNome_Editar);
            this.grbEditar.Controls.Add(this.lblSenha_Editar);
            this.grbEditar.Controls.Add(this.lblEmail_Editar);
            this.grbEditar.Controls.Add(this.lblNome_Editar);
            this.grbEditar.Enabled = false;
            this.grbEditar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.Location = new System.Drawing.Point(440, 218);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(293, 159);
            this.grbEditar.TabIndex = 2;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(9, 109);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(278, 36);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbSenha_Editar
            // 
            this.txbSenha_Editar.Location = new System.Drawing.Point(105, 82);
            this.txbSenha_Editar.Name = "txbSenha_Editar";
            this.txbSenha_Editar.Size = new System.Drawing.Size(168, 21);
            this.txbSenha_Editar.TabIndex = 1;
            // 
            // txbEmail_Editar
            // 
            this.txbEmail_Editar.Location = new System.Drawing.Point(105, 55);
            this.txbEmail_Editar.Name = "txbEmail_Editar";
            this.txbEmail_Editar.Size = new System.Drawing.Size(168, 21);
            this.txbEmail_Editar.TabIndex = 1;
            // 
            // txbNome_Editar
            // 
            this.txbNome_Editar.Location = new System.Drawing.Point(105, 26);
            this.txbNome_Editar.Name = "txbNome_Editar";
            this.txbNome_Editar.Size = new System.Drawing.Size(168, 21);
            this.txbNome_Editar.TabIndex = 1;
            // 
            // lblSenha_Editar
            // 
            this.lblSenha_Editar.AutoSize = true;
            this.lblSenha_Editar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha_Editar.Location = new System.Drawing.Point(57, 87);
            this.lblSenha_Editar.Name = "lblSenha_Editar";
            this.lblSenha_Editar.Size = new System.Drawing.Size(42, 14);
            this.lblSenha_Editar.TabIndex = 0;
            this.lblSenha_Editar.Text = "Senha:";
            // 
            // lblEmail_Editar
            // 
            this.lblEmail_Editar.AutoSize = true;
            this.lblEmail_Editar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail_Editar.Location = new System.Drawing.Point(61, 55);
            this.lblEmail_Editar.Name = "lblEmail_Editar";
            this.lblEmail_Editar.Size = new System.Drawing.Size(38, 14);
            this.lblEmail_Editar.TabIndex = 0;
            this.lblEmail_Editar.Text = "Email:";
            // 
            // lblNome_Editar
            // 
            this.lblNome_Editar.AutoSize = true;
            this.lblNome_Editar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome_Editar.Location = new System.Drawing.Point(6, 29);
            this.lblNome_Editar.Name = "lblNome_Editar";
            this.lblNome_Editar.Size = new System.Drawing.Size(96, 14);
            this.lblNome_Editar.TabIndex = 0;
            this.lblNome_Editar.Text = "Nome Completo:";
            // 
            // grbApagar
            // 
            this.grbApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(211)))));
            this.grbApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblApagar);
            this.grbApagar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbApagar.Location = new System.Drawing.Point(21, 387);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(715, 85);
            this.grbApagar.TabIndex = 3;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Transparent;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.ForeColor = System.Drawing.Color.IndianRed;
            this.btnApagar.Location = new System.Drawing.Point(524, 24);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(148, 43);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.BackColor = System.Drawing.Color.Transparent;
            this.lblApagar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagar.Location = new System.Drawing.Point(23, 32);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(317, 23);
            this.lblApagar.TabIndex = 0;
            this.lblApagar.Text = "Selecione um usuário para apagar.";
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoDoPao.Properties.Resources.paes_fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Label lblNome_Cadastro;
        private System.Windows.Forms.Label lblEmail_Cadastro;
        private System.Windows.Forms.Button btnCadastrar_Cadastro;
        private System.Windows.Forms.TextBox txbSenha_Cadastro;
        private System.Windows.Forms.TextBox txbEmail_cadastro;
        private System.Windows.Forms.TextBox txbNome_Cadastro;
        private System.Windows.Forms.Label lblSenha_Cadastro;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbSenha_Editar;
        private System.Windows.Forms.TextBox txbEmail_Editar;
        private System.Windows.Forms.TextBox txbNome_Editar;
        private System.Windows.Forms.Label lblSenha_Editar;
        private System.Windows.Forms.Label lblEmail_Editar;
        private System.Windows.Forms.Label lblNome_Editar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblApagar;
    }
}