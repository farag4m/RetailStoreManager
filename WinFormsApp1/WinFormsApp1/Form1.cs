using System.Data.SQLite;
using Smart_Retail_Store_Manager.Entity;
using Smart_Retail_Store_Manager.Manager;
using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        #region Data Variables
        private static List<ProductInfo> _products = new List<ProductInfo>();
        private static List<SupplierInfo> _suppliers = new List<SupplierInfo>();
        public static List<ProductInfo> Products
        {
            get
            {
                return _products;
            }
            set
            {
                _products = value;
            }
        }
        public static List<SupplierInfo> Suppliers
        {
            get
            {
                return _suppliers;
            }
            set
            {
                _suppliers = value;
            }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
            Products = Manager.GetAllProducts();
            Suppliers = Manager.GetAllSuppliers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            constructProductData();
            ProductGrid.DataSource = Products;
            cbSuppliers.DataSource = new BindingList<SupplierInfo>(Suppliers);
        }

        private void constructProductData()
        {
            // Array of 5 sample product names
            string[] sampleProductNames = new string[]
            {
                "Product A", "Product B", "Product C", "Product D", "Product E"
            };

            // Add 5 ProductInfo records to the list, using names from the array
            for (int i = 0; i < 5; i++)
            {
                AddProduct(new ProductInfo
                {
                    ProductID = i + 1,  // ProductID starts from 1 (assuming you have a way to auto-generate this in the DB)
                    Name = sampleProductNames[i],  // Fetch name from the array
                    Price = (i + 1) * 10 + ".00",  // Assign a sample price
                    Stock = (i + 1) * 5 + "",  // Assign a sample stock number
                    SupplierID = (1)  // Assign a sample SupplierID
                });
            }
        }
        private void ClearProductInput()
        {
            txtProductName.Text = String.Empty;
            txtProductPrice.Text = String.Empty;
            txtProductStock.Text = String.Empty;
        }
        private void AddProduct(ProductInfo product)
        {
            bool isError = false;

            isError = Manager.AddProduct(product);
            if (isError == false)
            {
                Products = Manager.GetAllProducts();

                ProductGrid.DataSource = new BindingList<ProductInfo>(Products);
                ProductGrid.Refresh();
            }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductInfo product = new ProductInfo();

            product.Name = txtProductName.Text;
            product.Price = txtProductPrice.Text;
            product.Stock = txtProductStock.Text;
            product.SupplierID = Convert.ToInt32(cbSuppliers.SelectedValue);

            AddProduct(product);
            ClearProductInput();
        }

        private void AddSupplier(SupplierInfo supplier)
        {
            bool isError = false;

            isError = Manager.AddSupplier(supplier);
            if (isError == false)
            {
                Suppliers = Manager.GetAllSuppliers();

                // Update the ComboBox with the new list of suppliers
                cbSuppliers.DataSource = new BindingList<SupplierInfo>(Suppliers);
                cbSuppliers.Refresh();
            }
        }
        private void ClearSupplierInput()
        {
            txtSupplierName.Text = string.Empty;
        }
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            SupplierInfo supplier = new SupplierInfo();

            supplier.Name = txtSupplierName.Text;

            AddSupplier(supplier);
            ClearSupplierInput();
        }
    }
}
