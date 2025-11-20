using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeoMente
{
    public partial class FormMessageBox : Form
    {
        public FormMessageBox(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            InitializeComponent();
            this.Text = title;
            lblMessage.Text = message;
            ConfigurarTema();
            ConfigurarBotoes(buttons);
            // ConfigurarIcone(icon); // Opcional: Adicionar PictureBox para ícone
        }

        private void ConfigurarTema()
        {
            this.BackColor = Theme.Background;
            this.ForeColor = Theme.Text;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            lblMessage.ForeColor = Theme.Text;
            lblMessage.Font = Theme.GetTextFont(12);

            panelButtons.BackColor = Color.Transparent;
        }

        private void ConfigurarBotoes(MessageBoxButtons buttons)
        {
            panelButtons.Controls.Clear();

            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    AdicionarBotao("OK", DialogResult.OK, Theme.Primary);
                    break;
                case MessageBoxButtons.OKCancel:
                    AdicionarBotao("OK", DialogResult.OK, Theme.Primary);
                    AdicionarBotao("Cancelar", DialogResult.Cancel, Theme.Secondary);
                    break;
                    // Adicionar outros casos conforme necessário (Yes/No, etc.)
            }

            // Centraliza os botões
            int totalWidth = 0;
            foreach (Control btn in panelButtons.Controls)
            {
                totalWidth += btn.Width + btn.Margin.Left + btn.Margin.Right;
            }
            int startX = (panelButtons.ClientSize.Width - totalWidth) / 2;
            int currentX = startX;
            foreach (Control btn in panelButtons.Controls)
            {
                btn.Left = currentX;
                currentX += btn.Width + btn.Margin.Left + btn.Margin.Right;
            }
        }

        private void AdicionarBotao(string text, DialogResult result, Color color)
        {
            RoundedButton btn = new RoundedButton
            {
                Text = text,
                DialogResult = result,
                BackColor = color,
                ForeColor = Theme.Text,
                Font = Theme.GetButtonFont(10),
                Size = new Size(100, 40),
                BorderRadius = 15
            };
            btn.Click += (sender, e) => { this.Close(); };
            panelButtons.Controls.Add(btn);
        }

        // Método estático para facilitar a chamada, similar ao MessageBox.Show
        public static DialogResult Show(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            using (var form = new FormMessageBox(message, title, buttons, icon))
            {
                return form.ShowDialog();
            }
        }
    }
}