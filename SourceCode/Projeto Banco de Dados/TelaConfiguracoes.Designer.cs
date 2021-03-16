namespace Projeto_Banco_de_Dados
{
    partial class TelaConfiguracoes
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
            this.txtDate = new System.Windows.Forms.MonthCalendar();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbxSexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtualizarDados = new System.Windows.Forms.Button();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpAtualizarSenha = new System.Windows.Forms.GroupBox();
            this.btnAtualizarSenha = new System.Windows.Forms.Button();
            this.grpAtualizarSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(8, 271);
            this.txtDate.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.txtDate.MaxSelectionCount = 1;
            this.txtDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.TabIndex = 27;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(386, 444);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 23;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Data Nascimento";
            // 
            // cmbxSexo
            // 
            this.cmbxSexo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxSexo.FormattingEnabled = true;
            this.cmbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.cmbxSexo.Location = new System.Drawing.Point(8, 219);
            this.cmbxSexo.Name = "cmbxSexo";
            this.cmbxSexo.Size = new System.Drawing.Size(227, 21);
            this.cmbxSexo.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Sexo:";
            // 
            // txtDesc
            // 
            this.txtDesc.AllowDrop = true;
            this.txtDesc.Location = new System.Drawing.Point(8, 128);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(227, 60);
            this.txtDesc.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Descrição:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(6, 47);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(208, 20);
            this.txtSenha.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nova Senha:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(8, 76);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email:";
            // 
            // txtNomeUser
            // 
            this.txtNomeUser.Location = new System.Drawing.Point(8, 28);
            this.txtNomeUser.Name = "txtNomeUser";
            this.txtNomeUser.Size = new System.Drawing.Size(227, 20);
            this.txtNomeUser.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome Usuário:";
            // 
            // btnAtualizarDados
            // 
            this.btnAtualizarDados.Location = new System.Drawing.Point(55, 444);
            this.btnAtualizarDados.Name = "btnAtualizarDados";
            this.btnAtualizarDados.Size = new System.Drawing.Size(126, 23);
            this.btnAtualizarDados.TabIndex = 22;
            this.btnAtualizarDados.Text = "Atualizar Dados";
            this.btnAtualizarDados.UseVisualStyleBackColor = true;
            this.btnAtualizarDados.Click += new System.EventHandler(this.btnAtualizarDados_Click);
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(6, 95);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '*';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(208, 20);
            this.txtConfirmarSenha.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Confirmar Nova Senha:";
            // 
            // grpAtualizarSenha
            // 
            this.grpAtualizarSenha.Controls.Add(this.btnAtualizarSenha);
            this.grpAtualizarSenha.Controls.Add(this.txtConfirmarSenha);
            this.grpAtualizarSenha.Controls.Add(this.label3);
            this.grpAtualizarSenha.Controls.Add(this.label7);
            this.grpAtualizarSenha.Controls.Add(this.txtSenha);
            this.grpAtualizarSenha.Location = new System.Drawing.Point(247, 158);
            this.grpAtualizarSenha.Name = "grpAtualizarSenha";
            this.grpAtualizarSenha.Size = new System.Drawing.Size(220, 151);
            this.grpAtualizarSenha.TabIndex = 30;
            this.grpAtualizarSenha.TabStop = false;
            this.grpAtualizarSenha.Text = "Segurança";
            // 
            // btnAtualizarSenha
            // 
            this.btnAtualizarSenha.Location = new System.Drawing.Point(45, 121);
            this.btnAtualizarSenha.Name = "btnAtualizarSenha";
            this.btnAtualizarSenha.Size = new System.Drawing.Size(126, 23);
            this.btnAtualizarSenha.TabIndex = 30;
            this.btnAtualizarSenha.Text = "Atualizar Senha";
            this.btnAtualizarSenha.UseVisualStyleBackColor = true;
            this.btnAtualizarSenha.Click += new System.EventHandler(this.btnAtualizarSenha_Click);
            // 
            // TelaConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 479);
            this.Controls.Add(this.grpAtualizarSenha);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbxSexo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtualizarDados);
            this.Name = "TelaConfiguracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaConfiguracoes";
            this.Load += new System.EventHandler(this.TelaConfiguracoes_Load);
            this.grpAtualizarSenha.ResumeLayout(false);
            this.grpAtualizarSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar txtDate;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbxSexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtualizarDados;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpAtualizarSenha;
        private System.Windows.Forms.Button btnAtualizarSenha;
    }
}