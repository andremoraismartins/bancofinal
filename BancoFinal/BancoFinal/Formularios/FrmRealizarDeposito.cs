using BancoFinal.Entidades;
using BancoFinal.Servicos;
using System;
using System.Windows.Forms;

namespace BancoFinal.Formularios
{
    public partial class FrmRealizarDeposito : Form
    {
        ContaCorrente contaCorrente = null;
        ContaCorrenteServico contaCorrenteServico = new ContaCorrenteServico();

        public FrmRealizarDeposito(ContaCorrente contaCorrente)
        {
            InitializeComponent();
            if (contaCorrente != null && contaCorrente.ConCodigo > 0 && contaCorrente.Cliente != null && contaCorrente.Cliente.CliCodigo > 0)
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
                MessageBox.Show("Para acessar essa tela é necessário selecionar uma conta corrente válida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void FrmRealizarDeposito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            else if (e.KeyCode == Keys.F2)
                btnConfirmar_Click(sender, e);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                contaCorrenteServico.Depositar(contaCorrente.ConCodigo, nudValor.Value);

                if (string.IsNullOrEmpty(contaCorrenteServico.Erros))
                {
                    MessageBox.Show("Depósito realizado com sucesso!", "Succeso no depósito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(contaCorrenteServico.Erros, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
