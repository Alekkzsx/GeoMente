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
            ConfigurarTema();

            // Carrega a imagem da logo dinamicamente
            try
            {
                string exeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string logoPath = Path.Combine(exeDir, "GeoMente-logo.png");

                if (File.Exists(logoPath))
                {
                    pictureBoxLogo.Image = Image.FromFile(logoPath);
                    pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom; // Garante que a logo não distorça
                }
            }
            catch (Exception ex)
            {
                FormMessageBox.Show("Não foi possível carregar a imagem da logo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Adicionando os event handlers para os botões
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.Resize += new System.EventHandler(this.FormEntrada_Resize);

            // Garante que a centralização ocorra após o form ser totalmente carregado
            this.Load += new System.EventHandler(this.FormEntrada_Load);
        }

        private void ConfigurarTema()
        {
            this.BackColor = Theme.Background;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "GeoMente - Menu Principal";
            
            // Configura botões (assumindo que são RoundedButton no Designer ou convertidos aqui)
            // Se forem botões normais no designer, vamos estilizá-los o máximo possível ou
            // o ideal seria trocar no Designer.cs, mas aqui vamos ajustar cores.
            
            EstilizarBotao(btnJogar, Theme.Primary);
            EstilizarBotao(btnSair, Theme.Secondary);
        }

        private void EstilizarBotao(Button btn, Color corFundo)
        {
            if (btn is RoundedButton rb)
            {
                rb.BackColor = corFundo;
                rb.ForeColor = Theme.Text;
                rb.BorderRadius = 25;
            }
            else
            {
                btn.BackColor = corFundo;
                btn.ForeColor = Theme.Text;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }
        }

        private void FormEntrada_Load(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void FormEntrada_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int espacamento = 20;
            int totalHeight = pictureBoxLogo.Height + btnJogar.Height + btnSair.Height + (espacamento * 2);
            
            int startY = (this.ClientSize.Height - totalHeight) / 2;

            // Centraliza a Logo
            pictureBoxLogo.Left = (this.ClientSize.Width - pictureBoxLogo.Width) / 2;
            pictureBoxLogo.Top = startY;

            // Centraliza o botão Jogar
            btnJogar.Left = (this.ClientSize.Width - btnJogar.Width) / 2;
            btnJogar.Top = pictureBoxLogo.Bottom + espacamento;

            // Centraliza o botão Sair
            btnSair.Left = (this.ClientSize.Width - btnSair.Width) / 2;
            btnSair.Top = btnJogar.Bottom + espacamento;
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            // Cria e exibe o formulário de seleção de modo de jogo
            FormModoJogo formModoJogo = new FormModoJogo(this);
            formModoJogo.Show();
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
