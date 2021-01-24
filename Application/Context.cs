using Microsoft.EntityFrameworkCore;
using System;

namespace Application
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\mssqllocaldb;Database=Application;Integrated Security=True");
        }
    }
}