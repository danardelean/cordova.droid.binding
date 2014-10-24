using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaArgs']"
	[global::Android.Runtime.Register ("org/apache/cordova/CordovaArgs", DoNotGenerateAcw=true)]
	public partial class CordovaArgs : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/CordovaArgs", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CordovaArgs); }
		}

		protected CordovaArgs (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONArray_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaArgs']/constructor[@name='CordovaArgs' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
		[Register (".ctor", "(Lorg/json/JSONArray;)V", "")]
		public CordovaArgs (global::Org.Json.JSONArray p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CordovaArgs)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/json/JSONArray;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/json/JSONArray;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorg_json_JSONArray_ == IntPtr.Zero)
				id_ctor_Lorg_json_JSONArray_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONArray;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONArray_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_json_JSONArray_, new JValue (p0));
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Get_I);
			return cb_get_I;
		}

		static IntPtr n_Get_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CordovaArgs __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaArgs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get (p0));
		}
#pragma warning restore 0169

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaArgs']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Ljava/lang/Object;", "GetGet_IHandler")]
		public virtual global::Java.Lang.Object Get (int p0)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(I)Ljava/lang/Object;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getArrayBuffer_I;
#pragma warning disable 0169
		static Delegate GetGetArrayBuffer_IHandler ()
		{
			if (cb_getArrayBuffer_I == null)
				cb_getArrayBuffer_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetArrayBuffer_I);
			return cb_getArrayBuffer_I;
		}

		static IntPtr n_GetArrayBuffer_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CordovaArgs __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaArgs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetArrayBuffer (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getArrayBuffer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaArgs']/method[@name='getArrayBuffer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getArrayBuffer", "(I)[B", "GetGetArrayBuffer_IHandler")]
		public virtual byte[] GetArrayBuffer (int p0)
		{
			if (id_getArrayBuffer_I == IntPtr.Zero)
				id_getArrayBuffer_I = JNIEnv.GetMethodID (class_ref, "getArrayBuffer", "(I)[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getArrayBuffer_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getArrayBuffer", "(I)[B"), new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getBoolean_I;
#pragma warning disable 0169
		static Delegate GetGetBoolean_IHandler ()
		{
			if (cb_getBoolean_I == null)
				cb_getBoolean_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_GetBoolean_I);
			return cb_getBoolean_I;
		}

		static bool n_GetBoolean_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CordovaArgs __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaArgs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetBoolean (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getBoolean_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaArgs']/method[@name='getBoolean' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getBoolean", "(I)Z", "GetGetBoolean_IHandler")]
		public virtual bool GetBoolean (int p0)
		{
			if (id_getBoolean_I == IntPtr.Zero)
				id_getBoolean_I = JNIEnv.GetMethodID (class_ref, "getBoolean", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_getBoolean_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBoolean", "(I)Z"), new JValue (p0));
		}

		static Delegate cb_getDouble_I;
#pragma warning disable 0169
		static Delegate GetGetDouble_IHandler ()
		{
			if (cb_getDouble_I == null)
				cb_getDouble_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_GetDouble_I);
			return cb_getDouble_I;
		}

		static double n_GetDouble_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CordovaArgs __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaArgs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDouble (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getDouble_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaArgs']/method[@name='getDouble' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDouble", "(I)D", "GetGetDouble_IHandler")]
		public virtual double GetDouble (int p0)
		{
			if (id_getDouble_I == IntPtr.Zero)
				id_getDouble_I = JNIEnv.GetMethodID (class_ref, "getDouble", "(I)D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_getDouble_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDouble", "(I)D"), new JValue (p0));
		}

		static Delegate cb_getInt_I;
#pragma warning disable 0169
		static Delegate GetGetInt_IHandler ()
		{
			if (cb_getInt_I == null)
				cb_getInt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetInt_I);
			return cb_getInt_I;
		}

		static int n_GetInt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CordovaArgs __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaArgs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetInt (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getInt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaArgs']/method[@name='getInt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getInt", "(I)I", "GetGetInt_IHandler")]
		public virtual int GetInt (int p0)
		{
			if (id_getInt_I == IntPtr.Zero)
				id_getInt_I = JNIEnv.GetMethodID (class_ref, "getInt", "(I)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_getInt_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInt", "(I)I"), new JValue (p0));
		}

		static Delegate cb_getJSONArray_I;
#pragma warning disable 0169
		static Delegate GetGetJSONArray_IHandler ()
		{
			if (cb_getJSONArray_I == null)
				cb_getJSONArray_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetJSONArray_I);
			return cb_getJSONArray_I;
		}

		static IntPtr n_GetJSONArray_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CordovaArgs __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaArgs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetJSONArray (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getJSONArray_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaArgs']/method[@name='getJSONArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getJSONArray", "(I)Lorg/json/JSONArray;", "GetGetJSONArray_IHandler")]
		public virtual global::Org.Json.JSONArray GetJSONArray (int p0)
		{
			if (id_getJSONArray_I == IntPtr.Zero)
				id_getJSONArray_I = JNIEnv.GetMethodID (class_ref, "getJSONArray", "(I)Lorg/json/JSONArray;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallObjectMethod  (Handle, id_getJSONArray_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJSONArray", "(I)Lorg/json/JSONArray;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getJSONObject_I;
#pragma warning disable 0169
		static Delegate GetGetJSONObject_IHandler ()
		{
			if (cb_getJSONObject_I == null)
				cb_getJSONObject_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetJSONObject_I);
			return cb_getJSONObject_I;
		}

		static IntPtr n_GetJSONObject_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CordovaArgs __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaArgs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetJSONObject (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getJSONObject_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaArgs']/method[@name='getJSONObject' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getJSONObject", "(I)Lorg/json/JSONObject;", "GetGetJSONObject_IHandler")]
		public virtual global::Org.Json.JSONObject GetJSONObject (int p0)
		{
			if (id_getJSONObject_I == IntPtr.Zero)
				id_getJSONObject_I = JNIEnv.GetMethodID (class_ref, "getJSONObject", "(I)Lorg/json/JSONObject;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getJSONObject_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJSONObject", "(I)Lorg/json/JSONObject;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getLong_I;
#pragma warning disable 0169
		static Delegate GetGetLong_IHandler ()
		{
			if (cb_getLong_I == null)
				cb_getLong_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetLong_I);
			return cb_getLong_I;
		}

		static long n_GetLong_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CordovaArgs __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaArgs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetLong (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getLong_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaArgs']/method[@name='getLong' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLong", "(I)J", "GetGetLong_IHandler")]
		public virtual long GetLong (int p0)
		{
			if (id_getLong_I == IntPtr.Zero)
				id_getLong_I = JNIEnv.GetMethodID (class_ref, "getLong", "(I)J");

			if (GetType () == ThresholdType)
				return JNIEnv.CallLongMethod  (Handle, id_getLong_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLong", "(I)J"), new JValue (p0));
		}

		static Delegate cb_getString_I;
#pragma warning disable 0169
		static Delegate GetGetString_IHandler ()
		{
			if (cb_getString_I == null)
				cb_getString_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetString_I);
			return cb_getString_I;
		}

		static IntPtr n_GetString_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CordovaArgs __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaArgs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetString (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getString_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaArgs']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getString", "(I)Ljava/lang/String;", "GetGetString_IHandler")]
		public virtual string GetString (int p0)
		{
			if (id_getString_I == IntPtr.Zero)
				id_getString_I = JNIEnv.GetMethodID (class_ref, "getString", "(I)Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getString_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getString", "(I)Ljava/lang/String;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_isNull_I;
#pragma warning disable 0169
		static Delegate GetIsNull_IHandler ()
		{
			if (cb_isNull_I == null)
				cb_isNull_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsNull_I);
			return cb_isNull_I;
		}

		static bool n_IsNull_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CordovaArgs __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaArgs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNull (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isNull_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaArgs']/method[@name='isNull' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isNull", "(I)Z", "GetIsNull_IHandler")]
		public virtual bool IsNull (int p0)
		{
			if (id_isNull_I == IntPtr.Zero)
				id_isNull_I = JNIEnv.GetMethodID (class_ref, "isNull", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_isNull_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNull", "(I)Z"), new JValue (p0));
		}

		static Delegate cb_opt_I;
#pragma warning disable 0169
		static Delegate GetOpt_IHandler ()
		{
			if (cb_opt_I == null)
				cb_opt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Opt_I);
			return cb_opt_I;
		}

		static IntPtr n_Opt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CordovaArgs __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaArgs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Opt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_opt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaArgs']/method[@name='opt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("opt", "(I)Ljava/lang/Object;", "GetOpt_IHandler")]
		public virtual global::Java.Lang.Object Opt (int p0)
		{
			if (id_opt_I == IntPtr.Zero)
				id_opt_I = JNIEnv.GetMethodID (class_ref, "opt", "(I)Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_opt_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "opt", "(I)Ljava/lang/Object;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_optBoolean_I;
#pragma warning disable 0169
		static Delegate GetOptBoolean_IHandler ()
		{
			if (cb_optBoolean_I == null)
				cb_optBoolean_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_OptBoolean_I);
			return cb_optBoolean_I;
		}

		static bool n_OptBoolean_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CordovaArgs __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaArgs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OptBoolean (p0);
		}
#pragma warning restore 0169

		static IntPtr id_optBoolean_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaArgs']/method[@name='optBoolean' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("optBoolean", "(I)Z", "GetOptBoolean_IHandler")]
		public virtual bool OptBoolean (int p0)
		{
			if (id_optBoolean_I == IntPtr.Zero)
				id_optBoolean_I = JNIEnv.GetMethodID (class_ref, "optBoolean", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_optBoolean_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "optBoolean", "(I)Z"), new JValue (p0));
		}

		static Delegate cb_optDouble_I;
#pragma warning disable 0169
		static Delegate GetOptDouble_IHandler ()
		{
			if (cb_optDouble_I == null)
				cb_optDouble_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_OptDouble_I);
			return cb_optDouble_I;
		}

		static double n_OptDouble_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CordovaArgs __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaArgs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OptDouble (p0);
		}
#pragma warning restore 0169

		static IntPtr id_optDouble_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaArgs']/method[@name='optDouble' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("optDouble", "(I)D", "GetOptDouble_IHandler")]
		public virtual double OptDouble (int p0)
		{
			if (id_optDouble_I == IntPtr.Zero)
				id_optDouble_I = JNIEnv.GetMethodID (class_ref, "optDouble", "(I)D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_optDouble_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "optDouble", "(I)D"), new JValue (p0));
		}

		static Delegate cb_optInt_I;
#pragma warning disable 0169
		static Delegate GetOptInt_IHandler ()
		{
			if (cb_optInt_I == null)
				cb_optInt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_OptInt_I);
			return cb_optInt_I;
		}

		static int n_OptInt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CordovaArgs __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaArgs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OptInt (p0);
		}
#pragma warning restore 0169

		static IntPtr id_optInt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaArgs']/method[@name='optInt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("optInt", "(I)I", "GetOptInt_IHandler")]
		public virtual int OptInt (int p0)
		{
			if (id_optInt_I == IntPtr.Zero)
				id_optInt_I = JNIEnv.GetMethodID (class_ref, "optInt", "(I)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_optInt_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "optInt", "(I)I"), new JValue (p0));
		}

		static Delegate cb_optJSONArray_I;
#pragma warning disable 0169
		static Delegate GetOptJSONArray_IHandler ()
		{
			if (cb_optJSONArray_I == null)
				cb_optJSONArray_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_OptJSONArray_I);
			return cb_optJSONArray_I;
		}

		static IntPtr n_OptJSONArray_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CordovaArgs __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaArgs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OptJSONArray (p0));
		}
#pragma warning restore 0169

		static IntPtr id_optJSONArray_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaArgs']/method[@name='optJSONArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("optJSONArray", "(I)Lorg/json/JSONArray;", "GetOptJSONArray_IHandler")]
		public virtual global::Org.Json.JSONArray OptJSONArray (int p0)
		{
			if (id_optJSONArray_I == IntPtr.Zero)
				id_optJSONArray_I = JNIEnv.GetMethodID (class_ref, "optJSONArray", "(I)Lorg/json/JSONArray;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallObjectMethod  (Handle, id_optJSONArray_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "optJSONArray", "(I)Lorg/json/JSONArray;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_optJSONObject_I;
#pragma warning disable 0169
		static Delegate GetOptJSONObject_IHandler ()
		{
			if (cb_optJSONObject_I == null)
				cb_optJSONObject_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_OptJSONObject_I);
			return cb_optJSONObject_I;
		}

		static IntPtr n_OptJSONObject_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CordovaArgs __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaArgs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OptJSONObject (p0));
		}
