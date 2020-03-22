using System.Collections.Generic;
using Xamarin_leanr.Data;
using Xamarin_leanr.Model;

namespace Xamarin_leanr.Services
{
    public class ContactRepository : IContactRepository
    {

        readonly DataFunctions _dataFunctions;
        public ContactRepository()
        {
            _dataFunctions = new DataFunctions();
        }

        public void AddNewContact(Contact contact)
        {
            _dataFunctions.AddNewContact(contact);
        }

        public void DeleteAllContacts()
        {
            _dataFunctions.DeleteAllContacts();
        }

        public void DeleteContact(int contactId)
        {
            _dataFunctions.DeleteContact(contactId);
        }

        public List<Contact> GetAllContacts()
        {
            return _dataFunctions.GetAllContacts();
        }

        public Contact GetContact(int contactId)
        {
            return _dataFunctions.GetContact(contactId);
        }

        public void UpdateContact(Contact contact)
        {
            _dataFunctions.UpdateContact(contact);
        }
    }
}
