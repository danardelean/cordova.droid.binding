package cordova.droid.test;


public class MainActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer,
		org.apache.cordova.CordovaInterface
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_getActivity:()Landroid/app/Activity;:GetGetActivityHandler:Org.Apache.Cordova.ICordovaInterfaceInvoker, Cordova.Android.Binding\n" +
			"n_getThreadPool:()Ljava/util/concurrent/ExecutorService;:GetGetThreadPoolHandler:Org.Apache.Cordova.ICordovaInterfaceInvoker, Cordova.Android.Binding\n" +
			"n_onMessage:(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;:GetOnMessage_Ljava_lang_String_Ljava_lang_Object_Handler:Org.Apache.Cordova.ICordovaInterfaceInvoker, Cordova.Android.Binding\n" +
			"n_setActivityResultCallback:(Lorg/apache/cordova/CordovaPlugin;)V:GetSetActivityResultCallback_Lorg_apache_cordova_CordovaPlugin_Handler:Org.Apache.Cordova.ICordovaInterfaceInvoker, Cordova.Android.Binding\n" +
			"n_startActivityForResult:(Lorg/apache/cordova/CordovaPlugin;Landroid/content/Intent;I)V:GetStartActivityForResult_Lorg_apache_cordova_CordovaPlugin_Landroid_content_Intent_IHandler:Org.Apache.Cordova.ICordovaInterfaceInvoker, Cordova.Android.Binding\n" +
			"";
		mono.android.Runtime.register ("Cordova.Droid.Test.MainActivity, Cordova.Droid.Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity.class, __md_methods);
	}


	public MainActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("Cordova.Droid.Test.MainActivity, Cordova.Droid.Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public android.app.Activity getActivity ()
	{
		return n_getActivity ();
	}

	private native android.app.Activity n_getActivity ();


	public java.util.concurrent.ExecutorService getThreadPool ()
	{
		return n_getThreadPool ();
	}

	private native java.util.concurrent.ExecutorService n_getThreadPool ();


	public java.lang.Object onMessage (java.lang.String p0, java.lang.Object p1)
	{
		return n_onMessage (p0, p1);
	}

	private native java.lang.Object n_onMessage (java.lang.String p0, java.lang.Object p1);


	public void setActivityResultCallback (org.apache.cordova.CordovaPlugin p0)
	{
		n_setActivityResultCallback (p0);
	}

	private native void n_setActivityResultCallback (org.apache.cordova.CordovaPlugin p0);


	public void startActivityForResult (org.apache.cordova.CordovaPlugin p0, android.content.Intent p1, int p2)
	{
		n_startActivityForResult (p0, p1, p2);
	}

	private native void n_startActivityForResult (org.apache.cordova.CordovaPlugin p0, android.content.Intent p1, int p2);

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
