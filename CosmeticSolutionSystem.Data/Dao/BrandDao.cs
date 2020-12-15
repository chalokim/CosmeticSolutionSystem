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
        protected override Expression<Func<Brand, bool>> IsKey(int key)
        {
            return x => x.BrandId == key;
        }
        protected override Expression<Func<Brand, int>> KeySelector =>
                x => x.BrandId;

        public static List<Brand> GetByBrandName()
        {
            using (var context = new CosmeticSolutionSystemEntities())
            {
                var query = from x in context.Brands
                                // where x.BrandName == brandName
                                //where x.BrandName.All(t => t.Name.Contains(brandName))
                            select x;

                return query.ToList();

            }
        }
    }

}