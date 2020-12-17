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
    public class BrandDao : SingleKeyDao<Brand, int>
    {
        internal BrandDao() { }
        protected override Expression<Func<Brand, int>> KeySelector
        {
            get
            {
                return x => x.BrandId;
            }
            
        }
        
        public static List<Brand> GetByBrandName()
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Brands
                                //where x.BrandName == BrandName
                                //where x.BrandName.All(t => t.Name.Contains(BrandName))
                            select x;

                return query.ToList();

            }
        }

    }

}