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
    public struct ItemJogo
    {
        public string Nome;
        public string CaminhoImagem;
        public int Nivel;
        public string Dica; // Novo campo para a dica
    }

    public class GerenciadorJogo
    {
        private Random rand = new Random();
        private List<ItemJogo> todosOsItens;
        private string itemAtualNomeSemAcentos;
        private HashSet<char> letrasTentadas = new HashSet<char>();

        private static readonly Dictionary<int, (int Tentativas, int Tempo)> NiveisDificuldade = new Dictionary<int, (int, int)>
        {
            { 1, (6, 60) },  // Fácil
            { 2, (5, 45) },  // Médio
            { 3, (4, 30) },  // Difícil
            { 4, (3, 25) }   // Hardcore
        };

        public ItemJogo ItemAtual { get; private set; }
        public char[] PalavraExibida { get; private set; }
        public int TentativasRestantes { get; private set; }
        public int TempoRestante { get; private set; }
        public int Pontuacao { get; private set; }
        public List<char> LetrasErradas { get; private set; } = new List<char>();
        public int TempoTotalPartida { get; private set; }
        public bool JogoEmAndamento { get; private set; }
        public bool Vitoria { get; private set; }
        public int TentativasPalavraCompleta { get; private set; }

        public GerenciadorJogo(string modoJogo)
        {
            todosOsItens = RepositorioItens.ObterTodosItens(modoJogo);
        }

        public void IniciarNovoJogo(string dificuldadeNome = "Fácil")
        {
            if (todosOsItens.Count == 0)
            {
                FormMessageBox.Show("Nenhum item carregado para este modo de jogo.", "Erro de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mapeia o nome da dificuldade para o nível (int)
            int nivelDificuldade = 1; // Padrão Fácil
            switch (dificuldadeNome)
            {
                case "Fácil": nivelDificuldade = 1; break;
                case "Médio": nivelDificuldade = 2; break;
                case "Difícil": nivelDificuldade = 3; break;
                case "Hardcore": nivelDificuldade = 4; break;
            }

            // Filtra os países pelo nível de dificuldade
            var itensFiltrados = todosOsItens.Where(p => p.Nivel == nivelDificuldade).ToList();

            // Se não houver países para a dificuldade selecionada, usa todos (fallback)
            // ou tenta buscar de níveis adjacentes? Vamos usar todos por enquanto para evitar travar.
            if (itensFiltrados.Count == 0)
            {
                // Opcional: Avisar o usuário ou apenas usar todos silenciosamente
                // MessageBox.Show($"Não há itens cadastrados para a dificuldade {dificuldadeNome}. Usando lista completa.");
                itensFiltrados = todosOsItens;
            }

            ItemAtual = itensFiltrados[rand.Next(itensFiltrados.Count)];
            itemAtualNomeSemAcentos = Utils.RemoverAcentos(ItemAtual.Nome);

            PalavraExibida = new char[ItemAtual.Nome.Length];
            for (int i = 0; i < ItemAtual.Nome.Length; i++)
            {
                PalavraExibida[i] = ItemAtual.Nome[i] == ' ' ? ' ' : '_';
            }

            // Define tempo e tentativas com base na dificuldade SELECIONADA, 
            // mas o código original usava o nível do país. 
            // Como agora filtramos, o nível do país deve bater com a dificuldade.
            // Se caiu no fallback (todos), usamos o nível do país sorteado.
            
            if (NiveisDificuldade.TryGetValue(ItemAtual.Nivel, out var config))
            {
                TentativasRestantes = config.Tentativas;
                TempoRestante = config.Tempo;
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
            TentativasPalavraCompleta = 3;
        }

        public void AdivinharLetra(char letra)
        {
            if (!JogoEmAndamento) return;

            // Normaliza a letra para comparação sem acentos
            string letraNormalizadaStr = Utils.RemoverAcentos(letra.ToString().ToUpper());
            if (string.IsNullOrEmpty(letraNormalizadaStr)) return; // Ignora caracteres inválidos
            char letraNormalizada = letraNormalizadaStr[0];

            if (letrasTentadas.Contains(letraNormalizada))
            {
                // Letra já tentada
                return;
            }
            letrasTentadas.Add(letraNormalizada);

            bool acertou = false;
            for (int i = 0; i < itemAtualNomeSemAcentos.Length; i++)
            {
                if (itemAtualNomeSemAcentos[i] == letraNormalizada)
                {
                    PalavraExibida[i] = ItemAtual.Nome[i];
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

        public void AdivinharPalavraCompleta(string palavra)
        {
            if (!JogoEmAndamento) return;

            string palavraNormalizada = Utils.RemoverAcentos(palavra.Trim()).ToUpper();
            
            if (palavraNormalizada == itemAtualNomeSemAcentos)
            {
                // Acertou a palavra completa
                PalavraExibida = ItemAtual.Nome.ToCharArray();
                Pontuacao += 50; // Bônus por acertar a palavra completa
                FimDeJogo(true);
            }
            else
            {
                // Errou
                TentativasPalavraCompleta--;
                if (TentativasPalavraCompleta <= 0)
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
