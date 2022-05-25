using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engleasy
{
    public partial class F_NovoUsuario : Form
    {
        public F_NovoUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.nome = tb_nome.Text;
            usuario.username = tb_username.Text;
            usuario.senha = tb_senha.Text;
            usuario.status = "A";
            usuario.nivel = 1;
            usuario.ponto = 0;

            Banco.NovoUsuario(usuario);
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_username.Clear();
            tb_senha.Clear();
            tb_nome.Focus();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_username.Clear();
            tb_senha.Clear();
            tb_nome.Focus();
        }
    }
}
