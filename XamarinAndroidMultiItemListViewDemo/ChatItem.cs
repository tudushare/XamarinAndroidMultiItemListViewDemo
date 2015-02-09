using System;

namespace XamarinAndroidMultiItemListViewDemo
{
	public class ChatItem
	{
		public string Content {	get; set; }
		public int Avatar {	get; set; }
		public bool IsMine { get; set; }

		public ChatItem (bool isMine, int avatar, string content)
		{
			this.Content = content;
			this.Avatar = avatar;
			this.IsMine = isMine;
		}
	}
}

