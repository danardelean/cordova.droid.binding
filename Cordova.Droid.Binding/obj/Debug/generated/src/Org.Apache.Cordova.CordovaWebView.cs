using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']"
	[global::Android.Runtime.Register ("org/apache/cordova/CordovaWebView", DoNotGenerateAcw=true)]
	public partial class CordovaWebView : global::Android.Webkit.WebView {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/field[@name='CORDOVA_VERSION']"
		[Register ("CORDOVA_VERSION")]
		public const string CordovaVersion = (string) "3.7.0-dev";

		static IntPtr pluginManager_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/field[@name='pluginManager']"
		[Register ("pluginManager")]
		public global::Org.Apache.Cordova.PluginManager PluginManager {
			get {
				if (pluginManager_jfieldId == IntPtr.Zero)
					pluginManager_jfieldId = JNIEnv.GetFieldID (class_ref, "pluginManager", "Lorg/apache/cordova/PluginManager;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, pluginManager_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginManager> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (pluginManager_jfieldId == IntPtr.Zero)
					pluginManager_jfieldId = JNIEnv.GetFieldID (class_ref, "pluginManager", "Lorg/apache/cordova/PluginManager;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, pluginManager_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView.ActivityResult']"
		[global::Android.Runtime.Register ("org/apache/cordova/CordovaWebView$ActivityResult", DoNotGenerateAcw=true)]
		public partial class ActivityResult : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/apache/cordova/CordovaWebView$ActivityResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ActivityResult); }
			}

			protected ActivityResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_apache_cordova_CordovaWebView_IILandroid_content_Intent_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView.ActivityResult']/constructor[@name='CordovaWebView.ActivityResult' and count(parameter)=4 and parameter[1][@type='org.apache.cordova.CordovaWebView'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.content.Intent']]"
			[Register (".ctor", "(Lorg/apache/cordova/CordovaWebView;IILandroid/content/Intent;)V", "")]
			public ActivityResult (global::Org.Apache.Cordova.CordovaWebView __self, int p1, int p2, global::Android.Content.Intent p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ActivityResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IILandroid/content/Intent;)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IILandroid/content/Intent;)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3));
					return;
				}

				if (id_ctor_Lorg_apache_cordova_CordovaWebView_IILandroid_content_Intent_ == IntPtr.Zero)
					id_ctor_Lorg_apache_cordova_CordovaWebView_IILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/cordova/CordovaWebView;IILandroid/content/Intent;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_cordova_CordovaWebView_IILandroid_content_Intent_, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_cordova_CordovaWebView_IILandroid_content_Intent_, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView.Level16Apis']"
		[global::Android.Runtime.Register ("org/apache/cordova/CordovaWebView$Level16Apis", DoNotGenerateAcw=true)]
		public partial class Level16Apis : global::Java.Lang.Object {

			protected Level16Apis (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/CordovaWebView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CordovaWebView); }
		}

		protected CordovaWebView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/constructor[@name='CordovaWebView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public CordovaWebView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CordovaWebView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/constructor[@name='CordovaWebView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public CordovaWebView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CordovaWebView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_IZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/constructor[@name='CordovaWebView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;IZ)V", "")]
		public CordovaWebView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2, bool p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CordovaWebView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;IZ)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;IZ)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_IZ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_IZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;IZ)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_IZ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_IZ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/constructor[@name='CordovaWebView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public CordovaWebView (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CordovaWebView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_getExternalWhitelist;
#pragma warning disable 0169
		static Delegate GetGetExternalWhitelistHandler ()
		{
			if (cb_getExternalWhitelist == null)
				cb_getExternalWhitelist = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExternalWhitelist);
			return cb_getExternalWhitelist;
		}

		static IntPtr n_GetExternalWhitelist (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExternalWhitelist);
		}
#pragma warning restore 0169

		static IntPtr id_getExternalWhitelist;
		public virtual global::Org.Apache.Cordova.Whitelist ExternalWhitelist {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='getExternalWhitelist' and count(parameter)=0]"
			[Register ("getExternalWhitelist", "()Lorg/apache/cordova/Whitelist;", "GetGetExternalWhitelistHandler")]
			get {
				if (id_getExternalWhitelist == IntPtr.Zero)
					id_getExternalWhitelist = JNIEnv.GetMethodID (class_ref, "getExternalWhitelist", "()Lorg/apache/cordova/Whitelist;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.Whitelist> (JNIEnv.CallObjectMethod  (Handle, id_getExternalWhitelist), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.Whitelist> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExternalWhitelist", "()Lorg/apache/cordova/Whitelist;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isBackButtonBound;
#pragma warning disable 0169
		static Delegate GetIsBackButtonBoundHandler ()
		{
			if (cb_isBackButtonBound == null)
				cb_isBackButtonBound = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBackButtonBound);
			return cb_isBackButtonBound;
		}

		static bool n_IsBackButtonBound (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBackButtonBound;
		}
#pragma warning restore 0169

		static IntPtr id_isBackButtonBound;
		[Obsolete (@"deprecated")]
		public virtual bool IsBackButtonBound {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='isBackButtonBound' and count(parameter)=0]"
			[Register ("isBackButtonBound", "()Z", "GetIsBackButtonBoundHandler")]
			get {
				if (id_isBackButtonBound == IntPtr.Zero)
					id_isBackButtonBound = JNIEnv.GetMethodID (class_ref, "isBackButtonBound", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isBackButtonBound);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBackButtonBound", "()Z"));
			}
		}

		static Delegate cb_isCustomViewShowing;
