using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoDoPao
{
    public partial class FormProdutos : Form
    {
        Model.Usuario usuario;

        int idselecionado = 0;
        public FormProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        public void AtualizarDgv()
        {
            //Mostrar as informações do bd no datagridveiw:
            dgvProdutos.DataSource = usuario.listar();
        }

        public void ListarCategoriasCmb()
        {
            Model.Categoria categoria = new Model.Categoria();
            //tabela para receber o resultado do select
            DataTable tabela = categoria.Listar();
            foreach (DataRow dr in tabela.Rows)
            {
                //1- salgados
                //2- bebidas
                cmbCategoria_CadastrarProdutos.Items.Add($"{dr["dr"]} - {dr["nome"]}");
                cmbCategoria_EditarProdutos.Items.Add($"{dr["dr"]} - {dr["nome"]}");
            }

        }

        private void btnCadastrar_Produtos_Click(object sender, EventArgs e)
        {
            double preco = double.Parse(txbPreco_CadastrarProdutos.Text);
            //Validar campos:
            if (txbNome_CadastrarProdutos.Text.Length < 3)
            {
                MessageBox.Show("O nome deve ter no mínimo 3 caracteres", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (preco <= 0)
            {
                MessageBox.Show("Verifique o valor", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
            else
            {
                //fazer o cadastro...
                Model.Produto produtoCadastro = new Model.Produto();

                //salvar os valores dos campos nos atributos do objeto:
                produtoCadastro.Nome = txbNome_CadastrarProdutos.Text;
                produtoCadastro.Preco = preco;

                string produtoselecionado = cmbCategoria_CadastrarProdutos.SelectedItem.ToString(); 
                string numero_categoria = produtoselecionado.Split('-')[0].Trim();

                //Executar o insert
                if (produtoCadastro.Cadastrar())
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Atualizar o dgv:
                    AtualizarDgv();

                    //Apagar os campos de cadastro
                    txbNome_CadastrarProdutos.Clear();
                    txbPreco_CadastrarProdutos.Clear();
                    
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o usuário", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // pegar a linha selecionada:
            int ls = dgvProdutos.SelectedCells[0].RowIndex;

            //colocar os valores das células no txbs de edição:
            txbNome_EditarProdutos.Text = dgvProdutos.Rows[ls].Cells[1].Value.ToString();
            txbPreco_EditarProdutos.Text = dgvProdutos.Rows[ls].Cells[2].Value.ToString();
            int idCategoria = Convert.ToInt32(dgvProdutos.Rows[ls].Cells[3].Value);

            //armazenar o ID de quem foi selecionado:
            idselecionado = (int)dgvProdutos.Rows[ls].Cells[0].Value;

            //ativar o grbEditar
            grbEditar_Produtos.Enabled = true;

            //Ajustes no grbApagar
            lblApagar_Produtos.Text = $"Apagar: {dgvProdutos.Rows[ls].Cells[1].Value}";

            //ativar o grbApagar;
            lblApagar_Produtos.Enabled = true;
        }

        private void btnApagar_Produtos_Click(object sender, EventArgs e)
        {
            //perguntar se realmente quer apagar:
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar este produto?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                //prosseguir com o apagemnto:      

                Model.Produto produtoApagar = new Model.Produto();
                produtoApagar.Id = idselecionado;
                if (produtoApagar.Apagar())
                {
                    MessageBox.Show("Produto apagado com sucesso!", "Show",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Falha ao apagar o produto!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void ResetarCampos()
        {
            //atualizar o dgv
            AtualizarDgv();

            //limpar campos de edição
            txbNome_EditarProdutos.Clear();
            txbPreco_EditarProdutos.Clear();
            

            //retornar o id selecionado para 0
            idselecionado = 0;

            //retornar o texto padrao do "apagar"
            lblApagar_Produtos.Text = "selecione o produto que deseja apagar.";

            //Desabilitar os rgbs:
            grbApagar_Produtos.Enabled = false;
            grbEditar_Produtos.Enabled = false;
        }

        private void btnEditar_Produtos_Click(object sender, EventArgs e)
        {
            double preco = double.Parse(txbNome_EditarProdutos.Text);
            //Validar campos:
            if (txbNome_CadastrarProdutos.Text.Length < 3)
            {
                MessageBox.Show("O nome deve ter no mínimo 3 caracteres", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (preco <= 0)
            {
                MessageBox.Show("Verifique o valor", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

            
        }
    }
}
