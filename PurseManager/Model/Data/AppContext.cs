using BudgetManagerLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace PurseManager.Model.Data
{
    public class AppContext : DbContext
    {
        public DbSet<MoneyModel> MoneyModel{get;set;}

        public AppContext()
        {
            Database.EnsureCreated();//if data base doesn't exist, this method create it
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PuseMangerDB;Trusted_Connection = true;");
        }
    }
}
