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
    public partial class FormCaixa : Form
    {
        Model.Usuario usuario;
        public FormCaixa(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //verificar se o campos esta vazio:
            if(txbNumero_Comanda.Text.Length == 0)
            {
                MessageBox.Show("Informe o número da comanda!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txbNumero_Comanda.Text);

                //tabela para receber o resultado da consulta SELECT
                DataTable resultado = ordemComanda.BuscarPorFicha();

                //verificar se existem linhas em "Resultado":
                if(resultado.Rows.Count > 0)
                {
                    // mostrar no dgv
                    dgvComandas.DataSource = resultado;
                    //calcular o total e mostrar no lblvalor
                    lblValor.Text = "R$" + resultado.Compute("sum(Total_Item)", "true").ToString();
                }
                else
                {
                    //limpar o dgv
                    dgvComandas.DataSource= null;

                    //mostrar mensagem de erro
                    MessageBox.Show("Não existem lançamentos para esta comanda!", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void chbPagamento_CheckedChanged(object sender, EventArgs e)
        {
            btnEncerrar.Enabled = chbPagamento.Checked;

        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja encerrar esta comanda?", 
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resultado == DialogResult.Yes)
            {
                //encerrar comanda 
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txbNumero_Comanda.Text);

                //executar update para encerrar a comanda:
                if (ordemComanda.EncerrarComanda())
                {
                    MessageBox.Show("Comanda encerrada!","show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //resetar os campos
                    txbNumero_Comanda.Clear();
                    dgvComandas.DataSource = null;
                    chbPagamento.Checked = false;
                    btnEncerrar.Enabled=false;
                    lblValor.Text = "R$    -";
                }
                else
                {
                    MessageBox.Show("Falha ao encerrar a comanda!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
