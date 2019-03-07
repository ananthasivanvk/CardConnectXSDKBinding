using System;
using CardConnectBinding;
using Foundation;
using ObjCRuntime;
using PassKit;
using UIKit;

namespace POCCardConnect
{
    public partial class ViewController : UIViewController, IPKPaymentAuthorizationViewControllerDelegate
    {
        PKPaymentToken paymentToken;

        readonly NSString[] supportedNetworks = {
            PKPaymentNetwork.Amex,
            PKPaymentNetwork.Discover,
            PKPaymentNetwork.MasterCard,
            PKPaymentNetwork.Visa
        };

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void applePayPressed(UIButton sender)
        {
            if (!PKPaymentAuthorizationViewController.CanMakePaymentsUsingNetworks(supportedNetworks))
            {
                ShowAuthorizationAlert();
                return;
            }

            var paymentRequest = new PKPaymentRequest();

            paymentRequest.MerchantIdentifier = "merchant.id.sample";
            paymentRequest.CountryCode = "US";
            paymentRequest.CurrencyCode = "USD";
            paymentRequest.MerchantCapabilities = PKMerchantCapability.ThreeDS;

            paymentRequest.PaymentSummaryItems = MakeSummaryItems();
            paymentRequest.SupportedNetworks = supportedNetworks;

            var viewController = new PKPaymentAuthorizationViewController(paymentRequest);
            viewController.Delegate = this;
            PresentViewController(viewController, true, null);
        }

        void ShowAuthorizationAlert()
        {
            var alert = UIAlertController.Create("Error", "This device cannot make payments.", UIAlertControllerStyle.Alert);
            var action = UIAlertAction.Create("Okay", UIAlertActionStyle.Default, null);
            alert.AddAction(action);

            PresentViewController(alert, true, null);
        }

        PKPaymentSummaryItem[] MakeSummaryItems()
        {
            var items = new List<PKPaymentSummaryItem>();

            // Product items have a label (a string) and an amount (NSDecimalNumber).
            // NSDecimalNumber is a Cocoa class that can express floating point numbers
            // in Base 10, which ensures precision. It can be initialized with a
            // double, or in this case, a string.
            var productSummaryItem = PKPaymentSummaryItem.Create("Total", new NSDecimalNumber("1.00"));
            items.Add(productSummaryItem);

            return items.ToArray();
        }

        /// <summary>
        /// This is where you would send your payment to be processed - here we will
        /// simply present a confirmation screen. If your payment processor failed the
        /// payment you would return `completion(PKPaymentAuthorizationStatus.Failure)` instead. Remember to never
        /// attempt to decrypt the payment token on device.
        /// </summary>
        public void DidAuthorizePayment(PKPaymentAuthorizationViewController controller, PKPayment payment, Action<PKPaymentAuthorizationStatus> completion)
        {
            paymentToken = payment.Token;

            var ccApi = CCCAPI.Instance();
            ccApi.GenerateTokenForApplePay(payment, (theToken, error) =>
            {
                if (!String.IsNullOrWhiteSpace(theToken))
                {
                    completion(PassKit.PKPaymentAuthorizationStatus.Success);

                    var alert = UIAlertController.Create("Payment Received!", "Thanks for making payment.", UIAlertControllerStyle.Alert);
                    var action = UIAlertAction.Create("Okay", UIAlertActionStyle.Default, null);
                    alert.AddAction(action);

                    PresentViewController(alert, true, null);
                }
                else
                {
                    completion(PassKit.PKPaymentAuthorizationStatus.Failure);
                }
            });
        }

        public void PaymentAuthorizationViewControllerDidFinish(PKPaymentAuthorizationViewController controller)
        {
            // We always need to dismiss our payment view controller when done.
            DismissViewController(true, null);
        }

        public void WillAuthorizePayment(PKPaymentAuthorizationViewController controller)
        {
        }
    }
}
