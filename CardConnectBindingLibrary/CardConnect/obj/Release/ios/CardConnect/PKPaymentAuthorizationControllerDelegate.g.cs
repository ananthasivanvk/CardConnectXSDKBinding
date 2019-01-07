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
	[Protocol (Name = "PKPaymentAuthorizationControllerDelegate", WrapperType = typeof (PKPaymentAuthorizationControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PaymentAuthorizationControllerDidFinish", Selector = "paymentAuthorizationControllerDidFinish:", ParameterType = new Type [] { typeof (CardConnect.PKPaymentAuthorizationController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PaymentAuthorizationController", Selector = "paymentAuthorizationController:didAuthorizePayment:handler:", ParameterType = new Type [] { typeof (CardConnect.PKPaymentAuthorizationController), typeof (PassKit.PKPayment), typeof (global::System.Action<global::PassKit.PKPaymentAuthorizationResult>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V1) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PaymentAuthorizationController", Selector = "paymentAuthorizationController:didAuthorizePayment:completion:", ParameterType = new Type [] { typeof (CardConnect.PKPaymentAuthorizationController), typeof (PassKit.PKPayment), typeof (global::System.Action<global::PassKit.PKPaymentAuthorizationStatus>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V2) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PaymentAuthorizationControllerWillAuthorizePayment", Selector = "paymentAuthorizationControllerWillAuthorizePayment:", ParameterType = new Type [] { typeof (CardConnect.PKPaymentAuthorizationController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PaymentAuthorizationController", Selector = "paymentAuthorizationController:didSelectShippingMethod:handler:", ParameterType = new Type [] { typeof (CardConnect.PKPaymentAuthorizationController), typeof (PassKit.PKShippingMethod), typeof (global::System.Action<global::PassKit.PKPaymentRequestShippingMethodUpdate>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V3) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PaymentAuthorizationController", Selector = "paymentAuthorizationController:didSelectShippingContact:handler:", ParameterType = new Type [] { typeof (CardConnect.PKPaymentAuthorizationController), typeof (PassKit.PKContact), typeof (global::System.Action<global::PassKit.PKPaymentRequestShippingContactUpdate>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V4) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PaymentAuthorizationController", Selector = "paymentAuthorizationController:didSelectPaymentMethod:handler:", ParameterType = new Type [] { typeof (CardConnect.PKPaymentAuthorizationController), typeof (PassKit.PKPaymentMethod), typeof (global::System.Action<global::PassKit.PKPaymentRequestPaymentMethodUpdate>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V5) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PaymentAuthorizationController", Selector = "paymentAuthorizationController:didSelectShippingMethod:completion:", ParameterType = new Type [] { typeof (CardConnect.PKPaymentAuthorizationController), typeof (PassKit.PKShippingMethod), typeof (global::System.Action<global::PassKit.PKPaymentAuthorizationStatus, NSArray<global::PassKit.PKPaymentSummaryItem>>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V4) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PaymentAuthorizationController", Selector = "paymentAuthorizationController:didSelectShippingContact:completion:", ParameterType = new Type [] { typeof (CardConnect.PKPaymentAuthorizationController), typeof (PassKit.PKContact), typeof (global::System.Action<global::PassKit.PKPaymentAuthorizationStatus, NSArray<global::PassKit.PKShippingMethod>, NSArray<global::PassKit.PKPaymentSummaryItem>>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity3V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PaymentAuthorizationController", Selector = "paymentAuthorizationController:didSelectPaymentMethod:completion:", ParameterType = new Type [] { typeof (CardConnect.PKPaymentAuthorizationController), typeof (PassKit.PKPaymentMethod), typeof (global::System.Action<NSArray<global::PassKit.PKPaymentSummaryItem>>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V6) })]
	public interface IPKPaymentAuthorizationControllerDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("paymentAuthorizationControllerDidFinish:")]
		[Preserve (Conditional = true)]
		void PaymentAuthorizationControllerDidFinish (PKPaymentAuthorizationController controller);
		
	}
	
	public static partial class PKPaymentAuthorizationControllerDelegate_Extensions {
		[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PaymentAuthorizationController (this IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, global::PassKit.PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<global::PassKit.PKPaymentAuthorizationResult> completion)
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
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didAuthorizePayment:handler:"), controller.Handle, payment.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Introduced (PlatformName.WatchOS, 3,0, message: "Use paymentAuthorizationController:didAuthorizePayment:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.WatchOS, 4,0, message: "Use paymentAuthorizationController:didAuthorizePayment:handler: instead to provide more granular errors")]
		[Introduced (PlatformName.iOS, 10,0, message: "Use paymentAuthorizationController:didAuthorizePayment:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use paymentAuthorizationController:didAuthorizePayment:handler: instead to provide more granular errors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PaymentAuthorizationController (this IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, global::PassKit.PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<global::PassKit.PKPaymentAuthorizationStatus> completion)
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
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didAuthorizePayment:completion:"), controller.Handle, payment.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PaymentAuthorizationControllerWillAuthorizePayment (this IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("paymentAuthorizationControllerWillAuthorizePayment:"), controller.Handle);
		}
		
		[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PaymentAuthorizationController (this IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, global::PassKit.PKShippingMethod shippingMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V3))]global::System.Action<global::PassKit.PKPaymentRequestShippingMethodUpdate> completion)
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
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didSelectShippingMethod:handler:"), controller.Handle, shippingMethod.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PaymentAuthorizationController (this IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, global::PassKit.PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V4))]global::System.Action<global::PassKit.PKPaymentRequestShippingContactUpdate> completion)
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
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didSelectShippingContact:handler:"), controller.Handle, contact.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PaymentAuthorizationController (this IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, global::PassKit.PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V5))]global::System.Action<global::PassKit.PKPaymentRequestPaymentMethodUpdate> completion)
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
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didSelectPaymentMethod:handler:"), controller.Handle, paymentMethod.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Introduced (PlatformName.WatchOS, 3,0, message: "Use paymentAuthorizationController:didSelectShippingMethod:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.WatchOS, 4,0, message: "Use paymentAuthorizationController:didSelectShippingMethod:handler: instead to provide more granular errors")]
		[Introduced (PlatformName.iOS, 10,0, message: "Use paymentAuthorizationController:didSelectShippingMethod:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use paymentAuthorizationController:didSelectShippingMethod:handler: instead to provide more granular errors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PaymentAuthorizationController (this IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, global::PassKit.PKShippingMethod shippingMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V4))]global::System.Action<global::PassKit.PKPaymentAuthorizationStatus, NSArray<global::PassKit.PKPaymentSummaryItem>> completion)
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
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didSelectShippingMethod:completion:"), controller.Handle, shippingMethod.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Introduced (PlatformName.WatchOS, 3,0, message: "Use paymentAuthorizationController:didSelectShippingContact:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.WatchOS, 4,0, message: "Use paymentAuthorizationController:didSelectShippingContact:handler: instead to provide more granular errors")]
		[Introduced (PlatformName.iOS, 10,0, message: "Use paymentAuthorizationController:didSelectShippingContact:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use paymentAuthorizationController:didSelectShippingContact:handler: instead to provide more granular errors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PaymentAuthorizationController (this IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, global::PassKit.PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<global::PassKit.PKPaymentAuthorizationStatus, NSArray<global::PassKit.PKShippingMethod>, NSArray<global::PassKit.PKPaymentSummaryItem>> completion)
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
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didSelectShippingContact:completion:"), controller.Handle, contact.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Introduced (PlatformName.WatchOS, 3,0, message: "Use paymentAuthorizationController:didSelectPaymentMethod:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.WatchOS, 4,0, message: "Use paymentAuthorizationController:didSelectPaymentMethod:handler: instead to provide more granular errors")]
		[Introduced (PlatformName.iOS, 10,0, message: "Use paymentAuthorizationController:didSelectPaymentMethod:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use paymentAuthorizationController:didSelectPaymentMethod:handler: instead to provide more granular errors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PaymentAuthorizationController (this IPKPaymentAuthorizationControllerDelegate This, PKPaymentAuthorizationController controller, global::PassKit.PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V6))]global::System.Action<NSArray<global::PassKit.PKPaymentSummaryItem>> completion)
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
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("paymentAuthorizationController:didSelectPaymentMethod:completion:"), controller.Handle, paymentMethod.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
	}
	
	internal sealed class PKPaymentAuthorizationControllerDelegateWrapper : BaseWrapper, IPKPaymentAuthorizationControllerDelegate {
		[Preserve (Conditional = true)]
		public PKPaymentAuthorizationControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("paymentAuthorizationControllerDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PaymentAuthorizationControllerDidFinish (PKPaymentAuthorizationController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("paymentAuthorizationControllerDidFinish:"), controller.Handle);
		}
		
	}
}
namespace CardConnect {
	[Protocol()]
	[Register("PKPaymentAuthorizationControllerDelegate", false)]
	[Model]
	public unsafe abstract partial class PKPaymentAuthorizationControllerDelegate : NSObject, IPKPaymentAuthorizationControllerDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PKPaymentAuthorizationControllerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PKPaymentAuthorizationControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PKPaymentAuthorizationControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("paymentAuthorizationController:didAuthorizePayment:handler:")]
		[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PaymentAuthorizationController (PKPaymentAuthorizationController controller, global::PassKit.PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<global::PassKit.PKPaymentAuthorizationResult> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("paymentAuthorizationController:didAuthorizePayment:completion:")]
		[Introduced (PlatformName.WatchOS, 3,0, message: "Use paymentAuthorizationController:didAuthorizePayment:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.WatchOS, 4,0, message: "Use paymentAuthorizationController:didAuthorizePayment:handler: instead to provide more granular errors")]
		[Introduced (PlatformName.iOS, 10,0, message: "Use paymentAuthorizationController:didAuthorizePayment:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use paymentAuthorizationController:didAuthorizePayment:handler: instead to provide more granular errors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PaymentAuthorizationController (PKPaymentAuthorizationController controller, global::PassKit.PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<global::PassKit.PKPaymentAuthorizationStatus> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("paymentAuthorizationController:didSelectShippingMethod:handler:")]
		[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PaymentAuthorizationController (PKPaymentAuthorizationController controller, global::PassKit.PKShippingMethod shippingMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V3))]global::System.Action<global::PassKit.PKPaymentRequestShippingMethodUpdate> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("paymentAuthorizationController:didSelectShippingContact:handler:")]
		[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PaymentAuthorizationController (PKPaymentAuthorizationController controller, global::PassKit.PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V4))]global::System.Action<global::PassKit.PKPaymentRequestShippingContactUpdate> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("paymentAuthorizationController:didSelectPaymentMethod:handler:")]
		[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PaymentAuthorizationController (PKPaymentAuthorizationController controller, global::PassKit.PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V5))]global::System.Action<global::PassKit.PKPaymentRequestPaymentMethodUpdate> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("paymentAuthorizationController:didSelectShippingMethod:completion:")]
		[Introduced (PlatformName.WatchOS, 3,0, message: "Use paymentAuthorizationController:didSelectShippingMethod:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.WatchOS, 4,0, message: "Use paymentAuthorizationController:didSelectShippingMethod:handler: instead to provide more granular errors")]
		[Introduced (PlatformName.iOS, 10,0, message: "Use paymentAuthorizationController:didSelectShippingMethod:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use paymentAuthorizationController:didSelectShippingMethod:handler: instead to provide more granular errors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PaymentAuthorizationController (PKPaymentAuthorizationController controller, global::PassKit.PKShippingMethod shippingMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V4))]global::System.Action<global::PassKit.PKPaymentAuthorizationStatus, NSArray<global::PassKit.PKPaymentSummaryItem>> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("paymentAuthorizationController:didSelectShippingContact:completion:")]
		[Introduced (PlatformName.WatchOS, 3,0, message: "Use paymentAuthorizationController:didSelectShippingContact:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.WatchOS, 4,0, message: "Use paymentAuthorizationController:didSelectShippingContact:handler: instead to provide more granular errors")]
		[Introduced (PlatformName.iOS, 10,0, message: "Use paymentAuthorizationController:didSelectShippingContact:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use paymentAuthorizationController:didSelectShippingContact:handler: instead to provide more granular errors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PaymentAuthorizationController (PKPaymentAuthorizationController controller, global::PassKit.PKContact contact, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<global::PassKit.PKPaymentAuthorizationStatus, NSArray<global::PassKit.PKShippingMethod>, NSArray<global::PassKit.PKPaymentSummaryItem>> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("paymentAuthorizationController:didSelectPaymentMethod:completion:")]
		[Introduced (PlatformName.WatchOS, 3,0, message: "Use paymentAuthorizationController:didSelectPaymentMethod:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.WatchOS, 4,0, message: "Use paymentAuthorizationController:didSelectPaymentMethod:handler: instead to provide more granular errors")]
		[Introduced (PlatformName.iOS, 10,0, message: "Use paymentAuthorizationController:didSelectPaymentMethod:handler: instead to provide more granular errors")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use paymentAuthorizationController:didSelectPaymentMethod:handler: instead to provide more granular errors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PaymentAuthorizationController (PKPaymentAuthorizationController controller, global::PassKit.PKPaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V6))]global::System.Action<NSArray<global::PassKit.PKPaymentSummaryItem>> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("paymentAuthorizationControllerDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void PaymentAuthorizationControllerDidFinish (PKPaymentAuthorizationController controller);
		[Export ("paymentAuthorizationControllerWillAuthorizePayment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PaymentAuthorizationControllerWillAuthorizePayment (PKPaymentAuthorizationController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PKPaymentAuthorizationControllerDelegate */
}
