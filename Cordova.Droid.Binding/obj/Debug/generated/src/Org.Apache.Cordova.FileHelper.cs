using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='FileHelper']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/cordova/FileHelper", DoNotGenerateAcw=true)]
	public partial class FileHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/FileHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileHelper); }
		}

		protected FileHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='FileHelper']/constructor[@name='FileHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public FileHelper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FileHelper)) {
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

		static IntPtr id_getInputStreamFromUriString_Ljava_lang_String_Lorg_apache_cordova_CordovaInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='FileHelper']/method[@name='getInputStreamFromUriString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.apache.cordova.CordovaInterface']]"
		[Register ("getInputStreamFromUriString", "(Ljava/lang/String;Lorg/apache/cordova/CordovaInterface;)Ljava/io/InputStream;", "")]
		public static global::System.IO.Stream GetInputStreamFromUriString (string p0, global::Org.Apache.Cordova.ICordovaInterface p1)
		{
			if (id_getInputStreamFromUriString_Ljava_lang_String_Lorg_apache_cordova_CordovaInterface_ == IntPtr.Zero)
				id_getInputStreamFromUriString_Ljava_lang_String_Lorg_apache_cordova_CordovaInterface_ = JNIEnv.GetStaticMethodID (class_ref, "getInputStreamFromUriString", "(Ljava/lang/String;Lorg/apache/cordova/CordovaInterface;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInputStreamFromUriString_Ljava_lang_String_Lorg_apache_cordova_CordovaInterface_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getMimeType_Ljava_lang_String_Lorg_apache_cordova_CordovaInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='FileHelper']/method[@name='getMimeType' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.apache.cordova.CordovaInterface']]"
		[Register ("getMimeType", "(Ljava/lang/String;Lorg/apache/cordova/CordovaInterface;)Ljava/lang/String;", "")]
		public static string GetMimeType (string p0, global::Org.Apache.Cordova.ICordovaInterface p1)
		{
			if (id_getMimeType_Ljava_lang_String_Lorg_apache_cordova_CordovaInterface_ == IntPtr.Zero)
				id_getMimeType_Ljava_lang_String_Lorg_apache_cordova_CordovaInterface_ = JNIEnv.GetStaticMethodID (class_ref, "getMimeType", "(Ljava/lang/String;Lorg/apache/cordova/CordovaInterface;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMimeType_Ljava_lang_String_Lorg_apache_cordova_CordovaInterface_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getMimeTypeForExtension_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='FileHelper']/method[@name='getMimeTypeForExtension' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMimeTypeForExtension", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string GetMimeTypeForExtension (string p0)
		{
			if (id_getMimeTypeForExtension_Ljava_lang_String_ == IntPtr.Zero)
				id_getMimeTypeForExtension_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getMimeTypeForExtension", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMimeTypeForExtension_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getRealPath_Landroid_net_Uri_Lorg_apache_cordova_CordovaInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='FileHelper']/method[@name='getRealPath' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='org.apache.cordova.CordovaInterface']]"
		[Register ("getRealPath", "(Landroid/net/Uri;Lorg/apache/cordova/CordovaInterface;)Ljava/lang/String;", "")]
		public static string GetRealPath (global::Android.Net.Uri p0, global::Org.Apache.Cordova.ICordovaInterface p1)
		{
			if (id_getRealPath_Landroid_net_Uri_Lorg_apache_cordova_CordovaInterface_ == IntPtr.Zero)
				id_getRealPath_Landroid_net_Uri_Lorg_apache_cordova_CordovaInterface_ = JNIEnv.GetStaticMethodID (class_ref, "getRealPath", "(Landroid/net/Uri;Lorg/apache/cordova/CordovaInterface;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRealPath_Landroid_net_Uri_Lorg_apache_cordova_CordovaInterface_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getRealPath_Ljava_lang_String_Lorg_apache_cordova_CordovaInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='FileHelper']/method[@name='getRealPath' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.apache.cordova.CordovaInterface']]"
		[Register ("getRealPath", "(Ljava/lang/String;Lorg/apache/cordova/CordovaInterface;)Ljava/lang/String;", "")]
		public static string GetRealPath (string p0, global::Org.Apache.Cordova.ICordovaInterface p1)
		{
			if (id_getRealPath_Ljava_lang_String_Lorg_apache_cordova_CordovaInterface_ == IntPtr.Zero)
				id_getRealPath_Ljava_lang_String_Lorg_apache_cordova_CordovaInterface_ = JNIEnv.GetStaticMethodID (class_ref, "getRealPath", "(Ljava/lang/String;Lorg/apache/cordova/CordovaInterface;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRealPath_Ljava_lang_String_Lorg_apache_cordova_CordovaInterface_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_stripFileProtocol_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='FileHelper']/method[@name='stripFileProtocol' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("stripFileProtocol", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string StripFileProtocol (string p0)
		{
			if (id_stripFileProtocol_Ljava_lang_String_ == IntPtr.Zero)
				id_stripFileProtocol_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "stripFileProtocol", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_stripFileProtocol_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
