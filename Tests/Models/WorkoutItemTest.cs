using System;
using Xunit;
using WorkoutApi.Models;
using WorkoutApi.Enums;

namespace Tests.WorkoutApi.Models
{
    public class WorkoutItemTests
    {
        [Fact]
        public void WorkoutItem_ReturnsNewWorkoutItem() {
            WorkoutItem workoutItem = new WorkoutItem
            {
                Id = "ItemId",
                Workout = WorkoutType.Run,
                DistanceKm = 5,
                Duration = new TimeSpan(0, 5, 32),
                WorkoutDate = new DateTime(2016, 1, 10)
            };
            Assert.Equal("ItemId", workoutItem.Id);
            Assert.Equal(WorkoutType.Run, workoutItem.Workout);
            Assert.Equal(5, workoutItem.DistanceKm);
            Assert.Equal("00:05:32", workoutItem.Duration.ToString());
            Assert.Equal(0, workoutItem.Reps);
            Assert.Equal(0, workoutItem.Set);
            Assert.Equal(new DateTime(2016, 1, 10), workoutItem.WorkoutDate);
        }
    }
}