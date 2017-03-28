using Android.Telephony;
using MyUtilsApp.Android;

[assembly: Xamarin.Forms.Dependency(typeof(SmsService_Android))]

namespace MyUtilsApp.Android
{
    public class SmsService_Android : ISmsService
    {
        public void SendSMS(string phoneNumber, string text)
        {
            SmsManager.Default.SendTextMessage(phoneNumber, null, text, null, null);
        }
    }
}