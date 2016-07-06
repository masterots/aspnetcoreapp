using System.Collections.Generic;

namespace WorkoutApi.Models
{
    public interface IWorkoutRepository
    {
        void Add(WorkoutItem item);
        IEnumerable<WorkoutItem> GetAll();
        // WorkoutItem Find(int id);
        // WorkoutItem Remove(int id);
        // void Update(WorkoutItem item);
    }
}