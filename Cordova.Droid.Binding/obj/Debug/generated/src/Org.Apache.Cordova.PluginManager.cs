using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginManager']"
	[global::Android.Runtime.Register ("org/apache/cordova/PluginManager", DoNotGenerateAcw=true)]
	public partial class PluginManager : global::Java.Lang.Object {


		static IntPtr urlMap_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginManager']/field[@name='urlMap']"
		[Register ("urlMap")]
		protected global::System.Collections.IDictionary UrlMap {
			get {
				if (urlMap_jfieldId == IntPtr.Zero)
					urlMap_jfieldId = JNIEnv.GetFieldID (class_ref, "urlMap", "Ljava/util/HashMap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, urlMap_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (urlMap_jfieldId == IntPtr.Zero)
					urlMap_jfieldId = JNIEnv.GetFieldID (class_ref, "urlMap", "Ljava/util/HashMap;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, urlMap_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/PluginManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PluginManager); }
		}

		protected PluginManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Org.Apache.Cordova.PluginManager __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddService (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addService_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginManager']/method[@name='addService' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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

		static Delegate cb_addService_Lorg_apache_cordova_PluginEntry_;
#pragma warning disable 0169
		static Delegate GetAddService_Lorg_apache_cordova_PluginEntry_Handler ()
		{
			if (cb_addService_Lorg_apache_cordova_PluginEntry_ == null)
				cb_addService_Lorg_apache_cordova_PluginEntry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddService_Lorg_apache_cordova_PluginEntry_);
			return cb_addService_Lorg_apache_cordova_PluginEntry_;
		}

		static void n_AddService_Lorg_apache_cordova_PluginEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.PluginManager __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.PluginEntry p0 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginEntry> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddService (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addService_Lorg_apache_cordova_PluginEntry_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginManager']/method[@name='addService' and count(parameter)=1 and parameter[1][@type='org.apache.cordova.PluginEntry']]"
		[Register ("addService", "(Lorg/apache/cordova/PluginEntry;)V", "GetAddService_Lorg_apache_cordova_PluginEntry_Handler")]
		public virtual void AddService (global::Org.Apache.Cordova.PluginEntry p0)
		{
			if (id_addService_Lorg_apache_cordova_PluginEntry_ == IntPtr.Zero)
				id_addService_Lorg_apache_cordova_PluginEntry_ = JNIEnv.GetMethodID (class_ref, "addService", "(Lorg/apache/cordova/PluginEntry;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addService_Lorg_apache_cordova_PluginEntry_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addService", "(Lorg/apache/cordova/PluginEntry;)V"), new JValue (p0));
		}

		static Delegate cb_clearPluginObjects;
#pragma warning disable 0169
		static Delegate GetClearPluginObjectsHandler ()
		{
			if (cb_clearPluginObjects == null)
				cb_clearPluginObjects = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearPluginObjects);
			return cb_clearPluginObjects;
		}

		static void n_ClearPluginObjects (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.PluginManager __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearPluginObjects ();
		}
#pragma warning restore 0169

		static IntPtr id_clearPluginObjects;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginManager']/method[@name='clearPluginObjects' and count(parameter)=0]"
		[Register ("clearPluginObjects", "()V", "GetClearPluginObjectsHandler")]
		public virtual void ClearPluginObjects ()
		{
			if (id_clearPluginObjects == IntPtr.Zero)
				id_clearPluginObjects = JNIEnv.GetMethodID (class_ref, "clearPluginObjects", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearPluginObjects);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearPluginObjects", "()V"));
		}

		static Delegate cb_exec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetExec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_exec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_exec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Exec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_exec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Exec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Apache.Cordova.PluginManager __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Exec (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_exec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginManager']/method[@name='exec' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("exec", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetExec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void Exec (string p0, string p1, string p2, string p3)
		{
			if (id_exec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_exec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "exec", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_exec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "exec", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_exec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetExec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_exec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_exec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Exec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_exec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static void n_Exec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, bool p4)
		{
			global::Org.Apache.Cordova.PluginManager __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Exec (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_exec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginManager']/method[@name='exec' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='boolean']]"
		[Register ("exec", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "GetExec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual void Exec (string p0, string p1, string p2, string p3, bool p4)
		{
			if (id_exec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_exec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "exec", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_exec_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "exec", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V"), new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_getPlugin_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPlugin_Ljava_lang_String_Handler ()
		{
			if (cb_getPlugin_Ljava_lang_String_ == null)
				cb_getPlugin_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPlugin_Ljava_lang_String_);
			return cb_getPlugin_Ljava_lang_String_;
		}

		static IntPtr n_GetPlugin_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.PluginManager __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPlugin (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPlugin_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginManager']/method[@name='getPlugin' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPlugin", "(Ljava/lang/String;)Lorg/apache/cordova/CordovaPlugin;", "GetGetPlugin_Ljava_lang_String_Handler")]
		public virtual global::Org.Apache.Cordova.CordovaPlugin GetPlugin (string p0)
		{
			if (id_getPlugin_Ljava_lang_String_ == IntPtr.Zero)
				id_getPlugin_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getPlugin", "(Ljava/lang/String;)Lorg/apache/cordova/CordovaPlugin;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Org.Apache.Cordova.CordovaPlugin __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (JNIEnv.CallObjectMethod  (Handle, id_getPlugin_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlugin", "(Ljava/lang/String;)Lorg/apache/cordova/CordovaPlugin;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Org.Apache.Cordova.PluginManager __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginManager']/method[@name='init' and count(parameter)=0]"
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

		static Delegate cb_loadPlugins;
#pragma warning disable 0169
		static Delegate GetLoadPluginsHandler ()
		{
			if (cb_loadPlugins == null)
				cb_loadPlugins = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LoadPlugins);
			return cb_loadPlugins;
		}

		static void n_LoadPlugins (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.PluginManager __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadPlugins ();
		}
#pragma warning restore 0169

		static IntPtr id_loadPlugins;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginManager']/method[@name='loadPlugins' and count(parameter)=0]"
		[Register ("loadPlugins", "()V", "GetLoadPluginsHandler")]
		public virtual void LoadPlugins ()
		{
			if (id_loadPlugins == IntPtr.Zero)
				id_loadPlugins = JNIEnv.GetMethodID (class_ref, "loadPlugins", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadPlugins);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadPlugins", "()V"));
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
			global::Org.Apache.Cordova.PluginManager __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginManager']/method[@name='onDestroy' and count(parameter)=0]"
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
			global::Org.Apache.Cordova.PluginManager __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNewIntent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onNewIntent_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginManager']/method[@name='onNewIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
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
			global::Org.Apache.Cordova.PluginManager __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnOverrideUrlLoading (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onOverrideUrlLoading_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginManager']/method[@name='onOverrideUrlLoading' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Org.Apache.Cordova.PluginManager __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPause_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginManager']/method[@name='onPause' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Org.Apache.Cordova.PluginManager __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnReset ();
		}
#pragma warning restore 0169

		static IntPtr id_onReset;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginManager']/method[@name='onReset' and count(parameter)=0]"
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
			global::Org.Apache.Cordova.PluginManager __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onResume_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginManager']/method[@name='onResume' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_postMessage_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPostMessage_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_postMessage_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_postMessage_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PostMessage_Ljava_lang_String_Ljava_lang_Object_);
			return cb_postMessage_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_PostMessage_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Apache.Cordova.PluginManager __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PostMessage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_postMessage_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginManager']/method[@name='postMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("postMessage", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", "GetPostMessage_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual global::Java.Lang.Object PostMessage (string p0, global::Java.Lang.Object p1)
		{
			if (id_postMessage_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_postMessage_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "postMessage", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_postMessage_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postMessage", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setPluginEntries_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPluginEntries_Ljava_util_List_Handler ()
		{
			if (cb_setPluginEntries_Ljava_util_List_ == null)
				cb_setPluginEntries_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPluginEntries_Ljava_util_List_);
			return cb_setPluginEntries_Ljava_util_List_;
		}

		static void n_SetPluginEntries_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.PluginManager __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Org.Apache.Cordova.PluginEntry> p0 = global::Android.Runtime.JavaList<global::Org.Apache.Cordova.PluginEntry>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPluginEntries (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPluginEntries_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginManager']/method[@name='setPluginEntries' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("setPluginEntries", "(Ljava/util/List;)V", "GetSetPluginEntries_Ljava_util_List_Handler")]
		public virtual void SetPluginEntries (global::System.Collections.Generic.IList<global::Org.Apache.Cordova.PluginEntry> p0)
		{
			if (id_setPluginEntries_Ljava_util_List_ == IntPtr.Zero)
				id_setPluginEntries_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPluginEntries", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Apache.Cordova.PluginEntry>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPluginEntries_Ljava_util_List_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPluginEntries", "(Ljava/util/List;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_startupPlugins;
#pragma warning disable 0169
		static Delegate GetStartupPluginsHandler ()
		{
			if (cb_startupPlugins == null)
				cb_startupPlugins = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartupPlugins);
			return cb_startupPlugins;
		}

		static void n_StartupPlugins (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.PluginManager __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartupPlugins ();
		}
#pragma warning restore 0169

		static IntPtr id_startupPlugins;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginManager']/method[@name='startupPlugins' and count(parameter)=0]"
		[Register ("startupPlugins", "()V", "GetStartupPluginsHandler")]
		public virtual void StartupPlugins ()
		{
			if (id_startupPlugins == IntPtr.Zero)
				id_startupPlugins = JNIEnv.GetMethodID (class_ref, "startupPlugins", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_startupPlugins);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startupPlugins", "()V"));
		}

	}
}
