using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMate.View.FeedComment;
using FindMate.View.FeedPosts;
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

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FeedPost());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FeedComments());
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NotificAlerts());
        }
    }
}