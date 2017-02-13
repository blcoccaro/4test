using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ddlNetworkCard.DataSource = Helper.GetAllNetworkInterfaces();
            dataGridView1.DataSource = Helper.GetAllNetworkInterfacesFull();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Image image = null;

            //if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            //{
            //    image = Resource1.green_light;
            //}
            //else
            //{
            //    image = Resource1.red_light;
            //}
            //Properties.Resources.ResourceManager.GetObject("");
            //pictureBox1.Image = image;
        }

        private void btnEnableOrDisable_Click(object sender, EventArgs e)
        {
            var id = (string)ddlNetworkCard.SelectedValue;
            if (!string.IsNullOrWhiteSpace(id))
            {
                Helper.EnableDisable(id);
            }
            btnRefresh_Click(sender, e);
        }
    }
}
