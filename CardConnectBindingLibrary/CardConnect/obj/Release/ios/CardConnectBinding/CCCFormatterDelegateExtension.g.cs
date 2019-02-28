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
	[Protocol (Name = "CCCFormatterDelegateExtension", WrapperType = typeof (CCCFormatterDelegateExtensionWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeCharactersInRangeForFormatter", Selector = "didChangeCharactersInRangeForFormatter:", ParameterType = new Type [] { typeof (CardConnectBinding.CCCTextFieldDelegateProxy) }, ParameterByRef = new bool [] { false })]
	public interface ICCCFormatterDelegateExtension : INativeObject, IDisposable, 
		UIKit.IUITextFieldDelegate
		
	{
	}
	
	public static partial class CCCFormatterDelegateExtension_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeCharactersInRangeForFormatter (this ICCCFormatterDelegateExtension This, CCCTextFieldDelegateProxy formatter)
		{
			if (formatter == null)
				throw new ArgumentNullException ("formatter");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("didChangeCharactersInRangeForFormatter:"), formatter.Handle);
		}
		
	}
	
	internal sealed class CCCFormatterDelegateExtensionWrapper : BaseWrapper, ICCCFormatterDelegateExtension {
		[Preserve (Conditional = true)]
		public CCCFormatterDelegateExtensionWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CardConnectBinding {
	[Protocol()]
	[Register("CCCFormatterDelegateExtension", true)]
	public unsafe partial class CCCFormatterDelegateExtension : NSObject, ICCCFormatterDelegateExtension, global::UIKit.IUITextFieldDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CCCFormatterDelegateExtension");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CCCFormatterDelegateExtension () : base (NSObjectFlag.Empty)
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
		protected CCCFormatterDelegateExtension (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CCCFormatterDelegateExtension (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("didChangeCharactersInRangeForFormatter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeCharactersInRangeForFormatter (CCCTextFieldDelegateProxy formatter)
		{
			if (formatter == null)
				throw new ArgumentNullException ("formatter");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("didChangeCharactersInRangeForFormatter:"), formatter.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("didChangeCharactersInRangeForFormatter:"), formatter.Handle);
			}
		}
		
	} /* class CCCFormatterDelegateExtension */
}
