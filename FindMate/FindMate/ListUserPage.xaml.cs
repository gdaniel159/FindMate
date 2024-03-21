using System.Collections.Generic;
using System.Collections.ObjectModel;
using FindMate.Models;
using Xamarin.Forms;

namespace FindMate
{
	public partial class ListUserPage : ContentPage
	{
        public ObservableCollection<Usuario> Usuarios { get; set; }
        public ListUserPage ()
		{
            InitializeComponent();
            Usuarios = new ObservableCollection<Usuario>();
            listaUsuarios.ItemsSource = Usuarios;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Recuperar todos los usuarios de la base de datos y agregarlos a la lista
            List<Usuario> usuariosDesdeBD = App.Conexion.Table<Usuario>().ToList();
            Usuarios.Clear();
            foreach (var usuario in usuariosDesdeBD)
            {
                Usuarios.Add(usuario);
            }
        }
    }
}