using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using WorkoutApi.Enums;

namespace WorkoutApi.Models
{
    public class WorkoutRepository : IWorkoutRepository
    {
        private static WorkoutContext _db = new WorkoutContext();
        private static ConcurrentDictionary<string, WorkoutItem> _workouts = new ConcurrentDictionary<string, WorkoutItem>();

        public WorkoutRepository() { }

        public void Add(WorkoutItem item)
        {
            WorkoutItem workoutItem;
            if (string.IsNullOrWhiteSpace(item.Id))
            {
                workoutItem = WorkoutItem.Create(item);
            }
            else
            {
                workoutItem = item;
            }

            _db.Workouts.Add(workoutItem);
            _db.SaveChanges();
        }

        public IEnumerable<WorkoutItem> GetAll()
        {
            return _db.Workouts.ToList();
        }
    }
}