using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginEntry']"
	[global::Android.Runtime.Register ("org/apache/cordova/PluginEntry", DoNotGenerateAcw=true)]
	public partial class PluginEntry : global::Java.Lang.Object {


		static IntPtr onload_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginEntry']/field[@name='onload']"
		[Register ("onload")]
		public bool Onload {
			get {
				if (onload_jfieldId == IntPtr.Zero)
					onload_jfieldId = JNIEnv.GetFieldID (class_ref, "onload", "Z");
				return JNIEnv.GetBooleanField (Handle, onload_jfieldId);
			}
			set {
				if (onload_jfieldId == IntPtr.Zero)
					onload_jfieldId = JNIEnv.GetFieldID (class_ref, "onload", "Z");
				JNIEnv.SetField (Handle, onload_jfieldId, value);
			}
		}

		static IntPtr plugin_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginEntry']/field[@name='plugin']"
		[Register ("plugin")]
		public global::Org.Apache.Cordova.CordovaPlugin Plugin {
			get {
				if (plugin_jfieldId == IntPtr.Zero)
					plugin_jfieldId = JNIEnv.GetFieldID (class_ref, "plugin", "Lorg/apache/cordova/CordovaPlugin;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, plugin_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPlugin> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (plugin_jfieldId == IntPtr.Zero)
					plugin_jfieldId = JNIEnv.GetFieldID (class_ref, "plugin", "Lorg/apache/cordova/CordovaPlugin;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, plugin_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr pluginClass_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginEntry']/field[@name='pluginClass']"
		[Register ("pluginClass")]
		public string PluginClass {
			get {
				if (pluginClass_jfieldId == IntPtr.Zero)
					pluginClass_jfieldId = JNIEnv.GetFieldID (class_ref, "pluginClass", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, pluginClass_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (pluginClass_jfieldId == IntPtr.Zero)
					pluginClass_jfieldId = JNIEnv.GetFieldID (class_ref, "pluginClass", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, pluginClass_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr service_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginEntry']/field[@name='service']"
		[Register ("service")]
		public string Service {
			get {
				if (service_jfieldId == IntPtr.Zero)
					service_jfieldId = JNIEnv.GetFieldID (class_ref, "service", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, service_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (service_jfieldId == IntPtr.Zero)
					service_jfieldId = JNIEnv.GetFieldID (class_ref, "service", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, service_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/PluginEntry", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PluginEntry); }
		}

		protected PluginEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lorg_apache_cordova_CordovaPlugin_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginEntry']/constructor[@name='PluginEntry' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.apache.cordova.CordovaPlugin']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/apache/cordova/CordovaPlugin;)V", "")]
		public PluginEntry (string p0, global::Org.Apache.Cordova.CordovaPlugin p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (PluginEntry)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lorg/apache/cordova/CordovaPlugin;)V", new JValue (native_p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lorg/apache/cordova/CordovaPlugin;)V", new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_Lorg_apache_cordova_CordovaPlugin_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Lorg_apache_cordova_CordovaPlugin_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lorg/apache/cordova/CordovaPlugin;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lorg_apache_cordova_CordovaPlugin_, new JValue (native_p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lorg_apache_cordova_CordovaPlugin_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginEntry']/constructor[@name='PluginEntry' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Z)V", "")]
		public PluginEntry (string p0, string p1, bool p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (PluginEntry)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Z)V", new JValue (native_p0), new JValue (native_p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Z)V", new JValue (native_p0), new JValue (native_p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Z)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Z, new JValue (native_p0), new JValue (native_p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Z, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_ZLjava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginEntry']/constructor[@name='PluginEntry' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='java.util.List']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;ZLjava/util/List;)V", "")]
		public PluginEntry (string p0, string p1, bool p2, global::System.Collections.Generic.IList<string> p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p3 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p3);;
			if (GetType () != typeof (PluginEntry)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;ZLjava/util/List;)V", new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;ZLjava/util/List;)V", new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_ZLjava_util_List_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_ZLjava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;ZLjava/util/List;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_ZLjava_util_List_, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_ZLjava_util_List_, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_getUrlFilters;
#pragma warning disable 0169
		static Delegate GetGetUrlFiltersHandler ()
		{
			if (cb_getUrlFilters == null)
				cb_getUrlFilters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrlFilters);
			return cb_getUrlFilters;
		}

		static IntPtr n_GetUrlFilters (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.PluginEntry __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.UrlFilters);
		}
#pragma warning restore 0169

		static IntPtr id_getUrlFilters;
		public virtual global::System.Collections.Generic.IList<string> UrlFilters {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginEntry']/method[@name='getUrlFilters' and count(parameter)=0]"
			[Register ("getUrlFilters", "()Ljava/util/List;", "GetGetUrlFiltersHandler")]
			get {
				if (id_getUrlFilters == IntPtr.Zero)
					id_getUrlFilters = JNIEnv.GetMethodID (class_ref, "getUrlFilters", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getUrlFilters), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrlFilters", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
