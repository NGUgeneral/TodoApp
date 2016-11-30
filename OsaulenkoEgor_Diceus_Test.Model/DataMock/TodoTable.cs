using OsaulenkoEgor_Diceus_Test.Model.AppModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsaulenkoEgor_Diceus_Test.Model.DataMock
{
    /// <summary>
    /// Constructor for mocking TodoTable.
    /// </summary>
    public class TodoTable
    {   
        /// <summary>
        /// Returns the current todo table items count.
        /// </summary>
        internal int TodoCount(List<Todo> _todotable)
        {
            return _todotable.Count();
        }
        /// <summary>
        /// Returns list with all todo table items.
        /// </summary>
        internal List<Todo> TodoGetAll(List<Todo> _todotable)
        {
            return _todotable;
        }
        /// <summary>
        /// Returns list with all active todo table items.
        /// </summary>
        internal List<Todo> TodoGetAllActive(List<Todo> _todotable)
        {
            List<Todo> _activelist = new List<Todo>();
            foreach(Todo todo in _todotable)
            {
                if(todo.Active)
                {
                    _activelist.Add(todo);
                }
            }
            return _activelist;
        }
        /// <summary>
        /// Returns list with all inactive todo table items.
        /// </summary>
        internal List<Todo> TodoGetAllInactive(List<Todo> _todotable)
        {
            List<Todo> _inactivelist = new List<Todo>();
            foreach (Todo todo in _todotable)
            {
                if (!todo.Active)
                {
                    _inactivelist.Add(todo);
                }
            }
            return _inactivelist;
        }
        /// <summary>
        /// Insert a new todo item to the todo table.
        /// </summary>
        /// <param x:Name="todo">Item to insert</param>
        internal List<Todo> TodoInsert(Todo todo, List<Todo> _todotable)
        {
            _todotable.Add(todo);
            return _todotable;
        }
        /// <summary>
        /// Removes item from Todo Table by its index.
        /// </summary>
        /// <param x:Name="indexTodo">Index of item to remove</param>
        internal List<Todo> TodoRemove(int indexTodo, List<Todo> _todotable)
        {
            _todotable.Remove(_todotable.ElementAt(indexTodo));
            return _todotable;
        }
        /// <summary>
        /// Updates an item from the Todo Table.
        /// </summary>
        /// <param x:Name="indexTodo">Index of item to remove</param>
        /// <param x:Name="updatedTodo">updated item</param>
        internal List<Todo> TodoUpdate(int indexTodo, Todo updatedTodo, List<Todo> _todotable)
        {
            TodoRemove(indexTodo, _todotable);
            _todotable.Insert(indexTodo, updatedTodo);
            return _todotable;
        }
        /// <summary>
        /// Switches active stance of a Todo item by its Id.
        /// </summary>
        /// <param x:Name="indexTodo">Index of item</param>
        internal List<Todo> TodoDeactivateActivate(int indexTodo, List<Todo> _todotable)
        {
            Todo _currenttodo = _todotable.ElementAt(indexTodo);
            _currenttodo.Active = _currenttodo.Active ? false : true;
            TodoUpdate(indexTodo, _currenttodo, _todotable);
            return _todotable;
        }
        /// <summary>
        /// Clears the whole table from items.
        /// </summary>
        internal List<Todo> TodoClearTable(List<Todo> _todotable)
        {
            _todotable.Clear();
            return _todotable;
        }
    }
}
