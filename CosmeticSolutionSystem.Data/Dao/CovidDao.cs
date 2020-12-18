using CosmeticSolutionSystem.Data.Models;
using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionSystem.Data
{
    public class CovidDao : SingleKeyDao<CovidMonth, int>
    {
        internal CovidDao() { }
        protected override Expression<Func<CovidMonth, int>> KeySelector
        {
            get
            {
                return x => x.CovidId;
            }

        }
        public static List<CovidMonth> GetById()
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.CovidMonths
                            select x;

                return query.ToList();

            }
        }

        //public static List<CovidMonth> GetCovidCount()
        //{
        //    using (var context = DbContextCreator.Create())
        //    {
        //        var query = from x in context.CovidMonths
                           
        //                    select new { Month = x., Quantity = x.ConfirmedCount };

        //        var list = query.ToList();

        //    }
        //}
    }
}

