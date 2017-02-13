using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var ret = openFileDialog1.ShowDialog();
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            new Helper().ResizeTo(openFileDialog1.FileName, txtPathToSave.Text);
            pictureBox1.ImageLocation = txtPathToSave.Text;
        }
    }
}
