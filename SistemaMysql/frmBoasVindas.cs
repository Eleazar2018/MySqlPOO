using QRCoder;
using SistemaMysql.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QRCoder.PayloadGenerator;

namespace SistemaMysql
{
    public partial class frmBoasVindas : MetroFramework.Forms.MetroForm
    {
        public frmBoasVindas()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            GerarQRCode();
        }

        private void GerarQRCode()
        {
            Url generator = new Url("https://www.youtube.com/watch?v=d-tx9D4a8dc");

            string payload = generator.ToString();

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(qrCodeData);
            pictureBox1.Image = qRCode.GetGraphic(4);
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            frmCadastra form = new frmCadastra();
            form.Show();
           // this.Hide();
           // f.Show();

        }
    }
}
