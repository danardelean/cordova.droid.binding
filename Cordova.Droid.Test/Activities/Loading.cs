
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
	[Activity (Label = "Loading")]			
	public class Loading : CordovaActivity
	{

		public override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			base.Init ();

			Preferences.Set ("loadingDialog", "Testing,Loading...");

			Config.Whitelist.AddWhiteListEntry("https://www.google.com/*", true);

			base.LoadUrl ("https://www.google.com");
		}
	}
}

