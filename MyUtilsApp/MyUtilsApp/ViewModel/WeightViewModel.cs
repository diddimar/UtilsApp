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
    public class WeightViewModel : ViewModelBase
    {

        public ICommand CalculateWeightCommand { get; }
        private WeightTypeResult weightTypeResult = WeightTypeResult.Lbs;

        public WeightViewModel()
        {

            WeightType = "Lbs";

            CalculateWeightCommand = new Command(() =>
            {
                try
                {
                    WeightCalculated = Helpers.CalculateWeight(WeightInput, weightTypeResult);
                }
                catch (Exception ex)
                {
                    //Ekki best practice - Frekar útfæra IDialogService
                    App.Current.MainPage.DisplayAlert("Villa", ex.Message, "OK");
                }
            });
        }


        bool _isCalculatingLbs = true;
        public bool IsCalculatingLbs
        {
            get { return _isCalculatingLbs; }
            set
            {
                if (_isCalculatingLbs == value)
                    return;

                _isCalculatingLbs = value;

                weightTypeResult = _isCalculatingLbs == true ? WeightTypeResult.Lbs : WeightTypeResult.Kg;
                WeightType = _isCalculatingLbs == true ? "Lbs" : "Kg";

                OnPropertyChanged();
            }
        }

        string _weightCalculated = "";
        public string WeightCalculated
        {
            get { return _weightCalculated; }
            set
            {
                if (_weightCalculated == value)
                    return;

                _weightCalculated = value;
                OnPropertyChanged();
            }
        }


        string _weightInput = "";
        public string WeightInput
        {
            get { return _weightInput; }
            set
            {
                if (_weightInput == value)
                    return;

                _weightInput = value;
                OnPropertyChanged();
            }
        }

        string _weightType = "";
        public string WeightType
        {
            get { return _weightType; }
            set
            {
                if (_weightType == value)
                    return;

                _weightType = value;
                OnPropertyChanged();
            }
        }

    }
}
