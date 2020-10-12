using Android.Telecom;
using Plugin.Messaging;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Shiny;
using Shiny.Locations;

namespace KhaziMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard : TabbedPage
    {
        public Dashboard()
        {
            InitializeComponent();
            
            
            var listView = new ListView();
            listView.ItemsSource = new string[]
            {
                "Lerato Mono - 0716721344",
                "Julia Mofokeng - 0841237765",
                "Bridget Styles - 0827765144",
                "Doofenschmirtz - 0812356744"
            };

            ObservableCollection<Contact> Contacts = new ObservableCollection<Contact>();

            listView.ItemsSource = Contacts;
            Contacts.Add(new Contact() { Name = "Choki" });
            Contacts.Add(new Contact() { Name = "Timothy" });
            Contacts.Add(new Contact() { Name = "Martha" });
            Contacts.Add(new Contact() { Name = "Dennis" });
            Contacts.Add(new Contact() { Name = "Tom" });

        }

        void BtnCall_Click(object sender, EventArgs args)
        {
            var PlaceCall = CrossMessaging.Current.PhoneDialer;
            if (PlaceCall.CanMakePhoneCall)
                PlaceCall.MakePhoneCall(PhoneNumber.Text);
            
        }


        void OnSwitchToggled(object sender, EventArgs args)
        {
            //Logic for device
            lblDevice1.IsVisible = true;
            lblDevice2.IsVisible = true;
            lblDevice3.IsVisible = false;
            if (styleSwitch.IsToggled == false)
            {
                lblDevice1.IsVisible = false;
                lblDevice2.IsVisible = false;
                lblDevice3.IsVisible = true;
            }
        }

        //async protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    await ShinyHost.Resolve<IGeofenceManager>().RequestAccess();
        //}

        void OnBeepClicked(object sender, EventArgs args)
        {
            BeepRunning.IsRunning = true;
            DisplayAlert("ALERT", "Your emergency contacts have been notified. Please press the stop button", "OK");


        }

        void OnStopClicked(object sender, EventArgs args)
        {
            BeepRunning.IsRunning = false;
        }

        //void wait(int milliseconds)
        //{
        //    var timer1 = new Xamarin.Forms.Timer();
        //    if (milliseconds == 0 || milliseconds < 0) return;

        //    // Console.WriteLine("start wait timer");
        //    timer1.Interval = milliseconds;
        //    timer1.Enabled = true;
        //    timer1.Start();

        //    timer1.Tick += (s, e) =>
        //    {
        //        timer1.Enabled = false;
        //        timer1.Stop();
        //        // Console.WriteLine("stop wait timer");
        //    };

        //    while (timer1.Enabled)
        //    {
        //        Application.DoEvents();
        //    }
        //}

    }



}