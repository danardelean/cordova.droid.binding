
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
	[Activity (Label = "Basicauth")]			
	public class Basicauth : CordovaActivity
	{

		public override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			base.Init ();


			AuthenticationToken token = new AuthenticationToken();
			token.UserName = "test";;
			token.Password="test";
			// classic webview includes port in hostname, Chromium webview does not. Handle both here.
			// BTW, the realm is optional.
			SetAuthenticationToken(token, "browserspy.dk:80", "BrowserSpy.dk - HTTP Password Test");
			SetAuthenticationToken(token, "browserspy.dk", "BrowserSpy.dk - HTTP Password Test");

			// Add web site to whitelist
			Config.Whitelist.AddWhiteListEntry("http://browserspy.dk/*", true);




			base.LoadUrl ("file:///android_asset/www/basicauth/index.html");
		}
	}
}
