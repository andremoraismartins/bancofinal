namespace BancoFinal.Formularios
{
    partial class FrmCadatrarContaCorrente
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
            this.txtCliCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.mtxtCliCpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConSaldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConCodigo = new System.Windows.Forms.TextBox();
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.gpbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCliCodigo
            // 
            this.txtCliCodigo.Location = new System.Drawing.Point(55, 19);
            this.txtCliCodigo.Name = "txtCliCodigo";
            this.txtCliCodigo.ReadOnly = true;
            this.txtCliCodigo.Size = new System.Drawing.Size(211, 20);
            this.txtCliCodigo.TabIndex = 0;
            this.txtCliCodigo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // txtCliNome
            // 
            this.txtCliNome.Location = new System.Drawing.Point(55, 50);
            this.txtCliNome.Name = "txtCliNome";
            this.txtCliNome.ReadOnly = true;
            this.txtCliNome.Size = new System.Drawing.Size(211, 20);
            this.txtCliNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(178, 195);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 30);
            this.btnCadastrar.TabIndex = 50;
            this.btnCadastrar.Text = "[F2] - Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // mtxtCliCpf
            // 
            this.mtxtCliCpf.Location = new System.Drawing.Point(55, 81);
            this.mtxtCliCpf.Mask = "000,000,000-00";
            this.mtxtCliCpf.Name = "mtxtCliCpf";
            this.mtxtCliCpf.ReadOnly = true;
            this.mtxtCliCpf.Size = new System.Drawing.Size(211, 20);
            this.mtxtCliCpf.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Saldo Ini.:";
            // 
            // txtConSaldo
            // 
            this.txtConSaldo.Location = new System.Drawing.Point(67, 43);
            this.txtConSaldo.Name = "txtConSaldo";
            this.txtConSaldo.ReadOnly = true;
            this.txtConSaldo.Size = new System.Drawing.Size(211, 20);
            this.txtConSaldo.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Código:";
            // 
            // txtConCodigo
            // 
            this.txtConCodigo.Location = new System.Drawing.Point(67, 12);
            this.txtConCodigo.Name = "txtConCodigo";
            this.txtConCodigo.ReadOnly = true;
            this.txtConCodigo.Size = new System.Drawing.Size(211, 20);
            this.txtConCodigo.TabIndex = 51;
            this.txtConCodigo.TabStop = false;
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.label1);
            this.gpbCliente.Controls.Add(this.txtCliCodigo);
            this.gpbCliente.Controls.Add(this.txtCliNome);
            this.gpbCliente.Controls.Add(this.label2);
            this.gpbCliente.Controls.Add(this.label3);
            this.gpbCliente.Controls.Add(this.mtxtCliCpf);
            this.gpbCliente.Location = new System.Drawing.Point(12, 78);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(278, 111);
            this.gpbCliente.TabIndex = 55;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(12, 195);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(120, 30);
            this.btnBuscarCliente.TabIndex = 56;
            this.btnBuscarCliente.Text = "[F3] - Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // FrmCadatrarContaCorrente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 236);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.gpbCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConSaldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtConCodigo);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadatrarContaCorrente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadatrar Conta Corrente";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadatrarCliente_KeyDown);
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCliNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox mtxtCliCpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConCodigo;
        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
    }
}