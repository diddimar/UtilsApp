using System;
using MyUtilsApp.ViewModel;
using Plugin.Battery;
using Plugin.Connectivity;
using Plugin.Geolocator;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyUtilsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PluginPage : ContentPage
    {
        public PluginPage()
        {
            InitializeComponent();

            LblBattery.Text = "Level: " + CrossBattery.Current.RemainingChargePercent + "%";

            CrossConnectivity.Current.ConnectivityChanged += Current_ConnectivityChanged;

            GetGPS();


            MessagingCenter.Subscribe<HeatViewModel, string>(this, "HeatCalculated", CalcHeatResult );

        }

        private void CalcHeatResult(HeatViewModel arg1, string arg)
        {
            LblHeat.Text = arg;
        }

        private void ReceiveMessage(HeatViewModel sender, string message)
        {
            LblMessage.Text = message;
        }

        private void Current_ConnectivityChanged(object sender, Plugin.Connectivity.Abstractions.ConnectivityChangedEventArgs e)
        {
            App.Current.MainPage.DisplayAlert("ATH", "Netamband breyttist", "OK");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (!CrossConnectivity.Current.IsConnected)
            {
                App.Current.MainPage.DisplayAlert("ATH", "Ekkert netsamband", "OK");
            }
        }

        public async void GetGPS()
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            var position = await locator.GetPositionAsync(10000);

            LblGPSStatus.Text = $"Position status : {position.Timestamp}";
            LblGPSLatitude.Text = $"Position Latitude : {position.Latitude}";
            LblGPSLongitude.Text = $"Position Longitude: { position.Longitude}";
        }
    }
}
