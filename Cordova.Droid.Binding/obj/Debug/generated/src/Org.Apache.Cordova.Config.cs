using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='Config']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/cordova/Config", DoNotGenerateAcw=true)]
	public partial class Config : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/Config", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Config); }
		}

		protected Config (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getErrorUrl;
		public static string ErrorUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='Config']/method[@name='getErrorUrl' and count(parameter)=0]"
			[Register ("getErrorUrl", "()Ljava/lang/String;", "GetGetErrorUrlHandler")]
			get {
				if (id_getErrorUrl == IntPtr.Zero)
					id_getErrorUrl = JNIEnv.GetStaticMethodID (class_ref, "getErrorUrl", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getErrorUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getExternalWhitelist;
		public static global::Org.Apache.Cordova.Whitelist ExternalWhitelist {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='Config']/method[@name='getExternalWhitelist' and count(parameter)=0]"
			[Register ("getExternalWhitelist", "()Lorg/apache/cordova/Whitelist;", "GetGetExternalWhitelistHandler")]
			get {
				if (id_getExternalWhitelist == IntPtr.Zero)
					id_getExternalWhitelist = JNIEnv.GetStaticMethodID (class_ref, "getExternalWhitelist", "()Lorg/apache/cordova/Whitelist;");
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.Whitelist> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getExternalWhitelist), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isInitialized;
		public static bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='Config']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetStaticMethodID (class_ref, "isInitialized", "()Z");
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isInitialized);
			}
		}

		static IntPtr id_getPluginEntries;
		public static global::System.Collections.Generic.IList<global::Org.Apache.Cordova.PluginEntry> PluginEntries {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='Config']/method[@name='getPluginEntries' and count(parameter)=0]"
			[Register ("getPluginEntries", "()Ljava/util/List;", "GetGetPluginEntriesHandler")]
			get {
				if (id_getPluginEntries == IntPtr.Zero)
					id_getPluginEntries = JNIEnv.GetStaticMethodID (class_ref, "getPluginEntries", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Org.Apache.Cordova.PluginEntry>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPluginEntries), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getPreferences;
		public static global::Org.Apache.Cordova.CordovaPreferences Preferences {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='Config']/method[@name='getPreferences' and count(parameter)=0]"
			[Register ("getPreferences", "()Lorg/apache/cordova/CordovaPreferences;", "GetGetPreferencesHandler")]
			get {
				if (id_getPreferences == IntPtr.Zero)
					id_getPreferences = JNIEnv.GetStaticMethodID (class_ref, "getPreferences", "()Lorg/apache/cordova/CordovaPreferences;");
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPreferences> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPreferences), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getStartUrl;
		public static string StartUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='Config']/method[@name='getStartUrl' and count(parameter)=0]"
			[Register ("getStartUrl", "()Ljava/lang/String;", "GetGetStartUrlHandler")]
			get {
				if (id_getStartUrl == IntPtr.Zero)
					id_getStartUrl = JNIEnv.GetStaticMethodID (class_ref, "getStartUrl", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStartUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getWhitelist;
		public static global::Org.Apache.Cordova.Whitelist Whitelist {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='Config']/method[@name='getWhitelist' and count(parameter)=0]"
			[Register ("getWhitelist", "()Lorg/apache/cordova/Whitelist;", "GetGetWhitelistHandler")]
			get {
				if (id_getWhitelist == IntPtr.Zero)
					id_getWhitelist = JNIEnv.GetStaticMethodID (class_ref, "getWhitelist", "()Lorg/apache/cordova/Whitelist;");
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.Whitelist> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getWhitelist), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_addWhiteListEntry_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='Config']/method[@name='addWhiteListEntry' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("addWhiteListEntry", "(Ljava/lang/String;Z)V", "")]
		public static void AddWhiteListEntry (string p0, bool p1)
		{
			if (id_addWhiteListEntry_Ljava_lang_String_Z == IntPtr.Zero)
				id_addWhiteListEntry_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "addWhiteListEntry", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_addWhiteListEntry_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='Config']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "")]
		public static void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetStaticMethodID (class_ref, "init", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_init);
		}

		static IntPtr id_init_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='Config']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("init", "(Landroid/app/Activity;)V", "")]
		public static void Init (global::Android.App.Activity p0)
		{
			if (id_init_Landroid_app_Activity_ == IntPtr.Zero)
				id_init_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/app/Activity;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_app_Activity_, new JValue (p0));
		}

		static IntPtr id_isUrlExternallyWhiteListed_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='Config']/method[@name='isUrlExternallyWhiteListed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isUrlExternallyWhiteListed", "(Ljava/lang/String;)Z", "")]
		public static bool IsUrlExternallyWhiteListed (string p0)
		{
			if (id_isUrlExternallyWhiteListed_Ljava_lang_String_ == IntPtr.Zero)
				id_isUrlExternallyWhiteListed_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isUrlExternallyWhiteListed", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isUrlExternallyWhiteListed_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_isUrlWhiteListed_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='Config']/method[@name='isUrlWhiteListed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isUrlWhiteListed", "(Ljava/lang/String;)Z", "")]
		public static bool IsUrlWhiteListed (string p0)
		{
			if (id_isUrlWhiteListed_Ljava_lang_String_ == IntPtr.Zero)
				id_isUrlWhiteListed_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isUrlWhiteListed", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isUrlWhiteListed_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
