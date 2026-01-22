using Microsoft.EntityFrameworkCore;
using ToDoApp.Models;

namespace ToDoApp.Context
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {
        }
        public DbSet<ToDo> ToDos { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Status> Statuses { get; set; } = null!;

        //seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "work", Name = "Travail" },
                new Category { CategoryId = "home", Name = "Maison" },
                new Category { CategoryId = "ex", Name = "Exercice" },
                new Category { CategoryId = "shop", Name = "Shopping" },
                new Category { CategoryId = "call", Name = "Contact" }
            );
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "open", Name = "Ouvert" },
                new Status { StatusId = "closed", Name = "Completed" }
            );
        }
    }
}