#pragma warning disable 0169
		static Delegate GetIsCustomViewShowingHandler ()
		{
			if (cb_isCustomViewShowing == null)
				cb_isCustomViewShowing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCustomViewShowing);
			return cb_isCustomViewShowing;
		}

		static bool n_IsCustomViewShowing (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCustomViewShowing;
		}
#pragma warning restore 0169

		static IntPtr id_isCustomViewShowing;
		public virtual bool IsCustomViewShowing {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='isCustomViewShowing' and count(parameter)=0]"
			[Register ("isCustomViewShowing", "()Z", "GetIsCustomViewShowingHandler")]
			get {
				if (id_isCustomViewShowing == IntPtr.Zero)
					id_isCustomViewShowing = JNIEnv.GetMethodID (class_ref, "isCustomViewShowing", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isCustomViewShowing);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCustomViewShowing", "()Z"));
			}
		}

		static Delegate cb_isPaused;
#pragma warning disable 0169
		static Delegate GetIsPausedHandler ()
		{
			if (cb_isPaused == null)
				cb_isPaused = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPaused);
			return cb_isPaused;
		}

		static bool n_IsPaused (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPaused;
		}
#pragma warning restore 0169

		static IntPtr id_isPaused;
		public virtual bool IsPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='isPaused' and count(parameter)=0]"
			[Register ("isPaused", "()Z", "GetIsPausedHandler")]
			get {
				if (id_isPaused == IntPtr.Zero)
					id_isPaused = JNIEnv.GetMethodID (class_ref, "isPaused", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isPaused);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPaused", "()Z"));
			}
		}

		static Delegate cb_getPreferences;
#pragma warning disable 0169
		static Delegate GetGetPreferencesHandler ()
		{
			if (cb_getPreferences == null)
				cb_getPreferences = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPreferences);
			return cb_getPreferences;
		}

		static IntPtr n_GetPreferences (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Preferences);
		}
#pragma warning restore 0169

		static IntPtr id_getPreferences;
		public virtual global::Org.Apache.Cordova.CordovaPreferences Preferences {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='getPreferences' and count(parameter)=0]"
			[Register ("getPreferences", "()Lorg/apache/cordova/CordovaPreferences;", "GetGetPreferencesHandler")]
			get {
				if (id_getPreferences == IntPtr.Zero)
					id_getPreferences = JNIEnv.GetMethodID (class_ref, "getPreferences", "()Lorg/apache/cordova/CordovaPreferences;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPreferences> (JNIEnv.CallObjectMethod  (Handle, id_getPreferences), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPreferences> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreferences", "()Lorg/apache/cordova/CordovaPreferences;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getResourceApi;
#pragma warning disable 0169
		static Delegate GetGetResourceApiHandler ()
		{
			if (cb_getResourceApi == null)
				cb_getResourceApi = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResourceApi);
			return cb_getResourceApi;
		}

		static IntPtr n_GetResourceApi (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResourceApi);
		}
#pragma warning restore 0169

		static IntPtr id_getResourceApi;
		public virtual global::Org.Apache.Cordova.CordovaResourceApi ResourceApi {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='getResourceApi' and count(parameter)=0]"
			[Register ("getResourceApi", "()Lorg/apache/cordova/CordovaResourceApi;", "GetGetResourceApiHandler")]
			get {
				if (id_getResourceApi == IntPtr.Zero)
					id_getResourceApi = JNIEnv.GetMethodID (class_ref, "getResourceApi", "()Lorg/apache/cordova/CordovaResourceApi;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaResourceApi> (JNIEnv.CallObjectMethod  (Handle, id_getResourceApi), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaResourceApi> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResourceApi", "()Lorg/apache/cordova/CordovaResourceApi;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getWebChromeClient;
#pragma warning disable 0169
		static Delegate GetGetWebChromeClientHandler ()
		{
			if (cb_getWebChromeClient == null)
				cb_getWebChromeClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWebChromeClient);
			return cb_getWebChromeClient;
		}

		static IntPtr n_GetWebChromeClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WebChromeClient);
		}
#pragma warning restore 0169

		static IntPtr id_getWebChromeClient;
		public virtual global::Org.Apache.Cordova.CordovaChromeClient WebChromeClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='getWebChromeClient' and count(parameter)=0]"
			[Register ("getWebChromeClient", "()Lorg/apache/cordova/CordovaChromeClient;", "GetGetWebChromeClientHandler")]
			get {
				if (id_getWebChromeClient == IntPtr.Zero)
					id_getWebChromeClient = JNIEnv.GetMethodID (class_ref, "getWebChromeClient", "()Lorg/apache/cordova/CordovaChromeClient;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaChromeClient> (JNIEnv.CallObjectMethod  (Handle, id_getWebChromeClient), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaChromeClient> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWebChromeClient", "()Lorg/apache/cordova/CordovaChromeClient;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getWhitelist;
#pragma warning disable 0169
		static Delegate GetGetWhitelistHandler ()
		{
			if (cb_getWhitelist == null)
				cb_getWhitelist = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWhitelist);
			return cb_getWhitelist;
		}

		static IntPtr n_GetWhitelist (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Whitelist);
		}
