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
	[Protocol (Name = "CCCSwiper", WrapperType = typeof (CCCSwiperWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "WeakDelegate", Selector = "delegate", PropertyType = typeof (NSObject), GetterSelector = "delegate", SetterSelector = "setDelegate:", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ConnectionState", Selector = "connectionState", PropertyType = typeof (CardConnectBinding.CCCSwiperConnectionState), GetterSelector = "connectionState", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "Model", Selector = "model", PropertyType = typeof (string), GetterSelector = "model", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DebugLoggingEnabled", Selector = "debugLoggingEnabled", PropertyType = typeof (bool), GetterSelector = "isDebugLoggingEnabled", SetterSelector = "setDebugLoggingEnabled:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ShouldShowAudioWarning", Selector = "shouldShowAudioWarning", PropertyType = typeof (bool), GetterSelector = "shouldShowAudioWarning", ArgumentSemantic = ArgumentSemantic.None)]
	public interface ICCCSwiper : INativeObject, IDisposable
	{
	}
	
	public static partial class CCCSwiper_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject GetWeakDelegate (this ICCCSwiper This)
		{
			return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("delegate")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetWeakDelegate (this ICCCSwiper This, NSObject value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDelegate:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CCCSwiperConnectionState GetConnectionState (this ICCCSwiper This)
		{
			CCCSwiperConnectionState ret;
			if (IntPtr.Size == 8) {
				ret = (CCCSwiperConnectionState) global::ApiDefinition.Messaging.Int64_objc_msgSend (This.Handle, Selector.GetHandle ("connectionState"));
			} else {
				ret = (CCCSwiperConnectionState) global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("connectionState"));
			}
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetDebugLoggingEnabled (this ICCCSwiper This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("debugLoggingEnabled"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDebugLoggingEnabled (this ICCCSwiper This, bool value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setDebugLoggingEnabled:"), value);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetShouldShowAudioWarning (this ICCCSwiper This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("shouldShowAudioWarning"));
		}
		
	}
	
	internal sealed class CCCSwiperWrapper : BaseWrapper, ICCCSwiper {
		[Preserve (Conditional = true)]
		public CCCSwiperWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CardConnectBinding {
	[Protocol()]
	[Register("CCCSwiper", true)]
	public unsafe partial class CCCSwiper : NSObject, ICCCSwiper {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CCCSwiper");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CCCSwiper () : base (NSObjectFlag.Empty)
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
		protected CCCSwiper (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CCCSwiper (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CCCSwiper (CCCSwiperDelegate @delegate)
			: base (NSObjectFlag.Empty)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithDelegate:"), @delegate.Handle), "initWithDelegate:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDelegate:"), @delegate.Handle), "initWithDelegate:");
			}
		}
		
		[Export ("initWithDelegate:loggingEnabled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CCCSwiper (CCCSwiperDelegate @delegate, bool enabled)
			: base (NSObjectFlag.Empty)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("initWithDelegate:loggingEnabled:"), @delegate.Handle, enabled), "initWithDelegate:loggingEnabled:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("initWithDelegate:loggingEnabled:"), @delegate.Handle, enabled), "initWithDelegate:loggingEnabled:");
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CCCSwiperConnectionState ConnectionState {
			[Export ("connectionState", ArgumentSemantic.UnsafeUnretained)]
			get {
				CCCSwiperConnectionState ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (CCCSwiperConnectionState) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("connectionState"));
					} else {
						ret = (CCCSwiperConnectionState) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("connectionState"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (CCCSwiperConnectionState) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("connectionState"));
					} else {
						ret = (CCCSwiperConnectionState) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("connectionState"));
					}
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DebugLoggingEnabled {
			[Export ("isDebugLoggingEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDebugLoggingEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isDebugLoggingEnabled"));
				}
			}
			
			[Export ("setDebugLoggingEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDebugLoggingEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDebugLoggingEnabled:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CCCSwiperDelegate Delegate {
			get {
				return WeakDelegate as CCCSwiperDelegate;
			}
			set {
				var rvalue = value as NSObject;
				if (value != null && rvalue == null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string Model {
			[Export ("model")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("model")));
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowAudioWarning {
			[Export ("shouldShowAudioWarning")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldShowAudioWarning"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldShowAudioWarning"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class CCCSwiper */
}
