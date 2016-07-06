using System;
using WorkoutApi.Enums;

namespace WorkoutApi.Models
{
    public class WorkoutItem
    {
        public string Id { get; set; }
        public WorkoutType Workout { get; set; }
        public double DistanceKm { get; set; }
        public TimeSpan Duration { get; set; }
        public int Reps { get; set; }
        public int Set { get; set; }
        public DateTime WorkoutDate { get; set; }

        public static WorkoutItem Create(WorkoutItem item)
        {
            return new WorkoutItem
            {
                Id = Guid.NewGuid().ToString(),
                Workout = item.Workout,
                DistanceKm = item.DistanceKm,
                Duration = item.Duration,
                Reps = item.Reps,
                Set = item.Set,
                WorkoutDate = DateTime.Now
            };
        }
    }
}