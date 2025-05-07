using Smart_Retail_Store_Manager.Entity;
using System.Data.SQLite;

namespace Smart_Retail_Store_Manager.Data
{
    public class SQLiteDataAccess : IDisposable
    {
        #region Constructor
        private SQLiteConnection _connection;

        // Constructor that initializes the connection with the connection string
        public SQLiteDataAccess(string connectionString)
        {
            _connection = new SQLiteConnection(connectionString);
            _connection.Open();
        }

        public void Dispose()
        {
            if (_connection != null)
            {
                if (_connection.State != System.Data.ConnectionState.Closed)
                {
                    _connection.Close(); // Ensure the connection is closed when disposed
                }
                _connection.Dispose(); // Free up the resources used by the connection
                _connection = null; // Nullify the reference
            }
        }
        #endregion


        public bool AddProduct(ProductInfo product)
        {
            bool isError = true;
            string query = @"
                INSERT INTO products (Name, Price, Stock, SupplierID) 
                SELECT @Name, @Price, @Stock, @SupplierID
                WHERE NOT EXISTS (
                    SELECT 1 FROM products WHERE Name = @Name
                )";

            using (SQLiteCommand cmd = new SQLiteCommand(query, _connection))
            {
                // Add parameters to the SQL command to prevent SQL injection
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Stock", product.Stock);
                cmd.Parameters.AddWithValue("@SupplierID", product.SupplierID);

                // ExecuteNonQuery returns the number of rows affected
                int rowsAffected = cmd.ExecuteNonQuery();

                // Return true if 1 row was added (success), false if 0 rows (duplicate)
                isError = rowsAffected == 0;
                return isError;
            }
        }

        public ProductInfo? GetLastProduct()
        {
            string query = "SELECT * FROM products ORDER BY ProductID DESC LIMIT 1";

            using (var cmd = new SQLiteCommand(query, _connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader != null && reader.Read())
                    {
                        return new ProductInfo
                        {
                            ProductID = Convert.ToInt32(reader["ProductID"]),
                            Name = reader["Name"].ToString(),
                            Price = reader["Price"].ToString(),
                            Stock = reader["Stock"].ToString(),
                            SupplierID = reader["SupplierID"] != DBNull.Value ? Convert.ToInt32(reader["SupplierID"]) : 0 // Handle null SupplierID
                        };
                    }
                }
            }
            return null; // If no products found
        }

        public List<ProductInfo> GetAllProducts()
        {
            var products = new List<ProductInfo>();
            string query = "SELECT * FROM products ORDER BY ProductID";

            using (var cmd = new SQLiteCommand(query, _connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new ProductInfo
                        {
                            ProductID = Convert.ToInt32(reader["ProductID"]),
                            Name = reader["Name"].ToString(),
                            Price = reader["Price"].ToString(),
                            Stock = reader["Stock"].ToString(),
                            SupplierID = reader["SupplierID"] != DBNull.Value ? Convert.ToInt32(reader["SupplierID"]) : 0 // Handle null SupplierID
                        });
                    }
                }
            }
            return products;
        }

        public ProductInfo? GetProduct(int productID)
        {
            string query = "SELECT * FROM products WHERE ProductID = @ProductID";

            using (var cmd = new SQLiteCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@ProductID", productID);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ProductInfo
                        {
                            ProductID = Convert.ToInt32(reader["ProductID"]),
                            Name = reader["Name"].ToString(),
                            Price = reader["Price"].ToString(),
                            Stock = reader["Stock"].ToString(),
                            SupplierID = reader["SupplierID"] != DBNull.Value ? Convert.ToInt32(reader["SupplierID"]) : 0 // Handle null SupplierID
                        };
                    }
                }
            }
            return null; // If no product with that ID
        }

        public bool AddSupplier(SupplierInfo supplier)
        {
            bool isError = true;
            string query = @"
                INSERT INTO suppliers (Name, Email, Phone) 
                SELECT @Name, @Email, @Phone
                WHERE NOT EXISTS (
                    SELECT 1 FROM suppliers WHERE Name = @Name
                )";

            using (SQLiteCommand cmd = new SQLiteCommand(query, _connection))
            {
                // Add parameters to the SQL command to prevent SQL injection
                cmd.Parameters.AddWithValue("@Name", supplier.Name);
                cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(supplier.Email) ? string.Empty : supplier.Email);
                cmd.Parameters.AddWithValue("@Phone", string.IsNullOrEmpty(supplier.Phone) ? string.Empty : supplier.Phone);

                // ExecuteNonQuery returns the number of rows affected
                int rowsAffected = cmd.ExecuteNonQuery();

                // Return true if 1 row was added (success), false if 0 rows (duplicate)
                isError = rowsAffected == 0;
                return isError;
            }
        }

        public List<SupplierInfo> GetAllSuppliers()
        {
            var suppliers = new List<SupplierInfo>();
            string query = "SELECT * FROM suppliers ORDER BY SupplierID";

            using (var cmd = new SQLiteCommand(query, _connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        suppliers.Add(new SupplierInfo
                        {
                            SupplierID = Convert.ToInt32(reader["SupplierID"]),
                            Name = reader["Name"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = reader["Phone"].ToString()
                        });
                    }
                }
            }
            return suppliers;
        }

    }
}
