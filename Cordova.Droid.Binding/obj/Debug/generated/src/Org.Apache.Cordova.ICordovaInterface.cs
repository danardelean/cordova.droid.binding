using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.apache.cordova']/interface[@name='CordovaInterface']"
	[Register ("org/apache/cordova/CordovaInterface", "", "Org.Apache.Cordova.ICordovaInterfaceInvoker")]
	public partial interface ICordovaInterface : IJavaObject {

		global::Android.App.Activity Activity {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/interface[@name='CordovaInterface']/method[@name='getActivity' and count(parameter)=0]"
			[Register ("getActivity", "()Landroid/app/Activity;", "GetGetActivityHandler:Org.Apache.Cordova.ICordovaInterfaceInvoker, Cordova.Android.Binding")] get;
		}

		global::Java.Util.Concurrent.IExecutorService ThreadPool {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/interface[@name='CordovaInterface']/method[@name='getThreadPool' and count(parameter)=0]"
			[Register ("getThreadPool", "()Ljava/util/concurrent/ExecutorService;", "GetGetThreadPoolHandler:Org.Apache.Cordova.ICordovaInterfaceInvoker, Cordova.Android.Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/interface[@name='CordovaInterface']/method[@name='onMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("onMessage", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", "GetOnMessage_Ljava_lang_String_Ljava_lang_Object_Handler:Org.Apache.Cordova.ICordovaInterfaceInvoker, Cordova.Android.Binding")]
		global::Java.Lang.Object OnMessage (string p0, global::Java.Lang.Object p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/interface[@name='CordovaInterface']/method[@name='setActivityResultCallback' and count(parameter)=1 and parameter[1][@type='org.apache.cordova.CordovaPlugin']]"
		[Register ("setActivityResultCallback", "(Lorg/apache/cordova/CordovaPlugin;)V", "GetSetActivityResultCallback_Lorg_apache_cordova_CordovaPlugin_Handler:Org.Apache.Cordova.ICordovaInterfaceInvoker, Cordova.Android.Binding")]
		void SetActivityResultCallback (global::Org.Apache.Cordova.CordovaPlugin p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/interface[@name='CordovaInterface']/method[@name='startActivityForResult' and count(parameter)=3 and parameter[1][@type='org.apache.cordova.CordovaPlugin'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='int']]"
		[Register ("startActivityForResult", "(Lorg/apache/cordova/CordovaPlugin;Landroid/content/Intent;I)V", "GetStartActivityForResult_Lorg_apache_cordova_CordovaPlugin_Landroid_content_Intent_IHandler:Org.Apache.Cordova.ICordovaInterfaceInvoker, Cordova.Android.Binding")]
		void StartActivityForResult (global::Org.Apache.Cordova.CordovaPlugin p0, global::Android.Content.Intent p1, int p2);

	}

	[global::Android.Runtime.Register ("org/apache/cordova/CordovaInterface", DoNotGenerateAcw=true)]
	internal class ICordovaInterfaceInvoker : global::Java.Lang.Object, ICordovaInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/apache/cordova/CordovaInterface");
		IntPtr class_ref;

		public static ICordovaInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICordovaInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.apache.cordova.CordovaInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICordovaInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ICordovaInterfaceInvoker); }
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
			global::Org.Apache.Cordova.ICordovaInterface __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ICordovaInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Activity);
		}
#pragma warning restore 0169

		IntPtr id_getActivity;
		public global::Android.App.Activity Activity {
			get {
				if (id_getActivity == IntPtr.Zero)
					id_getActivity = JNIEnv.GetMethodID (class_ref, "getActivity", "()Landroid/app/Activity;");
				return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (JNIEnv.CallObjectMethod (Handle, id_getActivity), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Apache.Cordova.ICordovaInterface __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ICordovaInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThreadPool);
		}
#pragma warning restore 0169

		IntPtr id_getThreadPool;
		public global::Java.Util.Concurrent.IExecutorService ThreadPool {
			get {
				if (id_getThreadPool == IntPtr.Zero)
					id_getThreadPool = JNIEnv.GetMethodID (class_ref, "getThreadPool", "()Ljava/util/concurrent/ExecutorService;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (JNIEnv.CallObjectMethod (Handle, id_getThreadPool), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Org.Apache.Cordova.ICordovaInterface __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ICordovaInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnMessage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onMessage_Ljava_lang_String_Ljava_lang_Object_;
		public global::Java.Lang.Object OnMessage (string p0, global::Java.Lang.Object p1)
		{
			if (id_onMessage_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_onMessage_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onMessage", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_onMessage_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Org.Apache.Cordova.ICordovaInterface __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ICordovaInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.CordovaPlugin p0 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetActivityResultCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_setActivityResultCallback_Lorg_apache_cordova_CordovaPlugin_;
		public void SetActivityResultCallback (global::Org.Apache.Cordova.CordovaPlugin p0)
		{
			if (id_setActivityResultCallback_Lorg_apache_cordova_CordovaPlugin_ == IntPtr.Zero)
				id_setActivityResultCallback_Lorg_apache_cordova_CordovaPlugin_ = JNIEnv.GetMethodID (class_ref, "setActivityResultCallback", "(Lorg/apache/cordova/CordovaPlugin;)V");
			JNIEnv.CallVoidMethod (Handle, id_setActivityResultCallback_Lorg_apache_cordova_CordovaPlugin_, new JValue (p0));
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
			global::Org.Apache.Cordova.ICordovaInterface __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ICordovaInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.CordovaPlugin p0 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartActivityForResult (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_startActivityForResult_Lorg_apache_cordova_CordovaPlugin_Landroid_content_Intent_I;
		public void StartActivityForResult (global::Org.Apache.Cordova.CordovaPlugin p0, global::Android.Content.Intent p1, int p2)
		{
			if (id_startActivityForResult_Lorg_apache_cordova_CordovaPlugin_Landroid_content_Intent_I == IntPtr.Zero)
				id_startActivityForResult_Lorg_apache_cordova_CordovaPlugin_Landroid_content_Intent_I = JNIEnv.GetMethodID (class_ref, "startActivityForResult", "(Lorg/apache/cordova/CordovaPlugin;Landroid/content/Intent;I)V");
			JNIEnv.CallVoidMethod (Handle, id_startActivityForResult_Lorg_apache_cordova_CordovaPlugin_Landroid_content_Intent_I, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}

}
