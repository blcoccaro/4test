using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompressJSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnCompress_Click(object sender, EventArgs e)
        {
            if (txtText.Text.Length > 0)
            {
                var value = Helper.Compress3(txtText.Text);
                txtResult.Text = value;
                lblSize.Text = Helper.SizeSuffix(System.Text.Encoding.Unicode.GetByteCount(txtText.Text)) + " / " + Helper.SizeSuffix(System.Text.Encoding.Unicode.GetByteCount(value));
            }
        }

        private void btnDeCompress_Click(object sender, EventArgs e)
        {
            if (txtText.Text.Length > 0)
            {
                var value = Helper.DeCompress3(txtText.Text);
                txtResult.Text = value;
                lblSize.Text = Helper.SizeSuffix(System.Text.Encoding.ASCII.GetByteCount(txtText.Text)) + " / " + Helper.SizeSuffix(System.Text.Encoding.ASCII.GetByteCount(value));
            }
        }

        private void btnCopyToTexto_Click(object sender, EventArgs e)
        {
            txtText.Text = txtResult.Text;
        }
    }
}
