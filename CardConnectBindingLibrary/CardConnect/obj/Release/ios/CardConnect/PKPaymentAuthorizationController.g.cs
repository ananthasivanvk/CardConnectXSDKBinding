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
	[Introduced (PlatformName.WatchOS, 3,0, PlatformArchitecture.All)]
	[Introduced (PlatformName.iOS, 10,0, PlatformArchitecture.All)]
	[Protocol (Name = "PKPaymentAuthorizationController", WrapperType = typeof (PKPaymentAuthorizationControllerWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "CanMakePaymentsUsingNetworks", Selector = "canMakePaymentsUsingNetworks:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (String[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "CanMakePaymentsUsingNetworks", Selector = "canMakePaymentsUsingNetworks:capabilities:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (String[]), typeof (PassKit.PKMerchantCapability) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentWithCompletion", Selector = "presentWithCompletion:", ParameterType = new Type [] { typeof (global::System.Action<bool>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DismissWithCompletion", Selector = "dismissWithCompletion:", ParameterType = new Type [] { typeof (Action) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type [] { typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "CanMakePayments", Selector = "canMakePayments", PropertyType = typeof (bool), GetterSelector = "canMakePayments", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "WeakDelegate", Selector = "delegate", PropertyType = typeof (NSObject), GetterSelector = "delegate", SetterSelector = "setDelegate:", ArgumentSemantic = ArgumentSemantic.Weak)]
	public interface IPKPaymentAuthorizationController : INativeObject, IDisposable
	{
	}
	
	public static partial class PKPaymentAuthorizationController_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PresentWithCompletion (this IPKPaymentAuthorizationController This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion)
		{
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V0.Handler, completion);
			}
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("presentWithCompletion:"), (IntPtr) block_ptr_completion);
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DismissWithCompletion (this IPKPaymentAuthorizationController This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDAction.Handler, completion);
			}
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("dismissWithCompletion:"), (IntPtr) block_ptr_completion);
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject GetWeakDelegate (this IPKPaymentAuthorizationController This)
		{
			return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("delegate")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetWeakDelegate (this IPKPaymentAuthorizationController This, NSObject value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDelegate:"), value.Handle);
		}
		
	}
	
	internal sealed class PKPaymentAuthorizationControllerWrapper : BaseWrapper, IPKPaymentAuthorizationController {
		[Preserve (Conditional = true)]
		public PKPaymentAuthorizationControllerWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CardConnect {
	[Protocol()]
	[Register("PKPaymentAuthorizationController", true)]
	[Introduced (PlatformName.WatchOS, 3,0, PlatformArchitecture.All)]
	[Introduced (PlatformName.iOS, 10,0, PlatformArchitecture.All)]
	public unsafe partial class PKPaymentAuthorizationController : NSObject, IPKPaymentAuthorizationController {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("PKPaymentAuthorizationController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PKPaymentAuthorizationController () : base (NSObjectFlag.Empty)
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
		protected PKPaymentAuthorizationController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PKPaymentAuthorizationController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPaymentRequest:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PKPaymentAuthorizationController (global::PassKit.PKPaymentRequest request)
			: base (NSObjectFlag.Empty)
		{
			if (request == null)
				throw new ArgumentNullException ("request");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithPaymentRequest:"), request.Handle), "initWithPaymentRequest:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithPaymentRequest:"), request.Handle), "initWithPaymentRequest:");
			}
		}
		
		[Export ("canMakePaymentsUsingNetworks:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanMakePaymentsUsingNetworks (string[] supportedNetworks)
		{
			if (supportedNetworks == null)
				throw new ArgumentNullException ("supportedNetworks");
			var nsa_supportedNetworks = NSArray.FromStrings (supportedNetworks);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("canMakePaymentsUsingNetworks:"), nsa_supportedNetworks.Handle);
			nsa_supportedNetworks.Dispose ();
			
			return ret;
		}
		
		[Export ("canMakePaymentsUsingNetworks:capabilities:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanMakePaymentsUsingNetworks (string[] supportedNetworks, global::PassKit.PKMerchantCapability capabilties)
		{
			if (supportedNetworks == null)
				throw new ArgumentNullException ("supportedNetworks");
			var nsa_supportedNetworks = NSArray.FromStrings (supportedNetworks);
			
			bool ret;
			if (IntPtr.Size == 8) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_UInt64 (class_ptr, Selector.GetHandle ("canMakePaymentsUsingNetworks:capabilities:"), nsa_supportedNetworks.Handle, (UInt64)capabilties);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_UInt32 (class_ptr, Selector.GetHandle ("canMakePaymentsUsingNetworks:capabilities:"), nsa_supportedNetworks.Handle, (UInt32)capabilties);
			}
			nsa_supportedNetworks.Dispose ();
			
			return ret;
		}
		
		[Export ("dismissWithCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DismissWithCompletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDAction.Handler, completion);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("dismissWithCompletion:"), (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("dismissWithCompletion:"), (IntPtr) block_ptr_completion);
			}
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("presentWithCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PresentWithCompletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion)
		{
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V0.Handler, completion);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("presentWithCompletion:"), (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("presentWithCompletion:"), (IntPtr) block_ptr_completion);
			}
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanMakePayments {
			[Export ("canMakePayments")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("canMakePayments"));
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PKPaymentAuthorizationControllerDelegate Delegate {
			get {
				return WeakDelegate as PKPaymentAuthorizationControllerDelegate;
			}
			set {
				var rvalue = value as NSObject;
				if (value != null && rvalue == null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
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
	} /* class PKPaymentAuthorizationController */
}
