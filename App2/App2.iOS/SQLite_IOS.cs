using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App2;
using App2.iOS;
using Xamarin.Forms;
using System.IO;

//using MonoTouch.Foundation;
//using MonoTouch.UIKit;

[assembly: Dependency(typeof(SQLite_IOS))]
namespace App2.iOS
{
    public class SQLite_IOS : ISQLite
    {
        public SQLite_IOS()
        {

        }

        public SQLite.SQLiteConnection GetConnection()
        {
            var dbname = "Agenda.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
            var path = Path.Combine(libraryPath, dbname);
            Console.WriteLine(path);
            //if (!File.Exists(path))
            //{
            //    File.Copy(dbname, path);
            //}
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }