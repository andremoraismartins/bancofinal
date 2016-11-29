using BancoFinal.Repositorios;
using BancoFinal.Servicos;
using System;
using System.Windows.Forms;

namespace BancoFinal.Formularios
{
    public partial class FrmListarContaCorrente : Form
    {
        ContaCorrenteRepositorio contaCorrenteRepositorio = new ContaCorrenteRepositorio();
        ContaCorrenteServico contaCorrenteServico = new ContaCorrenteServico();

        public FrmListarContaCorrente()
        {
            InitializeComponent();
        }

        private void FrmListarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                btnNovo_Click(sender, e);
            else if (e.KeyCode == Keys.F4)
                btnExcluir_Click(sender, e);
            else if (e.KeyCode == Keys.F5)
                btnRealizarSaque_Click(sender, e);
            else if (e.KeyCode == Keys.F6)
                btnRealizarDeposito_Click(sender, e);
            else if (e.KeyCode == Keys.F7)
                btnRealizarTransferencia_Click(sender, e);
        }

        private void AtualizarDgv()
        {
            try
            {
                dgv.DataSource = contaCorrenteRepositorio.ListarCompleto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro inesperado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void FrmListarCliente_Load(object sender, EventArgs e)
        {
            AtualizarDgv();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0 && dgv.SelectedRows.Count == 1)
            {
                int codigo = -1;
                if (int.TryParse(dgv.SelectedRows[0].Cells["ConCodigo"].Value.ToString(), out codigo) && codigo > -1)
                {
                    try
                    {
                        if (MessageBox.Show("Tem certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            contaCorrenteRepositorio.Excluir(codigo);
                            MessageBox.Show("Conta corrente excluída com sucesso!", "Sucesso ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AtualizarDgv();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ocorreu um erro inesperado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Não foi possível encontrar o código do registro selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Não existe nenhum registro selecionado na tabela!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadatrarContaCorrente frm = new FrmCadatrarContaCorrente();
            frm.ShowDialog();
            AtualizarDgv();
        }

        private void btnRealizarSaque_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0 && dgv.SelectedRows.Count == 1)
            {
                int codigo = -1;
                if (int.TryParse(dgv.SelectedRows[0].Cells["ConCodigo"].Value.ToString(), out codigo) && codigo > -1)
                {
                    try
                    {
                        FrmRealizarSaque frm = new FrmRealizarSaque(contaCorrenteRepositorio.BuscarPorCodigo(codigo));
                        if (!frm.IsDisposed)
                            frm.ShowDialog();
                        AtualizarDgv();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ocorreu um erro inesperado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Não foi possível encontrar o código do registro selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Não existe nenhum registro selecionado na tabela!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRealizarDeposito_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0 && dgv.SelectedRows.Count == 1)
            {
                int codigo = -1;
                if (int.TryParse(dgv.SelectedRows[0].Cells["ConCodigo"].Value.ToString(), out codigo) && codigo > -1)
                {
                    try
                    {
                        FrmRealizarDeposito frm = new FrmRealizarDeposito(contaCorrenteRepositorio.BuscarPorCodigo(codigo));
                        if (!frm.IsDisposed)
                            frm.ShowDialog();
                        AtualizarDgv();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ocorreu um erro inesperado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Não foi possível encontrar o código do registro selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Não existe nenhum registro selecionado na tabela!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRealizarTransferencia_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0 && dgv.SelectedRows.Count == 1)
            {
                int codigo = -1;
                if (int.TryParse(dgv.SelectedRows[0].Cells["ConCodigo"].Value.ToString(), out codigo) && codigo > -1)
                {
                    try
                    {
                        FrmRealizarTransferencia frm = new FrmRealizarTransferencia(contaCorrenteRepositorio.BuscarPorCodigo(codigo));
                        if (!frm.IsDisposed)
                            frm.ShowDialog();
                        AtualizarDgv();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ocorreu um erro inesperado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Não foi possível encontrar o código do registro selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Não existe nenhum registro selecionado na tabela!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
