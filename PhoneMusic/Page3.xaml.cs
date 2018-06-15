using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PhoneMusic
{
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }
        async void Database_function(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
