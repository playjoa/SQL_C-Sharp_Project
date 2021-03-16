using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Banco_de_Dados
{
    public partial class frmLogIn : Form
    {
        ConexaoSQL sqlConection;

        public frmLogIn()
        {
            InitializeComponent();

            sqlConection = new ConexaoSQL();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            frmCadUsuario telaCad = new frmCadUsuario();
            this.Hide();
            telaCad.Show();
        }

        bool VerificarSeEstaVazio()
        {
            if (txtEmail.Text == string.Empty)
                return true;

            if (txtSenha.Text == string.Empty)
                return true;

            return false;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (VerificarSeEstaVazio())
            {
                MessageBox.Show("Preencha todos os campos!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            int resultadoLogIn = sqlConection.VerificarLogIn(txtEmail.Text.ToLower(), txtSenha.Text);

            if (resultadoLogIn < 0)
            {
                // NAO EXISTE USUARIO
                MessageBox.Show("LogIn Não encontrado!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                // EXISTE USUARIO
                UsuarioAtual.idUsuario = resultadoLogIn;
                UsuarioAtual.isDeveloper = sqlConection.VerificarSerDev(UsuarioAtual.idUsuario);

                frmUsuario telaUser = new frmUsuario();
                this.Hide();
                telaUser.Show();
            }
        }
    }
}
