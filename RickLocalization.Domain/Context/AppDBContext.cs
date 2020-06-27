using Microsoft.EntityFrameworkCore;
using RickLocalization.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Domain.Context {

    public class AppDBContext : DbContext {

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Viajante> Viajantes { get; set; }
        public DbSet<Dimensao> Dimensoes { get; set; }
        public DbSet<LogViagem> LogsViagens { get; set; }
    }
}
