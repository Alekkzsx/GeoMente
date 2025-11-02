using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace GeoMente
{
    public partial class FormEntrada : Form
    {
        public FormEntrada()
        {
            InitializeComponent();

            // Carrega a imagem da logo dinamicamente
            try
            {
                string exeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string logoPath = Path.Combine(exeDir, "GeoMente-logo.png");

                if (File.Exists(logoPath))
                {
                    pictureBoxLogo.Image = Image.FromFile(logoPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar a imagem da logo: " + ex.Message);
            }


            // Adicionando os event handlers para os botões
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            // Cria e exibe o formulário principal do jogo, passando uma referência de si mesmo
            Form1 formJogo = new Form1(this);
            formJogo.Show();
            // Esconde a tela de entrada
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Fecha a aplicação
            Application.Exit();
        }
    }
}
