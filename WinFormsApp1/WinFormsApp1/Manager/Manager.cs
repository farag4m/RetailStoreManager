using Smart_Retail_Store_Manager.Data;
using Smart_Retail_Store_Manager.Entity;

namespace Smart_Retail_Store_Manager.Manager
{
    public static class Manager
    {
        private static SQLiteDataAccess _sqliteDataAccess;

        static Manager()
        {
            // Define your database file path and connection string
            string dbFilePath = Path.Combine("SQLite", "retail_store.db");
            string connectionString = $"Data Source={dbFilePath};";

            // Initialize SQLiteDataAccess with the connection string
            _sqliteDataAccess = new SQLiteDataAccess(connectionString);
        }

        public static List<ProductInfo> GetAllProducts()
        {
            return _sqliteDataAccess.GetAllProducts();
        }
        public static bool AddProduct(ProductInfo product)
        {
            return _sqliteDataAccess.AddProduct(product);
        }
        public static ProductInfo? GetProduct(int productID)
        {
            return _sqliteDataAccess.GetProduct(productID);
        }


        public static bool AddSupplier(SupplierInfo supplier)
        {
            return _sqliteDataAccess.AddSupplier(supplier);
        }
        public static List<SupplierInfo> GetAllSuppliers()
        {
            return _sqliteDataAccess.GetAllSuppliers();
        }
    }
}
