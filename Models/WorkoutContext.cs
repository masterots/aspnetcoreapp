using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Collections.Generic;

namespace WorkoutApi.Models
{
    public class WorkoutContext : DbContext
    {
        public DbSet<WorkoutItem> Workouts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./workouts.db");
        }
    }
}