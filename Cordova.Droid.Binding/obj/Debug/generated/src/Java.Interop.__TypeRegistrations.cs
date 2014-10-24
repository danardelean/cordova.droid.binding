using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/squareup/okhttp/internal",
						"com/squareup/okhttp/internal/spdy",
					},
					new Converter<string, Type>[]{
						lookup_com_squareup_okhttp_internal_package,
						lookup_com_squareup_okhttp_internal_spdy_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_squareup_okhttp_internal_mappings;
		static Type lookup_com_squareup_okhttp_internal_package (string klass)
		{
			if (package_com_squareup_okhttp_internal_mappings == null) {
				package_com_squareup_okhttp_internal_mappings = new string[]{
					"com/squareup/okhttp/internal/Dns$1:Com.Squareup.Okhttp.Internal.Dns1",
				};
			}

			return Lookup (package_com_squareup_okhttp_internal_mappings, klass);
		}

		static string[] package_com_squareup_okhttp_internal_spdy_mappings;
		static Type lookup_com_squareup_okhttp_internal_spdy_package (string klass)
		{
			if (package_com_squareup_okhttp_internal_spdy_mappings == null) {
				package_com_squareup_okhttp_internal_spdy_mappings = new string[]{
					"com/squareup/okhttp/internal/spdy/IncomingStreamHandler$1:Com.Squareup.Okhttp.Internal.Spdy.IncomingStreamHandler1",
				};
			}

			return Lookup (package_com_squareup_okhttp_internal_spdy_mappings, klass);
		}
	}
}
