using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnetcoreapp.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    DistanceKm = table.Column<double>(nullable: false),
                    Duration = table.Column<TimeSpan>(nullable: false),
                    Reps = table.Column<int>(nullable: false),
                    Set = table.Column<int>(nullable: false),
                    Workout = table.Column<int>(nullable: false),
                    WorkoutDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Workouts");
        }
    }
}
