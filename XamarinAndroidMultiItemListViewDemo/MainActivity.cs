using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace XamarinAndroidMultiItemListViewDemo
{
	[Activity (Label = "XamarinAndroidMultiItemListViewDemo", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Create mockup
			List<ChatItem> list = new List<ChatItem> ();
			list.Add (new ChatItem(true, Resource.Drawable.my_avatar, "Hello!"));
			list.Add (new ChatItem(false, Resource.Drawable.your_avatar, "Hi!"));
			list.Add (new ChatItem(false, Resource.Drawable.your_avatar, "Who are you?"));
			list.Add (new ChatItem(true, Resource.Drawable.my_avatar, "Lorem ipsum dolor sit amet"));
			list.Add (new ChatItem(true, Resource.Drawable.my_avatar, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod\ntempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,\nquis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo\nconsequat. Duis aute irure dolor in reprehenderit in voluptate velit esse\ncillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non\nproident, sunt in culpa qui officia deserunt mollit anim id est laborum."));
			list.Add (new ChatItem(false, Resource.Drawable.your_avatar, "Wow!"));
			list.Add (new ChatItem(false, Resource.Drawable.your_avatar, "Greate name"));
			list.Add (new ChatItem(true, Resource.Drawable.my_avatar, "Thanks"));
			list.Add (new ChatItem(true, Resource.Drawable.my_avatar, "Bye"));
			list.Add (new ChatItem(false, Resource.Drawable.your_avatar, "Ok"));
			list.Add (new ChatItem(false, Resource.Drawable.your_avatar, "Good night"));

			var listView = FindViewById<ListView> (Resource.Id.chatListView);
			listView.Adapter = new ChatAdapter (this, list);
		}
	}
}


