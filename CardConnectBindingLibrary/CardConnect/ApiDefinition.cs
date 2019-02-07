using System;
using AVFoundation;
//using CardConnectConsumerSDK;
using CloudKit;
using Contacts;
using CoreAnimation;
using CoreData;
using CoreFoundation;
using CoreGraphics;
using CoreImage;
using CoreLocation;
using CoreVideo;
using FileProvider;
using Foundation;
using IOSurface;
using ImageIO;
using Intents;
using Metal;
using ObjCRuntime;
using OpenGLES;
using PassKit;
using Security;
using UIKit;

namespace CardConnect
{

    /*
    // @protocol PKPaymentAuthorizationViewControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface PKPaymentAuthorizationViewControllerDelegate
    {
        // @required -(void)paymentAuthorizationViewControllerDidFinish:(PKPaymentAuthorizationViewController * _Nonnull)controller;
        [Abstract]
        [Export("paymentAuthorizationViewControllerDidFinish:")]
        void PaymentAuthorizationViewControllerDidFinish(PKPaymentAuthorizationViewController controller);

        // @optional -(void)paymentAuthorizationViewController:(PKPaymentAuthorizationViewController * _Nonnull)controller didAuthorizePayment:(PKPayment * _Nonnull)payment handler:(void (^ _Nonnull)(PKPaymentAuthorizationResult * _Nonnull))completion __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(ios, introduced=11.0)));
        [Watch(4, 0), iOS(11, 0)]
        [Export("paymentAuthorizationViewController:didAuthorizePayment:handler:")]
        void PaymentAuthorizationViewController(PKPaymentAuthorizationViewController controller, PKPayment payment, Action<PKPaymentAuthorizationResult> completion);

        // @optional -(void)paymentAuthorizationViewControllerWillAuthorizePayment:(PKPaymentAuthorizationViewController * _Nonnull)controller __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(ios, introduced=8.3)));
        [Watch(3, 0), iOS(8, 3)]
        [Export("paymentAuthorizationViewControllerWillAuthorizePayment:")]
        void PaymentAuthorizationViewControllerWillAuthorizePayment(PKPaymentAuthorizationViewController controller);

        // @optional -(void)paymentAuthorizationViewController:(PKPaymentAuthorizationViewController * _Nonnull)controller didSelectShippingMethod:(PKShippingMethod * _Nonnull)shippingMethod handler:(void (^ _Nonnull)(PKPaymentRequestShippingMethodUpdate * _Nonnull))completion __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(ios, introduced=11.0)));
        [Watch(4, 0), iOS(11, 0)]
        [Export("paymentAuthorizationViewController:didSelectShippingMethod:handler:")]
        void PaymentAuthorizationViewController(PKPaymentAuthorizationViewController controller, PKShippingMethod shippingMethod, Action<PKPaymentRequestShippingMethodUpdate> completion);

        // @optional -(void)paymentAuthorizationViewController:(PKPaymentAuthorizationViewController * _Nonnull)controller didSelectShippingContact:(PKContact * _Nonnull)contact handler:(void (^ _Nonnull)(PKPaymentRequestShippingContactUpdate * _Nonnull))completion __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(ios, introduced=11.0)));
        [Watch(4, 0), iOS(11, 0)]
        [Export("paymentAuthorizationViewController:didSelectShippingContact:handler:")]
        void PaymentAuthorizationViewController(PKPaymentAuthorizationViewController controller, PKContact contact, Action<PKPaymentRequestShippingContactUpdate> completion);

        // @optional -(void)paymentAuthorizationViewController:(PKPaymentAuthorizationViewController * _Nonnull)controller didSelectPaymentMethod:(PKPaymentMethod * _Nonnull)paymentMethod handler:(void (^ _Nonnull)(PKPaymentRequestPaymentMethodUpdate * _Nonnull))completion __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(ios, introduced=11.0)));
        [Watch(4, 0), iOS(11, 0)]
        [Export("paymentAuthorizationViewController:didSelectPaymentMethod:handler:")]
        void PaymentAuthorizationViewController(PKPaymentAuthorizationViewController controller, PKPaymentMethod paymentMethod, Action<PKPaymentRequestPaymentMethodUpdate> completion);

        // @optional -(void)paymentAuthorizationViewController:(PKPaymentAuthorizationViewController * _Nonnull)controller didAuthorizePayment:(PKPayment * _Nonnull)payment completion:(void (^ _Nonnull)(PKPaymentAuthorizationStatus))completion __attribute__((availability(ios, introduced=8.0, deprecated=11.0)));
        [Introduced(PlatformName.iOS, 8, 0, message: "Use paymentAuthorizationViewController:didAuthorizePayment:handler: instead to provide more granular errors")]
        [Deprecated(PlatformName.iOS, 11, 0, message: "Use paymentAuthorizationViewController:didAuthorizePayment:handler: instead to provide more granular errors")]
        [Export("paymentAuthorizationViewController:didAuthorizePayment:completion:")]
        void PaymentAuthorizationViewController(PKPaymentAuthorizationViewController controller, PKPayment payment, Action<PKPaymentAuthorizationStatus> completion);

        // @optional -(void)paymentAuthorizationViewController:(PKPaymentAuthorizationViewController * _Nonnull)controller didSelectShippingMethod:(PKShippingMethod * _Nonnull)shippingMethod completion:(void (^ _Nonnull)(PKPaymentAuthorizationStatus, NSArray<PKPaymentSummaryItem *> * _Nonnull))completion __attribute__((availability(ios, introduced=8.0, deprecated=11.0)));
        [Introduced(PlatformName.iOS, 8, 0, message: "Use paymentAuthorizationViewController:didSelectShippingMethod:handler: instead to provide more granular errors")]
        [Deprecated(PlatformName.iOS, 11, 0, message: "Use paymentAuthorizationViewController:didSelectShippingMethod:handler: instead to provide more granular errors")]
        [Export("paymentAuthorizationViewController:didSelectShippingMethod:completion:")]
        void PaymentAuthorizationViewController(PKPaymentAuthorizationViewController controller, PKShippingMethod shippingMethod, Action<PKPaymentAuthorizationStatus, NSArray<PKPaymentSummaryItem>> completion);

        // @optional -(void)paymentAuthorizationViewController:(PKPaymentAuthorizationViewController * _Nonnull)controller didSelectShippingAddress:(ABRecordRef _Nonnull)address completion:(void (^ _Nonnull)(PKPaymentAuthorizationStatus, NSArray<PKShippingMethod *> * _Nonnull, NSArray<PKPaymentSummaryItem *> * _Nonnull))completion __attribute__((availability(ios, introduced=8.0, deprecated=9.0)));
        //[Introduced(PlatformName.iOS, 8, 0, message: "ABRecordRef has been deprecated. Please migrate away from this delegate callback as soon as possible.")]
        //[Deprecated(PlatformName.iOS, 9, 0, message: "ABRecordRef has been deprecated. Please migrate away from this delegate callback as soon as possible.")]
        //[Export("paymentAuthorizationViewController:didSelectShippingAddress:completion:")]
        //unsafe void PaymentAuthorizationViewController(PKPaymentAuthorizationViewController controller, void* address, Action<PKPaymentAuthorizationStatus, NSArray<PKShippingMethod>, NSArray<PKPaymentSummaryItem>> completion);

        // @optional -(void)paymentAuthorizationViewController:(PKPaymentAuthorizationViewController * _Nonnull)controller didSelectShippingContact:(PKContact * _Nonnull)contact completion:(void (^ _Nonnull)(PKPaymentAuthorizationStatus, NSArray<PKShippingMethod *> * _Nonnull, NSArray<PKPaymentSummaryItem *> * _Nonnull))completion __attribute__((availability(ios, introduced=8.0, deprecated=11.0)));
        [Introduced(PlatformName.iOS, 8, 0, message: "Use paymentAuthorizationViewController:didSelectShippingContact:handler: instead to provide more granular errors")]
        [Deprecated(PlatformName.iOS, 11, 0, message: "Use paymentAuthorizationViewController:didSelectShippingContact:handler: instead to provide more granular errors")]
        [Export("paymentAuthorizationViewController:didSelectShippingContact:completion:")]
        void PaymentAuthorizationViewController(PKPaymentAuthorizationViewController controller, PKContact contact, Action<PKPaymentAuthorizationStatus, NSArray<PKShippingMethod>, NSArray<PKPaymentSummaryItem>> completion);

        // @optional -(void)paymentAuthorizationViewController:(PKPaymentAuthorizationViewController * _Nonnull)controller didSelectPaymentMethod:(PKPaymentMethod * _Nonnull)paymentMethod completion:(void (^ _Nonnull)(NSArray<PKPaymentSummaryItem *> * _Nonnull))completion __attribute__((availability(ios, introduced=8.0, deprecated=11.0)));
        [Introduced(PlatformName.iOS, 8, 0, message: "Use paymentAuthorizationViewController:didSelectPaymentMethod:handler: instead to provide more granular errors")]
        [Deprecated(PlatformName.iOS, 11, 0, message: "Use paymentAuthorizationViewController:didSelectPaymentMethod:handler: instead to provide more granular errors")]
        [Export("paymentAuthorizationViewController:didSelectPaymentMethod:completion:")]
        void PaymentAuthorizationViewController(PKPaymentAuthorizationViewController controller, PKPaymentMethod paymentMethod, Action<NSArray<PKPaymentSummaryItem>> completion);
    }

    // @interface PKPaymentAuthorizationViewController : UIViewController
    [iOS(8, 0)]
    [BaseType(typeof(UIViewController))]
    interface PKPaymentAuthorizationViewController
    {
        // +(BOOL)canMakePayments;
        [Static]
        [Export("canMakePayments")]
        bool CanMakePayments { get; }

        // +(BOOL)canMakePaymentsUsingNetworks:(NSArray<PKPaymentNetwork> * _Nonnull)supportedNetworks;
        [Static]
        [Export("canMakePaymentsUsingNetworks:")]
        bool CanMakePaymentsUsingNetworks(string[] supportedNetworks);

        // +(BOOL)canMakePaymentsUsingNetworks:(NSArray<PKPaymentNetwork> * _Nonnull)supportedNetworks capabilities:(PKMerchantCapability)capabilties __attribute__((availability(ios, introduced=9.0)));
        [iOS(9, 0)]
        [Static]
        [Export("canMakePaymentsUsingNetworks:capabilities:")]
        bool CanMakePaymentsUsingNetworks(string[] supportedNetworks, PKMerchantCapability capabilties);

        [Wrap("WeakDelegate")]
        [NullAllowed]
        PKPaymentAuthorizationViewControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<PKPaymentAuthorizationViewControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(instancetype _Nullable)initWithPaymentRequest:(PKPaymentRequest * _Nonnull)request __attribute__((objc_designated_initializer));
        [Export("initWithPaymentRequest:")]
        [DesignatedInitializer]
        IntPtr Constructor(PKPaymentRequest request);
    }

    // @protocol PKPaymentAuthorizationControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface PKPaymentAuthorizationControllerDelegate
    {
        // @required -(void)paymentAuthorizationControllerDidFinish:(PKPaymentAuthorizationController * _Nonnull)controller;
        [Abstract]
        [Export("paymentAuthorizationControllerDidFinish:")]
        void PaymentAuthorizationControllerDidFinish(PKPaymentAuthorizationController controller);

        // @optional -(void)paymentAuthorizationController:(PKPaymentAuthorizationController * _Nonnull)controller didAuthorizePayment:(PKPayment * _Nonnull)payment handler:(void (^ _Nonnull)(PKPaymentAuthorizationResult * _Nonnull))completion __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(ios, introduced=11.0)));
        [Watch(4, 0), iOS(11, 0)]
        [Export("paymentAuthorizationController:didAuthorizePayment:handler:")]
        void PaymentAuthorizationController(PKPaymentAuthorizationController controller, PKPayment payment, Action<PKPaymentAuthorizationResult> completion);

        // @optional -(void)paymentAuthorizationController:(PKPaymentAuthorizationController * _Nonnull)controller didAuthorizePayment:(PKPayment * _Nonnull)payment completion:(void (^ _Nonnull)(PKPaymentAuthorizationStatus))completion __attribute__((availability(watchos, introduced=3.0, deprecated=4.0))) __attribute__((availability(ios, introduced=10.0, deprecated=11.0)));
        [Introduced(PlatformName.WatchOS, 3, 0, message: "Use paymentAuthorizationController:didAuthorizePayment:handler: instead to provide more granular errors")]
        [Deprecated(PlatformName.WatchOS, 4, 0, message: "Use paymentAuthorizationController:didAuthorizePayment:handler: instead to provide more granular errors")]
        [Introduced(PlatformName.iOS, 10, 0, message: "Use paymentAuthorizationController:didAuthorizePayment:handler: instead to provide more granular errors")]
        [Deprecated(PlatformName.iOS, 11, 0, message: "Use paymentAuthorizationController:didAuthorizePayment:handler: instead to provide more granular errors")]
        [Export("paymentAuthorizationController:didAuthorizePayment:completion:")]
        void PaymentAuthorizationController(PKPaymentAuthorizationController controller, PKPayment payment, Action<PKPaymentAuthorizationStatus> completion);

        // @optional -(void)paymentAuthorizationControllerWillAuthorizePayment:(PKPaymentAuthorizationController * _Nonnull)controller;
        [Export("paymentAuthorizationControllerWillAuthorizePayment:")]
        void PaymentAuthorizationControllerWillAuthorizePayment(PKPaymentAuthorizationController controller);

        // @optional -(void)paymentAuthorizationController:(PKPaymentAuthorizationController * _Nonnull)controller didSelectShippingMethod:(PKShippingMethod * _Nonnull)shippingMethod handler:(void (^ _Nonnull)(PKPaymentRequestShippingMethodUpdate * _Nonnull))completion __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(ios, introduced=11.0)));
        [Watch(4, 0), iOS(11, 0)]
        [Export("paymentAuthorizationController:didSelectShippingMethod:handler:")]
        void PaymentAuthorizationController(PKPaymentAuthorizationController controller, PKShippingMethod shippingMethod, Action<PKPaymentRequestShippingMethodUpdate> completion);

        // @optional -(void)paymentAuthorizationController:(PKPaymentAuthorizationController * _Nonnull)controller didSelectShippingContact:(PKContact * _Nonnull)contact handler:(void (^ _Nonnull)(PKPaymentRequestShippingContactUpdate * _Nonnull))completion __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(ios, introduced=11.0)));
        [Watch(4, 0), iOS(11, 0)]
        [Export("paymentAuthorizationController:didSelectShippingContact:handler:")]
        void PaymentAuthorizationController(PKPaymentAuthorizationController controller, PKContact contact, Action<PKPaymentRequestShippingContactUpdate> completion);

        // @optional -(void)paymentAuthorizationController:(PKPaymentAuthorizationController * _Nonnull)controller didSelectPaymentMethod:(PKPaymentMethod * _Nonnull)paymentMethod handler:(void (^ _Nonnull)(PKPaymentRequestPaymentMethodUpdate * _Nonnull))completion __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(ios, introduced=11.0)));
        [Watch(4, 0), iOS(11, 0)]
        [Export("paymentAuthorizationController:didSelectPaymentMethod:handler:")]
        void PaymentAuthorizationController(PKPaymentAuthorizationController controller, PKPaymentMethod paymentMethod, Action<PKPaymentRequestPaymentMethodUpdate> completion);

        // @optional -(void)paymentAuthorizationController:(PKPaymentAuthorizationController * _Nonnull)controller didSelectShippingMethod:(PKShippingMethod * _Nonnull)shippingMethod completion:(void (^ _Nonnull)(PKPaymentAuthorizationStatus, NSArray<PKPaymentSummaryItem *> * _Nonnull))completion __attribute__((availability(watchos, introduced=3.0, deprecated=4.0))) __attribute__((availability(ios, introduced=10.0, deprecated=11.0)));
        [Introduced(PlatformName.WatchOS, 3, 0, message: "Use paymentAuthorizationController:didSelectShippingMethod:handler: instead to provide more granular errors")]
        [Deprecated(PlatformName.WatchOS, 4, 0, message: "Use paymentAuthorizationController:didSelectShippingMethod:handler: instead to provide more granular errors")]
        [Introduced(PlatformName.iOS, 10, 0, message: "Use paymentAuthorizationController:didSelectShippingMethod:handler: instead to provide more granular errors")]
        [Deprecated(PlatformName.iOS, 11, 0, message: "Use paymentAuthorizationController:didSelectShippingMethod:handler: instead to provide more granular errors")]
        [Export("paymentAuthorizationController:didSelectShippingMethod:completion:")]
        void PaymentAuthorizationController(PKPaymentAuthorizationController controller, PKShippingMethod shippingMethod, Action<PKPaymentAuthorizationStatus, NSArray<PKPaymentSummaryItem>> completion);

        // @optional -(void)paymentAuthorizationController:(PKPaymentAuthorizationController * _Nonnull)controller didSelectShippingContact:(PKContact * _Nonnull)contact completion:(void (^ _Nonnull)(PKPaymentAuthorizationStatus, NSArray<PKShippingMethod *> * _Nonnull, NSArray<PKPaymentSummaryItem *> * _Nonnull))completion __attribute__((availability(watchos, introduced=3.0, deprecated=4.0))) __attribute__((availability(ios, introduced=10.0, deprecated=11.0)));
        [Introduced(PlatformName.WatchOS, 3, 0, message: "Use paymentAuthorizationController:didSelectShippingContact:handler: instead to provide more granular errors")]
        [Deprecated(PlatformName.WatchOS, 4, 0, message: "Use paymentAuthorizationController:didSelectShippingContact:handler: instead to provide more granular errors")]
        [Introduced(PlatformName.iOS, 10, 0, message: "Use paymentAuthorizationController:didSelectShippingContact:handler: instead to provide more granular errors")]
        [Deprecated(PlatformName.iOS, 11, 0, message: "Use paymentAuthorizationController:didSelectShippingContact:handler: instead to provide more granular errors")]
        [Export("paymentAuthorizationController:didSelectShippingContact:completion:")]
        void PaymentAuthorizationController(PKPaymentAuthorizationController controller, PKContact contact, Action<PKPaymentAuthorizationStatus, NSArray<PKShippingMethod>, NSArray<PKPaymentSummaryItem>> completion);

        // @optional -(void)paymentAuthorizationController:(PKPaymentAuthorizationController * _Nonnull)controller didSelectPaymentMethod:(PKPaymentMethod * _Nonnull)paymentMethod completion:(void (^ _Nonnull)(NSArray<PKPaymentSummaryItem *> * _Nonnull))completion __attribute__((availability(watchos, introduced=3.0, deprecated=4.0))) __attribute__((availability(ios, introduced=10.0, deprecated=11.0)));
        [Introduced(PlatformName.WatchOS, 3, 0, message: "Use paymentAuthorizationController:didSelectPaymentMethod:handler: instead to provide more granular errors")]
        [Deprecated(PlatformName.WatchOS, 4, 0, message: "Use paymentAuthorizationController:didSelectPaymentMethod:handler: instead to provide more granular errors")]
        [Introduced(PlatformName.iOS, 10, 0, message: "Use paymentAuthorizationController:didSelectPaymentMethod:handler: instead to provide more granular errors")]
        [Deprecated(PlatformName.iOS, 11, 0, message: "Use paymentAuthorizationController:didSelectPaymentMethod:handler: instead to provide more granular errors")]
        [Export("paymentAuthorizationController:didSelectPaymentMethod:completion:")]
        void PaymentAuthorizationController(PKPaymentAuthorizationController controller, PKPaymentMethod paymentMethod, Action<NSArray<PKPaymentSummaryItem>> completion);
    }

    // @interface PKPaymentAuthorizationController : NSObject
    [Protocol]
    [Watch(3, 0), iOS(10, 0)]
    [BaseType(typeof(NSObject))]
    interface PKPaymentAuthorizationController
    {
        // +(BOOL)canMakePayments;
        [Static]
        [Export("canMakePayments")]
        bool CanMakePayments { get; }

        // +(BOOL)canMakePaymentsUsingNetworks:(NSArray<PKPaymentNetwork> * _Nonnull)supportedNetworks;
        [Static]
        [Export("canMakePaymentsUsingNetworks:")]
        bool CanMakePaymentsUsingNetworks(string[] supportedNetworks);

        // +(BOOL)canMakePaymentsUsingNetworks:(NSArray<PKPaymentNetwork> * _Nonnull)supportedNetworks capabilities:(PKMerchantCapability)capabilties;
        [Static]
        [Export("canMakePaymentsUsingNetworks:capabilities:")]
        bool CanMakePaymentsUsingNetworks(string[] supportedNetworks, PKMerchantCapability capabilties);

        [Wrap("WeakDelegate")]
        [NullAllowed]
        PKPaymentAuthorizationControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<PKPaymentAuthorizationControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(instancetype _Nonnull)initWithPaymentRequest:(PKPaymentRequest * _Nonnull)request __attribute__((objc_designated_initializer));
        [Export("initWithPaymentRequest:")]
        [DesignatedInitializer]
        IntPtr Constructor(PKPaymentRequest request);

        // -(void)presentWithCompletion:(void (^ _Nullable)(BOOL))completion;
        [Export("presentWithCompletion:")]
        void PresentWithCompletion([NullAllowed] Action<bool> completion);

        // -(void)dismissWithCompletion:(void (^ _Nullable)(void))completion;
        [Export("dismissWithCompletion:")]
        void DismissWithCompletion([NullAllowed] Action completion);
    }
    */

