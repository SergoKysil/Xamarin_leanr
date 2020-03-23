using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_leanr.Model;

namespace Xamarin_leanr.Services.ToDoRepo
{
    public interface IToDoRepository
    {
        List<ToDo> GetAllToDos();

        ToDo GetToDo(int toDoId);

        void DeleteAllToDos();

        void DeleteToDo(int toDoId);

        void AddNewToDo(ToDo toDo);

        void UpdateToDo(ToDo toDo);

    }
}
