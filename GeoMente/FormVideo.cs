using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace GeoMente
{
    public partial class FormVideo : Form
    {
        private string caminhoVideo;
        private RoundedButton btnContinuar;
        private Label lblMensagem;

        public FormVideo(string nomeVideo)
        {
            InitializeComponent();
            
            string exeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            caminhoVideo = Path.Combine(exeDir, nomeVideo);

            ConfigurarForm();
            ConfigurarMensagem();
            ConfigurarBotao();
            ReproducirVideo();
        }

        private void ConfigurarForm()
        {
            this.BackColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.KeyPreview = true;
            this.KeyDown += FormVideo_KeyDown;
        }

        private void ConfigurarMensagem()
        {
            lblMensagem = new Label
            {
                Text = "Reproduzindo vídeo...\n\nPressione ESC ou clique em Continuar para prosseguir",
                ForeColor = Color.White,
                Font = Theme.GetTextFont(16),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(600, 100)
            };

            lblMensagem.Location = new Point(
                (this.ClientSize.Width - lblMensagem.Width) / 2,
                (this.ClientSize.Height - lblMensagem.Height) / 2
            );

            this.Controls.Add(lblMensagem);
        }

        private void ConfigurarBotao()
        {
            btnContinuar = new RoundedButton
            {
                Text = "Continuar",
                Size = new Size(200, 60),
                BackColor = Theme.Primary,
                ForeColor = Color.White,
                Font = Theme.GetButtonFont(16),
                BorderRadius = 20
            };

            btnContinuar.Click += (s, e) => this.Close();
            
            // Posiciona no centro inferior
            btnContinuar.Location = new Point(
                (this.ClientSize.Width - btnContinuar.Width) / 2,
                this.ClientSize.Height - btnContinuar.Height - 50
            );

            this.Controls.Add(btnContinuar);
            btnContinuar.BringToFront();
        }

        private void ReproducirVideo()
        {
            if (File.Exists(caminhoVideo))
            {
                try
                {
                    // Usa o player de vídeo padrão do Windows
                    Process.Start(caminhoVideo);
                    
                    // Aguarda um pouco para o vídeo abrir
                    Timer timer = new Timer();
                    timer.Interval = 3000; // 3 segundos
                    timer.Tick += (s, e) =>
                    {
                        timer.Stop();
                        lblMensagem.Text = "Vídeo reproduzindo em outra janela!\n\nPressione ESC ou clique em Continuar quando terminar";
                    };
                    timer.Start();
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = $"Erro ao reproduzir vídeo: {ex.Message}\n\nPressione ESC ou clique em Continuar";
                }
            }
            else
            {
                lblMensagem.Text = $"Vídeo não encontrado!\n\nPressione ESC ou clique em Continuar";
            }
        }

        private void FormVideo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormVideo
            // 
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1280, 720);
            this.Name = "FormVideo";
            this.Text = "GeoMente - Vídeo";
            this.ResumeLayout(false);
        }
    }
}
