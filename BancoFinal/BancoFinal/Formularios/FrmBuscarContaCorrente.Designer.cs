namespace BancoFinal.Formularios
{
    partial class FrmBuscarContaCorrente
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
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.CliCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CliNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CliCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(202, 319);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(180, 30);
            this.btnSelecionar.TabIndex = 4;
            this.btnSelecionar.Text = "[F2] - Selecionar Conta Corrente";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionarCliente_Click);
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
            this.ConSaldo,
            this.ConCodigo});
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(560, 301);
            this.dgv.TabIndex = 5;
            this.dgv.DoubleClick += new System.EventHandler(this.btnSelecionarCliente_Click);
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
            // ConCodigo
            // 
            this.ConCodigo.DataPropertyName = "ConCodigo";
            this.ConCodigo.HeaderText = "Código";
            this.ConCodigo.Name = "ConCodigo";
            this.ConCodigo.ReadOnly = true;
            // 
            // FrmBuscarContaCorrente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnSelecionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscarContaCorrente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Conta Corrente";
            this.Load += new System.EventHandler(this.FrmBuscarCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBuscarCliente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CliCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CliNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CliCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConCodigo;
    }
}