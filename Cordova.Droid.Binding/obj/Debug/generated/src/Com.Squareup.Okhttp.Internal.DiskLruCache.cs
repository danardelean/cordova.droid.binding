using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Squareup.Okhttp.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache']"
	[global::Android.Runtime.Register ("com/squareup/okhttp/internal/DiskLruCache", DoNotGenerateAcw=true)]
	public sealed partial class DiskLruCache : global::Java.Lang.Object, global::Java.IO.ICloseable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache.Editor']"
		[global::Android.Runtime.Register ("com/squareup/okhttp/internal/DiskLruCache$Editor", DoNotGenerateAcw=true)]
		public sealed partial class Editor : global::Java.Lang.Object {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache.Editor.FaultHidingOutputStream']"
			[global::Android.Runtime.Register ("com/squareup/okhttp/internal/DiskLruCache$Editor$FaultHidingOutputStream", DoNotGenerateAcw=true)]
			public partial class FaultHidingOutputStream : global::Java.IO.FilterOutputStream {

				protected FaultHidingOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/squareup/okhttp/internal/DiskLruCache$Editor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Editor); }
			}

			internal Editor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_abort;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache.Editor']/method[@name='abort' and count(parameter)=0]"
			[Register ("abort", "()V", "")]
			public void Abort ()
			{
				if (id_abort == IntPtr.Zero)
					id_abort = JNIEnv.GetMethodID (class_ref, "abort", "()V");
				JNIEnv.CallVoidMethod  (Handle, id_abort);
			}

			static IntPtr id_abortUnlessCommitted;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache.Editor']/method[@name='abortUnlessCommitted' and count(parameter)=0]"
			[Register ("abortUnlessCommitted", "()V", "")]
			public void AbortUnlessCommitted ()
			{
				if (id_abortUnlessCommitted == IntPtr.Zero)
					id_abortUnlessCommitted = JNIEnv.GetMethodID (class_ref, "abortUnlessCommitted", "()V");
				JNIEnv.CallVoidMethod  (Handle, id_abortUnlessCommitted);
			}

			static IntPtr id_commit;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache.Editor']/method[@name='commit' and count(parameter)=0]"
			[Register ("commit", "()V", "")]
			public void Commit ()
			{
				if (id_commit == IntPtr.Zero)
					id_commit = JNIEnv.GetMethodID (class_ref, "commit", "()V");
				JNIEnv.CallVoidMethod  (Handle, id_commit);
			}

			static IntPtr id_getString_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache.Editor']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getString", "(I)Ljava/lang/String;", "")]
			public string GetString (int p0)
			{
				if (id_getString_I == IntPtr.Zero)
					id_getString_I = JNIEnv.GetMethodID (class_ref, "getString", "(I)Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getString_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_newInputStream_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache.Editor']/method[@name='newInputStream' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("newInputStream", "(I)Ljava/io/InputStream;", "")]
			public global::System.IO.Stream NewInputStream (int p0)
			{
				if (id_newInputStream_I == IntPtr.Zero)
					id_newInputStream_I = JNIEnv.GetMethodID (class_ref, "newInputStream", "(I)Ljava/io/InputStream;");
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_newInputStream_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_newOutputStream_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache.Editor']/method[@name='newOutputStream' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("newOutputStream", "(I)Ljava/io/OutputStream;", "")]
			public global::System.IO.Stream NewOutputStream (int p0)
			{
				if (id_newOutputStream_I == IntPtr.Zero)
					id_newOutputStream_I = JNIEnv.GetMethodID (class_ref, "newOutputStream", "(I)Ljava/io/OutputStream;");
				return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_newOutputStream_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_set_ILjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache.Editor']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("set", "(ILjava/lang/String;)V", "")]
			public void Set (int p0, string p1)
			{
				if (id_set_ILjava_lang_String_ == IntPtr.Zero)
					id_set_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "set", "(ILjava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JNIEnv.CallVoidMethod  (Handle, id_set_ILjava_lang_String_, new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache.Entry']"
		[global::Android.Runtime.Register ("com/squareup/okhttp/internal/DiskLruCache$Entry", DoNotGenerateAcw=true)]
		public sealed partial class Entry : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/squareup/okhttp/internal/DiskLruCache$Entry", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Entry); }
			}

			internal Entry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getLengths;
			public string Lengths {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache.Entry']/method[@name='getLengths' and count(parameter)=0]"
				[Register ("getLengths", "()Ljava/lang/String;", "GetGetLengthsHandler")]
				get {
					if (id_getLengths == IntPtr.Zero)
						id_getLengths = JNIEnv.GetMethodID (class_ref, "getLengths", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLengths), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getCleanFile_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache.Entry']/method[@name='getCleanFile' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getCleanFile", "(I)Ljava/io/File;", "")]
			public global::Java.IO.File GetCleanFile (int p0)
			{
				if (id_getCleanFile_I == IntPtr.Zero)
					id_getCleanFile_I = JNIEnv.GetMethodID (class_ref, "getCleanFile", "(I)Ljava/io/File;");
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_getCleanFile_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_getDirtyFile_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache.Entry']/method[@name='getDirtyFile' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getDirtyFile", "(I)Ljava/io/File;", "")]
			public global::Java.IO.File GetDirtyFile (int p0)
			{
				if (id_getDirtyFile_I == IntPtr.Zero)
					id_getDirtyFile_I = JNIEnv.GetMethodID (class_ref, "getDirtyFile", "(I)Ljava/io/File;");
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_getDirtyFile_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache.Snapshot']"
		[global::Android.Runtime.Register ("com/squareup/okhttp/internal/DiskLruCache$Snapshot", DoNotGenerateAcw=true)]
		public sealed partial class Snapshot : global::Java.Lang.Object, global::Java.IO.ICloseable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/squareup/okhttp/internal/DiskLruCache$Snapshot", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Snapshot); }
			}

			internal Snapshot (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_close;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache.Snapshot']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "")]
			public void Close ()
			{
				if (id_close == IntPtr.Zero)
					id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
				JNIEnv.CallVoidMethod  (Handle, id_close);
			}

			static IntPtr id_edit;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache.Snapshot']/method[@name='edit' and count(parameter)=0]"
			[Register ("edit", "()Lcom/squareup/okhttp/internal/DiskLruCache$Editor;", "")]
			public global::Com.Squareup.Okhttp.Internal.DiskLruCache.Editor Edit ()
			{
				if (id_edit == IntPtr.Zero)
					id_edit = JNIEnv.GetMethodID (class_ref, "edit", "()Lcom/squareup/okhttp/internal/DiskLruCache$Editor;");
				return global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.DiskLruCache.Editor> (JNIEnv.CallObjectMethod  (Handle, id_edit), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_getInputStream_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache.Snapshot']/method[@name='getInputStream' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getInputStream", "(I)Ljava/io/InputStream;", "")]
			public global::System.IO.Stream GetInputStream (int p0)
			{
				if (id_getInputStream_I == IntPtr.Zero)
					id_getInputStream_I = JNIEnv.GetMethodID (class_ref, "getInputStream", "(I)Ljava/io/InputStream;");
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getInputStream_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_getLength_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache.Snapshot']/method[@name='getLength' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getLength", "(I)J", "")]
			public long GetLength (int p0)
			{
				if (id_getLength_I == IntPtr.Zero)
					id_getLength_I = JNIEnv.GetMethodID (class_ref, "getLength", "(I)J");
				return JNIEnv.CallLongMethod  (Handle, id_getLength_I, new JValue (p0));
			}

			static IntPtr id_getString_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache.Snapshot']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getString", "(I)Ljava/lang/String;", "")]
			public string GetString (int p0)
			{
				if (id_getString_I == IntPtr.Zero)
					id_getString_I = JNIEnv.GetMethodID (class_ref, "getString", "(I)Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getString_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/squareup/okhttp/internal/DiskLruCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DiskLruCache); }
		}

		internal DiskLruCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDirectory;
		public global::Java.IO.File Directory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache']/method[@name='getDirectory' and count(parameter)=0]"
			[Register ("getDirectory", "()Ljava/io/File;", "GetGetDirectoryHandler")]
			get {
				if (id_getDirectory == IntPtr.Zero)
					id_getDirectory = JNIEnv.GetMethodID (class_ref, "getDirectory", "()Ljava/io/File;");
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod  (Handle, id_getDirectory), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isClosed;
		public bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache']/method[@name='isClosed' and count(parameter)=0]"
			[Register ("isClosed", "()Z", "GetIsClosedHandler")]
			get {
				if (id_isClosed == IntPtr.Zero)
					id_isClosed = JNIEnv.GetMethodID (class_ref, "isClosed", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isClosed);
			}
		}

		static IntPtr id_getMaxSize;
		static IntPtr id_setMaxSize_J;
		public long MaxSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache']/method[@name='getMaxSize' and count(parameter)=0]"
			[Register ("getMaxSize", "()J", "GetGetMaxSizeHandler")]
			get {
				if (id_getMaxSize == IntPtr.Zero)
					id_getMaxSize = JNIEnv.GetMethodID (class_ref, "getMaxSize", "()J");
				return JNIEnv.CallLongMethod  (Handle, id_getMaxSize);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache']/method[@name='setMaxSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMaxSize", "(J)V", "GetSetMaxSize_JHandler")]
			set {
				if (id_setMaxSize_J == IntPtr.Zero)
					id_setMaxSize_J = JNIEnv.GetMethodID (class_ref, "setMaxSize", "(J)V");
				JNIEnv.CallVoidMethod  (Handle, id_setMaxSize_J, new JValue (value));
			}
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_close);
		}

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "")]
		public void Delete ()
		{
			if (id_delete == IntPtr.Zero)
				id_delete = JNIEnv.GetMethodID (class_ref, "delete", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_delete);
		}

		static IntPtr id_edit_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache']/method[@name='edit' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("edit", "(Ljava/lang/String;)Lcom/squareup/okhttp/internal/DiskLruCache$Editor;", "")]
		public global::Com.Squareup.Okhttp.Internal.DiskLruCache.Editor Edit (string p0)
		{
			if (id_edit_Ljava_lang_String_ == IntPtr.Zero)
				id_edit_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "edit", "(Ljava/lang/String;)Lcom/squareup/okhttp/internal/DiskLruCache$Editor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Squareup.Okhttp.Internal.DiskLruCache.Editor __ret = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.DiskLruCache.Editor> (JNIEnv.CallObjectMethod  (Handle, id_edit_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_flush;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "")]
		public void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_flush);
		}

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lcom/squareup/okhttp/internal/DiskLruCache$Snapshot;", "")]
		public global::Com.Squareup.Okhttp.Internal.DiskLruCache.Snapshot Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Lcom/squareup/okhttp/internal/DiskLruCache$Snapshot;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Squareup.Okhttp.Internal.DiskLruCache.Snapshot __ret = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.DiskLruCache.Snapshot> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_open_Ljava_io_File_IIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache']/method[@name='open' and count(parameter)=4 and parameter[1][@type='java.io.File'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("open", "(Ljava/io/File;IIJ)Lcom/squareup/okhttp/internal/DiskLruCache;", "")]
		public static global::Com.Squareup.Okhttp.Internal.DiskLruCache Open (global::Java.IO.File p0, int p1, int p2, long p3)
		{
			if (id_open_Ljava_io_File_IIJ == IntPtr.Zero)
				id_open_Ljava_io_File_IIJ = JNIEnv.GetStaticMethodID (class_ref, "open", "(Ljava/io/File;IIJ)Lcom/squareup/okhttp/internal/DiskLruCache;");
			global::Com.Squareup.Okhttp.Internal.DiskLruCache __ret = global::Java.Lang.Object.GetObject<global::Com.Squareup.Okhttp.Internal.DiskLruCache> (JNIEnv.CallStaticObjectMethod  (class_ref, id_open_Ljava_io_File_IIJ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_remove_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)Z", "")]
		public bool Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_remove_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.okhttp.internal']/class[@name='DiskLruCache']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()J", "")]
		public long Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_size);
		}

	}
}
