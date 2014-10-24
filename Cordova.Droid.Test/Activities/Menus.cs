
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
	[Activity (Label = "Menus")]			
	public class Menus : CordovaActivity
	{
		public override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			base.Init ();

	

			base.RegisterForContextMenu (base.AppView);

			base.LoadUrl ("file:///android_asset/www/menus/index.html", 2000);
		}

		public override bool OnCreateOptionsMenu (IMenu menu)
		{
			base.OnCreateOptionsMenu (menu);
		
			// Group, item id, order, title
			menu.Add( Menu.First,  Menu.First,  Menu.First, "Item1");
			menu.Add( Menu.First,  Menu.First + 1,  Menu.First + 1, "Item2");
			menu.Add( Menu.First,  Menu.First + 2,  Menu.First + 2, "Item3");
			return true;
		}

		public override bool OnOptionsItemSelected (IMenuItem item)
		{
			LOG.D("menus", "Item " + item.ItemId + " pressed.");
			this.AppView.LoadUrl("javascript:alert('Menu " + item.ItemId + " pressed.')");
			return base.OnOptionsItemSelected (item);
		}

		public override bool OnPrepareOptionsMenu (IMenu menu)
		{
			LOG.D("menus", "onPrepareOptionsMenu()");
			return base.OnPrepareOptionsMenu (menu);
		}

		public override void OnCreateContextMenu (IContextMenu menu, View v, IContextMenuContextMenuInfo menuInfo)
		{
			LOG.D("menus", "onCreateContextMenu()");
			menu.SetHeaderTitle("Test Context Menu");
			menu.Add(200, 200, 200, "Context Item1");
		}

		public override bool OnContextItemSelected (IMenuItem item)
		{
			this.AppView.LoadUrl("javascript:alert('Context Menu " + item.ItemId + " pressed.')");
			return true;
		}
	}
}

