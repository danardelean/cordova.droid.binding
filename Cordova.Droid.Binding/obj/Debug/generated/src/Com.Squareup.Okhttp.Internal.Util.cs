using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Squareup.Okhttp.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']"
	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/Util", DoNotGenerateAcw=true)]
	public sealed partial class Util : global::Java.Lang.Object {


		static IntPtr EMPTY_BYTE_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/field[@name='EMPTY_BYTE_ARRAY']"
		[Register ("EMPTY_BYTE_ARRAY")]
		public static IList<byte> EmptyByteArray {
			get {
				if (EMPTY_BYTE_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_BYTE_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_BYTE_ARRAY", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_BYTE_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EMPTY_BYTE_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_BYTE_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_BYTE_ARRAY", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EMPTY_BYTE_ARRAY_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EMPTY_STRING_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/field[@name='EMPTY_STRING_ARRAY']"
		[Register ("EMPTY_STRING_ARRAY")]
		public static IList<string> EmptyStringArray {
			get {
				if (EMPTY_STRING_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_STRING_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_STRING_ARRAY", "[Ljava/lang/String;");
				return JavaArray<string>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, EMPTY_STRING_ARRAY_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EMPTY_STRING_ARRAY_jfieldId == IntPtr.Zero)
					EMPTY_STRING_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_STRING_ARRAY", "[Ljava/lang/String;");
				IntPtr native_value = JavaArray<string>.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EMPTY_STRING_ARRAY_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr ISO_8859_1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/field[@name='ISO_8859_1']"
		[Register ("ISO_8859_1")]
		public static global::Java.Nio.Charset.Charset Iso88591 {
			get {
				if (ISO_8859_1_jfieldId == IntPtr.Zero)
					ISO_8859_1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO_8859_1", "Ljava/nio/charset/Charset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO_8859_1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ISO_8859_1_jfieldId == IntPtr.Zero)
					ISO_8859_1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO_8859_1", "Ljava/nio/charset/Charset;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ISO_8859_1_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr US_ASCII_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/field[@name='US_ASCII']"
		[Register ("US_ASCII")]
		public static global::Java.Nio.Charset.Charset UsAscii {
			get {
				if (US_ASCII_jfieldId == IntPtr.Zero)
					US_ASCII_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "US_ASCII", "Ljava/nio/charset/Charset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, US_ASCII_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (US_ASCII_jfieldId == IntPtr.Zero)
					US_ASCII_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "US_ASCII", "Ljava/nio/charset/Charset;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, US_ASCII_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr UTF_8_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/field[@name='UTF_8']"
		[Register ("UTF_8")]
		public static global::Java.Nio.Charset.Charset Utf8 {
			get {
				if (UTF_8_jfieldId == IntPtr.Zero)
					UTF_8_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UTF_8", "Ljava/nio/charset/Charset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UTF_8_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UTF_8_jfieldId == IntPtr.Zero)
					UTF_8_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UTF_8", "Ljava/nio/charset/Charset;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, UTF_8_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/squareup/okhttp/internal/Util", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Util); }
		}

		internal Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_checkOffsetAndCount_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='checkOffsetAndCount' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("checkOffsetAndCount", "(III)V", "")]
		public static void CheckOffsetAndCount (int p0, int p1, int p2)
		{
			if (id_checkOffsetAndCount_III == IntPtr.Zero)
				id_checkOffsetAndCount_III = JNIEnv.GetStaticMethodID (class_ref, "checkOffsetAndCount", "(III)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_checkOffsetAndCount_III, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_closeAll_Ljava_io_Closeable_Ljava_io_Closeable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='closeAll' and count(parameter)=2 and parameter[1][@type='java.io.Closeable'] and parameter[2][@type='java.io.Closeable']]"
		[Register ("closeAll", "(Ljava/io/Closeable;Ljava/io/Closeable;)V", "")]
		public static void CloseAll (global::Java.IO.ICloseable p0, global::Java.IO.ICloseable p1)
		{
			if (id_closeAll_Ljava_io_Closeable_Ljava_io_Closeable_ == IntPtr.Zero)
				id_closeAll_Ljava_io_Closeable_Ljava_io_Closeable_ = JNIEnv.GetStaticMethodID (class_ref, "closeAll", "(Ljava/io/Closeable;Ljava/io/Closeable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_closeAll_Ljava_io_Closeable_Ljava_io_Closeable_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_closeQuietly_Ljava_io_Closeable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register ("closeQuietly", "(Ljava/io/Closeable;)V", "")]
		public static void CloseQuietly (global::Java.IO.ICloseable p0)
		{
			if (id_closeQuietly_Ljava_io_Closeable_ == IntPtr.Zero)
				id_closeQuietly_Ljava_io_Closeable_ = JNIEnv.GetStaticMethodID (class_ref, "closeQuietly", "(Ljava/io/Closeable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_closeQuietly_Ljava_io_Closeable_, new JValue (p0));
		}

		static IntPtr id_closeQuietly_Ljava_net_ServerSocket_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.net.ServerSocket']]"
		[Register ("closeQuietly", "(Ljava/net/ServerSocket;)V", "")]
		public static void CloseQuietly (global::Java.Net.ServerSocket p0)
		{
			if (id_closeQuietly_Ljava_net_ServerSocket_ == IntPtr.Zero)
				id_closeQuietly_Ljava_net_ServerSocket_ = JNIEnv.GetStaticMethodID (class_ref, "closeQuietly", "(Ljava/net/ServerSocket;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_closeQuietly_Ljava_net_ServerSocket_, new JValue (p0));
		}

		static IntPtr id_closeQuietly_Ljava_net_Socket_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.net.Socket']]"
		[Register ("closeQuietly", "(Ljava/net/Socket;)V", "")]
		public static void CloseQuietly (global::Java.Net.Socket p0)
		{
			if (id_closeQuietly_Ljava_net_Socket_ == IntPtr.Zero)
				id_closeQuietly_Ljava_net_Socket_ = JNIEnv.GetStaticMethodID (class_ref, "closeQuietly", "(Ljava/net/Socket;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_closeQuietly_Ljava_net_Socket_, new JValue (p0));
		}

		static IntPtr id_copy_Ljava_io_InputStream_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("copy", "(Ljava/io/InputStream;Ljava/io/OutputStream;)I", "")]
		public static int Copy (global::System.IO.Stream p0, global::System.IO.Stream p1)
		{
			if (id_copy_Ljava_io_InputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_copy_Ljava_io_InputStream_Ljava_io_OutputStream_ = JNIEnv.GetStaticMethodID (class_ref, "copy", "(Ljava/io/InputStream;Ljava/io/OutputStream;)I");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_copy_Ljava_io_InputStream_Ljava_io_OutputStream_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_daemonThreadFactory_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='daemonThreadFactory' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("daemonThreadFactory", "(Ljava/lang/String;)Ljava/util/concurrent/ThreadFactory;", "")]
		public static global::Java.Util.Concurrent.IThreadFactory DaemonThreadFactory (string p0)
		{
			if (id_daemonThreadFactory_Ljava_lang_String_ == IntPtr.Zero)
				id_daemonThreadFactory_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "daemonThreadFactory", "(Ljava/lang/String;)Ljava/util/concurrent/ThreadFactory;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Util.Concurrent.IThreadFactory __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IThreadFactory> (JNIEnv.CallStaticObjectMethod  (class_ref, id_daemonThreadFactory_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_deleteContents_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='deleteContents' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("deleteContents", "(Ljava/io/File;)V", "")]
		public static void DeleteContents (global::Java.IO.File p0)
		{
			if (id_deleteContents_Ljava_io_File_ == IntPtr.Zero)
				id_deleteContents_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "deleteContents", "(Ljava/io/File;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_deleteContents_Ljava_io_File_, new JValue (p0));
		}

		static IntPtr id_equal_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='equal' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("equal", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public static bool Equal (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_equal_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_equal_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "equal", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_equal_Ljava_lang_Object_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static IntPtr id_getDefaultPort_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='getDefaultPort' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDefaultPort", "(Ljava/lang/String;)I", "")]
		public static int GetDefaultPort (string p0)
		{
			if (id_getDefaultPort_Ljava_lang_String_ == IntPtr.Zero)
				id_getDefaultPort_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getDefaultPort", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getDefaultPort_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getEffectivePort_Ljava_net_URI_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='getEffectivePort' and count(parameter)=1 and parameter[1][@type='java.net.URI']]"
		[Register ("getEffectivePort", "(Ljava/net/URI;)I", "")]
		public static int GetEffectivePort (global::Java.Net.URI p0)
		{
			if (id_getEffectivePort_Ljava_net_URI_ == IntPtr.Zero)
				id_getEffectivePort_Ljava_net_URI_ = JNIEnv.GetStaticMethodID (class_ref, "getEffectivePort", "(Ljava/net/URI;)I");
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getEffectivePort_Ljava_net_URI_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getEffectivePort_Ljava_net_URL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='getEffectivePort' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("getEffectivePort", "(Ljava/net/URL;)I", "")]
		public static int GetEffectivePort (global::Java.Net.URL p0)
		{
			if (id_getEffectivePort_Ljava_net_URL_ == IntPtr.Zero)
				id_getEffectivePort_Ljava_net_URL_ = JNIEnv.GetStaticMethodID (class_ref, "getEffectivePort", "(Ljava/net/URL;)I");
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getEffectivePort_Ljava_net_URL_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_hash_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='hash' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hash", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string Hash (string p0)
		{
			if (id_hash_Ljava_lang_String_ == IntPtr.Zero)
				id_hash_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hash", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hash_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_immutableList_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='immutableList' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("immutableList", "(Ljava/util/List;)Ljava/util/List;", "")]
		public static global::System.Collections.IList ImmutableList (global::System.Collections.IList p0)
		{
			if (id_immutableList_Ljava_util_List_ == IntPtr.Zero)
				id_immutableList_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "immutableList", "(Ljava/util/List;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_immutableList_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_pokeInt_arrayBIILjava_nio_ByteOrder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='pokeInt' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.nio.ByteOrder']]"
		[Register ("pokeInt", "([BIILjava/nio/ByteOrder;)V", "")]
		public static void PokeInt (byte[] p0, int p1, int p2, global::Java.Nio.ByteOrder p3)
		{
			if (id_pokeInt_arrayBIILjava_nio_ByteOrder_ == IntPtr.Zero)
				id_pokeInt_arrayBIILjava_nio_ByteOrder_ = JNIEnv.GetStaticMethodID (class_ref, "pokeInt", "([BIILjava/nio/ByteOrder;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_pokeInt_arrayBIILjava_nio_ByteOrder_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_readAsciiLine_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='readAsciiLine' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("readAsciiLine", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static string ReadAsciiLine (global::System.IO.Stream p0)
		{
			if (id_readAsciiLine_Ljava_io_InputStream_ == IntPtr.Zero)
				id_readAsciiLine_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "readAsciiLine", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_readAsciiLine_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_readFully_Ljava_io_InputStream_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='readFully' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='byte[]']]"
		[Register ("readFully", "(Ljava/io/InputStream;[B)V", "")]
		public static void ReadFully (global::System.IO.Stream p0, byte[] p1)
		{
			if (id_readFully_Ljava_io_InputStream_arrayB == IntPtr.Zero)
				id_readFully_Ljava_io_InputStream_arrayB = JNIEnv.GetStaticMethodID (class_ref, "readFully", "(Ljava/io/InputStream;[B)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_readFully_Ljava_io_InputStream_arrayB, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_readFully_Ljava_io_InputStream_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='readFully' and count(parameter)=4 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("readFully", "(Ljava/io/InputStream;[BII)V", "")]
		public static void ReadFully (global::System.IO.Stream p0, byte[] p1, int p2, int p3)
		{
			if (id_readFully_Ljava_io_InputStream_arrayBII == IntPtr.Zero)
				id_readFully_Ljava_io_InputStream_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "readFully", "(Ljava/io/InputStream;[BII)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_readFully_Ljava_io_InputStream_arrayBII, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_readFully_Ljava_io_Reader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='readFully' and count(parameter)=1 and parameter[1][@type='java.io.Reader']]"
		[Register ("readFully", "(Ljava/io/Reader;)Ljava/lang/String;", "")]
		public static string ReadFully (global::Java.IO.Reader p0)
		{
			if (id_readFully_Ljava_io_Reader_ == IntPtr.Zero)
				id_readFully_Ljava_io_Reader_ = JNIEnv.GetStaticMethodID (class_ref, "readFully", "(Ljava/io/Reader;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_readFully_Ljava_io_Reader_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_readSingleByte_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='readSingleByte' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("readSingleByte", "(Ljava/io/InputStream;)I", "")]
		public static int ReadSingleByte (global::System.IO.Stream p0)
		{
			if (id_readSingleByte_Ljava_io_InputStream_ == IntPtr.Zero)
				id_readSingleByte_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "readSingleByte", "(Ljava/io/InputStream;)I");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_readSingleByte_Ljava_io_InputStream_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_skipAll_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='skipAll' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("skipAll", "(Ljava/io/InputStream;)V", "")]
		public static void SkipAll (global::System.IO.Stream p0)
		{
			if (id_skipAll_Ljava_io_InputStream_ == IntPtr.Zero)
				id_skipAll_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "skipAll", "(Ljava/io/InputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_skipAll_Ljava_io_InputStream_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_skipByReading_Ljava_io_InputStream_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='skipByReading' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='long']]"
		[Register ("skipByReading", "(Ljava/io/InputStream;J)J", "")]
		public static long SkipByReading (global::System.IO.Stream p0, long p1)
		{
			if (id_skipByReading_Ljava_io_InputStream_J == IntPtr.Zero)
				id_skipByReading_Ljava_io_InputStream_J = JNIEnv.GetStaticMethodID (class_ref, "skipByReading", "(Ljava/io/InputStream;J)J");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_skipByReading_Ljava_io_InputStream_J, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_writeSingleByte_Ljava_io_OutputStream_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='Util']/method[@name='writeSingleByte' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='int']]"
		[Register ("writeSingleByte", "(Ljava/io/OutputStream;I)V", "")]
		public static void WriteSingleByte (global::System.IO.Stream p0, int p1)
		{
			if (id_writeSingleByte_Ljava_io_OutputStream_I == IntPtr.Zero)
				id_writeSingleByte_Ljava_io_OutputStream_I = JNIEnv.GetStaticMethodID (class_ref, "writeSingleByte", "(Ljava/io/OutputStream;I)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_writeSingleByte_Ljava_io_OutputStream_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
