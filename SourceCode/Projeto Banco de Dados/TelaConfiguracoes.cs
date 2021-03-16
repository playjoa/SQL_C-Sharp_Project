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
    public partial class TelaConfiguracoes : Form
    {
        ConexaoSQL sqlConection;

        public TelaConfiguracoes()
        {
            InitializeComponent();

            sqlConection = new ConexaoSQL();

            cmbxSexo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void TelaConfiguracoes_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        void CarregarDados() 
        {
            txtEmail.Text = sqlConection.PegarInfoDeTabela("Usuario", "email", "idUser", UsuarioAtual.idUsuario.ToString());
            txtNomeUser.Text = sqlConection.PegarInfoDeTabela("Usuario", "nomeUser", "idUser", UsuarioAtual.idUsuario.ToString());
            txtDesc.Text = sqlConection.PegarInfoDeTabela("Usuario", "descUser", "idUser", UsuarioAtual.idUsuario.ToString());

            cmbxSexo.Text = sqlConection.PegarInfoDeTabela("Usuario", "sexo", "idUser", UsuarioAtual.idUsuario.ToString());

            txtDate.Text = sqlConection.PegarInfoDeTabela("Usuario", "data_nasc", "idUser", UsuarioAtual.idUsuario.ToString());
        }

        bool VerificarSeSenhaEstaVazia() 
        {
            if (txtSenha.Text == string.Empty)
                return true;

            if (txtConfirmarSenha.Text == string.Empty)
                return true;

            return false;
        }

        bool VerificarSeEstaVazio()
        {
            if (txtEmail.Text == string.Empty)
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

        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {
            if (VerificarSeEstaVazio())
            {
                MessageBox.Show("Preencha todos os campos!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (sqlConection.VerificarSeJaTemEmUpdate("Usuario", "email", txtEmail.Text.TrimEnd().ToLower(), UsuarioAtual.idUsuario))
            {
                //JA TEM CADASTRO COM ESSE EMAIL
                MessageBox.Show("EMAIL JA CADASTRADO", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else
            {
                //Atualizado

                sqlConection.RodarLinhadeComando("UPDATE Usuario SET email = '" + txtEmail.Text.ToLower() + "', nomeUser = '"+txtNomeUser.Text +"', descUser = '" +txtDesc.Text + "', sexo = '"+ cmbxSexo.Text +"', data_nasc = '"+ txtDate.SelectionRange.Start.ToShortDateString() + "'  WHERE idUser = '" + UsuarioAtual.idUsuario+ "'; ");

                MessageBox.Show("Parabens seu cadastro foi Atualizado!", "Atualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAtualizarSenha_Click(object sender, EventArgs e)
        {
            if (VerificarSeSenhaEstaVazia())
            {
                MessageBox.Show("Preencha todos os campos!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                //Atualizado

                sqlConection.RodarLinhadeComando("UPDATE Usuario SET senha = '" + txtSenha.Text + "' WHERE idUser='" + UsuarioAtual.idUsuario + "';");
                MessageBox.Show("Parabens seu cadastro foi Atualizado!", "Atualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtConfirmarSenha.Text = string.Empty;
                txtSenha.Text = string.Empty;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmUsuario novaTela = new frmUsuario();
            this.Hide();
            novaTela.Show();
        }     
    }
}
