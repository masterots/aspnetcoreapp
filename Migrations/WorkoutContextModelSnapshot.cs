using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WorkoutApi.Models;

namespace aspnetcoreapp.Migrations
{
    [DbContext(typeof(WorkoutContext))]
    partial class WorkoutContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("WorkoutApi.Models.WorkoutItem", b =>
                {
                    b.Property<string>("Id");

                    b.Property<double>("DistanceKm");

                    b.Property<TimeSpan>("Duration");

                    b.Property<int>("Reps");

                    b.Property<int>("Set");

                    b.Property<int>("Workout");

                    b.Property<DateTime>("WorkoutDate");

                    b.HasKey("Id");

                    b.ToTable("Workouts");
                });
        }
    }
}
