
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
using System.Drawing;


namespace Cordova.Droid.Test
{
	[Activity (Label = "Backgroundcolor")]			
	public class Backgroundcolor : CordovaActivity
	{

		public override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			base.Init ();


			// backgroundColor can also be set in cordova.xml, but you must use the number equivalent of the color.  For example, Color.RED is
			//      <preference name="backgroundColor" value="-65536" />

			Preferences.Set("backgroundColor", Color.Green.ToArgb());

			base.LoadUrl ("file:///android_asset/www/backgroundcolor/index.html");
		}
	}
}

