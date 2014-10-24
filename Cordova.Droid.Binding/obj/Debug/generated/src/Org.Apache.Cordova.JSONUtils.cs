using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='JSONUtils']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/cordova/JSONUtils", DoNotGenerateAcw=true)]
	public partial class JSONUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/JSONUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JSONUtils); }
		}

		protected JSONUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='JSONUtils']/constructor[@name='JSONUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public JSONUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (JSONUtils)) {
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

		static IntPtr id_toStringList_Lorg_json_JSONArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='JSONUtils']/method[@name='toStringList' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
		[Register ("toStringList", "(Lorg/json/JSONArray;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<string> ToStringList (global::Org.Json.JSONArray p0)
		{
			if (id_toStringList_Lorg_json_JSONArray_ == IntPtr.Zero)
				id_toStringList_Lorg_json_JSONArray_ = JNIEnv.GetStaticMethodID (class_ref, "toStringList", "(Lorg/json/JSONArray;)Ljava/util/List;");
			global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_toStringList_Lorg_json_JSONArray_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