    // @interface CCCCardInfo : NSObject <NSCopying>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface CCCCardInfo : INSCopying
    {
        // @property (copy, nonatomic) NSString * cardNumber;
        [Export("cardNumber")]
        string CardNumber { get; set; }

        // @property (copy, nonatomic) NSDate * expirationDate;
        [Export("expirationDate", ArgumentSemantic.Copy)]
        NSDate ExpirationDate { get; set; }

        // @property (copy, nonatomic) NSString * CVV;
        [Export("CVV")]
        string CVV { get; set; }

        // @property (copy, nonatomic) NSString * postalCode;
        [Export("postalCode")]
        string PostalCode { get; set; }

        // @property (readonly, assign, nonatomic) CCCCardIssuer accountType;
        //[Export("accountType", ArgumentSemantic.Assign)]
        //CCCCardIssuer AccountType { get; }

        //// @property (assign, nonatomic) CCCCardMaskFormat maskFormat;
        //[Export("maskFormat", ArgumentSemantic.Assign)]
        //CCCCardMaskFormat MaskFormat { get; set; }

        // @property (assign, nonatomic) unichar maskCharacter;
        [Export("maskCharacter")]
        ushort MaskCharacter { get; set; }

        // @property (assign, nonatomic) CCCCardMaskSpacing maskSpacing;
        //[Export("maskSpacing", ArgumentSemantic.Assign)]
        //CCCCardMaskSpacing MaskSpacing { get; set; }

        // -(BOOL)isCardValid;
        [Export("isCardValid")]
        bool IsCardValid { get; }
    }

