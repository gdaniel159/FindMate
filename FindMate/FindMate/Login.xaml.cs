using FindMate.View.FeedComment;
using FindMate.View.FeedPosts;
using FindMate.View.NotificAlert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindMate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FeedComment());
        }
        private void btnRegister_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register());
        }

        private void btnOlvidar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgotPassword());
        }
    }
}