using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Squareup.Okhttp.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='FaultRecoveringOutputStream']"
	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/FaultRecoveringOutputStream", DoNotGenerateAcw=true)]
	public abstract partial class FaultRecoveringOutputStream : global::Com.Squareup.Okhttp.Internal.AbstractOutputStream {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/squareup/okhttp/internal/FaultRecoveringOutputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FaultRecoveringOutputStream); }
		}

		protected FaultRecoveringOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_io_OutputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='FaultRecoveringOutputStream']/constructor[@name='FaultRecoveringOutputStream' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.io.OutputStream']]"
		[Register (".ctor", "(ILjava/io/OutputStream;)V", "")]
		public FaultRecoveringOutputStream (int p0, global::System.IO.Stream p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);;
			if (GetType () != typeof (FaultRecoveringOutputStream)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/io/OutputStream;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILjava/io/OutputStream;)V", new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_ILjava_io_OutputStream_ == IntPtr.Zero)
				id_ctor_ILjava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/io/OutputStream;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_io_OutputStream_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILjava_io_OutputStream_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_isRecoverable;
#pragma warning disable 0169
		static Delegate GetIsRecoverableHandler ()
		{
			if (cb_isRecoverable == null)
				cb_isRecoverable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRecoverable);
			return cb_isRecoverable;
		}

		static bool n_IsRecoverable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Okhttp.Internal.FaultRecoveringOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.FaultRecoveringOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRecoverable;
		}
#pragma warning restore 0169

		static IntPtr id_isRecoverable;
		public virtual bool IsRecoverable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='FaultRecoveringOutputStream']/method[@name='isRecoverable' and count(parameter)=0]"
			[Register ("isRecoverable", "()Z", "GetIsRecoverableHandler")]
			get {
				if (id_isRecoverable == IntPtr.Zero)
					id_isRecoverable = JNIEnv.GetMethodID (class_ref, "isRecoverable", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isRecoverable);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRecoverable", "()Z"));
			}
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='FaultRecoveringOutputStream']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public override sealed void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_close);
		}

		static IntPtr id_flush;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='FaultRecoveringOutputStream']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "")]
		public override sealed void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_flush);
		}

		static IntPtr id_replaceStream_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='FaultRecoveringOutputStream']/method[@name='replaceStream' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("replaceStream", "(Ljava/io/OutputStream;)V", "")]
		public void ReplaceStream (global::System.IO.Stream p0)
		{
			if (id_replaceStream_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_replaceStream_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "replaceStream", "(Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_replaceStream_Ljava_io_OutputStream_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_replacementStream_Ljava_io_IOException_;
#pragma warning disable 0169
		static Delegate GetReplacementStream_Ljava_io_IOException_Handler ()
		{
			if (cb_replacementStream_Ljava_io_IOException_ == null)
				cb_replacementStream_Ljava_io_IOException_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReplacementStream_Ljava_io_IOException_);
			return cb_replacementStream_Ljava_io_IOException_;
		}

		static IntPtr n_ReplacementStream_Ljava_io_IOException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Squareup.Okhttp.Internal.FaultRecoveringOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.FaultRecoveringOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.IOException p0 = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.ReplacementStream (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='FaultRecoveringOutputStream']/method[@name='replacementStream' and count(parameter)=1 and parameter[1][@type='java.io.IOException']]"
		[Register ("replacementStream", "(Ljava/io/IOException;)Ljava/io/OutputStream;", "GetReplacementStream_Ljava_io_IOException_Handler")]
		protected abstract global::System.IO.Stream ReplacementStream (global::Java.IO.IOException p0);

		static IntPtr id_write_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='FaultRecoveringOutputStream']/method[@name='write' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("write", "([BII)V", "")]
		public override sealed void Write (byte[] p0, int p1, int p2)
		{
			if (id_write_arrayBII == IntPtr.Zero)
				id_write_arrayBII = JNIEnv.GetMethodID (class_ref, "write", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod  (Handle, id_write_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/FaultRecoveringOutputStream", DoNotGenerateAcw=true)]
	internal partial class FaultRecoveringOutputStreamInvoker : FaultRecoveringOutputStream {

		public FaultRecoveringOutputStreamInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (FaultRecoveringOutputStreamInvoker); }
		}

		static IntPtr id_replacementStream_Ljava_io_IOException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='FaultRecoveringOutputStream']/method[@name='replacementStream' and count(parameter)=1 and parameter[1][@type='java.io.IOException']]"
		[Register ("replacementStream", "(Ljava/io/IOException;)Ljava/io/OutputStream;", "GetReplacementStream_Ljava_io_IOException_Handler")]
		protected override global::System.IO.Stream ReplacementStream (global::Java.IO.IOException p0)
		{
			if (id_replacementStream_Ljava_io_IOException_ == IntPtr.Zero)
				id_replacementStream_Ljava_io_IOException_ = JNIEnv.GetMethodID (class_ref, "replacementStream", "(Ljava/io/IOException;)Ljava/io/OutputStream;");
			global::System.IO.Stream __ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_replacementStream_Ljava_io_IOException_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
