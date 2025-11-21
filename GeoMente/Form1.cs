using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoMente
{
    public partial class Form1 : Form
    {
        private readonly string exeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private GerenciadorJogo jogo;
        private float anguloAtual = 0;
        private Image imagemBandeiraOriginal;
        private Form formAnterior;
        private string modoJogo;
        private string dificuldade;

        public Form1(Form formAnterior, string modo = "Países", string dificuldade = "Fácil")
        {
            InitializeComponent();
            this.formAnterior = formAnterior;
            this.modoJogo = modo;
            this.dificuldade = dificuldade;

            // Habilita Double Buffering para suavizar a animação
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);

            // Adicionando os event handlers
            btnNovoJogo.Click += new EventHandler(btnNovoJogo_Click);
            btnAdivinhar.Click += new EventHandler(btnAdivinhar_Click);
            btnAdivinharPalavra.Click += new EventHandler(btnAdivinharPalavra_Click);
            timerJogo.Tick += new EventHandler(timerJogo_Tick);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            pictureBoxBandeira.Paint += new PaintEventHandler(pictureBoxBandeira_Paint);
            btnVoltar.Click += new EventHandler(btnVoltar_Click);
            btnDica.Click += new EventHandler(btnDica_Click);
            this.Resize += new System.EventHandler(this.Form1_Resize);

            // Cria a instância do gerenciador de jogo
            jogo = new GerenciadorJogo(modoJogo);

            // Inscreve-se no evento Load para iniciar o jogo quando a janela estiver pronta
            this.Load += new EventHandler(Form1_Load);
            
            ConfigurarTema();
        }

        private void ConfigurarTema()
        {
            this.BackColor = Theme.Background;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = $"GeoMente - {modoJogo} ({dificuldade})";

            // Estiliza Labels
            EstilizarLabel(lblTentativas, Theme.Text);
            EstilizarLabel(lblTempo, Theme.Text);
            EstilizarLabel(lblPontuacao, Theme.Text);
            EstilizarLabel(lblLetrasErradas, Theme.Error);
            EstilizarLabel(lblTentativasPalavra, Theme.TextSecondary);
            
            // Estiliza Botões
            EstilizarBotao(btnAdivinhar, Theme.Primary, Color.White);
            EstilizarBotao(btnAdivinharPalavra, Theme.Warning, Color.White);
            EstilizarBotao(btnNovoJogo, Theme.Success, Color.White);
            EstilizarBotao(btnVoltar, Theme.TextSecondary, Color.White);
            EstilizarBotao(btnDica, Theme.Info, Color.White);

            // Estiliza Panels com fundo sutil
            panelAdivinhar.BackColor = Theme.Surface;
            panelAdivinharPalavra.BackColor = ColorTranslator.FromHtml("#FEF3C7"); // Amarelo muito claro
            
            // Ajusta PictureBox
            pictureBoxBandeira.BackColor = Theme.Surface;
        }

        private void EstilizarLabel(Label lbl, Color color)
        {
            lbl.ForeColor = color;
            lbl.Font = Theme.GetTextFont(12);
        }

        private void EstilizarBotao(Button btn, Color corFundo, Color corTexto)
        {
            if (btn is RoundedButton rb)
            {
                rb.BackColor = corFundo;
                rb.ForeColor = corTexto;
                rb.BorderRadius = 15;
                rb.Font = Theme.GetButtonFont(12);
            }
            else
            {
                btn.BackColor = corFundo;
                btn.ForeColor = corTexto;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Centraliza o painel de adivinhação
            panelAdivinhar.Left = (this.ClientSize.Width - panelAdivinhar.Width) / 2;
            
            // Centraliza o painel de adivinhação de palavra completa
            panelAdivinharPalavra.Left = (this.ClientSize.Width - panelAdivinharPalavra.Width) / 2;
            panelAdivinharPalavra.Top = panelAdivinhar.Bottom + 20; // Position below the letter guess panel

            // Centraliza a mensagem final
            lblMensagemFinal.Left = (this.ClientSize.Width - lblMensagemFinal.Width) / 2;

            // Centraliza o FlowLayoutPanel da palavra secreta
            if (flowPalavraSecreta != null)
            {
                 flowPalavraSecreta.Left = (this.ClientSize.Width - flowPalavraSecreta.Width) / 2;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicia o jogo assim que o formulário é carregado e o handle criado
            IniciarNovoJogo();
            // Garante a centralização inicial
            Form1_Resize(null, null);
        }

        private void IniciarNovoJogo()
        {
            // Passa a dificuldade selecionada para o gerenciador
            jogo.IniciarNovoJogo(dificuldade);

            // Prepara a animação da bandeira
            anguloAtual = 0;
            CarregarImagemBandeira();

            // Atualiza a interface com o novo estado do jogo
            AtualizarPalavraExibida();
            AtualizarInterface();

            // Habilita controles e inicia o timer
            txtLetra.Enabled = true;
            btnAdivinhar.Enabled = true;
            txtPalavraCompleta.Enabled = true;
            btnAdivinharPalavra.Enabled = true;
            txtPalavraCompleta.Clear();
            timerJogo.Start();

            // Limpa a mensagem de fim de jogo
            lblMensagemFinal.Visible = false;

            // Mostra o botão de dica apenas no modo Curiosidades
            btnDica.Visible = (modoJogo == "Curiosidades");
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            IniciarNovoJogo();
        }

        private void AtualizarPalavraExibida()
        {
            if (jogo.PalavraExibida == null) return;

            // Se o número de controles não bater (ex: novo jogo), recria
            if (flowPalavraSecreta.Controls.Count != jogo.PalavraExibida.Length)
            {
                flowPalavraSecreta.Controls.Clear();
                for (int i = 0; i < jogo.PalavraExibida.Length; i++)
                {
                    Label lblLetra = new Label();
                    lblLetra.AutoSize = false;
                    lblLetra.Size = new Size(50, 60); // Tamanho fixo para cada "slot"
                    lblLetra.Font = new Font("Courier New", 32F, FontStyle.Bold);
                    lblLetra.TextAlign = ContentAlignment.MiddleCenter;
                    lblLetra.ForeColor = Theme.Text;
                    lblLetra.BackColor = Theme.Surface; // Fundo estilo "Card"
                    lblLetra.Margin = new Padding(5);
                    
                    // Arredonda as bordas do label (simples)
                    // Para fazer isso direito precisaria de um controle customizado, mas vamos usar Paint event
                    lblLetra.Paint += (s, e) =>
                    {
                        // Desenha borda arredondada
                        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        using (Pen p = new Pen(Theme.Primary, 2))
                        {
                            Rectangle r = new Rectangle(1, 1, lblLetra.Width - 2, lblLetra.Height - 2);
                            // e.Graphics.DrawRectangle(p, r); // Borda simples
                        }
                    };
                    
                    flowPalavraSecreta.Controls.Add(lblLetra);
                }
                
                // Centraliza o FlowLayoutPanel após adicionar os controles
                // Pequeno delay para garantir que o layout foi calculado
                if (this.IsHandleCreated)
                {
                    this.BeginInvoke(new Action(() => {
                         flowPalavraSecreta.Left = (this.ClientSize.Width - flowPalavraSecreta.Width) / 2;
                    }));
                }
                else
                {
                    // Se o handle ainda não foi criado, centraliza diretamente
                    flowPalavraSecreta.Left = (this.ClientSize.Width - flowPalavraSecreta.Width) / 2;
                }
            }

            // Atualiza o texto de cada label
            for (int i = 0; i < jogo.PalavraExibida.Length; i++)
            {
                if (flowPalavraSecreta.Controls[i] is Label lbl)
                {
                    char letra = jogo.PalavraExibida[i];
                    // Se for espaço, não mostra nada (ou mostra espaço), se for _, mostra vazio
                    // Se for letra, mostra a letra
                    if (letra == '_')
                    {
                        lbl.Text = "";
                    }
                    else
                    {
                        lbl.Text = letra.ToString();
                    }
                }
            }
        }

        private void AtualizarInterface()
        {
            lblTentativas.Text = "Tentativas: " + jogo.TentativasRestantes;
            lblTempo.Text = "Tempo: " + jogo.TempoRestante + "s";
            lblPontuacao.Text = "Pontuação: " + jogo.Pontuacao;
            lblLetrasErradas.Text = "Erros: " + string.Join(", ", jogo.LetrasErradas);
            lblTentativasPalavra.Text = $"Chances Palavra: {jogo.TentativasPalavraCompleta}";
            
            // Muda cor do tempo se estiver acabando
            if (jogo.TempoRestante <= 10) lblTempo.ForeColor = Theme.Error;
            else lblTempo.ForeColor = Theme.Text;
        }

        private void btnAdivinhar_Click(object sender, EventArgs e)
        {
            if (!jogo.JogoEmAndamento || string.IsNullOrEmpty(txtLetra.Text))
            {
                FormMessageBox.Show("Por favor, inicie um novo jogo e digite uma letra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!char.IsLetter(txtLetra.Text[0]))
            {
                FormMessageBox.Show("Por favor, digite uma letra válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLetra.Clear();
                return;
            }

            char letra = txtLetra.Text.ToUpper()[0];
            jogo.AdivinharLetra(letra);

            AtualizarPalavraExibida();
            AtualizarInterface();

            if (!jogo.JogoEmAndamento)
            {
                FimDeJogo();
            }

            txtLetra.Clear();
            txtLetra.Focus();
        }

        private void btnAdivinharPalavra_Click(object sender, EventArgs e)
        {
            if (!jogo.JogoEmAndamento || string.IsNullOrWhiteSpace(txtPalavraCompleta.Text))
            {
                FormMessageBox.Show("Por favor, digite uma palavra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string palavra = txtPalavraCompleta.Text;
            int tentativasAntes = jogo.TentativasPalavraCompleta;
            jogo.AdivinharPalavraCompleta(palavra);

            AtualizarPalavraExibida();
            AtualizarInterface();

            if (!jogo.JogoEmAndamento)
            {
                FimDeJogo();
            }
            else if (jogo.TentativasPalavraCompleta < tentativasAntes)
            {
                FormMessageBox.Show($"Palavra incorreta! Você perdeu uma tentativa de palavra completa. Restam {jogo.TentativasPalavraCompleta}.", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPalavraCompleta.Clear();
                txtPalavraCompleta.Focus();
            }
        }

        private void FimDeJogo()
        {
            timerJogo.Stop();
            txtLetra.Enabled = false;
            btnAdivinhar.Enabled = false;
            txtPalavraCompleta.Enabled = false;
            btnAdivinharPalavra.Enabled = false;

            if (jogo.Vitoria)
            {
                AtualizarInterface(); // Atualiza a pontuação com o bônus
                lblMensagemFinal.Text = "Parabéns! Você acertou a palavra! Pontuação final: " + jogo.Pontuacao;
                lblMensagemFinal.ForeColor = Theme.Success;
            }
            else
            {
                lblMensagemFinal.Text = "Fim de jogo! A palavra era: " + jogo.ItemAtual.Nome;
                lblMensagemFinal.ForeColor = Theme.Error;
            }
            lblMensagemFinal.Visible = true;
            lblMensagemFinal.BringToFront();
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            timerJogo.Stop();
            this.formAnterior.Show();
            this.Close();
        }

        private void timerJogo_Tick(object sender, EventArgs e)
        {
            if (jogo.JogoEmAndamento)
            {
                jogo.DecrementarTempo();
                AtualizarInterface();

                // Calcula o ângulo da animação com base no tempo
                float tempoDecorrido = jogo.TempoTotalPartida - jogo.TempoRestante;
                float duracaoAnimacao = jogo.TempoTotalPartida - 3; // Animação termina 3s antes
                if (duracaoAnimacao <= 0) duracaoAnimacao = 1; // Evita divisão por zero

                float progresso = tempoDecorrido / duracaoAnimacao;
                anguloAtual = progresso * 360;

                if (anguloAtual > 360)
                {
                    anguloAtual = 360;
                }

                pictureBoxBandeira.Invalidate(); // Redesenha a bandeira

                if (!jogo.JogoEmAndamento)
                {
                    FimDeJogo();
                }
            }
        }


        private void pictureBoxBandeira_Paint(object sender, PaintEventArgs e)
        {
            if (imagemBandeiraOriginal != null)
            {
                e.Graphics.Clear(pictureBoxBandeira.BackColor);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Calcula a proporção da imagem dinamicamente para evitar distorções
                float aspectRatio = 1.0f; // Valor padrão
                if (imagemBandeiraOriginal.Height > 0)
                {
                    aspectRatio = (float)imagemBandeiraOriginal.Width / imagemBandeiraOriginal.Height;
                }

                // Calcula as dimensões do retângulo de destino mantendo a proporção
                int larguraDestino = pictureBoxBandeira.Width;
                int alturaDestino = (int)(larguraDestino / aspectRatio);

                if (alturaDestino > pictureBoxBandeira.Height)
                {
                    alturaDestino = pictureBoxBandeira.Height;
                    larguraDestino = (int)(alturaDestino * aspectRatio);
                }

                // Centraliza a imagem no PictureBox
                int x = (pictureBoxBandeira.Width - larguraDestino) / 2;
                int y = (pictureBoxBandeira.Height - alturaDestino) / 2;

                Rectangle destRect = new Rectangle(x, y, larguraDestino, alturaDestino);

                // Cria o caminho (path) da fatia de pizza para usar como clipe
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddPie(destRect, -90, anguloAtual);

                    // Define a região de clipe dos gráficos para o caminho da fatia
                    e.Graphics.SetClip(path);

                    // Desenha a imagem inteira, que será cortada pela região de clipe
                    e.Graphics.DrawImage(imagemBandeiraOriginal, destRect);

                    // Reseta a região de clipe para não afetar outros desenhos
                    e.Graphics.ResetClip();
                }
                
                // Desenha uma borda estilizada ao redor da área da bandeira (opcional)
                using (Pen p = new Pen(Theme.Surface, 4))
                {
                    e.Graphics.DrawRectangle(p, destRect);
                }
            }
        }


        private void CarregarImagemBandeira()
        {
            if (imagemBandeiraOriginal != null)
            {
                imagemBandeiraOriginal.Dispose();
            }
            pictureBoxBandeira.Image = null; // Limpa a imagem antiga do PictureBox

            if (jogo.ItemAtual.CaminhoImagem == null) return;

            string imagePath = Path.Combine(exeDir, jogo.ItemAtual.CaminhoImagem);
            if (File.Exists(imagePath))
            {
                try
                {
                    imagemBandeiraOriginal = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao carregar imagem: {ex.Message}");
                    imagemBandeiraOriginal = null;
                }
            }
            else
            {
                Console.WriteLine($"Imagem não encontrada: {imagePath}");
                imagemBandeiraOriginal = null;
            }
            pictureBoxBandeira.Invalidate(); // Inicia o processo de desenho
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Libera a imagem ao fechar o formulário para evitar memory leaks
            if (imagemBandeiraOriginal != null)
            {
                imagemBandeiraOriginal.Dispose();
            }
        }

        private void btnDica_Click(object sender, EventArgs e)
        {
            if (jogo.ItemAtual.Dica != null)
            {
                FormMessageBox.Show(jogo.ItemAtual.Dica, "Dica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDica.Enabled = false; // Desabilita o botão após o uso
            }
        }

    }
}
