using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using Xamarin_leanr.Model;
using Xamarin_leanr.Services;

namespace Xamarin_leanr.ViewModels
{
    public class BaseContactViewModel : INotifyPropertyChanged
    {

        public Contact _contact;

        public INavigation _navigation;
        public IValidator _contactValidator;
        public IContactRepository _contactRepository;


        public string ContactName
        {
            get => _contact.ContactName;
            set
            {
                _contact.ContactName = value;
                NotifyPropertyChanged("ContactName");
            }
        }
        public string ContactSurname
        {
            get => _contact.ContactSurname;
            set
            {
                _contact.ContactSurname = value;
                NotifyPropertyChanged("ContactSurname");
            }
        }

        public string Gender
        {
            get => _contact.Gender;
            set
            {
                _contact.Gender = value;
                NotifyPropertyChanged("Gender");
            }
        }

        public DateTime DateOfBirthday
        {
            get => _contact.DateOfBirthday;
            set
            {
                _contact.DateOfBirthday = value;
                NotifyPropertyChanged("DateOfBirthday");
            }
        }

        public string Address
        {
            get => _contact.Address;
            set
            {
                _contact.Address = value;
                NotifyPropertyChanged("Address");
            }
        }

        public string MobileNumber
        {
            get => _contact.MobileNumber;
            set
            {
                _contact.MobileNumber = value;
                NotifyPropertyChanged("MobileNumber");
            }
        }

        public string Email
        {
            get => _contact.Email;
            set
            {
                _contact.Email = value;
                NotifyPropertyChanged("Email");
            }
        }


        List<Contact> _contactList;
        public List<Contact> ContactList
        {
            get => _contactList;
            set
            {
                _contactList = value;
                NotifyPropertyChanged("ContactList");
            }
        }


        #region INotifyPropertyChanged    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
