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
            ObjCRuntime.Class.ThrowOnInitFailure = true;

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
