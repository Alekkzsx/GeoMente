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
            this.flowPalavraSecreta = new System.Windows.Forms.FlowLayoutPanel();
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
            this.panelAdivinharPalavra = new System.Windows.Forms.Panel();
            this.txtPalavraCompleta = new System.Windows.Forms.TextBox();
            this.btnAdivinharPalavra = new GeoMente.RoundedButton();
            this.lblTentativasPalavra = new System.Windows.Forms.Label();
            this.btnDica = new GeoMente.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBandeira)).BeginInit();
            this.panelAdivinhar.SuspendLayout();
            this.panelAdivinharPalavra.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBandeira
            // 
            this.pictureBoxBandeira.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBandeira.BackColor = System.Drawing.Color.White;
            this.pictureBoxBandeira.Location = new System.Drawing.Point(24, 24);
            this.pictureBoxBandeira.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBoxBandeira.Name = "pictureBoxBandeira";
            this.pictureBoxBandeira.Size = new System.Drawing.Size(1308, 280);
            this.pictureBoxBandeira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBandeira.TabIndex = 0;
            this.pictureBoxBandeira.TabStop = false;
            // 
            // flowPalavraSecreta
            // 
            this.flowPalavraSecreta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPalavraSecreta.AutoSize = true;
            this.flowPalavraSecreta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowPalavraSecreta.BackColor = System.Drawing.Color.Transparent;
            this.flowPalavraSecreta.Location = new System.Drawing.Point(24, 328);
            this.flowPalavraSecreta.Margin = new System.Windows.Forms.Padding(8, 8, 8, 12);
            this.flowPalavraSecreta.Name = "flowPalavraSecreta";
            this.flowPalavraSecreta.Size = new System.Drawing.Size(1308, 62);
            this.flowPalavraSecreta.TabIndex = 1;
            this.flowPalavraSecreta.WrapContents = false;
            this.flowPalavraSecreta.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            // 
            // txtLetra
            // 
            this.txtLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLetra.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetra.Location = new System.Drawing.Point(8, 8);
            this.txtLetra.Margin = new System.Windows.Forms.Padding(4);
            this.txtLetra.MaxLength = 1;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(70, 52);
            this.txtLetra.TabIndex = 2;
            this.txtLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdivinhar
            // 
            this.btnAdivinhar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdivinhar.BorderRadius = 20;
            this.btnAdivinhar.FlatAppearance.BorderSize = 0;
            this.btnAdivinhar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdivinhar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdivinhar.ForeColor = System.Drawing.Color.White;
            this.btnAdivinhar.Location = new System.Drawing.Point(86, 8);
            this.btnAdivinhar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdivinhar.Name = "btnAdivinhar";
            this.btnAdivinhar.Size = new System.Drawing.Size(150, 52);
            this.btnAdivinhar.TabIndex = 3;
            this.btnAdivinhar.Text = "✓ Confirmar";
            this.btnAdivinhar.UseVisualStyleBackColor = false;
            // 
            // lblTentativas
            // 
            this.lblTentativas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTentativas.AutoSize = true;
            this.lblTentativas.BackColor = System.Drawing.Color.Transparent;
            this.lblTentativas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTentativas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTentativas.Location = new System.Drawing.Point(28, 540);
            this.lblTentativas.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.lblTentativas.Name = "lblTentativas";
            this.lblTentativas.Size = new System.Drawing.Size(185, 25);
            this.lblTentativas.TabIndex = 4;
            this.lblTentativas.Text = "Tentativas restantes:";
            // 
            // lblTempo
            // 
            this.lblTempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTempo.AutoSize = true;
            this.lblTempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTempo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTempo.Location = new System.Drawing.Point(28, 573);
            this.lblTempo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(150, 25);
            this.lblTempo.TabIndex = 5;
            this.lblTempo.Text = "Tempo restante:";
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.BackColor = System.Drawing.Color.Transparent;
            this.lblPontuacao.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblPontuacao.Location = new System.Drawing.Point(28, 606);
            this.lblPontuacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(108, 25);
            this.lblPontuacao.TabIndex = 6;
            this.lblPontuacao.Text = "Pontuação:";
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoJogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnNovoJogo.BorderRadius = 20;
            this.btnNovoJogo.FlatAppearance.BorderSize = 0;
            this.btnNovoJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoJogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoJogo.ForeColor = System.Drawing.Color.White;
            this.btnNovoJogo.Location = new System.Drawing.Point(1142, 650);
            this.btnNovoJogo.Margin = new System.Windows.Forms.Padding(8);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(190, 58);
            this.btnNovoJogo.TabIndex = 7;
            this.btnNovoJogo.Text = "🎮 Novo Jogo";
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
            this.lblLetrasErradas.BackColor = System.Drawing.Color.Transparent;
            this.lblLetrasErradas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetrasErradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblLetrasErradas.Location = new System.Drawing.Point(28, 507);
            this.lblLetrasErradas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.lblLetrasErradas.Name = "lblLetrasErradas";
            this.lblLetrasErradas.Size = new System.Drawing.Size(136, 25);
            this.lblLetrasErradas.TabIndex = 8;
            this.lblLetrasErradas.Text = "Letras erradas:";
            // 
            // lblMensagemFinal
            // 
            this.lblMensagemFinal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensagemFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagemFinal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagemFinal.Location = new System.Drawing.Point(24, 480);
            this.lblMensagemFinal.Name = "lblMensagemFinal";
            this.lblMensagemFinal.Size = new System.Drawing.Size(1308, 60);
            this.lblMensagemFinal.TabIndex = 9;
            this.lblMensagemFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensagemFinal.Visible = false;
            // 
            // btnJogarNovamente
            // 
            this.btnJogarNovamente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnJogarNovamente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnJogarNovamente.BorderRadius = 25;
            this.btnJogarNovamente.FlatAppearance.BorderSize = 0;
            this.btnJogarNovamente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogarNovamente.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogarNovamente.ForeColor = System.Drawing.Color.White;
            this.btnJogarNovamente.Location = new System.Drawing.Point(540, 555);
            this.btnJogarNovamente.Margin = new System.Windows.Forms.Padding(8);
            this.btnJogarNovamente.Name = "btnJogarNovamente";
            this.btnJogarNovamente.Size = new System.Drawing.Size(280, 75);
            this.btnJogarNovamente.TabIndex = 10;
            this.btnJogarNovamente.Text = "🔄 Jogar Novamente";
            this.btnJogarNovamente.UseVisualStyleBackColor = false;
            this.btnJogarNovamente.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnVoltar.BorderRadius = 20;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(24, 650);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(8);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(180, 58);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "← Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // panelAdivinhar
            // 
            this.panelAdivinhar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelAdivinhar.BackColor = System.Drawing.Color.White;
            this.panelAdivinhar.Controls.Add(this.txtLetra);
            this.panelAdivinhar.Controls.Add(this.btnAdivinhar);
            this.panelAdivinhar.Location = new System.Drawing.Point(565, 415);
            this.panelAdivinhar.Margin = new System.Windows.Forms.Padding(8);
            this.panelAdivinhar.Name = "panelAdivinhar";
            this.panelAdivinhar.Size = new System.Drawing.Size(250, 70);
            this.panelAdivinhar.TabIndex = 12;
            // 
            // panelAdivinharPalavra
            // 
            this.panelAdivinharPalavra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelAdivinharPalavra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(240)))));
            this.panelAdivinharPalavra.Controls.Add(this.txtPalavraCompleta);
            this.panelAdivinharPalavra.Controls.Add(this.btnAdivinharPalavra);
            this.panelAdivinharPalavra.Controls.Add(this.lblTentativasPalavra);
            this.panelAdivinharPalavra.Location = new System.Drawing.Point(380, 500);
            this.panelAdivinharPalavra.Name = "panelAdivinharPalavra";
            this.panelAdivinharPalavra.Padding = new System.Windows.Forms.Padding(12);
            this.panelAdivinharPalavra.Size = new System.Drawing.Size(590, 110);
            this.panelAdivinharPalavra.TabIndex = 13;
            // 
            // txtPalavraCompleta
            // 
            this.txtPalavraCompleta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPalavraCompleta.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavraCompleta.Location = new System.Drawing.Point(12, 12);
            this.txtPalavraCompleta.Name = "txtPalavraCompleta";
            this.txtPalavraCompleta.Size = new System.Drawing.Size(370, 36);
            this.txtPalavraCompleta.TabIndex = 0;
            // 
            // btnAdivinharPalavra
            // 
            this.btnAdivinharPalavra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnAdivinharPalavra.BorderRadius = 18;
            this.btnAdivinharPalavra.FlatAppearance.BorderSize = 0;
            this.btnAdivinharPalavra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdivinharPalavra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdivinharPalavra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnAdivinharPalavra.Location = new System.Drawing.Point(390, 12);
            this.btnAdivinharPalavra.Name = "btnAdivinharPalavra";
            this.btnAdivinharPalavra.Size = new System.Drawing.Size(188, 36);
            this.btnAdivinharPalavra.TabIndex = 1;
            this.btnAdivinharPalavra.Text = "⚡ Arriscar Tudo";
            this.btnAdivinharPalavra.UseVisualStyleBackColor = false;
            // 
            // lblTentativasPalavra
            // 
            this.lblTentativasPalavra.AutoSize = true;
            this.lblTentativasPalavra.BackColor = System.Drawing.Color.Transparent;
            this.lblTentativasPalavra.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTentativasPalavra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTentativasPalavra.Location = new System.Drawing.Point(12, 56);
            this.lblTentativasPalavra.Name = "lblTentativasPalavra";
            this.lblTentativasPalavra.Size = new System.Drawing.Size(280, 21);
            this.lblTentativasPalavra.TabIndex = 2;
            this.lblTentativasPalavra.Text = "Tentativas de palavra completa restantes: 3";
            //
            // btnDica
            //
            this.btnDica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnDica.BorderRadius = 20;
            this.btnDica.FlatAppearance.BorderSize = 0;
            this.btnDica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDica.ForeColor = System.Drawing.Color.White;
            this.btnDica.Location = new System.Drawing.Point(944, 650);
            this.btnDica.Margin = new System.Windows.Forms.Padding(8);
            this.btnDica.Name = "btnDica";
            this.btnDica.Size = new System.Drawing.Size(190, 58);
            this.btnDica.TabIndex = 14;
            this.btnDica.Text = "💡 Dica";
            this.btnDica.UseVisualStyleBackColor = false;
            this.btnDica.Visible = false;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1356, 722);
            this.Controls.Add(this.btnDica);
            this.Controls.Add(this.lblLetrasErradas);
            this.Controls.Add(this.btnNovoJogo);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblTentativas);
            this.Controls.Add(this.flowPalavraSecreta);
            this.Controls.Add(this.pictureBoxBandeira);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panelAdivinhar);
            this.Controls.Add(this.panelAdivinharPalavra);
            this.Controls.Add(this.btnJogarNovamente);
            this.Controls.Add(this.lblMensagemFinal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "GeoMente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBandeira)).EndInit();
            this.panelAdivinhar.ResumeLayout(false);
            this.panelAdivinhar.PerformLayout();
            this.panelAdivinharPalavra.ResumeLayout(false);
            this.panelAdivinharPalavra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBandeira;
        private System.Windows.Forms.FlowLayoutPanel flowPalavraSecreta;
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
        private System.Windows.Forms.Panel panelAdivinharPalavra;
        private System.Windows.Forms.TextBox txtPalavraCompleta;
        private GeoMente.RoundedButton btnAdivinharPalavra;
        private System.Windows.Forms.Label lblTentativasPalavra;
        private RoundedButton btnDica;
    }
}
