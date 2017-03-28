using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyUtilsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class SMSPage : ContentPage
    {
        public SMSPage()
        {
            var phoneLabel = new Label
            {
                VerticalOptions = LayoutOptions.Center,
                Text = "Phone Number"
            };
            var phoneEntry = new Entry
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Placeholder = "Enter Phone Number"
            };
            var textLabel = new Label
            {
                VerticalOptions = LayoutOptions.Center,
                Text = "Text"
            };
            var textEntry = new Entry
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Placeholder = "Enter text"
            };
            var button = new Button
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Text = "Send Message"
            };
            button.Clicked += (sender, args) =>
            {
                var smsService = DependencyService.Get<ISmsService>();
                var phoneNumber = phoneEntry.Text;
                var text = textEntry.Text;
                smsService.SendSMS(phoneNumber, text);
            };
            var phoneStack = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { phoneLabel, phoneEntry }
            };
            var textStack = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { textLabel, textEntry }
            };
            var parentStack = new StackLayout
            {
                Children = { phoneStack, textStack, button }
            };
            Content = parentStack;
        }


    }
}