    // @interface CCCAccount : NSObject <NSCopying>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface CCCAccount : INSCopying
    {
        // @property (copy, nonatomic) NSString * accountID;
        [Export("accountID")]
        string AccountID { get; set; }

        // @property (copy, nonatomic) NSString * accountType;
        [Export("accountType")]
        string AccountType { get; set; }

        // @property (assign, nonatomic) BOOL accountUpdaterOptOut;
        [Export("accountUpdaterOptOut")]
        bool AccountUpdaterOptOut { get; set; }

        // @property (copy, nonatomic) NSString * address;
        [Export("address")]
        string Address { get; set; }

        // @property (copy, nonatomic) NSString * city;
        [Export("city")]
        string City { get; set; }

        // @property (copy, nonatomic) NSString * country;
        [Export("country")]
        string Country { get; set; }

        // @property (assign, nonatomic) BOOL defaultAccount;
        [Export("defaultAccount")]
        bool DefaultAccount { get; set; }

        // @property (copy, nonatomic) NSString * email;
        [Export("email")]
        string Email { get; set; }

        // @property (copy, nonatomic) NSDate * expirationDate;
        [Export("expirationDate", ArgumentSemantic.Copy)]
        NSDate ExpirationDate { get; set; }

        // @property (assign, nonatomic) BOOL governmentIssued;
        [Export("governmentIssued")]
        bool GovernmentIssued { get; set; }

        // @property (copy, nonatomic) NSString * license;
        [Export("license")]
        string License { get; set; }

        // @property (copy, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * phone;
        [Export("phone")]
        string Phone { get; set; }

        // @property (copy, nonatomic) NSString * postalCode;
        [Export("postalCode")]
        string PostalCode { get; set; }

        // @property (copy, nonatomic) NSNumber * profileID;
        [Export("profileID", ArgumentSemantic.Copy)]
        NSNumber ProfileID { get; set; }

        // @property (copy, nonatomic) NSString * region;
        [Export("region")]
        string Region { get; set; }

        // @property (copy, nonatomic) NSString * ssnl4;
        [Export("ssnl4")]
        string Ssnl4 { get; set; }

        // @property (copy, nonatomic) NSString * token;
        [Export("token")]
        string Token { get; set; }

        // @property (readonly, nonatomic) NSString * last4;
        [Export("last4")]
        string Last4 { get; }

        // -(instancetype)initWithData:(NSData *)data;
        [Export("initWithData:")]
        IntPtr Constructor(NSData data);

        // -(NSData *)dataForObject;
        [Export("dataForObject")]
        NSData DataForObject { get; }
    }

