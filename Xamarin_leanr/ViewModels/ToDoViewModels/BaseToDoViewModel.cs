using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_leanr.ViewModels.Base;
using FluentValidation;
using Xamarin_leanr.Services.ToDoRepo;
using Xamarin_leanr.Model;

namespace Xamarin_leanr.ViewModels.ToDoViewModels
{
    public class BaseToDoViewModel : BaseViewModel
    {
        public IValidator _todoValidator;
        public IToDoRepository _todoRepository;

        #region ToDo

        public ToDo _todo;

        public string ToDoTitle
        {
            get => _todo.ToDoTitle;
            set
            {
                _todo.ToDoTitle = value;
                NotifyPropertyChanged("ToDoTitle");
            }
        }

        public string Content
        {
            get => _todo.Content;
            set
            {
                _todo.Content = value;
                NotifyPropertyChanged("Content");
            }
        }

        public DateTime CreatedAt
        {
            get => _todo.CreatedAt;
            set
            {
                _todo.CreatedAt = DateTime.Now;
                NotifyPropertyChanged("CreatedAt");
            }
        }

        public List<ToDo> _todoList;
        public List<ToDo> ToDoList
        {
            get => _todoList;
            set
            {
                _todoList = value;
                NotifyPropertyChanged("ContactList");
            }
        }

        #endregion


    }
}
