using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Infraestructure.Context {

    public class ProvidersContext : DbContext {

        public ProvidersContext(DbContextOptions<ProvidersContext> options) : base(options) {

        }

        public DbSet<Providers> Providers { get; set; }
        public DbSet<Types> Types { get; set; }

        /*protected override void OnModelCreating (ModelBuilder builder) {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.Get)
        }*/

    }

}