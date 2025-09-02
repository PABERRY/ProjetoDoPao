using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDoPao
{
   
    
    public partial class FormUsuarios : Form
    {
        //objetos globais:
        Model.Usuario usuario;

        public FormUsuarios(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            AtualizarDgv();
        }

        public void AtualizarDgv()
        {
            //Mostrar as informações do bd no datagridveiw:
            dgvUsuarios.DataSource = usuario.listar();
        }

        private void btnCadastrar_Cadastro_Click(object sender, EventArgs e)
        {
            //Validar campos:
            if(txbNome_Cadastro.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no mínimo 5 caracteres", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txbEmail_cadastro.Text.Length < 7)
            {
                MessageBox.Show("O Email deve ter no mínimo 7 caracteres", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha_Cadastro.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //fazer o cadastro...
                Model.Usuario usuarioCadastro = new Model.Usuario();

                //salvar os valores dos campos nos atributos do objeto:
                usuarioCadastro.NomeCompleto = txbSenha_Cadastro.Text;
                usuarioCadastro.Email = txbEmail_cadastro.Text;
                usuarioCadastro.Senha = txbSenha_Cadastro.Text;

                //Executar o insert
                if (usuarioCadastro.Cadastrar())
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Atualizar o dgv:
                    AtualizarDgv();

                    //Apagar os campos de cadastro
                    txbNome_Cadastro.Clear();
                    txbEmail_cadastro.Clear();
                    txbSenha_Cadastro.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o usuário", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
