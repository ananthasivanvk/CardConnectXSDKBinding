using System;
using CardConnect;
//using CardConnect;
using Foundation;
using ObjCRuntime;
using PassKit;
using UIKit;

namespace POCCardConnect
{
    public partial class ViewController : UIViewController
    {
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
            //var okAlertController = UIAlertController.Create("Title", "Message", UIAlertControllerStyle.Alert);

            //okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, (obj) =>
            //{

            //    Console.WriteLine("OK Pressed");
            //}));

            //PresentViewController(okAlertController, true, null);


           

            CCCAPIBridgeProtocol aPIBridge = new APIBridge();

            PaymentControllerDelegate paymentControllerDelegate = new PaymentControllerDelegate();

            CCCPaymentController cCCPaymentController = new CCCPaymentController(this, aPIBridge, paymentControllerDelegate);
            CCCPaymentRequest cCCPayment = new CCCPaymentRequest
            {
                ApplePayMerchantID = "merchantid",
                Total = new Foundation.NSDecimalNumber("1.00")
            };
            cCCPaymentController.PaymentRequest = cCCPayment;

            cCCPaymentController.PresentPaymentView();


            //PKPaymentRequest pKPaymentRequest = new PKPaymentRequest
            //{
            //    CurrencyCode = "USD",
            //    CountryCode = "US",
            //    MerchantIdentifier = "merchant.test.id",
            //    PaymentSummaryItems = new PKPaymentSummaryItem[]
            //        {
            //                new PKPaymentSummaryItem{ Label = "Total", Amount = new Foundation.NSDecimalNumber("1.00") }
            //        },
            //    MerchantCapabilities = PKMerchantCapability.ThreeDS,
            //    SupportedNetworks = new Foundation.NSString[]
            //        {
            //                PKPaymentNetwork.Amex,
            //                PKPaymentNetwork.Visa,
            //                PKPaymentNetwork.MasterCard
            //        }
            //};

            //PKPaymentAuthorizationViewController pauthCtrl = new PKPaymentAuthorizationViewController(pKPaymentRequest);
            //pauthCtrl.PaymentAuthorizationViewControllerDidFinish += (senderObj, e) => { pauthCtrl.DismissViewController(true, null); };

            //PresentViewController(pauthCtrl, true, () => { });
        }
    }

    public class APIBridge : CCCAPIBridgeProtocol
    {
        public override void CCC_deleteCustomerAccount(string accountID,  Action<bool, NSError> completion)
        {
            //throw new NotImplementedException();
        }

        public override void CCC_getAccounts( Action<NSArray<CCCAccount>, NSError> completion)
        {
            //throw new NotImplementedException();
        }

        public override void CCC_saveAccountToCustomer(CCCAccount account,  Action<CCCAccount, NSError> completion)
        {
            //throw new NotImplementedException();
        }

        public override void CCC_updateAccount(CCCAccount account,  Action<CCCAccount, NSError> completion)
        {
            //throw new NotImplementedException();
        }
    }

    public class PaymentControllerDelegate : CCCPaymentControllerDelegate
    {
        public override void PaymentController(CCCPaymentController controller, CCCAccount account)
        {
            //throw new NotImplementedException();
        }
    }
}
