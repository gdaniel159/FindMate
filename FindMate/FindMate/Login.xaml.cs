using FindMate.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindMate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        private readonly LoginViewModel viewModel;
        public Login()
        {
            InitializeComponent();
            viewModel = new LoginViewModel();
            BindingContext = viewModel;
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