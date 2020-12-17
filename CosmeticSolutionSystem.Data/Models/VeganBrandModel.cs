using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionSystem.Data.Models
{
    public class VeganBrandModel
    {
        public DateTime Date { get; set; }

        public int Quantity { get; set; }

        public int BrandTag { get; set; }
    }

    public class TheModel
    {
        public int Year { get; set; }

        public int Quantity { get; set; }
    }
}
