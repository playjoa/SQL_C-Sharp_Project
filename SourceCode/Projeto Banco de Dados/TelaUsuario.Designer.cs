namespace Projeto_Banco_de_Dados
{
    partial class frmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDeveloper = new System.Windows.Forms.GroupBox();
            this.txtDescJogo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeJogo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarJogo = new System.Windows.Forms.Button();
            this.lblMsgBemVindo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVirarDev = new System.Windows.Forms.Button();
            this.grbxHighScores = new System.Windows.Forms.GroupBox();
            this.btnAtualizarDados = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTodasAvaliacoes = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbxNota = new System.Windows.Forms.ComboBox();
            this.txtDescAvaliacao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAvaliarJogo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScoreDesejado = new System.Windows.Forms.TextBox();
            this.btnAtualizarScoreJogo = new System.Windows.Forms.Button();
            this.lblScoreAtual = new System.Windows.Forms.Label();
            this.cmbxJogosDisponiveis = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpMeusJogos = new System.Windows.Forms.GroupBox();
            this.lblMediaNota = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescAtualizacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeAtualizado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAtualizarJogo = new System.Windows.Forms.Button();
            this.cmbxPesquisaMeusJogos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConfigPlayer = new System.Windows.Forms.Button();
            this.lblJogadoTantasVezes = new System.Windows.Forms.Label();
            this.grpDeveloper.SuspendLayout();
            this.grbxHighScores.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpMeusJogos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDeveloper
            // 
            this.grpDeveloper.Controls.Add(this.txtDescJogo);
            this.grpDeveloper.Controls.Add(this.label4);
            this.grpDeveloper.Controls.Add(this.txtNomeJogo);
            this.grpDeveloper.Controls.Add(this.label1);
            this.grpDeveloper.Controls.Add(this.btnCadastrarJogo);
            this.grpDeveloper.Location = new System.Drawing.Point(259, 40);
            this.grpDeveloper.Name = "grpDeveloper";
            this.grpDeveloper.Size = new System.Drawing.Size(247, 174);
            this.grpDeveloper.TabIndex = 0;
            this.grpDeveloper.TabStop = false;
            this.grpDeveloper.Text = "Adicionar Jogo";
            // 
            // txtDescJogo
            // 
            this.txtDescJogo.AllowDrop = true;
            this.txtDescJogo.Location = new System.Drawing.Point(12, 79);
            this.txtDescJogo.Multiline = true;
            this.txtDescJogo.Name = "txtDescJogo";
            this.txtDescJogo.Size = new System.Drawing.Size(229, 60);
            this.txtDescJogo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descrição:";
            // 
            // txtNomeJogo
            // 
            this.txtNomeJogo.Location = new System.Drawing.Point(12, 39);
            this.txtNomeJogo.Name = "txtNomeJogo";
            this.txtNomeJogo.Size = new System.Drawing.Size(229, 20);
            this.txtNomeJogo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome Jogo:";
            // 
            // btnCadastrarJogo
            // 
            this.btnCadastrarJogo.Location = new System.Drawing.Point(85, 145);
            this.btnCadastrarJogo.Name = "btnCadastrarJogo";
            this.btnCadastrarJogo.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarJogo.TabIndex = 7;
            this.btnCadastrarJogo.Text = "Cadastrar";
            this.btnCadastrarJogo.UseVisualStyleBackColor = true;
            this.btnCadastrarJogo.Click += new System.EventHandler(this.btnCadastrarJogo_Click);
            // 
            // lblMsgBemVindo
            // 
            this.lblMsgBemVindo.AutoSize = true;
            this.lblMsgBemVindo.Location = new System.Drawing.Point(72, 14);
            this.lblMsgBemVindo.Name = "lblMsgBemVindo";
            this.lblMsgBemVindo.Size = new System.Drawing.Size(64, 13);
            this.lblMsgBemVindo.TabIndex = 1;
            this.lblMsgBemVindo.Text = "Bem Vindo, ";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(431, 582);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVirarDev
            // 
            this.btnVirarDev.Location = new System.Drawing.Point(365, 9);
            this.btnVirarDev.Name = "btnVirarDev";
            this.btnVirarDev.Size = new System.Drawing.Size(141, 23);
            this.btnVirarDev.TabIndex = 9;
            this.btnVirarDev.Text = "Seja Um Developer";
            this.btnVirarDev.UseVisualStyleBackColor = true;
            this.btnVirarDev.Click += new System.EventHandler(this.btnVirarDev_Click);
            // 
            // grbxHighScores
            // 
            this.grbxHighScores.Controls.Add(this.btnAtualizarDados);
            this.grbxHighScores.Controls.Add(this.label5);
            this.grbxHighScores.Controls.Add(this.txtTodasAvaliacoes);
            this.grbxHighScores.Controls.Add(this.groupBox3);
            this.grbxHighScores.Controls.Add(this.label3);
            this.grbxHighScores.Controls.Add(this.txtScoreDesejado);
            this.grbxHighScores.Controls.Add(this.btnAtualizarScoreJogo);
            this.grbxHighScores.Controls.Add(this.lblScoreAtual);
            this.grbxHighScores.Controls.Add(this.cmbxJogosDisponiveis);
            this.grbxHighScores.Controls.Add(this.label2);
            this.grbxHighScores.Location = new System.Drawing.Point(12, 40);
            this.grbxHighScores.Name = "grbxHighScores";
            this.grbxHighScores.Size = new System.Drawing.Size(241, 571);
            this.grbxHighScores.TabIndex = 10;
            this.grbxHighScores.TabStop = false;
            this.grbxHighScores.Text = "Adicionar Highscore";
            // 
            // btnAtualizarDados
            // 
            this.btnAtualizarDados.Location = new System.Drawing.Point(181, 346);
            this.btnAtualizarDados.Name = "btnAtualizarDados";
            this.btnAtualizarDados.Size = new System.Drawing.Size(54, 23);
            this.btnAtualizarDados.TabIndex = 19;
            this.btnAtualizarDados.Text = "Refresh";
            this.btnAtualizarDados.UseVisualStyleBackColor = true;
            this.btnAtualizarDados.Click += new System.EventHandler(this.btnAtualizarDados_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Avaliações dos Jogadores:";
            // 
            // txtTodasAvaliacoes
            // 
            this.txtTodasAvaliacoes.AllowDrop = true;
            this.txtTodasAvaliacoes.Location = new System.Drawing.Point(7, 373);
            this.txtTodasAvaliacoes.Multiline = true;
            this.txtTodasAvaliacoes.Name = "txtTodasAvaliacoes";
            this.txtTodasAvaliacoes.ReadOnly = true;
            this.txtTodasAvaliacoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTodasAvaliacoes.Size = new System.Drawing.Size(228, 192);
            this.txtTodasAvaliacoes.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cmbxNota);
            this.groupBox3.Controls.Add(this.txtDescAvaliacao);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnAvaliarJogo);
            this.groupBox3.Location = new System.Drawing.Point(6, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 166);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Avaliar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Nota:";
            // 
            // cmbxNota
            // 
            this.cmbxNota.DisplayMember = "1";
            this.cmbxNota.FormattingEnabled = true;
            this.cmbxNota.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.cmbxNota.Location = new System.Drawing.Point(6, 46);
            this.cmbxNota.Name = "cmbxNota";
            this.cmbxNota.Size = new System.Drawing.Size(217, 21);
            this.cmbxNota.TabIndex = 12;
            this.cmbxNota.ValueMember = "1";
            // 
            // txtDescAvaliacao
            // 
            this.txtDescAvaliacao.AllowDrop = true;
            this.txtDescAvaliacao.Location = new System.Drawing.Point(4, 89);
            this.txtDescAvaliacao.Multiline = true;
            this.txtDescAvaliacao.Name = "txtDescAvaliacao";
            this.txtDescAvaliacao.Size = new System.Drawing.Size(219, 40);
            this.txtDescAvaliacao.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Comentário:";
            // 
            // btnAvaliarJogo
            // 
            this.btnAvaliarJogo.Location = new System.Drawing.Point(75, 135);
            this.btnAvaliarJogo.Name = "btnAvaliarJogo";
            this.btnAvaliarJogo.Size = new System.Drawing.Size(75, 23);
            this.btnAvaliarJogo.TabIndex = 7;
            this.btnAvaliarJogo.Text = "Avaliar";
            this.btnAvaliarJogo.UseVisualStyleBackColor = true;
            this.btnAvaliarJogo.Click += new System.EventHandler(this.btnAvaliarJogo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Novo Score:";
            // 
            // txtScoreDesejado
            // 
            this.txtScoreDesejado.Location = new System.Drawing.Point(7, 119);
            this.txtScoreDesejado.Name = "txtScoreDesejado";
            this.txtScoreDesejado.Size = new System.Drawing.Size(229, 20);
            this.txtScoreDesejado.TabIndex = 14;
            this.txtScoreDesejado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScoreDesejado_KeyPress);
            // 
            // btnAtualizarScoreJogo
            // 
            this.btnAtualizarScoreJogo.Location = new System.Drawing.Point(81, 145);
            this.btnAtualizarScoreJogo.Name = "btnAtualizarScoreJogo";
            this.btnAtualizarScoreJogo.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarScoreJogo.TabIndex = 13;
            this.btnAtualizarScoreJogo.Text = "Atualizar";
            this.btnAtualizarScoreJogo.UseVisualStyleBackColor = true;
            this.btnAtualizarScoreJogo.Click += new System.EventHandler(this.btnAtualizarScoreJogo_Click);
            // 
            // lblScoreAtual
            // 
            this.lblScoreAtual.AutoSize = true;
            this.lblScoreAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreAtual.ForeColor = System.Drawing.Color.Blue;
            this.lblScoreAtual.Location = new System.Drawing.Point(46, 73);
            this.lblScoreAtual.Name = "lblScoreAtual";
            this.lblScoreAtual.Size = new System.Drawing.Size(127, 24);
            this.lblScoreAtual.TabIndex = 12;
            this.lblScoreAtual.Text = "Score Atual: 0";
            this.lblScoreAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbxJogosDisponiveis
            // 
            this.cmbxJogosDisponiveis.FormattingEnabled = true;
            this.cmbxJogosDisponiveis.Location = new System.Drawing.Point(6, 37);
            this.cmbxJogosDisponiveis.Name = "cmbxJogosDisponiveis";
            this.cmbxJogosDisponiveis.Size = new System.Drawing.Size(229, 21);
            this.cmbxJogosDisponiveis.TabIndex = 11;
            this.cmbxJogosDisponiveis.DropDown += new System.EventHandler(this.cmbxJogosDisponiveis_DropDown);
            this.cmbxJogosDisponiveis.SelectedIndexChanged += new System.EventHandler(this.cmbxJogosDisponiveis_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Escolha o jogo:";
            // 
            // grpMeusJogos
            // 
            this.grpMeusJogos.Controls.Add(this.lblJogadoTantasVezes);
            this.grpMeusJogos.Controls.Add(this.lblMediaNota);
            this.grpMeusJogos.Controls.Add(this.groupBox2);
            this.grpMeusJogos.Controls.Add(this.cmbxPesquisaMeusJogos);
            this.grpMeusJogos.Controls.Add(this.label6);
            this.grpMeusJogos.Location = new System.Drawing.Point(259, 220);
            this.grpMeusJogos.Name = "grpMeusJogos";
            this.grpMeusJogos.Size = new System.Drawing.Size(247, 342);
            this.grpMeusJogos.TabIndex = 12;
            this.grpMeusJogos.TabStop = false;
            this.grpMeusJogos.Text = "Meus jogos";
            // 
            // lblMediaNota
            // 
            this.lblMediaNota.AutoSize = true;
            this.lblMediaNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaNota.ForeColor = System.Drawing.Color.Lime;
            this.lblMediaNota.Location = new System.Drawing.Point(60, 72);
            this.lblMediaNota.Name = "lblMediaNota";
            this.lblMediaNota.Size = new System.Drawing.Size(67, 24);
            this.lblMediaNota.TabIndex = 14;
            this.lblMediaNota.Text = "Média:";
            this.lblMediaNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDescAtualizacao);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNomeAtualizado);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnAtualizarJogo);
            this.groupBox2.Location = new System.Drawing.Point(12, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 182);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar Informações";
            // 
            // txtDescAtualizacao
            // 
            this.txtDescAtualizacao.AllowDrop = true;
            this.txtDescAtualizacao.Location = new System.Drawing.Point(12, 79);
            this.txtDescAtualizacao.Multiline = true;
            this.txtDescAtualizacao.Name = "txtDescAtualizacao";
            this.txtDescAtualizacao.Size = new System.Drawing.Size(211, 68);
            this.txtDescAtualizacao.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Descrição:";
            // 
            // txtNomeAtualizado
            // 
            this.txtNomeAtualizado.Location = new System.Drawing.Point(12, 39);
            this.txtNomeAtualizado.Name = "txtNomeAtualizado";
            this.txtNomeAtualizado.Size = new System.Drawing.Size(211, 20);
            this.txtNomeAtualizado.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nome Jogo:";
            // 
            // btnAtualizarJogo
            // 
            this.btnAtualizarJogo.Location = new System.Drawing.Point(85, 153);
            this.btnAtualizarJogo.Name = "btnAtualizarJogo";
            this.btnAtualizarJogo.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarJogo.TabIndex = 7;
            this.btnAtualizarJogo.Text = "Atualizar";
            this.btnAtualizarJogo.UseVisualStyleBackColor = true;
            this.btnAtualizarJogo.Click += new System.EventHandler(this.btnAtualizarJogo_Click);
            // 
            // cmbxPesquisaMeusJogos
            // 
            this.cmbxPesquisaMeusJogos.FormattingEnabled = true;
            this.cmbxPesquisaMeusJogos.Location = new System.Drawing.Point(12, 38);
            this.cmbxPesquisaMeusJogos.Name = "cmbxPesquisaMeusJogos";
            this.cmbxPesquisaMeusJogos.Size = new System.Drawing.Size(229, 21);
            this.cmbxPesquisaMeusJogos.TabIndex = 12;
            this.cmbxPesquisaMeusJogos.DropDown += new System.EventHandler(this.cmbxPesquisaMeusJogos_DropDown);
            this.cmbxPesquisaMeusJogos.SelectedIndexChanged += new System.EventHandler(this.cmbxPesquisaMeusJogos_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Meus Jogos:";
            // 
            // btnConfigPlayer
            // 
            this.btnConfigPlayer.Location = new System.Drawing.Point(12, 9);
            this.btnConfigPlayer.Name = "btnConfigPlayer";
            this.btnConfigPlayer.Size = new System.Drawing.Size(54, 23);
            this.btnConfigPlayer.TabIndex = 13;
            this.btnConfigPlayer.Text = "Config.";
            this.btnConfigPlayer.UseVisualStyleBackColor = true;
            this.btnConfigPlayer.Click += new System.EventHandler(this.btnConfigPlayer_Click);
            // 
            // lblJogadoTantasVezes
            // 
            this.lblJogadoTantasVezes.AutoSize = true;
            this.lblJogadoTantasVezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadoTantasVezes.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblJogadoTantasVezes.Location = new System.Drawing.Point(60, 111);
            this.lblJogadoTantasVezes.Name = "lblJogadoTantasVezes";
            this.lblJogadoTantasVezes.Size = new System.Drawing.Size(16, 24);
            this.lblJogadoTantasVezes.TabIndex = 15;
            this.lblJogadoTantasVezes.Text = "-";
            this.lblJogadoTantasVezes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 623);
            this.Controls.Add(this.btnConfigPlayer);
            this.Controls.Add(this.grpMeusJogos);
            this.Controls.Add(this.grbxHighScores);
            this.Controls.Add(this.btnVirarDev);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblMsgBemVindo);
            this.Controls.Add(this.grpDeveloper);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaUsuario";
            this.Load += new System.EventHandler(this.TelaUsuario_Load);
            this.grpDeveloper.ResumeLayout(false);
            this.grpDeveloper.PerformLayout();
            this.grbxHighScores.ResumeLayout(false);
            this.grbxHighScores.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpMeusJogos.ResumeLayout(false);
            this.grpMeusJogos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDeveloper;
        private System.Windows.Forms.Button btnCadastrarJogo;
        private System.Windows.Forms.TextBox txtNomeJogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescJogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMsgBemVindo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVirarDev;
        private System.Windows.Forms.GroupBox grbxHighScores;
        private System.Windows.Forms.TextBox txtScoreDesejado;
        private System.Windows.Forms.Button btnAtualizarScoreJogo;
        private System.Windows.Forms.Label lblScoreAtual;
        private System.Windows.Forms.ComboBox cmbxJogosDisponiveis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpMeusJogos;
        private System.Windows.Forms.Label lblMediaNota;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDescAtualizacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeAtualizado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAtualizarJogo;
        private System.Windows.Forms.ComboBox cmbxPesquisaMeusJogos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbxNota;
        private System.Windows.Forms.TextBox txtDescAvaliacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAvaliarJogo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnConfigPlayer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTodasAvaliacoes;
        private System.Windows.Forms.Button btnAtualizarDados;
        private System.Windows.Forms.Label lblJogadoTantasVezes;
    }
}