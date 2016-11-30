using OsaulenkoEgor_Diceus_Test.Model.DataRetrieval;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using OsaulenkoEgor_Diceus_Test.Model.AppModels;
using OsaulenkoEgor_Diceus_Test.Configurations;

namespace OsaulenkoEgor_Diceus_Test.ViewModels
{
    public class TodoListViewModel
    {
        TodoDataRetrieval _dataRetrieval;
        List<Todo> _todolist;

        internal List<Todo> GetAllActiveTodos()
        {
            _todolist = AppSession.Instance.GetValue<List<Todo>>("todolist");
            _dataRetrieval = new TodoDataRetrieval();
            return _dataRetrieval.TodoGetAllActive(_todolist);
        }

        internal void DeactivateTodo(Todo selecteditem)
        {
            _todolist = AppSession.Instance.GetValue<List<Todo>>("todolist");
            _dataRetrieval = new TodoDataRetrieval();
            int index = _todolist.IndexOf(selecteditem);
            AppSession.Instance.RemoveValue("todolist");
            AppSession.Instance.SetValue("todolist", _dataRetrieval.TodoDeactivateActivate(index, _todolist));
        }
    }
}
