using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='App']"
	[global::Android.Runtime.Register ("org/apache/cordova/App", DoNotGenerateAcw=true)]
	public partial class App : global::Org.Apache.Cordova.CordovaPlugin {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='App']/field[@name='TAG']"
		[Register ("TAG")]
		protected const string Tag = (string) "CordovaApp";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/App", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (App); }
		}

		protected App (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='App']/constructor[@name='App' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public App () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (App)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static Delegate cb_isBackbuttonOverridden;
#pragma warning disable 0169
		static Delegate GetIsBackbuttonOverriddenHandler ()
		{
			if (cb_isBackbuttonOverridden == null)
				cb_isBackbuttonOverridden = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBackbuttonOverridden);
			return cb_isBackbuttonOverridden;
		}

		static bool n_IsBackbuttonOverridden (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.App __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.App> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBackbuttonOverridden;
		}
#pragma warning restore 0169

		static IntPtr id_isBackbuttonOverridden;
		public virtual bool IsBackbuttonOverridden {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='App']/method[@name='isBackbuttonOverridden' and count(parameter)=0]"
			[Register ("isBackbuttonOverridden", "()Z", "GetIsBackbuttonOverriddenHandler")]
			get {
				if (id_isBackbuttonOverridden == IntPtr.Zero)
					id_isBackbuttonOverridden = JNIEnv.GetMethodID (class_ref, "isBackbuttonOverridden", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isBackbuttonOverridden);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBackbuttonOverridden", "()Z"));
			}
		}

		static Delegate cb_backHistory;
#pragma warning disable 0169
		static Delegate GetBackHistoryHandler ()
		{
			if (cb_backHistory == null)
				cb_backHistory = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BackHistory);
			return cb_backHistory;
		}

		static void n_BackHistory (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.App __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.App> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BackHistory ();
		}
#pragma warning restore 0169

		static IntPtr id_backHistory;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='App']/method[@name='backHistory' and count(parameter)=0]"
		[Register ("backHistory", "()V", "GetBackHistoryHandler")]
		public virtual void BackHistory ()
		{
			if (id_backHistory == IntPtr.Zero)
				id_backHistory = JNIEnv.GetMethodID (class_ref, "backHistory", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_backHistory);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "backHistory", "()V"));
		}

		static Delegate cb_clearCache;
#pragma warning disable 0169
		static Delegate GetClearCacheHandler ()
		{
			if (cb_clearCache == null)
				cb_clearCache = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearCache);
			return cb_clearCache;
		}

		static void n_ClearCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.App __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.App> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearCache ();
		}
#pragma warning restore 0169

		static IntPtr id_clearCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='App']/method[@name='clearCache' and count(parameter)=0]"
		[Register ("clearCache", "()V", "GetClearCacheHandler")]
		public virtual void ClearCache ()
		{
			if (id_clearCache == IntPtr.Zero)
				id_clearCache = JNIEnv.GetMethodID (class_ref, "clearCache", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearCache);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearCache", "()V"));
		}

		static Delegate cb_clearHistory;
#pragma warning disable 0169
		static Delegate GetClearHistoryHandler ()
		{
			if (cb_clearHistory == null)
				cb_clearHistory = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearHistory);
			return cb_clearHistory;
		}

		static void n_ClearHistory (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.App __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.App> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearHistory ();
		}
#pragma warning restore 0169

		static IntPtr id_clearHistory;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='App']/method[@name='clearHistory' and count(parameter)=0]"
		[Register ("clearHistory", "()V", "GetClearHistoryHandler")]
		public virtual void ClearHistory ()
		{
			if (id_clearHistory == IntPtr.Zero)
				id_clearHistory = JNIEnv.GetMethodID (class_ref, "clearHistory", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearHistory);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearHistory", "()V"));
		}

		static Delegate cb_exitApp;
#pragma warning disable 0169
		static Delegate GetExitAppHandler ()
		{
			if (cb_exitApp == null)
				cb_exitApp = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ExitApp);
			return cb_exitApp;
		}

		static void n_ExitApp (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.App __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.App> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExitApp ();
		}
