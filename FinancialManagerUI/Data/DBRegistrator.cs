using BudgetManagerDB.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerDB.Data
{
    static class DBRegistrator
    {
        /// <summary>
        /// Add base dates to server system
        /// </summary>
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration Configuration) => services
            .AddDbContext<BudgetDB>(opt=>
            {
                var type = Configuration["Type"];
                switch (type)
                {
                    case null: throw new InvalidOperationException("Type of database has not determined !");
                    default: throw new InvalidOperationException($"This type {type} isn't support");

                    case "MSSQL":
                        opt.UseSqlServer(Configuration.GetConnectionString(type));
                        break;
                    case "SQLite":
                        opt.UseSqlite(Configuration.GetConnectionString(type));
                        break;
                    case "InMemory":
                        opt.UseInMemoryDatabase("BudgetMangerDB.db");
                        break;
                }
            })
        ;
    }
}
