﻿
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
	[Activity (Label = "Iframe")]			
	public class Iframe : CordovaActivity
	{

		public override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			base.Init ();

			base.LoadUrl ("file:///android_asset/www/iframe/index.html", 2000);
		}
	}
}