using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionSystem.Data.Models
{
    public class TopWorstProductModel
    {
        public TopWorstProductModel(string prodName, int quantity)
        {
            ProductName = prodName;
            Quantity = quantity;
        }

        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}
