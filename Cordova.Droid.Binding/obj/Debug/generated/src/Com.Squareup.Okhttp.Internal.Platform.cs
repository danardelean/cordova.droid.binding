using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Squareup.Okhttp.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform']"
	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/Platform", DoNotGenerateAcw=true)]
	public partial class Platform : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform.Android23']"
		[global::Android.Runtime.Register ("com/squareup/okhttp/internal/Platform$Android23", DoNotGenerateAcw=true)]
		public partial class Android23 : global::Com.Squareup.Okhttp.Internal.Platform {


			static IntPtr openSslSocketClass_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform.Android23']/field[@name='openSslSocketClass']"
			[Register ("openSslSocketClass")]
			protected global::Java.Lang.Class OpenSslSocketClass {
				get {
					if (openSslSocketClass_jfieldId == IntPtr.Zero)
						openSslSocketClass_jfieldId = JNIEnv.GetFieldID (class_ref, "openSslSocketClass", "Ljava/lang/Class;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, openSslSocketClass_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (openSslSocketClass_jfieldId == IntPtr.Zero)
						openSslSocketClass_jfieldId = JNIEnv.GetFieldID (class_ref, "openSslSocketClass", "Ljava/lang/Class;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, openSslSocketClass_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/squareup/okhttp/internal/Platform$Android23", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Android23); }
			}

			protected Android23 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform.Android41']"
		[global::Android.Runtime.Register ("com/squareup/okhttp/internal/Platform$Android41", DoNotGenerateAcw=true)]
		public partial class Android41 : global::Com.Squareup.Okhttp.Internal.Platform.Android23 {

			protected Android41 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform.JdkWithJettyNpnPlatform']"
		[global::Android.Runtime.Register ("com/squareup/okhttp/internal/Platform$JdkWithJettyNpnPlatform", DoNotGenerateAcw=true)]
		public partial class JdkWithJettyNpnPlatform : global::Com.Squareup.Okhttp.Internal.Platform {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/squareup/okhttp/internal/Platform$JdkWithJettyNpnPlatform", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (JdkWithJettyNpnPlatform); }
			}

			protected JdkWithJettyNpnPlatform (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_reflect_Method_Ljava_lang_reflect_Method_Ljava_lang_Class_Ljava_lang_Class_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform.JdkWithJettyNpnPlatform']/constructor[@name='Platform.JdkWithJettyNpnPlatform' and count(parameter)=4 and parameter[1][@type='java.lang.reflect.Method'] and parameter[2][@type='java.lang.reflect.Method'] and parameter[3][@type='java.lang.Class'] and parameter[4][@type='java.lang.Class']]"
			[Register (".ctor", "(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/Class;Ljava/lang/Class;)V", "")]
			public JdkWithJettyNpnPlatform (global::Java.Lang.Reflect.Method p0, global::Java.Lang.Reflect.Method p1, global::Java.Lang.Class p2, global::Java.Lang.Class p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (JdkWithJettyNpnPlatform)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/Class;Ljava/lang/Class;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/Class;Ljava/lang/Class;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
					return;
				}

				if (id_ctor_Ljava_lang_reflect_Method_Ljava_lang_reflect_Method_Ljava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
					id_ctor_Ljava_lang_reflect_Method_Ljava_lang_reflect_Method_Ljava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/Class;Ljava/lang/Class;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_reflect_Method_Ljava_lang_reflect_Method_Ljava_lang_Class_Ljava_lang_Class_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_reflect_Method_Ljava_lang_reflect_Method_Ljava_lang_Class_Ljava_lang_Class_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform.JettyNpnProvider']"
		[global::Android.Runtime.Register ("com/squareup/okhttp/internal/Platform$JettyNpnProvider", DoNotGenerateAcw=true)]
		public partial class JettyNpnProvider : global::Java.Lang.Object, global::Java.Lang.Reflect.IInvocationHandler {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/squareup/okhttp/internal/Platform$JettyNpnProvider", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (JettyNpnProvider); }
			}

			protected JettyNpnProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_util_List_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform.JettyNpnProvider']/constructor[@name='Platform.JettyNpnProvider' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register (".ctor", "(Ljava/util/List;)V", "")]
			public JettyNpnProvider (global::System.Collections.Generic.IList<string> p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);;
				if (GetType () != typeof (JettyNpnProvider)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/List;)V", new JValue (native_p0)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/List;)V", new JValue (native_p0));
					JNIEnv.DeleteLocalRef (native_p0);
					return;
				}

				if (id_ctor_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_, new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_List_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler ()
			{
				if (cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == null)
					cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_);
				return cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
			}

			static IntPtr n_Invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Squareup.Okhttp.Internal.Platform.JettyNpnProvider __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Platform.JettyNpnProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Reflect.Method p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object[] p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Invoke (p0, p1, p2));
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform.JettyNpnProvider']/method[@name='invoke' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Method'] and parameter[3][@type='java.lang.Object[]']]"
			[Register ("invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;", "GetInvoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler")]
			public virtual global::Java.Lang.Object Invoke (global::Java.Lang.Object p0, global::Java.Lang.Reflect.Method p1, global::Java.Lang.Object[] p2)
			{
				if (id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;");
				IntPtr native_p2 = JNIEnv.NewArray (p2);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;"), new JValue (p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/squareup/okhttp/internal/Platform", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Platform); }
		}

		protected Platform (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform']/constructor[@name='Platform' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Platform () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Platform)) {
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

		static Delegate cb_getPrefix;
#pragma warning disable 0169
		static Delegate GetGetPrefixHandler ()
		{
			if (cb_getPrefix == null)
				cb_getPrefix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrefix);
			return cb_getPrefix;
		}

		static IntPtr n_GetPrefix (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Okhttp.Internal.Platform __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Prefix);
		}
