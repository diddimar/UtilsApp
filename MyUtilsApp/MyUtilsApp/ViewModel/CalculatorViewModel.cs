using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyUtilsApp.ViewModel
{
    public class CalculatorViewModel : ViewModelBase
    {
        public ICommand AddNumberCommand { get; }
        public ICommand AddNumberCommandTest { get; }

        public CalculatorViewModel()
        {

            AddNumberCommand = new Command<string>(InputNum =>
           {            

               try
               {
                   CalcScreen = CalcScreen + InputNum;
               }
               catch (Exception ex)
               {
                   //Ekki best practice - Frekar útfæra IDialogService
                   App.Current.MainPage.DisplayAlert("Villa", ex.Message, "OK");
               }
           });
        }

        private string calcScreen;

        public string CalcScreen
        {
            get { return calcScreen; }
            set
            {
                if (calcScreen == value)
                    return;

                calcScreen = value;
                OnPropertyChanged();

            }
        }
    }
}

