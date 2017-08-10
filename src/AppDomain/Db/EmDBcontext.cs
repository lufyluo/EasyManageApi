using AppDomain.Entities;
using Microsoft.EntityFrameworkCore;
using ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AppDomain.Db
{
    public class EmDBcontext:DbContext
    {
        public EmDBcontext(DbContextOptions<EmDBcontext> options) :base(options)
        {
          
        }
       
        //public virtual DbSet<AddressEntity> Address { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var assembly  = AssemblyLoadContext.Default.LoadFromAssemblyPath(pathTodll);
            modelBuilder.AddEntityConfigurationsFromAssembly(Assembly.Load(new AssemblyName(GetType().AssemblyQualifiedName)));
        }
    }
}
