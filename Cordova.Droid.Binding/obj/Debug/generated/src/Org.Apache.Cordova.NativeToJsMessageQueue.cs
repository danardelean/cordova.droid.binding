using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='NativeToJsMessageQueue']"
	[global::Android.Runtime.Register ("org/apache/cordova/NativeToJsMessageQueue", DoNotGenerateAcw=true)]
	public partial class NativeToJsMessageQueue : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='NativeToJsMessageQueue.BridgeMode']"
		[global::Android.Runtime.Register ("org/apache/cordova/NativeToJsMessageQueue$BridgeMode", DoNotGenerateAcw=true)]
		public abstract partial class BridgeMode : global::Java.Lang.Object {

			protected BridgeMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		[global::Android.Runtime.Register ("org/apache/cordova/NativeToJsMessageQueue$BridgeMode", DoNotGenerateAcw=true)]
		internal partial class BridgeModeInvoker : BridgeMode {

			public BridgeModeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (BridgeModeInvoker); }
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='NativeToJsMessageQueue.JsMessage']"
		[global::Android.Runtime.Register ("org/apache/cordova/NativeToJsMessageQueue$JsMessage", DoNotGenerateAcw=true)]
		public partial class JsMessage : global::Java.Lang.Object {

			protected JsMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='NativeToJsMessageQueue.LoadUrlBridgeMode']"
		[global::Android.Runtime.Register ("org/apache/cordova/NativeToJsMessageQueue$LoadUrlBridgeMode", DoNotGenerateAcw=true)]
		public partial class LoadUrlBridgeMode : global::Org.Apache.Cordova.NativeToJsMessageQueue.BridgeMode {

			protected LoadUrlBridgeMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='NativeToJsMessageQueue.OnlineEventsBridgeMode']"
		[global::Android.Runtime.Register ("org/apache/cordova/NativeToJsMessageQueue$OnlineEventsBridgeMode", DoNotGenerateAcw=true)]
		public partial class OnlineEventsBridgeMode : global::Org.Apache.Cordova.NativeToJsMessageQueue.BridgeMode {

			protected OnlineEventsBridgeMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='NativeToJsMessageQueue.PollingBridgeMode']"
		[global::Android.Runtime.Register ("org/apache/cordova/NativeToJsMessageQueue$PollingBridgeMode", DoNotGenerateAcw=true)]
		public partial class PollingBridgeMode : global::Org.Apache.Cordova.NativeToJsMessageQueue.BridgeMode {

			protected PollingBridgeMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='NativeToJsMessageQueue.PrivateApiBridgeMode']"
		[global::Android.Runtime.Register ("org/apache/cordova/NativeToJsMessageQueue$PrivateApiBridgeMode", DoNotGenerateAcw=true)]
		public partial class PrivateApiBridgeMode : global::Org.Apache.Cordova.NativeToJsMessageQueue.BridgeMode {

			protected PrivateApiBridgeMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/NativeToJsMessageQueue", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeToJsMessageQueue); }
		}

		protected NativeToJsMessageQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_apache_cordova_CordovaWebView_Lorg_apache_cordova_CordovaInterface_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='NativeToJsMessageQueue']/constructor[@name='NativeToJsMessageQueue' and count(parameter)=2 and parameter[1][@type='org.apache.cordova.CordovaWebView'] and parameter[2][@type='org.apache.cordova.CordovaInterface']]"
		[Register (".ctor", "(Lorg/apache/cordova/CordovaWebView;Lorg/apache/cordova/CordovaInterface;)V", "")]
		public NativeToJsMessageQueue (global::Org.Apache.Cordova.CordovaWebView p0, global::Org.Apache.Cordova.ICordovaInterface p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (NativeToJsMessageQueue)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/cordova/CordovaWebView;Lorg/apache/cordova/CordovaInterface;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/cordova/CordovaWebView;Lorg/apache/cordova/CordovaInterface;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lorg_apache_cordova_CordovaWebView_Lorg_apache_cordova_CordovaInterface_ == IntPtr.Zero)
				id_ctor_Lorg_apache_cordova_CordovaWebView_Lorg_apache_cordova_CordovaInterface_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/cordova/CordovaWebView;Lorg/apache/cordova/CordovaInterface;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_cordova_CordovaWebView_Lorg_apache_cordova_CordovaInterface_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_cordova_CordovaWebView_Lorg_apache_cordova_CordovaInterface_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_isBridgeEnabled;
