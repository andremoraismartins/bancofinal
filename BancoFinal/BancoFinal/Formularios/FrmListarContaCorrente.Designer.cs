namespace BancoFinal.Formularios
{
    partial class FrmListarContaCorrente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnRealizarSaque = new System.Windows.Forms.Button();
            this.btnRealizarDeposito = new System.Windows.Forms.Button();
            this.btnRealizarTransferencia = new System.Windows.Forms.Button();
            this.CliCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CliNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CliCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CliCodigo,
            this.CliNome,
            this.CliCpf,
            this.ConCodigo,
            this.ConSaldo});
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(560, 301);
            this.dgv.TabIndex = 0;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(61, 320);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(150, 30);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "[F2] - Nova Conta Corrente";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(373, 320);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(150, 30);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "[F4] - Excluir Conta Corrente";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnRealizarSaque
            // 
            this.btnRealizarSaque.Location = new System.Drawing.Point(61, 356);
            this.btnRealizarSaque.Name = "btnRealizarSaque";
            this.btnRealizarSaque.Size = new System.Drawing.Size(150, 30);
            this.btnRealizarSaque.TabIndex = 4;
            this.btnRealizarSaque.Text = "[F5] - Realizar Saque";
            this.btnRealizarSaque.UseVisualStyleBackColor = true;
            this.btnRealizarSaque.Click += new System.EventHandler(this.btnRealizarSaque_Click);
            // 
            // btnRealizarDeposito
            // 
            this.btnRealizarDeposito.Location = new System.Drawing.Point(217, 356);
            this.btnRealizarDeposito.Name = "btnRealizarDeposito";
            this.btnRealizarDeposito.Size = new System.Drawing.Size(150, 30);
            this.btnRealizarDeposito.TabIndex = 5;
            this.btnRealizarDeposito.Text = "[F6] - Realizar Depósito";
            this.btnRealizarDeposito.UseVisualStyleBackColor = true;
            this.btnRealizarDeposito.Click += new System.EventHandler(this.btnRealizarDeposito_Click);
            // 
            // btnRealizarTransferencia
            // 
            this.btnRealizarTransferencia.Location = new System.Drawing.Point(373, 356);
            this.btnRealizarTransferencia.Name = "btnRealizarTransferencia";
            this.btnRealizarTransferencia.Size = new System.Drawing.Size(150, 30);
            this.btnRealizarTransferencia.TabIndex = 6;
            this.btnRealizarTransferencia.Text = "[F7] - Realizar Transferência";
            this.btnRealizarTransferencia.UseVisualStyleBackColor = true;
            this.btnRealizarTransferencia.Click += new System.EventHandler(this.btnRealizarTransferencia_Click);
            // 
            // CliCodigo
            // 
            this.CliCodigo.DataPropertyName = "CliCodigo";
            this.CliCodigo.HeaderText = "Cód. Cliente";
            this.CliCodigo.Name = "CliCodigo";
            this.CliCodigo.ReadOnly = true;
            // 
            // CliNome
            // 
            this.CliNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CliNome.DataPropertyName = "CliNome";
            this.CliNome.HeaderText = "Nome";
            this.CliNome.Name = "CliNome";
            this.CliNome.ReadOnly = true;
            // 
            // CliCpf
            // 
            this.CliCpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CliCpf.DataPropertyName = "CliCpf";
            this.CliCpf.HeaderText = "CPF";
            this.CliCpf.Name = "CliCpf";
            this.CliCpf.ReadOnly = true;
            this.CliCpf.Width = 52;
            // 
            // ConCodigo
            // 
            this.ConCodigo.DataPropertyName = "ConCodigo";
            this.ConCodigo.HeaderText = "Código";
            this.ConCodigo.Name = "ConCodigo";
            this.ConCodigo.ReadOnly = true;
            // 
            // ConSaldo
            // 
            this.ConSaldo.DataPropertyName = "ConSaldo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.ConSaldo.DefaultCellStyle = dataGridViewCellStyle2;
            this.ConSaldo.HeaderText = "Saldo";
            this.ConSaldo.Name = "ConSaldo";
            this.ConSaldo.ReadOnly = true;
            // 
            // FrmListarContaCorrente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 397);
            this.Controls.Add(this.btnRealizarTransferencia);
            this.Controls.Add(this.btnRealizarDeposito);
            this.Controls.Add(this.btnRealizarSaque);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgv);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListarContaCorrente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Clientes";
            this.Load += new System.EventHandler(this.FrmListarCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmListarCliente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnRealizarSaque;
        private System.Windows.Forms.Button btnRealizarDeposito;
        private System.Windows.Forms.Button btnRealizarTransferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CliCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CliNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CliCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConSaldo;
    }
}