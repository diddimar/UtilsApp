using MessageUI;
using MyUtilsApp.iOS;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(SmsService_iOS))]

namespace MyUtilsApp.iOS
{
    public class SmsService_iOS : ISmsService
    {
        public void SendSMS(string phoneNumber, string text)
        {
            var composerViewController = new MFMessageComposeViewController()
            {
                Recipients = new[] { phoneNumber },
                Body = text,
            };
            UIApplication.SharedApplication.KeyWindow.RootViewController.
            PresentViewController(composerViewController, true, null);
        }
    }
}