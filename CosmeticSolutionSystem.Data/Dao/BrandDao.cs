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

        public List<YearlyBrandModel> GetBrand(DateTime startDate, DateTime endDate)
        {

            using (var context = DbContextCreator.Create())
            {
                var dataQuery = from x in context.SalesLines
                                where x.Sale.SelledAt >= startDate && x.Sale.SelledAt <= endDate
                                select new
                                {
                                    brandName = x.Product.Brand.BrandName,
                                    selledAt = x.Sale.SelledAt,
                                    totalPrice = x.Sale.TotalPrice
                                };
                var dataList = dataQuery.ToList();

                var groupQuery = (from p in dataQuery
                                  where p.selledAt.Year >= 2018 && p.selledAt.Year <= 2020
                                  select new
                                  {
                                      BrandName = p.brandName,
                                      TotalPrice = p.totalPrice
                                  }).GroupBy(p => p.BrandName).
                                  Select(group => new { group.FirstOrDefault().BrandName, TotalPrice = group.Sum(p => p.TotalPrice) }).OrderByDescending(p => p.TotalPrice);

                var groupList = groupQuery.ToList();

                List<YearlyBrandModel> model = new List<YearlyBrandModel>();

                foreach (var x in groupList)
                {
                    model.Add(new YearlyBrandModel(x.BrandName, x.TotalPrice));
                }

                return model;

            }
        }
    }
}
