using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='ScrollEvent']"
	[global::Android.Runtime.Register ("org/apache/cordova/ScrollEvent", DoNotGenerateAcw=true)]
	public partial class ScrollEvent : global::Java.Lang.Object {


		static IntPtr l_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='ScrollEvent']/field[@name='l']"
		[Register ("l")]
		public int L {
			get {
				if (l_jfieldId == IntPtr.Zero)
					l_jfieldId = JNIEnv.GetFieldID (class_ref, "l", "I");
				return JNIEnv.GetIntField (Handle, l_jfieldId);
			}
			set {
				if (l_jfieldId == IntPtr.Zero)
					l_jfieldId = JNIEnv.GetFieldID (class_ref, "l", "I");
				JNIEnv.SetField (Handle, l_jfieldId, value);
			}
		}

		static IntPtr nl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='ScrollEvent']/field[@name='nl']"
		[Register ("nl")]
		public int Nl {
			get {
				if (nl_jfieldId == IntPtr.Zero)
					nl_jfieldId = JNIEnv.GetFieldID (class_ref, "nl", "I");
				return JNIEnv.GetIntField (Handle, nl_jfieldId);
			}
			set {
				if (nl_jfieldId == IntPtr.Zero)
					nl_jfieldId = JNIEnv.GetFieldID (class_ref, "nl", "I");
				JNIEnv.SetField (Handle, nl_jfieldId, value);
			}
		}

		static IntPtr nt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='ScrollEvent']/field[@name='nt']"
		[Register ("nt")]
		public int Nt {
			get {
				if (nt_jfieldId == IntPtr.Zero)
					nt_jfieldId = JNIEnv.GetFieldID (class_ref, "nt", "I");
				return JNIEnv.GetIntField (Handle, nt_jfieldId);
			}
			set {
				if (nt_jfieldId == IntPtr.Zero)
					nt_jfieldId = JNIEnv.GetFieldID (class_ref, "nt", "I");
				JNIEnv.SetField (Handle, nt_jfieldId, value);
			}
		}

		static IntPtr t_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='ScrollEvent']/field[@name='t']"
		[Register ("t")]
		public int T {
			get {
				if (t_jfieldId == IntPtr.Zero)
					t_jfieldId = JNIEnv.GetFieldID (class_ref, "t", "I");
				return JNIEnv.GetIntField (Handle, t_jfieldId);
			}
			set {
				if (t_jfieldId == IntPtr.Zero)
					t_jfieldId = JNIEnv.GetFieldID (class_ref, "t", "I");
				JNIEnv.SetField (Handle, t_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/ScrollEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScrollEvent); }
		}

		protected ScrollEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getTargetView;
#pragma warning disable 0169
		static Delegate GetGetTargetViewHandler ()
		{
			if (cb_getTargetView == null)
				cb_getTargetView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTargetView);
			return cb_getTargetView;
		}

		static IntPtr n_GetTargetView (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.ScrollEvent __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ScrollEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TargetView);
		}
#pragma warning restore 0169

		static IntPtr id_getTargetView;
		public virtual global::Android.Views.View TargetView {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='ScrollEvent']/method[@name='getTargetView' and count(parameter)=0]"
			[Register ("getTargetView", "()Landroid/view/View;", "GetGetTargetViewHandler")]
			get {
				if (id_getTargetView == IntPtr.Zero)
					id_getTargetView = JNIEnv.GetMethodID (class_ref, "getTargetView", "()Landroid/view/View;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getTargetView), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTargetView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_dl;
#pragma warning disable 0169
		static Delegate GetDlHandler ()
		{
			if (cb_dl == null)
				cb_dl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Dl);
			return cb_dl;
		}

		static int n_Dl (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.ScrollEvent __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ScrollEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Dl ();
		}
#pragma warning restore 0169

		static IntPtr id_dl;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='ScrollEvent']/method[@name='dl' and count(parameter)=0]"
		[Register ("dl", "()I", "GetDlHandler")]
		public virtual int Dl ()
		{
			if (id_dl == IntPtr.Zero)
				id_dl = JNIEnv.GetMethodID (class_ref, "dl", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_dl);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dl", "()I"));
		}

		static Delegate cb_dt;
#pragma warning disable 0169
		static Delegate GetDtHandler ()
		{
			if (cb_dt == null)
				cb_dt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Dt);
			return cb_dt;
		}

		static int n_Dt (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.ScrollEvent __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ScrollEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Dt ();
		}
#pragma warning restore 0169

		static IntPtr id_dt;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='ScrollEvent']/method[@name='dt' and count(parameter)=0]"
		[Register ("dt", "()I", "GetDtHandler")]
		public virtual int Dt ()
		{
			if (id_dt == IntPtr.Zero)
				id_dt = JNIEnv.GetMethodID (class_ref, "dt", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_dt);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dt", "()I"));
		}

	}
}
