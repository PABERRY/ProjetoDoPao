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
    public partial class FormProdutos : Form
    {
        Model.Usuario usuario;
        public FormProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
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
    }
}