#pragma warning disable 0169
		static Delegate GetIsBridgeEnabledHandler ()
		{
			if (cb_isBridgeEnabled == null)
				cb_isBridgeEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBridgeEnabled);
			return cb_isBridgeEnabled;
		}

		static bool n_IsBridgeEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.NativeToJsMessageQueue __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.NativeToJsMessageQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBridgeEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isBridgeEnabled;
		public virtual bool IsBridgeEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='NativeToJsMessageQueue']/method[@name='isBridgeEnabled' and count(parameter)=0]"
			[Register ("isBridgeEnabled", "()Z", "GetIsBridgeEnabledHandler")]
			get {
				if (id_isBridgeEnabled == IntPtr.Zero)
					id_isBridgeEnabled = JNIEnv.GetMethodID (class_ref, "isBridgeEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isBridgeEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBridgeEnabled", "()Z"));
			}
		}

		static Delegate cb_addJavaScript_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddJavaScript_Ljava_lang_String_Handler ()
		{
			if (cb_addJavaScript_Ljava_lang_String_ == null)
				cb_addJavaScript_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddJavaScript_Ljava_lang_String_);
			return cb_addJavaScript_Ljava_lang_String_;
		}

		static void n_AddJavaScript_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.NativeToJsMessageQueue __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.NativeToJsMessageQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddJavaScript (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addJavaScript_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='NativeToJsMessageQueue']/method[@name='addJavaScript' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addJavaScript", "(Ljava/lang/String;)V", "GetAddJavaScript_Ljava_lang_String_Handler")]
		public virtual void AddJavaScript (string p0)
		{
			if (id_addJavaScript_Ljava_lang_String_ == IntPtr.Zero)
				id_addJavaScript_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addJavaScript", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addJavaScript_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addJavaScript", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_addPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_Handler ()
		{
			if (cb_addPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_ == null)
				cb_addPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_);
			return cb_addPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_;
		}

		static void n_AddPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Apache.Cordova.NativeToJsMessageQueue __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.NativeToJsMessageQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.PluginResult p0 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddPluginResult (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='NativeToJsMessageQueue']/method[@name='addPluginResult' and count(parameter)=2 and parameter[1][@type='org.apache.cordova.PluginResult'] and parameter[2][@type='java.lang.String']]"
		[Register ("addPluginResult", "(Lorg/apache/cordova/PluginResult;Ljava/lang/String;)V", "GetAddPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_Handler")]
		public virtual void AddPluginResult (global::Org.Apache.Cordova.PluginResult p0, string p1)
		{
			if (id_addPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_ == IntPtr.Zero)
				id_addPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addPluginResult", "(Lorg/apache/cordova/PluginResult;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPluginResult", "(Lorg/apache/cordova/PluginResult;Ljava/lang/String;)V"), new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_popAndEncode_Z;
#pragma warning disable 0169
		static Delegate GetPopAndEncode_ZHandler ()
		{
			if (cb_popAndEncode_Z == null)
				cb_popAndEncode_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_PopAndEncode_Z);
			return cb_popAndEncode_Z;
		}

		static IntPtr n_PopAndEncode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Apache.Cordova.NativeToJsMessageQueue __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.NativeToJsMessageQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PopAndEncode (p0));
		}
#pragma warning restore 0169

		static IntPtr id_popAndEncode_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='NativeToJsMessageQueue']/method[@name='popAndEncode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("popAndEncode", "(Z)Ljava/lang/String;", "GetPopAndEncode_ZHandler")]
		public virtual string PopAndEncode (bool p0)
		{
			if (id_popAndEncode_Z == IntPtr.Zero)
				id_popAndEncode_Z = JNIEnv.GetMethodID (class_ref, "popAndEncode", "(Z)Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_popAndEncode_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "popAndEncode", "(Z)Ljava/lang/String;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.NativeToJsMessageQueue __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.NativeToJsMessageQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='NativeToJsMessageQueue']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_reset);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
		}

		static Delegate cb_setBridgeMode_I;
#pragma warning disable 0169
		static Delegate GetSetBridgeMode_IHandler ()
		{
			if (cb_setBridgeMode_I == null)
				cb_setBridgeMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBridgeMode_I);
			return cb_setBridgeMode_I;
		}

		static void n_SetBridgeMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.NativeToJsMessageQueue __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.NativeToJsMessageQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBridgeMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBridgeMode_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='NativeToJsMessageQueue']/method[@name='setBridgeMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBridgeMode", "(I)V", "GetSetBridgeMode_IHandler")]
		public virtual void SetBridgeMode (int p0)
		{
			if (id_setBridgeMode_I == IntPtr.Zero)
				id_setBridgeMode_I = JNIEnv.GetMethodID (class_ref, "setBridgeMode", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setBridgeMode_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBridgeMode", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setPaused_Z;
#pragma warning disable 0169
		static Delegate GetSetPaused_ZHandler ()
		{
			if (cb_setPaused_Z == null)
				cb_setPaused_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPaused_Z);
			return cb_setPaused_Z;
		}

		static void n_SetPaused_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Apache.Cordova.NativeToJsMessageQueue __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.NativeToJsMessageQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPaused (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPaused_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='NativeToJsMessageQueue']/method[@name='setPaused' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPaused", "(Z)V", "GetSetPaused_ZHandler")]
		public virtual void SetPaused (bool p0)
		{
			if (id_setPaused_Z == IntPtr.Zero)
				id_setPaused_Z = JNIEnv.GetMethodID (class_ref, "setPaused", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPaused_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPaused", "(Z)V"), new JValue (p0));
		}

	}
}
