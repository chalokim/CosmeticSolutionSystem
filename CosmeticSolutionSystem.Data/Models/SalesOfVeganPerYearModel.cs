using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionSystem.Data.Models
{
    public class SalesOfVeganPerYearModel
    {
        public int BrandTag { get; }

        public int BrandId { get; }

        public int ProductId { get; }

        public int SalesId { get; }

        public DateTime SelledAt { get; }

        public int Quantity { get; }
    }
}
