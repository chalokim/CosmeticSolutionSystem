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
    public class CategoryDao : SingleKeyDao<Category, int>
    {
        internal CategoryDao() { }
        protected override Expression<Func<Category, int>> KeySelector
        {
            get
            {
                return x => x.CategoryId;
            }
        }
    }
}