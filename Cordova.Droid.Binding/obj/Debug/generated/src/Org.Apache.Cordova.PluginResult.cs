using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Cordova {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']"
	[global::Android.Runtime.Register ("org/apache/cordova/PluginResult", DoNotGenerateAcw=true)]
	public partial class PluginResult : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/field[@name='MESSAGE_TYPE_ARRAYBUFFER']"
		[Register ("MESSAGE_TYPE_ARRAYBUFFER")]
		public const int MessageTypeArraybuffer = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/field[@name='MESSAGE_TYPE_BINARYSTRING']"
		[Register ("MESSAGE_TYPE_BINARYSTRING")]
		public const int MessageTypeBinarystring = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/field[@name='MESSAGE_TYPE_BOOLEAN']"
		[Register ("MESSAGE_TYPE_BOOLEAN")]
		public const int MessageTypeBoolean = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/field[@name='MESSAGE_TYPE_JSON']"
		[Register ("MESSAGE_TYPE_JSON")]
		public const int MessageTypeJson = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/field[@name='MESSAGE_TYPE_MULTIPART']"
		[Register ("MESSAGE_TYPE_MULTIPART")]
		public const int MessageTypeMultipart = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/field[@name='MESSAGE_TYPE_NULL']"
		[Register ("MESSAGE_TYPE_NULL")]
		public const int MessageTypeNull = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/field[@name='MESSAGE_TYPE_NUMBER']"
		[Register ("MESSAGE_TYPE_NUMBER")]
		public const int MessageTypeNumber = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/field[@name='MESSAGE_TYPE_STRING']"
		[Register ("MESSAGE_TYPE_STRING")]
		public const int MessageTypeString = (int) 1;

		static IntPtr StatusMessages_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/field[@name='StatusMessages']"
		[Register ("StatusMessages")]
		public static IList<string> StatusMessages {
			get {
				if (StatusMessages_jfieldId == IntPtr.Zero)
					StatusMessages_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "StatusMessages", "[Ljava/lang/String;");
				return JavaArray<string>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, StatusMessages_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (StatusMessages_jfieldId == IntPtr.Zero)
					StatusMessages_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "StatusMessages", "[Ljava/lang/String;");
				IntPtr native_value = JavaArray<string>.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, StatusMessages_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult.Status']"
		[global::Android.Runtime.Register ("org/apache/cordova/PluginResult$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {


			static IntPtr CLASS_NOT_FOUND_EXCEPTION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult.Status']/field[@name='CLASS_NOT_FOUND_EXCEPTION']"
			[Register ("CLASS_NOT_FOUND_EXCEPTION")]
			public static global::Org.Apache.Cordova.PluginResult.Status ClassNotFoundException {
				get {
					if (CLASS_NOT_FOUND_EXCEPTION_jfieldId == IntPtr.Zero)
						CLASS_NOT_FOUND_EXCEPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLASS_NOT_FOUND_EXCEPTION", "Lorg/apache/cordova/PluginResult$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLASS_NOT_FOUND_EXCEPTION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CLASS_NOT_FOUND_EXCEPTION_jfieldId == IntPtr.Zero)
						CLASS_NOT_FOUND_EXCEPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLASS_NOT_FOUND_EXCEPTION", "Lorg/apache/cordova/PluginResult$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CLASS_NOT_FOUND_EXCEPTION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult.Status']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Org.Apache.Cordova.PluginResult.Status Error {
				get {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lorg/apache/cordova/PluginResult$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lorg/apache/cordova/PluginResult$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ERROR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ILLEGAL_ACCESS_EXCEPTION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult.Status']/field[@name='ILLEGAL_ACCESS_EXCEPTION']"
			[Register ("ILLEGAL_ACCESS_EXCEPTION")]
			public static global::Org.Apache.Cordova.PluginResult.Status IllegalAccessException {
				get {
					if (ILLEGAL_ACCESS_EXCEPTION_jfieldId == IntPtr.Zero)
						ILLEGAL_ACCESS_EXCEPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ILLEGAL_ACCESS_EXCEPTION", "Lorg/apache/cordova/PluginResult$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ILLEGAL_ACCESS_EXCEPTION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ILLEGAL_ACCESS_EXCEPTION_jfieldId == IntPtr.Zero)
						ILLEGAL_ACCESS_EXCEPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ILLEGAL_ACCESS_EXCEPTION", "Lorg/apache/cordova/PluginResult$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ILLEGAL_ACCESS_EXCEPTION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INSTANTIATION_EXCEPTION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult.Status']/field[@name='INSTANTIATION_EXCEPTION']"
			[Register ("INSTANTIATION_EXCEPTION")]
			public static global::Org.Apache.Cordova.PluginResult.Status InstantiationException {
				get {
					if (INSTANTIATION_EXCEPTION_jfieldId == IntPtr.Zero)
						INSTANTIATION_EXCEPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANTIATION_EXCEPTION", "Lorg/apache/cordova/PluginResult$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTANTIATION_EXCEPTION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INSTANTIATION_EXCEPTION_jfieldId == IntPtr.Zero)
						INSTANTIATION_EXCEPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANTIATION_EXCEPTION", "Lorg/apache/cordova/PluginResult$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INSTANTIATION_EXCEPTION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr INVALID_ACTION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult.Status']/field[@name='INVALID_ACTION']"
			[Register ("INVALID_ACTION")]
			public static global::Org.Apache.Cordova.PluginResult.Status InvalidAction {
				get {
					if (INVALID_ACTION_jfieldId == IntPtr.Zero)
						INVALID_ACTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_ACTION", "Lorg/apache/cordova/PluginResult$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_ACTION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INVALID_ACTION_jfieldId == IntPtr.Zero)
						INVALID_ACTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_ACTION", "Lorg/apache/cordova/PluginResult$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, INVALID_ACTION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr IO_EXCEPTION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult.Status']/field[@name='IO_EXCEPTION']"
			[Register ("IO_EXCEPTION")]
			public static global::Org.Apache.Cordova.PluginResult.Status IoException {
				get {
					if (IO_EXCEPTION_jfieldId == IntPtr.Zero)
						IO_EXCEPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IO_EXCEPTION", "Lorg/apache/cordova/PluginResult$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IO_EXCEPTION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (IO_EXCEPTION_jfieldId == IntPtr.Zero)
						IO_EXCEPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IO_EXCEPTION", "Lorg/apache/cordova/PluginResult$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, IO_EXCEPTION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr JSON_EXCEPTION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult.Status']/field[@name='JSON_EXCEPTION']"
			[Register ("JSON_EXCEPTION")]
			public static global::Org.Apache.Cordova.PluginResult.Status JsonException {
				get {
					if (JSON_EXCEPTION_jfieldId == IntPtr.Zero)
						JSON_EXCEPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JSON_EXCEPTION", "Lorg/apache/cordova/PluginResult$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JSON_EXCEPTION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (JSON_EXCEPTION_jfieldId == IntPtr.Zero)
						JSON_EXCEPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JSON_EXCEPTION", "Lorg/apache/cordova/PluginResult$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, JSON_EXCEPTION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr MALFORMED_URL_EXCEPTION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult.Status']/field[@name='MALFORMED_URL_EXCEPTION']"
			[Register ("MALFORMED_URL_EXCEPTION")]
			public static global::Org.Apache.Cordova.PluginResult.Status MalformedUrlException {
				get {
					if (MALFORMED_URL_EXCEPTION_jfieldId == IntPtr.Zero)
						MALFORMED_URL_EXCEPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MALFORMED_URL_EXCEPTION", "Lorg/apache/cordova/PluginResult$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MALFORMED_URL_EXCEPTION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MALFORMED_URL_EXCEPTION_jfieldId == IntPtr.Zero)
						MALFORMED_URL_EXCEPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MALFORMED_URL_EXCEPTION", "Lorg/apache/cordova/PluginResult$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MALFORMED_URL_EXCEPTION_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NO_RESULT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult.Status']/field[@name='NO_RESULT']"
			[Register ("NO_RESULT")]
			public static global::Org.Apache.Cordova.PluginResult.Status NoResult {
				get {
					if (NO_RESULT_jfieldId == IntPtr.Zero)
						NO_RESULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_RESULT", "Lorg/apache/cordova/PluginResult$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_RESULT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NO_RESULT_jfieldId == IntPtr.Zero)
						NO_RESULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_RESULT", "Lorg/apache/cordova/PluginResult$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NO_RESULT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr OK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult.Status']/field[@name='OK']"
			[Register ("OK")]
			public static global::Org.Apache.Cordova.PluginResult.Status Ok {
				get {
					if (OK_jfieldId == IntPtr.Zero)
						OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OK", "Lorg/apache/cordova/PluginResult$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (OK_jfieldId == IntPtr.Zero)
						OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OK", "Lorg/apache/cordova/PluginResult$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, OK_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/apache/cordova/PluginResult$Status", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Status); }
			}

			internal Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/apache/cordova/PluginResult$Status;", "")]
			public static global::Org.Apache.Cordova.PluginResult.Status ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/apache/cordova/PluginResult$Status;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Org.Apache.Cordova.PluginResult.Status __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult.Status']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/apache/cordova/PluginResult$Status;", "")]
			public static global::Org.Apache.Cordova.PluginResult.Status[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/apache/cordova/PluginResult$Status;");
				return (global::Org.Apache.Cordova.PluginResult.Status[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Apache.Cordova.PluginResult.Status));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/cordova/PluginResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PluginResult); }
		}

		protected PluginResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_apache_cordova_PluginResult_Status_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/constructor[@name='PluginResult' and count(parameter)=2 and parameter[1][@type='org.apache.cordova.PluginResult.Status'] and parameter[2][@type='java.util.List']]"
		[Register (".ctor", "(Lorg/apache/cordova/PluginResult$Status;Ljava/util/List;)V", "")]
		public PluginResult (global::Org.Apache.Cordova.PluginResult.Status p0, global::System.Collections.Generic.IList<global::Org.Apache.Cordova.PluginResult> p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Org.Apache.Cordova.PluginResult>.ToLocalJniHandle (p1);;
			if (GetType () != typeof (PluginResult)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/cordova/PluginResult$Status;Ljava/util/List;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/cordova/PluginResult$Status;Ljava/util/List;)V", new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Lorg_apache_cordova_PluginResult_Status_Ljava_util_List_ == IntPtr.Zero)
				id_ctor_Lorg_apache_cordova_PluginResult_Status_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/cordova/PluginResult$Status;Ljava/util/List;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_cordova_PluginResult_Status_Ljava_util_List_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_cordova_PluginResult_Status_Ljava_util_List_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Lorg_apache_cordova_PluginResult_Status_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/constructor[@name='PluginResult' and count(parameter)=2 and parameter[1][@type='org.apache.cordova.PluginResult.Status'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/apache/cordova/PluginResult$Status;Ljava/lang/String;)V", "")]
		public PluginResult (global::Org.Apache.Cordova.PluginResult.Status p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (PluginResult)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/cordova/PluginResult$Status;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/cordova/PluginResult$Status;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Lorg_apache_cordova_PluginResult_Status_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Lorg_apache_cordova_PluginResult_Status_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/cordova/PluginResult$Status;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_cordova_PluginResult_Status_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_cordova_PluginResult_Status_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Lorg_apache_cordova_PluginResult_Status_Lorg_json_JSONArray_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/constructor[@name='PluginResult' and count(parameter)=2 and parameter[1][@type='org.apache.cordova.PluginResult.Status'] and parameter[2][@type='org.json.JSONArray']]"
		[Register (".ctor", "(Lorg/apache/cordova/PluginResult$Status;Lorg/json/JSONArray;)V", "")]
		public PluginResult (global::Org.Apache.Cordova.PluginResult.Status p0, global::Org.Json.JSONArray p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PluginResult)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/cordova/PluginResult$Status;Lorg/json/JSONArray;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/cordova/PluginResult$Status;Lorg/json/JSONArray;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lorg_apache_cordova_PluginResult_Status_Lorg_json_JSONArray_ == IntPtr.Zero)
				id_ctor_Lorg_apache_cordova_PluginResult_Status_Lorg_json_JSONArray_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/cordova/PluginResult$Status;Lorg/json/JSONArray;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_cordova_PluginResult_Status_Lorg_json_JSONArray_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_cordova_PluginResult_Status_Lorg_json_JSONArray_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Lorg_apache_cordova_PluginResult_Status_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/constructor[@name='PluginResult' and count(parameter)=2 and parameter[1][@type='org.apache.cordova.PluginResult.Status'] and parameter[2][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/apache/cordova/PluginResult$Status;Lorg/json/JSONObject;)V", "")]
		public PluginResult (global::Org.Apache.Cordova.PluginResult.Status p0, global::Org.Json.JSONObject p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PluginResult)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/cordova/PluginResult$Status;Lorg/json/JSONObject;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/cordova/PluginResult$Status;Lorg/json/JSONObject;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lorg_apache_cordova_PluginResult_Status_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_ctor_Lorg_apache_cordova_PluginResult_Status_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/cordova/PluginResult$Status;Lorg/json/JSONObject;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_cordova_PluginResult_Status_Lorg_json_JSONObject_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_cordova_PluginResult_Status_Lorg_json_JSONObject_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Lorg_apache_cordova_PluginResult_Status_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/constructor[@name='PluginResult' and count(parameter)=2 and parameter[1][@type='org.apache.cordova.PluginResult.Status'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lorg/apache/cordova/PluginResult$Status;I)V", "")]
		public PluginResult (global::Org.Apache.Cordova.PluginResult.Status p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PluginResult)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/cordova/PluginResult$Status;I)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/cordova/PluginResult$Status;I)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lorg_apache_cordova_PluginResult_Status_I == IntPtr.Zero)
				id_ctor_Lorg_apache_cordova_PluginResult_Status_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/cordova/PluginResult$Status;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_cordova_PluginResult_Status_I, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_cordova_PluginResult_Status_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Lorg_apache_cordova_PluginResult_Status_F;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/constructor[@name='PluginResult' and count(parameter)=2 and parameter[1][@type='org.apache.cordova.PluginResult.Status'] and parameter[2][@type='float']]"
		[Register (".ctor", "(Lorg/apache/cordova/PluginResult$Status;F)V", "")]
		public PluginResult (global::Org.Apache.Cordova.PluginResult.Status p0, float p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PluginResult)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/cordova/PluginResult$Status;F)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/cordova/PluginResult$Status;F)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lorg_apache_cordova_PluginResult_Status_F == IntPtr.Zero)
				id_ctor_Lorg_apache_cordova_PluginResult_Status_F = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/cordova/PluginResult$Status;F)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_cordova_PluginResult_Status_F, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_cordova_PluginResult_Status_F, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Lorg_apache_cordova_PluginResult_Status_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/constructor[@name='PluginResult' and count(parameter)=2 and parameter[1][@type='org.apache.cordova.PluginResult.Status'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Lorg/apache/cordova/PluginResult$Status;Z)V", "")]
		public PluginResult (global::Org.Apache.Cordova.PluginResult.Status p0, bool p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PluginResult)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/cordova/PluginResult$Status;Z)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/cordova/PluginResult$Status;Z)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lorg_apache_cordova_PluginResult_Status_Z == IntPtr.Zero)
				id_ctor_Lorg_apache_cordova_PluginResult_Status_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/cordova/PluginResult$Status;Z)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_cordova_PluginResult_Status_Z, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_cordova_PluginResult_Status_Z, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Lorg_apache_cordova_PluginResult_Status_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/constructor[@name='PluginResult' and count(parameter)=2 and parameter[1][@type='org.apache.cordova.PluginResult.Status'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lorg/apache/cordova/PluginResult$Status;[B)V", "")]
		public PluginResult (global::Org.Apache.Cordova.PluginResult.Status p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (PluginResult)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/cordova/PluginResult$Status;[B)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/cordova/PluginResult$Status;[B)V", new JValue (p0), new JValue (native_p1));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return;
			}

			if (id_ctor_Lorg_apache_cordova_PluginResult_Status_arrayB == IntPtr.Zero)
				id_ctor_Lorg_apache_cordova_PluginResult_Status_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/cordova/PluginResult$Status;[B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_cordova_PluginResult_Status_arrayB, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_cordova_PluginResult_Status_arrayB, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Lorg_apache_cordova_PluginResult_Status_arrayBZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/constructor[@name='PluginResult' and count(parameter)=3 and parameter[1][@type='org.apache.cordova.PluginResult.Status'] and parameter[2][@type='byte[]'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Lorg/apache/cordova/PluginResult$Status;[BZ)V", "")]
		public PluginResult (global::Org.Apache.Cordova.PluginResult.Status p0, byte[] p1, bool p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (PluginResult)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/cordova/PluginResult$Status;[BZ)V", new JValue (p0), new JValue (native_p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/cordova/PluginResult$Status;[BZ)V", new JValue (p0), new JValue (native_p1), new JValue (p2));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return;
			}

			if (id_ctor_Lorg_apache_cordova_PluginResult_Status_arrayBZ == IntPtr.Zero)
				id_ctor_Lorg_apache_cordova_PluginResult_Status_arrayBZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/cordova/PluginResult$Status;[BZ)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_cordova_PluginResult_Status_arrayBZ, new JValue (p0), new JValue (native_p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_cordova_PluginResult_Status_arrayBZ, new JValue (p0), new JValue (native_p1), new JValue (p2));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Lorg_apache_cordova_PluginResult_Status_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/constructor[@name='PluginResult' and count(parameter)=1 and parameter[1][@type='org.apache.cordova.PluginResult.Status']]"
		[Register (".ctor", "(Lorg/apache/cordova/PluginResult$Status;)V", "")]
		public PluginResult (global::Org.Apache.Cordova.PluginResult.Status p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PluginResult)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/cordova/PluginResult$Status;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/cordova/PluginResult$Status;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorg_apache_cordova_PluginResult_Status_ == IntPtr.Zero)
				id_ctor_Lorg_apache_cordova_PluginResult_Status_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/cordova/PluginResult$Status;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_cordova_PluginResult_Status_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_cordova_PluginResult_Status_, new JValue (p0));
		}

		static Delegate cb_getJSONString;
#pragma warning disable 0169
		static Delegate GetGetJSONStringHandler ()
		{
			if (cb_getJSONString == null)
				cb_getJSONString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJSONString);
			return cb_getJSONString;
		}

		static IntPtr n_GetJSONString (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.PluginResult __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.JSONString);
		}
#pragma warning restore 0169

		static IntPtr id_getJSONString;
		[Obsolete (@"deprecated")]
		public virtual string JSONString {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/method[@name='getJSONString' and count(parameter)=0]"
			[Register ("getJSONString", "()Ljava/lang/String;", "GetGetJSONStringHandler")]
			get {
				if (id_getJSONString == IntPtr.Zero)
					id_getJSONString = JNIEnv.GetMethodID (class_ref, "getJSONString", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getJSONString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJSONString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getKeepCallback;
#pragma warning disable 0169
		static Delegate GetGetKeepCallbackHandler ()
		{
			if (cb_getKeepCallback == null)
				cb_getKeepCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetKeepCallback);
			return cb_getKeepCallback;
		}

		static bool n_GetKeepCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.PluginResult __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KeepCallback;
		}
#pragma warning restore 0169

		static Delegate cb_setKeepCallback_Z;
#pragma warning disable 0169
		static Delegate GetSetKeepCallback_ZHandler ()
		{
			if (cb_setKeepCallback_Z == null)
				cb_setKeepCallback_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetKeepCallback_Z);
			return cb_setKeepCallback_Z;
		}

		static void n_SetKeepCallback_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Apache.Cordova.PluginResult __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.KeepCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getKeepCallback;
		static IntPtr id_setKeepCallback_Z;
		public virtual bool KeepCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/method[@name='getKeepCallback' and count(parameter)=0]"
			[Register ("getKeepCallback", "()Z", "GetGetKeepCallbackHandler")]
			get {
				if (id_getKeepCallback == IntPtr.Zero)
					id_getKeepCallback = JNIEnv.GetMethodID (class_ref, "getKeepCallback", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getKeepCallback);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeepCallback", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/method[@name='setKeepCallback' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setKeepCallback", "(Z)V", "GetSetKeepCallback_ZHandler")]
			set {
				if (id_setKeepCallback_Z == IntPtr.Zero)
					id_setKeepCallback_Z = JNIEnv.GetMethodID (class_ref, "setKeepCallback", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setKeepCallback_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKeepCallback", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.PluginResult __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		public virtual string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMessageType;
#pragma warning disable 0169
		static Delegate GetGetMessageTypeHandler ()
		{
			if (cb_getMessageType == null)
				cb_getMessageType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMessageType);
			return cb_getMessageType;
		}

		static int n_GetMessageType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.PluginResult __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageType;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageType;
		public virtual int MessageType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/method[@name='getMessageType' and count(parameter)=0]"
			[Register ("getMessageType", "()I", "GetGetMessageTypeHandler")]
			get {
				if (id_getMessageType == IntPtr.Zero)
					id_getMessageType = JNIEnv.GetMethodID (class_ref, "getMessageType", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMessageType);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageType", "()I"));
			}
		}

		static Delegate cb_getMultipartMessagesSize;
#pragma warning disable 0169
		static Delegate GetGetMultipartMessagesSizeHandler ()
		{
			if (cb_getMultipartMessagesSize == null)
				cb_getMultipartMessagesSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMultipartMessagesSize);
			return cb_getMultipartMessagesSize;
		}

		static int n_GetMultipartMessagesSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.PluginResult __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MultipartMessagesSize;
		}
#pragma warning restore 0169

		static IntPtr id_getMultipartMessagesSize;
		public virtual int MultipartMessagesSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/method[@name='getMultipartMessagesSize' and count(parameter)=0]"
			[Register ("getMultipartMessagesSize", "()I", "GetGetMultipartMessagesSizeHandler")]
			get {
				if (id_getMultipartMessagesSize == IntPtr.Zero)
					id_getMultipartMessagesSize = JNIEnv.GetMethodID (class_ref, "getMultipartMessagesSize", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMultipartMessagesSize);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMultipartMessagesSize", "()I"));
			}
		}

		static Delegate cb_getStrMessage;
#pragma warning disable 0169
		static Delegate GetGetStrMessageHandler ()
		{
			if (cb_getStrMessage == null)
				cb_getStrMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStrMessage);
			return cb_getStrMessage;
		}

		static IntPtr n_GetStrMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.PluginResult __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StrMessage);
		}
