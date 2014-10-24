using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='CallbackContext']"
	[global::Android.Runtime.Register ("org/apache/cordova/CallbackContext", DoNotGenerateAcw=true)]
	public partial class CallbackContext : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/CallbackContext", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CallbackContext); }
		}

		protected CallbackContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lorg_apache_cordova_CordovaWebView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='CallbackContext']/constructor[@name='CallbackContext' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.apache.cordova.CordovaWebView']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/apache/cordova/CordovaWebView;)V", "")]
		public CallbackContext (string p0, global::Org.Apache.Cordova.CordovaWebView p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (CallbackContext)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lorg/apache/cordova/CordovaWebView;)V", new JValue (native_p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lorg/apache/cordova/CordovaWebView;)V", new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_Lorg_apache_cordova_CordovaWebView_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Lorg_apache_cordova_CordovaWebView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lorg/apache/cordova/CordovaWebView;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lorg_apache_cordova_CordovaWebView_, new JValue (native_p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lorg_apache_cordova_CordovaWebView_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getCallbackId;
#pragma warning disable 0169
		static Delegate GetGetCallbackIdHandler ()
		{
			if (cb_getCallbackId == null)
				cb_getCallbackId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallbackId);
			return cb_getCallbackId;
		}

		static IntPtr n_GetCallbackId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CallbackContext __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CallbackContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CallbackId);
		}
#pragma warning restore 0169

		static IntPtr id_getCallbackId;
		public virtual string CallbackId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CallbackContext']/method[@name='getCallbackId' and count(parameter)=0]"
			[Register ("getCallbackId", "()Ljava/lang/String;", "GetGetCallbackIdHandler")]
			get {
				if (id_getCallbackId == IntPtr.Zero)
					id_getCallbackId = JNIEnv.GetMethodID (class_ref, "getCallbackId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCallbackId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCallbackId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isChangingThreads;
#pragma warning disable 0169
		static Delegate GetIsChangingThreadsHandler ()
		{
			if (cb_isChangingThreads == null)
				cb_isChangingThreads = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsChangingThreads);
			return cb_isChangingThreads;
		}

		static bool n_IsChangingThreads (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CallbackContext __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CallbackContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsChangingThreads;
		}
#pragma warning restore 0169

		static IntPtr id_isChangingThreads;
		public virtual bool IsChangingThreads {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CallbackContext']/method[@name='isChangingThreads' and count(parameter)=0]"
			[Register ("isChangingThreads", "()Z", "GetIsChangingThreadsHandler")]
			get {
				if (id_isChangingThreads == IntPtr.Zero)
					id_isChangingThreads = JNIEnv.GetMethodID (class_ref, "isChangingThreads", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isChangingThreads);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isChangingThreads", "()Z"));
			}
		}

		static Delegate cb_isFinished;
#pragma warning disable 0169
		static Delegate GetIsFinishedHandler ()
		{
			if (cb_isFinished == null)
				cb_isFinished = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFinished);
			return cb_isFinished;
		}

		static bool n_IsFinished (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CallbackContext __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CallbackContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFinished;
		}
#pragma warning restore 0169

		static IntPtr id_isFinished;
		public virtual bool IsFinished {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CallbackContext']/method[@name='isFinished' and count(parameter)=0]"
			[Register ("isFinished", "()Z", "GetIsFinishedHandler")]
			get {
				if (id_isFinished == IntPtr.Zero)
					id_isFinished = JNIEnv.GetMethodID (class_ref, "isFinished", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isFinished);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFinished", "()Z"));
			}
		}

		static Delegate cb_error_I;
#pragma warning disable 0169
		static Delegate GetError_IHandler ()
		{
			if (cb_error_I == null)
				cb_error_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Error_I);
			return cb_error_I;
		}

		static void n_Error_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CallbackContext __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CallbackContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Error (p0);
		}
