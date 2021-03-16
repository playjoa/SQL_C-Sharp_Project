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
    public partial class frmUsuario : Form
    {
        ConexaoSQL sqlConection;
        int idJogoSelecionado = -1, idMeuJogoSelecionado = -1, scoreAtual;

        public frmUsuario()
        {
            InitializeComponent();

            sqlConection = new ConexaoSQL();

            cmbxPesquisaMeusJogos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxNota.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxJogosDisponiveis.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbxNota.SelectedIndex = 0;
        }

        void HabilitarFuncoesDev() 
        {
            if (UsuarioAtual.isDeveloper)
            {
                grpDeveloper.Visible = true;
                grpMeusJogos.Visible = true;

                btnVirarDev.Visible = false;

                UsuarioAtual.idDev = Convert.ToInt32(sqlConection.PegarInfoDeTabela("developer", "idDev", "idUser", UsuarioAtual.idUsuario.ToString()));
            }
            else
            {
                grpMeusJogos.Visible = false;
                grpDeveloper.Visible = false;

                btnVirarDev.Visible = true;
            }
        }

        bool VerificarCamposJogo() 
        {
            if (txtNomeJogo.Text == string.Empty)
                return true;

            if (txtDescJogo.Text == string.Empty)
                return true;

            return false;
        }

        bool VerificarCamposAvaliacao()
        {
            if (cmbxNota.Text == string.Empty)
                return true;

            if (txtDescAvaliacao.Text == string.Empty)
                return true;

            return false;
        }

        bool VerificarCamposAtualizarJogo()
        {
            if (txtNomeAtualizado.Text == string.Empty)
                return true;

            if (txtDescAtualizacao.Text == string.Empty)
                return true;

            return false;
        }

        void VoltarParaLogIn()
        {
            frmLogIn novaTela = new frmLogIn();
            this.Hide();
            novaTela.Show();
        }

        private void btnCadastrarJogo_Click(object sender, EventArgs e)
        {
            if (VerificarCamposJogo())
            {
                MessageBox.Show("Preencha todos os campos!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sqlConection.VerificarSeJaTemEm("Jogo", "nomeJogo", txtNomeJogo.Text.TrimEnd())) 
            {
                MessageBox.Show("Jogo ja existe com esse nome!!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else
            {
                //JA TEM JOGO CADASTRO COM ESSE NOME
                string[] campos = new string[] { "idDev", "nomeJogo", "descJogo", "dataLancamento" };
                string[] valores = new string[] { UsuarioAtual.idDev.ToString(), txtNomeJogo.Text.TrimEnd(), txtDescJogo.Text, DateTime.Today.ToShortDateString() };

                sqlConection.NovaInsercao("Jogo", campos, valores);

                txtNomeJogo.Text = string.Empty;
                txtDescJogo.Text = string.Empty;

                MessageBox.Show("Cadastro realizado com sucesso!!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TelaUsuario_Load(object sender, EventArgs e)
        {
            HabilitarFuncoesDev();

            lblMsgBemVindo.Text = "Seja Bem Vindo, " + UsuarioAtual.nomeUser;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            UsuarioAtual.ApagarDados();
            VoltarParaLogIn();
        }

        private void btnVirarDev_Click(object sender, EventArgs e)
        {
            sqlConection.NovaInsercao("Developer", new string [] {"idUser"}, new string[] { UsuarioAtual.idUsuario.ToString() });
            UsuarioAtual.isDeveloper = true;
            HabilitarFuncoesDev();
        }

        void PreencherItensJogo() 
        {
            cmbxJogosDisponiveis.Items.Clear();

            List<string> lista = sqlConection.ListaDeTodosJogos();

            lista.Sort();

            foreach (string l in lista)
            {
                cmbxJogosDisponiveis.Items.Add(l);
            }
        }

        void PreencherMeusJogos()
        {
            cmbxPesquisaMeusJogos.Items.Clear();

            List<string> lista = sqlConection.ListarMeusJogos(UsuarioAtual.idDev);

            lista.Sort();

            foreach (string l in lista)
            {
                cmbxPesquisaMeusJogos.Items.Add(l);
            }
        }

        private void cmbxJogosDisponiveis_DropDown(object sender, EventArgs e)
        {
            //Clique para abrir lista
            PreencherItensJogo();   
        }

        private void cmbxJogosDisponiveis_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Jogo Selecionado
            idJogoSelecionado = Convert.ToInt32(sqlConection.PegarInfoDeTabela("Jogo", "idJogo", "nomeJogo", cmbxJogosDisponiveis.SelectedItem.ToString()));

            AtualizarTextoScore();
            PreencherAvaliacoesDeUsuarios();
        }

        void PreencherAvaliacoesDeUsuarios() 
        {
            string cabecario = "Titulo: " + cmbxJogosDisponiveis.SelectedItem.ToString() + Environment.NewLine +
                "Nota Media: " + sqlConection.MediaDoJogo(idJogoSelecionado) + Environment.NewLine +
                "Maior Score: " + sqlConection.MaiorScoreDoJogo(idJogoSelecionado) +" de: "+ sqlConection.PegarNomeUsuarioDoScore(sqlConection.MaiorScoreDoJogo(idJogoSelecionado).ToString()) + Environment.NewLine +
                "Descrição: " + sqlConection.PegarInfoDeTabela("Jogo", "descJogo", "idJogo", idJogoSelecionado.ToString()) + Environment.NewLine +
                "Developer: " + sqlConection.PegarNomeDevJogo(idJogoSelecionado) + Environment.NewLine +
                "----------------------------------------------" + Environment.NewLine;

            string comentarios = sqlConection.DevolverAvaliacoesJogo(idJogoSelecionado);

            txtTodasAvaliacoes.Text = cabecario + comentarios;
        }

        void AtualizarTextoScore() 
        {
            scoreAtual = sqlConection.VoltarScoreJogoDoUsuario(idJogoSelecionado, UsuarioAtual.idUsuario);

            if (scoreAtual < 0)
                lblScoreAtual.Text = "Nenhum Score!";
            else
                lblScoreAtual.Text = "Score Atual: " + scoreAtual;
        }

        private void btnAvaliarJogo_Click(object sender, EventArgs e)
        {
            //Avaliar Jogo

            if (VerificarCamposAvaliacao())
            {
                MessageBox.Show("Preencha todos os campos!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (idJogoSelecionado == -1)
            {
                MessageBox.Show("Por Favor Escolha um jogo para ser avaliado!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Nota inserida com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConection.InserirAvaliacao(idJogoSelecionado, UsuarioAtual.idUsuario, Convert.ToInt32(cmbxNota.SelectedItem.ToString()), txtDescAvaliacao.Text);

                txtDescAvaliacao.Text = string.Empty;
            }
        }

        private void cmbxPesquisaMeusJogos_DropDown(object sender, EventArgs e)
        {
            //MEU JOGO CLICADO
            PreencherMeusJogos();
        }

        private void cmbxPesquisaMeusJogos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MEU JOGO SELECIONADO
            idMeuJogoSelecionado = Convert.ToInt32(sqlConection.PegarInfoDeTabela("Jogo", "idJogo", "nomeJogo", cmbxPesquisaMeusJogos.SelectedItem.ToString()));

            txtNomeAtualizado.Text = cmbxPesquisaMeusJogos.SelectedItem.ToString();
            txtDescAtualizacao.Text = sqlConection.PegarInfoDeTabela("Jogo", "descJogo", "nomeJogo", cmbxPesquisaMeusJogos.SelectedItem.ToString());

            lblMediaNota.Text = "Media: " + sqlConection.MediaDoJogo(idMeuJogoSelecionado);
            lblJogadoTantasVezes.Text = "Jogado: " + sqlConection.ContarEm("JogaJogo", "idJogo", idMeuJogoSelecionado.ToString()) + " vezes!";
        }

        private void btnConfigPlayer_Click(object sender, EventArgs e)
        {
            TelaConfiguracoes novaTela = new TelaConfiguracoes();
            this.Hide();
            novaTela.Show();
        }

        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {
            PreencherAvaliacoesDeUsuarios();
        }

        private void txtScoreDesejado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAtualizarJogo_Click(object sender, EventArgs e)
        {
            //Atualizar DADOS do Jogo

            if (VerificarCamposAtualizarJogo())
            {
                MessageBox.Show("Preencha todos os campos!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (idMeuJogoSelecionado == -1)
            {
                MessageBox.Show("Nenhum Jogo Selecionado!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                sqlConection.AtualizarDadosJogo(idMeuJogoSelecionado, txtNomeAtualizado.Text, txtDescAtualizacao.Text);

                cmbxPesquisaMeusJogos.Text = string.Empty;
                txtNomeAtualizado.Text = string.Empty;
                txtDescAtualizacao.Text = string.Empty;
                idMeuJogoSelecionado = -1;
            }
        }

        private void btnAtualizarScoreJogo_Click(object sender, EventArgs e)
        {
            if(txtScoreDesejado.Text == string.Empty)
            {
                //SCORE NAO EH MAIOR Q O ANTERIOR
                MessageBox.Show("Por favor preencha um valor!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int scoreEntrada = Convert.ToInt32(txtScoreDesejado.Text);

            if (scoreEntrada <= scoreAtual)
            {
                //SCORE NAO EH MAIOR Q O ANTERIOR
                MessageBox.Show("Score atual é menor ou igual ao anterior!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (scoreEntrada < 0)
            {
                //SCORE Negativo
                MessageBox.Show("Score tem que ser maior que 0!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            else if (scoreAtual == -1)
            {
                //Primeiro Score a ser inserido

                string[] campos = new string[] { "idJogo", "idUser", "valorScore" };
                string[] valores = new string[] {  idJogoSelecionado.ToString(), UsuarioAtual.idUsuario.ToString(), scoreEntrada.ToString() };

                sqlConection.NovaInsercao("JogaJogo", campos, valores);
            }
            else
            {
                //Atualizar Score Atual
                sqlConection.AtualizarScore(idJogoSelecionado, UsuarioAtual.idUsuario, scoreEntrada);
            }

            txtScoreDesejado.Text = string.Empty;

            AtualizarTextoScore();
        }
    }
}
