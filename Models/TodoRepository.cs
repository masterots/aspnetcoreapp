// using System;
// using System.Collections.Generic;
// using System.Collections.Concurrent;

// namespace TodoApi.Models
// {
//     public class TodoRepository : ITodoRepository
//     {
//         private static ConcurrentDictionary<string, WorkoutItem> _todos = new ConcurrentDictionary<string, WorkoutItem>();

//         public TodoRepository()
//         {
//             Add(new WorkoutItem { Name = "Item1" });
//         }

//         public void Add(WorkoutItem item)
//         {
//             item.Id = Guid.NewGuid().ToString();
//             _todos[item.Id] = item;
//         }

//         public WorkoutItem Find(string key)
//         {
//             WorkoutItem item;
//             _todos.TryGetValue(key, out item);
//             return item;
//         }

//         public WorkoutItem Remove(string key)
//         {
//             WorkoutItem item;
//             _todos.TryGetValue(key, out item);
//             _todos.TryRemove(key, out item);
//             return item;
//         }

//         public void Update(WorkoutItem item)
//         {
//             _todos[item.Id] = item;
//         }

//         public IEnumerable<WorkoutItem> GetAll()
//         {
//             return _todos.Values;
//         }
//     }
// }