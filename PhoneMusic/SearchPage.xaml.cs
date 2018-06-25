using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PhoneMusic
{
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
        }
        async void Submit(object sender,EventArgs e)
        {
            await DisplayAlert ("Alert","Search Submited....", "Ok");
        }
    } 
}
