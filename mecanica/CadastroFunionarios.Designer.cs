namespace mecanica
{
    partial class CadastroFunionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFunionarios));
            label1 = new Label();
            lblCadastroNomeFunci = new Label();
            txbNomeFunci = new TextBox();
            txbDataContratacao = new TextBox();
            lblDataContratacao = new Label();
            txbEmail = new TextBox();
            lblEmail = new Label();
            txbSenha = new TextBox();
            lblSenha = new Label();
            btnCadastrar = new Button();
            grbCadastro = new GroupBox();
            grbEditar = new GroupBox();
            btnEditar = new Button();
            txbEditarSenha = new TextBox();
            lblEditarSenha = new Label();
            txbEditarEmail = new TextBox();
            lblEditarEmail = new Label();
            txbEditarContratacao = new TextBox();
            lblEditarContratacao = new Label();
            txbEditarNome = new TextBox();
            lblEditarNome = new Label();
            dgvCadastroFunci = new DataGridView();
            grbEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCadastroFunci).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 20);
            label1.Name = "label1";
            label1.Size = new Size(241, 28);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Funcionário";
            // 
            // lblCadastroNomeFunci
            // 
            lblCadastroNomeFunci.AutoSize = true;
            lblCadastroNomeFunci.Font = new Font("Segoe UI", 12F);
            lblCadastroNomeFunci.Location = new Point(37, 106);
            lblCadastroNomeFunci.Name = "lblCadastroNomeFunci";
            lblCadastroNomeFunci.Size = new Size(125, 21);
            lblCadastroNomeFunci.TabIndex = 1;
            lblCadastroNomeFunci.Text = "Nome completo:";
            // 
            // txbNomeFunci
            // 
            txbNomeFunci.Location = new Point(194, 106);
            txbNomeFunci.Multiline = true;
            txbNomeFunci.Name = "txbNomeFunci";
            txbNomeFunci.Size = new Size(137, 23);
            txbNomeFunci.TabIndex = 2;
            // 
            // txbDataContratacao
            // 
            txbDataContratacao.Location = new Point(194, 150);
            txbDataContratacao.Multiline = true;
            txbDataContratacao.Name = "txbDataContratacao";
            txbDataContratacao.Size = new Size(137, 23);
            txbDataContratacao.TabIndex = 4;
            // 
            // lblDataContratacao
            // 
            lblDataContratacao.AutoSize = true;
            lblDataContratacao.Font = new Font("Segoe UI", 12F);
            lblDataContratacao.Location = new Point(37, 150);
            lblDataContratacao.Name = "lblDataContratacao";
            lblDataContratacao.Size = new Size(151, 21);
            lblDataContratacao.TabIndex = 3;
            lblDataContratacao.Text = "Data de contratação:";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(116, 190);
            txbEmail.Multiline = true;
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(137, 23);
            txbEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(37, 192);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 21);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(116, 228);
            txbSenha.Multiline = true;
            txbSenha.Name = "txbSenha";
            txbSenha.Size = new Size(137, 23);
            txbSenha.TabIndex = 8;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 12F);
            lblSenha.Location = new Point(37, 230);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(56, 21);
            lblSenha.TabIndex = 7;
            lblSenha.Text = "Senha:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(37, 284);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(125, 37);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // grbCadastro
            // 
            grbCadastro.Location = new Point(24, 84);
            grbCadastro.Name = "grbCadastro";
            grbCadastro.Size = new Size(332, 252);
            grbCadastro.TabIndex = 10;
            grbCadastro.TabStop = false;
            grbCadastro.Text = "Cadastro";
            // 
            // grbEditar
            // 
            grbEditar.Controls.Add(btnEditar);
            grbEditar.Controls.Add(txbEditarSenha);
            grbEditar.Controls.Add(lblEditarSenha);
            grbEditar.Controls.Add(txbEditarEmail);
            grbEditar.Controls.Add(lblEditarEmail);
            grbEditar.Controls.Add(txbEditarContratacao);
            grbEditar.Controls.Add(lblEditarContratacao);
            grbEditar.Controls.Add(txbEditarNome);
            grbEditar.Controls.Add(lblEditarNome);
            grbEditar.Location = new Point(24, 392);
            grbEditar.Name = "grbEditar";
            grbEditar.Size = new Size(332, 274);
            grbEditar.TabIndex = 11;
            grbEditar.TabStop = false;
            grbEditar.Text = "Edição";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(13, 222);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(125, 37);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txbEditarSenha
            // 
            txbEditarSenha.Location = new Point(92, 173);
            txbEditarSenha.Multiline = true;
            txbEditarSenha.Name = "txbEditarSenha";
            txbEditarSenha.Size = new Size(137, 23);
            txbEditarSenha.TabIndex = 10;
            // 
            // lblEditarSenha
            // 
            lblEditarSenha.AutoSize = true;
            lblEditarSenha.Font = new Font("Segoe UI", 12F);
            lblEditarSenha.Location = new Point(13, 175);
            lblEditarSenha.Name = "lblEditarSenha";
            lblEditarSenha.Size = new Size(56, 21);
            lblEditarSenha.TabIndex = 9;
            lblEditarSenha.Text = "Senha:";
            // 
            // txbEditarEmail
            // 
            txbEditarEmail.Location = new Point(92, 130);
            txbEditarEmail.Multiline = true;
            txbEditarEmail.Name = "txbEditarEmail";
            txbEditarEmail.Size = new Size(137, 23);
            txbEditarEmail.TabIndex = 8;
            // 
            // lblEditarEmail
            // 
            lblEditarEmail.AutoSize = true;
            lblEditarEmail.Font = new Font("Segoe UI", 12F);
            lblEditarEmail.Location = new Point(13, 132);
            lblEditarEmail.Name = "lblEditarEmail";
            lblEditarEmail.Size = new Size(51, 21);
            lblEditarEmail.TabIndex = 7;
            lblEditarEmail.Text = "Email:";
            // 
            // txbEditarContratacao
            // 
            txbEditarContratacao.Location = new Point(170, 89);
            txbEditarContratacao.Multiline = true;
            txbEditarContratacao.Name = "txbEditarContratacao";
            txbEditarContratacao.Size = new Size(137, 23);
            txbEditarContratacao.TabIndex = 6;
            // 
            // lblEditarContratacao
            // 
            lblEditarContratacao.AutoSize = true;
            lblEditarContratacao.Font = new Font("Segoe UI", 12F);
            lblEditarContratacao.Location = new Point(13, 89);
            lblEditarContratacao.Name = "lblEditarContratacao";
            lblEditarContratacao.Size = new Size(151, 21);
            lblEditarContratacao.TabIndex = 5;
            lblEditarContratacao.Text = "Data de contratação:";
            // 
            // txbEditarNome
            // 
            txbEditarNome.Location = new Point(170, 47);
            txbEditarNome.Multiline = true;
            txbEditarNome.Name = "txbEditarNome";
            txbEditarNome.Size = new Size(137, 23);
            txbEditarNome.TabIndex = 4;
            // 
            // lblEditarNome
            // 
            lblEditarNome.AutoSize = true;
            lblEditarNome.Font = new Font("Segoe UI", 12F);
            lblEditarNome.Location = new Point(13, 47);
            lblEditarNome.Name = "lblEditarNome";
            lblEditarNome.Size = new Size(125, 21);
            lblEditarNome.TabIndex = 3;
            lblEditarNome.Text = "Nome completo:";
            // 
            // dgvCadastroFunci
            // 
            dgvCadastroFunci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCadastroFunci.Location = new Point(380, 84);
            dgvCadastroFunci.Name = "dgvCadastroFunci";
            dgvCadastroFunci.Size = new Size(524, 609);
            dgvCadastroFunci.TabIndex = 12;
            dgvCadastroFunci.CellClick += dgvCadastroFunci_CellClick;
            // 
            // CadastroFunionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(916, 727);
            Controls.Add(dgvCadastroFunci);
            Controls.Add(btnCadastrar);
            Controls.Add(txbSenha);
            Controls.Add(lblSenha);
            Controls.Add(txbEmail);
            Controls.Add(lblEmail);
            Controls.Add(txbDataContratacao);
            Controls.Add(lblDataContratacao);
            Controls.Add(txbNomeFunci);
            Controls.Add(lblCadastroNomeFunci);
            Controls.Add(label1);
            Controls.Add(grbCadastro);
            Controls.Add(grbEditar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastroFunionarios";
            Text = "CadastroFunionarios";
            grbEditar.ResumeLayout(false);
            grbEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCadastroFunci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCadastroNomeFunci;
        private TextBox txbNomeFunci;
        private TextBox txbDataContratacao;
        private Label lblDataContratacao;
        private TextBox txbEmail;
        private Label lblEmail;
        private TextBox txbSenha;
        private Label lblSenha;
        private Button btnCadastrar;
        private GroupBox grbCadastro;
        private GroupBox grbEditar;
        private TextBox txbEditarNome;
        private Label lblEditarNome;
        private TextBox txbEditarSenha;
        private Label lblEditarSenha;
        private TextBox txbEditarEmail;
        private Label lblEditarEmail;
        private TextBox txbEditarContratacao;
        private Label lblEditarContratacao;
        private DataGridView dgvCadastroFunci;
        private Button btnEditar;
    }
}