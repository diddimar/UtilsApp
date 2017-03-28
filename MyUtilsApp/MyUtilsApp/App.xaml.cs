using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyUtilsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MyUtilsApp.MainTabbed();
        }

        //public App()
        //{
        //    var phoneLabel = new Label
        //    {
        //        VerticalOptions = LayoutOptions.Center,
        //        Text = "Phone Number"
        //    };
        //    var phoneEntry = new Entry
        //    {
        //        VerticalOptions = LayoutOptions.Center,
        //        HorizontalOptions = LayoutOptions.FillAndExpand,
        //        Placeholder = "Enter Phone Number"
        //    };
        //    var textLabel = new Label
        //    {
        //        VerticalOptions = LayoutOptions.Center,
        //        Text = "Text"
        //    };
        //    var textEntry = new Entry
        //    {
        //        VerticalOptions = LayoutOptions.Center,
        //        HorizontalOptions = LayoutOptions.FillAndExpand,
        //        Placeholder = "Enter text"
        //    };
        //    var button = new Button
        //    {
        //        HorizontalOptions = LayoutOptions.FillAndExpand,
        //        Text = "Send Message"
        //    };
        //    button.Clicked += (sender, args) => {
        //    var smsService = DependencyService.Get<ISmsService>();
        //        var phoneNumber = phoneEntry.Text;
        //        var text = textEntry.Text;
        //        smsService.SendSMS(phoneNumber, text);
        //    };
        //    var phoneStack = new StackLayout
        //    {
        //        Orientation = StackOrientation.Horizontal,
        //        Children = { phoneLabel, phoneEntry }
        //    };
        //    var textStack = new StackLayout
        //    {
        //        Orientation = StackOrientation.Horizontal,
        //        Children = { textLabel, textEntry }
        //    };
        //    var parentStack = new StackLayout
        //    {
        //        Children = { phoneStack, textStack, button }
        //    };
        //    MainPage = new NavigationPage(new ContentPage
        //    {
        //        Title = "SMS Helper",
        //        Content = parentStack
        //    });
        //}



        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
