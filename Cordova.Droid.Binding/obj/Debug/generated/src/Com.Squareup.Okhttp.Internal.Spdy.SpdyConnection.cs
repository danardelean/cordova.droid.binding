using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Squareup.Okhttp.Internal.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection']"
	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/spdy/SpdyConnection", DoNotGenerateAcw=true)]
	public sealed partial class SpdyConnection : global::Java.Lang.Object, global::Java.IO.ICloseable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection.Builder']"
		[global::Android.Runtime.Register ("com/squareup/okhttp/internal/spdy/SpdyConnection$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/squareup/okhttp/internal/spdy/SpdyConnection$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_ZLjava_net_Socket_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection.Builder']/constructor[@name='SpdyConnection.Builder' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.net.Socket']]"
			[Register (".ctor", "(ZLjava/net/Socket;)V", "")]
			public Builder (bool p0, global::Java.Net.Socket p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Builder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ZLjava/net/Socket;)V", new JValue (p0), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ZLjava/net/Socket;)V", new JValue (p0), new JValue (p1));
					return;
				}

				if (id_ctor_ZLjava_net_Socket_ == IntPtr.Zero)
					id_ctor_ZLjava_net_Socket_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ZLjava/net/Socket;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ZLjava_net_Socket_, new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ZLjava_net_Socket_, new JValue (p0), new JValue (p1));
			}

			static IntPtr id_ctor_ZLjava_io_InputStream_Ljava_io_OutputStream_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection.Builder']/constructor[@name='SpdyConnection.Builder' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.io.InputStream'] and parameter[3][@type='java.io.OutputStream']]"
			[Register (".ctor", "(ZLjava/io/InputStream;Ljava/io/OutputStream;)V", "")]
			public Builder (bool p0, global::System.IO.Stream p1, global::System.IO.Stream p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p1);;
				IntPtr native_p2 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p2);;
				if (GetType () != typeof (Builder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ZLjava/io/InputStream;Ljava/io/OutputStream;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ZLjava/io/InputStream;Ljava/io/OutputStream;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2));
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
					return;
				}

				if (id_ctor_ZLjava_io_InputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
					id_ctor_ZLjava_io_InputStream_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ZLjava/io/InputStream;Ljava/io/OutputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ZLjava_io_InputStream_Ljava_io_OutputStream_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ZLjava_io_InputStream_Ljava_io_OutputStream_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}

			static IntPtr id_ctor_Ljava_lang_String_ZLjava_net_Socket_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection.Builder']/constructor[@name='SpdyConnection.Builder' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='java.net.Socket']]"
			[Register (".ctor", "(Ljava/lang/String;ZLjava/net/Socket;)V", "")]
			public Builder (string p0, bool p1, global::Java.Net.Socket p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);;
				if (GetType () != typeof (Builder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;ZLjava/net/Socket;)V", new JValue (native_p0), new JValue (p1), new JValue (p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;ZLjava/net/Socket;)V", new JValue (native_p0), new JValue (p1), new JValue (p2));
					JNIEnv.DeleteLocalRef (native_p0);
					return;
				}

				if (id_ctor_Ljava_lang_String_ZLjava_net_Socket_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ZLjava_net_Socket_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;ZLjava/net/Socket;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_ZLjava_net_Socket_, new JValue (native_p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_ZLjava_net_Socket_, new JValue (native_p0), new JValue (p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static IntPtr id_ctor_Ljava_lang_String_ZLjava_io_InputStream_Ljava_io_OutputStream_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection.Builder']/constructor[@name='SpdyConnection.Builder' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='java.io.InputStream'] and parameter[4][@type='java.io.OutputStream']]"
			[Register (".ctor", "(Ljava/lang/String;ZLjava/io/InputStream;Ljava/io/OutputStream;)V", "")]
			public Builder (string p0, bool p1, global::System.IO.Stream p2, global::System.IO.Stream p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);;
				IntPtr native_p2 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p2);;
				IntPtr native_p3 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p3);;
				if (GetType () != typeof (Builder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;ZLjava/io/InputStream;Ljava/io/OutputStream;)V", new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;ZLjava/io/InputStream;Ljava/io/OutputStream;)V", new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3));
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p2);
					JNIEnv.DeleteLocalRef (native_p3);
					return;
				}

				if (id_ctor_Ljava_lang_String_ZLjava_io_InputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ZLjava_io_InputStream_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;ZLjava/io/InputStream;Ljava/io/OutputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_ZLjava_io_InputStream_Ljava_io_OutputStream_, new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_ZLjava_io_InputStream_Ljava_io_OutputStream_, new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/squareup/okhttp/internal/spdy/SpdyConnection;", "GetBuildHandler")]
			public virtual global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/squareup/okhttp/internal/spdy/SpdyConnection;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/squareup/okhttp/internal/spdy/SpdyConnection;")), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_handler_Lcom_squareup_okhttp_internal_spdy_IncomingStreamHandler_;
#pragma warning disable 0169
			static Delegate GetHandler_Lcom_squareup_okhttp_internal_spdy_IncomingStreamHandler_Handler ()
			{
				if (cb_handler_Lcom_squareup_okhttp_internal_spdy_IncomingStreamHandler_ == null)
					cb_handler_Lcom_squareup_okhttp_internal_spdy_IncomingStreamHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Handler_Lcom_squareup_okhttp_internal_spdy_IncomingStreamHandler_);
				return cb_handler_Lcom_squareup_okhttp_internal_spdy_IncomingStreamHandler_;
			}

			static IntPtr n_Handler_Lcom_squareup_okhttp_internal_spdy_IncomingStreamHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Squareup.Okhttp.Internal.Spdy.IIncomingStreamHandler p0 = (global::Com.Squareup.Okhttp.Internal.Spdy.IIncomingStreamHandler)global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IIncomingStreamHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Handler (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_handler_Lcom_squareup_okhttp_internal_spdy_IncomingStreamHandler_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection.Builder']/method[@name='handler' and count(parameter)=1 and parameter[1][@type='com.squareup.okhttp.internal.spdy.IncomingStreamHandler']]"
			[Register ("handler", "(Lcom/squareup/okhttp/internal/spdy/IncomingStreamHandler;)Lcom/squareup/okhttp/internal/spdy/SpdyConnection$Builder;", "GetHandler_Lcom_squareup_okhttp_internal_spdy_IncomingStreamHandler_Handler")]
			public virtual global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Builder Handler (global::Com.Squareup.Okhttp.Internal.Spdy.IIncomingStreamHandler p0)
			{
				if (id_handler_Lcom_squareup_okhttp_internal_spdy_IncomingStreamHandler_ == IntPtr.Zero)
					id_handler_Lcom_squareup_okhttp_internal_spdy_IncomingStreamHandler_ = JNIEnv.GetMethodID (class_ref, "handler", "(Lcom/squareup/okhttp/internal/spdy/IncomingStreamHandler;)Lcom/squareup/okhttp/internal/spdy/SpdyConnection$Builder;");

				global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Builder> (JNIEnv.CallObjectMethod  (Handle, id_handler_Lcom_squareup_okhttp_internal_spdy_IncomingStreamHandler_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handler", "(Lcom/squareup/okhttp/internal/spdy/IncomingStreamHandler;)Lcom/squareup/okhttp/internal/spdy/SpdyConnection$Builder;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_http20Draft06;
#pragma warning disable 0169
			static Delegate GetHttp20Draft06Handler ()
			{
				if (cb_http20Draft06 == null)
					cb_http20Draft06 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Http20Draft06);
				return cb_http20Draft06;
			}

			static IntPtr n_Http20Draft06 (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Http20Draft06 ());
			}
#pragma warning restore 0169

			static IntPtr id_http20Draft06;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection.Builder']/method[@name='http20Draft06' and count(parameter)=0]"
			[Register ("http20Draft06", "()Lcom/squareup/okhttp/internal/spdy/SpdyConnection$Builder;", "GetHttp20Draft06Handler")]
			public virtual global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Builder Http20Draft06 ()
			{
				if (id_http20Draft06 == IntPtr.Zero)
					id_http20Draft06 = JNIEnv.GetMethodID (class_ref, "http20Draft06", "()Lcom/squareup/okhttp/internal/spdy/SpdyConnection$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Builder> (JNIEnv.CallObjectMethod  (Handle, id_http20Draft06), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "http20Draft06", "()Lcom/squareup/okhttp/internal/spdy/SpdyConnection$Builder;")), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_spdy3;
#pragma warning disable 0169
			static Delegate GetSpdy3Handler ()
			{
				if (cb_spdy3 == null)
					cb_spdy3 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Spdy3);
				return cb_spdy3;
			}

			static IntPtr n_Spdy3 (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Spdy3 ());
			}
#pragma warning restore 0169

			static IntPtr id_spdy3;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection.Builder']/method[@name='spdy3' and count(parameter)=0]"
			[Register ("spdy3", "()Lcom/squareup/okhttp/internal/spdy/SpdyConnection$Builder;", "GetSpdy3Handler")]
			public virtual global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Builder Spdy3 ()
			{
				if (id_spdy3 == IntPtr.Zero)
					id_spdy3 = JNIEnv.GetMethodID (class_ref, "spdy3", "()Lcom/squareup/okhttp/internal/spdy/SpdyConnection$Builder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Builder> (JNIEnv.CallObjectMethod  (Handle, id_spdy3), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "spdy3", "()Lcom/squareup/okhttp/internal/spdy/SpdyConnection$Builder;")), JniHandleOwnership.TransferLocalRef);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection.Reader']"
		[global::Android.Runtime.Register ("com/squareup/okhttp/internal/spdy/SpdyConnection$Reader", DoNotGenerateAcw=true)]
		public partial class Reader : global::Java.Lang.Object, global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandler, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/squareup/okhttp/internal/spdy/SpdyConnection$Reader", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Reader); }
			}

			protected Reader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_data_ZILjava_io_InputStream_I;
#pragma warning disable 0169
			static Delegate GetData_ZILjava_io_InputStream_IHandler ()
			{
				if (cb_data_ZILjava_io_InputStream_I == null)
					cb_data_ZILjava_io_InputStream_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, IntPtr, int>) n_Data_ZILjava_io_InputStream_I);
				return cb_data_ZILjava_io_InputStream_I;
			}

			static void n_Data_ZILjava_io_InputStream_I (IntPtr jnienv, IntPtr native__this, bool p0, int p1, IntPtr native_p2, int p3)
			{
				global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Reader __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Reader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.IO.Stream p2 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.Data (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_data_ZILjava_io_InputStream_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection.Reader']/method[@name='data' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='java.io.InputStream'] and parameter[4][@type='int']]"
			[Register ("data", "(ZILjava/io/InputStream;I)V", "GetData_ZILjava_io_InputStream_IHandler")]
			public virtual void Data (bool p0, int p1, global::System.IO.Stream p2, int p3)
			{
				if (id_data_ZILjava_io_InputStream_I == IntPtr.Zero)
					id_data_ZILjava_io_InputStream_I = JNIEnv.GetMethodID (class_ref, "data", "(ZILjava/io/InputStream;I)V");
				IntPtr native_p2 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_data_ZILjava_io_InputStream_I, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "data", "(ZILjava/io/InputStream;I)V"), new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p2);
			}

			static Delegate cb_goAway_ILcom_squareup_okhttp_internal_spdy_ErrorCode_;
#pragma warning disable 0169
			static Delegate GetGoAway_ILcom_squareup_okhttp_internal_spdy_ErrorCode_Handler ()
			{
				if (cb_goAway_ILcom_squareup_okhttp_internal_spdy_ErrorCode_ == null)
					cb_goAway_ILcom_squareup_okhttp_internal_spdy_ErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_GoAway_ILcom_squareup_okhttp_internal_spdy_ErrorCode_);
				return cb_goAway_ILcom_squareup_okhttp_internal_spdy_ErrorCode_;
			}

			static void n_GoAway_ILcom_squareup_okhttp_internal_spdy_ErrorCode_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Reader __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Reader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode p1 = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.GoAway (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_goAway_ILcom_squareup_okhttp_internal_spdy_ErrorCode_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection.Reader']/method[@name='goAway' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.squareup.okhttp.internal.spdy.ErrorCode']]"
			[Register ("goAway", "(ILcom/squareup/okhttp/internal/spdy/ErrorCode;)V", "GetGoAway_ILcom_squareup_okhttp_internal_spdy_ErrorCode_Handler")]
			public virtual void GoAway (int p0, global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode p1)
			{
				if (id_goAway_ILcom_squareup_okhttp_internal_spdy_ErrorCode_ == IntPtr.Zero)
					id_goAway_ILcom_squareup_okhttp_internal_spdy_ErrorCode_ = JNIEnv.GetMethodID (class_ref, "goAway", "(ILcom/squareup/okhttp/internal/spdy/ErrorCode;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_goAway_ILcom_squareup_okhttp_internal_spdy_ErrorCode_, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "goAway", "(ILcom/squareup/okhttp/internal/spdy/ErrorCode;)V"), new JValue (p0), new JValue (p1));
			}

			static Delegate cb_noop;
#pragma warning disable 0169
			static Delegate GetNoopHandler ()
			{
				if (cb_noop == null)
					cb_noop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Noop);
				return cb_noop;
			}

			static void n_Noop (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Reader __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Reader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Noop ();
			}