#pragma warning restore 0169

		static IntPtr id_getPrefix;
		public virtual string Prefix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform']/method[@name='getPrefix' and count(parameter)=0]"
			[Register ("getPrefix", "()Ljava/lang/String;", "GetGetPrefixHandler")]
			get {
				if (id_getPrefix == IntPtr.Zero)
					id_getPrefix = JNIEnv.GetMethodID (class_ref, "getPrefix", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPrefix), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrefix", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_connectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I;
#pragma warning disable 0169
		static Delegate GetConnectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_IHandler ()
		{
			if (cb_connectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I == null)
				cb_connectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ConnectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I);
			return cb_connectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I;
		}

		static void n_ConnectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Squareup.Okhttp.Internal.Platform __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.Socket p0 = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.InetSocketAddress p1 = global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ConnectSocket (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_connectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform']/method[@name='connectSocket' and count(parameter)=3 and parameter[1][@type='java.net.Socket'] and parameter[2][@type='java.net.InetSocketAddress'] and parameter[3][@type='int']]"
		[Register ("connectSocket", "(Ljava/net/Socket;Ljava/net/InetSocketAddress;I)V", "GetConnectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_IHandler")]
		public virtual void ConnectSocket (global::Java.Net.Socket p0, global::Java.Net.InetSocketAddress p1, int p2)
		{
			if (id_connectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I == IntPtr.Zero)
				id_connectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I = JNIEnv.GetMethodID (class_ref, "connectSocket", "(Ljava/net/Socket;Ljava/net/InetSocketAddress;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_connectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectSocket", "(Ljava/net/Socket;Ljava/net/InetSocketAddress;I)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_enableTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnableTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Handler ()
		{
			if (cb_enableTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_ == null)
				cb_enableTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_EnableTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_);
			return cb_enableTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_;
		}

		static void n_EnableTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Squareup.Okhttp.Internal.Platform __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.SSLSocket p0 = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.EnableTlsExtensions (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_enableTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform']/method[@name='enableTlsExtensions' and count(parameter)=2 and parameter[1][@type='javax.net.ssl.SSLSocket'] and parameter[2][@type='java.lang.String']]"
		[Register ("enableTlsExtensions", "(Ljavax/net/ssl/SSLSocket;Ljava/lang/String;)V", "GetEnableTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Handler")]
		public virtual void EnableTlsExtensions (global::Javax.Net.Ssl.SSLSocket p0, string p1)
		{
			if (id_enableTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_ == IntPtr.Zero)
				id_enableTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "enableTlsExtensions", "(Ljavax/net/ssl/SSLSocket;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_enableTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableTlsExtensions", "(Ljavax/net/ssl/SSLSocket;Ljava/lang/String;)V"), new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lcom/squareup/okhttp/internal/Platform;", "")]
		public static global::Com.Squareup.Okhttp.Internal.Platform Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetStaticMethodID (class_ref, "get", "()Lcom/squareup/okhttp/internal/Platform;");
			return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Platform> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getNpnSelectedProtocol_Ljavax_net_ssl_SSLSocket_;
#pragma warning disable 0169
		static Delegate GetGetNpnSelectedProtocol_Ljavax_net_ssl_SSLSocket_Handler ()
		{
			if (cb_getNpnSelectedProtocol_Ljavax_net_ssl_SSLSocket_ == null)
				cb_getNpnSelectedProtocol_Ljavax_net_ssl_SSLSocket_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetNpnSelectedProtocol_Ljavax_net_ssl_SSLSocket_);
			return cb_getNpnSelectedProtocol_Ljavax_net_ssl_SSLSocket_;
		}

		static IntPtr n_GetNpnSelectedProtocol_Ljavax_net_ssl_SSLSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Squareup.Okhttp.Internal.Platform __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.SSLSocket p0 = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetNpnSelectedProtocol (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getNpnSelectedProtocol_Ljavax_net_ssl_SSLSocket_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform']/method[@name='getNpnSelectedProtocol' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSocket']]"
		[Register ("getNpnSelectedProtocol", "(Ljavax/net/ssl/SSLSocket;)[B", "GetGetNpnSelectedProtocol_Ljavax_net_ssl_SSLSocket_Handler")]
		public virtual byte[] GetNpnSelectedProtocol (global::Javax.Net.Ssl.SSLSocket p0)
		{
			if (id_getNpnSelectedProtocol_Ljavax_net_ssl_SSLSocket_ == IntPtr.Zero)
				id_getNpnSelectedProtocol_Ljavax_net_ssl_SSLSocket_ = JNIEnv.GetMethodID (class_ref, "getNpnSelectedProtocol", "(Ljavax/net/ssl/SSLSocket;)[B");

			byte[] __ret;
			if (GetType () == ThresholdType)
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getNpnSelectedProtocol_Ljavax_net_ssl_SSLSocket_, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNpnSelectedProtocol", "(Ljavax/net/ssl/SSLSocket;)[B"), new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			return __ret;
		}

		static Delegate cb_logW_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLogW_Ljava_lang_String_Handler ()
		{
			if (cb_logW_Ljava_lang_String_ == null)
				cb_logW_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LogW_Ljava_lang_String_);
			return cb_logW_Ljava_lang_String_;
		}

		static void n_LogW_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Squareup.Okhttp.Internal.Platform __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LogW (p0);
		}
