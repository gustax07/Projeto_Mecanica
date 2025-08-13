namespace mecanica
{
    partial class AdicionarServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarServicos));
            lblTitulo = new Label();
            grbAdicionar = new GroupBox();
            btnAdicionar = new Button();
            txbStatus = new TextBox();
            lblStatus = new Label();
            txbOrcamento = new TextBox();
            lblOrcamento = new Label();
            txbVeiculo = new TextBox();
            lblData = new Label();
            txbData = new TextBox();
            txbNome = new TextBox();
            lblVeiculo = new Label();
            lblNomeServico = new Label();
            grbEdicao = new GroupBox();
            button1 = new Button();
            txbEdtStatus = new TextBox();
            lblEdtStatus = new Label();
            txbEdtOrcamento = new TextBox();
            lblEdtOrcamento = new Label();
            txbEdtVeiculo = new TextBox();
            lblEdtData = new Label();
            txbEdtEntrega = new TextBox();
            txbEdtNome = new TextBox();
            lblEdtVeiculo = new Label();
            lblEdtNome = new Label();
            dataGridView1 = new DataGridView();
            grbAdicionar.SuspendLayout();
            grbEdicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Bernard MT Condensed", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(299, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(250, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Adicionar Serviços";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // grbAdicionar
            // 
            grbAdicionar.Controls.Add(btnAdicionar);
            grbAdicionar.Controls.Add(txbStatus);
            grbAdicionar.Controls.Add(lblStatus);
            grbAdicionar.Controls.Add(txbOrcamento);
            grbAdicionar.Controls.Add(lblOrcamento);
            grbAdicionar.Controls.Add(txbVeiculo);
            grbAdicionar.Controls.Add(lblData);
            grbAdicionar.Controls.Add(txbData);
            grbAdicionar.Controls.Add(txbNome);
            grbAdicionar.Controls.Add(lblVeiculo);
            grbAdicionar.Controls.Add(lblNomeServico);
            grbAdicionar.Location = new Point(35, 113);
            grbAdicionar.Name = "grbAdicionar";
            grbAdicionar.Size = new Size(315, 238);
            grbAdicionar.TabIndex = 1;
            grbAdicionar.TabStop = false;
            grbAdicionar.Text = "Adicionar";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.Black;
            btnAdicionar.ForeColor = SystemColors.ControlLightLight;
            btnAdicionar.Location = new Point(205, 197);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(97, 30);
            btnAdicionar.TabIndex = 10;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txbStatus
            // 
            txbStatus.Location = new Point(136, 168);
            txbStatus.Name = "txbStatus";
            txbStatus.Size = new Size(100, 23);
            txbStatus.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.Location = new Point(72, 168);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 19);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status:";
            // 
            // txbOrcamento
            // 
            txbOrcamento.Location = new Point(136, 136);
            txbOrcamento.Name = "txbOrcamento";
            txbOrcamento.Size = new Size(100, 23);
            txbOrcamento.TabIndex = 7;
            // 
            // lblOrcamento
            // 
            lblOrcamento.AutoSize = true;
            lblOrcamento.Location = new Point(52, 139);
            lblOrcamento.Name = "lblOrcamento";
            lblOrcamento.Size = new Size(70, 15);
            lblOrcamento.TabIndex = 6;
            lblOrcamento.Text = "Orçamento:";
            // 
            // txbVeiculo
            // 
            txbVeiculo.Location = new Point(136, 99);
            txbVeiculo.Name = "txbVeiculo";
            txbVeiculo.Size = new Size(100, 23);
            txbVeiculo.TabIndex = 5;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 10F);
            lblData.Location = new Point(11, 64);
            lblData.Name = "lblData";
            lblData.Size = new Size(111, 19);
            lblData.TabIndex = 4;
            lblData.Text = "Data de entrega:";
            lblData.Click += lblData_Click;
            // 
            // txbData
            // 
            txbData.Location = new Point(136, 64);
            txbData.Name = "txbData";
            txbData.Size = new Size(100, 23);
            txbData.TabIndex = 3;
            // 
            // txbNome
            // 
            txbNome.Location = new Point(136, 28);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(100, 23);
            txbNome.TabIndex = 2;
            // 
            // lblVeiculo
            // 
            lblVeiculo.AutoSize = true;
            lblVeiculo.Font = new Font("Segoe UI", 10F);
            lblVeiculo.Location = new Point(67, 103);
            lblVeiculo.Name = "lblVeiculo";
            lblVeiculo.Size = new Size(55, 19);
            lblVeiculo.TabIndex = 1;
            lblVeiculo.Text = "Veiculo:";
            lblVeiculo.Click += lblVeiculo_Click;
            // 
            // lblNomeServico
            // 
            lblNomeServico.AutoSize = true;
            lblNomeServico.Font = new Font("Segoe UI", 10F);
            lblNomeServico.Location = new Point(6, 28);
            lblNomeServico.Name = "lblNomeServico";
            lblNomeServico.Size = new Size(116, 19);
            lblNomeServico.TabIndex = 0;
            lblNomeServico.Text = "Nome do Serviço:";
            // 
            // grbEdicao
            // 
            grbEdicao.Controls.Add(button1);
            grbEdicao.Controls.Add(txbEdtStatus);
            grbEdicao.Controls.Add(lblEdtStatus);
            grbEdicao.Controls.Add(txbEdtOrcamento);
            grbEdicao.Controls.Add(lblEdtOrcamento);
            grbEdicao.Controls.Add(txbEdtVeiculo);
            grbEdicao.Controls.Add(lblEdtData);
            grbEdicao.Controls.Add(txbEdtEntrega);
            grbEdicao.Controls.Add(txbEdtNome);
            grbEdicao.Controls.Add(lblEdtVeiculo);
            grbEdicao.Controls.Add(lblEdtNome);
            grbEdicao.Location = new Point(460, 113);
            grbEdicao.Name = "grbEdicao";
            grbEdicao.Size = new Size(315, 238);
            grbEdicao.TabIndex = 2;
            grbEdicao.TabStop = false;
            grbEdicao.Text = "Edição";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(205, 197);
            button1.Name = "button1";
            button1.Size = new Size(97, 30);
            button1.TabIndex = 10;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            // 
            // txbEdtStatus
            // 
            txbEdtStatus.Location = new Point(136, 168);
            txbEdtStatus.Name = "txbEdtStatus";
            txbEdtStatus.Size = new Size(100, 23);
            txbEdtStatus.TabIndex = 9;
            // 
            // lblEdtStatus
            // 
            lblEdtStatus.AutoSize = true;
            lblEdtStatus.Font = new Font("Segoe UI", 10F);
            lblEdtStatus.Location = new Point(72, 168);
            lblEdtStatus.Name = "lblEdtStatus";
            lblEdtStatus.Size = new Size(50, 19);
            lblEdtStatus.TabIndex = 8;
            lblEdtStatus.Text = "Status:";
            // 
            // txbEdtOrcamento
            // 
            txbEdtOrcamento.Location = new Point(136, 136);
            txbEdtOrcamento.Name = "txbEdtOrcamento";
            txbEdtOrcamento.Size = new Size(100, 23);
            txbEdtOrcamento.TabIndex = 7;
            // 
            // lblEdtOrcamento
            // 
            lblEdtOrcamento.AutoSize = true;
            lblEdtOrcamento.Location = new Point(52, 139);
            lblEdtOrcamento.Name = "lblEdtOrcamento";
            lblEdtOrcamento.Size = new Size(70, 15);
            lblEdtOrcamento.TabIndex = 6;
            lblEdtOrcamento.Text = "Orçamento:";
            // 
            // txbEdtVeiculo
            // 
            txbEdtVeiculo.Location = new Point(136, 99);
            txbEdtVeiculo.Name = "txbEdtVeiculo";
            txbEdtVeiculo.Size = new Size(100, 23);
            txbEdtVeiculo.TabIndex = 5;
            // 
            // lblEdtData
            // 
            lblEdtData.AutoSize = true;
            lblEdtData.Font = new Font("Segoe UI", 10F);
            lblEdtData.Location = new Point(11, 64);
            lblEdtData.Name = "lblEdtData";
            lblEdtData.Size = new Size(111, 19);
            lblEdtData.TabIndex = 4;
            lblEdtData.Text = "Data de entrega:";
            // 
            // txbEdtEntrega
            // 
            txbEdtEntrega.Location = new Point(136, 64);
            txbEdtEntrega.Name = "txbEdtEntrega";
            txbEdtEntrega.Size = new Size(100, 23);
            txbEdtEntrega.TabIndex = 3;
            // 
            // txbEdtNome
            // 
            txbEdtNome.Location = new Point(136, 28);
            txbEdtNome.Name = "txbEdtNome";
            txbEdtNome.Size = new Size(100, 23);
            txbEdtNome.TabIndex = 2;
            // 
            // lblEdtVeiculo
            // 
            lblEdtVeiculo.AutoSize = true;
            lblEdtVeiculo.Font = new Font("Segoe UI", 10F);
            lblEdtVeiculo.Location = new Point(67, 103);
            lblEdtVeiculo.Name = "lblEdtVeiculo";
            lblEdtVeiculo.Size = new Size(55, 19);
            lblEdtVeiculo.TabIndex = 1;
            lblEdtVeiculo.Text = "Veiculo:";
            // 
            // lblEdtNome
            // 
            lblEdtNome.AutoSize = true;
            lblEdtNome.Font = new Font("Segoe UI", 10F);
            lblEdtNome.Location = new Point(6, 28);
            lblEdtNome.Name = "lblEdtNome";
            lblEdtNome.Size = new Size(116, 19);
            lblEdtNome.TabIndex = 0;
            lblEdtNome.Text = "Nome do Serviço:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 369);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(809, 246);
            dataGridView1.TabIndex = 3;
            // 
            // AdicionarServicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(824, 627);
            Controls.Add(dataGridView1);
            Controls.Add(grbEdicao);
            Controls.Add(grbAdicionar);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdicionarServicos";
            Text = "AdicionarServicos";
            grbAdicionar.ResumeLayout(false);
            grbAdicionar.PerformLayout();
            grbEdicao.ResumeLayout(false);
            grbEdicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox grbAdicionar;
        private Label lblVeiculo;
        private Label lblNomeServico;
        private Label lblData;
        private TextBox txbData;
        private TextBox txbNome;
        private TextBox txbVeiculo;
        private Button btnAdicionar;
        private TextBox txbStatus;
        private Label lblStatus;
        private TextBox txbOrcamento;
        private Label lblOrcamento;
        private GroupBox grbEdicao;
        private Button button1;
        private TextBox txbEdtStatus;
        private Label lblEdtStatus;
        private TextBox txbEdtOrcamento;
        private Label lblEdtOrcamento;
        private TextBox txbEdtVeiculo;
        private Label lblEdtData;
        private TextBox txbEdtEntrega;
        private TextBox txbEdtNome;
        private Label lblEdtVeiculo;
        private Label lblEdtNome;
        private DataGridView dataGridView1;
    }
}