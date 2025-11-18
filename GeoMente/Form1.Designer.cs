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
            this.btnAdivinhar = new GeoMente.RoundedButton();
            this.lblTentativas = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.btnNovoJogo = new GeoMente.RoundedButton();
            this.timerJogo = new System.Windows.Forms.Timer(this.components);
            this.lblLetrasErradas = new System.Windows.Forms.Label();
            this.lblMensagemFinal = new System.Windows.Forms.Label();
            this.btnJogarNovamente = new GeoMente.RoundedButton();
            this.btnVoltar = new GeoMente.RoundedButton();
            this.panelAdivinhar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBandeira)).BeginInit();
            this.panelAdivinhar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBandeira
            // 
            this.pictureBoxBandeira.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBandeira.Location = new System.Drawing.Point(16, 15);
            this.pictureBoxBandeira.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxBandeira.Name = "pictureBoxBandeira";
            this.pictureBoxBandeira.Size = new System.Drawing.Size(1324, 303);
            this.pictureBoxBandeira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBandeira.TabIndex = 0;
            this.pictureBoxBandeira.TabStop = false;
            // 
            // lblPalavraSecreta
            // 
            this.lblPalavraSecreta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPalavraSecreta.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavraSecreta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblPalavraSecreta.Location = new System.Drawing.Point(16, 350);
            this.lblPalavraSecreta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalavraSecreta.Name = "lblPalavraSecreta";
            this.lblPalavraSecreta.Size = new System.Drawing.Size(1324, 62);
            this.lblPalavraSecreta.TabIndex = 1;
            this.lblPalavraSecreta.Text = "_ _ _ _ _ _";
            this.lblPalavraSecreta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPalavraSecreta.Click += new System.EventHandler(this.lblPalavraSecreta_Click);
            // 
            // txtLetra
            // 
            this.txtLetra.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetra.Location = new System.Drawing.Point(4, 4);
            this.txtLetra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLetra.MaxLength = 1;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(65, 52);
            this.txtLetra.TabIndex = 2;
            this.txtLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdivinhar
            // 
            this.btnAdivinhar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdivinhar.BorderRadius = 15;
            this.btnAdivinhar.FlatAppearance.BorderSize = 0;
            this.btnAdivinhar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdivinhar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdivinhar.ForeColor = System.Drawing.Color.White;
            this.btnAdivinhar.Location = new System.Drawing.Point(79, 4);
            this.btnAdivinhar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdivinhar.Name = "btnAdivinhar";
            this.btnAdivinhar.Size = new System.Drawing.Size(133, 52);
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
            this.lblTentativas.Location = new System.Drawing.Point(11, 527);
            this.lblTentativas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTentativas.Name = "lblTentativas";
            this.lblTentativas.Size = new System.Drawing.Size(185, 28);
            this.lblTentativas.TabIndex = 4;
            this.lblTentativas.Text = "Tentativas restantes:";
            // 
            // lblTempo
            // 
            this.lblTempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblTempo.Location = new System.Drawing.Point(11, 564);
            this.lblTempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(150, 28);
            this.lblTempo.TabIndex = 5;
            this.lblTempo.Text = "Tempo restante:";
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblPontuacao.Location = new System.Drawing.Point(11, 601);
            this.lblPontuacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(108, 28);
            this.lblPontuacao.TabIndex = 6;
            this.lblPontuacao.Text = "Pontuação:";
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoJogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnNovoJogo.BorderRadius = 15;
            this.btnNovoJogo.FlatAppearance.BorderSize = 0;
            this.btnNovoJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoJogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoJogo.ForeColor = System.Drawing.Color.White;
            this.btnNovoJogo.Location = new System.Drawing.Point(1158, 650);
            this.btnNovoJogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(182, 58);
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
            this.lblLetrasErradas.Location = new System.Drawing.Point(11, 490);
            this.lblLetrasErradas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLetrasErradas.Name = "lblLetrasErradas";
            this.lblLetrasErradas.Size = new System.Drawing.Size(136, 28);
            this.lblLetrasErradas.TabIndex = 8;
            this.lblLetrasErradas.Text = "Letras erradas:";
            // 
            // lblMensagemFinal
            // 
            this.lblMensagemFinal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensagemFinal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagemFinal.Location = new System.Drawing.Point(16, 490);
            this.lblMensagemFinal.Name = "lblMensagemFinal";
            this.lblMensagemFinal.Size = new System.Drawing.Size(1324, 50);
            this.lblMensagemFinal.TabIndex = 9;
            this.lblMensagemFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensagemFinal.Visible = false;
            this.lblMensagemFinal.Click += new System.EventHandler(this.lblMensagemFinal_Click);
            // 
            // btnJogarNovamente
            // 
            this.btnJogarNovamente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJogarNovamente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnJogarNovamente.BorderRadius = 15;
            this.btnJogarNovamente.FlatAppearance.BorderSize = 0;
            this.btnJogarNovamente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogarNovamente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogarNovamente.ForeColor = System.Drawing.Color.White;
            this.btnJogarNovamente.Location = new System.Drawing.Point(537, 542);
            this.btnJogarNovamente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogarNovamente.Name = "btnJogarNovamente";
            this.btnJogarNovamente.Size = new System.Drawing.Size(277, 72);
            this.btnJogarNovamente.TabIndex = 10;
            this.btnJogarNovamente.Text = "Jogar Novamente";
            this.btnJogarNovamente.UseVisualStyleBackColor = false;
            this.btnJogarNovamente.Visible = false;
            this.btnJogarNovamente.Click += new System.EventHandler(this.btnJogarNovamente_Click_1);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnVoltar.BorderRadius = 15;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(16, 650);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(180, 58);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // panelAdivinhar
            // 
            this.panelAdivinhar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelAdivinhar.Controls.Add(this.txtLetra);
            this.panelAdivinhar.Controls.Add(this.btnAdivinhar);
            this.panelAdivinhar.Location = new System.Drawing.Point(565, 437);
            this.panelAdivinhar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAdivinhar.Name = "panelAdivinhar";
            this.panelAdivinhar.Size = new System.Drawing.Size(216, 62);
            this.panelAdivinhar.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1356, 722);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private GeoMente.RoundedButton btnAdivinhar;
        private System.Windows.Forms.Label lblTentativas;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblPontuacao;
        private GeoMente.RoundedButton btnNovoJogo;
        private System.Windows.Forms.Timer timerJogo;
        private System.Windows.Forms.Label lblLetrasErradas;
        private System.Windows.Forms.Label lblMensagemFinal;
        private GeoMente.RoundedButton btnJogarNovamente;
        private GeoMente.RoundedButton btnVoltar;
        private System.Windows.Forms.Panel panelAdivinhar;
    }
}
