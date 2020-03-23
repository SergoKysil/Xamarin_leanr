using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin_leanr.Model;
using Xamarin_leanr.Services;
using Xamarin_leanr.Validator;
using Xamarin_leanr.Views.ContactViews;

namespace Xamarin_leanr.ViewModels.ContactViewModels
{
    public class AddContactViewModel : BaseViewModel
    {
        public ICommand AddContactCommand { get; private set; }
        public ICommand ViewAllContactsCommand { get; private set; }

        public AddContactViewModel(INavigation navigation)
        {
            _navigation = navigation;
            _contactValidator = new ContactValidator();
            _contact = new Contact();
            _contactRepository = new ContactRepository();

            AddContactCommand = new Command(async () => await AddContact());
            ViewAllContactsCommand = new Command(async () => await ShowContactList());
        }

        async Task AddContact()
        {
            var validationResults = _contactValidator.Validate(_contact);

            if (validationResults.IsValid)
            {
                bool isUserAccept = await Application.Current.MainPage.DisplayAlert("Додавання контакту", "Зберегти контакт?", "OK", "Скасувати");
                if (isUserAccept)
                {
                    _contactRepository.AddNewContact(_contact);
                    await _navigation.PushAsync(new ContactList());
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Додавання контакту", validationResults.Errors[0].ErrorMessage, "Ok");
            }
        }

        async Task ShowContactList()
        {
            await _navigation.PopAsync();
        }

        public bool IsViewAll => _contactRepository.GetAllContacts().Count > 0 ? true : false;
    }
}

