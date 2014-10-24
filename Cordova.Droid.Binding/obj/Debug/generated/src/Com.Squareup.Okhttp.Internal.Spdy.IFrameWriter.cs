using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Squareup.Okhttp.Internal.Spdy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameWriter']"
	[Register ("com/squareup/okhttp/internal/spdy/FrameWriter", "", "Com.Squareup.Okhttp.Internal.Spdy.IFrameWriterInvoker")]
	public partial interface IFrameWriter : global::Java.IO.ICloseable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameWriter']/method[@name='connectionHeader' and count(parameter)=0]"
		[Register ("connectionHeader", "()V", "GetConnectionHeaderHandler:Com.Squareup.Okhttp.Internal.Spdy.IFrameWriterInvoker, Cordova.Android.Binding")]
		void ConnectionHeader ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameWriter']/method[@name='data' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("data", "(ZI[B)V", "GetData_ZIarrayBHandler:Com.Squareup.Okhttp.Internal.Spdy.IFrameWriterInvoker, Cordova.Android.Binding")]
		void Data (bool p0, int p1, byte[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameWriter']/method[@name='data' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("data", "(ZI[BII)V", "GetData_ZIarrayBIIHandler:Com.Squareup.Okhttp.Internal.Spdy.IFrameWriterInvoker, Cordova.Android.Binding")]
		void Data (bool p0, int p1, byte[] p2, int p3, int p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameWriter']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler:Com.Squareup.Okhttp.Internal.Spdy.IFrameWriterInvoker, Cordova.Android.Binding")]
		void Flush ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameWriter']/method[@name='goAway' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.squareup.okhttp.internal.spdy.ErrorCode']]"
		[Register ("goAway", "(ILcom/squareup/okhttp/internal/spdy/ErrorCode;)V", "GetGoAway_ILcom_squareup_okhttp_internal_spdy_ErrorCode_Handler:Com.Squareup.Okhttp.Internal.Spdy.IFrameWriterInvoker, Cordova.Android.Binding")]
		void GoAway (int p0, global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameWriter']/method[@name='headers' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.List']]"
		[Register ("headers", "(ILjava/util/List;)V", "GetHeaders_ILjava_util_List_Handler:Com.Squareup.Okhttp.Internal.Spdy.IFrameWriterInvoker, Cordova.Android.Binding")]
		void Headers (int p0, global::System.Collections.Generic.IList<string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameWriter']/method[@name='noop' and count(parameter)=0]"
		[Register ("noop", "()V", "GetNoopHandler:Com.Squareup.Okhttp.Internal.Spdy.IFrameWriterInvoker, Cordova.Android.Binding")]
		void Noop ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameWriter']/method[@name='ping' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("ping", "(ZII)V", "GetPing_ZIIHandler:Com.Squareup.Okhttp.Internal.Spdy.IFrameWriterInvoker, Cordova.Android.Binding")]
		void Ping (bool p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameWriter']/method[@name='rstStream' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.squareup.okhttp.internal.spdy.ErrorCode']]"
		[Register ("rstStream", "(ILcom/squareup/okhttp/internal/spdy/ErrorCode;)V", "GetRstStream_ILcom_squareup_okhttp_internal_spdy_ErrorCode_Handler:Com.Squareup.Okhttp.Internal.Spdy.IFrameWriterInvoker, Cordova.Android.Binding")]
		void RstStream (int p0, global::Com.Squareup.Okhttp.Internal.Spdy.ErrorCode p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameWriter']/method[@name='synReply' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List']]"
		[Register ("synReply", "(ZILjava/util/List;)V", "GetSynReply_ZILjava_util_List_Handler:Com.Squareup.Okhttp.Internal.Spdy.IFrameWriterInvoker, Cordova.Android.Binding")]
		void SynReply (bool p0, int p1, global::System.Collections.Generic.IList<string> p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameWriter']/method[@name='synStream' and count(parameter)=7 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='java.util.List']]"
		[Register ("synStream", "(ZZIIIILjava/util/List;)V", "GetSynStream_ZZIIIILjava_util_List_Handler:Com.Squareup.Okhttp.Internal.Spdy.IFrameWriterInvoker, Cordova.Android.Binding")]
		void SynStream (bool p0, bool p1, int p2, int p3, int p4, int p5, global::System.Collections.Generic.IList<string> p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='FrameWriter']/method[@name='windowUpdate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("windowUpdate", "(II)V", "GetWindowUpdate_IIHandler:Com.Squareup.Okhttp.Internal.Spdy.IFrameWriterInvoker, Cordova.Android.Binding")]
		void WindowUpdate (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/spdy/FrameWriter", DoNotGenerateAcw=true)]
	internal class IFrameWriterInvoker : global::Java.Lang.Object, IFrameWriter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/squareup/okhttp/internal/spdy/FrameWriter");
		IntPtr class_ref;

		public static IFrameWriter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFrameWriter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.squareup.okhttp.internal.spdy.FrameWriter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFrameWriterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IFrameWriterInvoker); }
		}

		static Delegate cb_connectionHeader;
#pragma warning disable 0169
		static Delegate GetConnectionHeaderHandler ()
		{
			if (cb_connectionHeader == null)
				cb_connectionHeader = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ConnectionHeader);
			return cb_connectionHeader;
		}

		static void n_ConnectionHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectionHeader ();
		}
#pragma warning restore 0169

		IntPtr id_connectionHeader;
		public void ConnectionHeader ()
		{
			if (id_connectionHeader == IntPtr.Zero)
				id_connectionHeader = JNIEnv.GetMethodID (class_ref, "connectionHeader", "()V");
			JNIEnv.CallVoidMethod (Handle, id_connectionHeader);
		}

		static Delegate cb_data_ZIarrayB;
