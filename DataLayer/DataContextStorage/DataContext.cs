using DataLayer.Model;
using System.Data.Entity;

namespace DataLayer.DataContextStorage
{
    public class DataContext : DbContext
    {
        public DataContext() :
            base("DefaultConnection")
        { }

        public DbSet<User> Users { get; set; }
    }
}
