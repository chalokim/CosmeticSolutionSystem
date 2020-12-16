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
    public class SalesLineDao : SingleKeyDao<SalesLine, int>
    {
        internal SalesLineDao() { }
        protected override Expression<Func<SalesLine, bool>> IsKey(int key)
        {
            return x => x.SalesLineId == key;
        }
        protected override Expression<Func<SalesLine, int>> KeySelector =>
                x => x.SalesLineId;

    }

}