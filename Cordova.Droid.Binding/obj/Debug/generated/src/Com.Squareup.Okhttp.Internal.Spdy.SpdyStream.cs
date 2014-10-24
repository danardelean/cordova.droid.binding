using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Squareup.Okhttp.Internal.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyStream']"
	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/spdy/SpdyStream", DoNotGenerateAcw=true)]
	public sealed partial class SpdyStream : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyStream']/field[@name='WINDOW_UPDATE_THRESHOLD']"
		[Register ("WINDOW_UPDATE_THRESHOLD")]
		public const int WindowUpdateThreshold = (int) 32768;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyStream.SpdyDataInputStream']"
		[global::Android.Runtime.Register ("com/squareup/okhttp/internal/spdy/SpdyStream$SpdyDataInputStream", DoNotGenerateAcw=true)]
		public sealed partial class SpdyDataInputStream : global::Java.IO.InputStream {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/squareup/okhttp/internal/spdy/SpdyStream$SpdyDataInputStream", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SpdyDataInputStream); }
			}

			internal SpdyDataInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_read;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyStream.SpdyDataInputStream']/method[@name='read' and count(parameter)=0]"
			[Register ("read", "()I", "")]
			public override int Read ()
			{
				if (id_read == IntPtr.Zero)
					id_read = JNIEnv.GetMethodID (class_ref, "read", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_read);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyStream.SpdyDataOutputStream']"
		[global::Android.Runtime.Register ("com/squareup/okhttp/internal/spdy/SpdyStream$SpdyDataOutputStream", DoNotGenerateAcw=true)]
		public sealed partial class SpdyDataOutputStream : global::Java.IO.OutputStream {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/squareup/okhttp/internal/spdy/SpdyStream$SpdyDataOutputStream", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SpdyDataOutputStream); }
			}

			internal SpdyDataOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_write_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyStream.SpdyDataOutputStream']/method[@name='write' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("write", "(I)V", "")]
			public override void Write (int p0)
			{
				if (id_write_I == IntPtr.Zero)
					id_write_I = JNIEnv.GetMethodID (class_ref, "write", "(I)V");
				JNIEnv.CallVoidMethod  (Handle, id_write_I, new JValue (p0));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/squareup/okhttp/internal/spdy/SpdyStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpdyStream); }
		}

		internal SpdyStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getConnection;
		public global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection Connection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyStream']/method[@name='getConnection' and count(parameter)=0]"
			[Register ("getConnection", "()Lcom/squareup/okhttp/internal/spdy/SpdyConnection;", "GetGetConnectionHandler")]
			get {
				if (id_getConnection == IntPtr.Zero)
					id_getConnection = JNIEnv.GetMethodID (class_ref, "getConnection", "()Lcom/squareup/okhttp/internal/spdy/SpdyConnection;");
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyConnection> (JNIEnv.CallObjectMethod  (Handle, id_getConnection), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getErrorCode;
		public global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyStream']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()Lcom/squareup/okhttp/internal/spdy/ErrorCode;", "GetGetErrorCodeHandler")]
			get {
				if (id_getErrorCode == IntPtr.Zero)
					id_getErrorCode = JNIEnv.GetMethodID (class_ref, "getErrorCode", "()Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (JNIEnv.CallObjectMethod  (Handle, id_getErrorCode), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getInputStream;
		public global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyStream']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")]
			get {
				if (id_getInputStream == IntPtr.Zero)
					id_getInputStream = JNIEnv.GetMethodID (class_ref, "getInputStream", "()Ljava/io/InputStream;");
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getInputStream), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isLocallyInitiated;
		public bool IsLocallyInitiated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyStream']/method[@name='isLocallyInitiated' and count(parameter)=0]"
			[Register ("isLocallyInitiated", "()Z", "GetIsLocallyInitiatedHandler")]
			get {
				if (id_isLocallyInitiated == IntPtr.Zero)
					id_isLocallyInitiated = JNIEnv.GetMethodID (class_ref, "isLocallyInitiated", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isLocallyInitiated);
			}
		}

		static IntPtr id_isOpen;
		public bool IsOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyStream']/method[@name='isOpen' and count(parameter)=0]"
			[Register ("isOpen", "()Z", "GetIsOpenHandler")]
			get {
				if (id_isOpen == IntPtr.Zero)
					id_isOpen = JNIEnv.GetMethodID (class_ref, "isOpen", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isOpen);
			}
		}

		static IntPtr id_getOutputStream;
		public global::System.IO.Stream OutputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyStream']/method[@name='getOutputStream' and count(parameter)=0]"
			[Register ("getOutputStream", "()Ljava/io/OutputStream;", "GetGetOutputStreamHandler")]
			get {
				if (id_getOutputStream == IntPtr.Zero)
					id_getOutputStream = JNIEnv.GetMethodID (class_ref, "getOutputStream", "()Ljava/io/OutputStream;");
				return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getOutputStream), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getReadTimeoutMillis;
		public long ReadTimeoutMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyStream']/method[@name='getReadTimeoutMillis' and count(parameter)=0]"
			[Register ("getReadTimeoutMillis", "()J", "GetGetReadTimeoutMillisHandler")]
			get {
				if (id_getReadTimeoutMillis == IntPtr.Zero)
					id_getReadTimeoutMillis = JNIEnv.GetMethodID (class_ref, "getReadTimeoutMillis", "()J");
				return JNIEnv.CallLongMethod  (Handle, id_getReadTimeoutMillis);
			}
		}

		static IntPtr id_getRequestHeaders;
		public global::System.Collections.Generic.IList<string> RequestHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyStream']/method[@name='getRequestHeaders' and count(parameter)=0]"
			[Register ("getRequestHeaders", "()Ljava/util/List;", "GetGetRequestHeadersHandler")]
			get {
				if (id_getRequestHeaders == IntPtr.Zero)
					id_getRequestHeaders = JNIEnv.GetMethodID (class_ref, "getRequestHeaders", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getRequestHeaders), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getResponseHeaders;
		public global::System.Collections.Generic.IList<string> ResponseHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyStream']/method[@name='getResponseHeaders' and count(parameter)=0]"
			[Register ("getResponseHeaders", "()Ljava/util/List;", "GetGetResponseHeadersHandler")]
			get {
				if (id_getResponseHeaders == IntPtr.Zero)
					id_getResponseHeaders = JNIEnv.GetMethodID (class_ref, "getResponseHeaders", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getResponseHeaders), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_close_Lcom_squareup_okhttp_internal_spdy_ErrorCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyStream']/method[@name='close' and count(parameter)=1 and parameter[1][@type='com.squareup.okhttp.internal.spdy.ErrorCode']]"
		[Register ("close", "(Lcom/squareup/okhttp/internal/spdy/ErrorCode;)V", "")]
		public void Close (global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode p0)
		{
			if (id_close_Lcom_squareup_okhttp_internal_spdy_ErrorCode_ == IntPtr.Zero)
				id_close_Lcom_squareup_okhttp_internal_spdy_ErrorCode_ = JNIEnv.GetMethodID (class_ref, "close", "(Lcom/squareup/okhttp/internal/spdy/ErrorCode;)V");
			JNIEnv.CallVoidMethod  (Handle, id_close_Lcom_squareup_okhttp_internal_spdy_ErrorCode_, new JValue (p0));
		}

		static IntPtr id_closeLater_Lcom_squareup_okhttp_internal_spdy_ErrorCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyStream']/method[@name='closeLater' and count(parameter)=1 and parameter[1][@type='com.squareup.okhttp.internal.spdy.ErrorCode']]"
		[Register ("closeLater", "(Lcom/squareup/okhttp/internal/spdy/ErrorCode;)V", "")]
		public void CloseLater (global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode p0)
		{
			if (id_closeLater_Lcom_squareup_okhttp_internal_spdy_ErrorCode_ == IntPtr.Zero)
				id_closeLater_Lcom_squareup_okhttp_internal_spdy_ErrorCode_ = JNIEnv.GetMethodID (class_ref, "closeLater", "(Lcom/squareup/okhttp/internal/spdy/ErrorCode;)V");
			JNIEnv.CallVoidMethod  (Handle, id_closeLater_Lcom_squareup_okhttp_internal_spdy_ErrorCode_, new JValue (p0));
		}

		static IntPtr id_reply_Ljava_util_List_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyStream']/method[@name='reply' and count(parameter)=2 and parameter[1][@type='java.util.List'] and parameter[2][@type='boolean']]"
		[Register ("reply", "(Ljava/util/List;Z)V", "")]
		public void Reply (global::System.Collections.Generic.IList<string> p0, bool p1)
		{
			if (id_reply_Ljava_util_List_Z == IntPtr.Zero)
				id_reply_Ljava_util_List_Z = JNIEnv.GetMethodID (class_ref, "reply", "(Ljava/util/List;Z)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_reply_Ljava_util_List_Z, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_setReadTimeout_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='SpdyStream']/method[@name='setReadTimeout' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setReadTimeout", "(J)V", "")]
		public void SetReadTimeout (long p0)
		{
			if (id_setReadTimeout_J == IntPtr.Zero)
				id_setReadTimeout_J = JNIEnv.GetMethodID (class_ref, "setReadTimeout", "(J)V");
			JNIEnv.CallVoidMethod  (Handle, id_setReadTimeout_J, new JValue (p0));
		}

	}
}