#pragma warning restore 0169

			static IntPtr id_noop;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection.Reader']/method[@name='noop' and count(parameter)=0]"
			[Register ("noop", "()V", "GetNoopHandler")]
			public virtual void Noop ()
			{
				if (id_noop == IntPtr.Zero)
					id_noop = JNIEnv.GetMethodID (class_ref, "noop", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_noop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "noop", "()V"));
			}

			static Delegate cb_ping_ZII;
#pragma warning disable 0169
			static Delegate GetPing_ZIIHandler ()
			{
				if (cb_ping_ZII == null)
					cb_ping_ZII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int>) n_Ping_ZII);
				return cb_ping_ZII;
			}

			static void n_Ping_ZII (IntPtr jnienv, IntPtr native__this, bool p0, int p1, int p2)
			{
				global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Reader __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Reader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Ping (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_ping_ZII;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection.Reader']/method[@name='ping' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("ping", "(ZII)V", "GetPing_ZIIHandler")]
			public virtual void Ping (bool p0, int p1, int p2)
			{
				if (id_ping_ZII == IntPtr.Zero)
					id_ping_ZII = JNIEnv.GetMethodID (class_ref, "ping", "(ZII)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_ping_ZII, new JValue (p0), new JValue (p1), new JValue (p2));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ping", "(ZII)V"), new JValue (p0), new JValue (p1), new JValue (p2));
			}

			static Delegate cb_priority_II;
#pragma warning disable 0169
			static Delegate GetPriority_IIHandler ()
			{
				if (cb_priority_II == null)
					cb_priority_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_Priority_II);
				return cb_priority_II;
			}

			static void n_Priority_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Reader __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Reader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Priority (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_priority_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection.Reader']/method[@name='priority' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("priority", "(II)V", "GetPriority_IIHandler")]
			public virtual void Priority (int p0, int p1)
			{
				if (id_priority_II == IntPtr.Zero)
					id_priority_II = JNIEnv.GetMethodID (class_ref, "priority", "(II)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_priority_II, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "priority", "(II)V"), new JValue (p0), new JValue (p1));
			}

			static Delegate cb_rstStream_ILcom_squareup_okhttp_internal_spdy_ErrorCode_;
#pragma warning disable 0169
			static Delegate GetRstStream_ILcom_squareup_okhttp_internal_spdy_ErrorCode_Handler ()
			{
				if (cb_rstStream_ILcom_squareup_okhttp_internal_spdy_ErrorCode_ == null)
					cb_rstStream_ILcom_squareup_okhttp_internal_spdy_ErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_RstStream_ILcom_squareup_okhttp_internal_spdy_ErrorCode_);
				return cb_rstStream_ILcom_squareup_okhttp_internal_spdy_ErrorCode_;
			}

			static void n_RstStream_ILcom_squareup_okhttp_internal_spdy_ErrorCode_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Reader __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Reader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode p1 = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.RstStream (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_rstStream_ILcom_squareup_okhttp_internal_spdy_ErrorCode_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection.Reader']/method[@name='rstStream' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.squareup.okhttp.internal.spdy.ErrorCode']]"
			[Register ("rstStream", "(ILcom/squareup/okhttp/internal/spdy/ErrorCode;)V", "GetRstStream_ILcom_squareup_okhttp_internal_spdy_ErrorCode_Handler")]
			public virtual void RstStream (int p0, global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode p1)
			{
				if (id_rstStream_ILcom_squareup_okhttp_internal_spdy_ErrorCode_ == IntPtr.Zero)
					id_rstStream_ILcom_squareup_okhttp_internal_spdy_ErrorCode_ = JNIEnv.GetMethodID (class_ref, "rstStream", "(ILcom/squareup/okhttp/internal/spdy/ErrorCode;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_rstStream_ILcom_squareup_okhttp_internal_spdy_ErrorCode_, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rstStream", "(ILcom/squareup/okhttp/internal/spdy/ErrorCode;)V"), new JValue (p0), new JValue (p1));
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Reader __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Reader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection.Reader']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			}

			static Delegate cb_windowUpdate_IIZ;