    [Static]
    partial interface Constants
    {
        // extern NSString *const _Nonnull CCCAPIErrorDomain;
        [Field("CCCAPIErrorDomain", "__Internal")]
        NSString CCCAPIErrorDomain { get; }

        // extern const NSInteger CCCAPIErrorCodeNoEndpoint;
        [Field("CCCAPIErrorCodeNoEndpoint", "__Internal")]
        nint CCCAPIErrorCodeNoEndpoint { get; }

        // extern const NSInteger CCCAPIErrorCodeInvalidCardData;
        [Field("CCCAPIErrorCodeInvalidCardData", "__Internal")]
        nint CCCAPIErrorCodeInvalidCardData { get; }
    }

    // @interface CCCAPI : NSObject
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface CCCAPI
    {
        // +(instancetype _Nonnull)instance;
        [Static]
        [Export("instance")]
        CCCAPI Instance();

        // @property (copy, nonatomic) NSString * _Nullable endpoint;
        [NullAllowed, Export("endpoint")]
        string Endpoint { get; set; }

        // @property (assign, nonatomic) BOOL enableLogging;
        [Export("enableLogging")]
        bool EnableLogging { get; set; }

        // -(NSURLSessionTask * _Nullable)generateAccountForCard:(CCCCardInfo * _Nonnull)card completion:(void (^ _Nonnull)(CCCAccount * _Nullable, NSError * _Nullable))completion;
        [Export("generateAccountForCard:completion:")]
        [return: NullAllowed]
        NSUrlSessionTask GenerateAccountForCard(CCCCardInfo card, Action<CCCAccount, NSError> completion);

        // -(NSURLSessionTask * _Nullable)generateTokenForApplePay:(PKPayment * _Nonnull)payment completion:(void (^ _Nonnull)(NSString * _Nullable, NSError * _Nullable))completion;
        [Export("generateTokenForApplePay:completion:")]
        [return: NullAllowed]
        NSUrlSessionTask GenerateTokenForApplePay(PKPayment payment, Action<NSString, NSError> completion);
    }

