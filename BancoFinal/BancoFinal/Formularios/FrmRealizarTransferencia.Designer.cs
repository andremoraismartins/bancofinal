namespace BancoFinal.Formularios
{
    partial class FrmRealizarTransferencia
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
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.gpbContaCorrenteOrigem = new System.Windows.Forms.GroupBox();
            this.txtConCodigoOrigem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConSaldoOrigem = new System.Windows.Forms.TextBox();
            this.gpbClienteOrigem = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliCodigoOrigem = new System.Windows.Forms.TextBox();
            this.txtCliNomeOrigem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtCliCpfOrigem = new System.Windows.Forms.MaskedTextBox();
            this.gpbContaCorrenteDestino = new System.Windows.Forms.GroupBox();
            this.txtConCodigoDestino = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConSaldoDestino = new System.Windows.Forms.TextBox();
            this.gpbClienteDestino = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCliCodigoDestino = new System.Windows.Forms.TextBox();
            this.txtCliNomeDestino = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mtxtCliCpfDestino = new System.Windows.Forms.MaskedTextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnBuscarContaCorrente = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            this.gpbContaCorrenteOrigem.SuspendLayout();
            this.gpbClienteOrigem.SuspendLayout();
            this.gpbContaCorrenteDestino.SuspendLayout();
            this.gpbClienteDestino.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudValor
            // 
            this.nudValor.DecimalPlaces = 2;
            this.nudValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudValor.Location = new System.Drawing.Point(385, 257);
            this.nudValor.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(141, 23);
            this.nudValor.TabIndex = 10;
            this.nudValor.Enter += new System.EventHandler(this.nudValor_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "Valor:";
            // 
            // gpbContaCorrenteOrigem
            // 
            this.gpbContaCorrenteOrigem.Controls.Add(this.txtConCodigoOrigem);
            this.gpbContaCorrenteOrigem.Controls.Add(this.label5);
            this.gpbContaCorrenteOrigem.Controls.Add(this.label4);
            this.gpbContaCorrenteOrigem.Controls.Add(this.txtConSaldoOrigem);
            this.gpbContaCorrenteOrigem.Location = new System.Drawing.Point(12, 36);
            this.gpbContaCorrenteOrigem.Name = "gpbContaCorrenteOrigem";
            this.gpbContaCorrenteOrigem.Size = new System.Drawing.Size(295, 84);
            this.gpbContaCorrenteOrigem.TabIndex = 67;
            this.gpbContaCorrenteOrigem.TabStop = false;
            this.gpbContaCorrenteOrigem.Text = "Conta Corrente";
            // 
            // txtConCodigoOrigem
            // 
            this.txtConCodigoOrigem.Location = new System.Drawing.Point(75, 19);
            this.txtConCodigoOrigem.Name = "txtConCodigoOrigem";
            this.txtConCodigoOrigem.ReadOnly = true;
            this.txtConCodigoOrigem.Size = new System.Drawing.Size(211, 20);
            this.txtConCodigoOrigem.TabIndex = 57;
            this.txtConCodigoOrigem.TabStop = false;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Saldo Atual:";
            // 
            // txtConSaldoOrigem
            // 
            this.txtConSaldoOrigem.Location = new System.Drawing.Point(75, 50);
            this.txtConSaldoOrigem.Name = "txtConSaldoOrigem";
            this.txtConSaldoOrigem.ReadOnly = true;
            this.txtConSaldoOrigem.Size = new System.Drawing.Size(211, 20);
            this.txtConSaldoOrigem.TabIndex = 58;
            this.txtConSaldoOrigem.TabStop = false;
            // 
            // gpbClienteOrigem
            // 
            this.gpbClienteOrigem.Controls.Add(this.label1);
            this.gpbClienteOrigem.Controls.Add(this.txtCliCodigoOrigem);
            this.gpbClienteOrigem.Controls.Add(this.txtCliNomeOrigem);
            this.gpbClienteOrigem.Controls.Add(this.label2);
            this.gpbClienteOrigem.Controls.Add(this.label3);
            this.gpbClienteOrigem.Controls.Add(this.mtxtCliCpfOrigem);
            this.gpbClienteOrigem.Location = new System.Drawing.Point(12, 134);
            this.gpbClienteOrigem.Name = "gpbClienteOrigem";
            this.gpbClienteOrigem.Size = new System.Drawing.Size(295, 111);
            this.gpbClienteOrigem.TabIndex = 66;
            this.gpbClienteOrigem.TabStop = false;
            this.gpbClienteOrigem.Text = "Cliente";
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
            // txtCliCodigoOrigem
            // 
            this.txtCliCodigoOrigem.Location = new System.Drawing.Point(75, 19);
            this.txtCliCodigoOrigem.Name = "txtCliCodigoOrigem";
            this.txtCliCodigoOrigem.ReadOnly = true;
            this.txtCliCodigoOrigem.Size = new System.Drawing.Size(211, 20);
            this.txtCliCodigoOrigem.TabIndex = 60;
            this.txtCliCodigoOrigem.TabStop = false;
            // 
            // txtCliNomeOrigem
            // 
            this.txtCliNomeOrigem.Location = new System.Drawing.Point(75, 50);
            this.txtCliNomeOrigem.Name = "txtCliNomeOrigem";
            this.txtCliNomeOrigem.ReadOnly = true;
            this.txtCliNomeOrigem.Size = new System.Drawing.Size(211, 20);
            this.txtCliNomeOrigem.TabIndex = 61;
            this.txtCliNomeOrigem.TabStop = false;
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
            // mtxtCliCpfOrigem
            // 
            this.mtxtCliCpfOrigem.Location = new System.Drawing.Point(75, 81);
            this.mtxtCliCpfOrigem.Mask = "000,000,000-00";
            this.mtxtCliCpfOrigem.Name = "mtxtCliCpfOrigem";
            this.mtxtCliCpfOrigem.ReadOnly = true;
            this.mtxtCliCpfOrigem.Size = new System.Drawing.Size(211, 20);
            this.mtxtCliCpfOrigem.TabIndex = 62;
            this.mtxtCliCpfOrigem.TabStop = false;
            // 
            // gpbContaCorrenteDestino
            // 
            this.gpbContaCorrenteDestino.Controls.Add(this.txtConCodigoDestino);
            this.gpbContaCorrenteDestino.Controls.Add(this.label8);
            this.gpbContaCorrenteDestino.Controls.Add(this.label9);
            this.gpbContaCorrenteDestino.Controls.Add(this.txtConSaldoDestino);
            this.gpbContaCorrenteDestino.Location = new System.Drawing.Point(337, 36);
            this.gpbContaCorrenteDestino.Name = "gpbContaCorrenteDestino";
            this.gpbContaCorrenteDestino.Size = new System.Drawing.Size(295, 84);
            this.gpbContaCorrenteDestino.TabIndex = 72;
            this.gpbContaCorrenteDestino.TabStop = false;
            this.gpbContaCorrenteDestino.Text = "Conta Corrente";
            // 
            // txtConCodigoDestino
            // 
            this.txtConCodigoDestino.Location = new System.Drawing.Point(75, 19);
            this.txtConCodigoDestino.Name = "txtConCodigoDestino";
            this.txtConCodigoDestino.ReadOnly = true;
            this.txtConCodigoDestino.Size = new System.Drawing.Size(211, 20);
            this.txtConCodigoDestino.TabIndex = 57;
            this.txtConCodigoDestino.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Código:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Saldo Atual:";
            // 
            // txtConSaldoDestino
            // 
            this.txtConSaldoDestino.Location = new System.Drawing.Point(75, 50);
            this.txtConSaldoDestino.Name = "txtConSaldoDestino";
            this.txtConSaldoDestino.ReadOnly = true;
            this.txtConSaldoDestino.Size = new System.Drawing.Size(211, 20);
            this.txtConSaldoDestino.TabIndex = 58;
            this.txtConSaldoDestino.TabStop = false;
            // 
            // gpbClienteDestino
            // 
            this.gpbClienteDestino.Controls.Add(this.label10);
            this.gpbClienteDestino.Controls.Add(this.txtCliCodigoDestino);
            this.gpbClienteDestino.Controls.Add(this.txtCliNomeDestino);
            this.gpbClienteDestino.Controls.Add(this.label11);
            this.gpbClienteDestino.Controls.Add(this.label12);
            this.gpbClienteDestino.Controls.Add(this.mtxtCliCpfDestino);
            this.gpbClienteDestino.Location = new System.Drawing.Point(337, 134);
            this.gpbClienteDestino.Name = "gpbClienteDestino";
            this.gpbClienteDestino.Size = new System.Drawing.Size(295, 111);
            this.gpbClienteDestino.TabIndex = 71;
            this.gpbClienteDestino.TabStop = false;
            this.gpbClienteDestino.Text = "Cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Código:";
            // 
            // txtCliCodigoDestino
            // 
            this.txtCliCodigoDestino.Location = new System.Drawing.Point(75, 19);
            this.txtCliCodigoDestino.Name = "txtCliCodigoDestino";
            this.txtCliCodigoDestino.ReadOnly = true;
            this.txtCliCodigoDestino.Size = new System.Drawing.Size(211, 20);
            this.txtCliCodigoDestino.TabIndex = 60;
            this.txtCliCodigoDestino.TabStop = false;
            // 
            // txtCliNomeDestino
            // 
            this.txtCliNomeDestino.Location = new System.Drawing.Point(75, 50);
            this.txtCliNomeDestino.Name = "txtCliNomeDestino";
            this.txtCliNomeDestino.ReadOnly = true;
            this.txtCliNomeDestino.Size = new System.Drawing.Size(211, 20);
            this.txtCliNomeDestino.TabIndex = 61;
            this.txtCliNomeDestino.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Nome:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "CPF:";
            // 
            // mtxtCliCpfDestino
            // 
            this.mtxtCliCpfDestino.Location = new System.Drawing.Point(75, 81);
            this.mtxtCliCpfDestino.Mask = "000,000,000-00";
            this.mtxtCliCpfDestino.Name = "mtxtCliCpfDestino";
            this.mtxtCliCpfDestino.ReadOnly = true;
            this.mtxtCliCpfDestino.Size = new System.Drawing.Size(211, 20);
            this.mtxtCliCpfDestino.TabIndex = 62;
            this.mtxtCliCpfDestino.TabStop = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(532, 252);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 30);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.Text = "[F2] - Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnBuscarContaCorrente
            // 
            this.btnBuscarContaCorrente.Location = new System.Drawing.Point(157, 252);
            this.btnBuscarContaCorrente.Name = "btnBuscarContaCorrente";
            this.btnBuscarContaCorrente.Size = new System.Drawing.Size(150, 30);
            this.btnBuscarContaCorrente.TabIndex = 0;
            this.btnBuscarContaCorrente.Text = "[F3] - Buscar Conta Corrente";
            this.btnBuscarContaCorrente.UseVisualStyleBackColor = true;
            this.btnBuscarContaCorrente.Click += new System.EventHandler(this.btnBuscarContaCorrente_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "Origem:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(341, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 74;
            this.label13.Text = "Destino:";
            // 
            // FrmRealizarTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 291);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscarContaCorrente);
            this.Controls.Add(this.gpbContaCorrenteDestino);
            this.Controls.Add(this.gpbClienteDestino);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.nudValor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gpbContaCorrenteOrigem);
            this.Controls.Add(this.gpbClienteOrigem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRealizarTransferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Transferência";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRealizarTransferencia_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            this.gpbContaCorrenteOrigem.ResumeLayout(false);
            this.gpbContaCorrenteOrigem.PerformLayout();
            this.gpbClienteOrigem.ResumeLayout(false);
            this.gpbClienteOrigem.PerformLayout();
            this.gpbContaCorrenteDestino.ResumeLayout(false);
            this.gpbContaCorrenteDestino.PerformLayout();
            this.gpbClienteDestino.ResumeLayout(false);
            this.gpbClienteDestino.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gpbContaCorrenteOrigem;
        private System.Windows.Forms.TextBox txtConCodigoOrigem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConSaldoOrigem;
        private System.Windows.Forms.GroupBox gpbClienteOrigem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliCodigoOrigem;
        private System.Windows.Forms.TextBox txtCliNomeOrigem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtCliCpfOrigem;
        private System.Windows.Forms.GroupBox gpbContaCorrenteDestino;
        private System.Windows.Forms.TextBox txtConCodigoDestino;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtConSaldoDestino;
        private System.Windows.Forms.GroupBox gpbClienteDestino;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCliCodigoDestino;
        private System.Windows.Forms.TextBox txtCliNomeDestino;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mtxtCliCpfDestino;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnBuscarContaCorrente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
    }
}