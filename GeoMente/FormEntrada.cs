using System;
using System.Windows.Forms;

namespace GeoMente
{
    public partial class FormEntrada : Form
    {
        public FormEntrada()
        {
            InitializeComponent();
            // Adicionando os event handlers para os botões
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            // Cria e exibe o formulário principal do jogo
            Form1 formJogo = new Form1();
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