#pragma warning restore 0169

		static IntPtr id_getWhitelist;
		public virtual global::Org.Apache.Cordova.Whitelist Whitelist {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='getWhitelist' and count(parameter)=0]"
			[Register ("getWhitelist", "()Lorg/apache/cordova/Whitelist;", "GetGetWhitelistHandler")]
			get {
				if (id_getWhitelist == IntPtr.Zero)
					id_getWhitelist = JNIEnv.GetMethodID (class_ref, "getWhitelist", "()Lorg/apache/cordova/Whitelist;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.Whitelist> (JNIEnv.CallObjectMethod  (Handle, id_getWhitelist), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.Whitelist> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWhitelist", "()Lorg/apache/cordova/Whitelist;")), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackHistory ();
		}
#pragma warning restore 0169

		static IntPtr id_backHistory;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='backHistory' and count(parameter)=0]"
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

		static Delegate cb_bindButton_Z;
#pragma warning disable 0169
		static Delegate GetBindButton_ZHandler ()
		{
			if (cb_bindButton_Z == null)
				cb_bindButton_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_BindButton_Z);
			return cb_bindButton_Z;
		}

		static void n_BindButton_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BindButton (p0);
		}
#pragma warning restore 0169

		static IntPtr id_bindButton_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='bindButton' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("bindButton", "(Z)V", "GetBindButton_ZHandler")]
		public virtual void BindButton (bool p0)
		{
			if (id_bindButton_Z == IntPtr.Zero)
				id_bindButton_Z = JNIEnv.GetMethodID (class_ref, "bindButton", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_bindButton_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindButton", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_bindButton_IZZ;
#pragma warning disable 0169
		static Delegate GetBindButton_IZZHandler ()
		{
			if (cb_bindButton_IZZ == null)
				cb_bindButton_IZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool, bool>) n_BindButton_IZZ);
			return cb_bindButton_IZZ;
		}

		static void n_BindButton_IZZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1, bool p2)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BindButton (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_bindButton_IZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='bindButton' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("bindButton", "(IZZ)V", "GetBindButton_IZZHandler")]
		public virtual void BindButton (int p0, bool p1, bool p2)
		{
			if (id_bindButton_IZZ == IntPtr.Zero)
				id_bindButton_IZZ = JNIEnv.GetMethodID (class_ref, "bindButton", "(IZZ)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_bindButton_IZZ, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindButton", "(IZZ)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_bindButton_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetBindButton_Ljava_lang_String_ZHandler ()
		{
			if (cb_bindButton_Ljava_lang_String_Z == null)
				cb_bindButton_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_BindButton_Ljava_lang_String_Z);
			return cb_bindButton_Ljava_lang_String_Z;
		}

		static void n_BindButton_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BindButton (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_bindButton_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='bindButton' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("bindButton", "(Ljava/lang/String;Z)V", "GetBindButton_Ljava_lang_String_ZHandler")]
		public virtual void BindButton (string p0, bool p1)
		{
			if (id_bindButton_Ljava_lang_String_Z == IntPtr.Zero)
				id_bindButton_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "bindButton", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_bindButton_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindButton", "(Ljava/lang/String;Z)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getProperty_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetProperty_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getProperty_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getProperty_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetProperty_Ljava_lang_String_Ljava_lang_String_);
			return cb_getProperty_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetProperty_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetProperty (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getProperty_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='getProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetProperty_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual string GetProperty (string p0, string p1)
		{
			if (id_getProperty_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getProperty_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getProperty_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_hadKeyEvent;
#pragma warning disable 0169
		static Delegate GetHadKeyEventHandler ()
		{
			if (cb_hadKeyEvent == null)
				cb_hadKeyEvent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HadKeyEvent);
			return cb_hadKeyEvent;
		}

		static bool n_HadKeyEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HadKeyEvent ();
		}
#pragma warning restore 0169

		static IntPtr id_hadKeyEvent;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='hadKeyEvent' and count(parameter)=0]"
		[Register ("hadKeyEvent", "()Z", "GetHadKeyEventHandler")]
		public virtual bool HadKeyEvent ()
		{
			if (id_hadKeyEvent == IntPtr.Zero)
				id_hadKeyEvent = JNIEnv.GetMethodID (class_ref, "hadKeyEvent", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_hadKeyEvent);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hadKeyEvent", "()Z"));
		}

		static Delegate cb_handleDestroy;
#pragma warning disable 0169
		static Delegate GetHandleDestroyHandler ()
		{
			if (cb_handleDestroy == null)
				cb_handleDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HandleDestroy);
			return cb_handleDestroy;
		}

		static void n_HandleDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HandleDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_handleDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='handleDestroy' and count(parameter)=0]"
		[Register ("handleDestroy", "()V", "GetHandleDestroyHandler")]
		public virtual void HandleDestroy ()
		{
			if (id_handleDestroy == IntPtr.Zero)
				id_handleDestroy = JNIEnv.GetMethodID (class_ref, "handleDestroy", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_handleDestroy);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleDestroy", "()V"));
		}

		static Delegate cb_handlePause_Z;
