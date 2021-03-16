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
    public partial class frmCadUsuario : Form
    {
        ConexaoSQL sqlConection;

        public frmCadUsuario()
        {
            InitializeComponent();

            sqlConection = new ConexaoSQL();

            cmbxSexo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnVoltarLogIn_Click(object sender, EventArgs e)
        {
            VoltarParaLogIn();
        }

        void VoltarParaLogIn() 
        {
            frmLogIn novaTela = new frmLogIn();
            this.Hide();
            novaTela.Show();
        }

        bool VerificarSeEstaVazio() 
        {
            if (txtEmail.Text == string.Empty)
                return true;

            if (txtSenha.Text == string.Empty)
                return true;

            if (txtConfirmarSenha.Text == string.Empty)
                return true;

            if (txtNomeUser.Text == string.Empty)
                return true;

            if (txtDesc.Text == string.Empty)
                return true;

            if (txtDate.SelectionRange.Start.ToShortDateString() == string.Empty)
                return true;

            if (cmbxSexo.Text == string.Empty)
                return true;

            return false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (VerificarSeEstaVazio())
            {
                MessageBox.Show("Preencha todos os campos!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }


            if (sqlConection.VerificarSeJaTemEm("Usuario", "email", txtEmail.Text.TrimEnd()))
            {
                //JA TEM CADASTRO COM ESSE EMAIL
                MessageBox.Show("EMAIL JA CADASTRADO", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else if (txtConfirmarSenha.Text != txtSenha.Text)
            {
                //Senhas Divergentes
                MessageBox.Show("Senhas sao diferentes!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else
            {
                //NAO TEM CADASTRO
                
                string[] campos = new string[] { "idUser", "email", "senha", "nomeUser", "descUser", "data_nasc", "sexo"};
                string[] valores = new string[] { "0", txtEmail.Text.TrimEnd().ToLower(), txtSenha.Text, txtNomeUser.Text, txtDesc.Text, txtDate.SelectionRange.Start.ToShortDateString(), cmbxSexo.Text };

                sqlConection.NovaInsercao("Usuario", campos, valores);

                MessageBox.Show("Parabens seu cadastro foi um sucesso!" ,"CADASTRADO!",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                VoltarParaLogIn();
            }
        }
    }
}
