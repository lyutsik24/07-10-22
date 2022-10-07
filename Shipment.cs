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
    public partial class Shipment : Form
    {
        public Shipment()
        {
            InitializeComponent();
        }

        private void Shipment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kostyaDataSet2.Shop_Shipment". При необходимости она может быть перемещена или удалена.
            this.shop_ShipmentTableAdapter.Fill(this.kostyaDataSet2.Shop_Shipment);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void Shipment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
