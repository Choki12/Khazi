
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KhaziMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
        }

        void OnRegClicked(object sender, EventArgs args)
        {
            DisplayAlert("Alert", "Registration complete", "OK");
            Navigation.PushAsync(new Dashboard());
        }
    }
}