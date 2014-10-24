using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Squareup.Okhttp.Internal.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='Ping']"
	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/spdy/Ping", DoNotGenerateAcw=true)]
	public sealed partial class Ping : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/squareup/okhttp/internal/spdy/Ping", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Ping); }
		}

		internal Ping (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_roundTripTime;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='Ping']/method[@name='roundTripTime' and count(parameter)=0]"
		[Register ("roundTripTime", "()J", "")]
		public long RoundTripTime ()
		{
			if (id_roundTripTime == IntPtr.Zero)
				id_roundTripTime = JNIEnv.GetMethodID (class_ref, "roundTripTime", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_roundTripTime);
		}

		static IntPtr id_roundTripTime_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal.spdy']/class[@name='Ping']/method[@name='roundTripTime' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("roundTripTime", "(JLjava/util/concurrent/TimeUnit;)J", "")]
		public long RoundTripTime (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			if (id_roundTripTime_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_roundTripTime_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "roundTripTime", "(JLjava/util/concurrent/TimeUnit;)J");
			long __ret = JNIEnv.CallLongMethod  (Handle, id_roundTripTime_JLjava_util_concurrent_TimeUnit_, new JValue (p0), new JValue (p1));
			return __ret;
		}

	}
}
