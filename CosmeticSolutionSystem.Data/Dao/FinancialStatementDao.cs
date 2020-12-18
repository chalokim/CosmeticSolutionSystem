using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CosmeticSolutionSystem.Data.Models;

namespace CosmeticSolutionSystem.Data
{
    public class FinancialStatementDao : SingleKeyDao<FinancialStatement,int>
    {
        internal FinancialStatementDao() { }
        protected override Expression<Func<FinancialStatement, int>> KeySelector
        {
            get
            {
                return x => x.FinancialStatementId;
            }

        }

        public static List<FinancialStatement> GetFinancialStatements()
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.FinancialStatements
                            select x;

                return query.ToList();

            }
        }
    }
}
