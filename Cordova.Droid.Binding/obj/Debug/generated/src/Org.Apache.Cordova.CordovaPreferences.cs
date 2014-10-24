using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPreferences']"
	[global::Android.Runtime.Register ("org/apache/cordova/CordovaPreferences", DoNotGenerateAcw=true)]
	public partial class CordovaPreferences : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/CordovaPreferences", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CordovaPreferences); }
		}

		protected CordovaPreferences (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPreferences']/constructor[@name='CordovaPreferences' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public CordovaPreferences () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CordovaPreferences)) {
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

		static Delegate cb_getAll;
#pragma warning disable 0169
		static Delegate GetGetAllHandler ()
		{
			if (cb_getAll == null)
				cb_getAll = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAll);
			return cb_getAll;
		}

		static IntPtr n_GetAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaPreferences __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.All);
		}
#pragma warning restore 0169

		static IntPtr id_getAll;
		public virtual global::System.Collections.Generic.IDictionary<string, string> All {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPreferences']/method[@name='getAll' and count(parameter)=0]"
			[Register ("getAll", "()Ljava/util/Map;", "GetGetAllHandler")]
			get {
				if (id_getAll == IntPtr.Zero)
					id_getAll = JNIEnv.GetMethodID (class_ref, "getAll", "()Ljava/util/Map;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAll), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAll", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_copyIntoIntentExtras_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetCopyIntoIntentExtras_Landroid_app_Activity_Handler ()
		{
			if (cb_copyIntoIntentExtras_Landroid_app_Activity_ == null)
				cb_copyIntoIntentExtras_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CopyIntoIntentExtras_Landroid_app_Activity_);
			return cb_copyIntoIntentExtras_Landroid_app_Activity_;
		}

		static void n_CopyIntoIntentExtras_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaPreferences __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CopyIntoIntentExtras (p0);
		}
#pragma warning restore 0169

		static IntPtr id_copyIntoIntentExtras_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPreferences']/method[@name='copyIntoIntentExtras' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("copyIntoIntentExtras", "(Landroid/app/Activity;)V", "GetCopyIntoIntentExtras_Landroid_app_Activity_Handler")]
		public virtual void CopyIntoIntentExtras (global::Android.App.Activity p0)
		{
			if (id_copyIntoIntentExtras_Landroid_app_Activity_ == IntPtr.Zero)
				id_copyIntoIntentExtras_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "copyIntoIntentExtras", "(Landroid/app/Activity;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_copyIntoIntentExtras_Landroid_app_Activity_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copyIntoIntentExtras", "(Landroid/app/Activity;)V"), new JValue (p0));
		}

		static Delegate cb_getBoolean_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetBoolean_Ljava_lang_String_ZHandler ()
		{
			if (cb_getBoolean_Ljava_lang_String_Z == null)
				cb_getBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool>) n_GetBoolean_Ljava_lang_String_Z);
			return cb_getBoolean_Ljava_lang_String_Z;
		}

		static bool n_GetBoolean_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Org.Apache.Cordova.CordovaPreferences __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBoolean (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBoolean_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPreferences']/method[@name='getBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getBoolean", "(Ljava/lang/String;Z)Z", "GetGetBoolean_Ljava_lang_String_ZHandler")]
		public virtual bool GetBoolean (string p0, bool p1)
		{
			if (id_getBoolean_Ljava_lang_String_Z == IntPtr.Zero)
				id_getBoolean_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "getBoolean", "(Ljava/lang/String;Z)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_getBoolean_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBoolean", "(Ljava/lang/String;Z)Z"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getDouble_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetGetDouble_Ljava_lang_String_DHandler ()
		{
			if (cb_getDouble_Ljava_lang_String_D == null)
				cb_getDouble_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double, double>) n_GetDouble_Ljava_lang_String_D);
			return cb_getDouble_Ljava_lang_String_D;
		}

		static double n_GetDouble_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::Org.Apache.Cordova.CordovaPreferences __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.GetDouble (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDouble_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPreferences']/method[@name='getDouble' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("getDouble", "(Ljava/lang/String;D)D", "GetGetDouble_Ljava_lang_String_DHandler")]
		public virtual double GetDouble (string p0, double p1)
		{
			if (id_getDouble_Ljava_lang_String_D == IntPtr.Zero)
				id_getDouble_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "getDouble", "(Ljava/lang/String;D)D");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			double __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallDoubleMethod  (Handle, id_getDouble_Ljava_lang_String_D, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDouble", "(Ljava/lang/String;D)D"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getInteger_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetInteger_Ljava_lang_String_IHandler ()
		{
			if (cb_getInteger_Ljava_lang_String_I == null)
				cb_getInteger_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_GetInteger_Ljava_lang_String_I);
			return cb_getInteger_Ljava_lang_String_I;
		}

		static int n_GetInteger_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Apache.Cordova.CordovaPreferences __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInteger (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getInteger_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPreferences']/method[@name='getInteger' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getInteger", "(Ljava/lang/String;I)I", "GetGetInteger_Ljava_lang_String_IHandler")]
		public virtual int GetInteger (string p0, int p1)
		{
			if (id_getInteger_Ljava_lang_String_I == IntPtr.Zero)
				id_getInteger_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getInteger", "(Ljava/lang/String;I)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getInteger_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInteger", "(Ljava/lang/String;I)I"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetString_Ljava_lang_String_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Apache.Cordova.CordovaPreferences __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPreferences']/method[@name='getString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual string GetString (string p0, string p1)
		{
			if (id_getString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getString_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_set_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_ZHandler ()
		{
			if (cb_set_Ljava_lang_String_Z == null)
				cb_set_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_Set_Ljava_lang_String_Z);
			return cb_set_Ljava_lang_String_Z;
		}

		static void n_Set_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Org.Apache.Cordova.CordovaPreferences __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_set_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPreferences']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("set", "(Ljava/lang/String;Z)V", "GetSet_Ljava_lang_String_ZHandler")]
		public virtual void Set (string p0, bool p1)
		{
			if (id_set_Ljava_lang_String_Z == IntPtr.Zero)
				id_set_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_set_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Ljava/lang/String;Z)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_set_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_DHandler ()
		{
			if (cb_set_Ljava_lang_String_D == null)
				cb_set_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double>) n_Set_Ljava_lang_String_D);
			return cb_set_Ljava_lang_String_D;
		}

		static void n_Set_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::Org.Apache.Cordova.CordovaPreferences __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_set_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPreferences']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("set", "(Ljava/lang/String;D)V", "GetSet_Ljava_lang_String_DHandler")]
		public virtual void Set (string p0, double p1)
		{
			if (id_set_Ljava_lang_String_D == IntPtr.Zero)
				id_set_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;D)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_set_Ljava_lang_String_D, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Ljava/lang/String;D)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_set_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_IHandler ()
		{
			if (cb_set_Ljava_lang_String_I == null)
				cb_set_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Set_Ljava_lang_String_I);
			return cb_set_Ljava_lang_String_I;
		}

		static void n_Set_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Apache.Cordova.CordovaPreferences __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_set_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPreferences']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("set", "(Ljava/lang/String;I)V", "GetSet_Ljava_lang_String_IHandler")]
		public virtual void Set (string p0, int p1)
		{
			if (id_set_Ljava_lang_String_I == IntPtr.Zero)
				id_set_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_set_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Ljava/lang/String;I)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_set_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_set_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_set_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Ljava_lang_String_Ljava_lang_String_);
			return cb_set_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Set_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Apache.Cordova.CordovaPreferences __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_set_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPreferences']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("set", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSet_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void Set (string p0, string p1)
		{
			if (id_set_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_set_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_set_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_setPreferencesBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSetPreferencesBundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_setPreferencesBundle_Landroid_os_Bundle_ == null)
				cb_setPreferencesBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPreferencesBundle_Landroid_os_Bundle_);
			return cb_setPreferencesBundle_Landroid_os_Bundle_;
		}

		static void n_SetPreferencesBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaPreferences __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPreferencesBundle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPreferencesBundle_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaPreferences']/method[@name='setPreferencesBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("setPreferencesBundle", "(Landroid/os/Bundle;)V", "GetSetPreferencesBundle_Landroid_os_Bundle_Handler")]
		public virtual void SetPreferencesBundle (global::Android.OS.Bundle p0)
		{
			if (id_setPreferencesBundle_Landroid_os_Bundle_ == IntPtr.Zero)
				id_setPreferencesBundle_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "setPreferencesBundle", "(Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPreferencesBundle_Landroid_os_Bundle_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPreferencesBundle", "(Landroid/os/Bundle;)V"), new JValue (p0));
		}

	}
}
