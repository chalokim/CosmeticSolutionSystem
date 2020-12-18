using CosmeticSolutionSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionSystem.Data
{
    public class Dao
    {
        public static CategoryDao Category = new CategoryDao();
        public static CustomerDao Customer = new CustomerDao();
        public static BrandDao Brand = new BrandDao();
        public static ProductDao Product = new ProductDao();
        public static SalesDao Sales = new SalesDao();
        public static SalesLineDao SalesLine = new SalesLineDao();
    }
}


