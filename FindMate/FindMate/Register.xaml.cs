using FindMate.Models;
using FindMate.Rest;
using Newtonsoft.Json.Linq;
using System;
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

        private async void btnRegister_Clicked(object sender, EventArgs e)
        {
            string email = entryEmail.Text;
            string dni = entryDNI.Text;
            string numero = entryPhone.Text;
            string password = entryPsw.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(numero) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
                return;
            }
            
            Usuario nuevoUsuario = new Usuario
            {
                Email = email,
                DNI = dni,
                Numero = numero,
                Password = password
            };

            var nuevoUsuarioJson = new JObject(
                new JProperty("usuario", "German"),
                new JProperty("email", "gdaniel.cs3@gmail.com"),
                new JProperty("password", "1234")
            );

            try
            {
                // Insertar un nuevo usuario
                App.Conexion.Insert(nuevoUsuario);
                var apiService = new ApiService();
                var response = await apiService.CreateUsuariosAsync(nuevoUsuarioJson.ToString());
                if (response != null)
                {

                    // Leer el contenido de la respuesta
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Imprimir la respuesta en la consola
                    Console.WriteLine("Response from API:");
                    Console.WriteLine(responseContent);

                    // Usuario creado exitosamente en el servidor
                    await Navigation.PushAsync(new RegisterMessage());

                    // Limpieza de campos
                    entryEmail.Text = string.Empty;
                    entryDNI.Text = string.Empty;
                    entryPhone.Text = string.Empty;
                    entryPsw.Text = string.Empty;
                }
                else
                {
                    // Manejar el caso de error al crear el usuario en el servidor
                    await DisplayAlert("Error", "No se pudo crear el usuario en el servidor.", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"No se pudo registrar el usuario. Error: {ex.Message}", "OK");
            }

        }
        private async void OnLabelClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login()); 
        }
    }
}