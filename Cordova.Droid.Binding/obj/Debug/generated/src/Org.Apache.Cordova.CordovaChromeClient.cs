using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaChromeClient']"
	[global::Android.Runtime.Register ("org/apache/cordova/CordovaChromeClient", DoNotGenerateAcw=true)]
	public partial class CordovaChromeClient : global::Android.Webkit.WebChromeClient {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaChromeClient']/field[@name='FILECHOOSER_RESULTCODE']"
		[Register ("FILECHOOSER_RESULTCODE")]
		public const int FilechooserResultcode = (int) 5173;

		static IntPtr appView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaChromeClient']/field[@name='appView']"
		[Register ("appView")]
		protected global::Org.Apache.Cordova.CordovaWebView AppView {
			get {
				if (appView_jfieldId == IntPtr.Zero)
					appView_jfieldId = JNIEnv.GetFieldID (class_ref, "appView", "Lorg/apache/cordova/CordovaWebView;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, appView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (appView_jfieldId == IntPtr.Zero)
					appView_jfieldId = JNIEnv.GetFieldID (class_ref, "appView", "Lorg/apache/cordova/CordovaWebView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, appView_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr cordova_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaChromeClient']/field[@name='cordova']"
		[Register ("cordova")]
		protected global::Org.Apache.Cordova.ICordovaInterface Cordova {
			get {
				if (cordova_jfieldId == IntPtr.Zero)
					cordova_jfieldId = JNIEnv.GetFieldID (class_ref, "cordova", "Lorg/apache/cordova/CordovaInterface;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, cordova_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.ICordovaInterface> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cordova_jfieldId == IntPtr.Zero)
					cordova_jfieldId = JNIEnv.GetFieldID (class_ref, "cordova", "Lorg/apache/cordova/CordovaInterface;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, cordova_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mUploadMessage_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaChromeClient']/field[@name='mUploadMessage']"
		[Register ("mUploadMessage")]
		public global::Android.Webkit.IValueCallback MUploadMessage {
			get {
				if (mUploadMessage_jfieldId == IntPtr.Zero)
					mUploadMessage_jfieldId = JNIEnv.GetFieldID (class_ref, "mUploadMessage", "Landroid/webkit/ValueCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mUploadMessage_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Webkit.IValueCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mUploadMessage_jfieldId == IntPtr.Zero)
					mUploadMessage_jfieldId = JNIEnv.GetFieldID (class_ref, "mUploadMessage", "Landroid/webkit/ValueCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mUploadMessage_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/CordovaChromeClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CordovaChromeClient); }
		}

		protected CordovaChromeClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_apache_cordova_CordovaInterface_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaChromeClient']/constructor[@name='CordovaChromeClient' and count(parameter)=1 and parameter[1][@type='org.apache.cordova.CordovaInterface']]"
		[Register (".ctor", "(Lorg/apache/cordova/CordovaInterface;)V", "")]
		public CordovaChromeClient (global::Org.Apache.Cordova.ICordovaInterface p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CordovaChromeClient)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/cordova/CordovaInterface;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/cordova/CordovaInterface;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorg_apache_cordova_CordovaInterface_ == IntPtr.Zero)
				id_ctor_Lorg_apache_cordova_CordovaInterface_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/cordova/CordovaInterface;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_cordova_CordovaInterface_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_cordova_CordovaInterface_, new JValue (p0));
		}

		static IntPtr id_ctor_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaChromeClient']/constructor[@name='CordovaChromeClient' and count(parameter)=2 and parameter[1][@type='org.apache.cordova.CordovaInterface'] and parameter[2][@type='org.apache.cordova.CordovaWebView']]"
		[Register (".ctor", "(Lorg/apache/cordova/CordovaInterface;Lorg/apache/cordova/CordovaWebView;)V", "")]
		public CordovaChromeClient (global::Org.Apache.Cordova.ICordovaInterface p0, global::Org.Apache.Cordova.CordovaWebView p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CordovaChromeClient)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/cordova/CordovaInterface;Lorg/apache/cordova/CordovaWebView;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/cordova/CordovaInterface;Lorg/apache/cordova/CordovaWebView;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_ == IntPtr.Zero)
				id_ctor_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/cordova/CordovaInterface;Lorg/apache/cordova/CordovaWebView;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_cordova_CordovaInterface_Lorg_apache_cordova_CordovaWebView_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getValueCallback;
#pragma warning disable 0169
		static Delegate GetGetValueCallbackHandler ()
		{
			if (cb_getValueCallback == null)
				cb_getValueCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValueCallback);
			return cb_getValueCallback;
		}

		static IntPtr n_GetValueCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaChromeClient __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaChromeClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ValueCallback);
		}
#pragma warning restore 0169

		static IntPtr id_getValueCallback;
		public virtual global::Android.Webkit.IValueCallback ValueCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaChromeClient']/method[@name='getValueCallback' and count(parameter)=0]"
			[Register ("getValueCallback", "()Landroid/webkit/ValueCallback;", "GetGetValueCallbackHandler")]
			get {
				if (id_getValueCallback == IntPtr.Zero)
					id_getValueCallback = JNIEnv.GetMethodID (class_ref, "getValueCallback", "()Landroid/webkit/ValueCallback;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Webkit.IValueCallback> (JNIEnv.CallObjectMethod  (Handle, id_getValueCallback), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Webkit.IValueCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValueCallback", "()Landroid/webkit/ValueCallback;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_destroyLastDialog;
#pragma warning disable 0169
		static Delegate GetDestroyLastDialogHandler ()
		{
			if (cb_destroyLastDialog == null)
				cb_destroyLastDialog = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DestroyLastDialog);
			return cb_destroyLastDialog;
		}

		static void n_DestroyLastDialog (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.CordovaChromeClient __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaChromeClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DestroyLastDialog ();
		}
#pragma warning restore 0169

		static IntPtr id_destroyLastDialog;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaChromeClient']/method[@name='destroyLastDialog' and count(parameter)=0]"
		[Register ("destroyLastDialog", "()V", "GetDestroyLastDialogHandler")]
		public virtual void DestroyLastDialog ()
		{
			if (id_destroyLastDialog == IntPtr.Zero)
				id_destroyLastDialog = JNIEnv.GetMethodID (class_ref, "destroyLastDialog", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_destroyLastDialog);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroyLastDialog", "()V"));
		}

		static Delegate cb_openFileChooser_Landroid_webkit_ValueCallback_;
#pragma warning disable 0169
		static Delegate GetOpenFileChooser_Landroid_webkit_ValueCallback_Handler ()
		{
			if (cb_openFileChooser_Landroid_webkit_ValueCallback_ == null)
				cb_openFileChooser_Landroid_webkit_ValueCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OpenFileChooser_Landroid_webkit_ValueCallback_);
			return cb_openFileChooser_Landroid_webkit_ValueCallback_;
		}

		static void n_OpenFileChooser_Landroid_webkit_ValueCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaChromeClient __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaChromeClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Webkit.IValueCallback p0 = (global::Android.Webkit.IValueCallback)global::Java.Lang.Object.GetObject<global::Android.Webkit.IValueCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OpenFileChooser (p0);
		}
#pragma warning restore 0169

		static IntPtr id_openFileChooser_Landroid_webkit_ValueCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaChromeClient']/method[@name='openFileChooser' and count(parameter)=1 and parameter[1][@type='android.webkit.ValueCallback']]"
		[Register ("openFileChooser", "(Landroid/webkit/ValueCallback;)V", "GetOpenFileChooser_Landroid_webkit_ValueCallback_Handler")]
		public virtual void OpenFileChooser (global::Android.Webkit.IValueCallback p0)
		{
			if (id_openFileChooser_Landroid_webkit_ValueCallback_ == IntPtr.Zero)
				id_openFileChooser_Landroid_webkit_ValueCallback_ = JNIEnv.GetMethodID (class_ref, "openFileChooser", "(Landroid/webkit/ValueCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_openFileChooser_Landroid_webkit_ValueCallback_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openFileChooser", "(Landroid/webkit/ValueCallback;)V"), new JValue (p0));
		}

		static Delegate cb_openFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpenFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_Handler ()
		{
			if (cb_openFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_ == null)
				cb_openFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OpenFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_);
			return cb_openFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_;
		}

		static void n_OpenFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Apache.Cordova.CordovaChromeClient __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaChromeClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Webkit.IValueCallback p0 = (global::Android.Webkit.IValueCallback)global::Java.Lang.Object.GetObject<global::Android.Webkit.IValueCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OpenFileChooser (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_openFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaChromeClient']/method[@name='openFileChooser' and count(parameter)=2 and parameter[1][@type='android.webkit.ValueCallback'] and parameter[2][@type='java.lang.String']]"
		[Register ("openFileChooser", "(Landroid/webkit/ValueCallback;Ljava/lang/String;)V", "GetOpenFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_Handler")]
		public virtual void OpenFileChooser (global::Android.Webkit.IValueCallback p0, string p1)
		{
			if (id_openFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_ == IntPtr.Zero)
				id_openFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "openFileChooser", "(Landroid/webkit/ValueCallback;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_openFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openFileChooser", "(Landroid/webkit/ValueCallback;Ljava/lang/String;)V"), new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_openFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpenFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_openFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_openFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OpenFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_Ljava_lang_String_);
			return cb_openFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OpenFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Apache.Cordova.CordovaChromeClient __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaChromeClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Webkit.IValueCallback p0 = (global::Android.Webkit.IValueCallback)global::Java.Lang.Object.GetObject<global::Android.Webkit.IValueCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OpenFileChooser (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_openFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaChromeClient']/method[@name='openFileChooser' and count(parameter)=3 and parameter[1][@type='android.webkit.ValueCallback'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("openFileChooser", "(Landroid/webkit/ValueCallback;Ljava/lang/String;Ljava/lang/String;)V", "GetOpenFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void OpenFileChooser (global::Android.Webkit.IValueCallback p0, string p1, string p2)
		{
			if (id_openFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_openFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "openFileChooser", "(Landroid/webkit/ValueCallback;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_openFileChooser_Landroid_webkit_ValueCallback_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openFileChooser", "(Landroid/webkit/ValueCallback;Ljava/lang/String;Ljava/lang/String;)V"), new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_setWebView_Lorg_apache_cordova_CordovaWebView_;
#pragma warning disable 0169
		static Delegate GetSetWebView_Lorg_apache_cordova_CordovaWebView_Handler ()
		{
			if (cb_setWebView_Lorg_apache_cordova_CordovaWebView_ == null)
				cb_setWebView_Lorg_apache_cordova_CordovaWebView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWebView_Lorg_apache_cordova_CordovaWebView_);
			return cb_setWebView_Lorg_apache_cordova_CordovaWebView_;
		}

		static void n_SetWebView_Lorg_apache_cordova_CordovaWebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.CordovaChromeClient __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaChromeClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Cordova.CordovaWebView p0 = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.CordovaWebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetWebView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setWebView_Lorg_apache_cordova_CordovaWebView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='CordovaChromeClient']/method[@name='setWebView' and count(parameter)=1 and parameter[1][@type='org.apache.cordova.CordovaWebView']]"
		[Register ("setWebView", "(Lorg/apache/cordova/CordovaWebView;)V", "GetSetWebView_Lorg_apache_cordova_CordovaWebView_Handler")]
		public virtual void SetWebView (global::Org.Apache.Cordova.CordovaWebView p0)
		{
			if (id_setWebView_Lorg_apache_cordova_CordovaWebView_ == IntPtr.Zero)
				id_setWebView_Lorg_apache_cordova_CordovaWebView_ = JNIEnv.GetMethodID (class_ref, "setWebView", "(Lorg/apache/cordova/CordovaWebView;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setWebView_Lorg_apache_cordova_CordovaWebView_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWebView", "(Lorg/apache/cordova/CordovaWebView;)V"), new JValue (p0));
		}

	}
}
