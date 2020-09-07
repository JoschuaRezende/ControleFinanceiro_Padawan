using Padawan.Financeiro.Negocio.Banco;
using Padawan.Financeiro.Negocio.Models;
using System;
using System.Windows.Forms;

namespace Padawan.Financeiro.View
{
    public partial class FormsUsuario : Form
    {
        private readonly Banco<Usuario> banco;
        public FormsUsuario()
        {
            InitializeComponent();
            banco = new Banco<Usuario>();
        }

        private void FormsUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario()
            {
                Nome = txt_Nome.Text,
                Login = txt_Usuario.Text,
                Senha = txt_Senha.Text
            };

            var retorno = banco.Add(usuario);

            if (retorno)
            {
                MessageBox.Show("Cadastrado com sucesso");

            }
            else
            {
                MessageBox.Show("Erro ao cadastrar");
            }
        
        }
    }
}
