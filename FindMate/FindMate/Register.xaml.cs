using FindMate.Models;
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
	public partial class Register : ContentPage
	{
		public Register ()
		{
			InitializeComponent ();
		}

        private void btnRegister_Clicked(object sender, EventArgs e)
        {
            string email = entryEmail.Text;
            string dni = entryDNI.Text;
            string numero = entryPhone.Text;
            string password = entryPsw.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(numero) || string.IsNullOrWhiteSpace(password))
            {
                DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
                return;
            }
            
            Usuario nuevoUsuario = new Usuario
            {
                Email = email,
                DNI = dni,
                Numero = numero,
                Password = password
            };

            try
            {
                // Insertar un nuevo usuario
                App.Conexion.Insert(nuevoUsuario);
                // DisplayAlert("Éxito", "Usuario registrado correctamente.", "OK");
                Navigation.PushAsync(new RegisterMessage());
                // Limpieza de campos
                entryEmail.Text = string.Empty;
                entryDNI.Text = string.Empty;
                entryPhone.Text = string.Empty;
                entryPsw.Text = string.Empty;
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", $"No se pudo registrar el usuario. Error: {ex.Message}", "OK");
            }

        }
        private async void OnLabelClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login()); 
        }
    }
}