#pragma warning restore 0169

		static IntPtr id_getStrMessage;
		public virtual string StrMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/method[@name='getStrMessage' and count(parameter)=0]"
			[Register ("getStrMessage", "()Ljava/lang/String;", "GetGetStrMessageHandler")]
			get {
				if (id_getStrMessage == IntPtr.Zero)
					id_getStrMessage = JNIEnv.GetMethodID (class_ref, "getStrMessage", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getStrMessage), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStrMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMultipartMessage_I;
#pragma warning disable 0169
		static Delegate GetGetMultipartMessage_IHandler ()
		{
			if (cb_getMultipartMessage_I == null)
				cb_getMultipartMessage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetMultipartMessage_I);
			return cb_getMultipartMessage_I;
		}

		static IntPtr n_GetMultipartMessage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Apache.Cordova.PluginResult __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMultipartMessage (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getMultipartMessage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/method[@name='getMultipartMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMultipartMessage", "(I)Lorg/apache/cordova/PluginResult;", "GetGetMultipartMessage_IHandler")]
		public virtual global::Org.Apache.Cordova.PluginResult GetMultipartMessage (int p0)
		{
			if (id_getMultipartMessage_I == IntPtr.Zero)
				id_getMultipartMessage_I = JNIEnv.GetMethodID (class_ref, "getMultipartMessage", "(I)Lorg/apache/cordova/PluginResult;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult> (JNIEnv.CallObjectMethod  (Handle, id_getMultipartMessage_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMultipartMessage", "(I)Lorg/apache/cordova/PluginResult;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatus);
			return cb_getStatus;
		}

		static int n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Apache.Cordova.PluginResult __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetStatus ();
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/method[@name='getStatus' and count(parameter)=0]"
		[Register ("getStatus", "()I", "GetGetStatusHandler")]
		public virtual int GetStatus ()
		{
			if (id_getStatus == IntPtr.Zero)
				id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_getStatus);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()I"));
		}

		static Delegate cb_toCallbackString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetToCallbackString_Ljava_lang_String_Handler ()
		{
			if (cb_toCallbackString_Ljava_lang_String_ == null)
				cb_toCallbackString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToCallbackString_Ljava_lang_String_);
			return cb_toCallbackString_Ljava_lang_String_;
		}

		static IntPtr n_ToCallbackString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.PluginResult __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ToCallbackString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toCallbackString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/method[@name='toCallbackString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toCallbackString", "(Ljava/lang/String;)Ljava/lang/String;", "GetToCallbackString_Ljava_lang_String_Handler")]
		public virtual string ToCallbackString (string p0)
		{
			if (id_toCallbackString_Ljava_lang_String_ == IntPtr.Zero)
				id_toCallbackString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "toCallbackString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toCallbackString_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toCallbackString", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_toErrorCallbackString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetToErrorCallbackString_Ljava_lang_String_Handler ()
		{
			if (cb_toErrorCallbackString_Ljava_lang_String_ == null)
				cb_toErrorCallbackString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToErrorCallbackString_Ljava_lang_String_);
			return cb_toErrorCallbackString_Ljava_lang_String_;
		}

		static IntPtr n_ToErrorCallbackString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.PluginResult __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ToErrorCallbackString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toErrorCallbackString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/method[@name='toErrorCallbackString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toErrorCallbackString", "(Ljava/lang/String;)Ljava/lang/String;", "GetToErrorCallbackString_Ljava_lang_String_Handler")]
		public virtual string ToErrorCallbackString (string p0)
		{
			if (id_toErrorCallbackString_Ljava_lang_String_ == IntPtr.Zero)
				id_toErrorCallbackString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "toErrorCallbackString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toErrorCallbackString_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toErrorCallbackString", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_toSuccessCallbackString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetToSuccessCallbackString_Ljava_lang_String_Handler ()
		{
			if (cb_toSuccessCallbackString_Ljava_lang_String_ == null)
				cb_toSuccessCallbackString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToSuccessCallbackString_Ljava_lang_String_);
			return cb_toSuccessCallbackString_Ljava_lang_String_;
		}

		static IntPtr n_ToSuccessCallbackString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Apache.Cordova.PluginResult __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Cordova.PluginResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ToSuccessCallbackString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toSuccessCallbackString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.cordova']/class[@name='PluginResult']/method[@name='toSuccessCallbackString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toSuccessCallbackString", "(Ljava/lang/String;)Ljava/lang/String;", "GetToSuccessCallbackString_Ljava_lang_String_Handler")]
		public virtual string ToSuccessCallbackString (string p0)
		{
			if (id_toSuccessCallbackString_Ljava_lang_String_ == IntPtr.Zero)
				id_toSuccessCallbackString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "toSuccessCallbackString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toSuccessCallbackString_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toSuccessCallbackString", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
