using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoMente
{
    public partial class Form1 : Form
    {
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

        public Form1()
        {
            InitializeComponent();
            CarregarPaises();

            // Adicionando os event handlers
            btnNovoJogo.Click += new EventHandler(btnNovoJogo_Click);
            btnAdivinhar.Click += new EventHandler(btnAdivinhar_Click);
            timerJogo.Tick += new EventHandler(timerJogo_Tick);
        }

        private void CarregarPaises()
        {
            string caminhoArquivo = "paises.txt";
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

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            if (todosOsPaises.Count == 0)
            {
                MessageBox.Show("Nenhum país carregado. Verifique o arquivo 'paises.txt'.");
                return;
            }

            // Seleciona um país aleatoriamente
            Random rand = new Random();
            paisAtual = todosOsPaises[rand.Next(todosOsPaises.Count)];

            // Carrega a imagem da bandeira
            if (File.Exists(paisAtual.CaminhoImagem))
            {
                pictureBoxBandeira.Image = Image.FromFile(paisAtual.CaminhoImagem);
            }
            else
            {
                // Se a imagem não existir, exibe um placeholder
                Bitmap bmp = new Bitmap(pictureBoxBandeira.Width, pictureBoxBandeira.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.LightGray);
                    g.DrawString("Imagem não encontrada", this.Font, Brushes.Black, 10, 10);
                }
                pictureBoxBandeira.Image = bmp;
            }

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

            // Reseta pontuação e letras erradas
            pontuacao = 0;
            letrasErradas.Clear();

            // Atualiza a interface
            AtualizarInterface();

            // Habilita controles e inicia o timer
            txtLetra.Enabled = true;
            btnAdivinhar.Enabled = true;
            timerJogo.Start();
        }

        private void AtualizarPalavraExibida()
        {
            lblPalavraSecreta.Text = string.Join(" ", palavraExibida);
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
            if (string.IsNullOrEmpty(txtLetra.Text))
            {
                MessageBox.Show("Por favor, digite uma letra.");
                return;
            }

            char letra = txtLetra.Text.ToUpper()[0];

            if (!char.IsLetter(letra))
            {
                MessageBox.Show("Por favor, digite uma letra válida.");
                txtLetra.Clear();
                return;
            }

            if (palavraExibida.Contains(letra) || letrasErradas.Contains(letra))
            {
                MessageBox.Show("Você já tentou esta letra.");
                txtLetra.Clear();
                return;
            }

            bool acertou = false;
            for (int i = 0; i < paisAtual.Nome.Length; i++)
            {
                if (paisAtual.Nome[i] == letra)
                {
                    palavraExibida[i] = letra;
                    acertou = true;
                    pontuacao += 10; // Ganha 10 pontos por acerto
                }
            }

            if (acertou)
            {
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
                pontuacao -= 5; // Perde 5 pontos por erro
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

            if (vitoria)
            {
                pontuacao += tempoRestante * 2; // Bônus por tempo restante
                AtualizarInterface();
                MessageBox.Show("Parabéns! Você acertou a palavra!\nPontuação final: " + pontuacao);
            }
            else
            {
                MessageBox.Show("Fim de jogo! A palavra era: " + paisAtual.Nome);
            }
        }

        private void timerJogo_Tick(object sender, EventArgs e)
        {
            if (tempoRestante > 0)
            {
                tempoRestante--;
                lblTempo.Text = "Tempo restante: " + tempoRestante + "s";
            }
            else
            {
                FimDeJogo(false); // O tempo acabou, o jogador perdeu
            }
        }

        private void pictureBoxBandeira_Click(object sender, EventArgs e)
        {

        }
    }
}
