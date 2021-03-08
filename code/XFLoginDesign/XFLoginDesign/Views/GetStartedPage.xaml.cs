using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFLoginDesign.Views
{
    public partial class GetStartedPage : ContentPage
    {
        public GetStartedPage()
        {
            InitializeComponent();
        }

        async void OnGetStartedTapped(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
