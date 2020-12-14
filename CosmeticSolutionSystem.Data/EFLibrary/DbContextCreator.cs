using System;
using CosmeticSolutionSystem.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CosmeticSolutionSystem.Data
{
    public class DbContextCreator
    {
        public static Func<DbContext> Context { get; set; }
    }
}
