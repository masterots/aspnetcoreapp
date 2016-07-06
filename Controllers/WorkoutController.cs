using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WorkoutApi.Models;

namespace WorkoutApi.Controllers
{
    [Route("api/[controller]")]
    public class WorkoutController : Controller
    {
        public IWorkoutRepository WorkoutItems { get; set; }

        public WorkoutController(IWorkoutRepository workoutItems)
        {
            WorkoutItems = workoutItems;
        }

        [HttpGet]
        public IEnumerable<WorkoutItem> GetAll()
        {
            return WorkoutItems.GetAll();
        }

        [HttpPost]
        public void Create([FromBody] WorkoutItem item)
        {
            try
            {
                WorkoutItems.Add(item);
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: {e}");
            }
        }
    }
}