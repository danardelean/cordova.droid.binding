using System;
using Org.Apache.Cordova;
using Android.Content;
using Java.Lang;
using Org.Json;

namespace Cordova.Droid.Test
{
	public class ActivityPlugin:CordovaPlugin
	{
		static string TAG = "ActivityPlugin";

		public ActivityPlugin ()
		{
		}

		public override bool Execute (string action, CordovaArgs args, CallbackContext callbackContext)
		{
			PluginResult result = new PluginResult(PluginResult.Status.Ok, "");

			try {
				if (action=="start") {
					StartActivity(args.GetString(0));
					callbackContext.SendPluginResult(result);
					callbackContext.Success();
					return true;
				}
			} catch (JSONException e) {
				result = new PluginResult(PluginResult.Status.JsonException, "JSON Exception");
				callbackContext.SendPluginResult(result);
				return false;
			}
			return false;
		}



		public void StartActivity(string className) {
			try {
				this.Cordova.Activity.StartActivity(Type.GetType(className));
			//	Intent intent = new Intent().SetClass(this.Cordova.Activity.ApplicationContext, );
				LOG.D(TAG, "Starting activity %s", className);
			//	this.Cordova.Activity.StartActivity(intent);
			} catch (System.Exception e) {
			
				LOG.E(TAG, "Error starting activity %s", className);
			}
		}
	}
}

