using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyUtilsApp.ViewModel
{
    public class InfoViewModel : ViewModelBase
    {

        public ICommand SubmitCommand { get; }

        public ICommand ClearCommand { get; }

        #region Properties

        private string nameInput;

        public string NameInput
        {
            get { return nameInput; }
            set
            {
                if (nameInput == value)
                    return;

                nameInput = value;             

                OnPropertyChanged();
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (name == value)
                    return;
                name = value;
                OnPropertyChanged();
            }
        }

        private string emailInput;

        public string EmailInput
        {
            get { return emailInput; }
            set
            {
                if (emailInput == value)
                    return;

                emailInput = value;
                OnPropertyChanged();
            }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                if (email == value)
                    return;

                email = value;
                OnPropertyChanged();
            }
        }

        private string phoneNumberInput;

        public string PhoneNumberInput
        {
            get { return phoneNumberInput; }
            set
            {
                if (phoneNumberInput == value)
                    return;

                phoneNumberInput = value;
                OnPropertyChanged();
            }
        }

        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (phoneNumber == value)
                    return;

                phoneNumber = value;
                OnPropertyChanged();
            }
        }

        #endregion

        public InfoViewModel()
        {
            SubmitCommand = new Command(() =>
            {
                try
                {
                    Name = NameInput;
                    Email = EmailInput;
                    PhoneNumber = PhoneNumberInput;
                }
                catch (Exception ex)
                {
                    //Ekki best practice - Frekar útfæra IDialogService
                    App.Current.MainPage.DisplayAlert("Villa", ex.Message, "OK");
                }
            });


            ClearCommand = new Command(() =>
            {
                try
                {
                    NameInput = "";
                    EmailInput = "";
                    PhoneNumberInput = "";
                    Name = "";
                    Email = "";
                    PhoneNumber = "";
                }
                catch (Exception ex)
                {
                    //Ekki best practice - Frekar útfæra IDialogService
                    App.Current.MainPage.DisplayAlert("Villa", ex.Message, "OK");
                }
            });

        }
    }
}