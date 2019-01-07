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
	[Protocol (Name = "CCCAPI", WrapperType = typeof (CCCAPIWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "Instance", Selector = "instance", ReturnType = typeof (CardConnect.CCCAPI))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GenerateAccountForCard", Selector = "generateAccountForCard:completion:", ReturnType = typeof (NSUrlSessionTask), ParameterType = new Type [] { typeof (CardConnect.CCCCardInfo), typeof (global::System.Action<global::CardConnect.CCCAccount, NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GenerateTokenForApplePay", Selector = "generateTokenForApplePay:completion:", ReturnType = typeof (NSUrlSessionTask), ParameterType = new Type [] { typeof (PassKit.PKPayment), typeof (global::System.Action<NSString, NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V1) })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Endpoint", Selector = "endpoint", PropertyType = typeof (string), GetterSelector = "endpoint", SetterSelector = "setEndpoint:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "EnableLogging", Selector = "enableLogging", PropertyType = typeof (bool), GetterSelector = "enableLogging", SetterSelector = "setEnableLogging:", ArgumentSemantic = ArgumentSemantic.None)]
	public interface ICCCAPI : INativeObject, IDisposable
	{
	}
	
	public static partial class CCCAPI_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSUrlSessionTask GenerateAccountForCard (this ICCCAPI This, CCCCardInfo card, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<CCCAccount, NSError> completion)
		{
			if (card == null)
				throw new ArgumentNullException ("card");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity2V0.Handler, completion);
			
			NSUrlSessionTask ret;
			ret =  Runtime.GetNSObject<NSUrlSessionTask> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("generateAccountForCard:completion:"), card.Handle, (IntPtr) block_ptr_completion));
			block_ptr_completion->CleanupBlock ();
			
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSUrlSessionTask GenerateTokenForApplePay (this ICCCAPI This, global::PassKit.PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V1))]global::System.Action<NSString, NSError> completion)
		{
			if (payment == null)
				throw new ArgumentNullException ("payment");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity2V1.Handler, completion);
			
			NSUrlSessionTask ret;
			ret =  Runtime.GetNSObject<NSUrlSessionTask> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("generateTokenForApplePay:completion:"), payment.Handle, (IntPtr) block_ptr_completion));
			block_ptr_completion->CleanupBlock ();
			
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetEndpoint (this ICCCAPI This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("endpoint")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetEndpoint (this ICCCAPI This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setEndpoint:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetEnableLogging (this ICCCAPI This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("enableLogging"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetEnableLogging (this ICCCAPI This, bool value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setEnableLogging:"), value);
		}
		
	}
	
	internal sealed class CCCAPIWrapper : BaseWrapper, ICCCAPI {
		[Preserve (Conditional = true)]
		public CCCAPIWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CardConnect {
	[Protocol()]
	[Register("CCCAPI", true)]
	public unsafe partial class CCCAPI : NSObject, ICCCAPI {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CCCAPI");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CCCAPI () : base (NSObjectFlag.Empty)
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
		protected CCCAPI (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CCCAPI (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("generateAccountForCard:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSUrlSessionTask GenerateAccountForCard (CCCCardInfo card, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<CCCAccount, NSError> completion)
		{
			if (card == null)
				throw new ArgumentNullException ("card");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity2V0.Handler, completion);
			
			NSUrlSessionTask ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrlSessionTask> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("generateAccountForCard:completion:"), card.Handle, (IntPtr) block_ptr_completion));
			} else {
				ret =  Runtime.GetNSObject<NSUrlSessionTask> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("generateAccountForCard:completion:"), card.Handle, (IntPtr) block_ptr_completion));
			}
			block_ptr_completion->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("generateTokenForApplePay:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSUrlSessionTask GenerateTokenForApplePay (global::PassKit.PKPayment payment, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V1))]global::System.Action<NSString, NSError> completion)
		{
			if (payment == null)
				throw new ArgumentNullException ("payment");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity2V1.Handler, completion);
			
			NSUrlSessionTask ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrlSessionTask> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("generateTokenForApplePay:completion:"), payment.Handle, (IntPtr) block_ptr_completion));
			} else {
				ret =  Runtime.GetNSObject<NSUrlSessionTask> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("generateTokenForApplePay:completion:"), payment.Handle, (IntPtr) block_ptr_completion));
			}
			block_ptr_completion->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("instance")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CCCAPI Instance ()
		{
			return  Runtime.GetNSObject<CCCAPI> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("instance")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool EnableLogging {
			[Export ("enableLogging")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enableLogging"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enableLogging"));
				}
			}
			
			[Export ("setEnableLogging:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnableLogging:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnableLogging:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Endpoint {
			[Export ("endpoint")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("endpoint")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("endpoint")));
				}
			}
			
			[Export ("setEndpoint:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setEndpoint:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setEndpoint:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
	} /* class CCCAPI */
}
