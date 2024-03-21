using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMate.View.NotificAlert;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindMate.View.FeedPrincipal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FeedPrincipal : ContentPage
    {
        public FeedPrincipal()
        {
            InitializeComponent();
        }

        private void btnVerDetalles_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VerDetalles());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NotificAlerts());
        }
    }
}