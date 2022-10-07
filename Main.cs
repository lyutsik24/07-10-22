using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_10_22
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products main = new Products();
            main.Show();
        }

        private void btnShipment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shipment main = new Shipment();
            main.Show();
        }

        private void btnProvider_Click(object sender, EventArgs e)
        {
            this.Hide();
            Provider main = new Provider();
            main.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
