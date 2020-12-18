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
    public class SalesDao : SingleKeyDao<Sale, int>
    {
        internal SalesDao() { }
        protected override Expression<Func<Sale, int>> KeySelector
        {
            get
            {
                return x => x.SalesId;
            }
        }
        
        
        public static List<Sale> GetById()
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Sales                        
                            select x;

                return query.ToList();

            }
        }

        public static List<SalesModel> GetModels(int month)
        {

            DateTime @from = DateTime.Today.AddMonths(month * -2);
            DateTime to = DateTime.Today;

            using (CosmeticSolutionSystemEntities context = new CosmeticSolutionSystemEntities())
            {
                var query = from x in context.SalesLines
                            where x.Sale.SelledAt >= @from && x.Sale.SelledAt <= to
                            select new
                            {
                                Date = x.Sale.SelledAt,
                                // TotalPrice = x.Sale.TotalPrice,
                                Quantity = x.Quantity,
                                CategoryName = x.Product.Category.CategoryName
                            };

                var list = query.ToList();

                List<SalesModel> models = new List<SalesModel>();

                foreach (var item in list)
                {
                    SalesModel model = models.Find(x => x.Date == item.Date && x.CategoryName == item.CategoryName);

                    if (model != null)
                    {
                        model.Quantity += item.Quantity;
                    }
                    else
                    {
                        model = new SalesModel();
                        model.Date = item.Date;
                        model.CategoryName = item.CategoryName;
                        model.Quantity = item.Quantity;

                        models.Add(model);

                    }
                }

                return models;
            }
        }



        

        public static List<CategorizedByAgeModel> GetModelsCategory(int year)
        {
            DateTime @from = DateTime.Today.AddMonths(year * -1);
            DateTime to = DateTime.Today;

            using (CosmeticSolutionSystemEntities context = new CosmeticSolutionSystemEntities())
            {
                var query = from x in context.SalesLines
                            where x.Sale.SelledAt >= @from && x.Sale.SelledAt <= to
                            select new
                            {
                                Date = x.Sale.SelledAt,
                                Quantity = x.Quantity,
                                CategoryName = x.Product.Category.CategoryName,
                                Age = x.Sale.Customer.Birth
                            };

                var list = query.ToList();

                List<CategorizedByAgeModel> models = new List<CategorizedByAgeModel>();

                foreach (var item in list)
                {
                    CategorizedByAgeModel model = models.Find(x => x.Date == item.Date && x.CategoryName == item.CategoryName
                    && x.Age == item.Age);

                    if (model != null)
                    {
                        model.Quantity += item.Quantity;
                    }
                    else
                    {
                        model = new CategorizedByAgeModel();
                        model.Date = item.Date;
                        model.CategoryName = item.CategoryName;
                        model.Quantity = item.Quantity;
                        model.Age = item.Age;

                        models.Add(model);

                    }
                }

                return models;
            }
        }


        public List<VeganBrandModel> VeganSalesPerYear(int year)
        {
            using (var context = DbContextCreator.Create())
            {
                DateTime firstDay = DateTime.Today.AddYears(year * -1);
                DateTime lastDay = DateTime.Today;


                var query = from x in context.SalesLines
                            where x.Sale.SelledAt >= firstDay && x.Sale.SelledAt <= lastDay
                            && x.Product.Brand.BrandTag == 0
                            select new { SelledAt = x.Sale.SelledAt, Quantity = x.Quantity };

                var list = query.ToList();


                var query2 = from x in list
                             group x by x.SelledAt.Year into g   
                             select new VeganBrandModel
                             {
                                 Year = g.Key,
                                 Quantity = g.Sum(y => y.Quantity)
                             };

                return query2.ToList();
            }
        }

        
    }

}