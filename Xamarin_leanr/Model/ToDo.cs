using System;
using SQLite;

namespace Xamarin_leanr.Model
{
    public class ToDo
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string ToDoTitle { get; set; }
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}
