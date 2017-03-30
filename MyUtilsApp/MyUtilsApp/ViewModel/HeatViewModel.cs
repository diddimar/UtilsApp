using PclBackend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyUtilsApp.ViewModel
{
    public class HeatViewModel : ViewModelBase
    {

        public ICommand CalculateHeatCommand { get; }
        private TemperatureTypeResult heatTypeResult = TemperatureTypeResult.Farenheit;


        public HeatViewModel()
        {

            HeatType = "Farenheit";

            CalculateHeatCommand = new Command(() =>
            {
                try
                {
                    HeatCalculated = Helpers.CalculateHeat(HeatInput, heatTypeResult);
                    MessagingCenter.Send<HeatViewModel, string>(this, "HeatCalculated", HeatCalculated);
                }
                catch (Exception ex)
                {
                    //Ekki best practice - Frekar útfæra IDialogService
                    App.Current.MainPage.DisplayAlert("Villa", ex.Message, "OK");
                }
            });
        }



        bool _isCalculatingFarenheit = true;
        public bool IsCalculatingFarenheit
        {
            get { return _isCalculatingFarenheit; }
            set
            {
                if (_isCalculatingFarenheit == value)
                    return;

                _isCalculatingFarenheit = value;


                heatTypeResult = _isCalculatingFarenheit == true ? TemperatureTypeResult.Farenheit : TemperatureTypeResult.Celsius;
                HeatType = _isCalculatingFarenheit == true ? "° F" : "° C";

                HeatInput = "";
                HeatCalculated = "";

                OnPropertyChanged();
            }
        }

        string _heatCalculated = "";
        public string HeatCalculated
        {
            get { return _heatCalculated; }
            set
            {
                if (_heatCalculated == value)
                    return;

                _heatCalculated = value;
                OnPropertyChanged();
            }
        }


        string _heatInput = "";
        public string HeatInput
        {
            get { return _heatInput; }
            set
            {
                if (_heatInput == value)
                    return;

                _heatInput = value;
                OnPropertyChanged();
            }
        }

        string _heatType = "";
        public string HeatType
        {
            get { return _heatType; }
            set
            {
                if (_heatType == value)
                    return;

                _heatType = value;
                OnPropertyChanged();
            }
        }


    }
}
