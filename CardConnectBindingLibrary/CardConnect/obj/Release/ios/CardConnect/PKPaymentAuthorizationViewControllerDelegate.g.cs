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
	[Protocol (Name = "PKPaymentAuthorizationViewControllerDelegate", WrapperType = typeof (PKPaymentAuthorizationViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PaymentAuthorizationViewControllerDidFinish", Selector = "paymentAuthorizationViewControllerDidFinish:", ParameterType = new Type [] { typeof (CardConnect.PKPaymentAuthorizationViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PaymentAuthorizationViewController", Selector = "paymentAuthorizationViewController:didAuthorizePayment:handler:", ParameterType = new Type [] { typeof (CardConnect.PKPaymentAuthorizationViewController), typeof (PassKit.PKPayment), typeof (global::System.Action<global::PassKit.PKPaymentAuthorizationResult>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V1) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PaymentAuthorizationViewControllerWillAuthorizePayment", Selector = "paymentAuthorizationViewControllerWillAuthorizePayment:", ParameterType = new Type [] { typeof (CardConnect.PKPaymentAuthorizationViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PaymentAuthorizationViewController", Selector = "paymentAuthorizationViewController:didSelectShippingMethod:handler:", ParameterType = new Type [] { typeof (CardConnect.PKPaymentAuthorizationViewController), typeof (PassKit.PKShippingMethod), typeof (global::System.Action<global::PassKit.PKPaymentRequestShippingMethodUpdate>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V3) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PaymentAuthorizationViewController", Selector = "paymentAuthorizationViewController:didSelectShippingContact:handler:", ParameterType = new Type [] { typeof (CardConnect.PKPaymentAuthorizationViewController), typeof (PassKit.PKContact), typeof (global::System.Action<global::PassKit.PKPaymentRequestShippingContactUpdate>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V4) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PaymentAuthorizationViewController", Selector = "paymentAuthorizationViewController:didSelectPaymentMethod:handler:", ParameterType = new Type [] { typeof (CardConnect.PKPaymentAuthorizationViewController), typeof (PassKit.PKPaymentMethod), typeof (global::System.Action<global::PassKit.PKPaymentRequestPaymentMethodUpdate>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V5) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PaymentAuthorizationViewController", Selector = "paymentAuthorizationViewController:didAuthorizePayment:completion:", ParameterType = new Type [] { typeof (CardConnect.PKPaymentAuthorizationViewController), typeof (PassKit.PKPayment), typeof (global::System.Action<global::PassKit.PKPaymentAuthorizationStatus>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V2) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PaymentAuthorizationViewController", Selector = "paymentAuthorizationViewController:didSelectShippingMethod:completion:", ParameterType = new Type [] { typeof (CardConnect.PKPaymentAuthorizationViewController), typeof (PassKit.PKShippingMethod), typeof (global::System.Action<global::PassKit.PKPaymentAuthorizationStatus, NSArray<global::PassKit.PKPaymentSummaryItem>>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V4) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PaymentAuthorizationViewController", Selector = "paymentAuthorizationViewController:didSelectShippingContact:completion:", ParameterType = new Type [] { typeof (CardConnect.PKPaymentAuthorizationViewController), typeof (PassKit.PKContact), typeof (global::System.Action<global::PassKit.PKPaymentAuthorizationStatus, NSArray<global::PassKit.PKShippingMethod>, NSArray<global::PassKit.PKPaymentSummaryItem>>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity3V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PaymentAuthorizationViewController", Selector = "paymentAuthorizationViewController:didSelectPaymentMethod:completion:", ParameterType = new Type [] { typeof (CardConnect.PKPaymentAuthorizationViewController), typeof (PassKit.PKPaymentMethod), typeof (global::System.Action<NSArray<global::PassKit.PKPaymentSummaryItem>>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V6) })]
	public interface IPKPaymentAuthorizationViewControllerDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("paymentAuthorizationViewControllerDidFinish:")]
		[Preserve (Conditional = true)]
		void PaymentAuthorizationViewControllerDidFinish (PKPaymentAuthorizationViewController controller);
		
	}
	
	public static partial class PKPaymentAuthorizationViewControllerDelegate_Extensions {
		[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PaymentAuthorizationViewController (this IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, global::PassKit.PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<global::PassKit.PKPaymentAuthorizationResult> completion)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (payment == null)
				throw new ArgumentNullException ("payment");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didAuthorizePayment:handler:"), controller.Handle, payment.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Introduced (PlatformName.WatchOS, 3,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 8,3, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PaymentAuthorizationViewControllerWillAuthorizePayment (this IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("paymentAuthorizationViewControllerWillAuthorizePayment:"), controller.Handle);
		}
		
		[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PaymentAuthorizationViewController (this IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, global::PassKit.PKShippingMethod shippingMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V3))]global::System.Action<global::PassKit.PKPaymentRequestShippingMethodUpdate> completion)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (shippingMethod == null)
				throw new ArgumentNullException ("shippingMethod");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V3.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didSelectShippingMethod:handler:"), controller.Handle, shippingMethod.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PaymentAuthorizationViewController (this IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, global::PassKit.PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V4))]global::System.Action<global::PassKit.PKPaymentRequestShippingContactUpdate> completion)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (contact == null)
				throw new ArgumentNullException ("contact");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V4.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didSelectShippingContact:handler:"), controller.Handle, contact.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PaymentAuthorizationViewController (this IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, global::PassKit.PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V5))]global::System.Action<global::PassKit.PKPaymentRequestPaymentMethodUpdate> completion)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (paymentMethod == null)
				throw new ArgumentNullException ("paymentMethod");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V5.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didSelectPaymentMethod:handler:"), controller.Handle, paymentMethod.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Introduced (PlatformName.iOS, 8,0, message: "Use paymentAuthorizationViewController:didAuthorizePayment:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use paymentAuthorizationViewController:didAuthorizePayment:handler: instead to provide more granular errors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PaymentAuthorizationViewController (this IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, global::PassKit.PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<global::PassKit.PKPaymentAuthorizationStatus> completion)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (payment == null)
				throw new ArgumentNullException ("payment");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V2.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didAuthorizePayment:completion:"), controller.Handle, payment.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Introduced (PlatformName.iOS, 8,0, message: "Use paymentAuthorizationViewController:didSelectShippingMethod:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use paymentAuthorizationViewController:didSelectShippingMethod:handler: instead to provide more granular errors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PaymentAuthorizationViewController (this IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, global::PassKit.PKShippingMethod shippingMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V4))]global::System.Action<global::PassKit.PKPaymentAuthorizationStatus, NSArray<global::PassKit.PKPaymentSummaryItem>> completion)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (shippingMethod == null)
				throw new ArgumentNullException ("shippingMethod");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity2V4.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didSelectShippingMethod:completion:"), controller.Handle, shippingMethod.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Introduced (PlatformName.iOS, 8,0, message: "Use paymentAuthorizationViewController:didSelectShippingContact:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use paymentAuthorizationViewController:didSelectShippingContact:handler: instead to provide more granular errors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PaymentAuthorizationViewController (this IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, global::PassKit.PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<global::PassKit.PKPaymentAuthorizationStatus, NSArray<global::PassKit.PKShippingMethod>, NSArray<global::PassKit.PKPaymentSummaryItem>> completion)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (contact == null)
				throw new ArgumentNullException ("contact");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity3V0.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didSelectShippingContact:completion:"), controller.Handle, contact.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Introduced (PlatformName.iOS, 8,0, message: "Use paymentAuthorizationViewController:didSelectPaymentMethod:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use paymentAuthorizationViewController:didSelectPaymentMethod:handler: instead to provide more granular errors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PaymentAuthorizationViewController (this IPKPaymentAuthorizationViewControllerDelegate This, PKPaymentAuthorizationViewController controller, global::PassKit.PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V6))]global::System.Action<NSArray<global::PassKit.PKPaymentSummaryItem>> completion)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (paymentMethod == null)
				throw new ArgumentNullException ("paymentMethod");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V6.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("paymentAuthorizationViewController:didSelectPaymentMethod:completion:"), controller.Handle, paymentMethod.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
	}
	
	internal sealed class PKPaymentAuthorizationViewControllerDelegateWrapper : BaseWrapper, IPKPaymentAuthorizationViewControllerDelegate {
		[Preserve (Conditional = true)]
		public PKPaymentAuthorizationViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("paymentAuthorizationViewControllerDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PaymentAuthorizationViewControllerDidFinish (PKPaymentAuthorizationViewController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("paymentAuthorizationViewControllerDidFinish:"), controller.Handle);
		}
		
	}
}
namespace CardConnect {
	[Protocol()]
	[Register("PKPaymentAuthorizationViewControllerDelegate", false)]
	[Model]
	public unsafe abstract partial class PKPaymentAuthorizationViewControllerDelegate : NSObject, IPKPaymentAuthorizationViewControllerDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PKPaymentAuthorizationViewControllerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PKPaymentAuthorizationViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PKPaymentAuthorizationViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("paymentAuthorizationViewController:didAuthorizePayment:handler:")]
		[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PaymentAuthorizationViewController (PKPaymentAuthorizationViewController controller, global::PassKit.PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<global::PassKit.PKPaymentAuthorizationResult> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("paymentAuthorizationViewController:didSelectShippingMethod:handler:")]
		[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PaymentAuthorizationViewController (PKPaymentAuthorizationViewController controller, global::PassKit.PKShippingMethod shippingMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V3))]global::System.Action<global::PassKit.PKPaymentRequestShippingMethodUpdate> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("paymentAuthorizationViewController:didSelectShippingContact:handler:")]
		[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PaymentAuthorizationViewController (PKPaymentAuthorizationViewController controller, global::PassKit.PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V4))]global::System.Action<global::PassKit.PKPaymentRequestShippingContactUpdate> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("paymentAuthorizationViewController:didSelectPaymentMethod:handler:")]
		[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PaymentAuthorizationViewController (PKPaymentAuthorizationViewController controller, global::PassKit.PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V5))]global::System.Action<global::PassKit.PKPaymentRequestPaymentMethodUpdate> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("paymentAuthorizationViewController:didAuthorizePayment:completion:")]
		[Introduced (PlatformName.iOS, 8,0, message: "Use paymentAuthorizationViewController:didAuthorizePayment:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use paymentAuthorizationViewController:didAuthorizePayment:handler: instead to provide more granular errors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PaymentAuthorizationViewController (PKPaymentAuthorizationViewController controller, global::PassKit.PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<global::PassKit.PKPaymentAuthorizationStatus> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("paymentAuthorizationViewController:didSelectShippingMethod:completion:")]
		[Introduced (PlatformName.iOS, 8,0, message: "Use paymentAuthorizationViewController:didSelectShippingMethod:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use paymentAuthorizationViewController:didSelectShippingMethod:handler: instead to provide more granular errors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PaymentAuthorizationViewController (PKPaymentAuthorizationViewController controller, global::PassKit.PKShippingMethod shippingMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V4))]global::System.Action<global::PassKit.PKPaymentAuthorizationStatus, NSArray<global::PassKit.PKPaymentSummaryItem>> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("paymentAuthorizationViewController:didSelectShippingContact:completion:")]
		[Introduced (PlatformName.iOS, 8,0, message: "Use paymentAuthorizationViewController:didSelectShippingContact:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use paymentAuthorizationViewController:didSelectShippingContact:handler: instead to provide more granular errors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PaymentAuthorizationViewController (PKPaymentAuthorizationViewController controller, global::PassKit.PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<global::PassKit.PKPaymentAuthorizationStatus, NSArray<global::PassKit.PKShippingMethod>, NSArray<global::PassKit.PKPaymentSummaryItem>> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("paymentAuthorizationViewController:didSelectPaymentMethod:completion:")]
		[Introduced (PlatformName.iOS, 8,0, message: "Use paymentAuthorizationViewController:didSelectPaymentMethod:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use paymentAuthorizationViewController:didSelectPaymentMethod:handler: instead to provide more granular errors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PaymentAuthorizationViewController (PKPaymentAuthorizationViewController controller, global::PassKit.PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V6))]global::System.Action<NSArray<global::PassKit.PKPaymentSummaryItem>> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("paymentAuthorizationViewControllerDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void PaymentAuthorizationViewControllerDidFinish (PKPaymentAuthorizationViewController controller);
		[Export ("paymentAuthorizationViewControllerWillAuthorizePayment:")]
		[Introduced (PlatformName.WatchOS, 3,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 8,3, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PaymentAuthorizationViewControllerWillAuthorizePayment (PKPaymentAuthorizationViewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PKPaymentAuthorizationViewControllerDelegate */
}
