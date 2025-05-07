namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ProductGrid = new DataGridView();
            productIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supplierIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productInfoBindingSource = new BindingSource(components);
            employeeInfoBindingSource = new BindingSource(components);
            userInfoBindingSource = new BindingSource(components);
            label1 = new Label();
            txtProductName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnAddProduct = new Button();
            DataBaseTabs = new TabControl();
            PageSqlite = new TabPage();
            cbSuppliers = new ComboBox();
            label10 = new Label();
            btnAddSupplier = new Button();
            txtSupplierName = new TextBox();
            label9 = new Label();
            txtMetaData = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtProductStock = new TextBox();
            txtProductPrice = new TextBox();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            supplierInfoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)ProductGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productInfoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeInfoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userInfoBindingSource).BeginInit();
            DataBaseTabs.SuspendLayout();
            PageSqlite.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierInfoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ProductGrid
            // 
            ProductGrid.AutoGenerateColumns = false;
            ProductGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGrid.Columns.AddRange(new DataGridViewColumn[] { productIDDataGridViewTextBoxColumn, dataGridViewTextBoxColumn4, priceDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn, supplierIDDataGridViewTextBoxColumn });
            ProductGrid.DataSource = productInfoBindingSource;
            ProductGrid.Location = new Point(181, 40);
            ProductGrid.Name = "ProductGrid";
            ProductGrid.RowHeadersWidth = 51;
            ProductGrid.Size = new Size(657, 502);
            ProductGrid.TabIndex = 0;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            dataGridViewTextBoxColumn4.HeaderText = "Name";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            supplierIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            supplierIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // productInfoBindingSource
            // 
            productInfoBindingSource.DataSource = typeof(Smart_Retail_Store_Manager.Entity.ProductInfo);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 17);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 3;
            label1.Text = "Products";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(13, 63);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(151, 27);
            txtProductName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 40);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 9;
            label3.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 199);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 10;
            label4.Text = "Supplier";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(13, 410);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(125, 29);
            btnAddProduct.TabIndex = 15;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // DataBaseTabs
            // 
            DataBaseTabs.Controls.Add(PageSqlite);
            DataBaseTabs.Controls.Add(tabPage2);
            DataBaseTabs.Location = new Point(12, 9);
            DataBaseTabs.Name = "DataBaseTabs";
            DataBaseTabs.SelectedIndex = 0;
            DataBaseTabs.Size = new Size(860, 589);
            DataBaseTabs.TabIndex = 17;
            // 
            // PageSqlite
            // 
            PageSqlite.BackColor = Color.MediumSeaGreen;
            PageSqlite.Controls.Add(cbSuppliers);
            PageSqlite.Controls.Add(label10);
            PageSqlite.Controls.Add(btnAddSupplier);
            PageSqlite.Controls.Add(txtSupplierName);
            PageSqlite.Controls.Add(label9);
            PageSqlite.Controls.Add(txtMetaData);
            PageSqlite.Controls.Add(label8);
            PageSqlite.Controls.Add(label7);
            PageSqlite.Controls.Add(txtProductStock);
            PageSqlite.Controls.Add(txtProductPrice);
            PageSqlite.Controls.Add(ProductGrid);
            PageSqlite.Controls.Add(label1);
            PageSqlite.Controls.Add(btnAddProduct);
            PageSqlite.Controls.Add(txtProductName);
            PageSqlite.Controls.Add(label3);
            PageSqlite.Controls.Add(label4);
            PageSqlite.Location = new Point(4, 29);
            PageSqlite.Name = "PageSqlite";
            PageSqlite.Padding = new Padding(3);
            PageSqlite.Size = new Size(852, 556);
            PageSqlite.TabIndex = 0;
            PageSqlite.Text = "(Relational) SQLite";
            // 
            // cbSuppliers
            // 
            cbSuppliers.DataSource = supplierInfoBindingSource;
            cbSuppliers.DisplayMember = "Name";
            cbSuppliers.FormattingEnabled = true;
            cbSuppliers.Location = new Point(13, 221);
            cbSuppliers.Name = "cbSuppliers";
            cbSuppliers.Size = new Size(151, 28);
            cbSuppliers.TabIndex = 28;
            cbSuppliers.ValueMember = "SupplierID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 454);
            label10.Name = "label10";
            label10.Size = new Size(108, 20);
            label10.TabIndex = 25;
            label10.Text = "Supplier Name";
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.Location = new Point(13, 513);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(125, 29);
            btnAddSupplier.TabIndex = 24;
            btnAddSupplier.Text = "Add Supplier";
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(13, 480);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(151, 27);
            txtSupplierName.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 252);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 21;
            label9.Text = "MetaData";
            // 
            // txtMetaData
            // 
            txtMetaData.Location = new Point(13, 275);
            txtMetaData.Multiline = true;
            txtMetaData.Name = "txtMetaData";
            txtMetaData.Size = new Size(151, 129);
            txtMetaData.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 93);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 19;
            label8.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 146);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 18;
            label7.Text = "Stock";
            // 
            // txtProductStock
            // 
            txtProductStock.Location = new Point(13, 169);
            txtProductStock.Name = "txtProductStock";
            txtProductStock.Size = new Size(151, 27);
            txtProductStock.TabIndex = 17;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(13, 116);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(151, 27);
            txtProductPrice.TabIndex = 16;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(852, 556);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "(Document) MongoDB";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(145, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(457, 471);
            dataGridView1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 17);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 17;
            label2.Text = "(Document) MongoDB";
            // 
            // button2
            // 
            button2.Location = new Point(44, 173);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 22;
            button2.Text = "Add User";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(13, 63);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(13, 130);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 40);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 20;
            label5.Text = "User Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 107);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 21;
            label6.Text = "Password";
            // 
            // supplierInfoBindingSource
            // 
            supplierInfoBindingSource.DataSource = typeof(Smart_Retail_Store_Manager.Entity.SupplierInfo);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1216, 606);
            Controls.Add(DataBaseTabs);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ProductGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)productInfoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeInfoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userInfoBindingSource).EndInit();
            DataBaseTabs.ResumeLayout(false);
            PageSqlite.ResumeLayout(false);
            PageSqlite.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierInfoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductGrid;
        private BindingSource userInfoBindingSource;
        private Label label1;
        private TextBox txtProductName;
        private Label label3;
        private Label label4;
        private Button btnAddProduct;
        private TabControl DataBaseTabs;
        private TabPage PageSqlite;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label label2;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hireDateDataGridViewTextBoxColumn;
        private BindingSource employeeInfoBindingSource;
        private TextBox txtProductStock;
        private TextBox txtProductPrice;
        private Label label9;
        private TextBox txtMetaData;
        private Label label8;
        private Label label7;
        private DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private BindingSource productInfoBindingSource;
        private Label label10;
        private Button btnAddSupplier;
        private TextBox txtSupplierName;
        private ComboBox cbSuppliers;
        private BindingSource supplierInfoBindingSource;
    }
}
