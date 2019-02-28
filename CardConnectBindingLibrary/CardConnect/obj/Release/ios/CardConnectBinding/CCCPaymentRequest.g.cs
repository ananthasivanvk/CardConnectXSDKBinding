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
	[Protocol (Name = "CCCPaymentRequest", WrapperType = typeof (CCCPaymentRequestWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ApplePayMerchantID", Selector = "applePayMerchantID", PropertyType = typeof (string), GetterSelector = "applePayMerchantID", SetterSelector = "setApplePayMerchantID:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Total", Selector = "total", PropertyType = typeof (NSDecimalNumber), GetterSelector = "total", SetterSelector = "setTotal:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AdditionalData", Selector = "additionalData", PropertyType = typeof (NSData), GetterSelector = "additionalData", SetterSelector = "setAdditionalData:", ArgumentSemantic = ArgumentSemantic.Copy)]
	public interface ICCCPaymentRequest : INativeObject, IDisposable
	{
	}
	
	public static partial class CCCPaymentRequest_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetApplePayMerchantID (this ICCCPaymentRequest This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("applePayMerchantID")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetApplePayMerchantID (this ICCCPaymentRequest This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setApplePayMerchantID:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDecimalNumber GetTotal (this ICCCPaymentRequest This)
		{
			return  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("total")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetTotal (this ICCCPaymentRequest This, NSDecimalNumber value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setTotal:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData GetAdditionalData (this ICCCPaymentRequest This)
		{
			return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("additionalData")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAdditionalData (this ICCCPaymentRequest This, NSData value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAdditionalData:"), value.Handle);
		}
		
	}
	
	internal sealed class CCCPaymentRequestWrapper : BaseWrapper, ICCCPaymentRequest {
		[Preserve (Conditional = true)]
		public CCCPaymentRequestWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CardConnectBinding {
	[Protocol()]
	[Register("CCCPaymentRequest", true)]
	public unsafe partial class CCCPaymentRequest : NSObject, ICCCPaymentRequest {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CCCPaymentRequest");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CCCPaymentRequest () : base (NSObjectFlag.Empty)
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
		protected CCCPaymentRequest (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CCCPaymentRequest (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData AdditionalData {
			[Export ("additionalData", ArgumentSemantic.Copy)]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("additionalData")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("additionalData")));
				}
				return ret;
			}
			
			[Export ("setAdditionalData:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAdditionalData:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAdditionalData:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ApplePayMerchantID {
			[Export ("applePayMerchantID")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("applePayMerchantID")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("applePayMerchantID")));
				}
			}
			
			[Export ("setApplePayMerchantID:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setApplePayMerchantID:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setApplePayMerchantID:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDecimalNumber Total {
			[Export ("total", ArgumentSemantic.Copy)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("total")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("total")));
				}
				return ret;
			}
			
			[Export ("setTotal:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTotal:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTotal:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
	} /* class CCCPaymentRequest */
}
