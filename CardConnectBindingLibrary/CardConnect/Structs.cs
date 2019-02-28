using System;

using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace CardConnectBinding
{
    [Native]
    public enum CCCCardIssuer : long
    {
        None,
        Amex,
        Visa,
        Discover,
        MasterCard,
        Diners,
        Jcb,
        Maestro,
        Other
    }

    static class CFunctions
    {
        // extern NSString * CCC_AccountTypeForIssuer (CCCCardIssuer issuer);
        [DllImport("__Internal")]

        static extern NSString CCC_AccountTypeForIssuer(CCCCardIssuer issuer);

        // extern CCCCardIssuer CCC_CardIssuerForAccountType (NSString *accountType);
        [DllImport("__Internal")]

        static extern CCCCardIssuer CCC_CardIssuerForAccountType(NSString accountType);

        // extern BOOL CCC_LuhnCheck (NSString *number);
        [DllImport("__Internal")]

        static extern bool CCC_LuhnCheck(NSString number);

        // extern CCCCardIssuer CCC_CardIssuerFromCardNumber (NSString *cardNumber);
        [DllImport("__Internal")]

        static extern CCCCardIssuer CCC_CardIssuerFromCardNumber(NSString cardNumber);

        // extern NSInteger CCC_MaxCardNumberLengthForCardNumber (NSString *cardNumber);
        [DllImport("__Internal")]

        static extern nint CCC_MaxCardNumberLengthForCardNumber(NSString cardNumber);

        // extern BOOL CCC_ValidateCardLength (NSString *cardNumber);
        [DllImport("__Internal")]

        static extern bool CCC_ValidateCardLength(NSString cardNumber);

        // extern BOOL CCC_ValidateCardNumber (NSString *cardNumber);
        [DllImport("__Internal")]

        static extern bool CCC_ValidateCardNumber(NSString cardNumber);

        // extern NSString * CCC_MaskCardNumberWithCharacterAndFormat (NSString *cardNumber, unichar maskCharacter, CCCCardMaskFormat format, CCCCardMaskSpacing spacing);
        [DllImport("__Internal")]

        static extern NSString CCC_MaskCardNumberWithCharacterAndFormat(NSString cardNumber, ushort maskCharacter, CCCCardMaskFormat format, CCCCardMaskSpacing spacing);

        // extern BOOL CCC_ValidateCVV (NSString *CVV);
        [DllImport("__Internal")]

        static extern bool CCC_ValidateCVV(NSString CVV);

        // extern BOOL CCC_ValidateCVVForCardNumber (NSString *CVV, NSString *cardNumber);
        [DllImport("__Internal")]

        static extern bool CCC_ValidateCVVForCardNumber(NSString CVV, NSString cardNumber);

        // extern NSString * CCC_MaskCVVWithCharacter (NSString *CVV, unichar maskCharacter);
        [DllImport("__Internal")]

        static extern NSString CCC_MaskCVVWithCharacter(NSString CVV, ushort maskCharacter);

        // extern BOOL CCC_ValidateExpirationDate (NSDate *date);
        [DllImport("__Internal")]

        static extern bool CCC_ValidateExpirationDate(NSDate date);

        // extern NSString * CCC_Base64GZippedSignatureForImage (UIImage *image);
        [DllImport("__Internal")]

        static extern NSString CCC_Base64GZippedSignatureForImage(UIImage image);

        // extern UIImage * CCC_ImageFromBase64GZippedString (NSString *string);
        [DllImport("__Internal")]

        static extern UIImage CCC_ImageFromBase64GZippedString(NSString @string);

        // extern NSDateFormatter * CCC_UTCDateFormatter ();
        [DllImport("__Internal")]

        static extern NSDateFormatter CCC_UTCDateFormatter();
    }

    [Native]
    public enum CCCCardMaskFormat : long
    {
        MaskWithLastFour,
        LastFour,
        FirstAndLastFour
    }

    [Native]
    public enum CCCCardMaskSpacing : long
    {
        None,
        EveryFour,
        EveryCharacter,
        EveryCharacterAndFour
    }

    [Native]
    public enum CCCExpirationDateInput : long
    {
        Four,
        Six
    }

    [Native]
    public enum CCCSwiperConnectionState : long
    {
        Disconnected = 0,
        Connecting = 1,
        Connected = 2
    }

    [Native]
    public enum CCCSwiperBatteryStatus : long
    {
        Low,
        Critical
    }
}
