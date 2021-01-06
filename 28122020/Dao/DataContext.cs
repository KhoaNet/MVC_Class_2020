using Dao.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Dao
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = Directory.GetCurrentDirectory();
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("settings.json");
            var config = builder.Build();

            optionsBuilder.UseSqlServer(config["ConnectionsStrings:ConectSql"]);

        }

        public DbSet<EmployeeModel> EmployeeModel { get; set; }
        public DbSet<ShoeModel> ShoeModel { get; set; }
    }
}
