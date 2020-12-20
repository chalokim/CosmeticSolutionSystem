using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionSystem.Data.Models
{
    public class SalesVolumeMonthCategoryModel
    {
        public SalesVolumeMonthCategoryModel(DateTime datetime, string category, int quantity)
        {
            Date = datetime;
            CategoryName = category;
            Quantity = quantity;
        }
        public DateTime Date { get; set; }
        public string CategoryName { get; set; }
        public int Quantity { get; set; }
    }
}
