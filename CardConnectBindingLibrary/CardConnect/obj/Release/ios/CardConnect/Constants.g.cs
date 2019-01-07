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
	public unsafe static partial class Constants  {
		
		[Field ("CCCAPIErrorCodeInvalidCardData",  "__Internal")]
		public static nint CCCAPIErrorCodeInvalidCardData {
			get {
				return Dlfcn.GetNInt (Libraries.__Internal.Handle, "CCCAPIErrorCodeInvalidCardData");
			}
		}
		[Field ("CCCAPIErrorCodeNoEndpoint",  "__Internal")]
		public static nint CCCAPIErrorCodeNoEndpoint {
			get {
				return Dlfcn.GetNInt (Libraries.__Internal.Handle, "CCCAPIErrorCodeNoEndpoint");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _CCCAPIErrorDomain;
		[Field ("CCCAPIErrorDomain",  "__Internal")]
		public static NSString CCCAPIErrorDomain {
			get {
				if (_CCCAPIErrorDomain == null)
					_CCCAPIErrorDomain = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "CCCAPIErrorDomain");
				return _CCCAPIErrorDomain;
			}
		}
		[Field ("CardConnectConsumerSDKVersionNumber",  "__Internal")]
		public static double CardConnectConsumerSDKVersionNumber {
			get {
				return Dlfcn.GetDouble (Libraries.__Internal.Handle, "CardConnectConsumerSDKVersionNumber");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _CardConnectConsumerSDKVersionString;
		[Field ("CardConnectConsumerSDKVersionString",  "__Internal")]
		public static NSString CardConnectConsumerSDKVersionString {
			get {
				if (_CardConnectConsumerSDKVersionString == null)
					_CardConnectConsumerSDKVersionString = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "CardConnectConsumerSDKVersionString");
				return _CardConnectConsumerSDKVersionString;
			}
		}
	} /* class Constants */
}
