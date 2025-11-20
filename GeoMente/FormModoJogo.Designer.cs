namespace GeoMente
{
    partial class FormModoJogo
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
            this.btnPaises = new GeoMente.RoundedButton();
            this.btnCapitais = new GeoMente.RoundedButton();
            this.btnCuriosidades = new GeoMente.RoundedButton();
            this.panelDificuldade = new System.Windows.Forms.Panel();
            this.btnFacil = new GeoMente.RoundedButton();
            this.btnMedio = new GeoMente.RoundedButton();
            this.btnDificil = new GeoMente.RoundedButton();
            this.btnHardcore = new GeoMente.RoundedButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVoltarModos = new GeoMente.RoundedButton();
            this.btnVoltarDificuldade = new GeoMente.RoundedButton();
            this.panelDificuldade.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPaises
            // 
            this.btnPaises.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnPaises.BorderRadius = 25;
            this.btnPaises.FlatAppearance.BorderSize = 0;
            this.btnPaises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaises.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaises.ForeColor = System.Drawing.Color.White;
            this.btnPaises.Location = new System.Drawing.Point(200, 300);
            this.btnPaises.Name = "btnPaises";
            this.btnPaises.Size = new System.Drawing.Size(280, 80);
            this.btnPaises.TabIndex = 0;
            this.btnPaises.Text = "🌍 Adivinhar Países";
            this.btnPaises.UseVisualStyleBackColor = false;
            this.btnPaises.Click += new System.EventHandler(this.btnPaises_Click);
            // 
            // btnCapitais
            // 
            this.btnCapitais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnCapitais.BorderRadius = 25;
            this.btnCapitais.FlatAppearance.BorderSize = 0;
            this.btnCapitais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapitais.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapitais.ForeColor = System.Drawing.Color.White;
            this.btnCapitais.Location = new System.Drawing.Point(500, 300);
            this.btnCapitais.Name = "btnCapitais";
            this.btnCapitais.Size = new System.Drawing.Size(280, 80);
            this.btnCapitais.TabIndex = 1;
            this.btnCapitais.Text = "🏛️ Adivinhar Capitais";
            this.btnCapitais.UseVisualStyleBackColor = false;
            this.btnCapitais.Click += new System.EventHandler(this.btnCapitais_Click);
            // 
            // btnCuriosidades
            // 
            this.btnCuriosidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnCuriosidades.BorderRadius = 25;
            this.btnCuriosidades.FlatAppearance.BorderSize = 0;
            this.btnCuriosidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuriosidades.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuriosidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnCuriosidades.Location = new System.Drawing.Point(800, 300);
            this.btnCuriosidades.Name = "btnCuriosidades";
            this.btnCuriosidades.Size = new System.Drawing.Size(280, 80);
            this.btnCuriosidades.TabIndex = 2;
            this.btnCuriosidades.Text = "💡 Adivinhar Curiosidades";
            this.btnCuriosidades.UseVisualStyleBackColor = false;
            this.btnCuriosidades.Click += new System.EventHandler(this.btnCuriosidades_Click);
            // 
            // panelDificuldade
            // 
            this.panelDificuldade.Controls.Add(this.btnFacil);
            this.panelDificuldade.Controls.Add(this.btnMedio);
            this.panelDificuldade.Controls.Add(this.btnDificil);
            this.panelDificuldade.Controls.Add(this.btnHardcore);
            this.panelDificuldade.Location = new System.Drawing.Point(300, 400);
            this.panelDificuldade.Name = "panelDificuldade";
            this.panelDificuldade.Size = new System.Drawing.Size(680, 100);
            this.panelDificuldade.TabIndex = 3;
            this.panelDificuldade.Visible = false;
            // 
            // btnFacil
            // 
            this.btnFacil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnFacil.BorderRadius = 20;
            this.btnFacil.FlatAppearance.BorderSize = 0;
            this.btnFacil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacil.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacil.ForeColor = System.Drawing.Color.White;
            this.btnFacil.Location = new System.Drawing.Point(10, 10);
            this.btnFacil.Name = "btnFacil";
            this.btnFacil.Size = new System.Drawing.Size(150, 70);
            this.btnFacil.TabIndex = 0;
            this.btnFacil.Text = "😊 Fácil";
            this.btnFacil.UseVisualStyleBackColor = false;
            this.btnFacil.Click += new System.EventHandler(this.btnFacil_Click);
            // 
            // btnMedio
            // 
            this.btnMedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnMedio.BorderRadius = 20;
            this.btnMedio.FlatAppearance.BorderSize = 0;
            this.btnMedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedio.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnMedio.Location = new System.Drawing.Point(180, 10);
            this.btnMedio.Name = "btnMedio";
            this.btnMedio.Size = new System.Drawing.Size(150, 70);
            this.btnMedio.TabIndex = 1;
            this.btnMedio.Text = "😐 Médio";
            this.btnMedio.UseVisualStyleBackColor = false;
            this.btnMedio.Click += new System.EventHandler(this.btnMedio_Click);
            // 
            // btnDificil
            // 
            this.btnDificil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnDificil.BorderRadius = 20;
            this.btnDificil.FlatAppearance.BorderSize = 0;
            this.btnDificil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDificil.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDificil.ForeColor = System.Drawing.Color.White;
            this.btnDificil.Location = new System.Drawing.Point(350, 10);
            this.btnDificil.Name = "btnDificil";
            this.btnDificil.Size = new System.Drawing.Size(150, 70);
            this.btnDificil.TabIndex = 2;
            this.btnDificil.Text = "😰 Difícil";
            this.btnDificil.UseVisualStyleBackColor = false;
            this.btnDificil.Click += new System.EventHandler(this.btnDificil_Click);
            // 
            // btnHardcore
            // 
            this.btnHardcore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnHardcore.BorderRadius = 20;
            this.btnHardcore.FlatAppearance.BorderSize = 0;
            this.btnHardcore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHardcore.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHardcore.ForeColor = System.Drawing.Color.White;
            this.btnHardcore.Location = new System.Drawing.Point(520, 10);
            this.btnHardcore.Name = "btnHardcore";
            this.btnHardcore.Size = new System.Drawing.Size(150, 70);
            this.btnHardcore.TabIndex = 3;
            this.btnHardcore.Text = "💀 Hardcore";
            this.btnHardcore.UseVisualStyleBackColor = false;
            this.btnHardcore.Click += new System.EventHandler(this.btnHardcore_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 80);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1332, 70);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Escolha o Modo de Jogo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltarModos
            // 
            this.btnVoltarModos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltarModos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnVoltarModos.BorderRadius = 20;
            this.btnVoltarModos.FlatAppearance.BorderSize = 0;
            this.btnVoltarModos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarModos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarModos.ForeColor = System.Drawing.Color.White;
            this.btnVoltarModos.Location = new System.Drawing.Point(24, 650);
            this.btnVoltarModos.Margin = new System.Windows.Forms.Padding(8);
            this.btnVoltarModos.Name = "btnVoltarModos";
            this.btnVoltarModos.Size = new System.Drawing.Size(180, 58);
            this.btnVoltarModos.TabIndex = 5;
            this.btnVoltarModos.Text = "← Voltar";
            this.btnVoltarModos.UseVisualStyleBackColor = false;
            this.btnVoltarModos.Click += new System.EventHandler(this.btnVoltarModos_Click);
            // 
            // btnVoltarDificuldade
            // 
            this.btnVoltarDificuldade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltarDificuldade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnVoltarDificuldade.BorderRadius = 20;
            this.btnVoltarDificuldade.FlatAppearance.BorderSize = 0;
            this.btnVoltarDificuldade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarDificuldade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarDificuldade.ForeColor = System.Drawing.Color.White;
            this.btnVoltarDificuldade.Location = new System.Drawing.Point(24, 650);
            this.btnVoltarDificuldade.Margin = new System.Windows.Forms.Padding(8);
            this.btnVoltarDificuldade.Name = "btnVoltarDificuldade";
            this.btnVoltarDificuldade.Size = new System.Drawing.Size(180, 58);
            this.btnVoltarDificuldade.TabIndex = 6;
            this.btnVoltarDificuldade.Text = "← Voltar";
            this.btnVoltarDificuldade.UseVisualStyleBackColor = false;
            this.btnVoltarDificuldade.Visible = false;
            this.btnVoltarDificuldade.Click += new System.EventHandler(this.btnVoltarDificuldade_Click);
            // 
            // FormModoJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1356, 722);
            this.Controls.Add(this.btnVoltarDificuldade);
            this.Controls.Add(this.btnVoltarModos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelDificuldade);
            this.Controls.Add(this.btnCuriosidades);
            this.Controls.Add(this.btnCapitais);
            this.Controls.Add(this.btnPaises);
            this.Name = "FormModoJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeoMente - Modo de Jogo";
            this.Load += new System.EventHandler(this.FormModoJogo_Load);
            this.Resize += new System.EventHandler(this.FormModoJogo_Resize);
            this.panelDificuldade.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton btnPaises;
        private RoundedButton btnCapitais;
        private RoundedButton btnCuriosidades;
        private System.Windows.Forms.Panel panelDificuldade;
        private RoundedButton btnFacil;
        private RoundedButton btnMedio;
        private RoundedButton btnDificil;
        private RoundedButton btnHardcore;
        private System.Windows.Forms.Label lblTitulo;
        private RoundedButton btnVoltarModos;
        private RoundedButton btnVoltarDificuldade;
    }
}
