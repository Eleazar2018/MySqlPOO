using System;
using System.Windows.Forms;
using SistemaMysql.View;

namespace SistemaMysql
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes form = new frmClientes();
            form.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            frmVendas form = new frmVendas();
            form.Show();
        }
    }
}