    // @protocol CCCAPIBridgeProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface CCCAPIBridgeProtocol
    {
        // @required -(void)CCC_getAccounts:(void (^)(NSArray<CCCAccount *> *, NSError *))completion;
        [Abstract]
        [Export("CCC_getAccounts:")]
        void CCC_getAccounts(Action<NSArray<CCCAccount>, NSError> completion);

        // @required -(void)CCC_saveAccountToCustomer:(CCCAccount *)account completion:(void (^)(CCCAccount *, NSError *))completion;
        [Abstract]
        [Export("CCC_saveAccountToCustomer:completion:")]
        void CCC_saveAccountToCustomer(CCCAccount account, Action<CCCAccount, NSError> completion);

        // @required -(void)CCC_deleteCustomerAccount:(NSString *)accountID completion:(void (^)(BOOL, NSError *))completion;
        [Abstract]
        [Export("CCC_deleteCustomerAccount:completion:")]
        void CCC_deleteCustomerAccount(string accountID, Action<bool, NSError> completion);

        // @required -(void)CCC_updateAccount:(CCCAccount *)account completion:(void (^)(CCCAccount *, NSError *))completion;
        [Abstract]
        [Export("CCC_updateAccount:completion:")]
        void CCC_updateAccount(CCCAccount account, Action<CCCAccount, NSError> completion);

        // @optional -(void)CCC_authApplePayTransactionWithToken:(NSString *)token completion:(void (^)(BOOL, NSError *))completion;
        [Export("CCC_authApplePayTransactionWithToken:completion:")]
        void CCC_authApplePayTransactionWithToken(string token, Action<bool, NSError> completion);
    }

