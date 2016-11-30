using OsaulenkoEgor_Diceus_Test.Model.DataRetrieval;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OsaulenkoEgor_Diceus_Test.Model.AppModels;
using OsaulenkoEgor_Diceus_Test.Configurations;

namespace OsaulenkoEgor_Diceus_Test.ViewModels
{
    public class InsertTodoViewModel
    {
        TodoDataRetrieval _dataRetrieval;
        List<Todo> _todolist;

        internal void SaveNewTodo(Todo _currentodo)
        {
            _todolist = AppSession.Instance.GetValue<List<Todo>>("todolist");
            _dataRetrieval = new TodoDataRetrieval();
            AppSession.Instance.RemoveValue("todolist");
            AppSession.Instance.SetValue("todolist", _dataRetrieval.TodoInsert(_currentodo, _todolist));
        }

        internal void UpdateTodo(int index, Todo _currentodo)
        {
            _todolist = AppSession.Instance.GetValue<List<Todo>>("todolist");
            _dataRetrieval = new TodoDataRetrieval();
            AppSession.Instance.RemoveValue("todolist");
            AppSession.Instance.SetValue("todolist", _dataRetrieval.TodoUpdate(index, _currentodo, _todolist));
        }
    }
}
