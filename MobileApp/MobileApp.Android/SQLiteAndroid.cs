using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobileApp;
using System.IO;

namespace MobileApp.Droid
{
    class SQLiteAndroid : ISQLite
    {
        public SQLiteAndroid() { }
        public string GetDatabasePath(string sqliteFilename)
        {
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            return path;
        }
    }
}