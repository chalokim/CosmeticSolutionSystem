using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionSystem.Data.Models
{
    public class CategorizedByAgeModel
    {
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public string CategoryName { get; set; }
        public int Age { get; set; }
    }
}