    // @interface CCCTextFieldDelegateProxy : NSObject <UITextFieldDelegate>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface CCCTextFieldDelegateProxy : IUITextFieldDelegate
    {
        [Wrap("WeakOriginalDelegate")]
        UITextFieldDelegate OriginalDelegate { get; set; }

        // @property (nonatomic, weak) id<UITextFieldDelegate> originalDelegate __attribute__((iboutlet));
        [NullAllowed, Export("originalDelegate", ArgumentSemantic.Weak)]
        NSObject WeakOriginalDelegate { get; set; }

        // @property (nonatomic, strong) UITextField * textField;
        [Export("textField", ArgumentSemantic.Strong)]
        UITextField TextField { get; set; }

        // @property (nonatomic, strong) UIView * leftValidView;
        [Export("leftValidView", ArgumentSemantic.Strong)]
        UIView LeftValidView { get; set; }

        // @property (nonatomic, strong) UIView * leftInvalidView;
        [Export("leftInvalidView", ArgumentSemantic.Strong)]
        UIView LeftInvalidView { get; set; }

        // @property (nonatomic, strong) UIView * rightValidView;
        [Export("rightValidView", ArgumentSemantic.Strong)]
        UIView RightValidView { get; set; }

        // @property (nonatomic, strong) UIView * rightInvalidView;
        [Export("rightInvalidView", ArgumentSemantic.Strong)]
        UIView RightInvalidView { get; set; }

        // -(void)updateTextFieldText:(UITextField *)textField;
        [Export("updateTextFieldText:")]
        void UpdateTextFieldText(UITextField textField);

        // -(void)clearTextField;
        [Export("clearTextField")]
        void ClearTextField();
    }

