using Android.Telecom;
using Plugin.Messaging;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



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
        }
    }
}