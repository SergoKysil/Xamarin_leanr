using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin_leanr.Model;
using Xamarin_leanr.Services.ToDoRepo;
using Xamarin_leanr.Validator;
using Xamarin_leanr.Views.ToDoViews;

namespace Xamarin_leanr.ViewModels.ToDoViewModels
{
    public class AddToDoViewModel : BaseToDoViewModel
    {
        public AddToDoViewModel(INavigation navigation)
        {
            _navigation = navigation;
            _todoValidator = new ToDoValidator();
            _todo = new ToDo();
            _todoRepository = new ToDoRepository();

            AddToDoCommand = new Command(async () => await AddToDo());
            ViewAllToDosCommand = new Command(async () => await ShowToDoList());

        }

        public ICommand AddToDoCommand { get; private set; }
        public ICommand ViewAllToDosCommand { get; private set; }



        async Task AddToDo()
        {
            var validationResults = _todoValidator.Validate(_todo);

            if (validationResults.IsValid)
            {
                bool isUserAccept = await Application.Current.MainPage.DisplayAlert("Додавання завдання", "Зберегти завдання?", "OK", "Скасувати");
                if (isUserAccept)
                {
                    _todoRepository.AddNewToDo(_todo);
                    await _navigation.PushAsync(new ToDoListView());
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Додавання завдання", validationResults.Errors[0].ErrorMessage, "Ok");
            }
        }

        async Task ShowToDoList()
        {
            await _navigation.PopAsync();
        }

        public bool IsViewAll => _todoRepository.GetAllToDos().Count > 0 ? true : false;

    }
}
