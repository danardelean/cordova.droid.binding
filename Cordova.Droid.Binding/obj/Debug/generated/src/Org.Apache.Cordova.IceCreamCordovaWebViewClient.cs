using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='IceCreamCordovaWebViewClient']"
	[global::Android.Runtime.Register ("org/apache/cordova/IceCreamCordovaWebViewClient", DoNotGenerateAcw=true)]
	public partial class IceCreamCordovaWebViewClient : global::Org.Apache.Cordova.CordovaWebViewClient {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/IceCreamCordovaWebViewClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IceCreamCordovaWebViewClient); }
		}

		protected IceCreamCordovaWebViewClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_apache_cordova_CordovaInterface_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='IceCreamCordovaWebViewClient']/constructor[@name='IceCreamCordovaWebViewClient' and count(parameter)=1 and parameter[1][@type='org.apache.cordova.CordovaInterface']]"
		[Register (".ctor", "(Lorg/apache/cordova/CordovaInterface;)V", "")]
		public IceCreamCordovaWebViewClient (global::Org.Apache.Cordova.ICordovaInterface p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (IceCreamCordovaWebViewClient)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/cordova/CordovaInterface;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/cordova/CordovaInterface;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorg_apache_cordova_CordovaInterface_ == IntPtr.Zero)
				id_ctor_Lorg_apache_cordova_CordovaInterface_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/cordova/CordovaInterface;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_cordova_CordovaInterface_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_cordova_CordovaInterface_, new JValue (p0));
		}

		static IntPtr id_ctor_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='IceCreamCordovaWebViewClient']/constructor[@name='IceCreamCordovaWebViewClient' and count(parameter)=2 and parameter[1][@type='org.apache.cordova.CordovaInterface'] and parameter[2][@type='org.apache.cordova.CordovaWebView']]"
		[Register (".ctor", "(Lorg/apache/cordova/CordovaInterface;Lorg/apache/cordova/CordovaWebView;)V", "")]
		public IceCreamCordovaWebViewClient (global::Org.Apache.Cordova.ICordovaInterface p0, global::Org.Apache.Cordova.CordovaWebView p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (IceCreamCordovaWebViewClient)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/cordova/CordovaInterface;Lorg/apache/cordova/CordovaWebView;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/cordova/CordovaInterface;Lorg/apache/cordova/CordovaWebView;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_ == IntPtr.Zero)
				id_ctor_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/cordova/CordovaInterface;Lorg/apache/cordova/CordovaWebView;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_, new JValue (p0), new JValue (p1));
		}

	}
}
