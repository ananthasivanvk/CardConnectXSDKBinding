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

namespace CardConnect {
	[Protocol (Name = "CCCCVVFormatterDelegate", WrapperType = typeof (CCCCVVFormatterDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsValidCVVForCardNumber", Selector = "isValidCVVForCardNumber:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetCVVOnCardInfo", Selector = "setCVVOnCardInfo:", ParameterType = new Type [] { typeof (CardConnect.CCCCardInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MaskCharacter", Selector = "maskCharacter", PropertyType = typeof (UInt16), GetterSelector = "maskCharacter", SetterSelector = "setMaskCharacter:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "IsValidCVV", Selector = "isValidCVV", PropertyType = typeof (bool), GetterSelector = "isValidCVV", ArgumentSemantic = ArgumentSemantic.None)]
	public interface ICCCCVVFormatterDelegate : INativeObject, IDisposable, 
		CardConnect.ICCCTextFieldDelegateProxy
		
	{
	}
	
	public static partial class CCCCVVFormatterDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsValidCVVForCardNumber (this ICCCCVVFormatterDelegate This, string cardNumber)
		{
			if (cardNumber == null)
				throw new ArgumentNullException ("cardNumber");
			var nscardNumber = NSString.CreateNative (cardNumber);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("isValidCVVForCardNumber:"), nscardNumber);
			NSString.ReleaseNative (nscardNumber);
			
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCVVOnCardInfo (this ICCCCVVFormatterDelegate This, CCCCardInfo cardInfo)
		{
			if (cardInfo == null)
				throw new ArgumentNullException ("cardInfo");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setCVVOnCardInfo:"), cardInfo.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ushort GetMaskCharacter (this ICCCCVVFormatterDelegate This)
		{
			return global::ApiDefinition.Messaging.UInt16_objc_msgSend (This.Handle, Selector.GetHandle ("maskCharacter"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMaskCharacter (this ICCCCVVFormatterDelegate This, ushort value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UInt16 (This.Handle, Selector.GetHandle ("setMaskCharacter:"), value);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetIsValidCVV (this ICCCCVVFormatterDelegate This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isValidCVV"));
		}
		
	}
	
	internal sealed class CCCCVVFormatterDelegateWrapper : BaseWrapper, ICCCCVVFormatterDelegate {
		[Preserve (Conditional = true)]
		public CCCCVVFormatterDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CardConnect {
	[Protocol()]
	[Register("CCCCVVFormatterDelegate", true)]
	public unsafe partial class CCCCVVFormatterDelegate : CCCTextFieldDelegateProxy, ICCCCVVFormatterDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CCCCVVFormatterDelegate");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CCCCVVFormatterDelegate () : base (NSObjectFlag.Empty)
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
		protected CCCCVVFormatterDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CCCCVVFormatterDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("isValidCVVForCardNumber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsValidCVVForCardNumber (string cardNumber)
		{
			if (cardNumber == null)
				throw new ArgumentNullException ("cardNumber");
			var nscardNumber = NSString.CreateNative (cardNumber);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isValidCVVForCardNumber:"), nscardNumber);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isValidCVVForCardNumber:"), nscardNumber);
			}
			NSString.ReleaseNative (nscardNumber);
			
			return ret;
		}
		
		[Export ("setCVVOnCardInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCVVOnCardInfo (CCCCardInfo cardInfo)
		{
			if (cardInfo == null)
				throw new ArgumentNullException ("cardInfo");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCVVOnCardInfo:"), cardInfo.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCVVOnCardInfo:"), cardInfo.Handle);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsValidCVV {
			[Export ("isValidCVV")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isValidCVV"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isValidCVV"));
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
		
	} /* class CCCCVVFormatterDelegate */
}
