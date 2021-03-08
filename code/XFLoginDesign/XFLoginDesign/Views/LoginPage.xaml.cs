using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFLoginDesign.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void OnLoginTapped(System.Object sender, System.EventArgs e)
        {
        }

        async void OnNewUserTapped(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}
