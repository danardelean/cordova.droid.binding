using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='ExifHelper']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/cordova/ExifHelper", DoNotGenerateAcw=true)]
	public partial class ExifHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/ExifHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExifHelper); }
		}

		protected ExifHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='ExifHelper']/constructor[@name='ExifHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ExifHelper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ExifHelper)) {
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

		static Delegate cb_getOrientation;
#pragma warning disable 0169
		static Delegate GetGetOrientationHandler ()
		{
			if (cb_getOrientation == null)
				cb_getOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOrientation);
			return cb_getOrientation;
		}

		static int n_GetOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.ExifHelper __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ExifHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Orientation;
		}
#pragma warning restore 0169

		static IntPtr id_getOrientation;
		public virtual int Orientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='ExifHelper']/method[@name='getOrientation' and count(parameter)=0]"
			[Register ("getOrientation", "()I", "GetGetOrientationHandler")]
			get {
				if (id_getOrientation == IntPtr.Zero)
					id_getOrientation = JNIEnv.GetMethodID (class_ref, "getOrientation", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getOrientation);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrientation", "()I"));
			}
		}

		static Delegate cb_createInFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateInFile_Ljava_lang_String_Handler ()
		{
			if (cb_createInFile_Ljava_lang_String_ == null)
				cb_createInFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CreateInFile_Ljava_lang_String_);
			return cb_createInFile_Ljava_lang_String_;
		}

		static void n_CreateInFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.ExifHelper __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ExifHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreateInFile (p0);
		}
#pragma warning restore 0169

		static IntPtr id_createInFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='ExifHelper']/method[@name='createInFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createInFile", "(Ljava/lang/String;)V", "GetCreateInFile_Ljava_lang_String_Handler")]
		public virtual void CreateInFile (string p0)
		{
			if (id_createInFile_Ljava_lang_String_ == IntPtr.Zero)
				id_createInFile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createInFile", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_createInFile_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createInFile", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_createOutFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateOutFile_Ljava_lang_String_Handler ()
		{
			if (cb_createOutFile_Ljava_lang_String_ == null)
				cb_createOutFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CreateOutFile_Ljava_lang_String_);
			return cb_createOutFile_Ljava_lang_String_;
		}

		static void n_CreateOutFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.ExifHelper __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ExifHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreateOutFile (p0);
		}
#pragma warning restore 0169

		static IntPtr id_createOutFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='ExifHelper']/method[@name='createOutFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createOutFile", "(Ljava/lang/String;)V", "GetCreateOutFile_Ljava_lang_String_Handler")]
		public virtual void CreateOutFile (string p0)
		{
			if (id_createOutFile_Ljava_lang_String_ == IntPtr.Zero)
				id_createOutFile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createOutFile", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_createOutFile_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createOutFile", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_readExifData;
#pragma warning disable 0169
		static Delegate GetReadExifDataHandler ()
		{
			if (cb_readExifData == null)
				cb_readExifData = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReadExifData);
			return cb_readExifData;
		}

		static void n_ReadExifData (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.ExifHelper __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ExifHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadExifData ();
		}
#pragma warning restore 0169

		static IntPtr id_readExifData;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='ExifHelper']/method[@name='readExifData' and count(parameter)=0]"
		[Register ("readExifData", "()V", "GetReadExifDataHandler")]
		public virtual void ReadExifData ()
		{
			if (id_readExifData == IntPtr.Zero)
				id_readExifData = JNIEnv.GetMethodID (class_ref, "readExifData", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_readExifData);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readExifData", "()V"));
		}

		static Delegate cb_resetOrientation;
#pragma warning disable 0169
		static Delegate GetResetOrientationHandler ()
		{
			if (cb_resetOrientation == null)
				cb_resetOrientation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetOrientation);
			return cb_resetOrientation;
		}

		static void n_ResetOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.ExifHelper __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ExifHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetOrientation ();
		}
#pragma warning restore 0169

		static IntPtr id_resetOrientation;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='ExifHelper']/method[@name='resetOrientation' and count(parameter)=0]"
		[Register ("resetOrientation", "()V", "GetResetOrientationHandler")]
		public virtual void ResetOrientation ()
		{
			if (id_resetOrientation == IntPtr.Zero)
				id_resetOrientation = JNIEnv.GetMethodID (class_ref, "resetOrientation", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_resetOrientation);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetOrientation", "()V"));
		}

		static Delegate cb_writeExifData;
#pragma warning disable 0169
		static Delegate GetWriteExifDataHandler ()
		{
			if (cb_writeExifData == null)
				cb_writeExifData = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WriteExifData);
			return cb_writeExifData;
		}

		static void n_WriteExifData (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.ExifHelper __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ExifHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteExifData ();
		}
#pragma warning restore 0169

		static IntPtr id_writeExifData;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='ExifHelper']/method[@name='writeExifData' and count(parameter)=0]"
		[Register ("writeExifData", "()V", "GetWriteExifDataHandler")]
		public virtual void WriteExifData ()
		{
			if (id_writeExifData == IntPtr.Zero)
				id_writeExifData = JNIEnv.GetMethodID (class_ref, "writeExifData", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeExifData);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeExifData", "()V"));
		}

	}
}
