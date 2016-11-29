using BancoFinal.Entidades;
using BancoFinal.Repositorios;
using System;
using System.Windows.Forms;

namespace BancoFinal.Formularios
{
    public partial class FrmBuscarCliente : Form
    {
        public Cliente ClienteSelecionado { get; private set; } = null;
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();

        public FrmBuscarCliente()
        {
            InitializeComponent();
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

        private void FrmBuscarCliente_Load(object sender, EventArgs e)
        {
            AtualizarDgv();
        }

        private void FrmBuscarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            else if (e.KeyCode == Keys.F2)
                btnSelecionarCliente_Click(sender, e);
        }

        private void btnSelecionarCliente_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0 && dgv.SelectedRows.Count == 1)
            {
                int codigo = -1;
                if (int.TryParse(dgv.SelectedRows[0].Cells["CliCodigo"].Value.ToString(), out codigo) && codigo > -1)
                {
                    try
                    {
                        ClienteSelecionado = clienteRepositorio.BuscarPorCodigo(codigo);
                        this.Close();
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
