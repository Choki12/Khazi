﻿using System;

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

        }

        void OnSignInClicked(object sender, EventArgs args)
        {
            var name = UName.Text;
            var password = UPassword.Text;

            if (name == null || password == null)
            {
                DisplayAlert("Alert", "Please enter a username and password", "OK");
            }
            else
            {
                DisplayAlert("Alert", "Login Successful", "OK");
                Navigation.PushAsync(new Dashboard());
                SetLoginDetails();

            }

        }

        void SetLoginDetails()
        {
            UName.Text = "";
            UPassword.Text = "";
            UName.Text = null;
            UPassword.Text = null;
        }

        void OnRegisterClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Registration());
        }
    }
}