#pragma warning restore 0169

		static IntPtr id_logW_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform']/method[@name='logW' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logW", "(Ljava/lang/String;)V", "GetLogW_Ljava_lang_String_Handler")]
		public virtual void LogW (string p0)
		{
			if (id_logW_Ljava_lang_String_ == IntPtr.Zero)
				id_logW_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "logW", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_logW_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logW", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_newDeflaterOutputStream_Ljava_io_OutputStream_Ljava_util_zip_Deflater_Z;
#pragma warning disable 0169
		static Delegate GetNewDeflaterOutputStream_Ljava_io_OutputStream_Ljava_util_zip_Deflater_ZHandler ()
		{
			if (cb_newDeflaterOutputStream_Ljava_io_OutputStream_Ljava_util_zip_Deflater_Z == null)
				cb_newDeflaterOutputStream_Ljava_io_OutputStream_Ljava_util_zip_Deflater_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_NewDeflaterOutputStream_Ljava_io_OutputStream_Ljava_util_zip_Deflater_Z);
			return cb_newDeflaterOutputStream_Ljava_io_OutputStream_Ljava_util_zip_Deflater_Z;
		}

		static IntPtr n_NewDeflaterOutputStream_Ljava_io_OutputStream_Ljava_util_zip_Deflater_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Squareup.Okhttp.Internal.Platform __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Zip.Deflater p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Zip.Deflater> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.NewDeflaterOutputStream (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newDeflaterOutputStream_Ljava_io_OutputStream_Ljava_util_zip_Deflater_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform']/method[@name='newDeflaterOutputStream' and count(parameter)=3 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='java.util.zip.Deflater'] and parameter[3][@type='boolean']]"
		[Register ("newDeflaterOutputStream", "(Ljava/io/OutputStream;Ljava/util/zip/Deflater;Z)Ljava/io/OutputStream;", "GetNewDeflaterOutputStream_Ljava_io_OutputStream_Ljava_util_zip_Deflater_ZHandler")]
		public virtual global::System.IO.Stream NewDeflaterOutputStream (global::System.IO.Stream p0, global::Java.Util.Zip.Deflater p1, bool p2)
		{
			if (id_newDeflaterOutputStream_Ljava_io_OutputStream_Ljava_util_zip_Deflater_Z == IntPtr.Zero)
				id_newDeflaterOutputStream_Ljava_io_OutputStream_Ljava_util_zip_Deflater_Z = JNIEnv.GetMethodID (class_ref, "newDeflaterOutputStream", "(Ljava/io/OutputStream;Ljava/util/zip/Deflater;Z)Ljava/io/OutputStream;");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_newDeflaterOutputStream_Ljava_io_OutputStream_Ljava_util_zip_Deflater_Z, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newDeflaterOutputStream", "(Ljava/io/OutputStream;Ljava/util/zip/Deflater;Z)Ljava/io/OutputStream;"), new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setNpnProtocols_Ljavax_net_ssl_SSLSocket_arrayB;
#pragma warning disable 0169
		static Delegate GetSetNpnProtocols_Ljavax_net_ssl_SSLSocket_arrayBHandler ()
		{
			if (cb_setNpnProtocols_Ljavax_net_ssl_SSLSocket_arrayB == null)
				cb_setNpnProtocols_Ljavax_net_ssl_SSLSocket_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetNpnProtocols_Ljavax_net_ssl_SSLSocket_arrayB);
			return cb_setNpnProtocols_Ljavax_net_ssl_SSLSocket_arrayB;
		}

		static void n_SetNpnProtocols_Ljavax_net_ssl_SSLSocket_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Squareup.Okhttp.Internal.Platform __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.SSLSocket p0 = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetNpnProtocols (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_setNpnProtocols_Ljavax_net_ssl_SSLSocket_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform']/method[@name='setNpnProtocols' and count(parameter)=2 and parameter[1][@type='javax.net.ssl.SSLSocket'] and parameter[2][@type='byte[]']]"
		[Register ("setNpnProtocols", "(Ljavax/net/ssl/SSLSocket;[B)V", "GetSetNpnProtocols_Ljavax_net_ssl_SSLSocket_arrayBHandler")]
		public virtual void SetNpnProtocols (global::Javax.Net.Ssl.SSLSocket p0, byte[] p1)
		{
			if (id_setNpnProtocols_Ljavax_net_ssl_SSLSocket_arrayB == IntPtr.Zero)
				id_setNpnProtocols_Ljavax_net_ssl_SSLSocket_arrayB = JNIEnv.GetMethodID (class_ref, "setNpnProtocols", "(Ljavax/net/ssl/SSLSocket;[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setNpnProtocols_Ljavax_net_ssl_SSLSocket_arrayB, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNpnProtocols", "(Ljavax/net/ssl/SSLSocket;[B)V"), new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_supportTlsIntolerantServer_Ljavax_net_ssl_SSLSocket_;
#pragma warning disable 0169
		static Delegate GetSupportTlsIntolerantServer_Ljavax_net_ssl_SSLSocket_Handler ()
		{
			if (cb_supportTlsIntolerantServer_Ljavax_net_ssl_SSLSocket_ == null)
				cb_supportTlsIntolerantServer_Ljavax_net_ssl_SSLSocket_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SupportTlsIntolerantServer_Ljavax_net_ssl_SSLSocket_);
			return cb_supportTlsIntolerantServer_Ljavax_net_ssl_SSLSocket_;
		}

		static void n_SupportTlsIntolerantServer_Ljavax_net_ssl_SSLSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Squareup.Okhttp.Internal.Platform __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.SSLSocket p0 = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SupportTlsIntolerantServer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_supportTlsIntolerantServer_Ljavax_net_ssl_SSLSocket_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform']/method[@name='supportTlsIntolerantServer' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSocket']]"
		[Register ("supportTlsIntolerantServer", "(Ljavax/net/ssl/SSLSocket;)V", "GetSupportTlsIntolerantServer_Ljavax_net_ssl_SSLSocket_Handler")]
		public virtual void SupportTlsIntolerantServer (global::Javax.Net.Ssl.SSLSocket p0)
		{
			if (id_supportTlsIntolerantServer_Ljavax_net_ssl_SSLSocket_ == IntPtr.Zero)
				id_supportTlsIntolerantServer_Ljavax_net_ssl_SSLSocket_ = JNIEnv.GetMethodID (class_ref, "supportTlsIntolerantServer", "(Ljavax/net/ssl/SSLSocket;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_supportTlsIntolerantServer_Ljavax_net_ssl_SSLSocket_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "supportTlsIntolerantServer", "(Ljavax/net/ssl/SSLSocket;)V"), new JValue (p0));
		}

		static Delegate cb_tagSocket_Ljava_net_Socket_;
#pragma warning disable 0169
		static Delegate GetTagSocket_Ljava_net_Socket_Handler ()
		{
			if (cb_tagSocket_Ljava_net_Socket_ == null)
				cb_tagSocket_Ljava_net_Socket_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TagSocket_Ljava_net_Socket_);
			return cb_tagSocket_Ljava_net_Socket_;
		}

		static void n_TagSocket_Ljava_net_Socket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Squareup.Okhttp.Internal.Platform __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.Socket p0 = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TagSocket (p0);
		}
