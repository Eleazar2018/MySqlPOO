using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMysql.View
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        bool VerSenhaTxt = false;

        public frmLogin()
        {
            InitializeComponent();
        }
        public frmLogin(string txtEmail)
        {
            InitializeComponent();
            txtEmail2.Text = txtEmail;
        }
        public frmLogin(string txtEmail, string txt_Senha)
        {
            InitializeComponent();
            txtEmail2.Text = txtEmail;
            txt_Senha2.Text = txt_Senha;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmail2.Text == "")
            {
                MessageBox.Show("Preencha o campo Login");
                txtEmail2.Focus();
                return;
            }

            if (txt_Senha2.Text == "")
            {
                MessageBox.Show("Preencha o campo senha");
                txt_Senha2.Focus();
                return;
            }
        }

        private void btnLimparLogin_Click(object sender, EventArgs e)
        {
            txtEmail2.Text = "";
            txt_Senha2.Text = "";
        }

        private void Btn_VerSenha_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                txt_Senha2.PasswordChar = '\0';
                VerSenhaTxt = true;
                Btn_VerSenha.Text = "Esconder Senha";
            }
            else
            {
                txt_Senha2.PasswordChar = '*';
                VerSenhaTxt = false;
                Btn_VerSenha.Text = "Ver Senha";
            }

        }

       private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmClientes f = new frmClientes();
            this.Hide();
            f.ShowDialog();

        }
    }
}
