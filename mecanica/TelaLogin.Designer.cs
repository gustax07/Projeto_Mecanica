namespace mecanica
{
    partial class TelaLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            lblLogin = new Label();
            lblEmail = new Label();
            lblSenha = new Label();
            txbEmail = new TextBox();
            txbSenha = new TextBox();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("SuperFrench", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lblLogin.Location = new Point(87, 52);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(101, 38);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(12, 151);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(12, 247);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(45, 20);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(59, 152);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(176, 23);
            txbEmail.TabIndex = 3;
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(59, 244);
            txbSenha.Name = "txbSenha";
            txbSenha.Size = new Size(176, 23);
            txbSenha.TabIndex = 4;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.ActiveBorder;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Monospac821 BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(87, 302);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(124, 43);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(294, 390);
            Controls.Add(btnEntrar);
            Controls.Add(txbSenha);
            Controls.Add(txbEmail);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(lblLogin);
            Font = new Font("SuperFrench", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblEmail;
        private Label lblSenha;
        private TextBox txbEmail;
        private TextBox txbSenha;
        private Button btnEntrar;
    }
}