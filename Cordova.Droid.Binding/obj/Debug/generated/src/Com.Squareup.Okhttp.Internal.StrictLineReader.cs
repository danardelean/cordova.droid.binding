using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Squareup.Okhttp.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='StrictLineReader']"
	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/StrictLineReader", DoNotGenerateAcw=true)]
	public partial class StrictLineReader : global::Java.Lang.Object, global::Java.IO.ICloseable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/squareup/okhttp/internal/StrictLineReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StrictLineReader); }
		}

		protected StrictLineReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_InputStream_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='StrictLineReader']/constructor[@name='StrictLineReader' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register (".ctor", "(Ljava/io/InputStream;Ljava/nio/charset/Charset;)V", "")]
		public StrictLineReader (global::System.IO.Stream p0, global::Java.Nio.Charset.Charset p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);;
			if (GetType () != typeof (StrictLineReader)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;Ljava/nio/charset/Charset;)V", new JValue (native_p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/InputStream;Ljava/nio/charset/Charset;)V", new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_io_InputStream_Ljava_nio_charset_Charset_ == IntPtr.Zero)
				id_ctor_Ljava_io_InputStream_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;Ljava/nio/charset/Charset;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_Ljava_nio_charset_Charset_, new JValue (native_p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_InputStream_Ljava_nio_charset_Charset_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_Ljava_io_InputStream_ILjava_nio_charset_Charset_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='StrictLineReader']/constructor[@name='StrictLineReader' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.charset.Charset']]"
		[Register (".ctor", "(Ljava/io/InputStream;ILjava/nio/charset/Charset;)V", "")]
		public StrictLineReader (global::System.IO.Stream p0, int p1, global::Java.Nio.Charset.Charset p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);;
			if (GetType () != typeof (StrictLineReader)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;ILjava/nio/charset/Charset;)V", new JValue (native_p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/InputStream;ILjava/nio/charset/Charset;)V", new JValue (native_p0), new JValue (p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_io_InputStream_ILjava_nio_charset_Charset_ == IntPtr.Zero)
				id_ctor_Ljava_io_InputStream_ILjava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;ILjava/nio/charset/Charset;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_ILjava_nio_charset_Charset_, new JValue (native_p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_InputStream_ILjava_nio_charset_Charset_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Squareup.Okhttp.Internal.StrictLineReader __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.StrictLineReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='StrictLineReader']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_close);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
		}

		static Delegate cb_readInt;
#pragma warning disable 0169
		static Delegate GetReadIntHandler ()
		{
			if (cb_readInt == null)
				cb_readInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ReadInt);
			return cb_readInt;
		}

		static int n_ReadInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Okhttp.Internal.StrictLineReader __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.StrictLineReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadInt ();
		}
#pragma warning restore 0169

		static IntPtr id_readInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='StrictLineReader']/method[@name='readInt' and count(parameter)=0]"
		[Register ("readInt", "()I", "GetReadIntHandler")]
		public virtual int ReadInt ()
		{
			if (id_readInt == IntPtr.Zero)
				id_readInt = JNIEnv.GetMethodID (class_ref, "readInt", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_readInt);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readInt", "()I"));
		}

		static Delegate cb_readLine;
#pragma warning disable 0169
		static Delegate GetReadLineHandler ()
		{
			if (cb_readLine == null)
				cb_readLine = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadLine);
			return cb_readLine;
		}

		static IntPtr n_ReadLine (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Okhttp.Internal.StrictLineReader __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.StrictLineReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReadLine ());
		}
#pragma warning restore 0169

		static IntPtr id_readLine;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='StrictLineReader']/method[@name='readLine' and count(parameter)=0]"
		[Register ("readLine", "()Ljava/lang/String;", "GetReadLineHandler")]
		public virtual string ReadLine ()
		{
			if (id_readLine == IntPtr.Zero)
				id_readLine = JNIEnv.GetMethodID (class_ref, "readLine", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_readLine), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readLine", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

	}
}