#pragma warning disable 0169
			static Delegate GetWindowUpdate_IIZHandler ()
			{
				if (cb_windowUpdate_IIZ == null)
					cb_windowUpdate_IIZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, bool>) n_WindowUpdate_IIZ);
				return cb_windowUpdate_IIZ;
			}

			static void n_WindowUpdate_IIZ (IntPtr jnienv, IntPtr native__this, int p0, int p1, bool p2)
			{
				global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Reader __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection.Reader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.WindowUpdate (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_windowUpdate_IIZ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection.Reader']/method[@name='windowUpdate' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
			[Register ("windowUpdate", "(IIZ)V", "GetWindowUpdate_IIZHandler")]
			public virtual void WindowUpdate (int p0, int p1, bool p2)
			{
				if (id_windowUpdate_IIZ == IntPtr.Zero)
					id_windowUpdate_IIZ = JNIEnv.GetMethodID (class_ref, "windowUpdate", "(IIZ)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_windowUpdate_IIZ, new JValue (p0), new JValue (p1), new JValue (p2));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "windowUpdate", "(IIZ)V"), new JValue (p0), new JValue (p1), new JValue (p2));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/squareup/okhttp/internal/spdy/SpdyConnection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpdyConnection); }
		}

		internal SpdyConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getIdleStartTimeNs;
		public long IdleStartTimeNs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection']/method[@name='getIdleStartTimeNs' and count(parameter)=0]"
			[Register ("getIdleStartTimeNs", "()J", "GetGetIdleStartTimeNsHandler")]
			get {
				if (id_getIdleStartTimeNs == IntPtr.Zero)
					id_getIdleStartTimeNs = JNIEnv.GetMethodID (class_ref, "getIdleStartTimeNs", "()J");
				return JNIEnv.CallLongMethod  (Handle, id_getIdleStartTimeNs);
			}
		}

		static IntPtr id_isIdle;
		public bool IsIdle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection']/method[@name='isIdle' and count(parameter)=0]"
			[Register ("isIdle", "()Z", "GetIsIdleHandler")]
			get {
				if (id_isIdle == IntPtr.Zero)
					id_isIdle = JNIEnv.GetMethodID (class_ref, "isIdle", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isIdle);
			}
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_close);
		}

		static IntPtr id_flush;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "")]
		public void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_flush);
		}

		static IntPtr id_newStream_Ljava_util_List_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection']/method[@name='newStream' and count(parameter)=3 and parameter[1][@type='java.util.List'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("newStream", "(Ljava/util/List;ZZ)Lcom/squareup/okhttp/internal/spdy/SpdyStream;", "")]
		public global::Com.Squareup.Okhttp.Internal.Spdy.SpdyStream NewStream (global::System.Collections.Generic.IList<string> p0, bool p1, bool p2)
		{
			if (id_newStream_Ljava_util_List_ZZ == IntPtr.Zero)
				id_newStream_Ljava_util_List_ZZ = JNIEnv.GetMethodID (class_ref, "newStream", "(Ljava/util/List;ZZ)Lcom/squareup/okhttp/internal/spdy/SpdyStream;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			global::Com.Squareup.Okhttp.Internal.Spdy.SpdyStream __ret = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyStream> (JNIEnv.CallObjectMethod  (Handle, id_newStream_Ljava_util_List_ZZ, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_noop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection']/method[@name='noop' and count(parameter)=0]"
		[Register ("noop", "()V", "")]
		public void Noop ()
		{
			if (id_noop == IntPtr.Zero)
				id_noop = JNIEnv.GetMethodID (class_ref, "noop", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_noop);
		}

		static IntPtr id_openStreamCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection']/method[@name='openStreamCount' and count(parameter)=0]"
		[Register ("openStreamCount", "()I", "")]
		public int OpenStreamCount ()
		{
			if (id_openStreamCount == IntPtr.Zero)
				id_openStreamCount = JNIEnv.GetMethodID (class_ref, "openStreamCount", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_openStreamCount);
		}

		static IntPtr id_ping;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection']/method[@name='ping' and count(parameter)=0]"
		[Register ("ping", "()Lcom/squareup/okhttp/internal/spdy/Ping;", "")]
		public global::Com.Squareup.Okhttp.Internal.Spdy.Ping Ping ()
		{
			if (id_ping == IntPtr.Zero)
				id_ping = JNIEnv.GetMethodID (class_ref, "ping", "()Lcom/squareup/okhttp/internal/spdy/Ping;");
			return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.Ping> (JNIEnv.CallObjectMethod  (Handle, id_ping), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_readConnectionHeader;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection']/method[@name='readConnectionHeader' and count(parameter)=0]"
		[Register ("readConnectionHeader", "()V", "")]
		public void ReadConnectionHeader ()
		{
			if (id_readConnectionHeader == IntPtr.Zero)
				id_readConnectionHeader = JNIEnv.GetMethodID (class_ref, "readConnectionHeader", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_readConnectionHeader);
		}

		static IntPtr id_sendConnectionHeader;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection']/method[@name='sendConnectionHeader' and count(parameter)=0]"
		[Register ("sendConnectionHeader", "()V", "")]
		public void SendConnectionHeader ()
		{
			if (id_sendConnectionHeader == IntPtr.Zero)
				id_sendConnectionHeader = JNIEnv.GetMethodID (class_ref, "sendConnectionHeader", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_sendConnectionHeader);
		}

		static IntPtr id_shutdown_Lcom_squareup_okhttp_internal_spdy_ErrorCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection']/method[@name='shutdown' and count(parameter)=1 and parameter[1][@type='com.squareup.okhttp.internal.spdy.ErrorCode']]"
		[Register ("shutdown", "(Lcom/squareup/okhttp/internal/spdy/ErrorCode;)V", "")]
		public void Shutdown (global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode p0)
		{
			if (id_shutdown_Lcom_squareup_okhttp_internal_spdy_ErrorCode_ == IntPtr.Zero)
				id_shutdown_Lcom_squareup_okhttp_internal_spdy_ErrorCode_ = JNIEnv.GetMethodID (class_ref, "shutdown", "(Lcom/squareup/okhttp/internal/spdy/ErrorCode;)V");
			JNIEnv.CallVoidMethod  (Handle, id_shutdown_Lcom_squareup_okhttp_internal_spdy_ErrorCode_, new JValue (p0));
		}

		static IntPtr id_writeData_IZarrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyConnection']/method[@name='writeData' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("writeData", "(IZ[BII)V", "")]
		public void WriteData (int p0, bool p1, byte[] p2, int p3, int p4)
		{
			if (id_writeData_IZarrayBII == IntPtr.Zero)
				id_writeData_IZarrayBII = JNIEnv.GetMethodID (class_ref, "writeData", "(IZ[BII)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JNIEnv.CallVoidMethod  (Handle, id_writeData_IZarrayBII, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (p4));
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
