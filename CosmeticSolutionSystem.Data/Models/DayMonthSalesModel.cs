using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionSystem.Data.Models
{
    public class DayMonthSalesModel
    {
        public DayMonthSalesModel(DateTime datetime, int salesVolume)
        {
            Date = datetime;
            SalesVolume = salesVolume;
        }

        public DateTime Date { get; set; }
        public int SalesVolume { get; set; }
    }
}
