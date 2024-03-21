using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindMate.View.FeedPrincipal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VerDetalles : ContentPage
	{
		public VerDetalles ()
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FeedPrincipal());
        }
    }
}