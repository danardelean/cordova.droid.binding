using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Squareup.Okhttp.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='AbstractOutputStream']"
	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/AbstractOutputStream", DoNotGenerateAcw=true)]
	public abstract partial class AbstractOutputStream : global::Java.IO.OutputStream {


		static IntPtr closed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='AbstractOutputStream']/field[@name='closed']"
		[Register ("closed")]
		protected bool Closed {
			get {
				if (closed_jfieldId == IntPtr.Zero)
					closed_jfieldId = JNIEnv.GetFieldID (class_ref, "closed", "Z");
				return JNIEnv.GetBooleanField (Handle, closed_jfieldId);
			}
			set {
				if (closed_jfieldId == IntPtr.Zero)
					closed_jfieldId = JNIEnv.GetFieldID (class_ref, "closed", "Z");
				JNIEnv.SetField (Handle, closed_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/squareup/okhttp/internal/AbstractOutputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractOutputStream); }
		}

		protected AbstractOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='AbstractOutputStream']/constructor[@name='AbstractOutputStream' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AbstractOutputStream () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AbstractOutputStream)) {
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

		static Delegate cb_isClosed;
#pragma warning disable 0169
		static Delegate GetIsClosedHandler ()
		{
			if (cb_isClosed == null)
				cb_isClosed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsClosed);
			return cb_isClosed;
		}

		static bool n_IsClosed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Squareup.Okhttp.Internal.AbstractOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.AbstractOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClosed;
		}
#pragma warning restore 0169

		static IntPtr id_isClosed;
		public virtual bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='AbstractOutputStream']/method[@name='isClosed' and count(parameter)=0]"
			[Register ("isClosed", "()Z", "GetIsClosedHandler")]
			get {
				if (id_isClosed == IntPtr.Zero)
					id_isClosed = JNIEnv.GetMethodID (class_ref, "isClosed", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isClosed);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isClosed", "()Z"));
			}
		}

		static IntPtr id_checkNotClosed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='AbstractOutputStream']/method[@name='checkNotClosed' and count(parameter)=0]"
		[Register ("checkNotClosed", "()V", "")]
		protected void CheckNotClosed ()
		{
			if (id_checkNotClosed == IntPtr.Zero)
				id_checkNotClosed = JNIEnv.GetMethodID (class_ref, "checkNotClosed", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_checkNotClosed);
		}

		static IntPtr id_write_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='AbstractOutputStream']/method[@name='write' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("write", "(I)V", "")]
		public override sealed void Write (int p0)
		{
			if (id_write_I == IntPtr.Zero)
				id_write_I = JNIEnv.GetMethodID (class_ref, "write", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_write_I, new JValue (p0));
		}

	}

	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/AbstractOutputStream", DoNotGenerateAcw=true)]
	internal partial class AbstractOutputStreamInvoker : AbstractOutputStream {

		public AbstractOutputStreamInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractOutputStreamInvoker); }
		}

	}

}
