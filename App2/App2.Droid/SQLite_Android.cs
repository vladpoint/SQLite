using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App2;
using App2.Droid;
using Xamarin.Forms;
using System.IO;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

[assembly: Dependency (typeof(SQLite_Android))]
namespace App2.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android()
        {

        }

        public SQLite.SQLiteConnection GetConnection()
        {
            var dbname = "Agenda.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, dbname);
            Console.WriteLine(path);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}