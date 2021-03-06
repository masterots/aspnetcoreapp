// using System.Collections.Generic;
// using Microsoft.AspNetCore.Mvc;
// using TodoApi.Models;

// namespace TodoApi.Controllers
// {
//     [Route("api/[controller]")]
//     public class TodoController : Controller
//     {
//         public ITodoRepository TodoItems { get; set; }
//         public TodoController(ITodoRepository todoItems)
//         {
//             TodoItems = todoItems;
//         }

//         public IEnumerable<WorkoutItem> GetAll()
//         {
//             return TodoItems.GetAll();
//         }

//         [HttpGet("{id}", Name = "GetTodo")]
//         public IActionResult GetById(string id)
//         {
//             var item = TodoItems.Find(id);
//             if (item == null)
//             {
//                 return NotFound();
//             }
//             return new ObjectResult(item);
//         }

//         [HttpPost]
//         public IActionResult Create([FromBody] WorkoutItem item)
//         {
//             if (item == null)
//             {
//                 return BadRequest();
//             }
//             TodoItems.Add(item);
//             return CreatedAtRoute("GetTodo", new { controller = "Todo", id = item.Id }, item);
//         }

//         [HttpPut]
//         public IActionResult Update(string id, [FromBody] WorkoutItem item)
//         {
//             if (item == null || item.Id != id)
//             {
//                 return BadRequest();
//             }

//             var todo = TodoItems.Find(id);
//             if (todo == null)
//             {
//                 return NotFound();
//             }

//             TodoItems.Update(item);
//             return new NoContentResult();
//         }

//         [HttpDelete("{id}")]
//         public void Delete(string id)
//         {
//             TodoItems.Remove(id);
//         }
//     }
// }