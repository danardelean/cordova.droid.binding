package cordova.droid.test;


public class PluginStub
	extends org.apache.cordova.CordovaPlugin
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Cordova.Droid.Test.PluginStub, Cordova.Droid.Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PluginStub.class, __md_methods);
	}


	public PluginStub () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PluginStub.class)
			mono.android.TypeManager.Activate ("Cordova.Droid.Test.PluginStub, Cordova.Droid.Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