    // @interface CCCCVVFormatterDelegate : CCCTextFieldDelegateProxy
    [Protocol]
    [BaseType(typeof(CCCTextFieldDelegateProxy))]
    interface CCCCVVFormatterDelegate
    {
        // @property (nonatomic) unichar maskCharacter;
        [Export("maskCharacter")]
        ushort MaskCharacter { get; set; }

        // -(BOOL)isValidCVV;
        [Export("isValidCVV")]
        bool IsValidCVV { get; }

        // -(BOOL)isValidCVVForCardNumber:(NSString *)cardNumber;
        [Export("isValidCVVForCardNumber:")]
        bool IsValidCVVForCardNumber(string cardNumber);

        // -(BOOL)isValidCVVWithCardFormatter:(CCCCardFormatterDelegate *)formatter;
        //[Export("isValidCVVWithCardFormatter:")]
        //bool IsValidCVVWithCardFormatter(CCCCardFormatterDelegate formatter);

        // -(void)setCVVOnCardInfo:(CCCCardInfo *)cardInfo;
        [Export("setCVVOnCardInfo:")]
        void SetCVVOnCardInfo(CCCCardInfo cardInfo);
    }

    // @interface CCCCardFunctions : NSObject
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface CCCCardFunctions
    {
    }


    // @interface CCCPaymentController : NSObject
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface CCCPaymentController
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        CCCPaymentControllerDelegate Delegate { get; }

