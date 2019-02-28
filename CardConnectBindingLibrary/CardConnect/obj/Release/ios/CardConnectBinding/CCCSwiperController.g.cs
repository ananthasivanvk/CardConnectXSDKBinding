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
	[Protocol (Name = "CCCSwiperController", WrapperType = typeof (CCCSwiperControllerWrapper))]
	public interface ICCCSwiperController : INativeObject, IDisposable, 
		CardConnectBinding.ICCCSwiper
		
	{
	}
	
	internal sealed class CCCSwiperControllerWrapper : BaseWrapper, ICCCSwiperController {
		[Preserve (Conditional = true)]
		public CCCSwiperControllerWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CardConnectBinding {
	[Protocol()]
	[Register("CCCSwiperController", true)]
	public unsafe partial class CCCSwiperController : CCCSwiper, ICCCSwiperController {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CCCSwiperController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CCCSwiperController () : base (NSObjectFlag.Empty)
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
		protected CCCSwiperController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CCCSwiperController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDelegate:loggingEnabled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CCCSwiperController (CCCSwiperDelegate @delegate, bool enabled)
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
		
	} /* class CCCSwiperController */
}
