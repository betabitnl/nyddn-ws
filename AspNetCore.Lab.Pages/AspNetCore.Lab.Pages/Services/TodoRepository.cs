using AspNetCore.Lab.Pages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Lab.Pages.Services
{
    public class TodoRepository
    {
        private IList<TodoItem> _todoItems;

        public TodoRepository()
        {
            _todoItems = new List<TodoItem>();
        }

        public void Save(TodoItem task)
        {
            task.DateTime = DateTime.Now;
            _todoItems.Add(task);
        }

        public IEnumerable<TodoItem> ListAll() => _todoItems;
    }
}
