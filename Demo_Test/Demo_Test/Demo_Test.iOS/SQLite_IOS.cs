using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Demo_Test.iOS;
using Demo_Test.Models;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_IOS))]
namespace Demo_Test.iOS
{
    public class SQLite_IOS : ISQLite
    {
        public SQLite_IOS() { }

        public SQLite.SQLiteConnection GetConnection()
        {
            var filename = "Demodb.db3";
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, filename);
            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }
    }
}