        // @property (readonly, nonatomic, weak) id<CCCPaymentControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; }

        // @property (nonatomic, strong) CCCPaymentRequest * _Nullable paymentRequest;
        [NullAllowed, Export("paymentRequest", ArgumentSemantic.Strong)]
        CCCPaymentRequest PaymentRequest { get; set; }

        // -(instancetype _Nullable)initWithRootView:(UIViewController * _Nonnull)rootView apiBridge:(id<CCCAPIBridgeProtocol> _Nonnull)bridge delegate:(id<CCCPaymentControllerDelegate> _Nonnull)delegate;
        [Export("initWithRootView:apiBridge:delegate:")]
        IntPtr Constructor(UIViewController rootView, CCCAPIBridgeProtocol bridge, CCCPaymentControllerDelegate @delegate);

        // -(instancetype _Nullable)initWithRootView:(UIViewController * _Nonnull)rootView apiBridge:(id<CCCAPIBridgeProtocol> _Nonnull)bridge delegate:(id<CCCPaymentControllerDelegate> _Nonnull)delegate theme:(CCCTheme * _Nullable)theme;
        //[Export("initWithRootView:apiBridge:delegate:theme:")]
        //IntPtr Constructor(UIViewController rootView, CCCAPIBridgeProtocol bridge, CCCPaymentControllerDelegate @delegate, [NullAllowed] CCCTheme theme);

        // -(void)presentPaymentView;
        [Export("presentPaymentView")]
        void PresentPaymentView();

        // -(void)pushPaymentView;
        [Export("pushPaymentView")]
        void PushPaymentView();
    }

    // @protocol CCCPaymentControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface CCCPaymentControllerDelegate
    {
        // @required -(void)paymentController:(CCCPaymentController * _Nonnull)controller finishedWithAccount:(CCCAccount * _Nonnull)account;
        [Abstract]
        [Export("paymentController:finishedWithAccount:")]
        void PaymentController(CCCPaymentController controller, CCCAccount account);

        // @optional -(void)didCancelPaymentController:(CCCPaymentController * _Nonnull)controller;
        [Export("didCancelPaymentController:")]
        void DidCancelPaymentController(CCCPaymentController controller);

        // @optional -(void)paymentController:(CCCPaymentController * _Nonnull)controller finishedApplePayWithResult:(BOOL)result;
        [Export("paymentController:finishedApplePayWithResult:")]
        void PaymentController(CCCPaymentController controller, bool result);
    }

    // @interface CCCPaymentRequest : NSObject
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface CCCPaymentRequest
    {
        // @property (copy, nonatomic) NSString * _Nullable applePayMerchantID;
        [NullAllowed, Export("applePayMerchantID")]
        string ApplePayMerchantID { get; set; }

        // @property (copy, nonatomic) NSDecimalNumber * _Nullable total;
        [NullAllowed, Export("total", ArgumentSemantic.Copy)]
        NSDecimalNumber Total { get; set; }

        // @property (copy, nonatomic) NSData * _Nullable additionalData;
        [NullAllowed, Export("additionalData", ArgumentSemantic.Copy)]
        NSData AdditionalData { get; set; }
    }



    partial interface Constants
    {
        // extern double CardConnectConsumerSDKVersionNumber;
        [Field("CardConnectConsumerSDKVersionNumber", "__Internal")]
        double CardConnectConsumerSDKVersionNumber { get; }

        // extern const unsigned char [] CardConnectConsumerSDKVersionString;
        [Field("CardConnectConsumerSDKVersionString", "__Internal")]
        NSString CardConnectConsumerSDKVersionString { get; }
    }
}
