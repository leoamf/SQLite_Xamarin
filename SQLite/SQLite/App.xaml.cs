using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SQLite
{
    public partial class App : Application
    {
        private static SQLiteConnection _db;

        public static SQLiteConnection BD
        {
            get{
                if (_db == null){
                    string path = DependencyService.Get<IDataBasePath>().GetPath();
                    _db = new SQLiteConnection(path);
                    _db.CreateTable<Aluno>();
                }
                return _db;

            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
