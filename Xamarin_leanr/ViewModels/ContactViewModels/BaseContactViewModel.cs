using FluentValidation;
using System;
using System.Collections.Generic;
using Xamarin_leanr.Model;
using Xamarin_leanr.Services.ContactRepo;
using Xamarin_leanr.ViewModels.Base;

namespace Xamarin_leanr.ViewModels.ContactViewModels
{
    public class BaseContactViewModel : BaseViewModel
    {

        public IValidator _contactValidator;
        public IContactRepository _contactRepository;


        #region Contact
        public Contact _contact;
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


        public List<Contact> _contactList;
        public List<Contact> ContactList
        {
            get => _contactList;
            set
            {
                _contactList = value;
                NotifyPropertyChanged("ContactList");
            }
        }
        #endregion
    }
}
