namespace GeoMente
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxBandeira = new System.Windows.Forms.PictureBox();
            this.lblPalavraSecreta = new System.Windows.Forms.Label();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.btnAdivinhar = new System.Windows.Forms.Button();
            this.lblTentativas = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.timerJogo = new System.Windows.Forms.Timer(this.components);
            this.lblLetrasErradas = new System.Windows.Forms.Label();
            this.lblMensagemFinal = new System.Windows.Forms.Label();
            this.btnJogarNovamente = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelAdivinhar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBandeira)).BeginInit();
            this.panelAdivinhar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBandeira
            // 
            this.pictureBoxBandeira.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBandeira.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBandeira.Name = "pictureBoxBandeira";
            this.pictureBoxBandeira.Size = new System.Drawing.Size(993, 246);
            this.pictureBoxBandeira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBandeira.TabIndex = 0;
            this.pictureBoxBandeira.TabStop = false;
            // 
            // lblPalavraSecreta
            // 
            this.lblPalavraSecreta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPalavraSecreta.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavraSecreta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblPalavraSecreta.Location = new System.Drawing.Point(12, 284);
            this.lblPalavraSecreta.Name = "lblPalavraSecreta";
            this.lblPalavraSecreta.Size = new System.Drawing.Size(993, 50);
            this.lblPalavraSecreta.TabIndex = 1;
            this.lblPalavraSecreta.Text = "_ _ _ _ _ _";
            this.lblPalavraSecreta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLetra
            // 
            this.txtLetra.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetra.Location = new System.Drawing.Point(3, 3);
            this.txtLetra.MaxLength = 1;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(50, 43);
            this.txtLetra.TabIndex = 2;
            this.txtLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdivinhar
            // 
            this.btnAdivinhar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdivinhar.FlatAppearance.BorderSize = 0;
            this.btnAdivinhar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdivinhar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdivinhar.ForeColor = System.Drawing.Color.White;
            this.btnAdivinhar.Location = new System.Drawing.Point(59, 3);
            this.btnAdivinhar.Name = "btnAdivinhar";
            this.btnAdivinhar.Size = new System.Drawing.Size(100, 42);
            this.btnAdivinhar.TabIndex = 3;
            this.btnAdivinhar.Text = "Adivinhar";
            this.btnAdivinhar.UseVisualStyleBackColor = false;
            // 
            // lblTentativas
            // 
            this.lblTentativas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTentativas.AutoSize = true;
            this.lblTentativas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTentativas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblTentativas.Location = new System.Drawing.Point(8, 499);
            this.lblTentativas.Name = "lblTentativas";
            this.lblTentativas.Size = new System.Drawing.Size(158, 21);
            this.lblTentativas.TabIndex = 4;
            this.lblTentativas.Text = "Tentativas restantes:";
            // 
            // lblTempo
            // 
            this.lblTempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblTempo.Location = new System.Drawing.Point(8, 529);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(125, 21);
            this.lblTempo.TabIndex = 5;
            this.lblTempo.Text = "Tempo restante:";
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblPontuacao.Location = new System.Drawing.Point(8, 559);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(89, 21);
            this.lblPontuacao.TabIndex = 6;
            this.lblPontuacao.Text = "Pontuação:";
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoJogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnNovoJogo.FlatAppearance.BorderSize = 0;
            this.btnNovoJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoJogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoJogo.ForeColor = System.Drawing.Color.White;
            this.btnNovoJogo.Location = new System.Drawing.Point(885, 528);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(120, 47);
            this.btnNovoJogo.TabIndex = 7;
            this.btnNovoJogo.Text = "Novo Jogo";
            this.btnNovoJogo.UseVisualStyleBackColor = false;
            // 
            // timerJogo
            // 
            this.timerJogo.Interval = 1000;
            // 
            // lblLetrasErradas
            // 
            this.lblLetrasErradas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLetrasErradas.AutoSize = true;
            this.lblLetrasErradas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetrasErradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblLetrasErradas.Location = new System.Drawing.Point(8, 469);
            this.lblLetrasErradas.Name = "lblLetrasErradas";
            this.lblLetrasErradas.Size = new System.Drawing.Size(114, 21);
            this.lblLetrasErradas.TabIndex = 8;
            this.lblLetrasErradas.Text = "Letras erradas:";
            // 
            // lblMensagemFinal
            // 
            this.lblMensagemFinal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensagemFinal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagemFinal.Location = new System.Drawing.Point(12, 398);
            this.lblMensagemFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensagemFinal.Name = "lblMensagemFinal";
            this.lblMensagemFinal.Size = new System.Drawing.Size(993, 41);
            this.lblMensagemFinal.TabIndex = 9;
            this.lblMensagemFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensagemFinal.Visible = false;
            // 
            // btnJogarNovamente
            // 
            this.btnJogarNovamente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJogarNovamente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnJogarNovamente.FlatAppearance.BorderSize = 0;
            this.btnJogarNovamente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogarNovamente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogarNovamente.ForeColor = System.Drawing.Color.White;
            this.btnJogarNovamente.Location = new System.Drawing.Point(431, 447);
            this.btnJogarNovamente.Margin = new System.Windows.Forms.Padding(2);
            this.btnJogarNovamente.Name = "btnJogarNovamente";
            this.btnJogarNovamente.Size = new System.Drawing.Size(150, 49);
            this.btnJogarNovamente.TabIndex = 10;
            this.btnJogarNovamente.Text = "Jogar Novamente";
            this.btnJogarNovamente.UseVisualStyleBackColor = false;
            this.btnJogarNovamente.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(12, 528);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(120, 47);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // panelAdivinhar
            // 
            this.panelAdivinhar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelAdivinhar.Controls.Add(this.txtLetra);
            this.panelAdivinhar.Controls.Add(this.btnAdivinhar);
            this.panelAdivinhar.Location = new System.Drawing.Point(424, 355);
            this.panelAdivinhar.Name = "panelAdivinhar";
            this.panelAdivinhar.Size = new System.Drawing.Size(162, 50);
            this.panelAdivinhar.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1017, 587);
            this.Controls.Add(this.panelAdivinhar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnJogarNovamente);
            this.Controls.Add(this.lblMensagemFinal);
            this.Controls.Add(this.lblLetrasErradas);
            this.Controls.Add(this.btnNovoJogo);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblTentativas);
            this.Controls.Add(this.lblPalavraSecreta);
            this.Controls.Add(this.pictureBoxBandeira);
            this.Name = "Form1";
            this.Text = "GeoMente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBandeira)).EndInit();
            this.panelAdivinhar.ResumeLayout(false);
            this.panelAdivinhar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBandeira;
        private System.Windows.Forms.Label lblPalavraSecreta;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Button btnAdivinhar;
        private System.Windows.Forms.Label lblTentativas;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.Button btnNovoJogo;
        private System.Windows.Forms.Timer timerJogo;
        private System.Windows.Forms.Label lblLetrasErradas;
        private System.Windows.Forms.Label lblMensagemFinal;
        private System.Windows.Forms.Button btnJogarNovamente;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panelAdivinhar;
    }
}
