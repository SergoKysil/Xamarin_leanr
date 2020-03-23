using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin_leanr.Model;
using Xamarin_leanr.Services;
using Xamarin_leanr.Views.ContactViews;

namespace Xamarin_leanr.ViewModels.ContactViewModels
{
    public class ContactListViewModel : BaseViewModel
    {
        public ContactListViewModel(INavigation navigation)
        {
            _navigation = navigation;
            _contactRepository = new ContactRepository();


            AddCommand = new Command(async () => await ShowAddContact());
            DeleteAllContactsCommand = new Command(async () => await DeleteAllContacts());

            FetchContacts();
        }

        public ICommand AddCommand { get; private set; }
        public ICommand DeleteAllContactsCommand { get; private set; }



        void FetchContacts()
        {
            ContactList = _contactRepository.GetAllContacts();
        }
        async Task DeleteAllContacts()
        {
            bool isUserAccept = await Application.Current.MainPage.DisplayAlert("Лист Контактів", "Видалити всі контакти?", "OK", "Скасувати");
            if (isUserAccept)
            {
                _contactRepository.DeleteAllContacts();
                await _navigation.PushAsync(new AddContactView());
            }
        }

        async Task ShowAddContact()
        {
            await _navigation.PushAsync(new AddContactView());
        }

        async void ShowContactDetails(int selectedContactID)
        {
            await _navigation.PushAsync(new DetailsContactView(selectedContactID));
        }

        Contact _selectedContact;
        public Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                if (value != null)
                {
                    _selectedContact = value;
                    NotifyPropertyChanged("SelectedContact");
                    
                }
            }
        }

    }


    
}
