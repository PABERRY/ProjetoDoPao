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
    public partial class MenuPrincipal : Form
    {
        //variaveis globais
        Model.Usuario usuario = new Model.Usuario();  
        public MenuPrincipal(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblSaldação.Text = $"Olá {usuario.NomeCompleto}, Escolha uma opção abaixo:";
        }

        private void btnComandas_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios(usuario);
            formUsuarios.ShowDialog();// mostrar o form
        }
    }
}
