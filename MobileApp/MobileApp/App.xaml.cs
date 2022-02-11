using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using MobileApp.DataBase;

[assembly: ExportFont("MaterialIcons-Regular.ttf", Alias = "Material")]
namespace MobileApp
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "Aplus.db";
        public static LocalRepository database;
        public static LocalRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new LocalRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AuthorizationPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
