using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Retail_Store_Manager.Entity
{
    public class ProductInfo
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Stock { get; set; }
        public int SupplierID { get; set; }
    }
}
