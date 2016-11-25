﻿using BancoFinal.Classes;
using BancoFinal.Repositorios;
using System;
using System.Windows.Forms;

namespace BancoFinal.Formularios
{
    public partial class FrmCadatrarContaCorrente : Form
    {
        ContaCorrenteRepositorio contaCorrenteRepo = new ContaCorrenteRepositorio();
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();

        public FrmCadatrarContaCorrente()
        {
            InitializeComponent();
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
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnCadastrar_Click(sender, e);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int codigo = (!string.IsNullOrEmpty(txtCliCodigo.Text) && int.TryParse(txtCliCodigo.Text, out codigo) && codigo > -1 ? codigo : -1);
            Cliente cliente = clienteRepositorio.BuscarPorCodigo(codigo);
            ContaCorrente contaCorrente = new ContaCorrente(cliente);

            string erros = contaCorrente.Validar();

            if (string.IsNullOrEmpty(erros))
            {
                try
                {
                    contaCorrenteRepo.Adicionar(contaCorrente);
                    MessageBox.Show("Conta corrente adicionada com sucesso!", "Sucesso ao Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ocorreu um erro inesperado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(erros, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente frm = new FrmBuscarCliente();
            frm.ShowDialog();
            if (frm.ClienteSelecionado != null)
            {
                txtCliCodigo.Text = frm.ClienteSelecionado.CliCodigo.ToString();
                txtCliNome.Text = frm.ClienteSelecionado.CliNome;
                mtxtCliCpf.Text = frm.ClienteSelecionado.CliCpf;
            }
        }
    }
}
