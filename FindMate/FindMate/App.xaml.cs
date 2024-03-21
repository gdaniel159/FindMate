using FindMate.Models;
using SQLite;
using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindMate
{
    public partial class App : Application
    {
        public static string DatabasePath;
        public static SQLiteConnection Conexion;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
        }

        protected override void OnStart()
        {
            DatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FindMateDB.db3");
            Conexion = new SQLiteConnection(DatabasePath);
            Conexion.CreateTable<Usuario>();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
