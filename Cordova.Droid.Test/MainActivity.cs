using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Org.Apache.Cordova;
using System.Threading;
using Java.Util.Concurrent;

namespace Cordova.Droid.Test
{
	[Activity (Label = "Cordova.Droid.Test", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity, ICordovaInterface
	{
		private IExecutorService threadPool = Java.Util.Concurrent.Executors.NewCachedThreadPool();

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			//AddContentView

			Config.Init ();

			Config.PluginEntries.Add(new PluginEntry("Activity",new ActivityPlugin()));

			var cordovaWebView = FindViewById<CordovaWebView> (Resource.Id.cordovaView);

			cordovaWebView.Init(this, new CordovaWebViewClient(this, cordovaWebView), new CordovaChromeClient(this, cordovaWebView),
				Config.PluginEntries, Config.Whitelist, Config.ExternalWhitelist, Config.Preferences);

			cordovaWebView.LoadUrl("file:///android_asset/www/index.html");

		}

		public Java.Lang.Object OnMessage (string message, Java.Lang.Object p1)
		{
			System.Diagnostics.Debug.WriteLine("Message: "+message);
			return null;
		}


	
		public void SetActivityResultCallback (CordovaPlugin plugin)
		{
			this.SetActivityResultCallback (plugin);
		}

	
		public void StartActivityForResult (CordovaPlugin command, Intent intent, int requestCode)
		{
			this.SetActivityResultCallback(command);


//
//			// Start activity
//			super.startActivityForResult(intent, requestCode);
		}

		public Activity Activity
		{
			get{
				return this;
			}
		}

		public IExecutorService ThreadPool
		{
			get{
				return threadPool;

			}
		}
	}
}


