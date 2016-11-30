using OsaulenkoEgor_Diceus_Test.Model.AppModels;
using OsaulenkoEgor_Diceus_Test.Model.DataMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsaulenkoEgor_Diceus_Test.Model.DataRetrieval
{
    /// <summary>
    /// Constructor for TodoTable communication.
    /// </summary>
    public class TodoDataRetrieval
    {
        /// <summary>
        /// Returns the current todo table items count.
        /// </summary>
        public int TodoCount(List<Todo> _todolist)
        {
            TodoTable _todoTable = new TodoTable();
            return _todoTable.TodoCount(_todolist);
        }
        /// <summary>
        /// Returns list with all todo table items.
        /// </summary>
        public List<Todo> TodoGetAll(List<Todo> _todolist)
        {
            TodoTable _todoTable = new TodoTable();
            return _todoTable.TodoGetAll(_todolist);
        }
        /// <summary>
        /// Returns list with all active todo table items.
        /// </summary>
        public List<Todo> TodoGetAllActive(List<Todo> _todolist)
        {
            TodoTable _todoTable = new TodoTable();
            return _todoTable.TodoGetAllActive(_todolist);
        }
        /// <summary>
        /// Returns list with all inactive todo table items.
        /// </summary>
        public List<Todo> TodoGetAllInactive(List<Todo> _todolist)
        {
            TodoTable _todoTable = new TodoTable();
            return _todoTable.TodoGetAllInactive(_todolist);
        }
        /// <summary>
        /// Insert a new todo item to the todo table.
        /// </summary>
        /// <param x:Name="todo">Item to insert</param>
        public List<Todo> TodoInsert(Todo todo, List<Todo> _todolist)
        {
            TodoTable _todoTable = new TodoTable();
            return _todoTable.TodoInsert(todo, _todolist);
        }
        /// <summary>
        /// Updates an item from the Todo Table.
        /// </summary>
        /// <param x:Name="indexTodo">Index of item to remove</param>
        /// <param x:Name="updatedTodo">updated item</param>
        public List<Todo> TodoUpdate(int indexTodo, Todo updatedTodo, List<Todo> _todolist)
        {
            TodoTable _todoTable = new TodoTable();
            return _todoTable.TodoUpdate(indexTodo, updatedTodo, _todolist);
        }
        /// <summary>
        /// Switches active stance of a Todo item by its Id.
        /// </summary>
        /// <param x:Name="indexTodo">Index of item</param>
        public List<Todo> TodoDeactivateActivate(int indexTodo, List<Todo> _todolist)
        {
            TodoTable _todoTable = new TodoTable();
            return _todoTable.TodoDeactivateActivate(indexTodo, _todolist);
        }
        /// <summary>
        /// Removes item from Todo Table by its index.
        /// </summary>
        /// <param x:Name="indexTodo">Index of item to remove</param>
        public List<Todo> TodoRemove(int indexTodo, List<Todo> _todolist)
        {
            TodoTable _todoTable = new TodoTable();
            return _todoTable.TodoRemove(indexTodo, _todolist);
        }
        /// <summary>
        /// Removes all items from Todo Table.
        /// </summary>
        public List<Todo> TodoClearTable(List<Todo> _todolist)
        {
            TodoTable _todoTable = new TodoTable();
            return _todoTable.TodoClearTable(_todolist);
        }
    }
}
