using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DataContexts
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options)
            : base(options) { }

        public DbSet<Todo> Todo { get; set; }

        private void TodoConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>(w =>
            {
                w.HasKey(k => k.Id);
                w.Property(c => c.Id).ValueGeneratedOnAdd();
            });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            TodoConfiguration(modelBuilder);
        }

    }
}
