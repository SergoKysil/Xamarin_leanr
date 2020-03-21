using SQLite;
using System;

namespace Xamarin_leanr.Model
{
    [Table ("Contacts")]
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        
        [NotNull]
        public string ContactName { get; set; }

        [NotNull]
        public string ContactSurname { get; set; }
       
        [NotNull]
        public string Gender { get; set; }
        public DateTime DateOfBirthday { get; set; }
        
        public string Address { get; set; }
        
        [NotNull]
        public string  MobileNumber { get; set; }
        public string Email { get; set; }

    }
}
