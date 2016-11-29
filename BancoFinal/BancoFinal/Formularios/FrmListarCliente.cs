using BancoFinal.Repositorios;
using BancoFinal.Servicos;
using System;
using System.Windows.Forms;

namespace BancoFinal.Formularios
{
    public partial class FrmListarCliente : Form
    {
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        ClienteServico clienteServico = new ClienteServico();

        public FrmListarCliente()
        {
            InitializeComponent();
        }

        private void FrmListarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                btnNovo_Click(sender, e);
            else if (e.KeyCode == Keys.F3)
                btnAlterar_Click(sender, e);
            else if (e.KeyCode == Keys.F4)
                btnExcluir_Click(sender, e);
        }

        private void AtualizarDgv()
        {
            try
            {
                dgv.DataSource = clienteRepositorio.Listar();
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
                if (int.TryParse(dgv.SelectedRows[0].Cells["CliCodigo"].Value.ToString(), out codigo) && codigo > -1)
                {
                    try
                    {
                        if (MessageBox.Show("Tem certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            clienteRepositorio.Excluir(codigo);
                            MessageBox.Show("Cliente excluído com sucesso!", "Sucesso ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            FrmCadatrarCliente frm = new FrmCadatrarCliente();
            frm.ShowDialog();
            AtualizarDgv();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0 && dgv.SelectedRows.Count == 1)
            {
                int codigo = -1;
                if (int.TryParse(dgv.SelectedRows[0].Cells["CliCodigo"].Value.ToString(), out codigo) && codigo > -1)
                {
                    try
                    {
                        FrmCadatrarCliente frm = new FrmCadatrarCliente(clienteRepositorio.BuscarPorCodigo(codigo));
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
