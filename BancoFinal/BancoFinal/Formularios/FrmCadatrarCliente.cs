using BancoFinal.Entidades;
using BancoFinal.Servicos;
using System;
using System.Windows.Forms;

namespace BancoFinal.Formularios
{
    public partial class FrmCadatrarCliente : Form
    {
        Cliente clienteAlterar = null;
        ClienteServico clienteServico = new ClienteServico();

        public FrmCadatrarCliente()
        {
            InitializeComponent();
        }

        public FrmCadatrarCliente(Cliente cliente)
        {
            InitializeComponent();
            if (cliente != null)
            {
                this.clienteAlterar = cliente;
                this.Text = "Alterar Cliente";
                btnCadastrar.Text = "[F2] - Salvar";
                txtCliCodigo.Text = cliente.CliCodigo.ToString();
                txtCliNome.Text = cliente.CliNome;
                mtxtCliCpf.Text = cliente.CliCpf;
            }
            else
            {
                MessageBox.Show("Para acessar essa tela é necessário selecionar um cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Limpar()
        {
            txtCliCodigo.Clear();
            txtCliNome.Clear();
            mtxtCliCpf.Clear();
        }

        private void FrmCadatrarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            else if (e.KeyCode == Keys.F2)
                btnCadastrar_Click(sender, e);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int codigo = -1;
            Cliente cliente = new Cliente()
            {
                CliCodigo = (int.TryParse(txtCliCodigo.Text, out codigo) && codigo > -1 ? codigo : -1),
                CliCpf = mtxtCliCpf.Text,
                CliNome = txtCliNome.Text
            };

            try
            {
                if (this.clienteAlterar == null)
                {
                    clienteServico.Adicionar(cliente);

                    if (string.IsNullOrEmpty(clienteServico.Erros))
                    {
                        MessageBox.Show("Cliente adicionado com sucesso!", "Sucesso ao Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                        this.Close();
                    }
                    else
                        MessageBox.Show(clienteServico.Erros, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    clienteServico.Alterar(cliente.CliCodigo, cliente);

                    if (string.IsNullOrEmpty(clienteServico.Erros))
                    {
                        MessageBox.Show("Cliente alterado com sucesso!", "Sucesso ao alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                        this.Close();
                    }
                    else
                        MessageBox.Show(clienteServico.Erros, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro inesperado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
