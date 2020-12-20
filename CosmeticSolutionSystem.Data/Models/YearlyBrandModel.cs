using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionSystem.Data.Models
{
    public class YearlyBrandModel
    {
        public YearlyBrandModel(string brandName, int totalPrice)
        {
            BrandName = brandName;
            TotalPrice = totalPrice;
        }

        public string BrandName { get; set; }
        public int Year { get; set; }
        public DateTime SelledAt { get; set; }
        public int TotalPrice { get; set; }
    }
}
