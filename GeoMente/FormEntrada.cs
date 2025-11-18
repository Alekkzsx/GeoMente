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
            this.Resize += new System.EventHandler(this.FormEntrada_Resize);

            // Centraliza os controles na inicialização
            CenterControls();

        }

        private void FormEntrada_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            // Centraliza a Logo
            pictureBoxLogo.Left = (this.ClientSize.Width - pictureBoxLogo.Width) / 2;
            pictureBoxLogo.Top = (this.ClientSize.Height - (pictureBoxLogo.Height + btnJogar.Height + btnSair.Height + 30)) / 2; // 30 é o espaçamento total entre os elementos

            // Centraliza o botão Jogar
            btnJogar.Left = (this.ClientSize.Width - btnJogar.Width) / 2;
            btnJogar.Top = pictureBoxLogo.Bottom + 10; // 10 pixels de espaçamento

            // Centraliza o botão Sair
            btnSair.Left = (this.ClientSize.Width - btnSair.Width) / 2;
            btnSair.Top = btnJogar.Bottom + 10; // 10 pixels de espaçamento
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

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
