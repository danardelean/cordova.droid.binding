using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPlugin']"
	[global::Android.Runtime.Register ("org/apache/cordova/CordovaPlugin", DoNotGenerateAcw=true)]
	public partial class CordovaPlugin : global::Java.Lang.Object {


		static IntPtr cordova_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPlugin']/field[@name='cordova']"
		[Register ("cordova")]
		public global::Org.Apache.Cordova.ICordovaInterface Cordova {
			get {
				if (cordova_jfieldId == IntPtr.Zero)
					cordova_jfieldId = JNIEnv.GetFieldID (class_ref, "cordova", "Lorg/apache/cordova/CordovaInterface;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, cordova_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ICordovaInterface> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cordova_jfieldId == IntPtr.Zero)
					cordova_jfieldId = JNIEnv.GetFieldID (class_ref, "cordova", "Lorg/apache/cordova/CordovaInterface;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, cordova_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPlugin']/field[@name='id']"
		[Register ("id")]
		public string Id {
			get {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, id_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, id_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr preferences_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPlugin']/field[@name='preferences']"
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

		static IntPtr webView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPlugin']/field[@name='webView']"
		[Register ("webView")]
		public global::Org.Apache.Cordova.CordovaWebView WebView {
			get {
				if (webView_jfieldId == IntPtr.Zero)
					webView_jfieldId = JNIEnv.GetFieldID (class_ref, "webView", "Lorg/apache/cordova/CordovaWebView;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, webView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (webView_jfieldId == IntPtr.Zero)
					webView_jfieldId = JNIEnv.GetFieldID (class_ref, "webView", "Lorg/apache/cordova/CordovaWebView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, webView_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/CordovaPlugin", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CordovaPlugin); }
		}

		protected CordovaPlugin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPlugin']/constructor[@name='CordovaPlugin' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public CordovaPlugin () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CordovaPlugin)) {
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

		static Delegate cb_execute_Ljava_lang_String_Ljava_lang_String_Lorg_apache_cordova_CallbackContext_;
#pragma warning disable 0169
		static Delegate GetExecute_Ljava_lang_String_Ljava_lang_String_Lorg_apache_cordova_CallbackContext_Handler ()
		{
			if (cb_execute_Ljava_lang_String_Ljava_lang_String_Lorg_apache_cordova_CallbackContext_ == null)
				cb_execute_Ljava_lang_String_Ljava_lang_String_Lorg_apache_cordova_CallbackContext_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Execute_Ljava_lang_String_Ljava_lang_String_Lorg_apache_cordova_CallbackContext_);
			return cb_execute_Ljava_lang_String_Ljava_lang_String_Lorg_apache_cordova_CallbackContext_;
		}

		static bool n_Execute_Ljava_lang_String_Ljava_lang_String_Lorg_apache_cordova_CallbackContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Apache.Cordova.CordovaPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.CallbackContext p2 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CallbackContext> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Execute (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_execute_Ljava_lang_String_Ljava_lang_String_Lorg_apache_cordova_CallbackContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPlugin']/method[@name='execute' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.apache.cordova.CallbackContext']]"
		[Register ("execute", "(Ljava/lang/String;Ljava/lang/String;Lorg/apache/cordova/CallbackContext;)Z", "GetExecute_Ljava_lang_String_Ljava_lang_String_Lorg_apache_cordova_CallbackContext_Handler")]
		public virtual bool Execute (string p0, string p1, global::Org.Apache.Cordova.CallbackContext p2)
		{
			if (id_execute_Ljava_lang_String_Ljava_lang_String_Lorg_apache_cordova_CallbackContext_ == IntPtr.Zero)
				id_execute_Ljava_lang_String_Ljava_lang_String_Lorg_apache_cordova_CallbackContext_ = JNIEnv.GetMethodID (class_ref, "execute", "(Ljava/lang/String;Ljava/lang/String;Lorg/apache/cordova/CallbackContext;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_execute_Ljava_lang_String_Ljava_lang_String_Lorg_apache_cordova_CallbackContext_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "(Ljava/lang/String;Ljava/lang/String;Lorg/apache/cordova/CallbackContext;)Z"), new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_execute_Ljava_lang_String_Lorg_apache_cordova_CordovaArgs_Lorg_apache_cordova_CallbackContext_;
#pragma warning disable 0169
		static Delegate GetExecute_Ljava_lang_String_Lorg_apache_cordova_CordovaArgs_Lorg_apache_cordova_CallbackContext_Handler ()
		{
			if (cb_execute_Ljava_lang_String_Lorg_apache_cordova_CordovaArgs_Lorg_apache_cordova_CallbackContext_ == null)
				cb_execute_Ljava_lang_String_Lorg_apache_cordova_CordovaArgs_Lorg_apache_cordova_CallbackContext_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Execute_Ljava_lang_String_Lorg_apache_cordova_CordovaArgs_Lorg_apache_cordova_CallbackContext_);
			return cb_execute_Ljava_lang_String_Lorg_apache_cordova_CordovaArgs_Lorg_apache_cordova_CallbackContext_;
		}

		static bool n_Execute_Ljava_lang_String_Lorg_apache_cordova_CordovaArgs_Lorg_apache_cordova_CallbackContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Apache.Cordova.CordovaPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.CordovaArgs p1 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaArgs> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.CallbackContext p2 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CallbackContext> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Execute (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_execute_Ljava_lang_String_Lorg_apache_cordova_CordovaArgs_Lorg_apache_cordova_CallbackContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPlugin']/method[@name='execute' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.apache.cordova.CordovaArgs'] and parameter[3][@type='org.apache.cordova.CallbackContext']]"
		[Register ("execute", "(Ljava/lang/String;Lorg/apache/cordova/CordovaArgs;Lorg/apache/cordova/CallbackContext;)Z", "GetExecute_Ljava_lang_String_Lorg_apache_cordova_CordovaArgs_Lorg_apache_cordova_CallbackContext_Handler")]
		public virtual bool Execute (string p0, global::Org.Apache.Cordova.CordovaArgs p1, global::Org.Apache.Cordova.CallbackContext p2)
		{
			if (id_execute_Ljava_lang_String_Lorg_apache_cordova_CordovaArgs_Lorg_apache_cordova_CallbackContext_ == IntPtr.Zero)
				id_execute_Ljava_lang_String_Lorg_apache_cordova_CordovaArgs_Lorg_apache_cordova_CallbackContext_ = JNIEnv.GetMethodID (class_ref, "execute", "(Ljava/lang/String;Lorg/apache/cordova/CordovaArgs;Lorg/apache/cordova/CallbackContext;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_execute_Ljava_lang_String_Lorg_apache_cordova_CordovaArgs_Lorg_apache_cordova_CallbackContext_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "(Ljava/lang/String;Lorg/apache/cordova/CordovaArgs;Lorg/apache/cordova/CallbackContext;)Z"), new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_execute_Ljava_lang_String_Lorg_json_JSONArray_Lorg_apache_cordova_CallbackContext_;
#pragma warning disable 0169
		static Delegate GetExecute_Ljava_lang_String_Lorg_json_JSONArray_Lorg_apache_cordova_CallbackContext_Handler ()
		{
			if (cb_execute_Ljava_lang_String_Lorg_json_JSONArray_Lorg_apache_cordova_CallbackContext_ == null)
				cb_execute_Ljava_lang_String_Lorg_json_JSONArray_Lorg_apache_cordova_CallbackContext_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Execute_Ljava_lang_String_Lorg_json_JSONArray_Lorg_apache_cordova_CallbackContext_);
			return cb_execute_Ljava_lang_String_Lorg_json_JSONArray_Lorg_apache_cordova_CallbackContext_;
		}

		static bool n_Execute_Ljava_lang_String_Lorg_json_JSONArray_Lorg_apache_cordova_CallbackContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Apache.Cordova.CordovaPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONArray p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.CallbackContext p2 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CallbackContext> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Execute (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_execute_Ljava_lang_String_Lorg_json_JSONArray_Lorg_apache_cordova_CallbackContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPlugin']/method[@name='execute' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONArray'] and parameter[3][@type='org.apache.cordova.CallbackContext']]"
		[Register ("execute", "(Ljava/lang/String;Lorg/json/JSONArray;Lorg/apache/cordova/CallbackContext;)Z", "GetExecute_Ljava_lang_String_Lorg_json_JSONArray_Lorg_apache_cordova_CallbackContext_Handler")]
		public virtual bool Execute (string p0, global::Org.Json.JSONArray p1, global::Org.Apache.Cordova.CallbackContext p2)
		{
			if (id_execute_Ljava_lang_String_Lorg_json_JSONArray_Lorg_apache_cordova_CallbackContext_ == IntPtr.Zero)
				id_execute_Ljava_lang_String_Lorg_json_JSONArray_Lorg_apache_cordova_CallbackContext_ = JNIEnv.GetMethodID (class_ref, "execute", "(Ljava/lang/String;Lorg/json/JSONArray;Lorg/apache/cordova/CallbackContext;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_execute_Ljava_lang_String_Lorg_json_JSONArray_Lorg_apache_cordova_CallbackContext_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "(Ljava/lang/String;Lorg/json/JSONArray;Lorg/apache/cordova/CallbackContext;)Z"), new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_initialize_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_;
#pragma warning disable 0169
		static Delegate GetInitialize_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_Handler ()
		{
			if (cb_initialize_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_ == null)
				cb_initialize_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Initialize_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_);
			return cb_initialize_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_;
		}

		static void n_Initialize_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Apache.Cordova.CordovaPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.ICordovaInterface p0 = (global::Org.Apache.Cordova.ICordovaInterface)global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ICordovaInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.CordovaWebView p1 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_initialize_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPlugin']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='org.apache.cordova.CordovaInterface'] and parameter[2][@type='org.apache.cordova.CordovaWebView']]"
		[Register ("initialize", "(Lorg/apache/cordova/CordovaInterface;Lorg/apache/cordova/CordovaWebView;)V", "GetInitialize_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_Handler")]
		public virtual void Initialize (global::Org.Apache.Cordova.ICordovaInterface p0, global::Org.Apache.Cordova.CordovaWebView p1)
		{
			if (id_initialize_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_ == IntPtr.Zero)
				id_initialize_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Lorg/apache/cordova/CordovaInterface;Lorg/apache/cordova/CordovaWebView;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_initialize_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initialize", "(Lorg/apache/cordova/CordovaInterface;Lorg/apache/cordova/CordovaWebView;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onActivityResult_IILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnActivityResult_IILandroid_content_Intent_Handler ()
		{
			if (cb_onActivityResult_IILandroid_content_Intent_ == null)
				cb_onActivityResult_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_OnActivityResult_IILandroid_content_Intent_);
			return cb_onActivityResult_IILandroid_content_Intent_;
		}

		static void n_OnActivityResult_IILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Org.Apache.Cordova.CordovaPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityResult (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityResult_IILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPlugin']/method[@name='onActivityResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("onActivityResult", "(IILandroid/content/Intent;)V", "GetOnActivityResult_IILandroid_content_Intent_Handler")]
		public virtual void OnActivityResult (int p0, int p1, global::Android.Content.Intent p2)
		{
			if (id_onActivityResult_IILandroid_content_Intent_ == IntPtr.Zero)
				id_onActivityResult_IILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onActivityResult", "(IILandroid/content/Intent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onActivityResult_IILandroid_content_Intent_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityResult", "(IILandroid/content/Intent;)V"), new JValue (p0), new JValue (p1), new JValue (p2));
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
			global::Org.Apache.Cordova.CordovaPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPlugin']/method[@name='onDestroy' and count(parameter)=0]"
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
			global::Org.Apache.Cordova.CordovaPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnMessage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onMessage_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPlugin']/method[@name='onMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
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
			global::Org.Apache.Cordova.CordovaPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNewIntent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onNewIntent_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPlugin']/method[@name='onNewIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
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

		static Delegate cb_onOverrideUrlLoading_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnOverrideUrlLoading_Ljava_lang_String_Handler ()
		{
			if (cb_onOverrideUrlLoading_Ljava_lang_String_ == null)
				cb_onOverrideUrlLoading_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnOverrideUrlLoading_Ljava_lang_String_);
			return cb_onOverrideUrlLoading_Ljava_lang_String_;
		}

		static bool n_OnOverrideUrlLoading_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnOverrideUrlLoading (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onOverrideUrlLoading_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPlugin']/method[@name='onOverrideUrlLoading' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onOverrideUrlLoading", "(Ljava/lang/String;)Z", "GetOnOverrideUrlLoading_Ljava_lang_String_Handler")]
		public virtual bool OnOverrideUrlLoading (string p0)
		{
			if (id_onOverrideUrlLoading_Ljava_lang_String_ == IntPtr.Zero)
				id_onOverrideUrlLoading_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onOverrideUrlLoading", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onOverrideUrlLoading_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOverrideUrlLoading", "(Ljava/lang/String;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_onPause_Z;
#pragma warning disable 0169
		static Delegate GetOnPause_ZHandler ()
		{
			if (cb_onPause_Z == null)
				cb_onPause_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnPause_Z);
			return cb_onPause_Z;
		}

		static void n_OnPause_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Apache.Cordova.CordovaPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPause_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPlugin']/method[@name='onPause' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onPause", "(Z)V", "GetOnPause_ZHandler")]
		public virtual void OnPause (bool p0)
		{
			if (id_onPause_Z == IntPtr.Zero)
				id_onPause_Z = JNIEnv.GetMethodID (class_ref, "onPause", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onPause_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPause", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_onReset;
#pragma warning disable 0169
		static Delegate GetOnResetHandler ()
		{
			if (cb_onReset == null)
				cb_onReset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnReset);
			return cb_onReset;
		}

		static void n_OnReset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnReset ();
		}
#pragma warning restore 0169

		static IntPtr id_onReset;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPlugin']/method[@name='onReset' and count(parameter)=0]"
		[Register ("onReset", "()V", "GetOnResetHandler")]
		public virtual void OnReset ()
		{
			if (id_onReset == IntPtr.Zero)
				id_onReset = JNIEnv.GetMethodID (class_ref, "onReset", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onReset);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReset", "()V"));
		}

		static Delegate cb_onResume_Z;
#pragma warning disable 0169
		static Delegate GetOnResume_ZHandler ()
		{
			if (cb_onResume_Z == null)
				cb_onResume_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnResume_Z);
			return cb_onResume_Z;
		}

		static void n_OnResume_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Apache.Cordova.CordovaPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onResume_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPlugin']/method[@name='onResume' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onResume", "(Z)V", "GetOnResume_ZHandler")]
		public virtual void OnResume (bool p0)
		{
			if (id_onResume_Z == IntPtr.Zero)
				id_onResume_Z = JNIEnv.GetMethodID (class_ref, "onResume", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onResume_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResume", "(Z)V"), new JValue (p0));
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
			global::Org.Apache.Cordova.CordovaPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PluginInitialize ();
		}
#pragma warning restore 0169

		static IntPtr id_pluginInitialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPlugin']/method[@name='pluginInitialize' and count(parameter)=0]"
		[Register ("pluginInitialize", "()V", "GetPluginInitializeHandler")]
		protected virtual void PluginInitialize ()
		{
			if (id_pluginInitialize == IntPtr.Zero)
				id_pluginInitialize = JNIEnv.GetMethodID (class_ref, "pluginInitialize", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_pluginInitialize);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pluginInitialize", "()V"));
		}

		static IntPtr id_privateInitialize_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_Lorg_apache_cordova_CordovaPreferences_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPlugin']/method[@name='privateInitialize' and count(parameter)=3 and parameter[1][@type='org.apache.cordova.CordovaInterface'] and parameter[2][@type='org.apache.cordova.CordovaWebView'] and parameter[3][@type='org.apache.cordova.CordovaPreferences']]"
		[Register ("privateInitialize", "(Lorg/apache/cordova/CordovaInterface;Lorg/apache/cordova/CordovaWebView;Lorg/apache/cordova/CordovaPreferences;)V", "")]
		public void PrivateInitialize (global::Org.Apache.Cordova.ICordovaInterface p0, global::Org.Apache.Cordova.CordovaWebView p1, global::Org.Apache.Cordova.CordovaPreferences p2)
		{
			if (id_privateInitialize_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_Lorg_apache_cordova_CordovaPreferences_ == IntPtr.Zero)
				id_privateInitialize_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_Lorg_apache_cordova_CordovaPreferences_ = JNIEnv.GetMethodID (class_ref, "privateInitialize", "(Lorg/apache/cordova/CordovaInterface;Lorg/apache/cordova/CordovaWebView;Lorg/apache/cordova/CordovaPreferences;)V");
			JNIEnv.CallVoidMethod  (Handle, id_privateInitialize_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_Lorg_apache_cordova_CordovaPreferences_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_remapUri_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetRemapUri_Landroid_net_Uri_Handler ()
		{
			if (cb_remapUri_Landroid_net_Uri_ == null)
				cb_remapUri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemapUri_Landroid_net_Uri_);
			return cb_remapUri_Landroid_net_Uri_;
		}

		static IntPtr n_RemapUri_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaPlugin __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemapUri (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_remapUri_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPlugin']/method[@name='remapUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("remapUri", "(Landroid/net/Uri;)Landroid/net/Uri;", "GetRemapUri_Landroid_net_Uri_Handler")]
		public virtual global::Android.Net.Uri RemapUri (global::Android.Net.Uri p0)
		{
			if (id_remapUri_Landroid_net_Uri_ == IntPtr.Zero)
				id_remapUri_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "remapUri", "(Landroid/net/Uri;)Landroid/net/Uri;");

			global::Android.Net.Uri __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_remapUri_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remapUri", "(Landroid/net/Uri;)Landroid/net/Uri;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
