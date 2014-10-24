
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Org.Apache.Cordova;

namespace Cordova.Droid.Test
{
	[Activity (Label = "Splashscreen")]			
	public class Splashscreen : CordovaActivity
	{
		public override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			base.Init ();

			// Create your application here
			Preferences.Set("splashscreen", "sandy");

			base.LoadUrl ("file:///android_asset/www/splashscreen/index.html", 2000);
		}
	}
}

