using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin_leanr.Model;
using Xamarin_leanr.Services.ToDoRepo;
using Xamarin_leanr.Views.ToDoViews;

namespace Xamarin_leanr.ViewModels.ToDoViewModels
{
    public class ToDoListVeiwModel : BaseToDoViewModel
    {
        public ToDoListVeiwModel(INavigation navigation)
        {
            _navigation = navigation;
            _todoRepository = new ToDoRepository();


            AddTodoCommand = new Command(async () => await ShowAddToDoView());
            DeleteAllToDosCommand = new Command(async () => await DeleteAllToDos());


            FetchToDos();
        }


        void FetchToDos()
        {
            ToDoList = _todoRepository.GetAllToDos();
        }

        public ICommand AddTodoCommand { get; private set; }

        public ICommand DeleteAllToDosCommand { get; private set; }


        async Task DeleteAllToDos()
        {
            bool isUserAccept = await Application.Current.MainPage.DisplayAlert("Лист Завдань", "Видалити всі завдання?", "OK", "Скасувати");
            if (isUserAccept)
            {
                _todoRepository.DeleteAllToDos();
                await ShowAddToDoView();
            }
        }


        async Task ShowAddToDoView()
        {
            await _navigation.PushAsync(new AddToDoView());
        }


        async void ShowToDoDetails(int selectedContactID)
        {
            await _navigation.PushAsync(new DetailToDoView(selectedContactID));
        }

        ToDo _selectedToDo;
        public ToDo SelectedToDo
        {
            get => _selectedToDo;
            set
            {
                if (value != null)
                {
                    _selectedToDo = value;
                    NotifyPropertyChanged("SelectedToDo");
                    ShowToDoDetails(value.ID);
                }
            }
        }


    }
}
