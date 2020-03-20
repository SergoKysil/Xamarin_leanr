using SQLite;
using System.IO;
using Xamarin_leanr.Data;
using Xamarin_leanr.Droid.Implementation;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidSQLite))]


namespace Xamarin_leanr.Droid.Implementation
{

    class AndroidSQLite : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), DataFunctions.DBName);
            var conn = new SQLiteConnection(path);
            return conn;
        }
    }
}