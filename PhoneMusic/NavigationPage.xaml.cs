using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PhoneMusic
{
    public partial class NewMain : ContentPage
    {
        public NewMain()
        {
            InitializeComponent();
        }
        async void NewDatabase(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        async void NewPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
                
            
    }
}
