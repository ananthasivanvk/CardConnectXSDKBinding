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
	[Protocol (Name = "CCCSwiperDelegate", WrapperType = typeof (CCCSwiperDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Swiper", Selector = "swiper:didGenerateTokenWithAccount:completion:", ParameterType = new Type [] { typeof (CardConnectBinding.CCCSwiper), typeof (CardConnectBinding.CCCAccount), typeof (Action) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type [] { null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Swiper", Selector = "swiper:didFailWithError:completion:", ParameterType = new Type [] { typeof (CardConnectBinding.CCCSwiper), typeof (NSError), typeof (Action) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type [] { null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Swiper", Selector = "swiper:connectionStateHasChanged:", ParameterType = new Type [] { typeof (CardConnectBinding.CCCSwiper), typeof (CardConnectBinding.CCCSwiperConnectionState) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Swiper", Selector = "swiper:batteryLevelStatusHasChanged:", ParameterType = new Type [] { typeof (CardConnectBinding.CCCSwiper), typeof (CardConnectBinding.CCCSwiperBatteryStatus) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SwiperDidStartMSR", Selector = "swiperDidStartMSR:", ParameterType = new Type [] { typeof (CardConnectBinding.CCCSwiper) }, ParameterByRef = new bool [] { false })]
	public interface ICCCSwiperDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("swiper:didGenerateTokenWithAccount:completion:")]
		[Preserve (Conditional = true)]
		unsafe void Swiper (CCCSwiper swiper, CCCAccount account, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("swiper:didFailWithError:completion:")]
		[Preserve (Conditional = true)]
		unsafe void Swiper (CCCSwiper swiper, NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion);
		
	}
	
	public static partial class CCCSwiperDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Swiper (this ICCCSwiperDelegate This, CCCSwiper swiper, CCCSwiperConnectionState state)
		{
			if (swiper == null)
				throw new ArgumentNullException ("swiper");
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Int64 (This.Handle, Selector.GetHandle ("swiper:connectionStateHasChanged:"), swiper.Handle, (Int64)state);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (This.Handle, Selector.GetHandle ("swiper:connectionStateHasChanged:"), swiper.Handle, (int)state);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Swiper (this ICCCSwiperDelegate This, CCCSwiper swiper, CCCSwiperBatteryStatus status)
		{
			if (swiper == null)
				throw new ArgumentNullException ("swiper");
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Int64 (This.Handle, Selector.GetHandle ("swiper:batteryLevelStatusHasChanged:"), swiper.Handle, (Int64)status);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (This.Handle, Selector.GetHandle ("swiper:batteryLevelStatusHasChanged:"), swiper.Handle, (int)status);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SwiperDidStartMSR (this ICCCSwiperDelegate This, CCCSwiper swiper)
		{
			if (swiper == null)
				throw new ArgumentNullException ("swiper");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("swiperDidStartMSR:"), swiper.Handle);
		}
		
	}
	
	internal sealed class CCCSwiperDelegateWrapper : BaseWrapper, ICCCSwiperDelegate {
		[Preserve (Conditional = true)]
		public CCCSwiperDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("swiper:didGenerateTokenWithAccount:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void Swiper (CCCSwiper swiper, CCCAccount account, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (swiper == null)
				throw new ArgumentNullException ("swiper");
			if (account == null)
				throw new ArgumentNullException ("account");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDAction.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("swiper:didGenerateTokenWithAccount:completion:"), swiper.Handle, account.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("swiper:didFailWithError:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void Swiper (CCCSwiper swiper, NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (swiper == null)
				throw new ArgumentNullException ("swiper");
			if (error == null)
				throw new ArgumentNullException ("error");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDAction.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("swiper:didFailWithError:completion:"), swiper.Handle, error.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
	}
}
namespace CardConnectBinding {
	[Protocol()]
	[Register("CCCSwiperDelegate", false)]
	[Model]
	public unsafe abstract partial class CCCSwiperDelegate : NSObject, ICCCSwiperDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CCCSwiperDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CCCSwiperDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CCCSwiperDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("swiper:didGenerateTokenWithAccount:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe abstract void Swiper (CCCSwiper swiper, CCCAccount account, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion);
		[Export ("swiper:didFailWithError:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe abstract void Swiper (CCCSwiper swiper, NSError error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion);
		[Export ("swiper:connectionStateHasChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Swiper (CCCSwiper swiper, CCCSwiperConnectionState state)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("swiper:batteryLevelStatusHasChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Swiper (CCCSwiper swiper, CCCSwiperBatteryStatus status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("swiperDidStartMSR:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SwiperDidStartMSR (CCCSwiper swiper)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class CCCSwiperDelegate */
}