#pragma warning disable 0169
		static Delegate GetData_ZIarrayBHandler ()
		{
			if (cb_data_ZIarrayB == null)
				cb_data_ZIarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, IntPtr>) n_Data_ZIarrayB);
			return cb_data_ZIarrayB;
		}

		static void n_Data_ZIarrayB (IntPtr jnienv, IntPtr native__this, bool p0, int p1, IntPtr native_p2)
		{
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Data (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_data_ZIarrayB;
		public void Data (bool p0, int p1, byte[] p2)
		{
			if (id_data_ZIarrayB == IntPtr.Zero)
				id_data_ZIarrayB = JNIEnv.GetMethodID (class_ref, "data", "(ZI[B)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JNIEnv.CallVoidMethod (Handle, id_data_ZIarrayB, new JValue (p0), new JValue (p1), new JValue (native_p2));
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_data_ZIarrayBII;
#pragma warning disable 0169
		static Delegate GetData_ZIarrayBIIHandler ()
		{
			if (cb_data_ZIarrayBII == null)
				cb_data_ZIarrayBII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, IntPtr, int, int>) n_Data_ZIarrayBII);
			return cb_data_ZIarrayBII;
		}

		static void n_Data_ZIarrayBII (IntPtr jnienv, IntPtr native__this, bool p0, int p1, IntPtr native_p2, int p3, int p4)
		{
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Data (p0, p1, p2, p3, p4);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_data_ZIarrayBII;
		public void Data (bool p0, int p1, byte[] p2, int p3, int p4)
		{
			if (id_data_ZIarrayBII == IntPtr.Zero)
				id_data_ZIarrayBII = JNIEnv.GetMethodID (class_ref, "data", "(ZI[BII)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JNIEnv.CallVoidMethod (Handle, id_data_ZIarrayBII, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (p4));
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		IntPtr id_flush;
		public void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			JNIEnv.CallVoidMethod (Handle, id_flush);
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
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_headers_ILjava_util_List_;
#pragma warning disable 0169
		static Delegate GetHeaders_ILjava_util_List_Handler ()
		{
			if (cb_headers_ILjava_util_List_ == null)
				cb_headers_ILjava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Headers_ILjava_util_List_);
			return cb_headers_ILjava_util_List_;
		}

		static void n_Headers_ILjava_util_List_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Headers (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_headers_ILjava_util_List_;
		public void Headers (int p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_headers_ILjava_util_List_ == IntPtr.Zero)
				id_headers_ILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "headers", "(ILjava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			JNIEnv.CallVoidMethod (Handle, id_headers_ILjava_util_List_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_synReply_ZILjava_util_List_;
#pragma warning disable 0169
		static Delegate GetSynReply_ZILjava_util_List_Handler ()
		{
			if (cb_synReply_ZILjava_util_List_ == null)
				cb_synReply_ZILjava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, IntPtr>) n_SynReply_ZILjava_util_List_);
			return cb_synReply_ZILjava_util_List_;
		}

		static void n_SynReply_ZILjava_util_List_ (IntPtr jnienv, IntPtr native__this, bool p0, int p1, IntPtr native_p2)
		{
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p2 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SynReply (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_synReply_ZILjava_util_List_;
		public void SynReply (bool p0, int p1, global::System.Collections.Generic.IList<string> p2)
		{
			if (id_synReply_ZILjava_util_List_ == IntPtr.Zero)
				id_synReply_ZILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "synReply", "(ZILjava/util/List;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			JNIEnv.CallVoidMethod (Handle, id_synReply_ZILjava_util_List_, new JValue (p0), new JValue (p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_synStream_ZZIIIILjava_util_List_;
#pragma warning disable 0169
		static Delegate GetSynStream_ZZIIIILjava_util_List_Handler ()
		{
			if (cb_synStream_ZZIIIILjava_util_List_ == null)
				cb_synStream_ZZIIIILjava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, bool, int, int, int, int, IntPtr>) n_SynStream_ZZIIIILjava_util_List_);
			return cb_synStream_ZZIIIILjava_util_List_;
		}

		static void n_SynStream_ZZIIIILjava_util_List_ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1, int p2, int p3, int p4, int p5, IntPtr native_p6)
		{
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p6 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p6, JniHandleOwnership.DoNotTransfer);
			__this.SynStream (p0, p1, p2, p3, p4, p5, p6);
		}
#pragma warning restore 0169

		IntPtr id_synStream_ZZIIIILjava_util_List_;
		public void SynStream (bool p0, bool p1, int p2, int p3, int p4, int p5, global::System.Collections.Generic.IList<string> p6)
		{
			if (id_synStream_ZZIIIILjava_util_List_ == IntPtr.Zero)
				id_synStream_ZZIIIILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "synStream", "(ZZIIIILjava/util/List;)V");
			IntPtr native_p6 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p6);
			JNIEnv.CallVoidMethod (Handle, id_synStream_ZZIIIILjava_util_List_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (native_p6));
			JNIEnv.DeleteLocalRef (native_p6);
		}

		static Delegate cb_windowUpdate_II;
#pragma warning disable 0169
		static Delegate GetWindowUpdate_IIHandler ()
		{
			if (cb_windowUpdate_II == null)
				cb_windowUpdate_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_WindowUpdate_II);
			return cb_windowUpdate_II;
		}

		static void n_WindowUpdate_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WindowUpdate (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_windowUpdate_II;
		public void WindowUpdate (int p0, int p1)
		{
			if (id_windowUpdate_II == IntPtr.Zero)
				id_windowUpdate_II = JNIEnv.GetMethodID (class_ref, "windowUpdate", "(II)V");
			JNIEnv.CallVoidMethod (Handle, id_windowUpdate_II, new JValue (p0), new JValue (p1));
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
			global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
