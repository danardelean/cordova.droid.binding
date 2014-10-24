using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebViewClient']"
	[global::Android.Runtime.Register ("org/apache/cordova/CordovaWebViewClient", DoNotGenerateAcw=true)]
	public partial class CordovaWebViewClient : global::Android.Webkit.WebViewClient {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/CordovaWebViewClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CordovaWebViewClient); }
		}

		protected CordovaWebViewClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebViewClient']/constructor[@name='CordovaWebViewClient' and count(parameter)=2 and parameter[1][@type='org.apache.cordova.CordovaInterface'] and parameter[2][@type='org.apache.cordova.CordovaWebView']]"
		[Register (".ctor", "(Lorg/apache/cordova/CordovaInterface;Lorg/apache/cordova/CordovaWebView;)V", "")]
		public CordovaWebViewClient (global::Org.Apache.Cordova.ICordovaInterface p0, global::Org.Apache.Cordova.CordovaWebView p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CordovaWebViewClient)) {
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

		static IntPtr id_ctor_Lorg_apache_cordova_CordovaInterface_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebViewClient']/constructor[@name='CordovaWebViewClient' and count(parameter)=1 and parameter[1][@type='org.apache.cordova.CordovaInterface']]"
		[Register (".ctor", "(Lorg/apache/cordova/CordovaInterface;)V", "")]
		public CordovaWebViewClient (global::Org.Apache.Cordova.ICordovaInterface p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CordovaWebViewClient)) {
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

		static Delegate cb_clearAuthenticationTokens;
#pragma warning disable 0169
		static Delegate GetClearAuthenticationTokensHandler ()
		{
			if (cb_clearAuthenticationTokens == null)
				cb_clearAuthenticationTokens = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearAuthenticationTokens);
			return cb_clearAuthenticationTokens;
		}

		static void n_ClearAuthenticationTokens (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaWebViewClient __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebViewClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAuthenticationTokens ();
		}
