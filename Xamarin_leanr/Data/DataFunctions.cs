using SQLite;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin_leanr.Model;
using System.Linq;

namespace Xamarin_leanr.Data
{
    public class DataFunctions
    {
        public const string DBName = "Xamarin_learn.db";
        static SQLiteConnection connection;

        public DataFunctions()
        {
            connection = DependencyService.Get<ISQLite>().GetConnection();
            connection.CreateTable<Contact>();
            connection.CreateTable<ToDo>();
        }


        #region ContactDataDunctions
        //Get all Contacts from data
        public List<Contact> GetAllContacts()
        {
            return (from data in connection.Table<Contact>() select data).ToList();
        }

        //Get one of contact from data
        public Contact GetContact(int id)
        {
            return connection.Table<Contact>().FirstOrDefault(c => c.ID == id);
        }

        //Delete all contacts from data
        public void DeleteAllContacts()
        {
            connection.DeleteAll<Contact>();
        }

        //Delete one of contact from data
        public void DeleteContact(int id)
        {
            connection.Delete<Contact>(id);
        }

        //Add new contact to data
        public void AddNewContact(Contact newContact)
        {
            connection.Insert(newContact);
        }

        //Update contact from data
        public void UpdateContact (Contact updatedContact)
        {
            connection.Update(updatedContact);
        }
        #endregion


        #region ToDoDataFunctions
        //Get all ToDo from data
        public List<ToDo> GetAllToDos()
        {
            return (from data in connection.Table<ToDo>() select data).ToList();
        }

        //Get one of ToDo from data
        public ToDo GetToDo(int id)
        {
            return connection.Table<ToDo>().FirstOrDefault(t => t.ID == id);
        }

        //Delete all ToDos from data
        public void DeleteAllToDos()
        {
            connection.DeleteAll<ToDo>();
        } 
        
        //Delete one of ToDO from data
        public void DeleteToDo(int id)
        {
            connection.Delete<ToDo>(id);
        }

        //Add new ToDo to data
        public void AddNewToDo(ToDo newToDo)
        {
            connection.Insert(newToDo);
        }

       
        #endregion



    }
}
