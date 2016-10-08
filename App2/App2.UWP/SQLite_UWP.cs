using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App2;
using App2.UWP;
using Xamarin.Forms;
using System.IO;
using Windows.Storage;

[assembly: Dependency (typeof(SQLite_UWP))]
namespace App2.UWP
{
    public class SQLite_UWP : ISQLite
    {
        public SQLite_UWP()
        {

        }
        public SQLite.SQLiteConnection GetConnection()
        {
            var dbname = "Agenda.db3";
            string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, dbname);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}
