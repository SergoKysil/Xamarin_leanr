using SQLite;

/// <summary>
/// Using for get connection to DB
/// </summary>
namespace Xamarin_leanr.Data
{
  
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
