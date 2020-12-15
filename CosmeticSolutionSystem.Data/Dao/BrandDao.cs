using CosmeticSolutionSystem.Data;
using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Data
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

    }

}
