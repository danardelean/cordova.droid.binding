using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='DirectoryManager']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/cordova/DirectoryManager", DoNotGenerateAcw=true)]
	public partial class DirectoryManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/DirectoryManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DirectoryManager); }
		}

		protected DirectoryManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='DirectoryManager']/constructor[@name='DirectoryManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DirectoryManager () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DirectoryManager)) {
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

		static IntPtr id_getFreeDiskSpace_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='DirectoryManager']/method[@name='getFreeDiskSpace' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getFreeDiskSpace", "(Z)J", "")]
		public static long GetFreeDiskSpace (bool p0)
		{
			if (id_getFreeDiskSpace_Z == IntPtr.Zero)
				id_getFreeDiskSpace_Z = JNIEnv.GetStaticMethodID (class_ref, "getFreeDiskSpace", "(Z)J");
			return JNIEnv.CallStaticLongMethod  (class_ref, id_getFreeDiskSpace_Z, new JValue (p0));
		}

		static IntPtr id_getTempDirectoryPath_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='DirectoryManager']/method[@name='getTempDirectoryPath' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getTempDirectoryPath", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetTempDirectoryPath (global::Android.Content.Context p0)
		{
			if (id_getTempDirectoryPath_Landroid_content_Context_ == IntPtr.Zero)
				id_getTempDirectoryPath_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getTempDirectoryPath", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTempDirectoryPath_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_testFileExists_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='DirectoryManager']/method[@name='testFileExists' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("testFileExists", "(Ljava/lang/String;)Z", "")]
		public static bool TestFileExists (string p0)
		{
			if (id_testFileExists_Ljava_lang_String_ == IntPtr.Zero)
				id_testFileExists_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "testFileExists", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_testFileExists_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_testSaveLocationExists;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='DirectoryManager']/method[@name='testSaveLocationExists' and count(parameter)=0]"
		[Register ("testSaveLocationExists", "()Z", "")]
		public static bool TestSaveLocationExists ()
		{
			if (id_testSaveLocationExists == IntPtr.Zero)
				id_testSaveLocationExists = JNIEnv.GetStaticMethodID (class_ref, "testSaveLocationExists", "()Z");
			return JNIEnv.CallStaticBooleanMethod  (class_ref, id_testSaveLocationExists);
		}

	}
}
