using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoMente
{
    // Estrutura para armazenar os dados de cada país
    public struct Pais
    {
        public string Nome;
        public string CaminhoImagem;
        public int Nivel;
    }

    public class GerenciadorJogo
    {
        private Random rand = new Random();
        private List<Pais> todosOsPaises;
        private string paisAtualNomeSemAcentos;
        private HashSet<char> letrasTentadas = new HashSet<char>();

        private static readonly Dictionary<int, (int Tentativas, int Tempo)> NiveisDificuldade = new Dictionary<int, (int, int)>
        {
            { 1, (6, 60) },
            { 2, (5, 45) },
            { 3, (4, 30) }
        };

        public Pais PaisAtual { get; private set; }
        public char[] PalavraExibida { get; private set; }
        public int TentativasRestantes { get; private set; }
        public int TempoRestante { get; private set; }
        public int Pontuacao { get; private set; }
        public List<char> LetrasErradas { get; private set; } = new List<char>();
        public int TempoTotalPartida { get; private set; }
        public bool JogoEmAndamento { get; private set; }
        public bool Vitoria { get; private set; }

        public GerenciadorJogo()
        {
            todosOsPaises = RepositorioPaises.ObterTodosOsPaises();
        }

        public void IniciarNovoJogo()
        {
            if (todosOsPaises.Count == 0)
            {
                MessageBox.Show("Nenhum país carregado. Verifique o arquivo 'paises.txt'.");
                return;
            }

            PaisAtual = todosOsPaises[rand.Next(todosOsPaises.Count)];
            paisAtualNomeSemAcentos = Utils.RemoverAcentos(PaisAtual.Nome);

            PalavraExibida = new char[PaisAtual.Nome.Length];
            for (int i = 0; i < PaisAtual.Nome.Length; i++)
            {
                PalavraExibida[i] = PaisAtual.Nome[i] == ' ' ? ' ' : '_';
            }

            if (NiveisDificuldade.TryGetValue(PaisAtual.Nivel, out var dificuldade))
            {
                TentativasRestantes = dificuldade.Tentativas;
                TempoRestante = dificuldade.Tempo;
            }
            else
            {
                // Nível padrão caso não seja encontrado no dicionário
                TentativasRestantes = 5;
                TempoRestante = 50;
            }

            TempoTotalPartida = TempoRestante;

            Pontuacao = 0;
            LetrasErradas.Clear();
            letrasTentadas.Clear();
            JogoEmAndamento = true;
            Vitoria = false;
        }

        public void AdivinharLetra(char letra)
        {
            if (!JogoEmAndamento) return;

            letra = char.ToUpper(letra);
            if (letrasTentadas.Contains(letra))
            {
                // Letra já tentada
                return;
            }
            letrasTentadas.Add(letra);

            bool acertou = false;
            for (int i = 0; i < paisAtualNomeSemAcentos.Length; i++)
            {
                if (paisAtualNomeSemAcentos[i] == letra)
                {
                    PalavraExibida[i] = PaisAtual.Nome[i];
                    acertou = true;
                }
            }

            if (acertou)
            {
                Pontuacao += 10;
                if (!new string(PalavraExibida).Contains('_'))
                {
                    FimDeJogo(true);
                }
            }
            else
            {
                LetrasErradas.Add(letra);
                TentativasRestantes--;
                Pontuacao = Math.Max(0, Pontuacao - 5);
                if (TentativasRestantes <= 0)
                {
                    FimDeJogo(false);
                }
            }
        }

        public void DecrementarTempo()
        {
            if (!JogoEmAndamento) return;

            TempoRestante--;
            if (TempoRestante <= 0)
            {
                FimDeJogo(false);
            }
        }

        private void FimDeJogo(bool vitoria)
        {
            JogoEmAndamento = false;
            Vitoria = vitoria;
            if (vitoria)
            {
                Pontuacao += TempoRestante * 2;
            }
        }

    }
}
