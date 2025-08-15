namespace mecanica
{
    partial class HistoricoCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoricoCompras));
            dgvHistoricoCompra = new DataGridView();
            pibCompras = new PictureBox();
            btnAtualizarDgvCompras = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pibCompras).BeginInit();
            SuspendLayout();
            // 
            // dgvHistoricoCompra
            // 
            dgvHistoricoCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricoCompra.Location = new Point(22, 12);
            dgvHistoricoCompra.Name = "dgvHistoricoCompra";
            dgvHistoricoCompra.Size = new Size(524, 533);
            dgvHistoricoCompra.TabIndex = 13;
            // 
            // pibCompras
            // 
            pibCompras.Image = (Image)resources.GetObject("pibCompras.Image");
            pibCompras.Location = new Point(570, 12);
            pibCompras.Name = "pibCompras";
            pibCompras.Size = new Size(282, 267);
            pibCompras.SizeMode = PictureBoxSizeMode.Zoom;
            pibCompras.TabIndex = 14;
            pibCompras.TabStop = false;
            // 
            // btnAtualizarDgvCompras
            // 
            btnAtualizarDgvCompras.FlatStyle = FlatStyle.Flat;
            btnAtualizarDgvCompras.ForeColor = SystemColors.ControlLight;
            btnAtualizarDgvCompras.Location = new Point(585, 498);
            btnAtualizarDgvCompras.Name = "btnAtualizarDgvCompras";
            btnAtualizarDgvCompras.Size = new Size(248, 47);
            btnAtualizarDgvCompras.TabIndex = 15;
            btnAtualizarDgvCompras.Text = "Atualizar";
            btnAtualizarDgvCompras.UseVisualStyleBackColor = true;
            // 
            // HistoricoCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(898, 568);
            Controls.Add(btnAtualizarDgvCompras);
            Controls.Add(pibCompras);
            Controls.Add(dgvHistoricoCompra);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HistoricoCompras";
            Text = "Historico De Compras";
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pibCompras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHistoricoCompra;
        private PictureBox pibCompras;
        private Button btnAtualizarDgvCompras;
    }
}