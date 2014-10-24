using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaBridge']"
	[global::Android.Runtime.Register ("org/apache/cordova/CordovaBridge", DoNotGenerateAcw=true)]
	public partial class CordovaBridge : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/CordovaBridge", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CordovaBridge); }
		}

		protected CordovaBridge (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_apache_cordova_PluginManager_Lorg_apache_cordova_NativeToJsMessageQueue_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaBridge']/constructor[@name='CordovaBridge' and count(parameter)=2 and parameter[1][@type='org.apache.cordova.PluginManager'] and parameter[2][@type='org.apache.cordova.NativeToJsMessageQueue']]"
		[Register (".ctor", "(Lorg/apache/cordova/PluginManager;Lorg/apache/cordova/NativeToJsMessageQueue;)V", "")]
		public CordovaBridge (global::Org.Apache.Cordova.PluginManager p0, global::Org.Apache.Cordova.NativeToJsMessageQueue p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CordovaBridge)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/cordova/PluginManager;Lorg/apache/cordova/NativeToJsMessageQueue;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/cordova/PluginManager;Lorg/apache/cordova/NativeToJsMessageQueue;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lorg_apache_cordova_PluginManager_Lorg_apache_cordova_NativeToJsMessageQueue_ == IntPtr.Zero)
				id_ctor_Lorg_apache_cordova_PluginManager_Lorg_apache_cordova_NativeToJsMessageQueue_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/cordova/PluginManager;Lorg/apache/cordova/NativeToJsMessageQueue;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_cordova_PluginManager_Lorg_apache_cordova_NativeToJsMessageQueue_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_cordova_PluginManager_Lorg_apache_cordova_NativeToJsMessageQueue_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getMessageQueue;
#pragma warning disable 0169
		static Delegate GetGetMessageQueueHandler ()
		{
			if (cb_getMessageQueue == null)
				cb_getMessageQueue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageQueue);
			return cb_getMessageQueue;
		}

		static IntPtr n_GetMessageQueue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaBridge __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MessageQueue);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageQueue;
		public virtual global::Org.Apache.Cordova.NativeToJsMessageQueue MessageQueue {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaBridge']/method[@name='getMessageQueue' and count(parameter)=0]"
			[Register ("getMessageQueue", "()Lorg/apache/cordova/NativeToJsMessageQueue;", "GetGetMessageQueueHandler")]
			get {
				if (id_getMessageQueue == IntPtr.Zero)
					id_getMessageQueue = JNIEnv.GetMethodID (class_ref, "getMessageQueue", "()Lorg/apache/cordova/NativeToJsMessageQueue;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.NativeToJsMessageQueue> (JNIEnv.CallObjectMethod  (Handle, id_getMessageQueue), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.NativeToJsMessageQueue> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageQueue", "()Lorg/apache/cordova/NativeToJsMessageQueue;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_jsExec_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetJsExec_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_jsExec_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_jsExec_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_JsExec_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_jsExec_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_JsExec_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Org.Apache.Cordova.CordovaBridge __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.JsExec (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_jsExec_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaBridge']/method[@name='jsExec' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("jsExec", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetJsExec_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual string JsExec (int p0, string p1, string p2, string p3, string p4)
		{
			if (id_jsExec_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_jsExec_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "jsExec", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_jsExec_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "jsExec", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

		static Delegate cb_jsRetrieveJsMessages_IZ;
#pragma warning disable 0169
		static Delegate GetJsRetrieveJsMessages_IZHandler ()
		{
			if (cb_jsRetrieveJsMessages_IZ == null)
				cb_jsRetrieveJsMessages_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, IntPtr>) n_JsRetrieveJsMessages_IZ);
			return cb_jsRetrieveJsMessages_IZ;
		}

		static IntPtr n_JsRetrieveJsMessages_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Org.Apache.Cordova.CordovaBridge __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.JsRetrieveJsMessages (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_jsRetrieveJsMessages_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaBridge']/method[@name='jsRetrieveJsMessages' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("jsRetrieveJsMessages", "(IZ)Ljava/lang/String;", "GetJsRetrieveJsMessages_IZHandler")]
		public virtual string JsRetrieveJsMessages (int p0, bool p1)
		{
			if (id_jsRetrieveJsMessages_IZ == IntPtr.Zero)
				id_jsRetrieveJsMessages_IZ = JNIEnv.GetMethodID (class_ref, "jsRetrieveJsMessages", "(IZ)Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_jsRetrieveJsMessages_IZ, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "jsRetrieveJsMessages", "(IZ)Ljava/lang/String;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_jsSetNativeToJsBridgeMode_II;
#pragma warning disable 0169
		static Delegate GetJsSetNativeToJsBridgeMode_IIHandler ()
		{
			if (cb_jsSetNativeToJsBridgeMode_II == null)
				cb_jsSetNativeToJsBridgeMode_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_JsSetNativeToJsBridgeMode_II);
			return cb_jsSetNativeToJsBridgeMode_II;
		}

		static void n_JsSetNativeToJsBridgeMode_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Org.Apache.Cordova.CordovaBridge __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.JsSetNativeToJsBridgeMode (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_jsSetNativeToJsBridgeMode_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaBridge']/method[@name='jsSetNativeToJsBridgeMode' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("jsSetNativeToJsBridgeMode", "(II)V", "GetJsSetNativeToJsBridgeMode_IIHandler")]
		public virtual void JsSetNativeToJsBridgeMode (int p0, int p1)
		{
			if (id_jsSetNativeToJsBridgeMode_II == IntPtr.Zero)
				id_jsSetNativeToJsBridgeMode_II = JNIEnv.GetMethodID (class_ref, "jsSetNativeToJsBridgeMode", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_jsSetNativeToJsBridgeMode_II, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "jsSetNativeToJsBridgeMode", "(II)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_promptOnJsPrompt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPromptOnJsPrompt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_promptOnJsPrompt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_promptOnJsPrompt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PromptOnJsPrompt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_promptOnJsPrompt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_PromptOnJsPrompt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Apache.Cordova.CordovaBridge __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.PromptOnJsPrompt (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_promptOnJsPrompt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaBridge']/method[@name='promptOnJsPrompt' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("promptOnJsPrompt", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetPromptOnJsPrompt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual string PromptOnJsPrompt (string p0, string p1, string p2)
		{
			if (id_promptOnJsPrompt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_promptOnJsPrompt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "promptOnJsPrompt", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_promptOnJsPrompt_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "promptOnJsPrompt", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_reset_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReset_Ljava_lang_String_Handler ()
		{
			if (cb_reset_Ljava_lang_String_ == null)
				cb_reset_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Reset_Ljava_lang_String_);
			return cb_reset_Ljava_lang_String_;
		}

		static void n_Reset_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaBridge __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Reset (p0);
		}
#pragma warning restore 0169

		static IntPtr id_reset_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaBridge']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("reset", "(Ljava/lang/String;)V", "GetReset_Ljava_lang_String_Handler")]
		public virtual void Reset (string p0)
		{
			if (id_reset_Ljava_lang_String_ == IntPtr.Zero)
				id_reset_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "reset", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_reset_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
