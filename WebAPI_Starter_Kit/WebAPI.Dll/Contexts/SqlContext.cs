using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Dll.DataModels;

namespace WebAPI.Dll.Contexts
{
    public class SqlContext : DbContext
    {
        //public static string conn = "BondIssuanceConnectionString";
        public SqlContext() : base("TestDB")
        {
            this.Configuration.LazyLoadingEnabled = false;

        }
        public virtual DbSet<Product> Products { get; set; }
       


    }
}
