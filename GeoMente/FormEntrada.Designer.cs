namespace GeoMente
{
    partial class FormEntrada
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnJogar = new GeoMente.RoundedButton();
            this.btnSair = new GeoMente.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(613, 246);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnJogar
            // 
            this.btnJogar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJogar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnJogar.BorderRadius = 15;
            this.btnJogar.FlatAppearance.BorderSize = 0;
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.Color.White;
            this.btnJogar.HoverBackColor = System.Drawing.Color.Empty;
            this.btnJogar.Location = new System.Drawing.Point(0, 0);
            this.btnJogar.Margin = new System.Windows.Forms.Padding(5);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.OriginalBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnJogar.Size = new System.Drawing.Size(281, 85);
            this.btnJogar.TabIndex = 1;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.BackColor = System.Drawing.Color.BlueViolet;
            this.btnSair.BorderRadius = 15;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.HoverBackColor = System.Drawing.Color.Empty;
            this.btnSair.Location = new System.Drawing.Point(0, 0);
            this.btnSair.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSair.Name = "btnSair";
            this.btnSair.OriginalBackColor = System.Drawing.Color.BlueViolet;
            this.btnSair.Size = new System.Drawing.Size(200, 62);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // FormEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 531);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "FormEntrada";
            this.Text = "Bem-vindo ao GeoMente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private RoundedButton btnJogar;
        private RoundedButton btnSair;
    }
}
