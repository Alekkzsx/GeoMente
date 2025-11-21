using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeoMente
{
    public partial class FormModoJogo : Form
    {
        private Form formEntrada;
        private string modoSelecionado = null;

        public FormModoJogo(Form formEntrada)
        {
            InitializeComponent();
            this.formEntrada = formEntrada;
            this.FormClosing += FormModoJogo_FormClosing;
            ConfigurarTema();

        }

        private void ConfigurarTema()
        {
            this.BackColor = Theme.Background;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "GeoMente - Seleção de Modo";

            // Estiliza botões de modo com cores vibrantes
            EstilizarBotao(btnPaises, Theme.Primary, Color.White);
            EstilizarBotao(btnCapitais, Theme.Info, Color.White);
            EstilizarBotao(btnCuriosidades, Theme.Secondary, Color.White);

            // Todos os modos estão disponíveis
            btnCapitais.Enabled = true;
            btnCuriosidades.Enabled = true;

            // Estiliza botões de dificuldade
            EstilizarBotao(btnFacil, Theme.Success, Color.White);
            EstilizarBotao(btnMedio, Theme.Warning, Color.White);
            EstilizarBotao(btnDificil, Theme.Error, Color.White);
            EstilizarBotao(btnHardcore, ColorTranslator.FromHtml("#7C3AED"), Color.White); // Roxo moderno

            // Estiliza botões de voltar
            EstilizarBotao(btnVoltarModos, Theme.TextSecondary, Color.White);
            EstilizarBotao(btnVoltarDificuldade, Theme.TextSecondary, Color.White);

            // Ajusta visibilidade inicial
            panelDificuldade.BackColor = Color.Transparent;
        }

        private void EstilizarBotao(Button btn, Color corFundo, Color corTexto)
        {
            if (btn is RoundedButton rb)
            {
                rb.BackColor = corFundo;
                rb.ForeColor = corTexto;
                rb.BorderRadius = 20;
                rb.Font = Theme.GetButtonFont(14); // Fonte maior para melhor legibilidade
                rb.Size = new Size(200, 65); // Botões maiores e mais clicáveis
            }
            else
            {
                btn.BackColor = corFundo;
                btn.ForeColor = corTexto;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }
        }

        private void FormModoJogo_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Evita fechar a aplicação inteira se o usuário clicar no "X"
            // Em vez disso, volta para o menu principal
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.formEntrada.Show();
            }
        }

        private void btnPaises_Click(object sender, EventArgs e)
        {
            SelecionarModo("Países");
        }

        private void btnCapitais_Click(object sender, EventArgs e)
        {
            SelecionarModo("Capitais");
        }

        private void btnCuriosidades_Click(object sender, EventArgs e)
        {
            SelecionarModo("Curiosidades");
        }

        private void SelecionarModo(string modo)
        {
            modoSelecionado = modo;

            // Atualiza o título para a tela de dificuldade
            lblTitulo.Text = "Escolha a Dificuldade (tome cuidado!)";

            // Esconde os botões não selecionados
            btnPaises.Visible = modo == "Países";
            btnCapitais.Visible = modo == "Capitais";
            btnCuriosidades.Visible = modo == "Curiosidades";

            // Centraliza o botão selecionado
            RoundedButton btnSelecionado = null;
            if (modo == "Países") btnSelecionado = btnPaises;
            else if (modo == "Capitais") btnSelecionado = btnCapitais;
            else if (modo == "Curiosidades") btnSelecionado = btnCuriosidades;

            if (btnSelecionado != null)
            {
                // Posiciona o botão selecionado no topo
                btnSelecionado.Left = (this.ClientSize.Width - btnSelecionado.Width) / 2;
                btnSelecionado.Top = 80; // Espaço do topo
            }

            // Organiza os botões de dificuldade em grid 2x2 DENTRO DO PAINEL
            int buttonSpacing = 20;
            
            // Primeira linha: Fácil e Médio
            btnFacil.Left = 10;
            btnFacil.Top = 10;
            
            btnMedio.Left = btnFacil.Right + buttonSpacing;
            btnMedio.Top = 10;
            
            // Segunda linha: Difícil e Hardcore
            btnDificil.Left = 10;
            btnDificil.Top = btnFacil.Bottom + buttonSpacing;
            
            btnHardcore.Left = btnDificil.Right + buttonSpacing;
            btnHardcore.Top = btnDificil.Top;

            // Ajusta o tamanho do painel para caber os botões
            int panelWidth = (btnFacil.Width * 2) + buttonSpacing + 20; // 20 = margens
            int panelHeight = (btnFacil.Height * 2) + buttonSpacing + 20;
            panelDificuldade.Size = new Size(panelWidth, panelHeight);

            // Posiciona o painel centralizado abaixo do botão de modo
            panelDificuldade.Left = (this.ClientSize.Width - panelWidth) / 2;
            panelDificuldade.Top = btnSelecionado.Bottom + 80; // Mais espaço após o botão de modo

            // Mostra o painel de dificuldade
            panelDificuldade.Visible = true;

            // Esconde o botão voltar dos modos
            btnVoltarModos.Visible = false;
            
            // Mostra o botão voltar da dificuldade
            btnVoltarDificuldade.Visible = true;
            btnVoltarDificuldade.Left = (this.ClientSize.Width - btnVoltarDificuldade.Width) / 2;
            btnVoltarDificuldade.Top = panelDificuldade.Bottom + 50; // Mais espaço
        }

        private void btnFacil_Click(object sender, EventArgs e)
        {
            IniciarJogo("Fácil");
        }

        private void btnMedio_Click(object sender, EventArgs e)
        {
            IniciarJogo("Médio");
        }

        private void btnDificil_Click(object sender, EventArgs e)
        {
            IniciarJogo("Difícil");
        }

        private void btnHardcore_Click(object sender, EventArgs e)
        {
            IniciarJogo("Hardcore");
        }

        private void IniciarJogo(string dificuldade)
        {
            Form1 formJogo = new Form1(this, modoSelecionado, dificuldade);
            formJogo.Show();
            this.Hide();
        }

        private void btnVoltarModos_Click(object sender, EventArgs e)
        {
            this.formEntrada.Show();
            this.Close();
        }

        private void btnVoltarDificuldade_Click(object sender, EventArgs e)
        {
            // Volta para a seleção de modos
            modoSelecionado = null;
            
            // Restaura o título para a tela de modos
            lblTitulo.Text = "Escolha o Modo de Jogo";
            
            btnPaises.Visible = true;
            btnCapitais.Visible = true;
            btnCuriosidades.Visible = true;
            panelDificuldade.Visible = false;
            btnVoltarModos.Visible = true;
            btnVoltarDificuldade.Visible = false;

            // Reposiciona os botões de modo
            CentralizarBotoesModo();
        }

        private void CentralizarBotoesModo()
        {
            int buttonWidth = btnPaises.Width;
            int spacing = 24; // Espaçamento aumentado
            int totalWidth = (buttonWidth * 3) + (spacing * 2);
            
            int startX = (this.ClientSize.Width - totalWidth) / 2;
            int centerY = (this.ClientSize.Height - btnPaises.Height) / 2 - 40; // Mais para cima

            btnPaises.Left = startX;
            btnPaises.Top = centerY;

            btnCapitais.Left = btnPaises.Right + spacing;
            btnCapitais.Top = centerY;

            btnCuriosidades.Left = btnCapitais.Right + spacing;
            btnCuriosidades.Top = centerY;

            // Botão voltar com mais espaço
            btnVoltarModos.Left = (this.ClientSize.Width - btnVoltarModos.Width) / 2;
            btnVoltarModos.Top = btnPaises.Bottom + 60; // Mais espaço
        }

        private void FormModoJogo_Resize(object sender, EventArgs e)
        {
            if (modoSelecionado == null)
            {
                CentralizarBotoesModo();
            }
            else
            {
                SelecionarModo(modoSelecionado); // Recalcula posições
            }
        }

        private void FormModoJogo_Load(object sender, EventArgs e)
        {
            CentralizarBotoesModo();
        }
    }
}
