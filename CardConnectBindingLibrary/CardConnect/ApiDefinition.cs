using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using PassKit;

namespace CardConnectBinding
{
    // The first step to creating a binding is to add your native library ("libNativeLibrary.a")
    // to the project by right-clicking (or Control-clicking) the folder containing this source
    // file and clicking "Add files..." and then simply select the native library (or libraries)
    // that you want to bind.
    //
    // When you do that, you'll notice that MonoDevelop generates a code-behind file for each
    // native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
    // architectures that the native library supports and fills in that information for you,
    // however, it cannot auto-detect any Frameworks or other system libraries that the
    // native library may depend on, so you'll need to fill in that information yourself.
    //
    // Once you've done that, you're ready to move on to binding the API...
    //
    //
    // Here is where you'd define your API definition for the native Objective-C library.
    //
    // For example, to bind the following Objective-C class:
    //
    //     @interface Widget : NSObject {
    //     }
    //
    // The C# binding would look like this:
    //
    //     [BaseType (typeof (NSObject))]
    //     interface Widget {
    //     }
    //
    // To bind Objective-C properties, such as:
    //
    //     @property (nonatomic, readwrite, assign) CGPoint center;
    //
    // You would add a property definition in the C# interface like so:
    //
    //     [Export ("center")]
    //     CGPoint Center { get; set; }
    //
    // To bind an Objective-C method, such as:
    //
    //     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
    //
    // You would add a method definition to the C# interface like so:
    //
    //     [Export ("doSomething:atIndex:")]
    //     void DoSomething (NSObject object, int index);
    //
    // Objective-C "constructors" such as:
    //
    //     -(id)initWithElmo:(ElmoMuppet *)elmo;
    //
    // Can be bound as:
    //
    //     [Export ("initWithElmo:")]
    //     IntPtr Constructor (ElmoMuppet elmo);
    //
    // For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
    //

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
        [Export("accountType", ArgumentSemantic.Assign)]
        CCCCardIssuer AccountType { get; }

        // @property (assign, nonatomic) CCCCardMaskFormat maskFormat;
        [Export("maskFormat", ArgumentSemantic.Assign)]
        CCCCardMaskFormat MaskFormat { get; set; }

        // @property (assign, nonatomic) unichar maskCharacter;
        [Export("maskCharacter")]
        ushort MaskCharacter { get; set; }

        // @property (assign, nonatomic) CCCCardMaskSpacing maskSpacing;
        [Export("maskSpacing", ArgumentSemantic.Assign)]
        CCCCardMaskSpacing MaskSpacing { get; set; }

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

