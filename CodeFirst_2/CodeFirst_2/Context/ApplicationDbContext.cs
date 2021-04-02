using CodeFirst_2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_2.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {
            Database.Connection.ConnectionString = @"Server=WIN-R6V1GMLCD90\SQLEXPRESS;Database=YMS5179CodeFirst_2Db;Integrated Security=True;";
        }

        public DbSet<Product> Products { get; set; }
    }
}