#pragma warning restore 0169

		static IntPtr id_optJSONObject_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaArgs']/method[@name='optJSONObject' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("optJSONObject", "(I)Lorg/json/JSONObject;", "GetOptJSONObject_IHandler")]
		public virtual global::Org.Json.JSONObject OptJSONObject (int p0)
		{
			if (id_optJSONObject_I == IntPtr.Zero)
				id_optJSONObject_I = JNIEnv.GetMethodID (class_ref, "optJSONObject", "(I)Lorg/json/JSONObject;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_optJSONObject_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "optJSONObject", "(I)Lorg/json/JSONObject;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_optLong_I;
#pragma warning disable 0169
		static Delegate GetOptLong_IHandler ()
		{
			if (cb_optLong_I == null)
				cb_optLong_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_OptLong_I);
			return cb_optLong_I;
		}

		static long n_OptLong_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CordovaArgs __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaArgs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OptLong (p0);
		}
#pragma warning restore 0169

		static IntPtr id_optLong_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaArgs']/method[@name='optLong' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("optLong", "(I)J", "GetOptLong_IHandler")]
		public virtual long OptLong (int p0)
		{
			if (id_optLong_I == IntPtr.Zero)
				id_optLong_I = JNIEnv.GetMethodID (class_ref, "optLong", "(I)J");

			if (GetType () == ThresholdType)
				return JNIEnv.CallLongMethod  (Handle, id_optLong_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "optLong", "(I)J"), new JValue (p0));
		}

		static Delegate cb_optString_I;
#pragma warning disable 0169
		static Delegate GetOptString_IHandler ()
		{
			if (cb_optString_I == null)
				cb_optString_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_OptString_I);
			return cb_optString_I;
		}

		static IntPtr n_OptString_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.CordovaArgs __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaArgs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OptString (p0));
		}
#pragma warning restore 0169

		static IntPtr id_optString_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaArgs']/method[@name='optString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("optString", "(I)Ljava/lang/String;", "GetOptString_IHandler")]
		public virtual string OptString (int p0)
		{
			if (id_optString_I == IntPtr.Zero)
				id_optString_I = JNIEnv.GetMethodID (class_ref, "optString", "(I)Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_optString_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "optString", "(I)Ljava/lang/String;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