    // @protocol CCCFormatterDelegateExtension <UITextFieldDelegate>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface CCCFormatterDelegateExtension : IUITextFieldDelegate
    {
        // @optional -(void)didChangeCharactersInRangeForFormatter:(CCCTextFieldDelegateProxy *)formatter;
        [Export("didChangeCharactersInRangeForFormatter:")]
        void DidChangeCharactersInRangeForFormatter(CCCTextFieldDelegateProxy formatter);
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
        [Export("isValidCVVWithCardFormatter:")]
        bool IsValidCVVWithCardFormatter(CCCCardFormatterDelegate formatter);

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

    // @interface CCCCardFormatterDelegate : CCCTextFieldDelegateProxy
    [Protocol]
    [BaseType(typeof(CCCTextFieldDelegateProxy))]
    interface CCCCardFormatterDelegate
    {
        // @property (nonatomic) CCCCardMaskFormat maskFormat;
        [Export("maskFormat", ArgumentSemantic.Assign)]
        CCCCardMaskFormat MaskFormat { get; set; }

        // @property (nonatomic) unichar maskCharacter;
        [Export("maskCharacter")]
        ushort MaskCharacter { get; set; }

        // @property (assign, nonatomic) CCCCardMaskSpacing maskSpacing;
        [Export("maskSpacing", ArgumentSemantic.Assign)]
        CCCCardMaskSpacing MaskSpacing { get; set; }

        // @property (getter = isValidCard, nonatomic) BOOL validCard;
        [Export("validCard")]
        bool ValidCard { [Bind("isValidCard")] get; set; }

        // -(void)setCardNumberOnCardInfo:(CCCCardInfo *)cardInfo;
        [Export("setCardNumberOnCardInfo:")]
        void SetCardNumberOnCardInfo(CCCCardInfo cardInfo);
    }

    // @interface CCCExpirationDateFormatterDelegate : CCCTextFieldDelegateProxy
    [Protocol]
    [BaseType(typeof(CCCTextFieldDelegateProxy))]
    interface CCCExpirationDateFormatterDelegate
    {
        // @property (nonatomic) unichar separatorCharacter;
        [Export("separatorCharacter")]
        ushort SeparatorCharacter { get; set; }

        // @property (assign, nonatomic) CCCExpirationDateInput inputCount;
        [Export("inputCount", ArgumentSemantic.Assign)]
        CCCExpirationDateInput InputCount { get; set; }

        // @property (getter = isValidExpirationDate, nonatomic) BOOL validExpirationDate;
        [Export("validExpirationDate")]
        bool ValidExpirationDate { [Bind("isValidExpirationDate")] get; set; }

        // @property (readonly, nonatomic) NSDate * expirationDate;
        [Export("expirationDate")]
        NSDate ExpirationDate { get; }

        // -(void)setExpirationDateOnCardInfo:(CCCCardInfo *)cardInfo;
        [Export("setExpirationDateOnCardInfo:")]
        void SetExpirationDateOnCardInfo(CCCCardInfo cardInfo);

        // -(instancetype)initWithDate:(NSDate *)date;
        [Export("initWithDate:")]
        IntPtr Constructor(NSDate date);
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
        IntPtr Constructor(UIViewController rootView, CCCAPIBridgeProtocol bridge, CCCPaymentControllerDelegate @del);

        // -(instancetype _Nullable)initWithRootView:(UIViewController * _Nonnull)rootView apiBridge:(id<CCCAPIBridgeProtocol> _Nonnull)bridge delegate:(id<CCCPaymentControllerDelegate> _Nonnull)delegate theme:(CCCTheme * _Nullable)theme;
        [Export("initWithRootView:apiBridge:delegate:theme:")]
        IntPtr Constructor(UIViewController rootView, CCCAPIBridgeProtocol bridge, CCCPaymentControllerDelegate @del, [NullAllowed] CCCTheme theme);

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

    // @interface CCCSwiper : NSObject
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface CCCSwiper
    {
        [Wrap("WeakDelegate")]
        CCCSwiperDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<CCCSwiperDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, assign, nonatomic) CCCSwiperConnectionState connectionState;
        [Export("connectionState", ArgumentSemantic.Assign)]
        CCCSwiperConnectionState ConnectionState { get; }

        // +(NSString *)model;
        [Static]
        [Export("model")]
        string Model { get; }

        // @property (getter = isDebugLoggingEnabled, nonatomic) BOOL debugLoggingEnabled;
        [Export("debugLoggingEnabled")]
        bool DebugLoggingEnabled { [Bind("isDebugLoggingEnabled")] get; set; }

        // -(instancetype)initWithDelegate:(id<CCCSwiperDelegate>)delegate;
        [Export("initWithDelegate:")]
        IntPtr Constructor(CCCSwiperDelegate @delegate);

        // -(instancetype)initWithDelegate:(id<CCCSwiperDelegate>)delegate loggingEnabled:(BOOL)enabled;
        [Export("initWithDelegate:loggingEnabled:")]
        IntPtr Constructor(CCCSwiperDelegate @delegate, bool enabled);

        // -(_Bool)shouldShowAudioWarning;
        [Export("shouldShowAudioWarning")]
        bool ShouldShowAudioWarning { get; }
    }

    // @protocol CCCSwiperDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface CCCSwiperDelegate
    {
        // @required -(void)swiper:(CCCSwiper *)swiper didGenerateTokenWithAccount:(CCCAccount *)account completion:(void (^)())completion;
        [Abstract]
        [Export("swiper:didGenerateTokenWithAccount:completion:")]
        void Swiper(CCCSwiper swiper, CCCAccount account, Action completion);

        // @required -(void)swiper:(CCCSwiper *)swiper didFailWithError:(NSError *)error completion:(void (^)())completion;
        [Abstract]
        [Export("swiper:didFailWithError:completion:")]
        void Swiper(CCCSwiper swiper, NSError error, Action completion);

        // @optional -(void)swiper:(CCCSwiper *)swiper connectionStateHasChanged:(CCCSwiperConnectionState)state;
        [Export("swiper:connectionStateHasChanged:")]
        void Swiper(CCCSwiper swiper, CCCSwiperConnectionState state);

        // @optional -(void)swiper:(CCCSwiper *)swiper batteryLevelStatusHasChanged:(CCCSwiperBatteryStatus)status;
        [Export("swiper:batteryLevelStatusHasChanged:")]
        void Swiper(CCCSwiper swiper, CCCSwiperBatteryStatus status);

        // @optional -(void)swiperDidStartMSR:(CCCSwiper *)swiper;
        [Export("swiperDidStartMSR:")]
        void SwiperDidStartMSR(CCCSwiper swiper);
    }

    // @interface CCCSwiperController : CCCSwiper
    [Protocol]
    [BaseType(typeof(CCCSwiper))]
    interface CCCSwiperController
    {
        // -(instancetype)initWithDelegate:(id<CCCSwiperDelegate>)delegate loggingEnabled:(BOOL)enabled;
        [Export("initWithDelegate:loggingEnabled:")]
        IntPtr Constructor(CCCSwiperDelegate @delegate, bool enabled);
    }

    // @interface CCCTheme : NSObject
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface CCCTheme
    {
        // @property (assign, nonatomic) UIBarStyle navigationBarStyle;
        [Export("navigationBarStyle", ArgumentSemantic.Assign)]
        UIBarStyle NavigationBarStyle { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified navigationBarColor;
        [Export("navigationBarColor", ArgumentSemantic.Strong)]
        UIColor NavigationBarColor { get; set; }

        // @property (assign, nonatomic) BOOL navigationBarTranslucent;
        [Export("navigationBarTranslucent")]
        bool NavigationBarTranslucent { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified navigationTitleColor;
        [Export("navigationTitleColor", ArgumentSemantic.Strong)]
        UIColor NavigationTitleColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Null_unspecified navigationTitleFont;
        [Export("navigationTitleFont", ArgumentSemantic.Strong)]
        UIFont NavigationTitleFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified navigationButtonColor;
        [Export("navigationButtonColor", ArgumentSemantic.Strong)]
        UIColor NavigationButtonColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Null_unspecified navigationButtonFont;
        [Export("navigationButtonFont", ArgumentSemantic.Strong)]
        UIFont NavigationButtonFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable disclaimerText;
        [NullAllowed, Export("disclaimerText", ArgumentSemantic.Strong)]
        string DisclaimerText { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified disclaimerTextColor;
        [Export("disclaimerTextColor", ArgumentSemantic.Strong)]
        UIColor DisclaimerTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Null_unspecified disclaimerTextFont;
        [Export("disclaimerTextFont", ArgumentSemantic.Strong)]
        UIFont DisclaimerTextFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified buttonColor;
        [Export("buttonColor", ArgumentSemantic.Strong)]
        UIColor ButtonColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified buttonTextColor;
        [Export("buttonTextColor", ArgumentSemantic.Strong)]
        UIColor ButtonTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Null_unspecified buttonTextFont;
        [Export("buttonTextFont", ArgumentSemantic.Strong)]
        UIFont ButtonTextFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified spinnerBackgroundColor;
        [Export("spinnerBackgroundColor", ArgumentSemantic.Strong)]
        UIColor SpinnerBackgroundColor { get; set; }

        // @property (assign, nonatomic) UIActivityIndicatorViewStyle spinnerStyle;
        [Export("spinnerStyle", ArgumentSemantic.Assign)]
        UIActivityIndicatorViewStyle SpinnerStyle { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified listSeparatorColor;
        [Export("listSeparatorColor", ArgumentSemantic.Strong)]
        UIColor ListSeparatorColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified listCellColor;
        [Export("listCellColor", ArgumentSemantic.Strong)]
        UIColor ListCellColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified listTextColor;
        [Export("listTextColor", ArgumentSemantic.Strong)]
        UIColor ListTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Null_unspecified listTextFont;
        [Export("listTextFont", ArgumentSemantic.Strong)]
        UIFont ListTextFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified listSecondaryTextColor;
        [Export("listSecondaryTextColor", ArgumentSemantic.Strong)]
        UIColor ListSecondaryTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Null_unspecified listSecondaryTextFont;
        [Export("listSecondaryTextFont", ArgumentSemantic.Strong)]
        UIFont ListSecondaryTextFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified listSectionHeaderColor;
        [Export("listSectionHeaderColor", ArgumentSemantic.Strong)]
        UIColor ListSectionHeaderColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Null_unspecified listSectionHeaderFont;
        [Export("listSectionHeaderFont", ArgumentSemantic.Strong)]
        UIFont ListSectionHeaderFont { get; set; }

        // @property (assign, nonatomic) BOOL collectContactInfo;
        [Export("collectContactInfo")]
        bool CollectContactInfo { get; set; }

        // @property (assign, nonatomic) BOOL collectBillingAddress;
        [Export("collectBillingAddress")]
        bool CollectBillingAddress { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable cardColor;
        [NullAllowed, Export("cardColor", ArgumentSemantic.Strong)]
        UIColor CardColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified cardTextColor;
        [Export("cardTextColor", ArgumentSemantic.Strong)]
        UIColor CardTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Null_unspecified cardTextFont;
        [Export("cardTextFont", ArgumentSemantic.Strong)]
        UIFont CardTextFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified listInputTextColor;
        [Export("listInputTextColor", ArgumentSemantic.Strong)]
        UIColor ListInputTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Null_unspecified listInputTextFont;
        [Export("listInputTextFont", ArgumentSemantic.Strong)]
        UIFont ListInputTextFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified listToggleOnColor;
        [Export("listToggleOnColor", ArgumentSemantic.Strong)]
        UIColor ListToggleOnColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable listToggleTintColor;
        [NullAllowed, Export("listToggleTintColor", ArgumentSemantic.Strong)]
        UIColor ListToggleTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable listToggleThumbColor;
        [NullAllowed, Export("listToggleThumbColor", ArgumentSemantic.Strong)]
        UIColor ListToggleThumbColor { get; set; }

        // @property (assign, nonatomic) CCCCardMaskFormat maskFormat;
        [Export("maskFormat", ArgumentSemantic.Assign)]
        CCCCardMaskFormat MaskFormat { get; set; }

        // @property (assign, nonatomic) unichar maskCharacter;
        [Export("maskCharacter")]
        ushort MaskCharacter { get; set; }

        // @property (assign, nonatomic) CCCCardMaskSpacing cardDisplayMaskSpacing;
        [Export("cardDisplayMaskSpacing", ArgumentSemantic.Assign)]
        CCCCardMaskSpacing CardDisplayMaskSpacing { get; set; }

        // @property (assign, nonatomic) CCCCardMaskSpacing cardTextFieldMaskSpacing;
        [Export("cardTextFieldMaskSpacing", ArgumentSemantic.Assign)]
        CCCCardMaskSpacing CardTextFieldMaskSpacing { get; set; }

        // @property (nonatomic) unichar separatorCharacter;
        [Export("separatorCharacter")]
        ushort SeparatorCharacter { get; set; }

        // @property (assign, nonatomic) CCCExpirationDateInput expirationDateInputCount;
        [Export("expirationDateInputCount", ArgumentSemantic.Assign)]
        CCCExpirationDateInput ExpirationDateInputCount { get; set; }

        // @property (nonatomic, strong) NSString * _Null_unspecified applePayButtonDescription;
        [Export("applePayButtonDescription", ArgumentSemantic.Strong)]
        string ApplePayButtonDescription { get; set; }

        // @property (assign, nonatomic) PKPaymentButtonType applePayButtonType;
        [Export("applePayButtonType", ArgumentSemantic.Assign)]
        PKPaymentButtonType ApplePayButtonType { get; set; }

        // @property (assign, nonatomic) PKPaymentButtonStyle applePayButtonStyle;
        [Export("applePayButtonStyle", ArgumentSemantic.Assign)]
        PKPaymentButtonStyle ApplePayButtonStyle { get; set; }
    }

    //[Static]
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
