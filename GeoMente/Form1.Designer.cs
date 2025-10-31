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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBandeira)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBandeira
            // 
            this.pictureBoxBandeira.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxBandeira.Location = new System.Drawing.Point(16, 15);
            this.pictureBoxBandeira.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxBandeira.Name = "pictureBoxBandeira";
            this.pictureBoxBandeira.Size = new System.Drawing.Size(1324, 303);
            this.pictureBoxBandeira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBandeira.TabIndex = 0;
            this.pictureBoxBandeira.TabStop = false;
            this.pictureBoxBandeira.Click += new System.EventHandler(this.pictureBoxBandeira_Click);
            // 
            // lblPalavraSecreta
            // 
            this.lblPalavraSecreta.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavraSecreta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblPalavraSecreta.Location = new System.Drawing.Point(16, 350);
            this.lblPalavraSecreta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalavraSecreta.Name = "lblPalavraSecreta";
            this.lblPalavraSecreta.Size = new System.Drawing.Size(1324, 62);
            this.lblPalavraSecreta.TabIndex = 1;
            this.lblPalavraSecreta.Text = "_ _ _ _ _ _";
            this.lblPalavraSecreta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLetra
            // 
            this.txtLetra.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetra.Location = new System.Drawing.Point(569, 441);
            this.txtLetra.Margin = new System.Windows.Forms.Padding(4);
            this.txtLetra.MaxLength = 1;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(65, 52);
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
            this.btnAdivinhar.Location = new System.Drawing.Point(657, 441);
            this.btnAdivinhar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdivinhar.Name = "btnAdivinhar";
            this.btnAdivinhar.Size = new System.Drawing.Size(133, 52);
            this.btnAdivinhar.TabIndex = 3;
            this.btnAdivinhar.Text = "Adivinhar";
            this.btnAdivinhar.UseVisualStyleBackColor = false;
            // 
            // lblTentativas
            // 
            this.lblTentativas.AutoSize = true;
            this.lblTentativas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTentativas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblTentativas.Location = new System.Drawing.Point(32, 591);
            this.lblTentativas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTentativas.Name = "lblTentativas";
            this.lblTentativas.Size = new System.Drawing.Size(194, 28);
            this.lblTentativas.TabIndex = 4;
            this.lblTentativas.Text = "Tentativas restantes:";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblTempo.Location = new System.Drawing.Point(32, 628);
            this.lblTempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(155, 28);
            this.lblTempo.TabIndex = 5;
            this.lblTempo.Text = "Tempo restante:";
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblPontuacao.Location = new System.Drawing.Point(32, 665);
            this.lblPontuacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(112, 28);
            this.lblPontuacao.TabIndex = 6;
            this.lblPontuacao.Text = "Pontuação:";
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnNovoJogo.FlatAppearance.BorderSize = 0;
            this.btnNovoJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoJogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoJogo.ForeColor = System.Drawing.Color.White;
            this.btnNovoJogo.Location = new System.Drawing.Point(1180, 650);
            this.btnNovoJogo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(160, 58);
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
            this.lblLetrasErradas.AutoSize = true;
            this.lblLetrasErradas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetrasErradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblLetrasErradas.Location = new System.Drawing.Point(32, 554);
            this.lblLetrasErradas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLetrasErradas.Name = "lblLetrasErradas";
            this.lblLetrasErradas.Size = new System.Drawing.Size(143, 28);
            this.lblLetrasErradas.TabIndex = 8;
            this.lblLetrasErradas.Text = "Letras erradas:";
            // 
            // lblMensagemFinal
            // 
            this.lblMensagemFinal = new System.Windows.Forms.Label();
            this.lblMensagemFinal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagemFinal.Location = new System.Drawing.Point(16, 490);
            this.lblMensagemFinal.Name = "lblMensagemFinal";
            this.lblMensagemFinal.Size = new System.Drawing.Size(1324, 50);
            this.lblMensagemFinal.TabIndex = 9;
            this.lblMensagemFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensagemFinal.Visible = false;
            // 
            // btnJogarNovamente
            // 
            this.btnJogarNovamente = new System.Windows.Forms.Button();
            this.btnJogarNovamente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnJogarNovamente.FlatAppearance.BorderSize = 0;
            this.btnJogarNovamente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogarNovamente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogarNovamente.ForeColor = System.Drawing.Color.White;
            this.btnJogarNovamente.Location = new System.Drawing.Point(575, 550);
            this.btnJogarNovamente.Name = "btnJogarNovamente";
            this.btnJogarNovamente.Size = new System.Drawing.Size(200, 60);
            this.btnJogarNovamente.TabIndex = 10;
            this.btnJogarNovamente.Text = "Jogar Novamente";
            this.btnJogarNovamente.UseVisualStyleBackColor = false;
            this.btnJogarNovamente.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1356, 722);
            this.Controls.Add(this.btnJogarNovamente);
            this.Controls.Add(this.lblMensagemFinal);
            this.Controls.Add(this.lblLetrasErradas);
            this.Controls.Add(this.btnNovoJogo);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblTentativas);
            this.Controls.Add(this.btnAdivinhar);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.lblPalavraSecreta);
            this.Controls.Add(this.pictureBoxBandeira);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "GeoMente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBandeira)).EndInit();
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
    }
}
