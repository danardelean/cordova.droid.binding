using System;
using Org.Apache.Cordova;

namespace Cordova.Droid.Test
{
	public class PluginStub :CordovaPlugin
	{
		public String id;
		public Object data;

		public Java.Lang.Object OnMessage(String id, Java.Lang.Object input)
		{
			this.data = input;
			return input;
		}
	}
}

