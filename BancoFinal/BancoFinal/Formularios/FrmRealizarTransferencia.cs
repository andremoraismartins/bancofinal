using BancoFinal.Entidades;
using BancoFinal.Repositorios;
using BancoFinal.Servicos;
using System;
using System.Windows.Forms;

namespace BancoFinal.Formularios
{
    public partial class FrmRealizarTransferencia : Form
    {
        ContaCorrente contaCorrenteOrigem = null;
        ContaCorrente contaCorrenteDestino = null;
        ContaCorrenteServico contaCorrenteServico = new ContaCorrenteServico();

        public FrmRealizarTransferencia(ContaCorrente contaCorrenteDestino)
        {
            InitializeComponent();
            if (contaCorrenteDestino != null && contaCorrenteDestino.ConCodigo > 0 && contaCorrenteDestino.Cliente != null && contaCorrenteDestino.Cliente.CliCodigo > 0)
            {
                this.contaCorrenteDestino = contaCorrenteDestino;
                txtConCodigoDestino.Text = this.contaCorrenteDestino.ConCodigo.ToString();
                txtConSaldoDestino.Text = this.contaCorrenteDestino.ConSaldo.ToString("C2");
                txtCliCodigoDestino.Text = this.contaCorrenteDestino.Cliente.CliCodigo.ToString();
                txtCliNomeDestino.Text = this.contaCorrenteDestino.Cliente.CliNome;
                mtxtCliCpfDestino.Text = this.contaCorrenteDestino.Cliente.CliCpf;
            }
            else
            {
                MessageBox.Show("Para acessar essa tela é necessário selecionar uma conta corrente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void FrmRealizarTransferencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            else if (e.KeyCode == Keys.F2)
                btnConfirmar_Click(sender, e);
            else if (e.KeyCode == Keys.F3)
                btnBuscarContaCorrente_Click(sender, e);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                contaCorrenteServico.Transferir(contaCorrenteOrigem.ConCodigo, contaCorrenteDestino.ConCodigo, nudValor.Value);

                if (string.IsNullOrEmpty(contaCorrenteServico.Erros))
                {
                    MessageBox.Show("Transferência realizada com sucesso!", "Succeso no depósito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show(contaCorrenteServico.Erros, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnBuscarContaCorrente_Click(object sender, EventArgs e)
        {
            FrmBuscarContaCorrente frm = new FrmBuscarContaCorrente();
            frm.ShowDialog();
            if (frm.ContaCorrenteSelecionado != null)
            {
                if (frm.ContaCorrenteSelecionado.ConCodigo != this.contaCorrenteDestino.ConCodigo)
                {
                    this.contaCorrenteOrigem = frm.ContaCorrenteSelecionado;
                    txtConCodigoOrigem.Text = this.contaCorrenteOrigem.ConCodigo.ToString();
                    txtConSaldoOrigem.Text = this.contaCorrenteOrigem.ConSaldo.ToString("C2");
                    txtCliCodigoOrigem.Text = this.contaCorrenteOrigem.Cliente.CliCodigo.ToString();
                    txtCliNomeOrigem.Text = this.contaCorrenteOrigem.Cliente.CliNome;
                    mtxtCliCpfOrigem.Text = this.contaCorrenteOrigem.Cliente.CliCpf;
                    nudValor.Focus();
                }
                else
                    MessageBox.Show("É necessário selecionar uma conta corrente diferente da conta corrente de destino!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