#pragma warning restore 0169

		static IntPtr id_tagSocket_Ljava_net_Socket_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform']/method[@name='tagSocket' and count(parameter)=1 and parameter[1][@type='java.net.Socket']]"
		[Register ("tagSocket", "(Ljava/net/Socket;)V", "GetTagSocket_Ljava_net_Socket_Handler")]
		public virtual void TagSocket (global::Java.Net.Socket p0)
		{
			if (id_tagSocket_Ljava_net_Socket_ == IntPtr.Zero)
				id_tagSocket_Ljava_net_Socket_ = JNIEnv.GetMethodID (class_ref, "tagSocket", "(Ljava/net/Socket;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_tagSocket_Ljava_net_Socket_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tagSocket", "(Ljava/net/Socket;)V"), new JValue (p0));
		}

		static Delegate cb_toUriLenient_Ljava_net_URL_;
#pragma warning disable 0169
		static Delegate GetToUriLenient_Ljava_net_URL_Handler ()
		{
			if (cb_toUriLenient_Ljava_net_URL_ == null)
				cb_toUriLenient_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToUriLenient_Ljava_net_URL_);
			return cb_toUriLenient_Ljava_net_URL_;
		}

		static IntPtr n_ToUriLenient_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Squareup.Okhttp.Internal.Platform __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URL p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToUriLenient (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toUriLenient_Ljava_net_URL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform']/method[@name='toUriLenient' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("toUriLenient", "(Ljava/net/URL;)Ljava/net/URI;", "GetToUriLenient_Ljava_net_URL_Handler")]
		public virtual global::Java.Net.URI ToUriLenient (global::Java.Net.URL p0)
		{
			if (id_toUriLenient_Ljava_net_URL_ == IntPtr.Zero)
				id_toUriLenient_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "toUriLenient", "(Ljava/net/URL;)Ljava/net/URI;");

			global::Java.Net.URI __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (JNIEnv.CallObjectMethod  (Handle, id_toUriLenient_Ljava_net_URL_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toUriLenient", "(Ljava/net/URL;)Ljava/net/URI;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_untagSocket_Ljava_net_Socket_;
#pragma warning disable 0169
		static Delegate GetUntagSocket_Ljava_net_Socket_Handler ()
		{
			if (cb_untagSocket_Ljava_net_Socket_ == null)
				cb_untagSocket_Ljava_net_Socket_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UntagSocket_Ljava_net_Socket_);
			return cb_untagSocket_Ljava_net_Socket_;
		}

		static void n_UntagSocket_Ljava_net_Socket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Squareup.Okhttp.Internal.Platform __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.Socket p0 = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UntagSocket (p0);
		}
#pragma warning restore 0169

		static IntPtr id_untagSocket_Ljava_net_Socket_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Platform']/method[@name='untagSocket' and count(parameter)=1 and parameter[1][@type='java.net.Socket']]"
		[Register ("untagSocket", "(Ljava/net/Socket;)V", "GetUntagSocket_Ljava_net_Socket_Handler")]
		public virtual void UntagSocket (global::Java.Net.Socket p0)
		{
			if (id_untagSocket_Ljava_net_Socket_ == IntPtr.Zero)
				id_untagSocket_Ljava_net_Socket_ = JNIEnv.GetMethodID (class_ref, "untagSocket", "(Ljava/net/Socket;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_untagSocket_Ljava_net_Socket_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "untagSocket", "(Ljava/net/Socket;)V"), new JValue (p0));
		}

	}
}
