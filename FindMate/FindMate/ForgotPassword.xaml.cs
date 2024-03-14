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
	public partial class ForgotPassword : ContentPage
	{
		public ForgotPassword ()
		{
			InitializeComponent ();
		}
        private async void btnEnviarCodigo_Clicked(object sender, EventArgs e)
        {
        }

        private async void btnVerificar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RestorePassword());
        }
    }
}