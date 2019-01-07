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
	[Protocol (Name = "CCCPaymentControllerDelegate", WrapperType = typeof (CCCPaymentControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PaymentController", Selector = "paymentController:finishedWithAccount:", ParameterType = new Type [] { typeof (CardConnect.CCCPaymentController), typeof (CardConnect.CCCAccount) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCancelPaymentController", Selector = "didCancelPaymentController:", ParameterType = new Type [] { typeof (CardConnect.CCCPaymentController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PaymentController", Selector = "paymentController:finishedApplePayWithResult:", ParameterType = new Type [] { typeof (CardConnect.CCCPaymentController), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	public interface ICCCPaymentControllerDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("paymentController:finishedWithAccount:")]
		[Preserve (Conditional = true)]
		void PaymentController (CCCPaymentController controller, CCCAccount account);
		
	}
	
	public static partial class CCCPaymentControllerDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCancelPaymentController (this ICCCPaymentControllerDelegate This, CCCPaymentController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("didCancelPaymentController:"), controller.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PaymentController (this ICCCPaymentControllerDelegate This, CCCPaymentController controller, bool result)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("paymentController:finishedApplePayWithResult:"), controller.Handle, result);
		}
		
	}
	
	internal sealed class CCCPaymentControllerDelegateWrapper : BaseWrapper, ICCCPaymentControllerDelegate {
		[Preserve (Conditional = true)]
		public CCCPaymentControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("paymentController:finishedWithAccount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PaymentController (CCCPaymentController controller, CCCAccount account)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (account == null)
				throw new ArgumentNullException ("account");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("paymentController:finishedWithAccount:"), controller.Handle, account.Handle);
		}
		
	}
}
namespace CardConnect {
	[Protocol()]
	[Register("CCCPaymentControllerDelegate", false)]
	[Model]
	public unsafe abstract partial class CCCPaymentControllerDelegate : NSObject, ICCCPaymentControllerDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CCCPaymentControllerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CCCPaymentControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CCCPaymentControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("didCancelPaymentController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCancelPaymentController (CCCPaymentController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("paymentController:finishedWithAccount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void PaymentController (CCCPaymentController controller, CCCAccount account);
		[Export ("paymentController:finishedApplePayWithResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PaymentController (CCCPaymentController controller, bool result)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class CCCPaymentControllerDelegate */
}
