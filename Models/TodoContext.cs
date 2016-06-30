using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Collections.Generic;

namespace TodoApi.Models {
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Filename=./todos.db");
        }
    }


}