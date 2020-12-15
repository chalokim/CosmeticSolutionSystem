using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Data
{
    public class Dao
    {
        public static CategoryDao category = new CategoryDao();
        public static CustomerDao customer = new CustomerDao();
        public static BrandDao brand = new BrandDao();
        public static ProductDao product = new ProductDao();
        public static SalesDao sales = new SalesDao();
        public static SalesLineDao salesLine = new SalesLineDao();
    }
}


