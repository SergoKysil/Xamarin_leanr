using System.Collections.Generic;
using Xamarin_leanr.Model;

namespace Xamarin_leanr.Services
{
    public interface IContactRepository
    {

        List<Contact> GetAllContacts();

        Contact GetContact(int contactId);

        void DeleteAllContacts();

        void DeleteContact(int contactId);

        void AddNewContact(Contact contact);

        void UpdateContact(Contact contact);
    }
}
