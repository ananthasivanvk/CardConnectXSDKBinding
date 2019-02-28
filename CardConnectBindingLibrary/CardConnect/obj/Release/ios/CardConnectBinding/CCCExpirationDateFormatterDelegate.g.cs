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
	[Protocol (Name = "CCCExpirationDateFormatterDelegate", WrapperType = typeof (CCCExpirationDateFormatterDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetExpirationDateOnCardInfo", Selector = "setExpirationDateOnCardInfo:", ParameterType = new Type [] { typeof (CardConnectBinding.CCCCardInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SeparatorCharacter", Selector = "separatorCharacter", PropertyType = typeof (UInt16), GetterSelector = "separatorCharacter", SetterSelector = "setSeparatorCharacter:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "InputCount", Selector = "inputCount", PropertyType = typeof (CardConnectBinding.CCCExpirationDateInput), GetterSelector = "inputCount", SetterSelector = "setInputCount:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ValidExpirationDate", Selector = "validExpirationDate", PropertyType = typeof (bool), GetterSelector = "isValidExpirationDate", SetterSelector = "setValidExpirationDate:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ExpirationDate", Selector = "expirationDate", PropertyType = typeof (NSDate), GetterSelector = "expirationDate", ArgumentSemantic = ArgumentSemantic.None)]
	public interface ICCCExpirationDateFormatterDelegate : INativeObject, IDisposable, 
		CardConnectBinding.ICCCTextFieldDelegateProxy
		
	{
	}
	
	public static partial class CCCExpirationDateFormatterDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetExpirationDateOnCardInfo (this ICCCExpirationDateFormatterDelegate This, CCCCardInfo cardInfo)
		{
			if (cardInfo == null)
				throw new ArgumentNullException ("cardInfo");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setExpirationDateOnCardInfo:"), cardInfo.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ushort GetSeparatorCharacter (this ICCCExpirationDateFormatterDelegate This)
		{
			return global::ApiDefinition.Messaging.UInt16_objc_msgSend (This.Handle, Selector.GetHandle ("separatorCharacter"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSeparatorCharacter (this ICCCExpirationDateFormatterDelegate This, ushort value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UInt16 (This.Handle, Selector.GetHandle ("setSeparatorCharacter:"), value);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CCCExpirationDateInput GetInputCount (this ICCCExpirationDateFormatterDelegate This)
		{
			CCCExpirationDateInput ret;
			if (IntPtr.Size == 8) {
				ret = (CCCExpirationDateInput) global::ApiDefinition.Messaging.Int64_objc_msgSend (This.Handle, Selector.GetHandle ("inputCount"));
			} else {
				ret = (CCCExpirationDateInput) global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("inputCount"));
			}
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetInputCount (this ICCCExpirationDateFormatterDelegate This, CCCExpirationDateInput value)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (This.Handle, Selector.GetHandle ("setInputCount:"), (Int64)value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setInputCount:"), (int)value);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetValidExpirationDate (this ICCCExpirationDateFormatterDelegate This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("validExpirationDate"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetValidExpirationDate (this ICCCExpirationDateFormatterDelegate This, bool value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setValidExpirationDate:"), value);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDate GetExpirationDate (this ICCCExpirationDateFormatterDelegate This)
		{
			return  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("expirationDate")));
		}
		
	}
	
	internal sealed class CCCExpirationDateFormatterDelegateWrapper : BaseWrapper, ICCCExpirationDateFormatterDelegate {
		[Preserve (Conditional = true)]
		public CCCExpirationDateFormatterDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CardConnectBinding {
	[Protocol()]
	[Register("CCCExpirationDateFormatterDelegate", true)]
	public unsafe partial class CCCExpirationDateFormatterDelegate : CCCTextFieldDelegateProxy, ICCCExpirationDateFormatterDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CCCExpirationDateFormatterDelegate");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CCCExpirationDateFormatterDelegate () : base (NSObjectFlag.Empty)
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
		protected CCCExpirationDateFormatterDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CCCExpirationDateFormatterDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CCCExpirationDateFormatterDelegate (NSDate date)
			: base (NSObjectFlag.Empty)
		{
			if (date == null)
				throw new ArgumentNullException ("date");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithDate:"), date.Handle), "initWithDate:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDate:"), date.Handle), "initWithDate:");
			}
		}
		
		[Export ("setExpirationDateOnCardInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetExpirationDateOnCardInfo (CCCCardInfo cardInfo)
		{
			if (cardInfo == null)
				throw new ArgumentNullException ("cardInfo");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setExpirationDateOnCardInfo:"), cardInfo.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setExpirationDateOnCardInfo:"), cardInfo.Handle);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate ExpirationDate {
			[Export ("expirationDate")]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("expirationDate")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("expirationDate")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CCCExpirationDateInput InputCount {
			[Export ("inputCount", ArgumentSemantic.UnsafeUnretained)]
			get {
				CCCExpirationDateInput ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (CCCExpirationDateInput) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("inputCount"));
					} else {
						ret = (CCCExpirationDateInput) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("inputCount"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (CCCExpirationDateInput) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("inputCount"));
					} else {
						ret = (CCCExpirationDateInput) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("inputCount"));
					}
				}
				return ret;
			}
			
			[Export ("setInputCount:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setInputCount:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setInputCount:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setInputCount:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setInputCount:"), (int)value);
					}
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
		public virtual bool ValidExpirationDate {
			[Export ("isValidExpirationDate")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isValidExpirationDate"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isValidExpirationDate"));
				}
			}
			
			[Export ("setValidExpirationDate:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setValidExpirationDate:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setValidExpirationDate:"), value);
				}
			}
		}
		
	} /* class CCCExpirationDateFormatterDelegate */
}
