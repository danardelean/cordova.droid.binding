package cordova.droid.test;


public class ActivityPlugin
	extends org.apache.cordova.CordovaPlugin
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_execute:(Ljava/lang/String;Lorg/apache/cordova/CordovaArgs;Lorg/apache/cordova/CallbackContext;)Z:GetExecute_Ljava_lang_String_Lorg_apache_cordova_CordovaArgs_Lorg_apache_cordova_CallbackContext_Handler\n" +
			"";
		mono.android.Runtime.register ("Cordova.Droid.Test.ActivityPlugin, Cordova.Droid.Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ActivityPlugin.class, __md_methods);
	}


	public ActivityPlugin () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ActivityPlugin.class)
			mono.android.TypeManager.Activate ("Cordova.Droid.Test.ActivityPlugin, Cordova.Droid.Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean execute (java.lang.String p0, org.apache.cordova.CordovaArgs p1, org.apache.cordova.CallbackContext p2)
	{
		return n_execute (p0, p1, p2);
	}

	private native boolean n_execute (java.lang.String p0, org.apache.cordova.CordovaArgs p1, org.apache.cordova.CallbackContext p2);

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
