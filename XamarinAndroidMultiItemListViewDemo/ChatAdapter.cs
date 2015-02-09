using System;
using Android.Widget;
using System.Collections.Generic;
using Android.App;

namespace XamarinAndroidMultiItemListViewDemo
{
	public class ChatAdapter : BaseAdapter<ChatItem>
	{
		List<ChatItem> _ListChatItem;
		Activity _Activity;

		public const int MINE_TYPE = 0;
		public const int YOURS_TYPE = 1;

		public ChatAdapter (Activity activity, List<ChatItem> listChatItem)
		{
			_Activity = activity;
			_ListChatItem = listChatItem;
		}

		#region implemented abstract members of BaseAdapter

		public override long GetItemId (int position)
		{
			return position;
		}

		public override Android.Views.View GetView (int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			var type = GetItemViewType (position);
			var item = _ListChatItem [position];
			var view = convertView;

			if (view == null) {
				if (type == MINE_TYPE) {
					view = _Activity.LayoutInflater.Inflate (Resource.Layout.my_item, null, false);
				} else {
					view = _Activity.LayoutInflater.Inflate (Resource.Layout.your_item, null, false);
				}
			}

			var content = view.FindViewById<TextView> (Resource.Id.chat_content);
			var avatar = view.FindViewById<ImageView> (Resource.Id.chat_avatar);
			content.Text = item.Content;
			avatar.SetImageResource (item.Avatar);

			return view;
		}

		public override int Count {
			get {
				return _ListChatItem.Count;
			}
		}

		#endregion

		#region implemented abstract members of BaseAdapter

		public override ChatItem this [int index] {
			get {
				return _ListChatItem [index];
			}
		}

		#endregion

		public override int ViewTypeCount {
			get {
				return 2; // 2 type of item
			}
		}

		public override int GetItemViewType (int position)
		{
			if (_ListChatItem[position].IsMine) {
				return MINE_TYPE;
			} else {
				return YOURS_TYPE;
			}
		}
	}
}

