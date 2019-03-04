using System;
using CardConnectBinding;
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
            PKPaymentRequest pKPaymentRequest = new PKPaymentRequest
            {
                MerchantIdentifier = "merchant.id.sample",
                CurrencyCode = "USD",
                CountryCode = "US",
                MerchantCapabilities = PassKit.PKMerchantCapability.ThreeDS
            };

            PassKit.PKPaymentSummaryItem[] pkPaymentSummaryItems = new PassKit.PKPaymentSummaryItem[]
            {
                new PassKit.PKPaymentSummaryItem
                {
                    Label = "Total",
                    Amount= new NSDecimalNumber("1.00")
                }
            };

            pKPaymentRequest.PaymentSummaryItems = pkPaymentSummaryItems;
            pKPaymentRequest.SupportedNetworks = new NSString[]
            {
                PassKit.PKPaymentNetwork.MasterCard,
                PassKit.PKPaymentNetwork.Visa,
                PassKit.PKPaymentNetwork.Amex
            };

            PKPaymentAuthorizationViewController pauthCtrl = new PKPaymentAuthorizationViewController(pKPaymentRequest);

            pauthCtrl.PaymentAuthorizationViewControllerDidFinish += (senderObj, e) =>
            {
                pauthCtrl.DismissViewController(true, null);
            };


            pauthCtrl.DidAuthorizePayment += (senderObj1, e) =>
            {
                CCCAPI cCCAPI = new CCCAPI();

                cCCAPI.GenerateTokenForApplePay(e.Payment, (theToken, error) =>
                {
                    if (!String.IsNullOrWhiteSpace(theToken))
                    {
                        e.Completion(PassKit.PKPaymentAuthorizationStatus.Success);
                    }
                    else
                    {
                        e.Completion(PassKit.PKPaymentAuthorizationStatus.Failure);
                    }
                });
            };

            PresentViewController(pauthCtrl, true, null);
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
