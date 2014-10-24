using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Squareup.Okhttp.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='NamedRunnable']"
	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/NamedRunnable", DoNotGenerateAcw=true)]
	public abstract partial class NamedRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/squareup/okhttp/internal/NamedRunnable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NamedRunnable); }
		}

		protected NamedRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='NamedRunnable']/constructor[@name='NamedRunnable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register (".ctor", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public NamedRunnable (string p0, params global:: Java.Lang.Object[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (NamedRunnable)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;[Ljava/lang/Object;)V", new JValue (native_p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;[Ljava/lang/Object;)V", new JValue (native_p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return;
			}

			if (id_ctor_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Execute);
			return cb_execute;
		}

		static void n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Okhttp.Internal.NamedRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.NamedRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='NamedRunnable']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()V", "GetExecuteHandler")]
		protected abstract void Execute ();

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='NamedRunnable']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "")]
		public void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_run);
		}

	}

	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/NamedRunnable", DoNotGenerateAcw=true)]
	internal partial class NamedRunnableInvoker : NamedRunnable {

		public NamedRunnableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (NamedRunnableInvoker); }
		}

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='NamedRunnable']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()V", "GetExecuteHandler")]
		protected override void Execute ()
		{
			if (id_execute == IntPtr.Zero)
				id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_execute);
		}

	}

}
