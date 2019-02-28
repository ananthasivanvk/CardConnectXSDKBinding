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
	[Protocol (Name = "CCCAccount", WrapperType = typeof (CCCAccountWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccountID", Selector = "accountID", PropertyType = typeof (string), GetterSelector = "accountID", SetterSelector = "setAccountID:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccountType", Selector = "accountType", PropertyType = typeof (string), GetterSelector = "accountType", SetterSelector = "setAccountType:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccountUpdaterOptOut", Selector = "accountUpdaterOptOut", PropertyType = typeof (bool), GetterSelector = "accountUpdaterOptOut", SetterSelector = "setAccountUpdaterOptOut:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Address", Selector = "address", PropertyType = typeof (string), GetterSelector = "address", SetterSelector = "setAddress:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "City", Selector = "city", PropertyType = typeof (string), GetterSelector = "city", SetterSelector = "setCity:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Country", Selector = "country", PropertyType = typeof (string), GetterSelector = "country", SetterSelector = "setCountry:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DefaultAccount", Selector = "defaultAccount", PropertyType = typeof (bool), GetterSelector = "defaultAccount", SetterSelector = "setDefaultAccount:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Email", Selector = "email", PropertyType = typeof (string), GetterSelector = "email", SetterSelector = "setEmail:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ExpirationDate", Selector = "expirationDate", PropertyType = typeof (NSDate), GetterSelector = "expirationDate", SetterSelector = "setExpirationDate:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "GovernmentIssued", Selector = "governmentIssued", PropertyType = typeof (bool), GetterSelector = "governmentIssued", SetterSelector = "setGovernmentIssued:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "License", Selector = "license", PropertyType = typeof (string), GetterSelector = "license", SetterSelector = "setLicense:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Name", Selector = "name", PropertyType = typeof (string), GetterSelector = "name", SetterSelector = "setName:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Phone", Selector = "phone", PropertyType = typeof (string), GetterSelector = "phone", SetterSelector = "setPhone:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "PostalCode", Selector = "postalCode", PropertyType = typeof (string), GetterSelector = "postalCode", SetterSelector = "setPostalCode:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ProfileID", Selector = "profileID", PropertyType = typeof (NSNumber), GetterSelector = "profileID", SetterSelector = "setProfileID:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Region", Selector = "region", PropertyType = typeof (string), GetterSelector = "region", SetterSelector = "setRegion:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Ssnl4", Selector = "ssnl4", PropertyType = typeof (string), GetterSelector = "ssnl4", SetterSelector = "setSsnl4:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Token", Selector = "token", PropertyType = typeof (string), GetterSelector = "token", SetterSelector = "setToken:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Last4", Selector = "last4", PropertyType = typeof (string), GetterSelector = "last4", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DataForObject", Selector = "dataForObject", PropertyType = typeof (NSData), GetterSelector = "dataForObject", ArgumentSemantic = ArgumentSemantic.None)]
	public interface ICCCAccount : INativeObject, IDisposable, 
		Foundation.INSCopying
		
	{
	}
	
	public static partial class CCCAccount_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetAccountID (this ICCCAccount This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accountID")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAccountID (this ICCCAccount This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccountID:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetAccountType (this ICCCAccount This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accountType")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAccountType (this ICCCAccount This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccountType:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetAccountUpdaterOptOut (this ICCCAccount This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("accountUpdaterOptOut"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAccountUpdaterOptOut (this ICCCAccount This, bool value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAccountUpdaterOptOut:"), value);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetAddress (this ICCCAccount This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("address")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAddress (this ICCCAccount This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAddress:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetCity (this ICCCAccount This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("city")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCity (this ICCCAccount This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setCity:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetCountry (this ICCCAccount This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("country")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCountry (this ICCCAccount This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setCountry:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetDefaultAccount (this ICCCAccount This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("defaultAccount"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDefaultAccount (this ICCCAccount This, bool value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setDefaultAccount:"), value);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetEmail (this ICCCAccount This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("email")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetEmail (this ICCCAccount This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setEmail:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDate GetExpirationDate (this ICCCAccount This)
		{
			return  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("expirationDate")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetExpirationDate (this ICCCAccount This, NSDate value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setExpirationDate:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetGovernmentIssued (this ICCCAccount This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("governmentIssued"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetGovernmentIssued (this ICCCAccount This, bool value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setGovernmentIssued:"), value);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetLicense (this ICCCAccount This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("license")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetLicense (this ICCCAccount This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setLicense:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetName (this ICCCAccount This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("name")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetName (this ICCCAccount This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setName:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetPhone (this ICCCAccount This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("phone")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetPhone (this ICCCAccount This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setPhone:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetPostalCode (this ICCCAccount This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("postalCode")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetPostalCode (this ICCCAccount This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setPostalCode:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber GetProfileID (this ICCCAccount This)
		{
			return  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("profileID")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetProfileID (this ICCCAccount This, NSNumber value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setProfileID:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetRegion (this ICCCAccount This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("region")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetRegion (this ICCCAccount This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setRegion:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetSsnl4 (this ICCCAccount This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("ssnl4")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSsnl4 (this ICCCAccount This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSsnl4:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetToken (this ICCCAccount This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("token")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetToken (this ICCCAccount This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setToken:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetLast4 (this ICCCAccount This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("last4")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData GetDataForObject (this ICCCAccount This)
		{
			return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("dataForObject")));
		}
		
	}
	
	internal sealed class CCCAccountWrapper : BaseWrapper, ICCCAccount {
		[Preserve (Conditional = true)]
		public CCCAccountWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("copyWithZone:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public NSObject Copy (NSZone zone)
		{
			if (zone == null)
				throw new ArgumentNullException ("zone");
			return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("copyWithZone:"), zone.Handle));
		}
		
	}
}
namespace CardConnectBinding {
	[Protocol()]
	[Register("CCCAccount", true)]
	public unsafe partial class CCCAccount : NSObject, ICCCAccount, INSCopying {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CCCAccount");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CCCAccount () : base (NSObjectFlag.Empty)
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
		protected CCCAccount (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CCCAccount (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CCCAccount (NSData data)
			: base (NSObjectFlag.Empty)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithData:"), data.Handle), "initWithData:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithData:"), data.Handle), "initWithData:");
			}
		}
		
		[Export ("copyWithZone:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public virtual NSObject Copy (NSZone zone)
		{
			if (zone == null)
				throw new ArgumentNullException ("zone");
			if (IsDirectBinding) {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("copyWithZone:"), zone.Handle));
			} else {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("copyWithZone:"), zone.Handle));
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AccountID {
			[Export ("accountID")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accountID")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accountID")));
				}
			}
			
			[Export ("setAccountID:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccountID:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAccountID:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AccountType {
			[Export ("accountType")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accountType")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accountType")));
				}
			}
			
			[Export ("setAccountType:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccountType:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAccountType:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccountUpdaterOptOut {
			[Export ("accountUpdaterOptOut")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("accountUpdaterOptOut"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accountUpdaterOptOut"));
				}
			}
			
			[Export ("setAccountUpdaterOptOut:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccountUpdaterOptOut:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAccountUpdaterOptOut:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Address {
			[Export ("address")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("address")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("address")));
				}
			}
			
			[Export ("setAddress:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAddress:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAddress:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string City {
			[Export ("city")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("city")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("city")));
				}
			}
			
			[Export ("setCity:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCity:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCity:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Country {
			[Export ("country")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("country")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("country")));
				}
			}
			
			[Export ("setCountry:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCountry:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCountry:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData DataForObject {
			[Export ("dataForObject")]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dataForObject")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dataForObject")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DefaultAccount {
			[Export ("defaultAccount")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("defaultAccount"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("defaultAccount"));
				}
			}
			
			[Export ("setDefaultAccount:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDefaultAccount:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDefaultAccount:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Email {
			[Export ("email")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("email")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("email")));
				}
			}
			
			[Export ("setEmail:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setEmail:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setEmail:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate ExpirationDate {
			[Export ("expirationDate", ArgumentSemantic.Copy)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("expirationDate")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("expirationDate")));
				}
				return ret;
			}
			
			[Export ("setExpirationDate:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setExpirationDate:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setExpirationDate:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GovernmentIssued {
			[Export ("governmentIssued")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("governmentIssued"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("governmentIssued"));
				}
			}
			
			[Export ("setGovernmentIssued:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setGovernmentIssued:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setGovernmentIssued:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Last4 {
			[Export ("last4")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("last4")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("last4")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string License {
			[Export ("license")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("license")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("license")));
				}
			}
			
			[Export ("setLicense:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLicense:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLicense:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Name {
			[Export ("name")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("name")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("name")));
				}
			}
			
			[Export ("setName:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Phone {
			[Export ("phone")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("phone")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("phone")));
				}
			}
			
			[Export ("setPhone:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPhone:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPhone:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string PostalCode {
			[Export ("postalCode")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("postalCode")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("postalCode")));
				}
			}
			
			[Export ("setPostalCode:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPostalCode:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPostalCode:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber ProfileID {
			[Export ("profileID", ArgumentSemantic.Copy)]
			get {
				NSNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("profileID")));
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("profileID")));
				}
				return ret;
			}
			
			[Export ("setProfileID:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setProfileID:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setProfileID:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Region {
			[Export ("region")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("region")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("region")));
				}
			}
			
			[Export ("setRegion:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRegion:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRegion:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Ssnl4 {
			[Export ("ssnl4")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("ssnl4")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ssnl4")));
				}
			}
			
			[Export ("setSsnl4:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSsnl4:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSsnl4:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Token {
			[Export ("token")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("token")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("token")));
				}
			}
			
			[Export ("setToken:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setToken:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setToken:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
	} /* class CCCAccount */
}
