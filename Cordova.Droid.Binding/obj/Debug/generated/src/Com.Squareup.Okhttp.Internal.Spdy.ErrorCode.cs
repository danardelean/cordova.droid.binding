using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Squareup.Okhttp.Internal.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']"
	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/spdy/ErrorCode", DoNotGenerateAcw=true)]
	public sealed partial class ErrorCode : global::Java.Lang.Enum {


		static IntPtr CANCEL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/field[@name='CANCEL']"
		[Register ("CANCEL")]
		public static global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode Cancel {
			get {
				if (CANCEL_jfieldId == IntPtr.Zero)
					CANCEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANCEL", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANCEL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CANCEL_jfieldId == IntPtr.Zero)
					CANCEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANCEL", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CANCEL_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr COMPRESSION_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/field[@name='COMPRESSION_ERROR']"
		[Register ("COMPRESSION_ERROR")]
		public static global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode CompressionError {
			get {
				if (COMPRESSION_ERROR_jfieldId == IntPtr.Zero)
					COMPRESSION_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPRESSION_ERROR", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPRESSION_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (COMPRESSION_ERROR_jfieldId == IntPtr.Zero)
					COMPRESSION_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPRESSION_ERROR", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, COMPRESSION_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr FLOW_CONTROL_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/field[@name='FLOW_CONTROL_ERROR']"
		[Register ("FLOW_CONTROL_ERROR")]
		public static global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode FlowControlError {
			get {
				if (FLOW_CONTROL_ERROR_jfieldId == IntPtr.Zero)
					FLOW_CONTROL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLOW_CONTROL_ERROR", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FLOW_CONTROL_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FLOW_CONTROL_ERROR_jfieldId == IntPtr.Zero)
					FLOW_CONTROL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLOW_CONTROL_ERROR", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, FLOW_CONTROL_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr FRAME_TOO_LARGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/field[@name='FRAME_TOO_LARGE']"
		[Register ("FRAME_TOO_LARGE")]
		public static global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode FrameTooLarge {
			get {
				if (FRAME_TOO_LARGE_jfieldId == IntPtr.Zero)
					FRAME_TOO_LARGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FRAME_TOO_LARGE", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FRAME_TOO_LARGE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FRAME_TOO_LARGE_jfieldId == IntPtr.Zero)
					FRAME_TOO_LARGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FRAME_TOO_LARGE", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, FRAME_TOO_LARGE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr INTERNAL_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/field[@name='INTERNAL_ERROR']"
		[Register ("INTERNAL_ERROR")]
		public static global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode InternalError {
			get {
				if (INTERNAL_ERROR_jfieldId == IntPtr.Zero)
					INTERNAL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL_ERROR", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERNAL_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INTERNAL_ERROR_jfieldId == IntPtr.Zero)
					INTERNAL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL_ERROR", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, INTERNAL_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr INVALID_CREDENTIALS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/field[@name='INVALID_CREDENTIALS']"
		[Register ("INVALID_CREDENTIALS")]
		public static global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode InvalidCredentials {
			get {
				if (INVALID_CREDENTIALS_jfieldId == IntPtr.Zero)
					INVALID_CREDENTIALS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_CREDENTIALS", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_CREDENTIALS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INVALID_CREDENTIALS_jfieldId == IntPtr.Zero)
					INVALID_CREDENTIALS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_CREDENTIALS", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, INVALID_CREDENTIALS_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr INVALID_STREAM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/field[@name='INVALID_STREAM']"
		[Register ("INVALID_STREAM")]
		public static global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode InvalidStream {
			get {
				if (INVALID_STREAM_jfieldId == IntPtr.Zero)
					INVALID_STREAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_STREAM", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_STREAM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INVALID_STREAM_jfieldId == IntPtr.Zero)
					INVALID_STREAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_STREAM", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, INVALID_STREAM_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NO_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/field[@name='NO_ERROR']"
		[Register ("NO_ERROR")]
		public static global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode NoError {
			get {
				if (NO_ERROR_jfieldId == IntPtr.Zero)
					NO_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_ERROR", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NO_ERROR_jfieldId == IntPtr.Zero)
					NO_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_ERROR", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NO_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr PROTOCOL_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/field[@name='PROTOCOL_ERROR']"
		[Register ("PROTOCOL_ERROR")]
		public static global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode ProtocolError {
			get {
				if (PROTOCOL_ERROR_jfieldId == IntPtr.Zero)
					PROTOCOL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROTOCOL_ERROR", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROTOCOL_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PROTOCOL_ERROR_jfieldId == IntPtr.Zero)
					PROTOCOL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROTOCOL_ERROR", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, PROTOCOL_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr REFUSED_STREAM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/field[@name='REFUSED_STREAM']"
		[Register ("REFUSED_STREAM")]
		public static global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode RefusedStream {
			get {
				if (REFUSED_STREAM_jfieldId == IntPtr.Zero)
					REFUSED_STREAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFUSED_STREAM", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REFUSED_STREAM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (REFUSED_STREAM_jfieldId == IntPtr.Zero)
					REFUSED_STREAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFUSED_STREAM", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, REFUSED_STREAM_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr STREAM_ALREADY_CLOSED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/field[@name='STREAM_ALREADY_CLOSED']"
		[Register ("STREAM_ALREADY_CLOSED")]
		public static global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode StreamAlreadyClosed {
			get {
				if (STREAM_ALREADY_CLOSED_jfieldId == IntPtr.Zero)
					STREAM_ALREADY_CLOSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_ALREADY_CLOSED", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STREAM_ALREADY_CLOSED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (STREAM_ALREADY_CLOSED_jfieldId == IntPtr.Zero)
					STREAM_ALREADY_CLOSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_ALREADY_CLOSED", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, STREAM_ALREADY_CLOSED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr STREAM_CLOSED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/field[@name='STREAM_CLOSED']"
		[Register ("STREAM_CLOSED")]
		public static global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode StreamClosed {
			get {
				if (STREAM_CLOSED_jfieldId == IntPtr.Zero)
					STREAM_CLOSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_CLOSED", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STREAM_CLOSED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (STREAM_CLOSED_jfieldId == IntPtr.Zero)
					STREAM_CLOSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_CLOSED", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, STREAM_CLOSED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr STREAM_IN_USE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/field[@name='STREAM_IN_USE']"
		[Register ("STREAM_IN_USE")]
		public static global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode StreamInUse {
			get {
				if (STREAM_IN_USE_jfieldId == IntPtr.Zero)
					STREAM_IN_USE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_IN_USE", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STREAM_IN_USE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (STREAM_IN_USE_jfieldId == IntPtr.Zero)
					STREAM_IN_USE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAM_IN_USE", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, STREAM_IN_USE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr UNSUPPORTED_VERSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/field[@name='UNSUPPORTED_VERSION']"
		[Register ("UNSUPPORTED_VERSION")]
		public static global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode UnsupportedVersion {
			get {
				if (UNSUPPORTED_VERSION_jfieldId == IntPtr.Zero)
					UNSUPPORTED_VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSUPPORTED_VERSION", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNSUPPORTED_VERSION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UNSUPPORTED_VERSION_jfieldId == IntPtr.Zero)
					UNSUPPORTED_VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSUPPORTED_VERSION", "Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, UNSUPPORTED_VERSION_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr httpCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/field[@name='httpCode']"
		[Register ("httpCode")]
		public int HttpCode {
			get {
				if (httpCode_jfieldId == IntPtr.Zero)
					httpCode_jfieldId = JNIEnv.GetFieldID (class_ref, "httpCode", "I");
				return JNIEnv.GetIntField (Handle, httpCode_jfieldId);
			}
			set {
				if (httpCode_jfieldId == IntPtr.Zero)
					httpCode_jfieldId = JNIEnv.GetFieldID (class_ref, "httpCode", "I");
				JNIEnv.SetField (Handle, httpCode_jfieldId, value);
			}
		}

		static IntPtr spdyGoAwayCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/field[@name='spdyGoAwayCode']"
		[Register ("spdyGoAwayCode")]
		public int SpdyGoAwayCode {
			get {
				if (spdyGoAwayCode_jfieldId == IntPtr.Zero)
					spdyGoAwayCode_jfieldId = JNIEnv.GetFieldID (class_ref, "spdyGoAwayCode", "I");
				return JNIEnv.GetIntField (Handle, spdyGoAwayCode_jfieldId);
			}
			set {
				if (spdyGoAwayCode_jfieldId == IntPtr.Zero)
					spdyGoAwayCode_jfieldId = JNIEnv.GetFieldID (class_ref, "spdyGoAwayCode", "I");
				JNIEnv.SetField (Handle, spdyGoAwayCode_jfieldId, value);
			}
		}

		static IntPtr spdyRstCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/field[@name='spdyRstCode']"
		[Register ("spdyRstCode")]
		public int SpdyRstCode {
			get {
				if (spdyRstCode_jfieldId == IntPtr.Zero)
					spdyRstCode_jfieldId = JNIEnv.GetFieldID (class_ref, "spdyRstCode", "I");
				return JNIEnv.GetIntField (Handle, spdyRstCode_jfieldId);
			}
			set {
				if (spdyRstCode_jfieldId == IntPtr.Zero)
					spdyRstCode_jfieldId = JNIEnv.GetFieldID (class_ref, "spdyRstCode", "I");
				JNIEnv.SetField (Handle, spdyRstCode_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/squareup/okhttp/internal/spdy/ErrorCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ErrorCode); }
		}

		internal ErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_fromHttp2_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/method[@name='fromHttp2' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromHttp2", "(I)Lcom/squareup/okhttp/internal/spdy/ErrorCode;", "")]
		public static global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode FromHttp2 (int p0)
		{
			if (id_fromHttp2_I == IntPtr.Zero)
				id_fromHttp2_I = JNIEnv.GetStaticMethodID (class_ref, "fromHttp2", "(I)Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
			return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromHttp2_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_fromSpdy3Rst_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/method[@name='fromSpdy3Rst' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromSpdy3Rst", "(I)Lcom/squareup/okhttp/internal/spdy/ErrorCode;", "")]
		public static global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode FromSpdy3Rst (int p0)
		{
			if (id_fromSpdy3Rst_I == IntPtr.Zero)
				id_fromSpdy3Rst_I = JNIEnv.GetStaticMethodID (class_ref, "fromSpdy3Rst", "(I)Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
			return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromSpdy3Rst_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_fromSpdyGoAway_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/method[@name='fromSpdyGoAway' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromSpdyGoAway", "(I)Lcom/squareup/okhttp/internal/spdy/ErrorCode;", "")]
		public static global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode FromSpdyGoAway (int p0)
		{
			if (id_fromSpdyGoAway_I == IntPtr.Zero)
				id_fromSpdyGoAway_I = JNIEnv.GetStaticMethodID (class_ref, "fromSpdyGoAway", "(I)Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
			return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromSpdyGoAway_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/squareup/okhttp/internal/spdy/ErrorCode;", "")]
		public static global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode __ret = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='ErrorCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/squareup/okhttp/internal/spdy/ErrorCode;", "")]
		public static global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/squareup/okhttp/internal/spdy/ErrorCode;");
			return (global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode));
		}

	}
}