#pragma warning disable 0169
		static Delegate GetHandlePause_ZHandler ()
		{
			if (cb_handlePause_Z == null)
				cb_handlePause_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_HandlePause_Z);
			return cb_handlePause_Z;
		}

		static void n_HandlePause_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HandlePause (p0);
		}
#pragma warning restore 0169

		static IntPtr id_handlePause_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='handlePause' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("handlePause", "(Z)V", "GetHandlePause_ZHandler")]
		public virtual void HandlePause (bool p0)
		{
			if (id_handlePause_Z == IntPtr.Zero)
				id_handlePause_Z = JNIEnv.GetMethodID (class_ref, "handlePause", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_handlePause_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handlePause", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_handleResume_ZZ;
#pragma warning disable 0169
		static Delegate GetHandleResume_ZZHandler ()
		{
			if (cb_handleResume_ZZ == null)
				cb_handleResume_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, bool>) n_HandleResume_ZZ);
			return cb_handleResume_ZZ;
		}

		static void n_HandleResume_ZZ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HandleResume (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_handleResume_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='handleResume' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("handleResume", "(ZZ)V", "GetHandleResume_ZZHandler")]
		public virtual void HandleResume (bool p0, bool p1)
		{
			if (id_handleResume_ZZ == IntPtr.Zero)
				id_handleResume_ZZ = JNIEnv.GetMethodID (class_ref, "handleResume", "(ZZ)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_handleResume_ZZ, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleResume", "(ZZ)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_hideCustomView;
#pragma warning disable 0169
		static Delegate GetHideCustomViewHandler ()
		{
			if (cb_hideCustomView == null)
				cb_hideCustomView = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideCustomView);
			return cb_hideCustomView;
		}

		static void n_HideCustomView (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideCustomView ();
		}
#pragma warning restore 0169

		static IntPtr id_hideCustomView;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='hideCustomView' and count(parameter)=0]"
		[Register ("hideCustomView", "()V", "GetHideCustomViewHandler")]
		public virtual void HideCustomView ()
		{
			if (id_hideCustomView == IntPtr.Zero)
				id_hideCustomView = JNIEnv.GetMethodID (class_ref, "hideCustomView", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_hideCustomView);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideCustomView", "()V"));
		}

		static Delegate cb_init_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_Ljava_util_List_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_CordovaPreferences_;
