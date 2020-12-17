using CosmeticSolutionSystem.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLibrary
{
    public class DbContextCreator
    {
        private const string ConnectionString = "metadata=res://*/CosmeticSolutionSystem.csdl|res://*/CosmeticSolutionSystem.ssdl|res://*/CosmeticSolutionSystem.msl;provider=System.Data.SqlClient;provider connection string=\"data source=cn76.ipdisk.co.kr,3423;initial catalog=CosmeticSolutionSystem;user id=8f;password=1;MultipleActiveResultSets=True;App=EntityFramework\"";

        public static CosmeticSolutionSystemEntities Create()
        {
            CosmeticSolutionSystemEntities context = new CosmeticSolutionSystemEntities(ConnectionString);
            
            context.Configuration.ProxyCreationEnabled = false;

            return context;
        }
    }
}

namespace CosmeticSolutionSystem.Data
{
    public partial class CosmeticSolutionSystemEntities
    {
        public CosmeticSolutionSystemEntities(string connectionString) : base(connectionString)
        {
        }
    }
}
