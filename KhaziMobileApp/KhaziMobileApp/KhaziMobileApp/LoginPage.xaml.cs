using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KhaziMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            SetLoginDetails("", "");
        }

        void OnSignInClicked(object sender, EventArgs args)
        {
            var name = UName.Text;
            var password = UPassword.Text;

            if(name == null|| password == null)
            {
               DisplayAlert("Alert", "Please enter a username and password", "OK");
            }
            else
            {
                DisplayAlert("Alert", "Login Successful", "OK");
                Navigation.PushAsync(new Dashboard());
                

            }
            
        }

        void SetLoginDetails(string Name, string Password)
        {
            UName.Text = Name;
            UPassword.Text = Password;
        }

        void OnRegisterClicked(object sender, EventArgs args)
        {
            
        }
    }
}