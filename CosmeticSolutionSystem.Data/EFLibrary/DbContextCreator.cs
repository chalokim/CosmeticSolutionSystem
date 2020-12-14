using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionSystem.Data
{
    public class DbContextCreator
    {
        public static Func<DbContext> Context { get; set; }
    }
}
