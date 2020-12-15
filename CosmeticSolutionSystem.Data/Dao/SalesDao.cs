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

    }

}