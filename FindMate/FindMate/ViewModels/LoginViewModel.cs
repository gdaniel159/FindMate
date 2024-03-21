using System;
using System.Windows.Input;
using FindMate.Models;
using FindMate.View.FeedPrincipal;
using Xamarin.Forms;

namespace FindMate.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string email;
        private string password;
        public string Email
        {
            get { return email; }
            set { SetProperty(ref email, value); }
        }

        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }
        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLogin);
        }
        private async void OnLogin()
        {
            if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
                return;
            }

            try
            {
                // Buscar el usuario en la base de datos
                Usuario usuario = App.Conexion.Table<Usuario>().FirstOrDefault(u => u.Email == Email && u.Password == Password);

                if (usuario != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Éxito", "Inicio de sesión exitoso.", "OK");
                    // Aquí puedes redirigir a la página principal
                    await Application.Current.MainPage.Navigation.PushAsync(new FeedPrincipal());
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Correo electrónico o contraseña incorrectos.", "OK");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", $"Error al iniciar sesión: {ex.Message}", "OK");
            }
        }
    }
}
