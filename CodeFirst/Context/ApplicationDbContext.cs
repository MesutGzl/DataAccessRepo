using BasicDatabaseWithCodeFirst.Entities.Concrete;
using System.Data.Entity;


namespace BasicDatabaseWithCodeFirst.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            Database.Connection.ConnectionString = @"Server=WIN-KQEBK7JS2VM\SQLEXPRESS;Database=BasicDatabaseWithCodeFirstDb;Integrated Security=True;";
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

    }
}
