using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']"
	[global::Android.Runtime.Register ("org/apache/cordova/CordovaActivity", DoNotGenerateAcw=true)]
	public partial class CordovaActivity : global::Android.App.Activity, global::Org.Apache.Cordova.ICordovaInterface {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, TAG_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr activityResultCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/field[@name='activityResultCallback']"
		[Register ("activityResultCallback")]
		protected global::Org.Apache.Cordova.CordovaPlugin ActivityResultCallback {
			get {
				if (activityResultCallback_jfieldId == IntPtr.Zero)
					activityResultCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "activityResultCallback", "Lorg/apache/cordova/CordovaPlugin;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, activityResultCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (activityResultCallback_jfieldId == IntPtr.Zero)
					activityResultCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "activityResultCallback", "Lorg/apache/cordova/CordovaPlugin;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, activityResultCallback_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr activityResultKeepRunning_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/field[@name='activityResultKeepRunning']"
		[Register ("activityResultKeepRunning")]
		protected bool ActivityResultKeepRunning {
			get {
				if (activityResultKeepRunning_jfieldId == IntPtr.Zero)
					activityResultKeepRunning_jfieldId = JNIEnv.GetFieldID (class_ref, "activityResultKeepRunning", "Z");
				return JNIEnv.GetBooleanField (Handle, activityResultKeepRunning_jfieldId);
			}
			set {
				if (activityResultKeepRunning_jfieldId == IntPtr.Zero)
					activityResultKeepRunning_jfieldId = JNIEnv.GetFieldID (class_ref, "activityResultKeepRunning", "Z");
				JNIEnv.SetField (Handle, activityResultKeepRunning_jfieldId, value);
			}
		}

		static IntPtr appView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/field[@name='appView']"
		[Register ("appView")]
		protected global::Org.Apache.Cordova.CordovaWebView AppView {
			get {
				if (appView_jfieldId == IntPtr.Zero)
					appView_jfieldId = JNIEnv.GetFieldID (class_ref, "appView", "Lorg/apache/cordova/CordovaWebView;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, appView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (appView_jfieldId == IntPtr.Zero)
					appView_jfieldId = JNIEnv.GetFieldID (class_ref, "appView", "Lorg/apache/cordova/CordovaWebView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, appView_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr externalWhitelist_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/field[@name='externalWhitelist']"
		[Register ("externalWhitelist")]
		protected global::Org.Apache.Cordova.Whitelist ExternalWhitelist {
			get {
				if (externalWhitelist_jfieldId == IntPtr.Zero)
					externalWhitelist_jfieldId = JNIEnv.GetFieldID (class_ref, "externalWhitelist", "Lorg/apache/cordova/Whitelist;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, externalWhitelist_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.Whitelist> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (externalWhitelist_jfieldId == IntPtr.Zero)
					externalWhitelist_jfieldId = JNIEnv.GetFieldID (class_ref, "externalWhitelist", "Lorg/apache/cordova/Whitelist;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, externalWhitelist_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr internalWhitelist_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/field[@name='internalWhitelist']"
		[Register ("internalWhitelist")]
		protected global::Org.Apache.Cordova.Whitelist InternalWhitelist {
			get {
				if (internalWhitelist_jfieldId == IntPtr.Zero)
					internalWhitelist_jfieldId = JNIEnv.GetFieldID (class_ref, "internalWhitelist", "Lorg/apache/cordova/Whitelist;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, internalWhitelist_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.Whitelist> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (internalWhitelist_jfieldId == IntPtr.Zero)
					internalWhitelist_jfieldId = JNIEnv.GetFieldID (class_ref, "internalWhitelist", "Lorg/apache/cordova/Whitelist;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, internalWhitelist_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr keepRunning_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/field[@name='keepRunning']"
		[Register ("keepRunning")]
		protected bool KeepRunning {
			get {
				if (keepRunning_jfieldId == IntPtr.Zero)
					keepRunning_jfieldId = JNIEnv.GetFieldID (class_ref, "keepRunning", "Z");
				return JNIEnv.GetBooleanField (Handle, keepRunning_jfieldId);
			}
			set {
				if (keepRunning_jfieldId == IntPtr.Zero)
					keepRunning_jfieldId = JNIEnv.GetFieldID (class_ref, "keepRunning", "Z");
				JNIEnv.SetField (Handle, keepRunning_jfieldId, value);
			}
		}

		static IntPtr launchUrl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/field[@name='launchUrl']"
		[Register ("launchUrl")]
		protected string LaunchUrl {
			get {
				if (launchUrl_jfieldId == IntPtr.Zero)
					launchUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "launchUrl", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, launchUrl_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (launchUrl_jfieldId == IntPtr.Zero)
					launchUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "launchUrl", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, launchUrl_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr loadUrlTimeoutValue_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/field[@name='loadUrlTimeoutValue']"
		[Register ("loadUrlTimeoutValue")]
		protected int LoadUrlTimeoutValue {
			get {
				if (loadUrlTimeoutValue_jfieldId == IntPtr.Zero)
					loadUrlTimeoutValue_jfieldId = JNIEnv.GetFieldID (class_ref, "loadUrlTimeoutValue", "I");
				return JNIEnv.GetIntField (Handle, loadUrlTimeoutValue_jfieldId);
			}
			set {
				if (loadUrlTimeoutValue_jfieldId == IntPtr.Zero)
					loadUrlTimeoutValue_jfieldId = JNIEnv.GetFieldID (class_ref, "loadUrlTimeoutValue", "I");
				JNIEnv.SetField (Handle, loadUrlTimeoutValue_jfieldId, value);
			}
		}

		static IntPtr pluginEntries_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/field[@name='pluginEntries']"
		[Register ("pluginEntries")]
		protected global::System.Collections.IList PluginEntries {
			get {
				if (pluginEntries_jfieldId == IntPtr.Zero)
					pluginEntries_jfieldId = JNIEnv.GetFieldID (class_ref, "pluginEntries", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, pluginEntries_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (pluginEntries_jfieldId == IntPtr.Zero)
					pluginEntries_jfieldId = JNIEnv.GetFieldID (class_ref, "pluginEntries", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, pluginEntries_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr preferences_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/field[@name='preferences']"
		[Register ("preferences")]
		protected global::Org.Apache.Cordova.CordovaPreferences Preferences {
			get {
				if (preferences_jfieldId == IntPtr.Zero)
					preferences_jfieldId = JNIEnv.GetFieldID (class_ref, "preferences", "Lorg/apache/cordova/CordovaPreferences;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, preferences_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPreferences> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (preferences_jfieldId == IntPtr.Zero)
					preferences_jfieldId = JNIEnv.GetFieldID (class_ref, "preferences", "Lorg/apache/cordova/CordovaPreferences;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, preferences_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr root_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/field[@name='root']"
		[Register ("root")]
		protected global::Android.Widget.LinearLayout Root {
			get {
				if (root_jfieldId == IntPtr.Zero)
					root_jfieldId = JNIEnv.GetFieldID (class_ref, "root", "Landroid/widget/LinearLayout;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, root_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.LinearLayout> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (root_jfieldId == IntPtr.Zero)
					root_jfieldId = JNIEnv.GetFieldID (class_ref, "root", "Landroid/widget/LinearLayout;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, root_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr spinnerDialog_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/field[@name='spinnerDialog']"
		[Register ("spinnerDialog")]
		protected global::Android.App.ProgressDialog SpinnerDialog {
			get {
				if (spinnerDialog_jfieldId == IntPtr.Zero)
					spinnerDialog_jfieldId = JNIEnv.GetFieldID (class_ref, "spinnerDialog", "Landroid/app/ProgressDialog;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, spinnerDialog_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.App.ProgressDialog> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (spinnerDialog_jfieldId == IntPtr.Zero)
					spinnerDialog_jfieldId = JNIEnv.GetFieldID (class_ref, "spinnerDialog", "Landroid/app/ProgressDialog;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, spinnerDialog_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr splashDialog_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/field[@name='splashDialog']"
		[Register ("splashDialog")]
		protected global::Android.App.Dialog SplashDialog {
			get {
				if (splashDialog_jfieldId == IntPtr.Zero)
					splashDialog_jfieldId = JNIEnv.GetFieldID (class_ref, "splashDialog", "Landroid/app/Dialog;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, splashDialog_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.App.Dialog> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (splashDialog_jfieldId == IntPtr.Zero)
					splashDialog_jfieldId = JNIEnv.GetFieldID (class_ref, "splashDialog", "Landroid/app/Dialog;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, splashDialog_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr splashscreen_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/field[@name='splashscreen']"
		[Register ("splashscreen")]
		protected int Splashscreen {
			get {
				if (splashscreen_jfieldId == IntPtr.Zero)
					splashscreen_jfieldId = JNIEnv.GetFieldID (class_ref, "splashscreen", "I");
				return JNIEnv.GetIntField (Handle, splashscreen_jfieldId);
			}
			set {
				if (splashscreen_jfieldId == IntPtr.Zero)
					splashscreen_jfieldId = JNIEnv.GetFieldID (class_ref, "splashscreen", "I");
				JNIEnv.SetField (Handle, splashscreen_jfieldId, value);
			}
		}

		static IntPtr splashscreenTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/field[@name='splashscreenTime']"
		[Register ("splashscreenTime")]
		protected int SplashscreenTime {
			get {
				if (splashscreenTime_jfieldId == IntPtr.Zero)
					splashscreenTime_jfieldId = JNIEnv.GetFieldID (class_ref, "splashscreenTime", "I");
				return JNIEnv.GetIntField (Handle, splashscreenTime_jfieldId);
			}
			set {
				if (splashscreenTime_jfieldId == IntPtr.Zero)
					splashscreenTime_jfieldId = JNIEnv.GetFieldID (class_ref, "splashscreenTime", "I");
				JNIEnv.SetField (Handle, splashscreenTime_jfieldId, value);
			}
		}

		static IntPtr webViewClient_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/field[@name='webViewClient']"
		[Register ("webViewClient")]
		protected global::Org.Apache.Cordova.CordovaWebViewClient WebViewClient {
			get {
				if (webViewClient_jfieldId == IntPtr.Zero)
					webViewClient_jfieldId = JNIEnv.GetFieldID (class_ref, "webViewClient", "Lorg/apache/cordova/CordovaWebViewClient;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, webViewClient_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebViewClient> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (webViewClient_jfieldId == IntPtr.Zero)
					webViewClient_jfieldId = JNIEnv.GetFieldID (class_ref, "webViewClient", "Lorg/apache/cordova/CordovaWebViewClient;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, webViewClient_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/CordovaActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CordovaActivity); }
		}

		protected CordovaActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/constructor[@name='CordovaActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public CordovaActivity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CordovaActivity)) {
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

		static Delegate cb_getActivity;
#pragma warning disable 0169
		static Delegate GetGetActivityHandler ()
		{
			if (cb_getActivity == null)
				cb_getActivity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActivity);
			return cb_getActivity;
		}

		static IntPtr n_GetActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Activity);
		}
#pragma warning restore 0169

		static IntPtr id_getActivity;
		public virtual global::Android.App.Activity Activity {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='getActivity' and count(parameter)=0]"
			[Register ("getActivity", "()Landroid/app/Activity;", "GetGetActivityHandler")]
			get {
				if (id_getActivity == IntPtr.Zero)
					id_getActivity = JNIEnv.GetMethodID (class_ref, "getActivity", "()Landroid/app/Activity;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (JNIEnv.CallObjectMethod  (Handle, id_getActivity), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActivity", "()Landroid/app/Activity;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		static IntPtr id_getContext;
		[Obsolete (@"deprecated")]
		public virtual global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetMethodID (class_ref, "getContext", "()Landroid/content/Context;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod  (Handle, id_getContext), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContext", "()Landroid/content/Context;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getThreadPool;
#pragma warning disable 0169
		static Delegate GetGetThreadPoolHandler ()
		{
			if (cb_getThreadPool == null)
				cb_getThreadPool = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThreadPool);
			return cb_getThreadPool;
		}

		static IntPtr n_GetThreadPool (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThreadPool);
		}
#pragma warning restore 0169

		static IntPtr id_getThreadPool;
		public virtual global::Java.Util.Concurrent.IExecutorService ThreadPool {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='getThreadPool' and count(parameter)=0]"
			[Register ("getThreadPool", "()Ljava/util/concurrent/ExecutorService;", "GetGetThreadPoolHandler")]
			get {
				if (id_getThreadPool == IntPtr.Zero)
					id_getThreadPool = JNIEnv.GetMethodID (class_ref, "getThreadPool", "()Ljava/util/concurrent/ExecutorService;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (JNIEnv.CallObjectMethod  (Handle, id_getThreadPool), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThreadPool", "()Ljava/util/concurrent/ExecutorService;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addService_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddService_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addService_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addService_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddService_Ljava_lang_String_Ljava_lang_String_);
			return cb_addService_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddService_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddService (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addService_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='addService' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addService", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddService_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void AddService (string p0, string p1)
		{
			if (id_addService_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addService_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addService", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addService_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addService", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_backHistory;
#pragma warning disable 0169
		static Delegate GetBackHistoryHandler ()
		{
			if (cb_backHistory == null)
				cb_backHistory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_BackHistory);
			return cb_backHistory;
		}

		static bool n_BackHistory (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackHistory ();
		}
#pragma warning restore 0169

		static IntPtr id_backHistory;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='backHistory' and count(parameter)=0]"
		[Register ("backHistory", "()Z", "GetBackHistoryHandler")]
		public virtual bool BackHistory ()
		{
			if (id_backHistory == IntPtr.Zero)
				id_backHistory = JNIEnv.GetMethodID (class_ref, "backHistory", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_backHistory);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "backHistory", "()Z"));
		}

		static Delegate cb_cancelLoadUrl;
#pragma warning disable 0169
		static Delegate GetCancelLoadUrlHandler ()
		{
			if (cb_cancelLoadUrl == null)
				cb_cancelLoadUrl = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelLoadUrl);
			return cb_cancelLoadUrl;
		}

		static void n_CancelLoadUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelLoadUrl ();
		}
#pragma warning restore 0169

		static IntPtr id_cancelLoadUrl;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='cancelLoadUrl' and count(parameter)=0]"
		[Register ("cancelLoadUrl", "()V", "GetCancelLoadUrlHandler")]
		public virtual void CancelLoadUrl ()
		{
			if (id_cancelLoadUrl == IntPtr.Zero)
				id_cancelLoadUrl = JNIEnv.GetMethodID (class_ref, "cancelLoadUrl", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_cancelLoadUrl);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelLoadUrl", "()V"));
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
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAuthenticationTokens ();
		}
#pragma warning restore 0169

		static IntPtr id_clearAuthenticationTokens;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='clearAuthenticationTokens' and count(parameter)=0]"
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
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearCache ();
		}
#pragma warning restore 0169

		static IntPtr id_clearCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='clearCache' and count(parameter)=0]"
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
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearHistory ();
		}
#pragma warning restore 0169

		static IntPtr id_clearHistory;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='clearHistory' and count(parameter)=0]"
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

		static Delegate cb_createViews;
#pragma warning disable 0169
		static Delegate GetCreateViewsHandler ()
		{
			if (cb_createViews == null)
				cb_createViews = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CreateViews);
			return cb_createViews;
		}

		static void n_CreateViews (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CreateViews ();
		}
#pragma warning restore 0169

		static IntPtr id_createViews;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='createViews' and count(parameter)=0]"
		[Register ("createViews", "()V", "GetCreateViewsHandler")]
		protected virtual void CreateViews ()
		{
			if (id_createViews == IntPtr.Zero)
				id_createViews = JNIEnv.GetMethodID (class_ref, "createViews", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_createViews);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createViews", "()V"));
		}

		static Delegate cb_displayError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetDisplayError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_displayError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_displayError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_DisplayError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_displayError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static void n_DisplayError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DisplayError (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_displayError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='displayError' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("displayError", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "GetDisplayError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual void DisplayError (string p0, string p1, string p2, bool p3)
		{
			if (id_displayError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_displayError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "displayError", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_displayError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "displayError", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V"), new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_endActivity;
#pragma warning disable 0169
		static Delegate GetEndActivityHandler ()
		{
			if (cb_endActivity == null)
				cb_endActivity = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EndActivity);
			return cb_endActivity;
		}

		static void n_EndActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndActivity ();
		}
#pragma warning restore 0169

		static IntPtr id_endActivity;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='endActivity' and count(parameter)=0]"
		[Register ("endActivity", "()V", "GetEndActivityHandler")]
		public virtual void EndActivity ()
		{
			if (id_endActivity == IntPtr.Zero)
				id_endActivity = JNIEnv.GetMethodID (class_ref, "endActivity", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_endActivity);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "endActivity", "()V"));
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
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAuthenticationToken (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthenticationToken_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='getAuthenticationToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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

		static Delegate cb_getBooleanProperty_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetBooleanProperty_Ljava_lang_String_ZHandler ()
		{
			if (cb_getBooleanProperty_Ljava_lang_String_Z == null)
				cb_getBooleanProperty_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool>) n_GetBooleanProperty_Ljava_lang_String_Z);
			return cb_getBooleanProperty_Ljava_lang_String_Z;
		}

		static bool n_GetBooleanProperty_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBooleanProperty (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBooleanProperty_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='getBooleanProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getBooleanProperty", "(Ljava/lang/String;Z)Z", "GetGetBooleanProperty_Ljava_lang_String_ZHandler")]
		public virtual bool GetBooleanProperty (string p0, bool p1)
		{
			if (id_getBooleanProperty_Ljava_lang_String_Z == IntPtr.Zero)
				id_getBooleanProperty_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "getBooleanProperty", "(Ljava/lang/String;Z)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_getBooleanProperty_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBooleanProperty", "(Ljava/lang/String;Z)Z"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getDoubleProperty_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetGetDoubleProperty_Ljava_lang_String_DHandler ()
		{
			if (cb_getDoubleProperty_Ljava_lang_String_D == null)
				cb_getDoubleProperty_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double, double>) n_GetDoubleProperty_Ljava_lang_String_D);
			return cb_getDoubleProperty_Ljava_lang_String_D;
		}

		static double n_GetDoubleProperty_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.GetDoubleProperty (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDoubleProperty_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='getDoubleProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("getDoubleProperty", "(Ljava/lang/String;D)D", "GetGetDoubleProperty_Ljava_lang_String_DHandler")]
		public virtual double GetDoubleProperty (string p0, double p1)
		{
			if (id_getDoubleProperty_Ljava_lang_String_D == IntPtr.Zero)
				id_getDoubleProperty_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "getDoubleProperty", "(Ljava/lang/String;D)D");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			double __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallDoubleMethod  (Handle, id_getDoubleProperty_Ljava_lang_String_D, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDoubleProperty", "(Ljava/lang/String;D)D"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getIntegerProperty_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetIntegerProperty_Ljava_lang_String_IHandler ()
		{
			if (cb_getIntegerProperty_Ljava_lang_String_I == null)
				cb_getIntegerProperty_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_GetIntegerProperty_Ljava_lang_String_I);
			return cb_getIntegerProperty_Ljava_lang_String_I;
		}

		static int n_GetIntegerProperty_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetIntegerProperty (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getIntegerProperty_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='getIntegerProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getIntegerProperty", "(Ljava/lang/String;I)I", "GetGetIntegerProperty_Ljava_lang_String_IHandler")]
		public virtual int GetIntegerProperty (string p0, int p1)
		{
			if (id_getIntegerProperty_Ljava_lang_String_I == IntPtr.Zero)
				id_getIntegerProperty_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getIntegerProperty", "(Ljava/lang/String;I)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getIntegerProperty_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIntegerProperty", "(Ljava/lang/String;I)I"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getStringProperty_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetStringProperty_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getStringProperty_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getStringProperty_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStringProperty_Ljava_lang_String_Ljava_lang_String_);
			return cb_getStringProperty_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetStringProperty_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetStringProperty (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStringProperty_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='getStringProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStringProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetStringProperty_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual string GetStringProperty (string p0, string p1)
		{
			if (id_getStringProperty_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getStringProperty_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getStringProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getStringProperty_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStringProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		public virtual void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_init);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "()V"));
		}

		static Delegate cb_init_Lorg_apache_cordova_CordovaWebView_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_;
#pragma warning disable 0169
		static Delegate GetInit_Lorg_apache_cordova_CordovaWebView_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_Handler ()
		{
			if (cb_init_Lorg_apache_cordova_CordovaWebView_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_ == null)
				cb_init_Lorg_apache_cordova_CordovaWebView_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Lorg_apache_cordova_CordovaWebView_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_);
			return cb_init_Lorg_apache_cordova_CordovaWebView_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_;
		}

		static void n_Init_Lorg_apache_cordova_CordovaWebView_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.CordovaWebView p0 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.CordovaWebViewClient p1 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebViewClient> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.CordovaChromeClient p2 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaChromeClient> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_init_Lorg_apache_cordova_CordovaWebView_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='init' and count(parameter)=3 and parameter[1][@type='org.apache.cordova.CordovaWebView'] and parameter[2][@type='org.apache.cordova.CordovaWebViewClient'] and parameter[3][@type='org.apache.cordova.CordovaChromeClient']]"
		[Register ("init", "(Lorg/apache/cordova/CordovaWebView;Lorg/apache/cordova/CordovaWebViewClient;Lorg/apache/cordova/CordovaChromeClient;)V", "GetInit_Lorg_apache_cordova_CordovaWebView_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_Handler")]
		public virtual void Init (global::Org.Apache.Cordova.CordovaWebView p0, global::Org.Apache.Cordova.CordovaWebViewClient p1, global::Org.Apache.Cordova.CordovaChromeClient p2)
		{
			if (id_init_Lorg_apache_cordova_CordovaWebView_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_ == IntPtr.Zero)
				id_init_Lorg_apache_cordova_CordovaWebView_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_ = JNIEnv.GetMethodID (class_ref, "init", "(Lorg/apache/cordova/CordovaWebView;Lorg/apache/cordova/CordovaWebViewClient;Lorg/apache/cordova/CordovaChromeClient;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_init_Lorg_apache_cordova_CordovaWebView_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Lorg/apache/cordova/CordovaWebView;Lorg/apache/cordova/CordovaWebViewClient;Lorg/apache/cordova/CordovaChromeClient;)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_isUrlWhiteListed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsUrlWhiteListed_Ljava_lang_String_Handler ()
		{
			if (cb_isUrlWhiteListed_Ljava_lang_String_ == null)
				cb_isUrlWhiteListed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsUrlWhiteListed_Ljava_lang_String_);
			return cb_isUrlWhiteListed_Ljava_lang_String_;
		}

		static bool n_IsUrlWhiteListed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsUrlWhiteListed (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isUrlWhiteListed_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='isUrlWhiteListed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isUrlWhiteListed", "(Ljava/lang/String;)Z", "GetIsUrlWhiteListed_Ljava_lang_String_Handler")]
		public virtual bool IsUrlWhiteListed (string p0)
		{
			if (id_isUrlWhiteListed_Ljava_lang_String_ == IntPtr.Zero)
				id_isUrlWhiteListed_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isUrlWhiteListed", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_isUrlWhiteListed_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUrlWhiteListed", "(Ljava/lang/String;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_loadConfig;
#pragma warning disable 0169
		static Delegate GetLoadConfigHandler ()
		{
			if (cb_loadConfig == null)
				cb_loadConfig = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LoadConfig);
			return cb_loadConfig;
		}

		static void n_LoadConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadConfig ();
		}
#pragma warning restore 0169

		static IntPtr id_loadConfig;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='loadConfig' and count(parameter)=0]"
		[Register ("loadConfig", "()V", "GetLoadConfigHandler")]
		protected virtual void LoadConfig ()
		{
			if (id_loadConfig == IntPtr.Zero)
				id_loadConfig = JNIEnv.GetMethodID (class_ref, "loadConfig", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadConfig);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadConfig", "()V"));
		}

		static Delegate cb_loadUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadUrl_Ljava_lang_String_Handler ()
		{
			if (cb_loadUrl_Ljava_lang_String_ == null)
				cb_loadUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadUrl_Ljava_lang_String_);
			return cb_loadUrl_Ljava_lang_String_;
		}

		static void n_LoadUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadUrl (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='loadUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadUrl", "(Ljava/lang/String;)V", "GetLoadUrl_Ljava_lang_String_Handler")]
		public virtual void LoadUrl (string p0)
		{
			if (id_loadUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_loadUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadUrl", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadUrl_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadUrl", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_loadUrl_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetLoadUrl_Ljava_lang_String_IHandler ()
		{
			if (cb_loadUrl_Ljava_lang_String_I == null)
				cb_loadUrl_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_LoadUrl_Ljava_lang_String_I);
			return cb_loadUrl_Ljava_lang_String_I;
		}

		static void n_LoadUrl_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadUrl (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_loadUrl_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='loadUrl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("loadUrl", "(Ljava/lang/String;I)V", "GetLoadUrl_Ljava_lang_String_IHandler")]
		public virtual void LoadUrl (string p0, int p1)
		{
			if (id_loadUrl_Ljava_lang_String_I == IntPtr.Zero)
				id_loadUrl_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "loadUrl", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadUrl_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadUrl", "(Ljava/lang/String;I)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_makeChromeClient_Lorg_apache_cordova_CordovaWebView_;
#pragma warning disable 0169
		static Delegate GetMakeChromeClient_Lorg_apache_cordova_CordovaWebView_Handler ()
		{
			if (cb_makeChromeClient_Lorg_apache_cordova_CordovaWebView_ == null)
				cb_makeChromeClient_Lorg_apache_cordova_CordovaWebView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MakeChromeClient_Lorg_apache_cordova_CordovaWebView_);
			return cb_makeChromeClient_Lorg_apache_cordova_CordovaWebView_;
		}

		static IntPtr n_MakeChromeClient_Lorg_apache_cordova_CordovaWebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.CordovaWebView p0 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MakeChromeClient (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_makeChromeClient_Lorg_apache_cordova_CordovaWebView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='makeChromeClient' and count(parameter)=1 and parameter[1][@type='org.apache.cordova.CordovaWebView']]"
		[Register ("makeChromeClient", "(Lorg/apache/cordova/CordovaWebView;)Lorg/apache/cordova/CordovaChromeClient;", "GetMakeChromeClient_Lorg_apache_cordova_CordovaWebView_Handler")]
		protected virtual global::Org.Apache.Cordova.CordovaChromeClient MakeChromeClient (global::Org.Apache.Cordova.CordovaWebView p0)
		{
			if (id_makeChromeClient_Lorg_apache_cordova_CordovaWebView_ == IntPtr.Zero)
				id_makeChromeClient_Lorg_apache_cordova_CordovaWebView_ = JNIEnv.GetMethodID (class_ref, "makeChromeClient", "(Lorg/apache/cordova/CordovaWebView;)Lorg/apache/cordova/CordovaChromeClient;");

			global::Org.Apache.Cordova.CordovaChromeClient __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaChromeClient> (JNIEnv.CallObjectMethod  (Handle, id_makeChromeClient_Lorg_apache_cordova_CordovaWebView_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaChromeClient> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "makeChromeClient", "(Lorg/apache/cordova/CordovaWebView;)Lorg/apache/cordova/CordovaChromeClient;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_makeWebView;
#pragma warning disable 0169
		static Delegate GetMakeWebViewHandler ()
		{
			if (cb_makeWebView == null)
				cb_makeWebView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_MakeWebView);
			return cb_makeWebView;
		}

		static IntPtr n_MakeWebView (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MakeWebView ());
		}
#pragma warning restore 0169

		static IntPtr id_makeWebView;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='makeWebView' and count(parameter)=0]"
		[Register ("makeWebView", "()Lorg/apache/cordova/CordovaWebView;", "GetMakeWebViewHandler")]
		protected virtual global::Org.Apache.Cordova.CordovaWebView MakeWebView ()
		{
			if (id_makeWebView == IntPtr.Zero)
				id_makeWebView = JNIEnv.GetMethodID (class_ref, "makeWebView", "()Lorg/apache/cordova/CordovaWebView;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (JNIEnv.CallObjectMethod  (Handle, id_makeWebView), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "makeWebView", "()Lorg/apache/cordova/CordovaWebView;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_makeWebViewClient_Lorg_apache_cordova_CordovaWebView_;
#pragma warning disable 0169
		static Delegate GetMakeWebViewClient_Lorg_apache_cordova_CordovaWebView_Handler ()
		{
			if (cb_makeWebViewClient_Lorg_apache_cordova_CordovaWebView_ == null)
				cb_makeWebViewClient_Lorg_apache_cordova_CordovaWebView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MakeWebViewClient_Lorg_apache_cordova_CordovaWebView_);
			return cb_makeWebViewClient_Lorg_apache_cordova_CordovaWebView_;
		}

		static IntPtr n_MakeWebViewClient_Lorg_apache_cordova_CordovaWebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.CordovaWebView p0 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MakeWebViewClient (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_makeWebViewClient_Lorg_apache_cordova_CordovaWebView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='makeWebViewClient' and count(parameter)=1 and parameter[1][@type='org.apache.cordova.CordovaWebView']]"
		[Register ("makeWebViewClient", "(Lorg/apache/cordova/CordovaWebView;)Lorg/apache/cordova/CordovaWebViewClient;", "GetMakeWebViewClient_Lorg_apache_cordova_CordovaWebView_Handler")]
		protected virtual global::Org.Apache.Cordova.CordovaWebViewClient MakeWebViewClient (global::Org.Apache.Cordova.CordovaWebView p0)
		{
			if (id_makeWebViewClient_Lorg_apache_cordova_CordovaWebView_ == IntPtr.Zero)
				id_makeWebViewClient_Lorg_apache_cordova_CordovaWebView_ = JNIEnv.GetMethodID (class_ref, "makeWebViewClient", "(Lorg/apache/cordova/CordovaWebView;)Lorg/apache/cordova/CordovaWebViewClient;");

			global::Org.Apache.Cordova.CordovaWebViewClient __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebViewClient> (JNIEnv.CallObjectMethod  (Handle, id_makeWebViewClient_Lorg_apache_cordova_CordovaWebView_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebViewClient> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "makeWebViewClient", "(Lorg/apache/cordova/CordovaWebView;)Lorg/apache/cordova/CordovaWebViewClient;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_onCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public virtual void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onCreate_Landroid_os_Bundle_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "(Landroid/os/Bundle;)V"), new JValue (p0));
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onDestroy);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDestroy", "()V"));
		}

		static Delegate cb_onMessage_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnMessage_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_onMessage_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_onMessage_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMessage_Ljava_lang_String_Ljava_lang_Object_);
			return cb_onMessage_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_OnMessage_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnMessage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onMessage_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='onMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("onMessage", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", "GetOnMessage_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual global::Java.Lang.Object OnMessage (string p0, global::Java.Lang.Object p1)
		{
			if (id_onMessage_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_onMessage_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onMessage", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_onMessage_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMessage", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_onReceivedError_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnReceivedError_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onReceivedError_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_onReceivedError_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnReceivedError_ILjava_lang_String_Ljava_lang_String_);
			return cb_onReceivedError_ILjava_lang_String_Ljava_lang_String_;
		}

		static void n_OnReceivedError_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnReceivedError (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onReceivedError_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='onReceivedError' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("onReceivedError", "(ILjava/lang/String;Ljava/lang/String;)V", "GetOnReceivedError_ILjava_lang_String_Ljava_lang_String_Handler")]
		public virtual void OnReceivedError (int p0, string p1, string p2)
		{
			if (id_onReceivedError_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onReceivedError_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onReceivedError", "(ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onReceivedError_ILjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceivedError", "(ILjava/lang/String;Ljava/lang/String;)V"), new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_postMessage_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPostMessage_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_postMessage_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_postMessage_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PostMessage_Ljava_lang_String_Ljava_lang_Object_);
			return cb_postMessage_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_PostMessage_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PostMessage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_postMessage_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='postMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("postMessage", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetPostMessage_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual void PostMessage (string p0, global::Java.Lang.Object p1)
		{
			if (id_postMessage_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_postMessage_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "postMessage", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_postMessage_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postMessage", "(Ljava/lang/String;Ljava/lang/Object;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveAuthenticationToken (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeAuthenticationToken_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='removeAuthenticationToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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

		static Delegate cb_removeSplashScreen;
#pragma warning disable 0169
		static Delegate GetRemoveSplashScreenHandler ()
		{
			if (cb_removeSplashScreen == null)
				cb_removeSplashScreen = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveSplashScreen);
			return cb_removeSplashScreen;
		}

		static void n_RemoveSplashScreen (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSplashScreen ();
		}
#pragma warning restore 0169

		static IntPtr id_removeSplashScreen;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='removeSplashScreen' and count(parameter)=0]"
		[Register ("removeSplashScreen", "()V", "GetRemoveSplashScreenHandler")]
		public virtual void RemoveSplashScreen ()
		{
			if (id_removeSplashScreen == IntPtr.Zero)
				id_removeSplashScreen = JNIEnv.GetMethodID (class_ref, "removeSplashScreen", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeSplashScreen);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeSplashScreen", "()V"));
		}

		static Delegate cb_sendJavascript_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendJavascript_Ljava_lang_String_Handler ()
		{
			if (cb_sendJavascript_Ljava_lang_String_ == null)
				cb_sendJavascript_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendJavascript_Ljava_lang_String_);
			return cb_sendJavascript_Ljava_lang_String_;
		}

		static void n_SendJavascript_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendJavascript (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendJavascript_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='sendJavascript' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendJavascript", "(Ljava/lang/String;)V", "GetSendJavascript_Ljava_lang_String_Handler")]
		public virtual void SendJavascript (string p0)
		{
			if (id_sendJavascript_Ljava_lang_String_ == IntPtr.Zero)
				id_sendJavascript_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendJavascript", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sendJavascript_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendJavascript", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setActivityResultCallback_Lorg_apache_cordova_CordovaPlugin_;
#pragma warning disable 0169
		static Delegate GetSetActivityResultCallback_Lorg_apache_cordova_CordovaPlugin_Handler ()
		{
			if (cb_setActivityResultCallback_Lorg_apache_cordova_CordovaPlugin_ == null)
				cb_setActivityResultCallback_Lorg_apache_cordova_CordovaPlugin_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActivityResultCallback_Lorg_apache_cordova_CordovaPlugin_);
			return cb_setActivityResultCallback_Lorg_apache_cordova_CordovaPlugin_;
		}

		static void n_SetActivityResultCallback_Lorg_apache_cordova_CordovaPlugin_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.CordovaPlugin p0 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetActivityResultCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setActivityResultCallback_Lorg_apache_cordova_CordovaPlugin_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='setActivityResultCallback' and count(parameter)=1 and parameter[1][@type='org.apache.cordova.CordovaPlugin']]"
		[Register ("setActivityResultCallback", "(Lorg/apache/cordova/CordovaPlugin;)V", "GetSetActivityResultCallback_Lorg_apache_cordova_CordovaPlugin_Handler")]
		public virtual void SetActivityResultCallback (global::Org.Apache.Cordova.CordovaPlugin p0)
		{
			if (id_setActivityResultCallback_Lorg_apache_cordova_CordovaPlugin_ == IntPtr.Zero)
				id_setActivityResultCallback_Lorg_apache_cordova_CordovaPlugin_ = JNIEnv.GetMethodID (class_ref, "setActivityResultCallback", "(Lorg/apache/cordova/CordovaPlugin;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setActivityResultCallback_Lorg_apache_cordova_CordovaPlugin_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActivityResultCallback", "(Lorg/apache/cordova/CordovaPlugin;)V"), new JValue (p0));
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
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.AuthenticationToken p0 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.AuthenticationToken> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetAuthenticationToken (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setAuthenticationToken_Lorg_apache_cordova_AuthenticationToken_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='setAuthenticationToken' and count(parameter)=3 and parameter[1][@type='org.apache.cordova.AuthenticationToken'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
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

		static Delegate cb_setBooleanProperty_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetBooleanProperty_Ljava_lang_String_ZHandler ()
		{
			if (cb_setBooleanProperty_Ljava_lang_String_Z == null)
				cb_setBooleanProperty_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetBooleanProperty_Ljava_lang_String_Z);
			return cb_setBooleanProperty_Ljava_lang_String_Z;
		}

		static void n_SetBooleanProperty_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBooleanProperty (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setBooleanProperty_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='setBooleanProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("setBooleanProperty", "(Ljava/lang/String;Z)V", "GetSetBooleanProperty_Ljava_lang_String_ZHandler")]
		public virtual void SetBooleanProperty (string p0, bool p1)
		{
			if (id_setBooleanProperty_Ljava_lang_String_Z == IntPtr.Zero)
				id_setBooleanProperty_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "setBooleanProperty", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setBooleanProperty_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBooleanProperty", "(Ljava/lang/String;Z)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setDoubleProperty_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetSetDoubleProperty_Ljava_lang_String_DHandler ()
		{
			if (cb_setDoubleProperty_Ljava_lang_String_D == null)
				cb_setDoubleProperty_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double>) n_SetDoubleProperty_Ljava_lang_String_D);
			return cb_setDoubleProperty_Ljava_lang_String_D;
		}

		static void n_SetDoubleProperty_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDoubleProperty (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setDoubleProperty_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='setDoubleProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("setDoubleProperty", "(Ljava/lang/String;D)V", "GetSetDoubleProperty_Ljava_lang_String_DHandler")]
		public virtual void SetDoubleProperty (string p0, double p1)
		{
			if (id_setDoubleProperty_Ljava_lang_String_D == IntPtr.Zero)
				id_setDoubleProperty_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "setDoubleProperty", "(Ljava/lang/String;D)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setDoubleProperty_Ljava_lang_String_D, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDoubleProperty", "(Ljava/lang/String;D)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setIntegerProperty_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetIntegerProperty_Ljava_lang_String_IHandler ()
		{
			if (cb_setIntegerProperty_Ljava_lang_String_I == null)
				cb_setIntegerProperty_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetIntegerProperty_Ljava_lang_String_I);
			return cb_setIntegerProperty_Ljava_lang_String_I;
		}

		static void n_SetIntegerProperty_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIntegerProperty (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setIntegerProperty_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='setIntegerProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setIntegerProperty", "(Ljava/lang/String;I)V", "GetSetIntegerProperty_Ljava_lang_String_IHandler")]
		public virtual void SetIntegerProperty (string p0, int p1)
		{
			if (id_setIntegerProperty_Ljava_lang_String_I == IntPtr.Zero)
				id_setIntegerProperty_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setIntegerProperty", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setIntegerProperty_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIntegerProperty", "(Ljava/lang/String;I)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setStringProperty_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStringProperty_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setStringProperty_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setStringProperty_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetStringProperty_Ljava_lang_String_Ljava_lang_String_);
			return cb_setStringProperty_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetStringProperty_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetStringProperty (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setStringProperty_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='setStringProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setStringProperty", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetStringProperty_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void SetStringProperty (string p0, string p1)
		{
			if (id_setStringProperty_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setStringProperty_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStringProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setStringProperty_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStringProperty", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_showSplashScreen_I;
#pragma warning disable 0169
		static Delegate GetShowSplashScreen_IHandler ()
		{
			if (cb_showSplashScreen_I == null)
				cb_showSplashScreen_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_ShowSplashScreen_I);
			return cb_showSplashScreen_I;
		}

		static void n_ShowSplashScreen_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowSplashScreen (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showSplashScreen_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='showSplashScreen' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("showSplashScreen", "(I)V", "GetShowSplashScreen_IHandler")]
		protected virtual void ShowSplashScreen (int p0)
		{
			if (id_showSplashScreen_I == IntPtr.Zero)
				id_showSplashScreen_I = JNIEnv.GetMethodID (class_ref, "showSplashScreen", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_showSplashScreen_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showSplashScreen", "(I)V"), new JValue (p0));
		}

		static Delegate cb_showWebPage_Ljava_lang_String_ZZLjava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetShowWebPage_Ljava_lang_String_ZZLjava_util_HashMap_Handler ()
		{
			if (cb_showWebPage_Ljava_lang_String_ZZLjava_util_HashMap_ == null)
				cb_showWebPage_Ljava_lang_String_ZZLjava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, bool, IntPtr>) n_ShowWebPage_Ljava_lang_String_ZZLjava_util_HashMap_);
			return cb_showWebPage_Ljava_lang_String_ZZLjava_util_HashMap_;
		}

		static void n_ShowWebPage_Ljava_lang_String_ZZLjava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, bool p2, IntPtr native_p3)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, Java.Lang.Object> p3 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.ShowWebPage (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_showWebPage_Ljava_lang_String_ZZLjava_util_HashMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='showWebPage' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='java.util.HashMap']]"
		[Register ("showWebPage", "(Ljava/lang/String;ZZLjava/util/HashMap;)V", "GetShowWebPage_Ljava_lang_String_ZZLjava_util_HashMap_Handler")]
		public virtual void ShowWebPage (string p0, bool p1, bool p2, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p3)
		{
			if (id_showWebPage_Ljava_lang_String_ZZLjava_util_HashMap_ == IntPtr.Zero)
				id_showWebPage_Ljava_lang_String_ZZLjava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "showWebPage", "(Ljava/lang/String;ZZLjava/util/HashMap;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p3);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_showWebPage_Ljava_lang_String_ZZLjava_util_HashMap_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (native_p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showWebPage", "(Ljava/lang/String;ZZLjava/util/HashMap;)V"), new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_spinnerStart_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSpinnerStart_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_spinnerStart_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_spinnerStart_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SpinnerStart_Ljava_lang_String_Ljava_lang_String_);
			return cb_spinnerStart_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SpinnerStart_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SpinnerStart (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_spinnerStart_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='spinnerStart' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("spinnerStart", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSpinnerStart_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void SpinnerStart (string p0, string p1)
		{
			if (id_spinnerStart_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_spinnerStart_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "spinnerStart", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_spinnerStart_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "spinnerStart", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_spinnerStop;
#pragma warning disable 0169
		static Delegate GetSpinnerStopHandler ()
		{
			if (cb_spinnerStop == null)
				cb_spinnerStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SpinnerStop);
			return cb_spinnerStop;
		}

		static void n_SpinnerStop (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SpinnerStop ();
		}
#pragma warning restore 0169

		static IntPtr id_spinnerStop;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='spinnerStop' and count(parameter)=0]"
		[Register ("spinnerStop", "()V", "GetSpinnerStopHandler")]
		public virtual void SpinnerStop ()
		{
			if (id_spinnerStop == IntPtr.Zero)
				id_spinnerStop = JNIEnv.GetMethodID (class_ref, "spinnerStop", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_spinnerStop);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "spinnerStop", "()V"));
		}

		static Delegate cb_startActivityForResult_Lorg_apache_cordova_CordovaPlugin_Landroid_content_Intent_I;
#pragma warning disable 0169
		static Delegate GetStartActivityForResult_Lorg_apache_cordova_CordovaPlugin_Landroid_content_Intent_IHandler ()
		{
			if (cb_startActivityForResult_Lorg_apache_cordova_CordovaPlugin_Landroid_content_Intent_I == null)
				cb_startActivityForResult_Lorg_apache_cordova_CordovaPlugin_Landroid_content_Intent_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_StartActivityForResult_Lorg_apache_cordova_CordovaPlugin_Landroid_content_Intent_I);
			return cb_startActivityForResult_Lorg_apache_cordova_CordovaPlugin_Landroid_content_Intent_I;
		}

		static void n_StartActivityForResult_Lorg_apache_cordova_CordovaPlugin_Landroid_content_Intent_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Org.Apache.Cordova.CordovaActivity __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.CordovaPlugin p0 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartActivityForResult (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_startActivityForResult_Lorg_apache_cordova_CordovaPlugin_Landroid_content_Intent_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaActivity']/method[@name='startActivityForResult' and count(parameter)=3 and parameter[1][@type='org.apache.cordova.CordovaPlugin'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='int']]"
		[Register ("startActivityForResult", "(Lorg/apache/cordova/CordovaPlugin;Landroid/content/Intent;I)V", "GetStartActivityForResult_Lorg_apache_cordova_CordovaPlugin_Landroid_content_Intent_IHandler")]
		public virtual void StartActivityForResult (global::Org.Apache.Cordova.CordovaPlugin p0, global::Android.Content.Intent p1, int p2)
		{
			if (id_startActivityForResult_Lorg_apache_cordova_CordovaPlugin_Landroid_content_Intent_I == IntPtr.Zero)
				id_startActivityForResult_Lorg_apache_cordova_CordovaPlugin_Landroid_content_Intent_I = JNIEnv.GetMethodID (class_ref, "startActivityForResult", "(Lorg/apache/cordova/CordovaPlugin;Landroid/content/Intent;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_startActivityForResult_Lorg_apache_cordova_CordovaPlugin_Landroid_content_Intent_I, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startActivityForResult", "(Lorg/apache/cordova/CordovaPlugin;Landroid/content/Intent;I)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}
}
