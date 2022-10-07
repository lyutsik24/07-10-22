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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kostyaDataSet.Shop_Products". При необходимости она может быть перемещена или удалена.
            this.shop_ProductsTableAdapter.Fill(this.kostyaDataSet.Shop_Products);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void Products_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
