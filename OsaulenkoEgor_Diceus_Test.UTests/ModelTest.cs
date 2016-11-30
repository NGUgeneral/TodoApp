using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OsaulenkoEgor_Diceus_Test.Model.DataRetrieval;
using OsaulenkoEgor_Diceus_Test.Model.AppModels;
using System.Collections.Generic;
using System.Linq;

namespace OsaulenkoEgor_Diceus_Test.UTests
{
    [TestClass]
    public class ModelTest
    {
        List<Todo> _todolist = new List<Todo>();

        private void AddDummyData()
        {
            TodoDataRetrieval _dataRetrieval = new TodoDataRetrieval();
            Todo item1 = new Todo()
            {
                Active = true,
                TimeCreated = DateTime.Now,
                Title = "item 1"
            };
            _todolist.Add(item1);
            Todo item2 = new Todo()
            {
                Active = false,
                TimeCreated = DateTime.Now,
                Title = "item 2"
            };
            _todolist.Add(item2);
            Todo item3 = new Todo()
            {
                Active = true,
                TimeCreated = DateTime.Now,
                Title = "item 3"
            };
            _todolist.Add(item3);
        }

        [TestMethod]
        public void TodoInsert_Test()
        {
            TodoDataRetrieval _dataRetrieval = new TodoDataRetrieval();
            Todo item = new Todo();

            _todolist.Clear();
            _todolist = _dataRetrieval.TodoInsert(item, _todolist);
            int count = _dataRetrieval.TodoCount(_todolist);

            Assert.AreEqual(count, 1);
        }

        [TestMethod]
        public void TodoGetAllActive_Test()
        {
            TodoDataRetrieval _dataRetrieval = new TodoDataRetrieval();

            _todolist.Clear();
            AddDummyData();

            _todolist = _dataRetrieval.TodoGetAllActive(_todolist);
            int count = _dataRetrieval.TodoCount(_todolist);

            Assert.AreEqual(count, 2);
        }

        [TestMethod]
        public void TodoGetAllInactive_Test()
        {
            TodoDataRetrieval _dataRetrieval = new TodoDataRetrieval();

            _todolist.Clear();
            AddDummyData();

            _todolist = _dataRetrieval.TodoGetAllInactive(_todolist);
            int count = _dataRetrieval.TodoCount(_todolist);

            Assert.AreEqual(count, 1);
        }

        [TestMethod]
        public void TodoRemove_Test()
        {
            TodoDataRetrieval _dataRetrieval = new TodoDataRetrieval();

            _todolist.Clear();
            AddDummyData();

            _todolist = _dataRetrieval.TodoRemove(1, _todolist);
            int count = _dataRetrieval.TodoCount(_todolist);

            Assert.AreEqual(count, 2);
        }

        [TestMethod]
        public void TodoUpdate_Test()
        {
            TodoDataRetrieval _dataRetrieval = new TodoDataRetrieval();

            _todolist.Clear();
            AddDummyData();

            Todo item4 = new Todo()
            {
                Title = "item4"
            };

            _todolist = _dataRetrieval.TodoUpdate(0, item4, _todolist);
            
            string title = _dataRetrieval.TodoGetAll(_todolist).First().Title;

            Assert.AreEqual(title, "item4");
        }

        [TestMethod]
        public void TodoDeactivateActivate_Test()
        {
            TodoDataRetrieval _dataRetrieval = new TodoDataRetrieval();

            _todolist.Clear();

            Todo item1 = new Todo()
            {
                Active = true
            };

            _todolist =_dataRetrieval.TodoInsert(item1, _todolist);

            int _item1index = _todolist.IndexOf(item1);
            bool active = _dataRetrieval.TodoDeactivateActivate(_item1index, _todolist).First().Active;

            Assert.AreEqual(active, false);
        }

    }
}
