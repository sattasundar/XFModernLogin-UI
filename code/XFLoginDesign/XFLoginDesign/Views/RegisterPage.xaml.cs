using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFLoginDesign.Views
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        async void OnRegisterTapped(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void OnAlreadyUserTapped(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
