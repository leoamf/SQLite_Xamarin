using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite.iOS.DBPath))]
namespace SQLite.iOS
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
