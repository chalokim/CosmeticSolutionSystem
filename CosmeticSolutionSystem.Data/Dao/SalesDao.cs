﻿using CosmeticSolutionSystem.Data.Models;
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
        protected override Expression<Func<Sale, bool>> IsKey(int key)
        {
            return x => x.SalesId == key;
        }
        protected override Expression<Func<Sale, int>> KeySelector =>
                x => x.SalesId;

        public static List<Sale> GetById()
        {
            using (var context = new CosmeticSolutionSystemEntities())
            {
                var query = from x in context.Sales                        
                            select x;

                return query.ToList();

            }
        }

/*        public List<HourlySalesModel> GetHourlyModel(int hour)
        {
            TimeSpan @from = TimeSpan.FromHours(10);
            TimeSpan to = TimeSpan.FromHours(12);

            using (CosmeticSolutionSystemEntities context = new CosmeticSolutionSystemEntities())
            {
                var query = from x in context.Sales
                            where x.Sale.SelledAt >= @from && x.Sale.SelledAt <= to
                            select new
                            {
                                
                            };
            }
        }
*/        public List<SalesModel> GetModels(int month)
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

                foreach(var item in list)
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
    }

}