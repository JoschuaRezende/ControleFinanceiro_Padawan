using Padawan.Financeiro.Negocio.Banco;
using Padawan.Financeiro.Negocio.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Padawan.Financeiro.View
{
    public partial class FormsLogin : Form
    {
        private readonly Banco<Usuario> banco;
        public FormsLogin()
        {
            InitializeComponent();
            banco = new Banco<Usuario>();
        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            var lista = banco.Listar();
            var usuario = lista.Where(p => p.Login == txt_usuario.Text).FirstOrDefault();
            if (usuario == null)
            {
                MessageBox.Show("Usuario não encontrado");

            }
            else
            {
                if (usuario.Senha == txt_senha.Text)
                {
                    new Inicial().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Senha incorreta");
                }
            }
        }

        private void FormsLogin_Load(object sender, EventArgs e)
        {
          
            
        }

        private void lbl_CadastrarUsuario_Click(object sender, EventArgs e)
        {
            new FormsUsuario().ShowDialog();
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
