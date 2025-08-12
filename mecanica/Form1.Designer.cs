namespace mecanica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblEmail = new Label();
            lblSenha = new Label();
            txbEmail = new TextBox();
            txbSenha = new TextBox();
            btnLogar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = SystemColors.ControlLightLight;
            lblEmail.Font = new Font("SuperFrench", 18F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lblEmail.ForeColor = Color.White;
            lblEmail.Image = Properties.Resources._2370744_tecnologia_fundo_com_um_conceito_mecanico_vetor;
            lblEmail.Location = new Point(122, 65);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(67, 24);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = SystemColors.ControlLightLight;
            lblSenha.Font = new Font("SuperFrench", 18F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lblSenha.ForeColor = Color.White;
            lblSenha.Image = Properties.Resources._2370744_tecnologia_fundo_com_um_conceito_mecanico_vetor;
            lblSenha.Location = new Point(122, 169);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(67, 24);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(195, 65);
            txbEmail.Multiline = true;
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(212, 36);
            txbEmail.TabIndex = 2;
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(195, 157);
            txbSenha.Multiline = true;
            txbSenha.Name = "txbSenha";
            txbSenha.Size = new Size(212, 36);
            txbSenha.TabIndex = 3;
            // 
            // btnLogar
            // 
            btnLogar.BackColor = Color.Black;
            btnLogar.Font = new Font("SuperFrench", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnLogar.ForeColor = Color.White;
            btnLogar.Image = Properties.Resources._2370744_tecnologia_fundo_com_um_conceito_mecanico_vetor1;
            btnLogar.Location = new Point(206, 224);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(145, 52);
            btnLogar.TabIndex = 4;
            btnLogar.Text = "Entrar";
            btnLogar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2370744_tecnologia_fundo_com_um_conceito_mecanico_vetor1;
            pictureBox1.Location = new Point(0, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(589, 382);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 312);
            Controls.Add(btnLogar);
            Controls.Add(txbSenha);
            Controls.Add(txbEmail);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlLightLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblSenha;
        private TextBox txbEmail;
        private TextBox txbSenha;
        private Button btnLogar;
        private PictureBox pictureBox1;
    }
}
