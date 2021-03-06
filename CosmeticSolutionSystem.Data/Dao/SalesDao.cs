﻿using CosmeticSolutionSystem.Data.Models;
using EFLibrary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
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

        public List<HourlySales> SearchDate(DateTime startDate, DateTime endDate)
        {
            using (CosmeticSolutionSystemEntities context = new CosmeticSolutionSystemEntities())
            {
                var query = from x in context.Sales
                            where x.SelledAt >= startDate && x.SelledAt <= endDate
                            select x;

                var groupQuery = from p in query
                                 where p.SelledAt.Hour >= 1 && p.SelledAt.Hour <= 24
                                 group p by p.SelledAt.Hour into g
                                 select new HourlySales
                                 {
                                     Hour = g.Key,
                                     CustomerCount = g.Count()
                                 };

                return groupQuery.ToList();
            }
        }

        public static List<SalesModel> GetModels(int month)
        {

            DateTime @from = DateTime.Today.AddMonths(month * -1);
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



      
        public List<SalesModel> GetCovid(int month)
        {
            using (var context = DbContextCreator.Create())
            {
                DateTime @from = DateTime.Today.AddMonths(month * -2);
                DateTime to = DateTime.Today;

                var query = from x in context.SalesLines
                            where x.Sale.SelledAt >= @from && x.Sale.SelledAt <= to
                            select new
                            {

                                Date = x.Sale.SelledAt,
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


        public List<CategorizedByAgeModel> GetModelsCategory(int year)
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


        public List<Sale> OneYearAgo(int year)
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Sales
                            where x.SelledAt.Year == DateTime.Today.Year - 1
                            select x;

                return query.ToList();
            }
        }

        public List<Sale> ThisYear(int year)
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Sales
                            where x.SelledAt.Year == DateTime.Today.Year
                            select x;

                return query.ToList();
            }
        }

        public static List<DayMonthSalesModel> GetSalesVolumeByMonth(DateTime startMonth)
        {
            int cntMonths = 12;

            DateTime start = new DateTime(
                startMonth.Year, startMonth.Month, 1);
            DateTime end = start.AddMonths(cntMonths);

            using (var context = new CosmeticSolutionSystemEntities())
            {
                var query = (from x in context.SalesLines
                             where x.Sale.SelledAt >= start && x.Sale.SelledAt <= end
                             select new
                             {
                                 Date = x.Sale.SelledAt,
                                 Quantity = x.Quantity,
                             }).GroupBy(x => x.Date.Month).Select(
                                group => new { group.FirstOrDefault().Date, Quantity = group.Sum(x => x.Quantity) });

                var list = query.ToList();

                List<DayMonthSalesModel> model = new List<DayMonthSalesModel>();

                for (int i = 0; i < cntMonths; i++)
                {
                    DateTime months = start.AddMonths(i);
                    model.Add(new DayMonthSalesModel(months, 0));
                }

                foreach (var item in list)
                {
                    DayMonthSalesModel sales = model.Find(x => x.Date.Month == item.Date.Month);

                    if (sales != null)
                        sales.SalesVolume = item.Quantity;
                }

                return model;
            }
        }

        private static string[] categoryArr = new string[6];
        // 일별 판매량을 카테고리 별로 가져온다
        public static List<DaySalesByCategoryModel> GetSalesVolumeByDay(DateTime start )
        {
            start = new DateTime(start.Year, start.Month, start.Day);

            using (var context = new CosmeticSolutionSystemEntities())
            {
                var queryX = from x in context.Categories
                             orderby x.CategoryName 
                             select x.CategoryName;

                int i = 0;

                foreach ( var x in queryX )
                    categoryArr[i] = x.ToString();


                //context.Database.Log = (log) => Debug.WriteLine(log);

                var query =  (from x in context.SalesLines
                             where DbFunctions.TruncateTime( x.Sale.SelledAt) == DbFunctions.TruncateTime( start )
                             select new
                             {
                                 CategoryName = x.Product.Category.CategoryName,
                                 Quantity = x.Quantity,
                             }).GroupBy( x => x.CategoryName ).Select(
                    group => new { group.FirstOrDefault().CategoryName, Quantity = group.Sum( x => x.Quantity) }
                    );

                var list = query.ToList();

                List<DaySalesByCategoryModel> model = new List<DaySalesByCategoryModel>();

                // 카테고리 6개를 무조건 만든다
                foreach (var x in queryX)
                    model.Add(new DaySalesByCategoryModel(x.ToString(), 0));

                foreach (var item in list)
                {
                    DaySalesByCategoryModel tempModel = model.Find(x => x.CategoryName == item.CategoryName);

                    if(tempModel != null )
                        tempModel.Quantity = item.Quantity;
                }

                return model;
            }
        }


        public static List<TopWorstProductModel> GetTopProductByMonth(int topCount, DateTime month)
        {
            DateTime start = new DateTime(month.Year, month.Month, 1);
            DateTime end = start.AddMonths(1); // 기간을 한달로 설정

            using (var context = new CosmeticSolutionSystemEntities())
            {
                var query = (from x in context.SalesLines
                             where x.Sale.SelledAt >= start && x.Sale.SelledAt <= end
                             select new
                            {
                                ProductName = x.Product.ProductName,
                                Quantity = x.Quantity,
                            }).GroupBy(x => x.ProductName).Select(
                   group => new { group.FirstOrDefault().ProductName, Quantity = group.Sum(x => x.Quantity) }).OrderByDescending(x => x.Quantity).Take(topCount);

                var list = query.ToList();

                List<TopWorstProductModel> model = new List<TopWorstProductModel>();

                foreach (var x in list)
                {
                    model.Add(new TopWorstProductModel(x.ProductName, x.Quantity));
                }

                return model;
            }
        }

        public static List<TopWorstProductModel> GetTopProductByYear(int topCount, DateTime year)
        {
            DateTime start = new DateTime(year.Year, 1, 1);
            DateTime end = start.AddYears(1); // 기간을 1년으로 설정

            using (var context = new CosmeticSolutionSystemEntities())
            {
                var query = (from x in context.SalesLines
                             where x.Sale.SelledAt >= start && x.Sale.SelledAt <= end
                             select new
                             {
                                 ProductName = x.Product.ProductName,
                                 Quantity = x.Quantity,
                             }).GroupBy(x => x.ProductName).Select(
                   group => new { group.FirstOrDefault().ProductName, Quantity = group.Sum(x => x.Quantity) }).OrderByDescending(x => x.Quantity).Take(topCount);

                var list = query.ToList();

                List<TopWorstProductModel> model = new List<TopWorstProductModel>();

                foreach (var x in list)
                {
                    model.Add(new TopWorstProductModel(x.ProductName, x.Quantity));
                }

                return model;
            }
        }


        public static List<SalesVolumeMonthCategoryModel> GetSalesVolumeByMonthCategory(DateTime month)
        {
            DateTime start = new DateTime(month.Year, month.Month, 1);
            DateTime end = start.AddYears(1);

            using (var context = new CosmeticSolutionSystemEntities())
            {
                //context.Database.Log = (log) => Debug.WriteLine(log);

                var queryX = from x in context.Categories
                             orderby x.CategoryName
                             select x.CategoryName;

                int i = 0;

                var listX = queryX.ToList();

                foreach (var x in listX)
                {
                    categoryArr[i] = x.ToString();
                    i++;
                }

                var query = (from x in context.SalesLines
                             where DbFunctions.TruncateTime(x.Sale.SelledAt) >= DbFunctions.TruncateTime(start)
                             && DbFunctions.TruncateTime(x.Sale.SelledAt) <= DbFunctions.TruncateTime(end)
                             select new
                             {
                                 Date = x.Sale.SelledAt,
                                 CategoryName = x.Product.Category.CategoryName,
                                 Quantity = x.Quantity
                             }).GroupBy(x => new { x.Date.Month, x.CategoryName }).Select
                                (group => new { group.FirstOrDefault().Date, group.FirstOrDefault().CategoryName, Quantity = group.Sum(x => x.Quantity) }
                             );

                var list = query.ToList();

                List<SalesVolumeMonthCategoryModel> model = new List<SalesVolumeMonthCategoryModel>();

                for (int y = 0; y < 12; y++)
                {
                    foreach (var item in categoryArr)
                    {
                        model.Add(new SalesVolumeMonthCategoryModel(start.AddMonths(y), item.ToString(), 0));
                    }
                }

                foreach (var x in list)
                {
                    SalesVolumeMonthCategoryModel categorymodel = model.Find( y => y.Date == new DateTime(x.Date.Year, x.Date.Month, 1) && y.CategoryName == x.CategoryName);

                    if (categorymodel != null)
                    {
                        categorymodel.Date = new DateTime(x.Date.Year, x.Date.Month, 1);
                        categorymodel.CategoryName = x.CategoryName;
                        categorymodel.Quantity = x.Quantity;
                    }
                }

                return model;
            }
        }

        public static List<SalesVolumeMonthCategoryModel> GetSalesVolumeByDayCategory(DateTime day)
        {
            DateTime start = day;
            DateTime end = start.AddDays(7);

            using (var context = new CosmeticSolutionSystemEntities())
            {
                //context.Database.Log = (log) => Debug.WriteLine(log);

                var queryX = from x in context.Categories
                             orderby x.CategoryName
                             select x.CategoryName;

                int i = 0;

                var listX = queryX.ToList();

                foreach (var x in listX)
                {
                    categoryArr[i] = x.ToString();
                    i++;
                }

                var query = (from x in context.SalesLines
                             where DbFunctions.TruncateTime(x.Sale.SelledAt) >= DbFunctions.TruncateTime(start)
                             && DbFunctions.TruncateTime(x.Sale.SelledAt) <= DbFunctions.TruncateTime(end)
                             select new
                             {
                                 Date = x.Sale.SelledAt,
                                 CategoryName = x.Product.Category.CategoryName,
                                 Quantity = x.Quantity
                             }).GroupBy(x => new { x.Date.Day, x.CategoryName }).Select
                                (group => new { group.FirstOrDefault().Date, group.FirstOrDefault().CategoryName, Quantity = group.Sum(x => x.Quantity) }
                             );

                var list = query.ToList();

                List<SalesVolumeMonthCategoryModel> model = new List<SalesVolumeMonthCategoryModel>();

                for (int y = 0; y < 7; y++)
                {
                    foreach (var item in categoryArr)
                    {
                        model.Add(new SalesVolumeMonthCategoryModel(start.AddDays(y), item.ToString(), 0));
                    }
                }

                foreach (var item in list)
                {
                    SalesVolumeMonthCategoryModel categoryModel = model.Find(x => x.CategoryName == item.CategoryName && new DateTime(x.Date.Year,x.Date.Month, x.Date.Day) == new DateTime(item.Date.Year, item.Date.Month, item.Date.Day));

                    if (categoryModel != null)
                        categoryModel.Quantity = item.Quantity;
                }

                return model;
            }
        }
    }
}