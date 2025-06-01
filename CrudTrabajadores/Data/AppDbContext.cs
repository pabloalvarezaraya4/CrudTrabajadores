using CrudTrabajadores.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CrudTrabajadores.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Trabajador> Trabajadores { get; set; }
    }
}
