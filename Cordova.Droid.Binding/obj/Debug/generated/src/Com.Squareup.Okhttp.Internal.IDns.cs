using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Squareup.Okhttp.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Dns.1']"
	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/Dns$1", DoNotGenerateAcw=true)]
	public partial class Dns1 : global::Java.Lang.Object, global::Com.Squareup.Okhttp.Internal.IDns {


		public static class InterfaceConsts {

			// The following are fields from: com.squareup.okhttp.internal.Dns

			static IntPtr DEFAULT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal']/interface[@name='Dns']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public static global::Com.Squareup.Okhttp.Internal.IDns Default {
				get {
					if (DEFAULT_jfieldId == IntPtr.Zero)
						DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/squareup/okhttp/internal/Dns;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.IDns> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DEFAULT_jfieldId == IntPtr.Zero)
						DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/squareup/okhttp/internal/Dns;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DEFAULT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/squareup/okhttp/internal/Dns$1", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Dns1); }
		}

		protected Dns1 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAllByName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAllByName_Ljava_lang_String_Handler ()
		{
			if (cb_getAllByName_Ljava_lang_String_ == null)
				cb_getAllByName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAllByName_Ljava_lang_String_);
			return cb_getAllByName_Ljava_lang_String_;
		}

		static IntPtr n_GetAllByName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Squareup.Okhttp.Internal.Dns1 __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.Dns1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetAllByName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAllByName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Dns.1']/method[@name='getAllByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAllByName", "(Ljava/lang/String;)[Ljava/net/InetAddress;", "GetGetAllByName_Ljava_lang_String_Handler")]
		public virtual global::Java.Net.InetAddress[] GetAllByName (string p0)
		{
			if (id_getAllByName_Ljava_lang_String_ == IntPtr.Zero)
				id_getAllByName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAllByName", "(Ljava/lang/String;)[Ljava/net/InetAddress;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.Net.InetAddress[] __ret;
			if (GetType () == ThresholdType)
				__ret = (global::Java.Net.InetAddress[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAllByName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Net.InetAddress));
			else
				__ret = (global::Java.Net.InetAddress[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllByName", "(Ljava/lang/String;)[Ljava/net/InetAddress;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Net.InetAddress));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

	[Register ("com/squareup/okhttp/internal/Dns")]
	public abstract class Dns {

		internal Dns ()
		{
		}

		static IntPtr DEFAULT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal']/interface[@name='Dns']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Com.Squareup.Okhttp.Internal.IDns Default {
			get {
				if (DEFAULT_jfieldId == IntPtr.Zero)
					DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/squareup/okhttp/internal/Dns;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.IDns> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEFAULT_jfieldId == IntPtr.Zero)
					DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/squareup/okhttp/internal/Dns;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DEFAULT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr class_ref = JNIEnv.FindClass ("com/squareup/okhttp/internal/Dns");
	}

	[System.Obsolete ("Use the 'Dns' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class DnsConsts : Dns {

		private DnsConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.squareup.okhttp.internal']/interface[@name='Dns']"
	[Register ("com/squareup/okhttp/internal/Dns", "", "Com.Squareup.Okhttp.Internal.IDnsInvoker")]
	public partial interface IDns : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/interface[@name='Dns']/method[@name='getAllByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAllByName", "(Ljava/lang/String;)[Ljava/net/InetAddress;", "GetGetAllByName_Ljava_lang_String_Handler:Com.Squareup.Okhttp.Internal.IDnsInvoker, Cordova.Android.Binding")]
		global::Java.Net.InetAddress[] GetAllByName (string p0);

	}

	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/Dns", DoNotGenerateAcw=true)]
	internal class IDnsInvoker : global::Java.Lang.Object, IDns {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/squareup/okhttp/internal/Dns");
		IntPtr class_ref;

		public static IDns GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDns> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.squareup.okhttp.internal.Dns"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDnsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IDnsInvoker); }
		}

		static Delegate cb_getAllByName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAllByName_Ljava_lang_String_Handler ()
		{
			if (cb_getAllByName_Ljava_lang_String_ == null)
				cb_getAllByName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAllByName_Ljava_lang_String_);
			return cb_getAllByName_Ljava_lang_String_;
		}

		static IntPtr n_GetAllByName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Squareup.Okhttp.Internal.IDns __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.IDns> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetAllByName (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAllByName_Ljava_lang_String_;
		public global::Java.Net.InetAddress[] GetAllByName (string p0)
		{
			if (id_getAllByName_Ljava_lang_String_ == IntPtr.Zero)
				id_getAllByName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAllByName", "(Ljava/lang/String;)[Ljava/net/InetAddress;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Net.InetAddress[] __ret = (global::Java.Net.InetAddress[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getAllByName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Net.InetAddress));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
