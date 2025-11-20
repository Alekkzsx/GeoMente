using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace GeoMente
{
    public static class RepositorioItens
    {
        private static readonly string exeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static Dictionary<string, List<ItemJogo>> cacheItens = new Dictionary<string, List<ItemJogo>>();

        public static List<ItemJogo> ObterTodosItens(string modoJogo)
        {
            if (cacheItens.ContainsKey(modoJogo))
            {
                return cacheItens[modoJogo];
            }

            string nomeArquivo = $"{modoJogo.ToLower()}.txt";
            string caminhoArquivo = Path.Combine(exeDir, nomeArquivo);

            if (!File.Exists(caminhoArquivo))
            {
                FormMessageBox.Show($"Arquivo '{nomeArquivo}' não encontrado!", "Erro de Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ItemJogo>();
            }

            List<ItemJogo> itens = new List<ItemJogo>();
            try
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);
                foreach (string linha in linhas)
                {
                    string[] partes = linha.Split(';');
                    if (partes.Length >= 3 && int.TryParse(partes[2], out int nivel))
                    {
                        ItemJogo item = new ItemJogo
                        {
                            Nome = partes[0].ToUpper(),
                            CaminhoImagem = partes[1],
                            Nivel = nivel,
                            Dica = partes.Length > 3 ? partes[3] : null // Adiciona a dica se ela existir
                        };
                        itens.Add(item);
                    }
                }
                cacheItens[modoJogo] = itens;
            }
            catch (Exception ex)
            {
                FormMessageBox.Show($"Erro ao ler o arquivo '{nomeArquivo}': {ex.Message}", "Erro de Leitura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return itens;
        }
    }
}
