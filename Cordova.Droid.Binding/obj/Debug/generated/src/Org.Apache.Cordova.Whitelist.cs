using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='Whitelist']"
	[global::Android.Runtime.Register ("org/apache/cordova/Whitelist", DoNotGenerateAcw=true)]
	public partial class Whitelist : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='Whitelist']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "Whitelist";
		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='Whitelist.URLPattern']"
		[global::Android.Runtime.Register ("org/apache/cordova/Whitelist$URLPattern", DoNotGenerateAcw=true)]
		public partial class URLPattern : global::Java.Lang.Object {


			static IntPtr host_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='Whitelist.URLPattern']/field[@name='host']"
			[Register ("host")]
			public global::Java.Util.Regex.Pattern Host {
				get {
					if (host_jfieldId == IntPtr.Zero)
						host_jfieldId = JNIEnv.GetFieldID (class_ref, "host", "Ljava/util/regex/Pattern;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, host_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Regex.Pattern> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (host_jfieldId == IntPtr.Zero)
						host_jfieldId = JNIEnv.GetFieldID (class_ref, "host", "Ljava/util/regex/Pattern;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, host_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr path_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='Whitelist.URLPattern']/field[@name='path']"
			[Register ("path")]
			public global::Java.Util.Regex.Pattern Path {
				get {
					if (path_jfieldId == IntPtr.Zero)
						path_jfieldId = JNIEnv.GetFieldID (class_ref, "path", "Ljava/util/regex/Pattern;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, path_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Regex.Pattern> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (path_jfieldId == IntPtr.Zero)
						path_jfieldId = JNIEnv.GetFieldID (class_ref, "path", "Ljava/util/regex/Pattern;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, path_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr port_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='Whitelist.URLPattern']/field[@name='port']"
			[Register ("port")]
			public global::Java.Lang.Integer Port {
				get {
					if (port_jfieldId == IntPtr.Zero)
						port_jfieldId = JNIEnv.GetFieldID (class_ref, "port", "Ljava/lang/Integer;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, port_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (port_jfieldId == IntPtr.Zero)
						port_jfieldId = JNIEnv.GetFieldID (class_ref, "port", "Ljava/lang/Integer;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, port_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr scheme_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='Whitelist.URLPattern']/field[@name='scheme']"
			[Register ("scheme")]
			public global::Java.Util.Regex.Pattern Scheme {
				get {
					if (scheme_jfieldId == IntPtr.Zero)
						scheme_jfieldId = JNIEnv.GetFieldID (class_ref, "scheme", "Ljava/util/regex/Pattern;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, scheme_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Regex.Pattern> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (scheme_jfieldId == IntPtr.Zero)
						scheme_jfieldId = JNIEnv.GetFieldID (class_ref, "scheme", "Ljava/util/regex/Pattern;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, scheme_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/apache/cordova/Whitelist$URLPattern", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (URLPattern); }
			}

			protected URLPattern (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='Whitelist.URLPattern']/constructor[@name='Whitelist.URLPattern' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public URLPattern (string p0, string p1, string p2, string p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);;
				IntPtr native_p1 = JNIEnv.NewString (p1);;
				IntPtr native_p2 = JNIEnv.NewString (p2);;
				IntPtr native_p3 = JNIEnv.NewString (p3);;
				if (GetType () != typeof (URLPattern)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3));
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
					JNIEnv.DeleteLocalRef (native_p3);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}

			static Delegate cb_matches_Landroid_net_Uri_;
#pragma warning disable 0169
			static Delegate GetMatches_Landroid_net_Uri_Handler ()
			{
				if (cb_matches_Landroid_net_Uri_ == null)
					cb_matches_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Matches_Landroid_net_Uri_);
				return cb_matches_Landroid_net_Uri_;
			}

			static bool n_Matches_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Apache.Cordova.Whitelist.URLPattern __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.Whitelist.URLPattern> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Matches (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_matches_Landroid_net_Uri_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='Whitelist.URLPattern']/method[@name='matches' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
			[Register ("matches", "(Landroid/net/Uri;)Z", "GetMatches_Landroid_net_Uri_Handler")]
			public virtual bool Matches (global::Android.Net.Uri p0)
			{
				if (id_matches_Landroid_net_Uri_ == IntPtr.Zero)
					id_matches_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "matches", "(Landroid/net/Uri;)Z");

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_matches_Landroid_net_Uri_, new JValue (p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "matches", "(Landroid/net/Uri;)Z"), new JValue (p0));
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/Whitelist", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Whitelist); }
		}

		protected Whitelist (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='Whitelist']/constructor[@name='Whitelist' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Whitelist () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Whitelist)) {
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

		static Delegate cb_addWhiteListEntry_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetAddWhiteListEntry_Ljava_lang_String_ZHandler ()
		{
			if (cb_addWhiteListEntry_Ljava_lang_String_Z == null)
				cb_addWhiteListEntry_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_AddWhiteListEntry_Ljava_lang_String_Z);
			return cb_addWhiteListEntry_Ljava_lang_String_Z;
		}

		static void n_AddWhiteListEntry_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Org.Apache.Cordova.Whitelist __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.Whitelist> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddWhiteListEntry (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addWhiteListEntry_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='Whitelist']/method[@name='addWhiteListEntry' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("addWhiteListEntry", "(Ljava/lang/String;Z)V", "GetAddWhiteListEntry_Ljava_lang_String_ZHandler")]
		public virtual void AddWhiteListEntry (string p0, bool p1)
		{
			if (id_addWhiteListEntry_Ljava_lang_String_Z == IntPtr.Zero)
				id_addWhiteListEntry_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "addWhiteListEntry", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addWhiteListEntry_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addWhiteListEntry", "(Ljava/lang/String;Z)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_isUrlWhiteListed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsUrlWhiteListed_Ljava_lang_String_Handler ()
		{
			if (cb_isUrlWhiteListed_Ljava_lang_String_ == null)
				cb_isUrlWhiteListed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsUrlWhiteListed_Ljava_lang_String_);
			return cb_isUrlWhiteListed_Ljava_lang_String_;
		}

		static bool n_IsUrlWhiteListed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.Whitelist __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.Whitelist> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsUrlWhiteListed (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isUrlWhiteListed_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='Whitelist']/method[@name='isUrlWhiteListed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isUrlWhiteListed", "(Ljava/lang/String;)Z", "GetIsUrlWhiteListed_Ljava_lang_String_Handler")]
		public virtual bool IsUrlWhiteListed (string p0)
		{
			if (id_isUrlWhiteListed_Ljava_lang_String_ == IntPtr.Zero)
				id_isUrlWhiteListed_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isUrlWhiteListed", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_isUrlWhiteListed_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUrlWhiteListed", "(Ljava/lang/String;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
