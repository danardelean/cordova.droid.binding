using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Squareup.Okhttp.Internal.Tls {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal.tls']/class[@name='OkHostnameVerifier']"
	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/tls/OkHostnameVerifier", DoNotGenerateAcw=true)]
	public sealed partial class OkHostnameVerifier : global::Java.Lang.Object, global::Javax.Net.Ssl.IHostnameVerifier {


		static IntPtr INSTANCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal.tls']/class[@name='OkHostnameVerifier']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Squareup.Okhttp.Internal.Tls.OkHostnameVerifier Instance {
			get {
				if (INSTANCE_jfieldId == IntPtr.Zero)
					INSTANCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANCE", "Lcom/squareup/okhttp/internal/tls/OkHostnameVerifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTANCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Tls.OkHostnameVerifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INSTANCE_jfieldId == IntPtr.Zero)
					INSTANCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANCE", "Lcom/squareup/okhttp/internal/tls/OkHostnameVerifier;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, INSTANCE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/squareup/okhttp/internal/tls/OkHostnameVerifier", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OkHostnameVerifier); }
		}

		internal OkHostnameVerifier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_verify_Ljava_lang_String_Ljava_security_cert_X509Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.tls']/class[@name='OkHostnameVerifier']/method[@name='verify' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.security.cert.X509Certificate']]"
		[Register ("verify", "(Ljava/lang/String;Ljava/security/cert/X509Certificate;)Z", "")]
		public bool Verify (string p0, global::Java.Security.Cert.X509Certificate p1)
		{
			if (id_verify_Ljava_lang_String_Ljava_security_cert_X509Certificate_ == IntPtr.Zero)
				id_verify_Ljava_lang_String_Ljava_security_cert_X509Certificate_ = JNIEnv.GetMethodID (class_ref, "verify", "(Ljava/lang/String;Ljava/security/cert/X509Certificate;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_verify_Ljava_lang_String_Ljava_security_cert_X509Certificate_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_verify_Ljava_lang_String_Ljavax_net_ssl_SSLSession_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.tls']/class[@name='OkHostnameVerifier']/method[@name='verify' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='javax.net.ssl.SSLSession']]"
		[Register ("verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z", "")]
		public bool Verify (string p0, global::Javax.Net.Ssl.ISSLSession p1)
		{
			if (id_verify_Ljava_lang_String_Ljavax_net_ssl_SSLSession_ == IntPtr.Zero)
				id_verify_Ljava_lang_String_Ljavax_net_ssl_SSLSession_ = JNIEnv.GetMethodID (class_ref, "verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_verify_Ljava_lang_String_Ljavax_net_ssl_SSLSession_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_verifyHostName_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.tls']/class[@name='OkHostnameVerifier']/method[@name='verifyHostName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("verifyHostName", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public bool VerifyHostName (string p0, string p1)
		{
			if (id_verifyHostName_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_verifyHostName_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "verifyHostName", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_verifyHostName_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
