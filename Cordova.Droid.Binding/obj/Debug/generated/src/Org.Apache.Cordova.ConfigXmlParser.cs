using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='ConfigXmlParser']"
	[global::Android.Runtime.Register ("org/apache/cordova/ConfigXmlParser", DoNotGenerateAcw=true)]
	public partial class ConfigXmlParser : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/ConfigXmlParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConfigXmlParser); }
		}

		protected ConfigXmlParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='ConfigXmlParser']/constructor[@name='ConfigXmlParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ConfigXmlParser () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ConfigXmlParser)) {
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
			global::Org.Apache.Cordova.ConfigXmlParser __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ConfigXmlParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExternalWhitelist);
		}
#pragma warning restore 0169

		static IntPtr id_getExternalWhitelist;
		public virtual global::Org.Apache.Cordova.Whitelist ExternalWhitelist {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='ConfigXmlParser']/method[@name='getExternalWhitelist' and count(parameter)=0]"
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

		static Delegate cb_getInternalWhitelist;
#pragma warning disable 0169
		static Delegate GetGetInternalWhitelistHandler ()
		{
			if (cb_getInternalWhitelist == null)
				cb_getInternalWhitelist = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInternalWhitelist);
			return cb_getInternalWhitelist;
		}

		static IntPtr n_GetInternalWhitelist (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.ConfigXmlParser __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ConfigXmlParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InternalWhitelist);
		}
#pragma warning restore 0169

		static IntPtr id_getInternalWhitelist;
		public virtual global::Org.Apache.Cordova.Whitelist InternalWhitelist {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='ConfigXmlParser']/method[@name='getInternalWhitelist' and count(parameter)=0]"
			[Register ("getInternalWhitelist", "()Lorg/apache/cordova/Whitelist;", "GetGetInternalWhitelistHandler")]
			get {
				if (id_getInternalWhitelist == IntPtr.Zero)
					id_getInternalWhitelist = JNIEnv.GetMethodID (class_ref, "getInternalWhitelist", "()Lorg/apache/cordova/Whitelist;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.Whitelist> (JNIEnv.CallObjectMethod  (Handle, id_getInternalWhitelist), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.Whitelist> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInternalWhitelist", "()Lorg/apache/cordova/Whitelist;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLaunchUrl;
#pragma warning disable 0169
		static Delegate GetGetLaunchUrlHandler ()
		{
			if (cb_getLaunchUrl == null)
				cb_getLaunchUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLaunchUrl);
			return cb_getLaunchUrl;
		}

		static IntPtr n_GetLaunchUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.ConfigXmlParser __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ConfigXmlParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LaunchUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getLaunchUrl;
		public virtual string LaunchUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='ConfigXmlParser']/method[@name='getLaunchUrl' and count(parameter)=0]"
			[Register ("getLaunchUrl", "()Ljava/lang/String;", "GetGetLaunchUrlHandler")]
			get {
				if (id_getLaunchUrl == IntPtr.Zero)
					id_getLaunchUrl = JNIEnv.GetMethodID (class_ref, "getLaunchUrl", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLaunchUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLaunchUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPluginEntries;
#pragma warning disable 0169
		static Delegate GetGetPluginEntriesHandler ()
		{
			if (cb_getPluginEntries == null)
				cb_getPluginEntries = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPluginEntries);
			return cb_getPluginEntries;
		}

		static IntPtr n_GetPluginEntries (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.ConfigXmlParser __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ConfigXmlParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Apache.Cordova.PluginEntry>.ToLocalJniHandle (__this.PluginEntries);
		}
#pragma warning restore 0169

		static IntPtr id_getPluginEntries;
		public virtual global::System.Collections.Generic.IList<global::Org.Apache.Cordova.PluginEntry> PluginEntries {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='ConfigXmlParser']/method[@name='getPluginEntries' and count(parameter)=0]"
			[Register ("getPluginEntries", "()Ljava/util/ArrayList;", "GetGetPluginEntriesHandler")]
			get {
				if (id_getPluginEntries == IntPtr.Zero)
					id_getPluginEntries = JNIEnv.GetMethodID (class_ref, "getPluginEntries", "()Ljava/util/ArrayList;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Org.Apache.Cordova.PluginEntry>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPluginEntries), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Org.Apache.Cordova.PluginEntry>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPluginEntries", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Apache.Cordova.ConfigXmlParser __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ConfigXmlParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Preferences);
		}
#pragma warning restore 0169

		static IntPtr id_getPreferences;
		public virtual global::Org.Apache.Cordova.CordovaPreferences Preferences {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='ConfigXmlParser']/method[@name='getPreferences' and count(parameter)=0]"
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

		static Delegate cb_parse_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetParse_Landroid_app_Activity_Handler ()
		{
			if (cb_parse_Landroid_app_Activity_ == null)
				cb_parse_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Parse_Landroid_app_Activity_);
			return cb_parse_Landroid_app_Activity_;
		}

		static void n_Parse_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.ConfigXmlParser __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ConfigXmlParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Parse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_parse_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='ConfigXmlParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("parse", "(Landroid/app/Activity;)V", "GetParse_Landroid_app_Activity_Handler")]
		public virtual void Parse (global::Android.App.Activity p0)
		{
			if (id_parse_Landroid_app_Activity_ == IntPtr.Zero)
				id_parse_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "parse", "(Landroid/app/Activity;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_parse_Landroid_app_Activity_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parse", "(Landroid/app/Activity;)V"), new JValue (p0));
		}

		static Delegate cb_parse_Landroid_content_res_XmlResourceParser_;
#pragma warning disable 0169
		static Delegate GetParse_Landroid_content_res_XmlResourceParser_Handler ()
		{
			if (cb_parse_Landroid_content_res_XmlResourceParser_ == null)
				cb_parse_Landroid_content_res_XmlResourceParser_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Parse_Landroid_content_res_XmlResourceParser_);
			return cb_parse_Landroid_content_res_XmlResourceParser_;
		}

		static void n_Parse_Landroid_content_res_XmlResourceParser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.ConfigXmlParser __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ConfigXmlParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Xml.XmlReader p0 = global::Android.Runtime.XmlResourceParserReader.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Parse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_parse_Landroid_content_res_XmlResourceParser_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='ConfigXmlParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='android.content.res.XmlResourceParser']]"
		[Register ("parse", "(Landroid/content/res/XmlResourceParser;)V", "GetParse_Landroid_content_res_XmlResourceParser_Handler")]
		public virtual void Parse (global::System.Xml.XmlReader p0)
		{
			if (id_parse_Landroid_content_res_XmlResourceParser_ == IntPtr.Zero)
				id_parse_Landroid_content_res_XmlResourceParser_ = JNIEnv.GetMethodID (class_ref, "parse", "(Landroid/content/res/XmlResourceParser;)V");
			IntPtr native_p0 = global::Android.Runtime.XmlReaderResourceParser.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_parse_Landroid_content_res_XmlResourceParser_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parse", "(Landroid/content/res/XmlResourceParser;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
