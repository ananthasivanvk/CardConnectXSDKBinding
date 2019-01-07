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
	[Protocol (Name = "CCCAPIBridgeProtocol", WrapperType = typeof (CCCAPIBridgeProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CCC_getAccounts", Selector = "CCC_getAccounts:", ParameterType = new Type [] { typeof (global::System.Action<NSArray<global::CardConnect.CCCAccount>, NSError>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type [] { typeof (ObjCRuntime.Trampolines.NIDActionArity2V2) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CCC_saveAccountToCustomer", Selector = "CCC_saveAccountToCustomer:completion:", ParameterType = new Type [] { typeof (CardConnect.CCCAccount), typeof (global::System.Action<global::CardConnect.CCCAccount, NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V0) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CCC_deleteCustomerAccount", Selector = "CCC_deleteCustomerAccount:completion:", ParameterType = new Type [] { typeof (string), typeof (global::System.Action<bool, NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V3) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CCC_updateAccount", Selector = "CCC_updateAccount:completion:", ParameterType = new Type [] { typeof (CardConnect.CCCAccount), typeof (global::System.Action<global::CardConnect.CCCAccount, NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CCC_authApplePayTransactionWithToken", Selector = "CCC_authApplePayTransactionWithToken:completion:", ParameterType = new Type [] { typeof (string), typeof (global::System.Action<bool, NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V3) })]
	public interface ICCCAPIBridgeProtocol : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("CCC_getAccounts:")]
		[Preserve (Conditional = true)]
		unsafe void CCC_getAccounts ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V2))]global::System.Action<NSArray<CCCAccount>, NSError> completion);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("CCC_saveAccountToCustomer:completion:")]
		[Preserve (Conditional = true)]
		unsafe void CCC_saveAccountToCustomer (CCCAccount account, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<CCCAccount, NSError> completion);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("CCC_deleteCustomerAccount:completion:")]
		[Preserve (Conditional = true)]
		unsafe void CCC_deleteCustomerAccount (string accountID, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<bool, NSError> completion);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("CCC_updateAccount:completion:")]
		[Preserve (Conditional = true)]
		unsafe void CCC_updateAccount (CCCAccount account, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<CCCAccount, NSError> completion);
		
	}
	
	public static partial class CCCAPIBridgeProtocol_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void CCC_authApplePayTransactionWithToken (this ICCCAPIBridgeProtocol This, string token, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<bool, NSError> completion)
		{
			if (token == null)
				throw new ArgumentNullException ("token");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			var nstoken = NSString.CreateNative (token);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity2V3.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("CCC_authApplePayTransactionWithToken:completion:"), nstoken, (IntPtr) block_ptr_completion);
			NSString.ReleaseNative (nstoken);
			block_ptr_completion->CleanupBlock ();
			
		}
		
	}
	
	internal sealed class CCCAPIBridgeProtocolWrapper : BaseWrapper, ICCCAPIBridgeProtocol {
		[Preserve (Conditional = true)]
		public CCCAPIBridgeProtocolWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("CCC_getAccounts:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CCC_getAccounts ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V2))]global::System.Action<NSArray<CCCAccount>, NSError> completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity2V2.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("CCC_getAccounts:"), (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("CCC_saveAccountToCustomer:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CCC_saveAccountToCustomer (CCCAccount account, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<CCCAccount, NSError> completion)
		{
			if (account == null)
				throw new ArgumentNullException ("account");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity2V0.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("CCC_saveAccountToCustomer:completion:"), account.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("CCC_deleteCustomerAccount:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CCC_deleteCustomerAccount (string accountID, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<bool, NSError> completion)
		{
			if (accountID == null)
				throw new ArgumentNullException ("accountID");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			var nsaccountID = NSString.CreateNative (accountID);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity2V3.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("CCC_deleteCustomerAccount:completion:"), nsaccountID, (IntPtr) block_ptr_completion);
			NSString.ReleaseNative (nsaccountID);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("CCC_updateAccount:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CCC_updateAccount (CCCAccount account, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<CCCAccount, NSError> completion)
		{
			if (account == null)
				throw new ArgumentNullException ("account");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity2V0.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("CCC_updateAccount:completion:"), account.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
	}
}
namespace CardConnect {
	[Protocol()]
	[Register("CCCAPIBridgeProtocol", false)]
	[Model]
	public unsafe abstract partial class CCCAPIBridgeProtocol : NSObject, ICCCAPIBridgeProtocol {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CCCAPIBridgeProtocol () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CCCAPIBridgeProtocol (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CCCAPIBridgeProtocol (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("CCC_authApplePayTransactionWithToken:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CCC_authApplePayTransactionWithToken (string token, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<bool, NSError> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("CCC_deleteCustomerAccount:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe abstract void CCC_deleteCustomerAccount (string accountID, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<bool, NSError> completion);
		[Export ("CCC_getAccounts:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe abstract void CCC_getAccounts ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V2))]global::System.Action<NSArray<CCCAccount>, NSError> completion);
		[Export ("CCC_saveAccountToCustomer:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe abstract void CCC_saveAccountToCustomer (CCCAccount account, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<CCCAccount, NSError> completion);
		[Export ("CCC_updateAccount:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe abstract void CCC_updateAccount (CCCAccount account, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<CCCAccount, NSError> completion);
	} /* class CCCAPIBridgeProtocol */
}
