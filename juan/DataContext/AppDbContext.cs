using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using juan.DataContext.Models;

namespace juan.DataContext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> products { get; set; }
    }
}
