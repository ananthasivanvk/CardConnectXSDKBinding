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
	[Protocol (Name = "CCCCardFormatterDelegate", WrapperType = typeof (CCCCardFormatterDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetCardNumberOnCardInfo", Selector = "setCardNumberOnCardInfo:", ParameterType = new Type [] { typeof (CardConnectBinding.CCCCardInfo) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MaskFormat", Selector = "maskFormat", PropertyType = typeof (CardConnectBinding.CCCCardMaskFormat), GetterSelector = "maskFormat", SetterSelector = "setMaskFormat:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MaskCharacter", Selector = "maskCharacter", PropertyType = typeof (UInt16), GetterSelector = "maskCharacter", SetterSelector = "setMaskCharacter:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MaskSpacing", Selector = "maskSpacing", PropertyType = typeof (CardConnectBinding.CCCCardMaskSpacing), GetterSelector = "maskSpacing", SetterSelector = "setMaskSpacing:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ValidCard", Selector = "validCard", PropertyType = typeof (bool), GetterSelector = "isValidCard", SetterSelector = "setValidCard:", ArgumentSemantic = ArgumentSemantic.None)]
	public interface ICCCCardFormatterDelegate : INativeObject, IDisposable, 
		CardConnectBinding.ICCCTextFieldDelegateProxy
		
	{
	}
	
	public static partial class CCCCardFormatterDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCardNumberOnCardInfo (this ICCCCardFormatterDelegate This, CCCCardInfo cardInfo)
		{
			if (cardInfo == null)
				throw new ArgumentNullException ("cardInfo");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setCardNumberOnCardInfo:"), cardInfo.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CCCCardMaskFormat GetMaskFormat (this ICCCCardFormatterDelegate This)
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
		public static void SetMaskFormat (this ICCCCardFormatterDelegate This, CCCCardMaskFormat value)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (This.Handle, Selector.GetHandle ("setMaskFormat:"), (Int64)value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setMaskFormat:"), (int)value);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ushort GetMaskCharacter (this ICCCCardFormatterDelegate This)
		{
			return global::ApiDefinition.Messaging.UInt16_objc_msgSend (This.Handle, Selector.GetHandle ("maskCharacter"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMaskCharacter (this ICCCCardFormatterDelegate This, ushort value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UInt16 (This.Handle, Selector.GetHandle ("setMaskCharacter:"), value);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CCCCardMaskSpacing GetMaskSpacing (this ICCCCardFormatterDelegate This)
		{
			CCCCardMaskSpacing ret;
			if (IntPtr.Size == 8) {
				ret = (CCCCardMaskSpacing) global::ApiDefinition.Messaging.Int64_objc_msgSend (This.Handle, Selector.GetHandle ("maskSpacing"));
			} else {
				ret = (CCCCardMaskSpacing) global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("maskSpacing"));
			}
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMaskSpacing (this ICCCCardFormatterDelegate This, CCCCardMaskSpacing value)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (This.Handle, Selector.GetHandle ("setMaskSpacing:"), (Int64)value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setMaskSpacing:"), (int)value);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetValidCard (this ICCCCardFormatterDelegate This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("validCard"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetValidCard (this ICCCCardFormatterDelegate This, bool value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setValidCard:"), value);
		}
		
	}
	
	internal sealed class CCCCardFormatterDelegateWrapper : BaseWrapper, ICCCCardFormatterDelegate {
		[Preserve (Conditional = true)]
		public CCCCardFormatterDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CardConnectBinding {
	[Protocol()]
	[Register("CCCCardFormatterDelegate", true)]
	public unsafe partial class CCCCardFormatterDelegate : CCCTextFieldDelegateProxy, ICCCCardFormatterDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CCCCardFormatterDelegate");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CCCCardFormatterDelegate () : base (NSObjectFlag.Empty)
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
		protected CCCCardFormatterDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CCCCardFormatterDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setCardNumberOnCardInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCardNumberOnCardInfo (CCCCardInfo cardInfo)
		{
			if (cardInfo == null)
				throw new ArgumentNullException ("cardInfo");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCardNumberOnCardInfo:"), cardInfo.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCardNumberOnCardInfo:"), cardInfo.Handle);
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
		public virtual CCCCardMaskSpacing MaskSpacing {
			[Export ("maskSpacing", ArgumentSemantic.UnsafeUnretained)]
			get {
				CCCCardMaskSpacing ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (CCCCardMaskSpacing) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("maskSpacing"));
					} else {
						ret = (CCCCardMaskSpacing) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("maskSpacing"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (CCCCardMaskSpacing) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maskSpacing"));
					} else {
						ret = (CCCCardMaskSpacing) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maskSpacing"));
					}
				}
				return ret;
			}
			
			[Export ("setMaskSpacing:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setMaskSpacing:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setMaskSpacing:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setMaskSpacing:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setMaskSpacing:"), (int)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ValidCard {
			[Export ("isValidCard")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isValidCard"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isValidCard"));
				}
			}
			
			[Export ("setValidCard:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setValidCard:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setValidCard:"), value);
				}
			}
		}
		
	} /* class CCCCardFormatterDelegate */
}
