using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Squareup.Okhttp.Internal.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='IncomingStreamHandler.1']"
	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/spdy/IncomingStreamHandler$1", DoNotGenerateAcw=true)]
	public partial class IncomingStreamHandler1 : global::Java.Lang.Object, global::Com.Squareup.Okhttp.Internal.Spdy.IIncomingStreamHandler {


		public static class InterfaceConsts {

			// The following are fields from: com.squareup.okhttp.internal.spdy.IncomingStreamHandler

			static IntPtr REFUSE_INCOMING_STREAMS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='IncomingStreamHandler']/field[@name='REFUSE_INCOMING_STREAMS']"
			[Register ("REFUSE_INCOMING_STREAMS")]
			public static global::Com.Squareup.Okhttp.Internal.Spdy.IIncomingStreamHandler RefuseIncomingStreams {
				get {
					if (REFUSE_INCOMING_STREAMS_jfieldId == IntPtr.Zero)
						REFUSE_INCOMING_STREAMS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFUSE_INCOMING_STREAMS", "Lcom/squareup/okhttp/internal/spdy/IncomingStreamHandler;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REFUSE_INCOMING_STREAMS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IIncomingStreamHandler> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (REFUSE_INCOMING_STREAMS_jfieldId == IntPtr.Zero)
						REFUSE_INCOMING_STREAMS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFUSE_INCOMING_STREAMS", "Lcom/squareup/okhttp/internal/spdy/IncomingStreamHandler;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, REFUSE_INCOMING_STREAMS_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/squareup/okhttp/internal/spdy/IncomingStreamHandler$1", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IncomingStreamHandler1); }
		}

		protected IncomingStreamHandler1 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_receive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_;
#pragma warning disable 0169
		static Delegate GetReceive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_Handler ()
		{
			if (cb_receive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_ == null)
				cb_receive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Receive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_);
			return cb_receive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_;
		}

		static void n_Receive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Squareup.Okhttp.Internal.Spdy.IncomingStreamHandler1 __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IncomingStreamHandler1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Squareup.Okhttp.Internal.Spdy.SpdyStream p0 = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Receive (p0);
		}
#pragma warning restore 0169

		static IntPtr id_receive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='IncomingStreamHandler.1']/method[@name='receive' and count(parameter)=1 and parameter[1][@type='com.squareup.okhttp.internal.spdy.SpdyStream']]"
		[Register ("receive", "(Lcom/squareup/okhttp/internal/spdy/SpdyStream;)V", "GetReceive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_Handler")]
		public virtual void Receive (global::Com.Squareup.Okhttp.Internal.Spdy.SpdyStream p0)
		{
			if (id_receive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_ == IntPtr.Zero)
				id_receive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_ = JNIEnv.GetMethodID (class_ref, "receive", "(Lcom/squareup/okhttp/internal/spdy/SpdyStream;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_receive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "receive", "(Lcom/squareup/okhttp/internal/spdy/SpdyStream;)V"), new JValue (p0));
		}

	}

	[Register ("com/squareup/okhttp/internal/spdy/IncomingStreamHandler")]
	public abstract class IncomingStreamHandler {

		internal IncomingStreamHandler ()
		{
		}

		static IntPtr REFUSE_INCOMING_STREAMS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='IncomingStreamHandler']/field[@name='REFUSE_INCOMING_STREAMS']"
		[Register ("REFUSE_INCOMING_STREAMS")]
		public static global::Com.Squareup.Okhttp.Internal.Spdy.IIncomingStreamHandler RefuseIncomingStreams {
			get {
				if (REFUSE_INCOMING_STREAMS_jfieldId == IntPtr.Zero)
					REFUSE_INCOMING_STREAMS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFUSE_INCOMING_STREAMS", "Lcom/squareup/okhttp/internal/spdy/IncomingStreamHandler;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REFUSE_INCOMING_STREAMS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IIncomingStreamHandler> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (REFUSE_INCOMING_STREAMS_jfieldId == IntPtr.Zero)
					REFUSE_INCOMING_STREAMS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFUSE_INCOMING_STREAMS", "Lcom/squareup/okhttp/internal/spdy/IncomingStreamHandler;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, REFUSE_INCOMING_STREAMS_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr class_ref = JNIEnv.FindClass ("com/squareup/okhttp/internal/spdy/IncomingStreamHandler");
	}

	[System.Obsolete ("Use the 'IncomingStreamHandler' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class IncomingStreamHandlerConsts : IncomingStreamHandler {

		private IncomingStreamHandlerConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='IncomingStreamHandler']"
	[Register ("com/squareup/okhttp/internal/spdy/IncomingStreamHandler", "", "Com.Squareup.Okhttp.Internal.Spdy.IIncomingStreamHandlerInvoker")]
	public partial interface IIncomingStreamHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/interface[@name='IncomingStreamHandler']/method[@name='receive' and count(parameter)=1 and parameter[1][@type='com.squareup.okhttp.internal.spdy.SpdyStream']]"
		[Register ("receive", "(Lcom/squareup/okhttp/internal/spdy/SpdyStream;)V", "GetReceive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_Handler:Com.Squareup.Okhttp.Internal.Spdy.IIncomingStreamHandlerInvoker, Cordova.Android.Binding")]
		void Receive (global::Com.Squareup.Okhttp.Internal.Spdy.SpdyStream p0);

	}

	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/spdy/IncomingStreamHandler", DoNotGenerateAcw=true)]
	internal class IIncomingStreamHandlerInvoker : global::Java.Lang.Object, IIncomingStreamHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/squareup/okhttp/internal/spdy/IncomingStreamHandler");
		IntPtr class_ref;

		public static IIncomingStreamHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIncomingStreamHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.squareup.okhttp.internal.spdy.IncomingStreamHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIncomingStreamHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IIncomingStreamHandlerInvoker); }
		}

		static Delegate cb_receive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_;
#pragma warning disable 0169
		static Delegate GetReceive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_Handler ()
		{
			if (cb_receive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_ == null)
				cb_receive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Receive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_);
			return cb_receive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_;
		}

		static void n_Receive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Squareup.Okhttp.Internal.Spdy.IIncomingStreamHandler __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.IIncomingStreamHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Squareup.Okhttp.Internal.Spdy.SpdyStream p0 = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Spdy.SpdyStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Receive (p0);
		}
#pragma warning restore 0169

		IntPtr id_receive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_;
		public void Receive (global::Com.Squareup.Okhttp.Internal.Spdy.SpdyStream p0)
		{
			if (id_receive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_ == IntPtr.Zero)
				id_receive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_ = JNIEnv.GetMethodID (class_ref, "receive", "(Lcom/squareup/okhttp/internal/spdy/SpdyStream;)V");
			JNIEnv.CallVoidMethod (Handle, id_receive_Lcom_squareup_okhttp_internal_spdy_SpdyStream_, new JValue (p0));
		}

	}

}
