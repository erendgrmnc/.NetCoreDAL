﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNova.DAL.DataContext
{
    public class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            AppConfiguration appConfig = new AppConfiguration();

            var opsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            opsBuilder.UseSqlServer(appConfig.SqlConnectionString);
            return new DatabaseContext(opsBuilder.Options);
        }
    }
}
