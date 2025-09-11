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
    public partial class FormComandas : Form
    {
        Model.Usuario usuario;

        public FormComandas(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
        }
        public void AtualizarDgv()
        {
            Model.Produto produto = new Model.Produto();
            dgvComandas.DataSource = produto.Listar();
        }

        private void dgvComandas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pegar a linha selecionada 
            int ls = dgvComandas.SelectedCells[0].RowIndex;

            //colocar o ID do produto no campo de código
            txbProduto.Text = dgvComandas.Rows[ls].Cells[0].Value.ToString();
            //colocar o nome do produto no campo de informações:
            txbProduto_Lancamento.Text = dgvComandas.Rows[ls].Cells[1].Value.ToString();
        }

        private void btnLancar_Produto_Click(object sender, EventArgs e)
        {
            //verificar se a quantidade foi preenchida:
            if(txbQuantidade.Text.Length == 0)
            {
                MessageBox.Show("informe a quantidade!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txbComanda.Text);
                ordemComanda.IdProduto = int.Parse(txbProduto.Text);
                ordemComanda.Quantidade = int.Parse(txbQuantidade.Text);
                ordemComanda.IdResp = usuario.Id;

                if (ordemComanda.Cadastrar())
                {
                    MessageBox.Show("lançamento efetuado", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao efetuar lançamento!", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //VERIFICAR SE OS CAMPOS ETÃO VAZIOS
            if (txbComanda.Text.Length == 0)
            {
                MessageBox.Show("Informe o numero da comanda!", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbProduto.Text.Length == 0)
            {
                MessageBox.Show("Informe o código do produto!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //desativar o grbinfos:
                grbInformacoes.Enabled = false;
                //Ativar o grbLancamento
                grbLancamentos.Enabled = true;
            }

        }
        private void ResetarCampos()
        {
            //limpar os txbs:
            txbProduto.Clear();
            txbQuantidade.Clear();
            txbProduto_Lancamento.Clear();
            txbComanda.Clear();
            //resetar os groupboxes:
            grbLancamentos.Enabled = false;
            grbInformacoes.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }
    }
}
