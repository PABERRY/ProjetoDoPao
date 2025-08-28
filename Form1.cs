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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // verificar se a pessoa digitou o email e a senha:
            
            if (txbLogin.Text.Length < 6 )
            {
                MessageBox.Show("Digite um e-mail Válido!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha.Text.Length < 4 )
            {
                MessageBox.Show("Digite uma senha Válida!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Prosseguir...
                Model.Usuario usuario = new Model.Usuario();

                //colocar os valores dos campos nos atributos do usuario:
                usuario.Email = txbLogin.Text;
                usuario.Senha = txbSenha.Text;
            }
        }
    }
}
