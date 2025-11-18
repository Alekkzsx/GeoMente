using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace GeoMente
{
    public static class RepositorioPaises
    {
        private static readonly string exeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static List<Pais> todosOsPaises = new List<Pais>();
        private static bool paisesCarregados = false;

        public static void CarregarPaises()
        {
            if (paisesCarregados) return;

            string caminhoArquivo = Path.Combine(exeDir, "paises.txt");
            if (!File.Exists(caminhoArquivo))
            {
                MessageBox.Show("Arquivo 'paises.txt' não encontrado!");
                return;
            }

            try
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);
                foreach (string linha in linhas)
                {
                    string[] partes = linha.Split(';');
                    if (partes.Length == 3 && int.TryParse(partes[2], out int nivel))
                    {
                        Pais p = new Pais
                        {
                            Nome = partes[0].ToUpper(),
                            CaminhoImagem = partes[1],
                            Nivel = nivel
                        };
                        todosOsPaises.Add(p);
                    }
                }
                paisesCarregados = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao ler o arquivo 'paises.txt': {ex.Message}");
            }
        }

        public static List<Pais> ObterTodosOsPaises()
        {
            if (!paisesCarregados)
            {
                CarregarPaises();
            }
            return todosOsPaises;
        }
    }
}
