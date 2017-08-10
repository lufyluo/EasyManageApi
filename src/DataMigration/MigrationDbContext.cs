using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDomain.Db;
using Microsoft.EntityFrameworkCore;

namespace DataMigration
{
    public class MigrationDbContext:EmDBcontext
    {
        public MigrationDbContext(DbContextOptions<EmDBcontext> options) : base(options)
        {
           
        }

    }
}
