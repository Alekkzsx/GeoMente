using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

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

            // Conecta os eventos MouseEnter e MouseLeave aos botões
            btnJogar.MouseEnter += new EventHandler(btnJogar_MouseEnter);
            btnJogar.MouseLeave += new EventHandler(btnJogar_MouseLeave);
            btnSair.MouseEnter += new EventHandler(btnSair_MouseEnter);
            btnSair.MouseLeave += new EventHandler(btnSair_MouseLeave);

            // Configura o WebView2
            var webView2Initialization = InitializeWebView2Async();
        }

        private async void InitializeWebView2Async()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.Navigate("https://www.youtube.com/embed/dQw4w9WgXcQ?autoplay=1&loop=1&rel=0&controls=0&showinfo=0");
            webView21.CoreWebView2.Settings.IsWebBrowserContextMenuEnabled = false;
            webView21.CoreWebView2.Settings.AreBrowserShortcutsEnabled = false;
            webView21.CoreWebView2.Settings.IsStatusBarEnabled = false;
            webView21.CoreWebView2.Settings.AreDevToolsEnabled = false;
        }

        private void FormEntrada_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            // Centraliza o painel central
            panelCentral.Left = (this.ClientSize.Width - panelCentral.Width) / 2;
            panelCentral.Top = (this.ClientSize.Height - panelCentral.Height) / 2;

            // Centraliza a Logo dentro do painel
            pictureBoxLogo.Left = (panelCentral.Width - pictureBoxLogo.Width) / 2;
            pictureBoxLogo.Top = 0;

            // Centraliza o botão Jogar
            btnJogar.Left = (panelCentral.Width - btnJogar.Width) / 2;
            btnJogar.Top = pictureBoxLogo.Bottom + 20;

            // Centraliza o botão Sair
            btnSair.Left = (panelCentral.Width - btnSair.Width) / 2;
            btnSair.Top = btnJogar.Bottom + 10;
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

        private void btnJogar_MouseEnter(object sender, EventArgs e)
        {
            btnJogar.BackColor = Color.FromArgb(90, 200, 255);
        }

        private void btnJogar_MouseLeave(object sender, EventArgs e)
        {
            btnJogar.BackColor = Color.DeepSkyBlue;
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.FromArgb(150, 43, 226);
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.BlueViolet;
        }
    }
}
