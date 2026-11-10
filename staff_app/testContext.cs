using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace staff_app
{
    public class testContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "server=localhost;user=Dima;database=staffDB;port=3306;password=123456abcd123456;CharSet=utf8;";

            optionsBuilder.UseMySql(connectionString);
        }
    }
}
