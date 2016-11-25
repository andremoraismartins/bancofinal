using BancoFinal.Classes;
using BancoFinal.Repositorios;
using System;
using System.Windows.Forms;

namespace BancoFinal.Formularios
{
    public partial class FrmRealizarDeposito : Form
    {
        ContaCorrente contaCorrente = null;
        ContaCorrenteRepositorio contaCorrenteRepositorio = new ContaCorrenteRepositorio();

        public FrmRealizarDeposito(ContaCorrente contaCorrente)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(contaCorrente.Validar()))
            {
                this.contaCorrente = contaCorrente;
                txtConCodigo.Text = this.contaCorrente.ConCodigo.ToString();
                txtConSaldo.Text = this.contaCorrente.ConSaldo.ToString("C2");
                txtCliCodigo.Text = this.contaCorrente.Cliente.CliCodigo.ToString();
                txtCliNome.Text = this.contaCorrente.Cliente.CliNome;
                mtxtCliCpf.Text = this.contaCorrente.Cliente.CliCpf;
            }
            else
            {
                MessageBox.Show("Para acessar essa tela é necessário selecionar uma conta corrente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void FrmRealizarDeposito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnConfirmar_Click(sender, e);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            contaCorrente.Depositar(nudValor.Value);

            try
            {
                contaCorrenteRepositorio.Alterar(contaCorrente.ConCodigo, contaCorrente);
                MessageBox.Show("Depósito realizado com sucesso!", "Succeso no depósito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro inesperado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void nudValor_Enter(object sender, EventArgs e)
        {
            nudValor.Select(0, nudValor.Maximum.ToString("N2").Length);
        }
    }
}
