using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Squareup.Okhttp.Internal.Spdy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameReader.Handler']"
	[Register ("com/squareup/okhttp/internal/spdy/FrameReader$Handler", "", "Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandlerInvoker")]
	public partial interface IFrameReaderHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameReader.Handler']/method[@name='data' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='java.io.InputStream'] and parameter[4][@type='int']]"
		[Register ("data", "(ZILjava/io/InputStream;I)V", "GetData_ZILjava_io_InputStream_IHandler:Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandlerInvoker, Cordova.Android.Binding")]
		void Data (bool p0, int p1, global::System.IO.Stream p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameReader.Handler']/method[@name='goAway' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.squareup.okhttp.internal.spdy.ErrorCode']]"
		[Register ("goAway", "(ILcom/squareup/okhttp/internal/spdy/ErrorCode;)V", "GetGoAway_ILcom_squareup_okhttp_internal_spdy_ErrorCode_Handler:Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandlerInvoker, Cordova.Android.Binding")]
		void GoAway (int p0, global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameReader.Handler']/method[@name='noop' and count(parameter)=0]"
		[Register ("noop", "()V", "GetNoopHandler:Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandlerInvoker, Cordova.Android.Binding")]
		void Noop ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameReader.Handler']/method[@name='ping' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("ping", "(ZII)V", "GetPing_ZIIHandler:Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandlerInvoker, Cordova.Android.Binding")]
		void Ping (bool p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameReader.Handler']/method[@name='priority' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("priority", "(II)V", "GetPriority_IIHandler:Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandlerInvoker, Cordova.Android.Binding")]
		void Priority (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameReader.Handler']/method[@name='rstStream' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.squareup.okhttp.internal.spdy.ErrorCode']]"
		[Register ("rstStream", "(ILcom/squareup/okhttp/internal/spdy/ErrorCode;)V", "GetRstStream_ILcom_squareup_okhttp_internal_spdy_ErrorCode_Handler:Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandlerInvoker, Cordova.Android.Binding")]
		void RstStream (int p0, global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameReader.Handler']/method[@name='windowUpdate' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("windowUpdate", "(IIZ)V", "GetWindowUpdate_IIZHandler:Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandlerInvoker, Cordova.Android.Binding")]
		void WindowUpdate (int p0, int p1, bool p2);

	}

	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/spdy/FrameReader$Handler", DoNotGenerateAcw=true)]
	internal class IFrameReaderHandlerInvoker : global::Java.Lang.Object, IFrameReaderHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/squareup/okhttp/internal/spdy/FrameReader$Handler");
		IntPtr class_ref;

		public static IFrameReaderHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFrameReaderHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.squareup.okhttp.internal.spdy.FrameReader.Handler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFrameReaderHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IFrameReaderHandlerInvoker); }
		}

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
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandler __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p2 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Data (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_data_ZILjava_io_InputStream_I;
		public void Data (bool p0, int p1, global::System.IO.Stream p2, int p3)
		{
			if (id_data_ZILjava_io_InputStream_I == IntPtr.Zero)
				id_data_ZILjava_io_InputStream_I = JNIEnv.GetMethodID (class_ref, "data", "(ZILjava/io/InputStream;I)V");
			IntPtr native_p2 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p2);
			JNIEnv.CallVoidMethod (Handle, id_data_ZILjava_io_InputStream_I, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
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
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandler __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode p1 = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GoAway (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_goAway_ILcom_squareup_okhttp_internal_spdy_ErrorCode_;
		public void GoAway (int p0, global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode p1)
		{
			if (id_goAway_ILcom_squareup_okhttp_internal_spdy_ErrorCode_ == IntPtr.Zero)
				id_goAway_ILcom_squareup_okhttp_internal_spdy_ErrorCode_ = JNIEnv.GetMethodID (class_ref, "goAway", "(ILcom/squareup/okhttp/internal/spdy/ErrorCode;)V");
			JNIEnv.CallVoidMethod (Handle, id_goAway_ILcom_squareup_okhttp_internal_spdy_ErrorCode_, new JValue (p0), new JValue (p1));
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
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandler __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Noop ();
		}
#pragma warning restore 0169

		IntPtr id_noop;
		public void Noop ()
		{
			if (id_noop == IntPtr.Zero)
				id_noop = JNIEnv.GetMethodID (class_ref, "noop", "()V");
			JNIEnv.CallVoidMethod (Handle, id_noop);
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
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandler __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Ping (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_ping_ZII;
		public void Ping (bool p0, int p1, int p2)
		{
			if (id_ping_ZII == IntPtr.Zero)
				id_ping_ZII = JNIEnv.GetMethodID (class_ref, "ping", "(ZII)V");
			JNIEnv.CallVoidMethod (Handle, id_ping_ZII, new JValue (p0), new JValue (p1), new JValue (p2));
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
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandler __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Priority (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_priority_II;
		public void Priority (int p0, int p1)
		{
			if (id_priority_II == IntPtr.Zero)
				id_priority_II = JNIEnv.GetMethodID (class_ref, "priority", "(II)V");
			JNIEnv.CallVoidMethod (Handle, id_priority_II, new JValue (p0), new JValue (p1));
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
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandler __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode p1 = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RstStream (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_rstStream_ILcom_squareup_okhttp_internal_spdy_ErrorCode_;
		public void RstStream (int p0, global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode p1)
		{
			if (id_rstStream_ILcom_squareup_okhttp_internal_spdy_ErrorCode_ == IntPtr.Zero)
				id_rstStream_ILcom_squareup_okhttp_internal_spdy_ErrorCode_ = JNIEnv.GetMethodID (class_ref, "rstStream", "(ILcom/squareup/okhttp/internal/spdy/ErrorCode;)V");
			JNIEnv.CallVoidMethod (Handle, id_rstStream_ILcom_squareup_okhttp_internal_spdy_ErrorCode_, new JValue (p0), new JValue (p1));
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
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandler __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WindowUpdate (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_windowUpdate_IIZ;
		public void WindowUpdate (int p0, int p1, bool p2)
		{
			if (id_windowUpdate_IIZ == IntPtr.Zero)
				id_windowUpdate_IIZ = JNIEnv.GetMethodID (class_ref, "windowUpdate", "(IIZ)V");
			JNIEnv.CallVoidMethod (Handle, id_windowUpdate_IIZ, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameReader']"
	[Register ("com/squareup/okhttp/internal/spdy/FrameReader", "", "Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderInvoker")]
	public partial interface IFrameReader : global::Java.IO.ICloseable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameReader']/method[@name='nextFrame' and count(parameter)=1 and parameter[1][@type='com.squareup.okhttp.internal.spdy.FrameReader.Handler']]"
		[Register ("nextFrame", "(Lcom/squareup/okhttp/internal/spdy/FrameReader$Handler;)Z", "GetNextFrame_Lcom_squareup_okhttp_internal_spdy_FrameReader_Handler_Handler:Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderInvoker, Cordova.Android.Binding")]
		bool NextFrame (global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandler p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameReader']/method[@name='readConnectionHeader' and count(parameter)=0]"
		[Register ("readConnectionHeader", "()V", "GetReadConnectionHeaderHandler:Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderInvoker, Cordova.Android.Binding")]
		void ReadConnectionHeader ();

	}

	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/spdy/FrameReader", DoNotGenerateAcw=true)]
	internal class IFrameReaderInvoker : global::Java.Lang.Object, IFrameReader {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/squareup/okhttp/internal/spdy/FrameReader");
		IntPtr class_ref;

		public static IFrameReader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFrameReader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.squareup.okhttp.internal.spdy.FrameReader"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFrameReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IFrameReaderInvoker); }
		}

		static Delegate cb_nextFrame_Lcom_squareup_okhttp_internal_spdy_FrameReader_Handler_;
#pragma warning disable 0169
		static Delegate GetNextFrame_Lcom_squareup_okhttp_internal_spdy_FrameReader_Handler_Handler ()
		{
			if (cb_nextFrame_Lcom_squareup_okhttp_internal_spdy_FrameReader_Handler_ == null)
				cb_nextFrame_Lcom_squareup_okhttp_internal_spdy_FrameReader_Handler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_NextFrame_Lcom_squareup_okhttp_internal_spdy_FrameReader_Handler_);
			return cb_nextFrame_Lcom_squareup_okhttp_internal_spdy_FrameReader_Handler_;
		}

		static bool n_NextFrame_Lcom_squareup_okhttp_internal_spdy_FrameReader_Handler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReader __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandler p0 = (global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandler)global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.NextFrame (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_nextFrame_Lcom_squareup_okhttp_internal_spdy_FrameReader_Handler_;
		public bool NextFrame (global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReaderHandler p0)
		{
			if (id_nextFrame_Lcom_squareup_okhttp_internal_spdy_FrameReader_Handler_ == IntPtr.Zero)
				id_nextFrame_Lcom_squareup_okhttp_internal_spdy_FrameReader_Handler_ = JNIEnv.GetMethodID (class_ref, "nextFrame", "(Lcom/squareup/okhttp/internal/spdy/FrameReader$Handler;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_nextFrame_Lcom_squareup_okhttp_internal_spdy_FrameReader_Handler_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_readConnectionHeader;
#pragma warning disable 0169
		static Delegate GetReadConnectionHeaderHandler ()
		{
			if (cb_readConnectionHeader == null)
				cb_readConnectionHeader = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReadConnectionHeader);
			return cb_readConnectionHeader;
		}

		static void n_ReadConnectionHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReader __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadConnectionHeader ();
		}
#pragma warning restore 0169

		IntPtr id_readConnectionHeader;
		public void ReadConnectionHeader ()
		{
			if (id_readConnectionHeader == IntPtr.Zero)
				id_readConnectionHeader = JNIEnv.GetMethodID (class_ref, "readConnectionHeader", "()V");
			JNIEnv.CallVoidMethod (Handle, id_readConnectionHeader);
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReader __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (Handle, id_close);
		}

	}

}
