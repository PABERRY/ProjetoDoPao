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

        int idselecionado = 0; //armazenar o id do usuario para apagar ou editar

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
                usuarioCadastro.NomeCompleto = txbNome_Cadastro.Text;
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

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // pegar a linha selecionada:
            int ls = dgvUsuarios.SelectedCells[0].RowIndex;

            //colocar os valores das células no txbs de edição:
            txbNome_Editar.Text = dgvUsuarios.Rows[ls].Cells[1].Value.ToString();
            txbEmail_Editar.Text = dgvUsuarios.Rows[ls].Cells[2].Value.ToString();

            //armazenar o ID de quem foi selecionado:
            idselecionado = (int)dgvUsuarios.Rows[ls].Cells[0].Value;

            //ativar o grbEditar
            grbEditar.Enabled = true;

            //Ajustes no grbApagar
            lblApagar.Text = $"Apagar: {dgvUsuarios.Rows[ls].Cells[1].Value}";

            //ativar o grbApagar;
            grbApagar.Enabled = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            //perguntar se realmente quer apagar:
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar este usuário?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                //prosseguir com o apagemnto:      

                Model.Usuario usuarioapagar = new Model.Usuario();
                usuarioapagar.Id = idselecionado;
                if (usuarioapagar.Apagar())
                {
                    MessageBox.Show("Usuário apagado com sucesso!", "Show",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }
                else
                {
                    MessageBox.Show("Falha ao apagar o usuário!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        public void ResetarCampos()
        {
            //atualizar o dgv
            AtualizarDgv();

            //limpar campos de edição
            txbEmail_Editar.Clear();
            txbSenha_Editar.Clear();
            txbNome_Editar.Clear();

            //retornar o id selecionado para 0
            idselecionado = 0;

            //retornar o texto padrao do "apagar"
            lblApagar.Text = "Selecione o usuário que deseja apagar.";

            //Desabilitar os rgbs:
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbNome_Editar.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no mínimo 5 caracteres", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmail_Editar.Text.Length < 7)
            {
                MessageBox.Show("O Email deve ter no mínimo 7 caracteres", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha_Editar.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // prosseguir com a edição 
                Model.Usuario usuarioEditar = new Model.Usuario();
                usuarioEditar.Id = idselecionado;
                usuarioEditar.NomeCompleto = txbNome_Editar.Text;
                usuarioEditar.Email = txbEmail_Editar.Text;
                usuarioEditar.Senha = txbSenha_Editar.Text;

                if (usuarioEditar.Modificar())
                {
                    MessageBox.Show("Usuário modificado com sucesso!", "show",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Falha ao modificar o usuario!", "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
