using System;
using System.Windows.Forms;

namespace BancoFinal.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarCliente frm = new FrmListarCliente();
            frm.ShowDialog();
        }

        private void contaCorrenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarContaCorrente frm = new FrmListarContaCorrente();
            frm.ShowDialog();
        }
    }
}
