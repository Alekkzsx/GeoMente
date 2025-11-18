using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private Form formEntrada;

        public Form1(Form formEntrada)
        {
            InitializeComponent();
            this.formEntrada = formEntrada;

            // Habilita Double Buffering para suavizar a animação
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);

            // Adicionando os event handlers
            btnNovoJogo.Click += new EventHandler(btnNovoJogo_Click);
            btnAdivinhar.Click += new EventHandler(btnAdivinhar_Click);
            timerJogo.Tick += new EventHandler(timerJogo_Tick);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            btnJogarNovamente.Click += new EventHandler(btnJogarNovamente_Click);
            pictureBoxBandeira.Paint += new PaintEventHandler(pictureBoxBandeira_Paint);
            btnVoltar.Click += new EventHandler(btnVoltar_Click);
            this.Resize += new System.EventHandler(this.Form1_Resize);

            // Cria a instância do gerenciador de jogo
            jogo = new GerenciadorJogo();

            // Inicia o jogo assim que o formulário é carregado
            IniciarNovoJogo();
            // Garante a centralização inicial
            Form1_Resize(null, null);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Centraliza o painel de adivinhação
            panelAdivinhar.Left = (this.ClientSize.Width - panelAdivinhar.Width) / 2;

            // Centraliza a mensagem final
            lblMensagemFinal.Left = (this.ClientSize.Width - lblMensagemFinal.Width) / 2;
        }

        private void IniciarNovoJogo()
        {
            jogo.IniciarNovoJogo();

            // Prepara a animação da bandeira
            anguloAtual = 0;
            CarregarImagemBandeira();

            // Atualiza a interface com o novo estado do jogo
            AtualizarPalavraExibida();
            AtualizarInterface();

            // Habilita controles e inicia o timer
            txtLetra.Enabled = true;
            btnAdivinhar.Enabled = true;
            timerJogo.Start();

            // Limpa a mensagem de fim de jogo
            lblMensagemFinal.Visible = false;
            btnJogarNovamente.Visible = false;
            btnNovoJogo.Visible = true;
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            IniciarNovoJogo();
        }

        private void AtualizarPalavraExibida()
        {
            if (jogo.PalavraExibida == null) return;

            // Use a StringBuilder to explicitly construct the display text with spaces.
            StringBuilder displayText = new StringBuilder();
            for (int i = 0; i < jogo.PalavraExibida.Length; i++)
            {
                displayText.Append(jogo.PalavraExibida[i]);
                if (i < jogo.PalavraExibida.Length - 1)
                {
                    displayText.Append(' ');
                }
            }
            lblPalavraSecreta.Text = displayText.ToString();
        }

        private void AtualizarInterface()
        {
            lblTentativas.Text = "Tentativas restantes: " + jogo.TentativasRestantes;
            lblTempo.Text = "Tempo restante: " + jogo.TempoRestante + "s";
            lblPontuacao.Text = "Pontuação: " + jogo.Pontuacao;
            lblLetrasErradas.Text = "Letras erradas: " + string.Join(", ", jogo.LetrasErradas);
        }

        private void btnAdivinhar_Click(object sender, EventArgs e)
        {
            if (!jogo.JogoEmAndamento || string.IsNullOrEmpty(txtLetra.Text))
            {
                MessageBox.Show("Por favor, inicie um novo jogo e digite uma letra.");
                return;
            }

            if (!char.IsLetter(txtLetra.Text[0]))
            {
                MessageBox.Show("Por favor, digite uma letra válida.");
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

        private void FimDeJogo()
        {
            timerJogo.Stop();
            txtLetra.Enabled = false;
            btnAdivinhar.Enabled = false;
            btnNovoJogo.Visible = false;
            btnJogarNovamente.Visible = true;

            if (jogo.Vitoria)
            {
                AtualizarInterface(); // Atualiza a pontuação com o bônus
                lblMensagemFinal.Text = "Parabéns! Você acertou a palavra! Pontuação final: " + jogo.Pontuacao;
                lblMensagemFinal.ForeColor = Color.Green;
            }
            else
            {
                lblMensagemFinal.Text = "Fim de jogo! A palavra era: " + jogo.PaisAtual.Nome;
                lblMensagemFinal.ForeColor = Color.Red;
            }
            lblMensagemFinal.Visible = true;
        }

        private void btnJogarNovamente_Click(object sender, EventArgs e)
        {
            IniciarNovoJogo();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            timerJogo.Stop();
            this.formEntrada.Show();
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

                // Proporção da imagem original (1200x720)
                const float aspectRatio = 1200f / 720f;

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
                using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    path.AddPie(destRect, -90, anguloAtual);

                    // Define a região de clipe dos gráficos para o caminho da fatia
                    e.Graphics.SetClip(path);

                    // Desenha a imagem inteira, que será cortada pela região de clipe
                    e.Graphics.DrawImage(imagemBandeiraOriginal, destRect);

                    // Reseta a região de clipe para não afetar outros desenhos
                    e.Graphics.ResetClip();
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

            if (jogo.PaisAtual.CaminhoImagem == null) return;

            string imagePath = Path.Combine(exeDir, jogo.PaisAtual.CaminhoImagem);
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

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {

        }

        private void lblPalavraSecreta_Click(object sender, EventArgs e)
        {

        }

        private void lblMensagemFinal_Click(object sender, EventArgs e)
        {

        }

        private void btnJogarNovamente_Click_1(object sender, EventArgs e)
        {

        }
    }
}
