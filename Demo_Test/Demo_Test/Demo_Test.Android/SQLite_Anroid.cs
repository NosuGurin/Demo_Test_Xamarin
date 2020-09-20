using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Demo_Test.Droid;
using Demo_Test.Models;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Anroid))]
namespace Demo_Test.Droid
{
    public class SQLite_Anroid : ISQLite
    {
        public SQLite_Anroid() { }

        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFileName = "Demodb.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFileName);
            var conn = new SQLite.SQLiteConnection(path);

            return conn;
        }
    }
}