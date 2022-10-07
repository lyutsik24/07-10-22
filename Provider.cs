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
    public partial class Provider : Form
    {
        public Provider()
        {
            InitializeComponent();
        }

        private void Provider_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kostyaDataSet1.Shop_Provider". При необходимости она может быть перемещена или удалена.
            this.shop_ProviderTableAdapter.Fill(this.kostyaDataSet1.Shop_Provider);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void Provider_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
