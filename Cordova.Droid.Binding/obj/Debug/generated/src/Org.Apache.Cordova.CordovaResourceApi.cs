using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']"
	[global::Android.Runtime.Register ("org/apache/cordova/CordovaResourceApi", DoNotGenerateAcw=true)]
	public partial class CordovaResourceApi : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/field[@name='URI_TYPE_ASSET']"
		[Register ("URI_TYPE_ASSET")]
		public const int UriTypeAsset = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/field[@name='URI_TYPE_CONTENT']"
		[Register ("URI_TYPE_CONTENT")]
		public const int UriTypeContent = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/field[@name='URI_TYPE_DATA']"
		[Register ("URI_TYPE_DATA")]
		public const int UriTypeData = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/field[@name='URI_TYPE_FILE']"
		[Register ("URI_TYPE_FILE")]
		public const int UriTypeFile = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/field[@name='URI_TYPE_HTTP']"
		[Register ("URI_TYPE_HTTP")]
		public const int UriTypeHttp = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/field[@name='URI_TYPE_HTTPS']"
		[Register ("URI_TYPE_HTTPS")]
		public const int UriTypeHttps = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/field[@name='URI_TYPE_RESOURCE']"
		[Register ("URI_TYPE_RESOURCE")]
		public const int UriTypeResource = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/field[@name='URI_TYPE_UNKNOWN']"
		[Register ("URI_TYPE_UNKNOWN")]
		public const int UriTypeUnknown = (int) -1;
		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi.OpenForReadResult']"
		[global::Android.Runtime.Register ("org/apache/cordova/CordovaResourceApi$OpenForReadResult", DoNotGenerateAcw=true)]
		public sealed partial class OpenForReadResult : global::Java.Lang.Object {


			static IntPtr assetFd_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi.OpenForReadResult']/field[@name='assetFd']"
			[Register ("assetFd")]
			public global::Android.Content.Res.AssetFileDescriptor AssetFd {
				get {
					if (assetFd_jfieldId == IntPtr.Zero)
						assetFd_jfieldId = JNIEnv.GetFieldID (class_ref, "assetFd", "Landroid/content/res/AssetFileDescriptor;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, assetFd_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Res.AssetFileDescriptor> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (assetFd_jfieldId == IntPtr.Zero)
						assetFd_jfieldId = JNIEnv.GetFieldID (class_ref, "assetFd", "Landroid/content/res/AssetFileDescriptor;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, assetFd_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr inputStream_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi.OpenForReadResult']/field[@name='inputStream']"
			[Register ("inputStream")]
			public global::System.IO.Stream InputStream {
				get {
					if (inputStream_jfieldId == IntPtr.Zero)
						inputStream_jfieldId = JNIEnv.GetFieldID (class_ref, "inputStream", "Ljava/io/InputStream;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, inputStream_jfieldId);
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (inputStream_jfieldId == IntPtr.Zero)
						inputStream_jfieldId = JNIEnv.GetFieldID (class_ref, "inputStream", "Ljava/io/InputStream;");
					IntPtr native_value = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, inputStream_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr length_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi.OpenForReadResult']/field[@name='length']"
			[Register ("length")]
			public long Length {
				get {
					if (length_jfieldId == IntPtr.Zero)
						length_jfieldId = JNIEnv.GetFieldID (class_ref, "length", "J");
					return JNIEnv.GetLongField (Handle, length_jfieldId);
				}
				set {
					if (length_jfieldId == IntPtr.Zero)
						length_jfieldId = JNIEnv.GetFieldID (class_ref, "length", "J");
					JNIEnv.SetField (Handle, length_jfieldId, value);
				}
			}

			static IntPtr mimeType_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi.OpenForReadResult']/field[@name='mimeType']"
			[Register ("mimeType")]
			public string MimeType {
				get {
					if (mimeType_jfieldId == IntPtr.Zero)
						mimeType_jfieldId = JNIEnv.GetFieldID (class_ref, "mimeType", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, mimeType_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mimeType_jfieldId == IntPtr.Zero)
						mimeType_jfieldId = JNIEnv.GetFieldID (class_ref, "mimeType", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					JNIEnv.SetField (Handle, mimeType_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr uri_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi.OpenForReadResult']/field[@name='uri']"
			[Register ("uri")]
			public global::Android.Net.Uri Uri {
				get {
					if (uri_jfieldId == IntPtr.Zero)
						uri_jfieldId = JNIEnv.GetFieldID (class_ref, "uri", "Landroid/net/Uri;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, uri_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (uri_jfieldId == IntPtr.Zero)
						uri_jfieldId = JNIEnv.GetFieldID (class_ref, "uri", "Landroid/net/Uri;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, uri_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/apache/cordova/CordovaResourceApi$OpenForReadResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OpenForReadResult); }
			}

			internal OpenForReadResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/CordovaResourceApi", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CordovaResourceApi); }
		}

		protected CordovaResourceApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lorg_apache_cordova_PluginManager_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/constructor[@name='CordovaResourceApi' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.apache.cordova.PluginManager']]"
		[Register (".ctor", "(Landroid/content/Context;Lorg/apache/cordova/PluginManager;)V", "")]
		public CordovaResourceApi (global::Android.Content.Context p0, global::Org.Apache.Cordova.PluginManager p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CordovaResourceApi)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lorg/apache/cordova/PluginManager;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lorg/apache/cordova/PluginManager;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Lorg_apache_cordova_PluginManager_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lorg_apache_cordova_PluginManager_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lorg/apache/cordova/PluginManager;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lorg_apache_cordova_PluginManager_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lorg_apache_cordova_PluginManager_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_isThreadCheckingEnabled;
#pragma warning disable 0169
		static Delegate GetIsThreadCheckingEnabledHandler ()
		{
			if (cb_isThreadCheckingEnabled == null)
				cb_isThreadCheckingEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsThreadCheckingEnabled);
			return cb_isThreadCheckingEnabled;
		}

		static bool n_IsThreadCheckingEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaResourceApi __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaResourceApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ThreadCheckingEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setThreadCheckingEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetThreadCheckingEnabled_ZHandler ()
		{
			if (cb_setThreadCheckingEnabled_Z == null)
				cb_setThreadCheckingEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetThreadCheckingEnabled_Z);
			return cb_setThreadCheckingEnabled_Z;
		}

		static void n_SetThreadCheckingEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Apache.Cordova.CordovaResourceApi __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaResourceApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ThreadCheckingEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isThreadCheckingEnabled;
		static IntPtr id_setThreadCheckingEnabled_Z;
		public virtual bool ThreadCheckingEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/method[@name='isThreadCheckingEnabled' and count(parameter)=0]"
			[Register ("isThreadCheckingEnabled", "()Z", "GetIsThreadCheckingEnabledHandler")]
			get {
				if (id_isThreadCheckingEnabled == IntPtr.Zero)
					id_isThreadCheckingEnabled = JNIEnv.GetMethodID (class_ref, "isThreadCheckingEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isThreadCheckingEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isThreadCheckingEnabled", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/method[@name='setThreadCheckingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setThreadCheckingEnabled", "(Z)V", "GetSetThreadCheckingEnabled_ZHandler")]
			set {
				if (id_setThreadCheckingEnabled_Z == IntPtr.Zero)
					id_setThreadCheckingEnabled_Z = JNIEnv.GetMethodID (class_ref, "setThreadCheckingEnabled", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setThreadCheckingEnabled_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setThreadCheckingEnabled", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_copyResource_Landroid_net_Uri_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetCopyResource_Landroid_net_Uri_Landroid_net_Uri_Handler ()
		{
			if (cb_copyResource_Landroid_net_Uri_Landroid_net_Uri_ == null)
				cb_copyResource_Landroid_net_Uri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CopyResource_Landroid_net_Uri_Landroid_net_Uri_);
			return cb_copyResource_Landroid_net_Uri_Landroid_net_Uri_;
		}

		static void n_CopyResource_Landroid_net_Uri_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Apache.Cordova.CordovaResourceApi __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaResourceApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CopyResource (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_copyResource_Landroid_net_Uri_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/method[@name='copyResource' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.net.Uri']]"
		[Register ("copyResource", "(Landroid/net/Uri;Landroid/net/Uri;)V", "GetCopyResource_Landroid_net_Uri_Landroid_net_Uri_Handler")]
		public virtual void CopyResource (global::Android.Net.Uri p0, global::Android.Net.Uri p1)
		{
			if (id_copyResource_Landroid_net_Uri_Landroid_net_Uri_ == IntPtr.Zero)
				id_copyResource_Landroid_net_Uri_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "copyResource", "(Landroid/net/Uri;Landroid/net/Uri;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_copyResource_Landroid_net_Uri_Landroid_net_Uri_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copyResource", "(Landroid/net/Uri;Landroid/net/Uri;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_copyResource_Landroid_net_Uri_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetCopyResource_Landroid_net_Uri_Ljava_io_OutputStream_Handler ()
		{
			if (cb_copyResource_Landroid_net_Uri_Ljava_io_OutputStream_ == null)
				cb_copyResource_Landroid_net_Uri_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CopyResource_Landroid_net_Uri_Ljava_io_OutputStream_);
			return cb_copyResource_Landroid_net_Uri_Ljava_io_OutputStream_;
		}

		static void n_CopyResource_Landroid_net_Uri_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Apache.Cordova.CordovaResourceApi __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaResourceApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p1 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CopyResource (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_copyResource_Landroid_net_Uri_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/method[@name='copyResource' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("copyResource", "(Landroid/net/Uri;Ljava/io/OutputStream;)V", "GetCopyResource_Landroid_net_Uri_Ljava_io_OutputStream_Handler")]
		public virtual void CopyResource (global::Android.Net.Uri p0, global::System.IO.Stream p1)
		{
			if (id_copyResource_Landroid_net_Uri_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_copyResource_Landroid_net_Uri_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "copyResource", "(Landroid/net/Uri;Ljava/io/OutputStream;)V");
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_copyResource_Landroid_net_Uri_Ljava_io_OutputStream_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copyResource", "(Landroid/net/Uri;Ljava/io/OutputStream;)V"), new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_copyResource_Lorg_apache_cordova_CordovaResourceApi_OpenForReadResult_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetCopyResource_Lorg_apache_cordova_CordovaResourceApi_OpenForReadResult_Ljava_io_OutputStream_Handler ()
		{
			if (cb_copyResource_Lorg_apache_cordova_CordovaResourceApi_OpenForReadResult_Ljava_io_OutputStream_ == null)
				cb_copyResource_Lorg_apache_cordova_CordovaResourceApi_OpenForReadResult_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CopyResource_Lorg_apache_cordova_CordovaResourceApi_OpenForReadResult_Ljava_io_OutputStream_);
			return cb_copyResource_Lorg_apache_cordova_CordovaResourceApi_OpenForReadResult_Ljava_io_OutputStream_;
		}

		static void n_CopyResource_Lorg_apache_cordova_CordovaResourceApi_OpenForReadResult_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Apache.Cordova.CordovaResourceApi __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaResourceApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.CordovaResourceApi.OpenForReadResult p0 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaResourceApi.OpenForReadResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p1 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CopyResource (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_copyResource_Lorg_apache_cordova_CordovaResourceApi_OpenForReadResult_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/method[@name='copyResource' and count(parameter)=2 and parameter[1][@type='org.apache.cordova.CordovaResourceApi.OpenForReadResult'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("copyResource", "(Lorg/apache/cordova/CordovaResourceApi$OpenForReadResult;Ljava/io/OutputStream;)V", "GetCopyResource_Lorg_apache_cordova_CordovaResourceApi_OpenForReadResult_Ljava_io_OutputStream_Handler")]
		public virtual void CopyResource (global::Org.Apache.Cordova.CordovaResourceApi.OpenForReadResult p0, global::System.IO.Stream p1)
		{
			if (id_copyResource_Lorg_apache_cordova_CordovaResourceApi_OpenForReadResult_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_copyResource_Lorg_apache_cordova_CordovaResourceApi_OpenForReadResult_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "copyResource", "(Lorg/apache/cordova/CordovaResourceApi$OpenForReadResult;Ljava/io/OutputStream;)V");
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_copyResource_Lorg_apache_cordova_CordovaResourceApi_OpenForReadResult_Ljava_io_OutputStream_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copyResource", "(Lorg/apache/cordova/CordovaResourceApi$OpenForReadResult;Ljava/io/OutputStream;)V"), new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_createHttpConnection_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetCreateHttpConnection_Landroid_net_Uri_Handler ()
		{
			if (cb_createHttpConnection_Landroid_net_Uri_ == null)
				cb_createHttpConnection_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateHttpConnection_Landroid_net_Uri_);
			return cb_createHttpConnection_Landroid_net_Uri_;
		}

		static IntPtr n_CreateHttpConnection_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaResourceApi __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaResourceApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateHttpConnection (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createHttpConnection_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/method[@name='createHttpConnection' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("createHttpConnection", "(Landroid/net/Uri;)Ljava/net/HttpURLConnection;", "GetCreateHttpConnection_Landroid_net_Uri_Handler")]
		public virtual global::Java.Net.HttpURLConnection CreateHttpConnection (global::Android.Net.Uri p0)
		{
			if (id_createHttpConnection_Landroid_net_Uri_ == IntPtr.Zero)
				id_createHttpConnection_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "createHttpConnection", "(Landroid/net/Uri;)Ljava/net/HttpURLConnection;");

			global::Java.Net.HttpURLConnection __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (JNIEnv.CallObjectMethod  (Handle, id_createHttpConnection_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createHttpConnection", "(Landroid/net/Uri;)Ljava/net/HttpURLConnection;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getMimeType_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetGetMimeType_Landroid_net_Uri_Handler ()
		{
			if (cb_getMimeType_Landroid_net_Uri_ == null)
				cb_getMimeType_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMimeType_Landroid_net_Uri_);
			return cb_getMimeType_Landroid_net_Uri_;
		}

		static IntPtr n_GetMimeType_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaResourceApi __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaResourceApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetMimeType (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMimeType_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/method[@name='getMimeType' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("getMimeType", "(Landroid/net/Uri;)Ljava/lang/String;", "GetGetMimeType_Landroid_net_Uri_Handler")]
		public virtual string GetMimeType (global::Android.Net.Uri p0)
		{
			if (id_getMimeType_Landroid_net_Uri_ == IntPtr.Zero)
				id_getMimeType_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "getMimeType", "(Landroid/net/Uri;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMimeType_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMimeType", "(Landroid/net/Uri;)Ljava/lang/String;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getUriType_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/method[@name='getUriType' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("getUriType", "(Landroid/net/Uri;)I", "")]
		public static int GetUriType (global::Android.Net.Uri p0)
		{
			if (id_getUriType_Landroid_net_Uri_ == IntPtr.Zero)
				id_getUriType_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "getUriType", "(Landroid/net/Uri;)I");
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getUriType_Landroid_net_Uri_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_mapUriToFile_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetMapUriToFile_Landroid_net_Uri_Handler ()
		{
			if (cb_mapUriToFile_Landroid_net_Uri_ == null)
				cb_mapUriToFile_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MapUriToFile_Landroid_net_Uri_);
			return cb_mapUriToFile_Landroid_net_Uri_;
		}

		static IntPtr n_MapUriToFile_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaResourceApi __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaResourceApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MapUriToFile (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_mapUriToFile_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/method[@name='mapUriToFile' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("mapUriToFile", "(Landroid/net/Uri;)Ljava/io/File;", "GetMapUriToFile_Landroid_net_Uri_Handler")]
		public virtual global::Java.IO.File MapUriToFile (global::Android.Net.Uri p0)
		{
			if (id_mapUriToFile_Landroid_net_Uri_ == IntPtr.Zero)
				id_mapUriToFile_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "mapUriToFile", "(Landroid/net/Uri;)Ljava/io/File;");

			global::Java.IO.File __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_mapUriToFile_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mapUriToFile", "(Landroid/net/Uri;)Ljava/io/File;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_openForRead_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetOpenForRead_Landroid_net_Uri_Handler ()
		{
			if (cb_openForRead_Landroid_net_Uri_ == null)
				cb_openForRead_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OpenForRead_Landroid_net_Uri_);
			return cb_openForRead_Landroid_net_Uri_;
		}

		static IntPtr n_OpenForRead_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaResourceApi __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaResourceApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OpenForRead (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_openForRead_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/method[@name='openForRead' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("openForRead", "(Landroid/net/Uri;)Lorg/apache/cordova/CordovaResourceApi$OpenForReadResult;", "GetOpenForRead_Landroid_net_Uri_Handler")]
		public virtual global::Org.Apache.Cordova.CordovaResourceApi.OpenForReadResult OpenForRead (global::Android.Net.Uri p0)
		{
			if (id_openForRead_Landroid_net_Uri_ == IntPtr.Zero)
				id_openForRead_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "openForRead", "(Landroid/net/Uri;)Lorg/apache/cordova/CordovaResourceApi$OpenForReadResult;");

			global::Org.Apache.Cordova.CordovaResourceApi.OpenForReadResult __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaResourceApi.OpenForReadResult> (JNIEnv.CallObjectMethod  (Handle, id_openForRead_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaResourceApi.OpenForReadResult> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openForRead", "(Landroid/net/Uri;)Lorg/apache/cordova/CordovaResourceApi$OpenForReadResult;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_openForRead_Landroid_net_Uri_Z;
#pragma warning disable 0169
		static Delegate GetOpenForRead_Landroid_net_Uri_ZHandler ()
		{
			if (cb_openForRead_Landroid_net_Uri_Z == null)
				cb_openForRead_Landroid_net_Uri_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_OpenForRead_Landroid_net_Uri_Z);
			return cb_openForRead_Landroid_net_Uri_Z;
		}

		static IntPtr n_OpenForRead_Landroid_net_Uri_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Org.Apache.Cordova.CordovaResourceApi __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaResourceApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OpenForRead (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_openForRead_Landroid_net_Uri_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/method[@name='openForRead' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='boolean']]"
		[Register ("openForRead", "(Landroid/net/Uri;Z)Lorg/apache/cordova/CordovaResourceApi$OpenForReadResult;", "GetOpenForRead_Landroid_net_Uri_ZHandler")]
		public virtual global::Org.Apache.Cordova.CordovaResourceApi.OpenForReadResult OpenForRead (global::Android.Net.Uri p0, bool p1)
		{
			if (id_openForRead_Landroid_net_Uri_Z == IntPtr.Zero)
				id_openForRead_Landroid_net_Uri_Z = JNIEnv.GetMethodID (class_ref, "openForRead", "(Landroid/net/Uri;Z)Lorg/apache/cordova/CordovaResourceApi$OpenForReadResult;");

			global::Org.Apache.Cordova.CordovaResourceApi.OpenForReadResult __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaResourceApi.OpenForReadResult> (JNIEnv.CallObjectMethod  (Handle, id_openForRead_Landroid_net_Uri_Z, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaResourceApi.OpenForReadResult> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openForRead", "(Landroid/net/Uri;Z)Lorg/apache/cordova/CordovaResourceApi$OpenForReadResult;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_openOutputStream_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetOpenOutputStream_Landroid_net_Uri_Handler ()
		{
			if (cb_openOutputStream_Landroid_net_Uri_ == null)
				cb_openOutputStream_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OpenOutputStream_Landroid_net_Uri_);
			return cb_openOutputStream_Landroid_net_Uri_;
		}

		static IntPtr n_OpenOutputStream_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaResourceApi __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaResourceApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OpenOutputStream (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_openOutputStream_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/method[@name='openOutputStream' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("openOutputStream", "(Landroid/net/Uri;)Ljava/io/OutputStream;", "GetOpenOutputStream_Landroid_net_Uri_Handler")]
		public virtual global::System.IO.Stream OpenOutputStream (global::Android.Net.Uri p0)
		{
			if (id_openOutputStream_Landroid_net_Uri_ == IntPtr.Zero)
				id_openOutputStream_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "openOutputStream", "(Landroid/net/Uri;)Ljava/io/OutputStream;");

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_openOutputStream_Landroid_net_Uri_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openOutputStream", "(Landroid/net/Uri;)Ljava/io/OutputStream;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_openOutputStream_Landroid_net_Uri_Z;
#pragma warning disable 0169
		static Delegate GetOpenOutputStream_Landroid_net_Uri_ZHandler ()
		{
			if (cb_openOutputStream_Landroid_net_Uri_Z == null)
				cb_openOutputStream_Landroid_net_Uri_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_OpenOutputStream_Landroid_net_Uri_Z);
			return cb_openOutputStream_Landroid_net_Uri_Z;
		}

		static IntPtr n_OpenOutputStream_Landroid_net_Uri_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Org.Apache.Cordova.CordovaResourceApi __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaResourceApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OpenOutputStream (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_openOutputStream_Landroid_net_Uri_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/method[@name='openOutputStream' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='boolean']]"
		[Register ("openOutputStream", "(Landroid/net/Uri;Z)Ljava/io/OutputStream;", "GetOpenOutputStream_Landroid_net_Uri_ZHandler")]
		public virtual global::System.IO.Stream OpenOutputStream (global::Android.Net.Uri p0, bool p1)
		{
			if (id_openOutputStream_Landroid_net_Uri_Z == IntPtr.Zero)
				id_openOutputStream_Landroid_net_Uri_Z = JNIEnv.GetMethodID (class_ref, "openOutputStream", "(Landroid/net/Uri;Z)Ljava/io/OutputStream;");

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_openOutputStream_Landroid_net_Uri_Z, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openOutputStream", "(Landroid/net/Uri;Z)Ljava/io/OutputStream;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_remapPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemapPath_Ljava_lang_String_Handler ()
		{
			if (cb_remapPath_Ljava_lang_String_ == null)
				cb_remapPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemapPath_Ljava_lang_String_);
			return cb_remapPath_Ljava_lang_String_;
		}

		static IntPtr n_RemapPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaResourceApi __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaResourceApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.RemapPath (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_remapPath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/method[@name='remapPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remapPath", "(Ljava/lang/String;)Ljava/lang/String;", "GetRemapPath_Ljava_lang_String_Handler")]
		public virtual string RemapPath (string p0)
		{
			if (id_remapPath_Ljava_lang_String_ == IntPtr.Zero)
				id_remapPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remapPath", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_remapPath_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remapPath", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Org.Apache.Cordova.CordovaResourceApi __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaResourceApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemapUri (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_remapUri_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaResourceApi']/method[@name='remapUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
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
