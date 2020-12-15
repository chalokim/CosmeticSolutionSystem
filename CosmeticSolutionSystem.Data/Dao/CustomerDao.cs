using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionSystem.Data
{
    public class CustomerDao : SingleKeyDao<Customer, int>
    {
        internal CustomerDao() { }
        protected override Expression<Func<Customer, bool>> IsKey(int key)
        {
            return x => x.CustomerId == key;
        }
        protected override Expression<Func<Customer, int>> KeySelector =>
                x => x.CustomerId;

    }

}