#pragma warning restore 0169

		static IntPtr id_error_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CallbackContext']/method[@name='error' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("error", "(I)V", "GetError_IHandler")]
		public virtual void Error (int p0)
		{
			if (id_error_I == IntPtr.Zero)
				id_error_I = JNIEnv.GetMethodID (class_ref, "error", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_error_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "error", "(I)V"), new JValue (p0));
		}

		static Delegate cb_error_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetError_Ljava_lang_String_Handler ()
		{
			if (cb_error_Ljava_lang_String_ == null)
				cb_error_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Error_Ljava_lang_String_);
			return cb_error_Ljava_lang_String_;
		}

		static void n_Error_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CallbackContext __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CallbackContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Error (p0);
		}
#pragma warning restore 0169

		static IntPtr id_error_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CallbackContext']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("error", "(Ljava/lang/String;)V", "GetError_Ljava_lang_String_Handler")]
		public virtual void Error (string p0)
		{
			if (id_error_Ljava_lang_String_ == IntPtr.Zero)
				id_error_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "error", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_error_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "error", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_error_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetError_Lorg_json_JSONObject_Handler ()
		{
			if (cb_error_Lorg_json_JSONObject_ == null)
				cb_error_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Error_Lorg_json_JSONObject_);
			return cb_error_Lorg_json_JSONObject_;
		}

		static void n_Error_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CallbackContext __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CallbackContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Error (p0);
		}
#pragma warning restore 0169

		static IntPtr id_error_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CallbackContext']/method[@name='error' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("error", "(Lorg/json/JSONObject;)V", "GetError_Lorg_json_JSONObject_Handler")]
		public virtual void Error (global::Org.Json.JSONObject p0)
		{
			if (id_error_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_error_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "error", "(Lorg/json/JSONObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_error_Lorg_json_JSONObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "error", "(Lorg/json/JSONObject;)V"), new JValue (p0));
		}

		static Delegate cb_sendPluginResult_Lorg_apache_cordova_PluginResult_;
#pragma warning disable 0169
		static Delegate GetSendPluginResult_Lorg_apache_cordova_PluginResult_Handler ()
		{
			if (cb_sendPluginResult_Lorg_apache_cordova_PluginResult_ == null)
				cb_sendPluginResult_Lorg_apache_cordova_PluginResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendPluginResult_Lorg_apache_cordova_PluginResult_);
			return cb_sendPluginResult_Lorg_apache_cordova_PluginResult_;
		}

		static void n_SendPluginResult_Lorg_apache_cordova_PluginResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CallbackContext __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CallbackContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.PluginResult p0 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendPluginResult (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendPluginResult_Lorg_apache_cordova_PluginResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CallbackContext']/method[@name='sendPluginResult' and count(parameter)=1 and parameter[1][@type='org.apache.cordova.PluginResult']]"
		[Register ("sendPluginResult", "(Lorg/apache/cordova/PluginResult;)V", "GetSendPluginResult_Lorg_apache_cordova_PluginResult_Handler")]
		public virtual void SendPluginResult (global::Org.Apache.Cordova.PluginResult p0)
		{
			if (id_sendPluginResult_Lorg_apache_cordova_PluginResult_ == IntPtr.Zero)
				id_sendPluginResult_Lorg_apache_cordova_PluginResult_ = JNIEnv.GetMethodID (class_ref, "sendPluginResult", "(Lorg/apache/cordova/PluginResult;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sendPluginResult_Lorg_apache_cordova_PluginResult_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendPluginResult", "(Lorg/apache/cordova/PluginResult;)V"), new JValue (p0));
		}

		static Delegate cb_success;
#pragma warning disable 0169
		static Delegate GetSuccessHandler ()
		{
			if (cb_success == null)
				cb_success = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Success);
			return cb_success;
		}

		static void n_Success (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CallbackContext __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CallbackContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Success ();
		}
#pragma warning restore 0169

		static IntPtr id_success;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CallbackContext']/method[@name='success' and count(parameter)=0]"
		[Register ("success", "()V", "GetSuccessHandler")]
		public virtual void Success ()
		{
			if (id_success == IntPtr.Zero)
				id_success = JNIEnv.GetMethodID (class_ref, "success", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_success);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "success", "()V"));
		}

		static Delegate cb_success_arrayB;
