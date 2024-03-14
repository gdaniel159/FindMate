using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FindMate.View.FeedPosts;
using FindMate.View.NotificAlert;

namespace FindMate
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FeedPosts();
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