#pragma warning disable 0169
		static Delegate GetInit_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_Ljava_util_List_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_CordovaPreferences_Handler ()
		{
			if (cb_init_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_Ljava_util_List_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_CordovaPreferences_ == null)
				cb_init_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_Ljava_util_List_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_CordovaPreferences_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_Ljava_util_List_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_CordovaPreferences_);
			return cb_init_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_Ljava_util_List_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_CordovaPreferences_;
		}

		static void n_Init_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_Ljava_util_List_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_CordovaPreferences_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.ICordovaInterface p0 = (global::Org.Apache.Cordova.ICordovaInterface)global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ICordovaInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.CordovaWebViewClient p1 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebViewClient> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.CordovaChromeClient p2 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaChromeClient> (native_p2, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Org.Apache.Cordova.PluginEntry> p3 = global::Android.Runtime.JavaList<global::Org.Apache.Cordova.PluginEntry>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.Whitelist p4 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.Whitelist> (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.Whitelist p5 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.Whitelist> (native_p5, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.CordovaPreferences p6 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPreferences> (native_p6, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1, p2, p3, p4, p5, p6);
		}
#pragma warning restore 0169

		static IntPtr id_init_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_Ljava_util_List_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_CordovaPreferences_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='init' and count(parameter)=7 and parameter[1][@type='org.apache.cordova.CordovaInterface'] and parameter[2][@type='org.apache.cordova.CordovaWebViewClient'] and parameter[3][@type='org.apache.cordova.CordovaChromeClient'] and parameter[4][@type='java.util.List'] and parameter[5][@type='org.apache.cordova.Whitelist'] and parameter[6][@type='org.apache.cordova.Whitelist'] and parameter[7][@type='org.apache.cordova.CordovaPreferences']]"
		[Register ("init", "(Lorg/apache/cordova/CordovaInterface;Lorg/apache/cordova/CordovaWebViewClient;Lorg/apache/cordova/CordovaChromeClient;Ljava/util/List;Lorg/apache/cordova/Whitelist;Lorg/apache/cordova/Whitelist;Lorg/apache/cordova/CordovaPreferences;)V", "GetInit_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_Ljava_util_List_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_CordovaPreferences_Handler")]
		public virtual void Init (global::Org.Apache.Cordova.ICordovaInterface p0, global::Org.Apache.Cordova.CordovaWebViewClient p1, global::Org.Apache.Cordova.CordovaChromeClient p2, global::System.Collections.Generic.IList<global::Org.Apache.Cordova.PluginEntry> p3, global::Org.Apache.Cordova.Whitelist p4, global::Org.Apache.Cordova.Whitelist p5, global::Org.Apache.Cordova.CordovaPreferences p6)
		{
			if (id_init_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_Ljava_util_List_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_CordovaPreferences_ == IntPtr.Zero)
				id_init_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_Ljava_util_List_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_CordovaPreferences_ = JNIEnv.GetMethodID (class_ref, "init", "(Lorg/apache/cordova/CordovaInterface;Lorg/apache/cordova/CordovaWebViewClient;Lorg/apache/cordova/CordovaChromeClient;Ljava/util/List;Lorg/apache/cordova/Whitelist;Lorg/apache/cordova/Whitelist;Lorg/apache/cordova/CordovaPreferences;)V");
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::Org.Apache.Cordova.PluginEntry>.ToLocalJniHandle (p3);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_init_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebViewClient_Lorg_apache_cordova_CordovaChromeClient_Ljava_util_List_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_Whitelist_Lorg_apache_cordova_CordovaPreferences_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3), new JValue (p4), new JValue (p5), new JValue (p6));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Lorg/apache/cordova/CordovaInterface;Lorg/apache/cordova/CordovaWebViewClient;Lorg/apache/cordova/CordovaChromeClient;Ljava/util/List;Lorg/apache/cordova/Whitelist;Lorg/apache/cordova/Whitelist;Lorg/apache/cordova/CordovaPreferences;)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3), new JValue (p4), new JValue (p5), new JValue (p6));
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_isButtonPlumbedToJs_I;
#pragma warning disable 0169
		static Delegate GetIsButtonPlumbedToJs_IHandler ()
		{
			if (cb_isButtonPlumbedToJs_I == null)
				cb_isButtonPlumbedToJs_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsButtonPlumbedToJs_I);
			return cb_isButtonPlumbedToJs_I;
		}

		static bool n_IsButtonPlumbedToJs_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsButtonPlumbedToJs (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isButtonPlumbedToJs_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='isButtonPlumbedToJs' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isButtonPlumbedToJs", "(I)Z", "GetIsButtonPlumbedToJs_IHandler")]
		public virtual bool IsButtonPlumbedToJs (int p0)
		{
			if (id_isButtonPlumbedToJs_I == IntPtr.Zero)
				id_isButtonPlumbedToJs_I = JNIEnv.GetMethodID (class_ref, "isButtonPlumbedToJs", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_isButtonPlumbedToJs_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isButtonPlumbedToJs", "(I)Z"), new JValue (p0));
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
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadUrl (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_loadUrl_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='loadUrl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
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

		static Delegate cb_loadUrlIntoView_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadUrlIntoView_Ljava_lang_String_Handler ()
		{
			if (cb_loadUrlIntoView_Ljava_lang_String_ == null)
				cb_loadUrlIntoView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadUrlIntoView_Ljava_lang_String_);
			return cb_loadUrlIntoView_Ljava_lang_String_;
		}

		static void n_LoadUrlIntoView_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadUrlIntoView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadUrlIntoView_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='loadUrlIntoView' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadUrlIntoView", "(Ljava/lang/String;)V", "GetLoadUrlIntoView_Ljava_lang_String_Handler")]
		public virtual void LoadUrlIntoView (string p0)
		{
			if (id_loadUrlIntoView_Ljava_lang_String_ == IntPtr.Zero)
				id_loadUrlIntoView_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadUrlIntoView", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadUrlIntoView_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadUrlIntoView", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_loadUrlIntoView_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetLoadUrlIntoView_Ljava_lang_String_ZHandler ()
		{
			if (cb_loadUrlIntoView_Ljava_lang_String_Z == null)
				cb_loadUrlIntoView_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_LoadUrlIntoView_Ljava_lang_String_Z);
			return cb_loadUrlIntoView_Ljava_lang_String_Z;
		}

		static void n_LoadUrlIntoView_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadUrlIntoView (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_loadUrlIntoView_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='loadUrlIntoView' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("loadUrlIntoView", "(Ljava/lang/String;Z)V", "GetLoadUrlIntoView_Ljava_lang_String_ZHandler")]
		public virtual void LoadUrlIntoView (string p0, bool p1)
		{
			if (id_loadUrlIntoView_Ljava_lang_String_Z == IntPtr.Zero)
				id_loadUrlIntoView_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "loadUrlIntoView", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadUrlIntoView_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadUrlIntoView", "(Ljava/lang/String;Z)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_loadUrlIntoView_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetLoadUrlIntoView_Ljava_lang_String_IHandler ()
		{
			if (cb_loadUrlIntoView_Ljava_lang_String_I == null)
				cb_loadUrlIntoView_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_LoadUrlIntoView_Ljava_lang_String_I);
			return cb_loadUrlIntoView_Ljava_lang_String_I;
		}

		static void n_LoadUrlIntoView_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadUrlIntoView (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_loadUrlIntoView_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='loadUrlIntoView' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("loadUrlIntoView", "(Ljava/lang/String;I)V", "GetLoadUrlIntoView_Ljava_lang_String_IHandler")]
		public virtual void LoadUrlIntoView (string p0, int p1)
		{
			if (id_loadUrlIntoView_Ljava_lang_String_I == IntPtr.Zero)
				id_loadUrlIntoView_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "loadUrlIntoView", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadUrlIntoView_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadUrlIntoView", "(Ljava/lang/String;I)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_makeWebChromeClient_Lorg_apache_cordova_CordovaInterface_;
#pragma warning disable 0169
		static Delegate GetMakeWebChromeClient_Lorg_apache_cordova_CordovaInterface_Handler ()
		{
			if (cb_makeWebChromeClient_Lorg_apache_cordova_CordovaInterface_ == null)
				cb_makeWebChromeClient_Lorg_apache_cordova_CordovaInterface_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MakeWebChromeClient_Lorg_apache_cordova_CordovaInterface_);
			return cb_makeWebChromeClient_Lorg_apache_cordova_CordovaInterface_;
		}

		static IntPtr n_MakeWebChromeClient_Lorg_apache_cordova_CordovaInterface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.ICordovaInterface p0 = (global::Org.Apache.Cordova.ICordovaInterface)global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ICordovaInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MakeWebChromeClient (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_makeWebChromeClient_Lorg_apache_cordova_CordovaInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='makeWebChromeClient' and count(parameter)=1 and parameter[1][@type='org.apache.cordova.CordovaInterface']]"
		[Register ("makeWebChromeClient", "(Lorg/apache/cordova/CordovaInterface;)Lorg/apache/cordova/CordovaChromeClient;", "GetMakeWebChromeClient_Lorg_apache_cordova_CordovaInterface_Handler")]
		public virtual global::Org.Apache.Cordova.CordovaChromeClient MakeWebChromeClient (global::Org.Apache.Cordova.ICordovaInterface p0)
		{
			if (id_makeWebChromeClient_Lorg_apache_cordova_CordovaInterface_ == IntPtr.Zero)
				id_makeWebChromeClient_Lorg_apache_cordova_CordovaInterface_ = JNIEnv.GetMethodID (class_ref, "makeWebChromeClient", "(Lorg/apache/cordova/CordovaInterface;)Lorg/apache/cordova/CordovaChromeClient;");

			global::Org.Apache.Cordova.CordovaChromeClient __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaChromeClient> (JNIEnv.CallObjectMethod  (Handle, id_makeWebChromeClient_Lorg_apache_cordova_CordovaInterface_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaChromeClient> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "makeWebChromeClient", "(Lorg/apache/cordova/CordovaInterface;)Lorg/apache/cordova/CordovaChromeClient;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_makeWebViewClient_Lorg_apache_cordova_CordovaInterface_;
#pragma warning disable 0169
		static Delegate GetMakeWebViewClient_Lorg_apache_cordova_CordovaInterface_Handler ()
		{
			if (cb_makeWebViewClient_Lorg_apache_cordova_CordovaInterface_ == null)
				cb_makeWebViewClient_Lorg_apache_cordova_CordovaInterface_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MakeWebViewClient_Lorg_apache_cordova_CordovaInterface_);
			return cb_makeWebViewClient_Lorg_apache_cordova_CordovaInterface_;
		}

		static IntPtr n_MakeWebViewClient_Lorg_apache_cordova_CordovaInterface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.ICordovaInterface p0 = (global::Org.Apache.Cordova.ICordovaInterface)global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ICordovaInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MakeWebViewClient (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_makeWebViewClient_Lorg_apache_cordova_CordovaInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='makeWebViewClient' and count(parameter)=1 and parameter[1][@type='org.apache.cordova.CordovaInterface']]"
		[Register ("makeWebViewClient", "(Lorg/apache/cordova/CordovaInterface;)Lorg/apache/cordova/CordovaWebViewClient;", "GetMakeWebViewClient_Lorg_apache_cordova_CordovaInterface_Handler")]
		public virtual global::Org.Apache.Cordova.CordovaWebViewClient MakeWebViewClient (global::Org.Apache.Cordova.ICordovaInterface p0)
		{
			if (id_makeWebViewClient_Lorg_apache_cordova_CordovaInterface_ == IntPtr.Zero)
				id_makeWebViewClient_Lorg_apache_cordova_CordovaInterface_ = JNIEnv.GetMethodID (class_ref, "makeWebViewClient", "(Lorg/apache/cordova/CordovaInterface;)Lorg/apache/cordova/CordovaWebViewClient;");

			global::Org.Apache.Cordova.CordovaWebViewClient __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebViewClient> (JNIEnv.CallObjectMethod  (Handle, id_makeWebViewClient_Lorg_apache_cordova_CordovaInterface_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebViewClient> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "makeWebViewClient", "(Lorg/apache/cordova/CordovaInterface;)Lorg/apache/cordova/CordovaWebViewClient;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_onNewIntent_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnNewIntent_Landroid_content_Intent_Handler ()
		{
			if (cb_onNewIntent_Landroid_content_Intent_ == null)
				cb_onNewIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNewIntent_Landroid_content_Intent_);
			return cb_onNewIntent_Landroid_content_Intent_;
		}

		static void n_OnNewIntent_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNewIntent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onNewIntent_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='onNewIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onNewIntent", "(Landroid/content/Intent;)V", "GetOnNewIntent_Landroid_content_Intent_Handler")]
		public virtual void OnNewIntent (global::Android.Content.Intent p0)
		{
			if (id_onNewIntent_Landroid_content_Intent_ == IntPtr.Zero)
				id_onNewIntent_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onNewIntent", "(Landroid/content/Intent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onNewIntent_Landroid_content_Intent_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNewIntent", "(Landroid/content/Intent;)V"), new JValue (p0));
		}

		static Delegate cb_onScrollChanged_IIII;
#pragma warning disable 0169
		static Delegate GetOnScrollChanged_IIIIHandler ()
		{
			if (cb_onScrollChanged_IIII == null)
				cb_onScrollChanged_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_OnScrollChanged_IIII);
			return cb_onScrollChanged_IIII;
		}

		static void n_OnScrollChanged_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnScrollChanged (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_onScrollChanged_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='onScrollChanged' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onScrollChanged", "(IIII)V", "GetOnScrollChanged_IIIIHandler")]
		public virtual void OnScrollChanged (int p0, int p1, int p2, int p3)
		{
			if (id_onScrollChanged_IIII == IntPtr.Zero)
				id_onScrollChanged_IIII = JNIEnv.GetMethodID (class_ref, "onScrollChanged", "(IIII)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onScrollChanged_IIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScrollChanged", "(IIII)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
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
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PostMessage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_postMessage_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='postMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
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

		static Delegate cb_printBackForwardList;
#pragma warning disable 0169
		static Delegate GetPrintBackForwardListHandler ()
		{
			if (cb_printBackForwardList == null)
				cb_printBackForwardList = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PrintBackForwardList);
			return cb_printBackForwardList;
		}

		static void n_PrintBackForwardList (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrintBackForwardList ();
		}
#pragma warning restore 0169

		static IntPtr id_printBackForwardList;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='printBackForwardList' and count(parameter)=0]"
		[Register ("printBackForwardList", "()V", "GetPrintBackForwardListHandler")]
		public virtual void PrintBackForwardList ()
		{
			if (id_printBackForwardList == IntPtr.Zero)
				id_printBackForwardList = JNIEnv.GetMethodID (class_ref, "printBackForwardList", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_printBackForwardList);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "printBackForwardList", "()V"));
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
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendJavascript (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendJavascript_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='sendJavascript' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_sendPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_Handler ()
		{
			if (cb_sendPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_ == null)
				cb_sendPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_);
			return cb_sendPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_;
		}

		static void n_SendPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.PluginResult p0 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendPluginResult (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='sendPluginResult' and count(parameter)=2 and parameter[1][@type='org.apache.cordova.PluginResult'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendPluginResult", "(Lorg/apache/cordova/PluginResult;Ljava/lang/String;)V", "GetSendPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_Handler")]
		public virtual void SendPluginResult (global::Org.Apache.Cordova.PluginResult p0, string p1)
		{
			if (id_sendPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_ == IntPtr.Zero)
				id_sendPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendPluginResult", "(Lorg/apache/cordova/PluginResult;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sendPluginResult_Lorg_apache_cordova_PluginResult_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendPluginResult", "(Lorg/apache/cordova/PluginResult;Ljava/lang/String;)V"), new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_setButtonPlumbedToJs_IZ;
#pragma warning disable 0169
		static Delegate GetSetButtonPlumbedToJs_IZHandler ()
		{
			if (cb_setButtonPlumbedToJs_IZ == null)
				cb_setButtonPlumbedToJs_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetButtonPlumbedToJs_IZ);
			return cb_setButtonPlumbedToJs_IZ;
		}

		static void n_SetButtonPlumbedToJs_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetButtonPlumbedToJs (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setButtonPlumbedToJs_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='setButtonPlumbedToJs' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setButtonPlumbedToJs", "(IZ)V", "GetSetButtonPlumbedToJs_IZHandler")]
		public virtual void SetButtonPlumbedToJs (int p0, bool p1)
		{
			if (id_setButtonPlumbedToJs_IZ == IntPtr.Zero)
				id_setButtonPlumbedToJs_IZ = JNIEnv.GetMethodID (class_ref, "setButtonPlumbedToJs", "(IZ)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setButtonPlumbedToJs_IZ, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setButtonPlumbedToJs", "(IZ)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_shouldRequestFocusOnInit;
#pragma warning disable 0169
		static Delegate GetShouldRequestFocusOnInitHandler ()
		{
			if (cb_shouldRequestFocusOnInit == null)
				cb_shouldRequestFocusOnInit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldRequestFocusOnInit);
			return cb_shouldRequestFocusOnInit;
		}

		static bool n_ShouldRequestFocusOnInit (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldRequestFocusOnInit ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldRequestFocusOnInit;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='shouldRequestFocusOnInit' and count(parameter)=0]"
		[Register ("shouldRequestFocusOnInit", "()Z", "GetShouldRequestFocusOnInitHandler")]
		protected virtual bool ShouldRequestFocusOnInit ()
		{
			if (id_shouldRequestFocusOnInit == IntPtr.Zero)
				id_shouldRequestFocusOnInit = JNIEnv.GetMethodID (class_ref, "shouldRequestFocusOnInit", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_shouldRequestFocusOnInit);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldRequestFocusOnInit", "()Z"));
		}

		static Delegate cb_showCustomView_Landroid_view_View_Landroid_webkit_WebChromeClient_CustomViewCallback_;
#pragma warning disable 0169
		static Delegate GetShowCustomView_Landroid_view_View_Landroid_webkit_WebChromeClient_CustomViewCallback_Handler ()
		{
			if (cb_showCustomView_Landroid_view_View_Landroid_webkit_WebChromeClient_CustomViewCallback_ == null)
				cb_showCustomView_Landroid_view_View_Landroid_webkit_WebChromeClient_CustomViewCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowCustomView_Landroid_view_View_Landroid_webkit_WebChromeClient_CustomViewCallback_);
			return cb_showCustomView_Landroid_view_View_Landroid_webkit_WebChromeClient_CustomViewCallback_;
		}

		static void n_ShowCustomView_Landroid_view_View_Landroid_webkit_WebChromeClient_CustomViewCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Webkit.WebChromeClient.ICustomViewCallback p1 = (global::Android.Webkit.WebChromeClient.ICustomViewCallback)global::Java.Lang.Object.GetObject<global::Android.Webkit.WebChromeClient.ICustomViewCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ShowCustomView (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_showCustomView_Landroid_view_View_Landroid_webkit_WebChromeClient_CustomViewCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='showCustomView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.webkit.WebChromeClient.CustomViewCallback']]"
		[Register ("showCustomView", "(Landroid/view/View;Landroid/webkit/WebChromeClient$CustomViewCallback;)V", "GetShowCustomView_Landroid_view_View_Landroid_webkit_WebChromeClient_CustomViewCallback_Handler")]
		public virtual void ShowCustomView (global::Android.Views.View p0, global::Android.Webkit.WebChromeClient.ICustomViewCallback p1)
		{
			if (id_showCustomView_Landroid_view_View_Landroid_webkit_WebChromeClient_CustomViewCallback_ == IntPtr.Zero)
				id_showCustomView_Landroid_view_View_Landroid_webkit_WebChromeClient_CustomViewCallback_ = JNIEnv.GetMethodID (class_ref, "showCustomView", "(Landroid/view/View;Landroid/webkit/WebChromeClient$CustomViewCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_showCustomView_Landroid_view_View_Landroid_webkit_WebChromeClient_CustomViewCallback_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showCustomView", "(Landroid/view/View;Landroid/webkit/WebChromeClient$CustomViewCallback;)V"), new JValue (p0), new JValue (p1));
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
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, Java.Lang.Object> p3 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.ShowWebPage (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_showWebPage_Ljava_lang_String_ZZLjava_util_HashMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='showWebPage' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='java.util.HashMap']]"
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

		static Delegate cb_startOfHistory;
#pragma warning disable 0169
		static Delegate GetStartOfHistoryHandler ()
		{
			if (cb_startOfHistory == null)
				cb_startOfHistory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StartOfHistory);
			return cb_startOfHistory;
		}

		static bool n_StartOfHistory (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartOfHistory ();
		}
#pragma warning restore 0169

		static IntPtr id_startOfHistory;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='startOfHistory' and count(parameter)=0]"
		[Register ("startOfHistory", "()Z", "GetStartOfHistoryHandler")]
		public virtual bool StartOfHistory ()
		{
			if (id_startOfHistory == IntPtr.Zero)
				id_startOfHistory = JNIEnv.GetMethodID (class_ref, "startOfHistory", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_startOfHistory);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startOfHistory", "()Z"));
		}

		static Delegate cb_storeResult_IILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetStoreResult_IILandroid_content_Intent_Handler ()
		{
			if (cb_storeResult_IILandroid_content_Intent_ == null)
				cb_storeResult_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_StoreResult_IILandroid_content_Intent_);
			return cb_storeResult_IILandroid_content_Intent_;
		}

		static void n_StoreResult_IILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Org.Apache.Cordova.CordovaWebView __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.StoreResult (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_storeResult_IILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaWebView']/method[@name='storeResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("storeResult", "(IILandroid/content/Intent;)V", "GetStoreResult_IILandroid_content_Intent_Handler")]
		public virtual void StoreResult (int p0, int p1, global::Android.Content.Intent p2)
		{
			if (id_storeResult_IILandroid_content_Intent_ == IntPtr.Zero)
				id_storeResult_IILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "storeResult", "(IILandroid/content/Intent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_storeResult_IILandroid_content_Intent_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "storeResult", "(IILandroid/content/Intent;)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}
}
