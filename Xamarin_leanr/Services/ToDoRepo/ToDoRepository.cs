using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_leanr.Data;
using Xamarin_leanr.Model;

namespace Xamarin_leanr.Services.ToDoRepo
{
    public class ToDoRepository : IToDoRepository
    {

        readonly DataFunctions _dataFunctions;
        public void AddNewToDo(ToDo toDo)
        {
            _dataFunctions.AddNewToDo(toDo);
        }

        public void DeleteAllToDos()
        {
            _dataFunctions.DeleteAllToDos();
        }

        public void DeleteToDo(int toDoId)
        {
            _dataFunctions.DeleteToDo(toDoId);
        }

        public List<ToDo> GetAllToDos()
        {
            return _dataFunctions.GetAllToDos();
        }

        public ToDo GetToDo(int toDoId)
        {
            return _dataFunctions.GetToDo(toDoId);
        }
    }
}
