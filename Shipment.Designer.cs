
namespace _07_10_22
{
    partial class Shipment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Shipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProviderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopShipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kostyaDataSet2 = new _07_10_22.KostyaDataSet2();
            this.shopProviderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kostyaDataSet1 = new _07_10_22.KostyaDataSet1();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.shop_ProviderTableAdapter = new _07_10_22.KostyaDataSet1TableAdapters.Shop_ProviderTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kostyaDataSet = new _07_10_22.KostyaDataSet();
            this.shopProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shop_ProductsTableAdapter = new _07_10_22.KostyaDataSetTableAdapters.Shop_ProductsTableAdapter();
            this.shop_ShipmentTableAdapter = new _07_10_22.KostyaDataSet2TableAdapters.Shop_ShipmentTableAdapter();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopShipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kostyaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopProviderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kostyaDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kostyaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(188, 474);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 36);
            this.button4.TabIndex = 10;
            this.button4.Text = "Очистить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 36);
            this.button3.TabIndex = 9;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(300, 474);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 36);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(10, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(404, 208);
            this.panel7.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Shipment,
            this.idProviderDataGridViewTextBoxColumn,
            this.Id_Product,
            this.Quantity,
            this.Delivery_Price,
            this.Delivery_Date});
            this.dataGridView1.DataSource = this.shopShipmentBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(404, 208);
            this.dataGridView1.TabIndex = 4;
            // 
            // Id_Shipment
            // 
            this.Id_Shipment.DataPropertyName = "Id_Shipment";
            this.Id_Shipment.HeaderText = "Id_Shipment";
            this.Id_Shipment.Name = "Id_Shipment";
            this.Id_Shipment.Visible = false;
            // 
            // idProviderDataGridViewTextBoxColumn
            // 
            this.idProviderDataGridViewTextBoxColumn.DataPropertyName = "Id_Provider";
            this.idProviderDataGridViewTextBoxColumn.HeaderText = "Id_Provider";
            this.idProviderDataGridViewTextBoxColumn.Name = "idProviderDataGridViewTextBoxColumn";
            this.idProviderDataGridViewTextBoxColumn.Visible = false;
            // 
            // Id_Product
            // 
            this.Id_Product.DataPropertyName = "Id_Product";
            this.Id_Product.HeaderText = "ID Продукта";
            this.Id_Product.Name = "Id_Product";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Количество";
            this.Quantity.Name = "Quantity";
            // 
            // Delivery_Price
            // 
            this.Delivery_Price.DataPropertyName = "Delivery_Price";
            this.Delivery_Price.HeaderText = "Цена поставки";
            this.Delivery_Price.Name = "Delivery_Price";
            // 
            // Delivery_Date
            // 
            this.Delivery_Date.DataPropertyName = "Delivery_Date";
            this.Delivery_Date.HeaderText = "Дата поставки";
            this.Delivery_Date.Name = "Delivery_Date";
            // 
            // shopShipmentBindingSource
            // 
            this.shopShipmentBindingSource.DataMember = "Shop_Shipment";
            this.shopShipmentBindingSource.DataSource = this.kostyaDataSet2;
            // 
            // kostyaDataSet2
            // 
            this.kostyaDataSet2.DataSetName = "KostyaDataSet2";
            this.kostyaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shopProviderBindingSource
            // 
            this.shopProviderBindingSource.DataMember = "Shop_Provider";
            this.shopProviderBindingSource.DataSource = this.kostyaDataSet1;
            // 
            // kostyaDataSet1
            // 
            this.kostyaDataSet1.DataSetName = "KostyaDataSet1";
            this.kostyaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(10, 516);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(404, 10);
            this.panel6.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 516);
            this.panel4.TabIndex = 2;
            // 
            // shop_ProviderTableAdapter
            // 
            this.shop_ProviderTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(414, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 516);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 526);
            this.panel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.dateTimePicker1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.btnBack);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(424, 526);
            this.panel5.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Дата поставки :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 317);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Цена поставки :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 277);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Количество :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 10);
            this.panel2.TabIndex = 0;
            // 
            // kostyaDataSet
            // 
            this.kostyaDataSet.DataSetName = "KostyaDataSet";
            this.kostyaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shopProductsBindingSource
            // 
            this.shopProductsBindingSource.DataMember = "Shop_Products";
            this.shopProductsBindingSource.DataSource = this.kostyaDataSet;
            // 
            // shop_ProductsTableAdapter
            // 
            this.shop_ProductsTableAdapter.ClearBeforeFill = true;
            // 
            // shop_ShipmentTableAdapter
            // 
            this.shop_ShipmentTableAdapter.ClearBeforeFill = true;
            // 
            // Shipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 526);
            this.Controls.Add(this.panel1);
            this.Name = "Shipment";
            this.Text = "Shipment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Shipment_FormClosing);
            this.Load += new System.EventHandler(this.Shipment_Load);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopShipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kostyaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopProviderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kostyaDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kostyaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopProductsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource shopProviderBindingSource;
        private KostyaDataSet1 kostyaDataSet1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private KostyaDataSet1TableAdapters.Shop_ProviderTableAdapter shop_ProviderTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private KostyaDataSet kostyaDataSet;
        private System.Windows.Forms.BindingSource shopProductsBindingSource;
        private KostyaDataSetTableAdapters.Shop_ProductsTableAdapter shop_ProductsTableAdapter;
        private KostyaDataSet2 kostyaDataSet2;
        private System.Windows.Forms.BindingSource shopShipmentBindingSource;
        private KostyaDataSet2TableAdapters.Shop_ShipmentTableAdapter shop_ShipmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Shipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProviderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}