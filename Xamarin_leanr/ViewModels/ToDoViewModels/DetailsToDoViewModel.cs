using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin_leanr.Model;
using Xamarin_leanr.Services.ToDoRepo;
using Xamarin_leanr.Validator;

namespace Xamarin_leanr.ViewModels.ToDoViewModels
{
    public class DetailsToDoViewModel : BaseToDoViewModel
    {
        public DetailsToDoViewModel(INavigation navigation, int selectedToDoID)
        {
            _navigation = navigation;
            _todoValidator = new ToDoValidator();
            _todoRepository = new ToDoRepository();
            _todo = new ToDo
            {
                ID = selectedToDoID
            };

            UpdateToDoCommand = new Command(async () => await UpdateToDo());
            DeleteToDoCommand = new Command(async () => await DeleteToDo());

            FetchToDoDetails();
        }


        void FetchToDoDetails()
        {
            _todo = _todoRepository.GetToDo(_todo.ID);
        }

        public ICommand UpdateToDoCommand { get; private set; }
        public ICommand DeleteToDoCommand { get; private set; }


        async Task UpdateToDo()
        {
            var validationResults = _todoValidator.Validate(_todo);

            if (validationResults.IsValid)
            {
                bool isUserAccept = await Application.Current.MainPage.DisplayAlert("Дані", "Оновити дані?", "OK", "Скасувати");
                if (isUserAccept)
                {
                    _todoRepository.UpdateToDo(_todo);
                    await _navigation.PopAsync();
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Дані", validationResults.Errors[0].ErrorMessage, "Ok");
            }
        }

        async Task DeleteToDo()
        {
            bool isUserAccept = await Application.Current.MainPage.DisplayAlert("Дані", "Видалити Лист Завдань?", "OK", "Скасувати");
            if (isUserAccept)
            {
                _todoRepository.DeleteToDo(_todo.ID);
                await _navigation.PopAsync();
            }
        }

    }
}