#pragma warning restore 0169

		static IntPtr id_clearAuthenticationTokens;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebViewClient']/method[@name='clearAuthenticationTokens' and count(parameter)=0]"
		[Register ("clearAuthenticationTokens", "()V", "GetClearAuthenticationTokensHandler")]
		public virtual void ClearAuthenticationTokens ()
		{
			if (id_clearAuthenticationTokens == IntPtr.Zero)
				id_clearAuthenticationTokens = JNIEnv.GetMethodID (class_ref, "clearAuthenticationTokens", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearAuthenticationTokens);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearAuthenticationTokens", "()V"));
		}

		static Delegate cb_getAuthenticationToken_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAuthenticationToken_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getAuthenticationToken_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getAuthenticationToken_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAuthenticationToken_Ljava_lang_String_Ljava_lang_String_);
			return cb_getAuthenticationToken_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetAuthenticationToken_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Apache.Cordova.CordovaWebViewClient __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebViewClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAuthenticationToken (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthenticationToken_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebViewClient']/method[@name='getAuthenticationToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getAuthenticationToken", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/cordova/AuthenticationToken;", "GetGetAuthenticationToken_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual global::Org.Apache.Cordova.AuthenticationToken GetAuthenticationToken (string p0, string p1)
		{
			if (id_getAuthenticationToken_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getAuthenticationToken_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAuthenticationToken", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/cordova/AuthenticationToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::Org.Apache.Cordova.AuthenticationToken __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.AuthenticationToken> (JNIEnv.CallObjectMethod  (Handle, id_getAuthenticationToken_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.AuthenticationToken> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthenticationToken", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/cordova/AuthenticationToken;"), new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_removeAuthenticationToken_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveAuthenticationToken_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_removeAuthenticationToken_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_removeAuthenticationToken_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveAuthenticationToken_Ljava_lang_String_Ljava_lang_String_);
			return cb_removeAuthenticationToken_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_RemoveAuthenticationToken_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Apache.Cordova.CordovaWebViewClient __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebViewClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveAuthenticationToken (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeAuthenticationToken_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebViewClient']/method[@name='removeAuthenticationToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeAuthenticationToken", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/cordova/AuthenticationToken;", "GetRemoveAuthenticationToken_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual global::Org.Apache.Cordova.AuthenticationToken RemoveAuthenticationToken (string p0, string p1)
		{
			if (id_removeAuthenticationToken_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeAuthenticationToken_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeAuthenticationToken", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/cordova/AuthenticationToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::Org.Apache.Cordova.AuthenticationToken __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.AuthenticationToken> (JNIEnv.CallObjectMethod  (Handle, id_removeAuthenticationToken_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.AuthenticationToken> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAuthenticationToken", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/cordova/AuthenticationToken;"), new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_setAuthenticationToken_Lorg_apache_cordova_AuthenticationToken_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAuthenticationToken_Lorg_apache_cordova_AuthenticationToken_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setAuthenticationToken_Lorg_apache_cordova_AuthenticationToken_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setAuthenticationToken_Lorg_apache_cordova_AuthenticationToken_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAuthenticationToken_Lorg_apache_cordova_AuthenticationToken_Ljava_lang_String_Ljava_lang_String_);
			return cb_setAuthenticationToken_Lorg_apache_cordova_AuthenticationToken_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetAuthenticationToken_Lorg_apache_cordova_AuthenticationToken_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Apache.Cordova.CordovaWebViewClient __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebViewClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.AuthenticationToken p0 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.AuthenticationToken> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetAuthenticationToken (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setAuthenticationToken_Lorg_apache_cordova_AuthenticationToken_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebViewClient']/method[@name='setAuthenticationToken' and count(parameter)=3 and parameter[1][@type='org.apache.cordova.AuthenticationToken'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setAuthenticationToken", "(Lorg/apache/cordova/AuthenticationToken;Ljava/lang/String;Ljava/lang/String;)V", "GetSetAuthenticationToken_Lorg_apache_cordova_AuthenticationToken_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void SetAuthenticationToken (global::Org.Apache.Cordova.AuthenticationToken p0, string p1, string p2)
		{
			if (id_setAuthenticationToken_Lorg_apache_cordova_AuthenticationToken_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setAuthenticationToken_Lorg_apache_cordova_AuthenticationToken_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAuthenticationToken", "(Lorg/apache/cordova/AuthenticationToken;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAuthenticationToken_Lorg_apache_cordova_AuthenticationToken_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAuthenticationToken", "(Lorg/apache/cordova/AuthenticationToken;Ljava/lang/String;Ljava/lang/String;)V"), new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_setWebView_Lorg_apache_cordova_CordovaWebView_;
#pragma warning disable 0169
		static Delegate GetSetWebView_Lorg_apache_cordova_CordovaWebView_Handler ()
		{
			if (cb_setWebView_Lorg_apache_cordova_CordovaWebView_ == null)
				cb_setWebView_Lorg_apache_cordova_CordovaWebView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWebView_Lorg_apache_cordova_CordovaWebView_);
			return cb_setWebView_Lorg_apache_cordova_CordovaWebView_;
		}

		static void n_SetWebView_Lorg_apache_cordova_CordovaWebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaWebViewClient __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebViewClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.CordovaWebView p0 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetWebView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setWebView_Lorg_apache_cordova_CordovaWebView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebViewClient']/method[@name='setWebView' and count(parameter)=1 and parameter[1][@type='org.apache.cordova.CordovaWebView']]"
		[Register ("setWebView", "(Lorg/apache/cordova/CordovaWebView;)V", "GetSetWebView_Lorg_apache_cordova_CordovaWebView_Handler")]
		public virtual void SetWebView (global::Org.Apache.Cordova.CordovaWebView p0)
		{
			if (id_setWebView_Lorg_apache_cordova_CordovaWebView_ == IntPtr.Zero)
				id_setWebView_Lorg_apache_cordova_CordovaWebView_ = JNIEnv.GetMethodID (class_ref, "setWebView", "(Lorg/apache/cordova/CordovaWebView;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setWebView_Lorg_apache_cordova_CordovaWebView_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWebView", "(Lorg/apache/cordova/CordovaWebView;)V"), new JValue (p0));
		}

	}
}
