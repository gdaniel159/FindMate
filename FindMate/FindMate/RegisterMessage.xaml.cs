﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindMate
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterMessage : ContentPage
	{
		public RegisterMessage ()
		{
			InitializeComponent ();
		}

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }
    }
}