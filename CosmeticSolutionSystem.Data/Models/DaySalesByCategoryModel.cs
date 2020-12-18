using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionSystem.Data.Models
{
    public class DaySalesByCategoryModel
    {
        public DaySalesByCategoryModel(string category, int quantity)
        {
            CategoryName = category;
            Quantity = quantity;

        }

        public string CategoryName { get; set; }

        public int Quantity { get; set; }
    }
}
