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
        private Random rand = new Random();
        private string paisAtualNomeSemAcentos;
        // Estrutura para armazenar os dados de cada país
        private struct Pais
        {
            public string Nome;
            public string CaminhoImagem;
            public int Nivel;
        }

        private List<Pais> todosOsPaises = new List<Pais>();
        private Pais paisAtual;
        private char[] palavraExibida;
        private int tentativasRestantes;
        private int tempoRestante;
        private int pontuacao;
        private List<char> letrasErradas = new List<char>();
        private int tempoTotalPartida;
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

            CarregarPaises();

            // Adicionando os event handlers
            btnNovoJogo.Click += new EventHandler(btnNovoJogo_Click);
            btnAdivinhar.Click += new EventHandler(btnAdivinhar_Click);
            timerJogo.Tick += new EventHandler(timerJogo_Tick);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            btnJogarNovamente.Click += new EventHandler(btnJogarNovamente_Click);
            pictureBoxBandeira.Paint += new PaintEventHandler(pictureBoxBandeira_Paint);
            btnVoltar.Click += new EventHandler(btnVoltar_Click);

            // Inicia o jogo assim que o formulário é carregado
            IniciarNovoJogo();
        }

        private void CarregarPaises()
        {
            string caminhoArquivo = Path.Combine(exeDir, "paises.txt");
            if (File.Exists(caminhoArquivo))
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);
                foreach (string linha in linhas)
                {
                    string[] partes = linha.Split(';');
                    if (partes.Length == 3)
                    {
                        Pais p = new Pais
                        {
                            Nome = partes[0].ToUpper(),
                            CaminhoImagem = partes[1],
                            Nivel = int.Parse(partes[2])
                        };
                        todosOsPaises.Add(p);
                    }
                }
            }
            else
            {
                MessageBox.Show("Arquivo 'paises.txt' não encontrado!");
            }
        }

        private void IniciarNovoJogo()
        {
            if (todosOsPaises.Count == 0)
            {
                MessageBox.Show("Nenhum país carregado. Verifique o arquivo 'paises.txt'.");
                return;
            }

            // Seleciona um país aleatoriamente
            paisAtual = todosOsPaises[rand.Next(todosOsPaises.Count)];
            paisAtualNomeSemAcentos = RemoverAcentos(paisAtual.Nome);

            // Prepara a animação da bandeira
            anguloAtual = 0;
            CarregarImagemBandeira();


            // Inicializa a palavra exibida com underscores
            palavraExibida = new char[paisAtual.Nome.Length];
            for (int i = 0; i < paisAtual.Nome.Length; i++)
            {
                if (paisAtual.Nome[i] == ' ')
                {
                    palavraExibida[i] = ' ';
                }
                else
                {
                    palavraExibida[i] = '_';
                }
            }
            AtualizarPalavraExibida();

            // Define tentativas e tempo com base no nível
            // Nivel 1: 6 tentativas, 60s
            // Nivel 2: 5 tentativas, 45s
            // Nivel 3: 4 tentativas, 30s
            switch (paisAtual.Nivel)
            {
                case 1:
                    tentativasRestantes = 6;
                    tempoRestante = 60;
                    break;
                case 2:
                    tentativasRestantes = 5;
                    tempoRestante = 45;
                    break;
                case 3:
                    tentativasRestantes = 4;
                    tempoRestante = 30;
                    break;
                default:
                    tentativasRestantes = 5;
                    tempoRestante = 50;
                    break;
            }
            tempoTotalPartida = tempoRestante; // Armazena o tempo inicial

            // Reseta pontuação e letras erradas
            pontuacao = 0;
            letrasErradas.Clear();

            // Atualiza a interface
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
            if (palavraExibida == null) return;

            // Use a StringBuilder to explicitly construct the display text with spaces.
            StringBuilder displayText = new StringBuilder();
            for (int i = 0; i < palavraExibida.Length; i++)
            {
                displayText.Append(palavraExibida[i]);
                if (i < palavraExibida.Length - 1)
                {
                    displayText.Append(' ');
                }
            }
            lblPalavraSecreta.Text = displayText.ToString();
        }

        private void AtualizarInterface()
        {
            lblTentativas.Text = "Tentativas restantes: " + tentativasRestantes;
            lblTempo.Text = "Tempo restante: " + tempoRestante + "s";
            lblPontuacao.Text = "Pontuação: " + pontuacao;
            lblLetrasErradas.Text = "Letras erradas: " + string.Join(", ", letrasErradas);
        }

        private void btnAdivinhar_Click(object sender, EventArgs e)
        {
            if (palavraExibida == null || string.IsNullOrEmpty(txtLetra.Text))
            {
                MessageBox.Show("Por favor, inicie um novo jogo e digite uma letra.");
                return;
            }

            char letra = txtLetra.Text.ToUpper()[0];

            if (!char.IsLetter(letra))
            {
                MessageBox.Show("Por favor, digite uma letra válida.");
                txtLetra.Clear();
                return;
            }

            // Verificação segura de letras já tentadas
            if (letrasErradas != null && letrasErradas.Contains(letra))
            {
                MessageBox.Show("Você já tentou esta letra.");
                txtLetra.Clear();
                return;
            }

            if (palavraExibida != null && palavraExibida.Contains(letra))
            {
                MessageBox.Show("Você já tentou esta letra.");
                txtLetra.Clear();
                return;
            }

            bool acertou = false;
            for (int i = 0; i < paisAtualNomeSemAcentos.Length; i++)
            {
                if (paisAtualNomeSemAcentos[i] == letra)
                {
                    palavraExibida[i] = paisAtual.Nome[i];
                    acertou = true;
                }
            }

            if (acertou)
            {
                pontuacao += 10; // Ganha 10 pontos por acerto
                AtualizarPalavraExibida();
                // Verificar condição de vitória
                if (!palavraExibida.Contains('_'))
                {
                    FimDeJogo(true); // Venceu
                }
            }
            else
            {
                letrasErradas.Add(letra);
                tentativasRestantes--;
                pontuacao = Math.Max(0, pontuacao - 5); // Perde 5 pontos por erro, sem negativar
                // Verificar condição de derrota
                if (tentativasRestantes <= 0)
                {
                    FimDeJogo(false); // Perdeu
                }
            }

            AtualizarInterface();
            txtLetra.Clear();
            txtLetra.Focus();
        }

        private void FimDeJogo(bool vitoria)
        {
            timerJogo.Stop();
            txtLetra.Enabled = false;
            btnAdivinhar.Enabled = false;
            btnNovoJogo.Visible = false;
            btnJogarNovamente.Visible = true;

            if (vitoria)
            {
                pontuacao += tempoRestante * 2; // Bônus por tempo restante
                AtualizarInterface();
                lblMensagemFinal.Text = "Parabéns! Você acertou a palavra! Pontuação final: " + pontuacao;
                lblMensagemFinal.ForeColor = Color.Green;
            }
            else
            {
                lblMensagemFinal.Text = "Fim de jogo! A palavra era: " + paisAtual.Nome;
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
            if (tempoRestante > 0)
            {
                tempoRestante--;
                lblTempo.Text = "Tempo restante: " + tempoRestante + "s";

                // Calcula o ângulo da animação com base no tempo
                float tempoDecorrido = tempoTotalPartida - tempoRestante;
                float duracaoAnimacao = tempoTotalPartida - 3; // Animação termina 3s antes
                if (duracaoAnimacao <= 0) duracaoAnimacao = 1; // Evita divisão por zero

                float progresso = tempoDecorrido / duracaoAnimacao;
                anguloAtual = progresso * 360;

                if (anguloAtual > 360)
                {
                    anguloAtual = 360;
                }

                pictureBoxBandeira.Invalidate(); // Redesenha a bandeira
            }
            else
            {
                FimDeJogo(false); // O tempo acabou, o jogador perdeu
            }
        }

        private void pictureBoxBandeira_Click(object sender, EventArgs e)
        {

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

            string imagePath = Path.Combine(exeDir, paisAtual.CaminhoImagem);
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

        private static string RemoverAcentos(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