#pragma warning disable 0169
		static Delegate GetSuccess_arrayBHandler ()
		{
			if (cb_success_arrayB == null)
				cb_success_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Success_arrayB);
			return cb_success_arrayB;
		}

		static void n_Success_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CallbackContext __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CallbackContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Success (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_success_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CallbackContext']/method[@name='success' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("success", "([B)V", "GetSuccess_arrayBHandler")]
		public virtual void Success (byte[] p0)
		{
			if (id_success_arrayB == IntPtr.Zero)
				id_success_arrayB = JNIEnv.GetMethodID (class_ref, "success", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_success_arrayB, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "success", "([B)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_success_I;
#pragma warning disable 0169
		static Delegate GetSuccess_IHandler ()
		{
			if (cb_success_I == null)
				cb_success_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Success_I);
			return cb_success_I;
		}

		static void n_Success_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CallbackContext __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CallbackContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Success (p0);
		}
#pragma warning restore 0169

		static IntPtr id_success_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CallbackContext']/method[@name='success' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("success", "(I)V", "GetSuccess_IHandler")]
		public virtual void Success (int p0)
		{
			if (id_success_I == IntPtr.Zero)
				id_success_I = JNIEnv.GetMethodID (class_ref, "success", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_success_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "success", "(I)V"), new JValue (p0));
		}

		static Delegate cb_success_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSuccess_Ljava_lang_String_Handler ()
		{
			if (cb_success_Ljava_lang_String_ == null)
				cb_success_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Success_Ljava_lang_String_);
			return cb_success_Ljava_lang_String_;
		}

		static void n_Success_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CallbackContext __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CallbackContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Success (p0);
		}
#pragma warning restore 0169

		static IntPtr id_success_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CallbackContext']/method[@name='success' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("success", "(Ljava/lang/String;)V", "GetSuccess_Ljava_lang_String_Handler")]
		public virtual void Success (string p0)
		{
			if (id_success_Ljava_lang_String_ == IntPtr.Zero)
				id_success_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "success", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_success_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "success", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_success_Lorg_json_JSONArray_;
#pragma warning disable 0169
		static Delegate GetSuccess_Lorg_json_JSONArray_Handler ()
		{
			if (cb_success_Lorg_json_JSONArray_ == null)
				cb_success_Lorg_json_JSONArray_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Success_Lorg_json_JSONArray_);
			return cb_success_Lorg_json_JSONArray_;
		}

		static void n_Success_Lorg_json_JSONArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CallbackContext __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CallbackContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONArray p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Success (p0);
		}
#pragma warning restore 0169

		static IntPtr id_success_Lorg_json_JSONArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CallbackContext']/method[@name='success' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
		[Register ("success", "(Lorg/json/JSONArray;)V", "GetSuccess_Lorg_json_JSONArray_Handler")]
		public virtual void Success (global::Org.Json.JSONArray p0)
		{
			if (id_success_Lorg_json_JSONArray_ == IntPtr.Zero)
				id_success_Lorg_json_JSONArray_ = JNIEnv.GetMethodID (class_ref, "success", "(Lorg/json/JSONArray;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_success_Lorg_json_JSONArray_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "success", "(Lorg/json/JSONArray;)V"), new JValue (p0));
		}

		static Delegate cb_success_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSuccess_Lorg_json_JSONObject_Handler ()
		{
			if (cb_success_Lorg_json_JSONObject_ == null)
				cb_success_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Success_Lorg_json_JSONObject_);
			return cb_success_Lorg_json_JSONObject_;
		}

		static void n_Success_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CallbackContext __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CallbackContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Success (p0);
		}
#pragma warning restore 0169

		static IntPtr id_success_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CallbackContext']/method[@name='success' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("success", "(Lorg/json/JSONObject;)V", "GetSuccess_Lorg_json_JSONObject_Handler")]
		public virtual void Success (global::Org.Json.JSONObject p0)
		{
			if (id_success_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_success_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "success", "(Lorg/json/JSONObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_success_Lorg_json_JSONObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "success", "(Lorg/json/JSONObject;)V"), new JValue (p0));
		}

	}
}
