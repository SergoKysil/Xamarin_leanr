using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin_leanr.Model;
using Xamarin_leanr.Services.ContactRepo;
using Xamarin_leanr.Validator;

namespace Xamarin_leanr.ViewModels.ContactViewModels
{
    public class DetailsContactViewModel : BaseContactViewModel
    {

        public ICommand UpdateContactCommand { get; private set; }
        public ICommand DeleteContactCommand { get; private set; }

        public DetailsContactViewModel(INavigation navigation, int selectedContactID)
        {
            _navigation = navigation;
            _contactValidator = new ContactValidator();
            _contact = new Contact
            {
                ID = selectedContactID
            };
            _contactRepository = new ContactRepository();

            UpdateContactCommand = new Command(async () => await UpdateContact());
            DeleteContactCommand = new Command(async () => await DeleteContact());

            FetchContactDetails();
        }

        void FetchContactDetails()
        {
            _contact = _contactRepository.GetContact(_contact.ID);
        }

        async Task UpdateContact()
        {
            var validationResults = _contactValidator.Validate(_contact);

            if (validationResults.IsValid)
            {
                bool isUserAccept = await Application.Current.MainPage.DisplayAlert("Дані контакту", "Оновити дані?", "OK", "Скасувати");
                if (isUserAccept)
                {
                    _contactRepository.UpdateContact(_contact);
                    await _navigation.PopAsync();
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Add Contact", validationResults.Errors[0].ErrorMessage, "Ok");
            }
        }

        async Task DeleteContact()
        {
            bool isUserAccept = await Application.Current.MainPage.DisplayAlert("Дані контаку", "Видалити контакт?", "OK", "Скасувати");
            if (isUserAccept)
            {
                _contactRepository.DeleteContact(_contact.ID);
                await _navigation.PopAsync();
            }
        }
    }
}
