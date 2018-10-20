using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite.Droid.DBPath))]
namespace SQLite.Droid
{
	public class DBPath : IDataBasePath
    { 

        public string GetPath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, "bancoDados.db3");
        }
    }
}
