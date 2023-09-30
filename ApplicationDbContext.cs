using ComplexType.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexType
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PT722ME\\SQLEXPRESS;Database=DbContext;User Id=sa; Password=23042016;Trusted_Connection=True; MultipleActiveResultSets=true;Encrypt=False;");
            optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().OwnsOne(a => a.Author);
        }

        public DbSet<Book> Books { get; set;}
    }
}
