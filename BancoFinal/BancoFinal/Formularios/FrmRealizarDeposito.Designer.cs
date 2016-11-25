namespace BancoFinal.Formularios
{
    partial class FrmRealizarDeposito
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
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliCodigo = new System.Windows.Forms.TextBox();
            this.txtCliNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtCliCpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConSaldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConCodigo = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gpbContaCorrente = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.gpbCliente.SuspendLayout();
            this.gpbContaCorrente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.label1);
            this.gpbCliente.Controls.Add(this.txtCliCodigo);
            this.gpbCliente.Controls.Add(this.txtCliNome);
            this.gpbCliente.Controls.Add(this.label2);
            this.gpbCliente.Controls.Add(this.label3);
            this.gpbCliente.Controls.Add(this.mtxtCliCpf);
            this.gpbCliente.Location = new System.Drawing.Point(10, 110);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(295, 111);
            this.gpbCliente.TabIndex = 61;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // txtCliCodigo
            // 
            this.txtCliCodigo.Location = new System.Drawing.Point(75, 19);
            this.txtCliCodigo.Name = "txtCliCodigo";
            this.txtCliCodigo.ReadOnly = true;
            this.txtCliCodigo.Size = new System.Drawing.Size(211, 20);
            this.txtCliCodigo.TabIndex = 60;
            this.txtCliCodigo.TabStop = false;
            // 
            // txtCliNome
            // 
            this.txtCliNome.Location = new System.Drawing.Point(75, 50);
            this.txtCliNome.Name = "txtCliNome";
            this.txtCliNome.ReadOnly = true;
            this.txtCliNome.Size = new System.Drawing.Size(211, 20);
            this.txtCliNome.TabIndex = 61;
            this.txtCliNome.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF:";
            // 
            // mtxtCliCpf
            // 
            this.mtxtCliCpf.Location = new System.Drawing.Point(75, 81);
            this.mtxtCliCpf.Mask = "000,000,000-00";
            this.mtxtCliCpf.Name = "mtxtCliCpf";
            this.mtxtCliCpf.ReadOnly = true;
            this.mtxtCliCpf.Size = new System.Drawing.Size(211, 20);
            this.mtxtCliCpf.TabIndex = 62;
            this.mtxtCliCpf.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Saldo Atual:";
            // 
            // txtConSaldo
            // 
            this.txtConSaldo.Location = new System.Drawing.Point(75, 50);
            this.txtConSaldo.Name = "txtConSaldo";
            this.txtConSaldo.ReadOnly = true;
            this.txtConSaldo.Size = new System.Drawing.Size(211, 20);
            this.txtConSaldo.TabIndex = 58;
            this.txtConSaldo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Código:";
            // 
            // txtConCodigo
            // 
            this.txtConCodigo.Location = new System.Drawing.Point(75, 19);
            this.txtConCodigo.Name = "txtConCodigo";
            this.txtConCodigo.ReadOnly = true;
            this.txtConCodigo.Size = new System.Drawing.Size(211, 20);
            this.txtConCodigo.TabIndex = 57;
            this.txtConCodigo.TabStop = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(196, 268);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 30);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "[F2] - Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // gpbContaCorrente
            // 
            this.gpbContaCorrente.Controls.Add(this.txtConCodigo);
            this.gpbContaCorrente.Controls.Add(this.label5);
            this.gpbContaCorrente.Controls.Add(this.label4);
            this.gpbContaCorrente.Controls.Add(this.txtConSaldo);
            this.gpbContaCorrente.Location = new System.Drawing.Point(10, 12);
            this.gpbContaCorrente.Name = "gpbContaCorrente";
            this.gpbContaCorrente.Size = new System.Drawing.Size(295, 84);
            this.gpbContaCorrente.TabIndex = 62;
            this.gpbContaCorrente.TabStop = false;
            this.gpbContaCorrente.Text = "Conta Corrente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Valor:";
            // 
            // nudValor
            // 
            this.nudValor.DecimalPlaces = 2;
            this.nudValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudValor.Location = new System.Drawing.Point(85, 235);
            this.nudValor.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(211, 23);
            this.nudValor.TabIndex = 0;
            this.nudValor.Enter += new System.EventHandler(this.nudValor_Enter);
            // 
            // FrmRealizarDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 311);
            this.Controls.Add(this.nudValor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gpbContaCorrente);
            this.Controls.Add(this.gpbCliente);
            this.Controls.Add(this.btnConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRealizarDeposito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Depósito";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRealizarDeposito_KeyDown);
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.gpbContaCorrente.ResumeLayout(false);
            this.gpbContaCorrente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliCodigo;
        private System.Windows.Forms.TextBox txtCliNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtCliCpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConCodigo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox gpbContaCorrente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudValor;
    }
}