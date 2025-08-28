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

                //tabela que vai receber o resultado do SELECT (logar)
                DataTable resultado = usuario.Logar();

                //verificar se acertou o email e senha
                if(resultado.Rows.Count == 0 ) 
                {
                    MessageBox.Show("E-mail e/ou senha inválidos!", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                
                }
                else
                {
                    //armazenar as infos vindas do bd no objeto "usuario" 
                    usuario.Id = int.Parse (resultado.Rows[0]["id"].ToString());
                    usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();

                    // mudar para o menu principal:
                    MenuPrincipal menuPrincipal = new MenuPrincipal(usuario);
                    Hide(); //esconder a janela atual
                    menuPrincipal.ShowDialog(); // mostrar o meni principal

                    Show();//mostrar a tela de login ao sair do menu principal

                }
            }
        }
    }
}
