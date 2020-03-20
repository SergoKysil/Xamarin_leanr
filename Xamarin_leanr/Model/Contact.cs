using SQLite;


namespace Xamarin_leanr.Model
{
    [Table ("Contacts")]
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string ContactName { get; set; }
        public string ContactSurname { get; set; }
        public string Gender { get; set; }
        public string DateOfBirthday { get; set; }
        public string Address { get; set; }
        public string  MobileNumber { get; set; }
        public string Email { get; set; }

    }
}
