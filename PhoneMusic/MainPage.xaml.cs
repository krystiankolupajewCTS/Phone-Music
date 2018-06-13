using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PhoneMusic
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void AddToTheDataBase(object sender, EventArgs e)
        {

            if (true)
            {

                DataBase_Button.Text = "Addded Text";
            }
        }
    }
}