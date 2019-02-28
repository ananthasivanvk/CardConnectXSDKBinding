//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace CardConnectBinding {
	[Protocol (Name = "CCCTheme", WrapperType = typeof (CCCThemeWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "NavigationBarStyle", Selector = "navigationBarStyle", PropertyType = typeof (UIBarStyle), GetterSelector = "navigationBarStyle", SetterSelector = "setNavigationBarStyle:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "NavigationBarColor", Selector = "navigationBarColor", PropertyType = typeof (UIColor), GetterSelector = "navigationBarColor", SetterSelector = "setNavigationBarColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "NavigationBarTranslucent", Selector = "navigationBarTranslucent", PropertyType = typeof (bool), GetterSelector = "navigationBarTranslucent", SetterSelector = "setNavigationBarTranslucent:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "NavigationTitleColor", Selector = "navigationTitleColor", PropertyType = typeof (UIColor), GetterSelector = "navigationTitleColor", SetterSelector = "setNavigationTitleColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "NavigationTitleFont", Selector = "navigationTitleFont", PropertyType = typeof (UIFont), GetterSelector = "navigationTitleFont", SetterSelector = "setNavigationTitleFont:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "NavigationButtonColor", Selector = "navigationButtonColor", PropertyType = typeof (UIColor), GetterSelector = "navigationButtonColor", SetterSelector = "setNavigationButtonColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "NavigationButtonFont", Selector = "navigationButtonFont", PropertyType = typeof (UIFont), GetterSelector = "navigationButtonFont", SetterSelector = "setNavigationButtonFont:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "BackgroundColor", Selector = "backgroundColor", PropertyType = typeof (UIColor), GetterSelector = "backgroundColor", SetterSelector = "setBackgroundColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DisclaimerText", Selector = "disclaimerText", PropertyType = typeof (string), GetterSelector = "disclaimerText", SetterSelector = "setDisclaimerText:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DisclaimerTextColor", Selector = "disclaimerTextColor", PropertyType = typeof (UIColor), GetterSelector = "disclaimerTextColor", SetterSelector = "setDisclaimerTextColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DisclaimerTextFont", Selector = "disclaimerTextFont", PropertyType = typeof (UIFont), GetterSelector = "disclaimerTextFont", SetterSelector = "setDisclaimerTextFont:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ButtonColor", Selector = "buttonColor", PropertyType = typeof (UIColor), GetterSelector = "buttonColor", SetterSelector = "setButtonColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ButtonTextColor", Selector = "buttonTextColor", PropertyType = typeof (UIColor), GetterSelector = "buttonTextColor", SetterSelector = "setButtonTextColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ButtonTextFont", Selector = "buttonTextFont", PropertyType = typeof (UIFont), GetterSelector = "buttonTextFont", SetterSelector = "setButtonTextFont:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SpinnerBackgroundColor", Selector = "spinnerBackgroundColor", PropertyType = typeof (UIColor), GetterSelector = "spinnerBackgroundColor", SetterSelector = "setSpinnerBackgroundColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SpinnerStyle", Selector = "spinnerStyle", PropertyType = typeof (UIActivityIndicatorViewStyle), GetterSelector = "spinnerStyle", SetterSelector = "setSpinnerStyle:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ListSeparatorColor", Selector = "listSeparatorColor", PropertyType = typeof (UIColor), GetterSelector = "listSeparatorColor", SetterSelector = "setListSeparatorColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ListCellColor", Selector = "listCellColor", PropertyType = typeof (UIColor), GetterSelector = "listCellColor", SetterSelector = "setListCellColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ListTextColor", Selector = "listTextColor", PropertyType = typeof (UIColor), GetterSelector = "listTextColor", SetterSelector = "setListTextColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ListTextFont", Selector = "listTextFont", PropertyType = typeof (UIFont), GetterSelector = "listTextFont", SetterSelector = "setListTextFont:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ListSecondaryTextColor", Selector = "listSecondaryTextColor", PropertyType = typeof (UIColor), GetterSelector = "listSecondaryTextColor", SetterSelector = "setListSecondaryTextColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ListSecondaryTextFont", Selector = "listSecondaryTextFont", PropertyType = typeof (UIFont), GetterSelector = "listSecondaryTextFont", SetterSelector = "setListSecondaryTextFont:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ListSectionHeaderColor", Selector = "listSectionHeaderColor", PropertyType = typeof (UIColor), GetterSelector = "listSectionHeaderColor", SetterSelector = "setListSectionHeaderColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ListSectionHeaderFont", Selector = "listSectionHeaderFont", PropertyType = typeof (UIFont), GetterSelector = "listSectionHeaderFont", SetterSelector = "setListSectionHeaderFont:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CollectContactInfo", Selector = "collectContactInfo", PropertyType = typeof (bool), GetterSelector = "collectContactInfo", SetterSelector = "setCollectContactInfo:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CollectBillingAddress", Selector = "collectBillingAddress", PropertyType = typeof (bool), GetterSelector = "collectBillingAddress", SetterSelector = "setCollectBillingAddress:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CardColor", Selector = "cardColor", PropertyType = typeof (UIColor), GetterSelector = "cardColor", SetterSelector = "setCardColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CardTextColor", Selector = "cardTextColor", PropertyType = typeof (UIColor), GetterSelector = "cardTextColor", SetterSelector = "setCardTextColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CardTextFont", Selector = "cardTextFont", PropertyType = typeof (UIFont), GetterSelector = "cardTextFont", SetterSelector = "setCardTextFont:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ListInputTextColor", Selector = "listInputTextColor", PropertyType = typeof (UIColor), GetterSelector = "listInputTextColor", SetterSelector = "setListInputTextColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ListInputTextFont", Selector = "listInputTextFont", PropertyType = typeof (UIFont), GetterSelector = "listInputTextFont", SetterSelector = "setListInputTextFont:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ListToggleOnColor", Selector = "listToggleOnColor", PropertyType = typeof (UIColor), GetterSelector = "listToggleOnColor", SetterSelector = "setListToggleOnColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ListToggleTintColor", Selector = "listToggleTintColor", PropertyType = typeof (UIColor), GetterSelector = "listToggleTintColor", SetterSelector = "setListToggleTintColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ListToggleThumbColor", Selector = "listToggleThumbColor", PropertyType = typeof (UIColor), GetterSelector = "listToggleThumbColor", SetterSelector = "setListToggleThumbColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MaskFormat", Selector = "maskFormat", PropertyType = typeof (CardConnectBinding.CCCCardMaskFormat), GetterSelector = "maskFormat", SetterSelector = "setMaskFormat:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MaskCharacter", Selector = "maskCharacter", PropertyType = typeof (UInt16), GetterSelector = "maskCharacter", SetterSelector = "setMaskCharacter:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CardDisplayMaskSpacing", Selector = "cardDisplayMaskSpacing", PropertyType = typeof (CardConnectBinding.CCCCardMaskSpacing), GetterSelector = "cardDisplayMaskSpacing", SetterSelector = "setCardDisplayMaskSpacing:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CardTextFieldMaskSpacing", Selector = "cardTextFieldMaskSpacing", PropertyType = typeof (CardConnectBinding.CCCCardMaskSpacing), GetterSelector = "cardTextFieldMaskSpacing", SetterSelector = "setCardTextFieldMaskSpacing:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SeparatorCharacter", Selector = "separatorCharacter", PropertyType = typeof (UInt16), GetterSelector = "separatorCharacter", SetterSelector = "setSeparatorCharacter:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ExpirationDateInputCount", Selector = "expirationDateInputCount", PropertyType = typeof (CardConnectBinding.CCCExpirationDateInput), GetterSelector = "expirationDateInputCount", SetterSelector = "setExpirationDateInputCount:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ApplePayButtonDescription", Selector = "applePayButtonDescription", PropertyType = typeof (string), GetterSelector = "applePayButtonDescription", SetterSelector = "setApplePayButtonDescription:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ApplePayButtonType", Selector = "applePayButtonType", PropertyType = typeof (PassKit.PKPaymentButtonType), GetterSelector = "applePayButtonType", SetterSelector = "setApplePayButtonType:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ApplePayButtonStyle", Selector = "applePayButtonStyle", PropertyType = typeof (PassKit.PKPaymentButtonStyle), GetterSelector = "applePayButtonStyle", SetterSelector = "setApplePayButtonStyle:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	public interface ICCCTheme : INativeObject, IDisposable
	{
	}
	
	public static partial class CCCTheme_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIBarStyle GetNavigationBarStyle (this ICCCTheme This)
		{
			global::UIKit.UIBarStyle ret;
			if (IntPtr.Size == 8) {
				ret = (global::UIKit.UIBarStyle) global::ApiDefinition.Messaging.Int64_objc_msgSend (This.Handle, Selector.GetHandle ("navigationBarStyle"));
			} else {
				ret = (global::UIKit.UIBarStyle) global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("navigationBarStyle"));
			}
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetNavigationBarStyle (this ICCCTheme This, global::UIKit.UIBarStyle value)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (This.Handle, Selector.GetHandle ("setNavigationBarStyle:"), (Int64)value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setNavigationBarStyle:"), (int)value);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor GetNavigationBarColor (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("navigationBarColor")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetNavigationBarColor (this ICCCTheme This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setNavigationBarColor:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetNavigationBarTranslucent (this ICCCTheme This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("navigationBarTranslucent"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetNavigationBarTranslucent (this ICCCTheme This, bool value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setNavigationBarTranslucent:"), value);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor GetNavigationTitleColor (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("navigationTitleColor")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetNavigationTitleColor (this ICCCTheme This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setNavigationTitleColor:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIFont GetNavigationTitleFont (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("navigationTitleFont")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetNavigationTitleFont (this ICCCTheme This, global::UIKit.UIFont value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setNavigationTitleFont:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor GetNavigationButtonColor (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("navigationButtonColor")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetNavigationButtonColor (this ICCCTheme This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setNavigationButtonColor:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIFont GetNavigationButtonFont (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("navigationButtonFont")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetNavigationButtonFont (this ICCCTheme This, global::UIKit.UIFont value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setNavigationButtonFont:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor GetBackgroundColor (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("backgroundColor")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetBackgroundColor (this ICCCTheme This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setBackgroundColor:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetDisclaimerText (this ICCCTheme This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("disclaimerText")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDisclaimerText (this ICCCTheme This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDisclaimerText:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor GetDisclaimerTextColor (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("disclaimerTextColor")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDisclaimerTextColor (this ICCCTheme This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDisclaimerTextColor:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIFont GetDisclaimerTextFont (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("disclaimerTextFont")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDisclaimerTextFont (this ICCCTheme This, global::UIKit.UIFont value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDisclaimerTextFont:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor GetButtonColor (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("buttonColor")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetButtonColor (this ICCCTheme This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setButtonColor:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor GetButtonTextColor (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("buttonTextColor")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetButtonTextColor (this ICCCTheme This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setButtonTextColor:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIFont GetButtonTextFont (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("buttonTextFont")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetButtonTextFont (this ICCCTheme This, global::UIKit.UIFont value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setButtonTextFont:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor GetSpinnerBackgroundColor (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("spinnerBackgroundColor")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSpinnerBackgroundColor (this ICCCTheme This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSpinnerBackgroundColor:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIActivityIndicatorViewStyle GetSpinnerStyle (this ICCCTheme This)
		{
			global::UIKit.UIActivityIndicatorViewStyle ret;
			if (IntPtr.Size == 8) {
				ret = (global::UIKit.UIActivityIndicatorViewStyle) global::ApiDefinition.Messaging.Int64_objc_msgSend (This.Handle, Selector.GetHandle ("spinnerStyle"));
			} else {
				ret = (global::UIKit.UIActivityIndicatorViewStyle) global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("spinnerStyle"));
			}
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSpinnerStyle (this ICCCTheme This, global::UIKit.UIActivityIndicatorViewStyle value)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (This.Handle, Selector.GetHandle ("setSpinnerStyle:"), (Int64)value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setSpinnerStyle:"), (int)value);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor GetListSeparatorColor (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("listSeparatorColor")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetListSeparatorColor (this ICCCTheme This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setListSeparatorColor:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor GetListCellColor (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("listCellColor")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetListCellColor (this ICCCTheme This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setListCellColor:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor GetListTextColor (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("listTextColor")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetListTextColor (this ICCCTheme This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setListTextColor:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIFont GetListTextFont (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("listTextFont")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetListTextFont (this ICCCTheme This, global::UIKit.UIFont value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setListTextFont:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor GetListSecondaryTextColor (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("listSecondaryTextColor")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetListSecondaryTextColor (this ICCCTheme This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setListSecondaryTextColor:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIFont GetListSecondaryTextFont (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("listSecondaryTextFont")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetListSecondaryTextFont (this ICCCTheme This, global::UIKit.UIFont value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setListSecondaryTextFont:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor GetListSectionHeaderColor (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("listSectionHeaderColor")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetListSectionHeaderColor (this ICCCTheme This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setListSectionHeaderColor:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIFont GetListSectionHeaderFont (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("listSectionHeaderFont")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetListSectionHeaderFont (this ICCCTheme This, global::UIKit.UIFont value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setListSectionHeaderFont:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetCollectContactInfo (this ICCCTheme This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("collectContactInfo"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCollectContactInfo (this ICCCTheme This, bool value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setCollectContactInfo:"), value);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetCollectBillingAddress (this ICCCTheme This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("collectBillingAddress"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCollectBillingAddress (this ICCCTheme This, bool value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setCollectBillingAddress:"), value);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor GetCardColor (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("cardColor")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCardColor (this ICCCTheme This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setCardColor:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor GetCardTextColor (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("cardTextColor")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCardTextColor (this ICCCTheme This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setCardTextColor:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIFont GetCardTextFont (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("cardTextFont")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCardTextFont (this ICCCTheme This, global::UIKit.UIFont value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setCardTextFont:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor GetListInputTextColor (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("listInputTextColor")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetListInputTextColor (this ICCCTheme This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setListInputTextColor:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIFont GetListInputTextFont (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("listInputTextFont")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetListInputTextFont (this ICCCTheme This, global::UIKit.UIFont value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setListInputTextFont:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor GetListToggleOnColor (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("listToggleOnColor")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetListToggleOnColor (this ICCCTheme This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setListToggleOnColor:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor GetListToggleTintColor (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("listToggleTintColor")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetListToggleTintColor (this ICCCTheme This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setListToggleTintColor:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor GetListToggleThumbColor (this ICCCTheme This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("listToggleThumbColor")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetListToggleThumbColor (this ICCCTheme This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setListToggleThumbColor:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CCCCardMaskFormat GetMaskFormat (this ICCCTheme This)
		{
			CCCCardMaskFormat ret;
			if (IntPtr.Size == 8) {
				ret = (CCCCardMaskFormat) global::ApiDefinition.Messaging.Int64_objc_msgSend (This.Handle, Selector.GetHandle ("maskFormat"));
			} else {
				ret = (CCCCardMaskFormat) global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("maskFormat"));
			}
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMaskFormat (this ICCCTheme This, CCCCardMaskFormat value)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (This.Handle, Selector.GetHandle ("setMaskFormat:"), (Int64)value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setMaskFormat:"), (int)value);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ushort GetMaskCharacter (this ICCCTheme This)
		{
			return global::ApiDefinition.Messaging.UInt16_objc_msgSend (This.Handle, Selector.GetHandle ("maskCharacter"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMaskCharacter (this ICCCTheme This, ushort value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UInt16 (This.Handle, Selector.GetHandle ("setMaskCharacter:"), value);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CCCCardMaskSpacing GetCardDisplayMaskSpacing (this ICCCTheme This)
		{
			CCCCardMaskSpacing ret;
			if (IntPtr.Size == 8) {
				ret = (CCCCardMaskSpacing) global::ApiDefinition.Messaging.Int64_objc_msgSend (This.Handle, Selector.GetHandle ("cardDisplayMaskSpacing"));
			} else {
				ret = (CCCCardMaskSpacing) global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("cardDisplayMaskSpacing"));
			}
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCardDisplayMaskSpacing (this ICCCTheme This, CCCCardMaskSpacing value)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (This.Handle, Selector.GetHandle ("setCardDisplayMaskSpacing:"), (Int64)value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setCardDisplayMaskSpacing:"), (int)value);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CCCCardMaskSpacing GetCardTextFieldMaskSpacing (this ICCCTheme This)
		{
			CCCCardMaskSpacing ret;
			if (IntPtr.Size == 8) {
				ret = (CCCCardMaskSpacing) global::ApiDefinition.Messaging.Int64_objc_msgSend (This.Handle, Selector.GetHandle ("cardTextFieldMaskSpacing"));
			} else {
				ret = (CCCCardMaskSpacing) global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("cardTextFieldMaskSpacing"));
			}
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCardTextFieldMaskSpacing (this ICCCTheme This, CCCCardMaskSpacing value)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (This.Handle, Selector.GetHandle ("setCardTextFieldMaskSpacing:"), (Int64)value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setCardTextFieldMaskSpacing:"), (int)value);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ushort GetSeparatorCharacter (this ICCCTheme This)
		{
			return global::ApiDefinition.Messaging.UInt16_objc_msgSend (This.Handle, Selector.GetHandle ("separatorCharacter"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSeparatorCharacter (this ICCCTheme This, ushort value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UInt16 (This.Handle, Selector.GetHandle ("setSeparatorCharacter:"), value);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CCCExpirationDateInput GetExpirationDateInputCount (this ICCCTheme This)
		{
			CCCExpirationDateInput ret;
			if (IntPtr.Size == 8) {
				ret = (CCCExpirationDateInput) global::ApiDefinition.Messaging.Int64_objc_msgSend (This.Handle, Selector.GetHandle ("expirationDateInputCount"));
			} else {
				ret = (CCCExpirationDateInput) global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("expirationDateInputCount"));
			}
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetExpirationDateInputCount (this ICCCTheme This, CCCExpirationDateInput value)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (This.Handle, Selector.GetHandle ("setExpirationDateInputCount:"), (Int64)value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setExpirationDateInputCount:"), (int)value);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetApplePayButtonDescription (this ICCCTheme This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("applePayButtonDescription")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetApplePayButtonDescription (this ICCCTheme This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setApplePayButtonDescription:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::PassKit.PKPaymentButtonType GetApplePayButtonType (this ICCCTheme This)
		{
			global::PassKit.PKPaymentButtonType ret;
			if (IntPtr.Size == 8) {
				ret = (global::PassKit.PKPaymentButtonType) global::ApiDefinition.Messaging.Int64_objc_msgSend (This.Handle, Selector.GetHandle ("applePayButtonType"));
			} else {
				ret = (global::PassKit.PKPaymentButtonType) global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("applePayButtonType"));
			}
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetApplePayButtonType (this ICCCTheme This, global::PassKit.PKPaymentButtonType value)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (This.Handle, Selector.GetHandle ("setApplePayButtonType:"), (Int64)value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setApplePayButtonType:"), (int)value);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::PassKit.PKPaymentButtonStyle GetApplePayButtonStyle (this ICCCTheme This)
		{
			global::PassKit.PKPaymentButtonStyle ret;
			if (IntPtr.Size == 8) {
				ret = (global::PassKit.PKPaymentButtonStyle) global::ApiDefinition.Messaging.Int64_objc_msgSend (This.Handle, Selector.GetHandle ("applePayButtonStyle"));
			} else {
				ret = (global::PassKit.PKPaymentButtonStyle) global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("applePayButtonStyle"));
			}
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetApplePayButtonStyle (this ICCCTheme This, global::PassKit.PKPaymentButtonStyle value)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (This.Handle, Selector.GetHandle ("setApplePayButtonStyle:"), (Int64)value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setApplePayButtonStyle:"), (int)value);
			}
		}
		
	}
	
	internal sealed class CCCThemeWrapper : BaseWrapper, ICCCTheme {
		[Preserve (Conditional = true)]
		public CCCThemeWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CardConnectBinding {
	[Protocol()]
	[Register("CCCTheme", true)]
	public unsafe partial class CCCTheme : NSObject, ICCCTheme {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CCCTheme");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CCCTheme () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CCCTheme (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CCCTheme (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ApplePayButtonDescription {
			[Export ("applePayButtonDescription", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("applePayButtonDescription")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("applePayButtonDescription")));
				}
			}
			
			[Export ("setApplePayButtonDescription:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setApplePayButtonDescription:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setApplePayButtonDescription:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::PassKit.PKPaymentButtonStyle ApplePayButtonStyle {
			[Export ("applePayButtonStyle", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::PassKit.PKPaymentButtonStyle ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (global::PassKit.PKPaymentButtonStyle) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("applePayButtonStyle"));
					} else {
						ret = (global::PassKit.PKPaymentButtonStyle) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("applePayButtonStyle"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (global::PassKit.PKPaymentButtonStyle) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("applePayButtonStyle"));
					} else {
						ret = (global::PassKit.PKPaymentButtonStyle) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("applePayButtonStyle"));
					}
				}
				return ret;
			}
			
			[Export ("setApplePayButtonStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setApplePayButtonStyle:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setApplePayButtonStyle:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setApplePayButtonStyle:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setApplePayButtonStyle:"), (int)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::PassKit.PKPaymentButtonType ApplePayButtonType {
			[Export ("applePayButtonType", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::PassKit.PKPaymentButtonType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (global::PassKit.PKPaymentButtonType) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("applePayButtonType"));
					} else {
						ret = (global::PassKit.PKPaymentButtonType) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("applePayButtonType"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (global::PassKit.PKPaymentButtonType) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("applePayButtonType"));
					} else {
						ret = (global::PassKit.PKPaymentButtonType) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("applePayButtonType"));
					}
				}
				return ret;
			}
			
			[Export ("setApplePayButtonType:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setApplePayButtonType:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setApplePayButtonType:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setApplePayButtonType:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setApplePayButtonType:"), (int)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor BackgroundColor {
			[Export ("backgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backgroundColor")));
				}
				return ret;
			}
			
			[Export ("setBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor ButtonColor {
			[Export ("buttonColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("buttonColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("buttonColor")));
				}
				return ret;
			}
			
			[Export ("setButtonColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setButtonColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setButtonColor:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor ButtonTextColor {
			[Export ("buttonTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("buttonTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("buttonTextColor")));
				}
				return ret;
			}
			
			[Export ("setButtonTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setButtonTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setButtonTextColor:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIFont ButtonTextFont {
			[Export ("buttonTextFont", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("buttonTextFont")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("buttonTextFont")));
				}
				return ret;
			}
			
			[Export ("setButtonTextFont:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setButtonTextFont:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setButtonTextFont:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor CardColor {
			[Export ("cardColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cardColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cardColor")));
				}
				return ret;
			}
			
			[Export ("setCardColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCardColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCardColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CCCCardMaskSpacing CardDisplayMaskSpacing {
			[Export ("cardDisplayMaskSpacing", ArgumentSemantic.UnsafeUnretained)]
			get {
				CCCCardMaskSpacing ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (CCCCardMaskSpacing) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("cardDisplayMaskSpacing"));
					} else {
						ret = (CCCCardMaskSpacing) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("cardDisplayMaskSpacing"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (CCCCardMaskSpacing) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cardDisplayMaskSpacing"));
					} else {
						ret = (CCCCardMaskSpacing) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cardDisplayMaskSpacing"));
					}
				}
				return ret;
			}
			
			[Export ("setCardDisplayMaskSpacing:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setCardDisplayMaskSpacing:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setCardDisplayMaskSpacing:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setCardDisplayMaskSpacing:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setCardDisplayMaskSpacing:"), (int)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor CardTextColor {
			[Export ("cardTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cardTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cardTextColor")));
				}
				return ret;
			}
			
			[Export ("setCardTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCardTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCardTextColor:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CCCCardMaskSpacing CardTextFieldMaskSpacing {
			[Export ("cardTextFieldMaskSpacing", ArgumentSemantic.UnsafeUnretained)]
			get {
				CCCCardMaskSpacing ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (CCCCardMaskSpacing) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("cardTextFieldMaskSpacing"));
					} else {
						ret = (CCCCardMaskSpacing) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("cardTextFieldMaskSpacing"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (CCCCardMaskSpacing) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cardTextFieldMaskSpacing"));
					} else {
						ret = (CCCCardMaskSpacing) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cardTextFieldMaskSpacing"));
					}
				}
				return ret;
			}
			
			[Export ("setCardTextFieldMaskSpacing:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setCardTextFieldMaskSpacing:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setCardTextFieldMaskSpacing:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setCardTextFieldMaskSpacing:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setCardTextFieldMaskSpacing:"), (int)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIFont CardTextFont {
			[Export ("cardTextFont", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cardTextFont")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cardTextFont")));
				}
				return ret;
			}
			
			[Export ("setCardTextFont:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCardTextFont:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCardTextFont:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CollectBillingAddress {
			[Export ("collectBillingAddress")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("collectBillingAddress"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("collectBillingAddress"));
				}
			}
			
			[Export ("setCollectBillingAddress:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCollectBillingAddress:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCollectBillingAddress:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CollectContactInfo {
			[Export ("collectContactInfo")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("collectContactInfo"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("collectContactInfo"));
				}
			}
			
			[Export ("setCollectContactInfo:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCollectContactInfo:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCollectContactInfo:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DisclaimerText {
			[Export ("disclaimerText", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("disclaimerText")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disclaimerText")));
				}
			}
			
			[Export ("setDisclaimerText:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDisclaimerText:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDisclaimerText:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor DisclaimerTextColor {
			[Export ("disclaimerTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("disclaimerTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disclaimerTextColor")));
				}
				return ret;
			}
			
			[Export ("setDisclaimerTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDisclaimerTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDisclaimerTextColor:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIFont DisclaimerTextFont {
			[Export ("disclaimerTextFont", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("disclaimerTextFont")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disclaimerTextFont")));
				}
				return ret;
			}
			
			[Export ("setDisclaimerTextFont:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDisclaimerTextFont:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDisclaimerTextFont:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CCCExpirationDateInput ExpirationDateInputCount {
			[Export ("expirationDateInputCount", ArgumentSemantic.UnsafeUnretained)]
			get {
				CCCExpirationDateInput ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (CCCExpirationDateInput) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("expirationDateInputCount"));
					} else {
						ret = (CCCExpirationDateInput) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("expirationDateInputCount"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (CCCExpirationDateInput) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("expirationDateInputCount"));
					} else {
						ret = (CCCExpirationDateInput) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("expirationDateInputCount"));
					}
				}
				return ret;
			}
			
			[Export ("setExpirationDateInputCount:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setExpirationDateInputCount:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setExpirationDateInputCount:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setExpirationDateInputCount:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setExpirationDateInputCount:"), (int)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor ListCellColor {
			[Export ("listCellColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("listCellColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("listCellColor")));
				}
				return ret;
			}
			
			[Export ("setListCellColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setListCellColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setListCellColor:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor ListInputTextColor {
			[Export ("listInputTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("listInputTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("listInputTextColor")));
				}
				return ret;
			}
			
			[Export ("setListInputTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setListInputTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setListInputTextColor:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIFont ListInputTextFont {
			[Export ("listInputTextFont", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("listInputTextFont")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("listInputTextFont")));
				}
				return ret;
			}
			
			[Export ("setListInputTextFont:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setListInputTextFont:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setListInputTextFont:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor ListSecondaryTextColor {
			[Export ("listSecondaryTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("listSecondaryTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("listSecondaryTextColor")));
				}
				return ret;
			}
			
			[Export ("setListSecondaryTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setListSecondaryTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setListSecondaryTextColor:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIFont ListSecondaryTextFont {
			[Export ("listSecondaryTextFont", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("listSecondaryTextFont")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("listSecondaryTextFont")));
				}
				return ret;
			}
			
			[Export ("setListSecondaryTextFont:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setListSecondaryTextFont:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setListSecondaryTextFont:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor ListSectionHeaderColor {
			[Export ("listSectionHeaderColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("listSectionHeaderColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("listSectionHeaderColor")));
				}
				return ret;
			}
			
			[Export ("setListSectionHeaderColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setListSectionHeaderColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setListSectionHeaderColor:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIFont ListSectionHeaderFont {
			[Export ("listSectionHeaderFont", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("listSectionHeaderFont")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("listSectionHeaderFont")));
				}
				return ret;
			}
			
			[Export ("setListSectionHeaderFont:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setListSectionHeaderFont:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setListSectionHeaderFont:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor ListSeparatorColor {
			[Export ("listSeparatorColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("listSeparatorColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("listSeparatorColor")));
				}
				return ret;
			}
			
			[Export ("setListSeparatorColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setListSeparatorColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setListSeparatorColor:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor ListTextColor {
			[Export ("listTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("listTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("listTextColor")));
				}
				return ret;
			}
			
			[Export ("setListTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setListTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setListTextColor:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIFont ListTextFont {
			[Export ("listTextFont", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("listTextFont")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("listTextFont")));
				}
				return ret;
			}
			
			[Export ("setListTextFont:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setListTextFont:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setListTextFont:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor ListToggleOnColor {
			[Export ("listToggleOnColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("listToggleOnColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("listToggleOnColor")));
				}
				return ret;
			}
			
			[Export ("setListToggleOnColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setListToggleOnColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setListToggleOnColor:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor ListToggleThumbColor {
			[Export ("listToggleThumbColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("listToggleThumbColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("listToggleThumbColor")));
				}
				return ret;
			}
			
			[Export ("setListToggleThumbColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setListToggleThumbColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setListToggleThumbColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor ListToggleTintColor {
			[Export ("listToggleTintColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("listToggleTintColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("listToggleTintColor")));
				}
				return ret;
			}
			
			[Export ("setListToggleTintColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setListToggleTintColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setListToggleTintColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ushort MaskCharacter {
			[Export ("maskCharacter")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.UInt16_objc_msgSend (this.Handle, Selector.GetHandle ("maskCharacter"));
				} else {
					return global::ApiDefinition.Messaging.UInt16_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maskCharacter"));
				}
			}
			
			[Export ("setMaskCharacter:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt16 (this.Handle, Selector.GetHandle ("setMaskCharacter:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt16 (this.SuperHandle, Selector.GetHandle ("setMaskCharacter:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CCCCardMaskFormat MaskFormat {
			[Export ("maskFormat", ArgumentSemantic.UnsafeUnretained)]
			get {
				CCCCardMaskFormat ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (CCCCardMaskFormat) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("maskFormat"));
					} else {
						ret = (CCCCardMaskFormat) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("maskFormat"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (CCCCardMaskFormat) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maskFormat"));
					} else {
						ret = (CCCCardMaskFormat) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maskFormat"));
					}
				}
				return ret;
			}
			
			[Export ("setMaskFormat:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setMaskFormat:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setMaskFormat:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setMaskFormat:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setMaskFormat:"), (int)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor NavigationBarColor {
			[Export ("navigationBarColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("navigationBarColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("navigationBarColor")));
				}
				return ret;
			}
			
			[Export ("setNavigationBarColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setNavigationBarColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setNavigationBarColor:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIBarStyle NavigationBarStyle {
			[Export ("navigationBarStyle", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIBarStyle ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIBarStyle) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("navigationBarStyle"));
					} else {
						ret = (global::UIKit.UIBarStyle) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("navigationBarStyle"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIBarStyle) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("navigationBarStyle"));
					} else {
						ret = (global::UIKit.UIBarStyle) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("navigationBarStyle"));
					}
				}
				return ret;
			}
			
			[Export ("setNavigationBarStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setNavigationBarStyle:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setNavigationBarStyle:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setNavigationBarStyle:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setNavigationBarStyle:"), (int)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool NavigationBarTranslucent {
			[Export ("navigationBarTranslucent")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("navigationBarTranslucent"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("navigationBarTranslucent"));
				}
			}
			
			[Export ("setNavigationBarTranslucent:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setNavigationBarTranslucent:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setNavigationBarTranslucent:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor NavigationButtonColor {
			[Export ("navigationButtonColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("navigationButtonColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("navigationButtonColor")));
				}
				return ret;
			}
			
			[Export ("setNavigationButtonColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setNavigationButtonColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setNavigationButtonColor:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIFont NavigationButtonFont {
			[Export ("navigationButtonFont", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("navigationButtonFont")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("navigationButtonFont")));
				}
				return ret;
			}
			
			[Export ("setNavigationButtonFont:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setNavigationButtonFont:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setNavigationButtonFont:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor NavigationTitleColor {
			[Export ("navigationTitleColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("navigationTitleColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("navigationTitleColor")));
				}
				return ret;
			}
			
			[Export ("setNavigationTitleColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setNavigationTitleColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setNavigationTitleColor:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIFont NavigationTitleFont {
			[Export ("navigationTitleFont", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("navigationTitleFont")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("navigationTitleFont")));
				}
				return ret;
			}
			
			[Export ("setNavigationTitleFont:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setNavigationTitleFont:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setNavigationTitleFont:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ushort SeparatorCharacter {
			[Export ("separatorCharacter")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.UInt16_objc_msgSend (this.Handle, Selector.GetHandle ("separatorCharacter"));
				} else {
					return global::ApiDefinition.Messaging.UInt16_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("separatorCharacter"));
				}
			}
			
			[Export ("setSeparatorCharacter:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt16 (this.Handle, Selector.GetHandle ("setSeparatorCharacter:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt16 (this.SuperHandle, Selector.GetHandle ("setSeparatorCharacter:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor SpinnerBackgroundColor {
			[Export ("spinnerBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("spinnerBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("spinnerBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setSpinnerBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSpinnerBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSpinnerBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIActivityIndicatorViewStyle SpinnerStyle {
			[Export ("spinnerStyle", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIActivityIndicatorViewStyle ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIActivityIndicatorViewStyle) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("spinnerStyle"));
					} else {
						ret = (global::UIKit.UIActivityIndicatorViewStyle) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("spinnerStyle"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIActivityIndicatorViewStyle) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("spinnerStyle"));
					} else {
						ret = (global::UIKit.UIActivityIndicatorViewStyle) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("spinnerStyle"));
					}
				}
				return ret;
			}
			
			[Export ("setSpinnerStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setSpinnerStyle:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setSpinnerStyle:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setSpinnerStyle:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setSpinnerStyle:"), (int)value);
					}
				}
			}
		}
		
	} /* class CCCTheme */
}