#pragma warning restore 0169

		static IntPtr id_exitApp;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='App']/method[@name='exitApp' and count(parameter)=0]"
		[Register ("exitApp", "()V", "GetExitAppHandler")]
		public virtual void ExitApp ()
		{
			if (id_exitApp == IntPtr.Zero)
				id_exitApp = JNIEnv.GetMethodID (class_ref, "exitApp", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_exitApp);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "exitApp", "()V"));
		}

		static Delegate cb_loadUrl_Ljava_lang_String_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetLoadUrl_Ljava_lang_String_Lorg_json_JSONObject_Handler ()
		{
			if (cb_loadUrl_Ljava_lang_String_Lorg_json_JSONObject_ == null)
				cb_loadUrl_Ljava_lang_String_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadUrl_Ljava_lang_String_Lorg_json_JSONObject_);
			return cb_loadUrl_Ljava_lang_String_Lorg_json_JSONObject_;
		}

		static void n_LoadUrl_Ljava_lang_String_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Apache.Cordova.App __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.App> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LoadUrl (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_loadUrl_Ljava_lang_String_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='App']/method[@name='loadUrl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("loadUrl", "(Ljava/lang/String;Lorg/json/JSONObject;)V", "GetLoadUrl_Ljava_lang_String_Lorg_json_JSONObject_Handler")]
		public virtual void LoadUrl (string p0, global::Org.Json.JSONObject p1)
		{
			if (id_loadUrl_Ljava_lang_String_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_loadUrl_Ljava_lang_String_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "loadUrl", "(Ljava/lang/String;Lorg/json/JSONObject;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadUrl_Ljava_lang_String_Lorg_json_JSONObject_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadUrl", "(Ljava/lang/String;Lorg/json/JSONObject;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_overrideBackbutton_Z;
#pragma warning disable 0169
		static Delegate GetOverrideBackbutton_ZHandler ()
		{
			if (cb_overrideBackbutton_Z == null)
				cb_overrideBackbutton_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OverrideBackbutton_Z);
			return cb_overrideBackbutton_Z;
		}

		static void n_OverrideBackbutton_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Apache.Cordova.App __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.App> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OverrideBackbutton (p0);
		}
#pragma warning restore 0169

		static IntPtr id_overrideBackbutton_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='App']/method[@name='overrideBackbutton' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("overrideBackbutton", "(Z)V", "GetOverrideBackbutton_ZHandler")]
		public virtual void OverrideBackbutton (bool p0)
		{
			if (id_overrideBackbutton_Z == IntPtr.Zero)
				id_overrideBackbutton_Z = JNIEnv.GetMethodID (class_ref, "overrideBackbutton", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_overrideBackbutton_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "overrideBackbutton", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_overrideButton_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetOverrideButton_Ljava_lang_String_ZHandler ()
		{
			if (cb_overrideButton_Ljava_lang_String_Z == null)
				cb_overrideButton_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OverrideButton_Ljava_lang_String_Z);
			return cb_overrideButton_Ljava_lang_String_Z;
		}

		static void n_OverrideButton_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Org.Apache.Cordova.App __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.App> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OverrideButton (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_overrideButton_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='App']/method[@name='overrideButton' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("overrideButton", "(Ljava/lang/String;Z)V", "GetOverrideButton_Ljava_lang_String_ZHandler")]
		public virtual void OverrideButton (string p0, bool p1)
		{
			if (id_overrideButton_Ljava_lang_String_Z == IntPtr.Zero)
				id_overrideButton_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "overrideButton", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_overrideButton_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "overrideButton", "(Ljava/lang/String;Z)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_pluginInitialize;
#pragma warning disable 0169
		static Delegate GetPluginInitializeHandler ()
		{
			if (cb_pluginInitialize == null)
				cb_pluginInitialize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PluginInitialize);
			return cb_pluginInitialize;
		}

		static void n_PluginInitialize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.App __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.App> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PluginInitialize ();
		}
#pragma warning restore 0169

		static IntPtr id_pluginInitialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='App']/method[@name='pluginInitialize' and count(parameter)=0]"
		[Register ("pluginInitialize", "()V", "GetPluginInitializeHandler")]
		public virtual void PluginInitialize ()
		{
			if (id_pluginInitialize == IntPtr.Zero)
				id_pluginInitialize = JNIEnv.GetMethodID (class_ref, "pluginInitialize", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_pluginInitialize);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pluginInitialize", "()V"));
		}

	}
}
